namespace EventInterface
{
    interface IScrewdriver
    {
        void fastenerType();
        void handleType();
        void priceTag();
    }
    interface IHammer
    {
        void fastenerType();
        void handleType();
        void priceTag();
    }
    interface IWrench
    {
        void fastenerType();
        void handleType();
        void priceTag();
    }

    interface IRentEngine
    {
        double RentalEngine(string code, ToolInfo tool);
    }

    public class ToolInfo
    {
        string name; // id
        string fastener; // description
        string handleMaterial; // description
        double rentPrice; // fee

        public ToolInfo(string newName, string newHandleMat, double newPrice)
        {
            name = newName;
            handleMaterial = newHandleMat;
            rentPrice = newPrice;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Fastener
        {
            get { return fastener; }
            set { fastener = value; }
        }
        public string HandleMaterial
        {
            get { return handleMaterial; }
            set { handleMaterial = value; }
        }
        public double RentPrice
        {
            get { return rentPrice; }
            set { rentPrice = value; }
        }

        public override string ToString()
        {
            return "Tool Name: " + Name.ToString() + ", useable on: " + Fastener.ToString() + ", handle material: " + HandleMaterial.ToString() + ", rent price: " + RentPrice.ToString() + "\n";
        }
    } // ToolInfo class

    public class Tool : IScrewdriver, IHammer, IWrench, IRentEngine
    {
        private ToolInfo tool;
        public Tool(string newName, string newHandleMat, double newPrice)
        {
            tool = new ToolInfo(newName, newHandleMat, newPrice);
        }

        void IScrewdriver.fastenerType()
        {
            tool.Fastener = "screws";
            Console.WriteLine("Screwdriver fastener type: " + tool.Fastener);
        }
        void IScrewdriver.handleType()
        {
            Console.WriteLine("Screwdriver handle material: " + tool.HandleMaterial);
        }
        void IScrewdriver.priceTag()
        {
            Console.WriteLine("Screwdriver rent price: " + tool.RentPrice);
        }
        // end of Screwdriver methods
        void IHammer.fastenerType()
        {
            tool.Fastener = "nails";
            Console.WriteLine("Hammer fastener type: " + tool.Fastener);
        }
        void IHammer.handleType()
        {
            Console.WriteLine("Hammer handle material: " + tool.HandleMaterial);
        }
        void IHammer.priceTag()
        {
            Console.WriteLine("Hammer rent price: " + tool.RentPrice);
        }
        // end of Hammer methods

        void IWrench.fastenerType()
        {
            tool.Fastener = "nuts and bolts";
            Console.WriteLine("Wrench fastener type: " + tool.Fastener);
        }
        void IWrench.handleType()
        {
            Console.WriteLine("Wrench handle material: " + tool.HandleMaterial);
        }
        void IWrench.priceTag()
        {
            Console.WriteLine("Wrench rent price: " + tool.RentPrice);
        }
        // end of Wrench methods

        double IRentEngine.RentalEngine(string code, ToolInfo tool)
        {
            string rentalCode = code.ToUpper();
            if (rentalCode == "D")
            {
                this.tool.RentPrice = this.tool.RentPrice - (this.tool.RentPrice * 0.10);
            }
            else if (rentalCode == "E")
            {
                this.tool.RentPrice = this.tool.RentPrice - (this.tool.RentPrice * 0.25);
            }
            else if (rentalCode == "F")
            {
                this.tool.RentPrice = 0.00;
            }
            else if (rentalCode == "L")
            {
                this.tool.RentPrice = this.tool.RentPrice + (this.tool.RentPrice * 0.10);
            }
            else
            {
                this.tool.RentPrice = this.tool.RentPrice;
            }
            return tool.RentPrice;
        }
        public override string ToString()
        {
            return tool.ToString();
        } // Tool class
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tool Rentals");
            Console.WriteLine("------------");
            Console.WriteLine("Enter the rented tool");
            Console.WriteLine("'S' for Screwdrivers, 'H' for Hammers, 'W' Wrenches");
            string toolInput = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter handle material");
            string handleInput = Console.ReadLine();
            Console.WriteLine("Enter rent price");
            double priceInput = Convert.ToDouble(Console.ReadLine());
            string inputCode;
            if (toolInput == "S")
            {
                IScrewdriver screwdriver = new Tool("Screwdriver", handleInput, priceInput);
                Console.WriteLine("Enter Code");
                Console.WriteLine("'D' for discount, 'E' for employee, 'F' for free, 'L' for Late");
                inputCode = Console.ReadLine();
                IRentEngine.RentalEngine(inputCode, tool);
            }
            else if (toolInput == "T")
            {
                IHammer hammer = new Tool("Hammer", handleInput, priceInput);
            }
            else if (toolInput == "W")
            {
                IWrench wrench = new Tool("Wrench", handleInput, priceInput);
            }
            else
            {
                Console.WriteLine("Try Again");
                Console.WriteLine("Enter the rented tool");
                Console.WriteLine("'S' for Screwdrivers, 'H' for Hammers, 'W' Wrenches");
                toolInput = Console.ReadLine().ToUpper();
                Console.WriteLine("Enter handle material");
                handleInput = Console.ReadLine();
                Console.WriteLine("Enter rent price");
                priceInput = Convert.ToDouble(Console.ReadLine());
            }


            Console.ReadLine();
        } // Main
    } // Program class
} // namespace