namespace EventInterface
{
    public interface IScrewdriver
    {
        void FastenerType();
        void HandleType();
        void PriceTag();
    }
    public interface IHammer
    {
        void FastenerType();
        void HandleType();
        void PriceTag();
    }
    public interface IWrench
    {
        void FastenerType();
        void HandleType();
        void PriceTag();
    }

    public interface IRentEngine
    {
        double RentalEngine(string code);
    }

    public class ToolInfo
    {
        string name; // id
        string fastener; // description
        string handleMaterial; // description
        double rentPrice; // fee

        public ToolInfo(string newName, string newFastener, string newHandleMat, double newPrice)
        {
            name = newName;
            fastener = newFastener;
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
            return "Tool Name: " + Name.ToString() + ", fastener: " + Fastener.ToString() + ", handle material: " 
                + HandleMaterial.ToString() + ", rent price: " + RentPrice.ToString();
        }
    } // ToolInfo class

    public class Tool : IScrewdriver, IHammer, IWrench, IRentEngine
    {
        private ToolInfo tool;
        public Tool(string newName, string newFastener, string newHandleMat, double newPrice)
        {
            tool = new ToolInfo(newName, newFastener, newHandleMat, newPrice);
        }

        void IScrewdriver.FastenerType()
        {
            Console.WriteLine("Screwdriver fastener type: " + tool.Fastener);
        }
        void IScrewdriver.HandleType()
        {
            Console.WriteLine("Screwdriver handle material: " + tool.HandleMaterial);
        }
        void IScrewdriver.PriceTag()
        {
            Console.WriteLine("Screwdriver rent price: " + tool.RentPrice);
        }
        // end of Screwdriver methods
        void IHammer.FastenerType()
        {
            Console.WriteLine("Hammer fastener type: " + tool.Fastener);
        }
        void IHammer.HandleType()
        {
            Console.WriteLine("Hammer handle material: " + tool.HandleMaterial);
        }
        void IHammer.PriceTag()
        {
            Console.WriteLine("Hammer rent price: " + tool.RentPrice);
        }
        // end of Hammer methods

        void IWrench.FastenerType()
        {
            Console.WriteLine("Wrench fastener type: " + tool.Fastener);
        }
        void IWrench.HandleType()
        {
            Console.WriteLine("Wrench handle material: " + tool.HandleMaterial);
        }
        void IWrench.PriceTag()
        {
            Console.WriteLine("Wrench rent price: " + tool.RentPrice);
        }
        // end of Wrench methods

        double IRentEngine.RentalEngine(string code)
        {
            string rentalCode = code.ToUpper();
            if (rentalCode == "D")
            {
                tool.RentPrice = tool.RentPrice - (tool.RentPrice * 0.10);
            }
            else if (rentalCode == "E")
            {
                tool.RentPrice = tool.RentPrice - (tool.RentPrice * 0.25);
            }
            else if (rentalCode == "F")
            {
                tool.RentPrice = 0.00;
            }
            else if (rentalCode == "L")
            {
                tool.RentPrice = tool.RentPrice + (tool.RentPrice * 0.10);
            }
            else
            {
                tool.RentPrice = tool.RentPrice;
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
            Console.WriteLine("'Screwdriver', 'Hammer', or 'Wrench'");
            string toolInput = Console.ReadLine();
            Console.WriteLine("Enter fastener type");
            string fastenerInput = Console.ReadLine();
            Console.WriteLine("Enter handle material");
            string handleInput = Console.ReadLine();
            Console.WriteLine("Enter rent price");
            double priceInput = Convert.ToDouble(Console.ReadLine());
            
            Tool tool = new Tool(toolInput, fastenerInput, handleInput, priceInput);
            IScrewdriver screwdriver;
            IHammer hammer;
            IWrench wrench;
            if (toolInput == "Screwdriver")
            {
                screwdriver = tool;
                Console.WriteLine("Enter Code");
                Console.WriteLine("'D' for discount, 'E' for employee, 'F' for free, 'L' for Late");
                IRentEngine RentEngine = (IRentEngine)screwdriver;
                RentEngine.RentalEngine(Console.ReadLine());

                Console.WriteLine(screwdriver);
            }
            else if (toolInput == "Hammer")
            {
                hammer = tool;
                Console.WriteLine("Enter Code");
                Console.WriteLine("'D' for discount, 'E' for employee, 'F' for free, 'L' for Late");
                IRentEngine RentEngine = (IRentEngine)hammer;
                RentEngine.RentalEngine(Console.ReadLine());

                Console.WriteLine(hammer);
            }
            else if (toolInput == "Wrench")
            {
                wrench = tool;
                Console.WriteLine("Enter Code");
                Console.WriteLine("'D' for discount, 'E' for employee, 'F' for free, 'L' for Late");
                IRentEngine RentEngine = (IRentEngine)wrench;
                RentEngine.RentalEngine(Console.ReadLine());

                Console.WriteLine(wrench);
            }
        } // Main
    } // Program class
} // namespace