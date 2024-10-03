using System;

namespace RefactorEventApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tool Rentals");
            Console.WriteLine("------------");
            Console.WriteLine("'H' for renting a hand tool, 'P' for renting a power tool");
            string toolType = Console.ReadLine().ToUpper();
            if (toolType == "H")
            {
                Console.WriteLine("Enter the rented tool");
                Console.WriteLine("'Screwdriver', 'Hammer', or 'Wrench'");
                string toolInput = Console.ReadLine();
                Console.WriteLine("Enter fastener type");
                string fastenerInput = Console.ReadLine();
                Console.WriteLine("Enter handle material");
                string handleOrPowerInput = Console.ReadLine();
                Console.WriteLine("Enter rent price");
                double priceInput = Convert.ToDouble(Console.ReadLine());

                Tool tool = new Tool(toolInput, fastenerInput, handleOrPowerInput, priceInput);
                IScrewdriver screwdriver = tool;
                IHammer hammer = tool;
                IWrench wrench = tool;
                
                if (toolInput == "Screwdriver")
                {
                    Console.WriteLine("Enter Code");
                    Console.WriteLine("'D' for discount, 'E' for employee, 'F' for free, 'L' for Late");
                    IRentEngine rentEngine1 = tool;
                    ToolService toolService = new ToolService(screwdriver, hammer, wrench, rentEngine1);
                    toolService.RentalEngine(Console.ReadLine());

                    toolService.SFastenerType();
                    toolService.SHandleType();
                    toolService.SPriceTag();
                } // if screwdriver
                else if (toolInput == "Hammer")
                {
                    Console.WriteLine("Enter Code");
                    Console.WriteLine("'D' for discount, 'E' for employee, 'F' for free, 'L' for Late");
                    IRentEngine rentEngine1 = tool;
                    ToolService toolService = new ToolService(screwdriver, hammer, wrench, rentEngine1);
                    toolService.RentalEngine(Console.ReadLine());

                    toolService.HFastenerType();
                    toolService.HHandleType();
                    toolService.HPriceTag();
                } // if hammer
                else if (toolInput == "Wrench")
                {
                    Console.WriteLine("Enter Code");
                    Console.WriteLine("'D' for discount, 'E' for employee, 'F' for free, 'L' for Late");
                    IRentEngine rentEngine1 = tool;
                    ToolService toolService = new ToolService(screwdriver, hammer, wrench, rentEngine1);
                    toolService.RentalEngine(Console.ReadLine());

                    toolService.WFastenerType();
                    toolService.WHandleType();
                    toolService.WPriceTag();
                } // if wrench

            } // hand tool if selector

            else if (toolType == "P")
            {
                Console.WriteLine("Enter the rented tool");
                Console.WriteLine("'Impact Driver', 'Nail Gun', or 'Impact Wrench'");
                string toolInput = Console.ReadLine();
                Console.WriteLine("Enter fastener type");
                string fastenerInput = Console.ReadLine();
                Console.WriteLine("Enter power type");
                string handleOrPowerInput = Console.ReadLine();
                Console.WriteLine("Enter rent price");
                double priceInput = Convert.ToDouble(Console.ReadLine());

                PowerTool powerTool = new PowerTool(toolInput, fastenerInput, handleOrPowerInput, priceInput);
                IImpactDriver impactDriver = powerTool;
                INailGun nailGun = powerTool;
                IImpactWrench impactWrench = powerTool;
                
                if (toolInput == "Impact Driver")
                {
                    Console.WriteLine("Enter Code");
                    Console.WriteLine("'D' for discount, 'E' for employee, 'F' for free, 'L' for Late");
                    IRentEngine rentEngine2 = powerTool;
                    PowerToolService powerToolService = new PowerToolService(impactDriver, nailGun, impactWrench, rentEngine2);
                    powerToolService.RentalEngine(Console.ReadLine());

                    powerToolService.IDFastenerType();
                    powerToolService.IDPowerType();
                    powerToolService.IDPriceTag();
                } // if impact driver
                else if (toolInput == "Nail Gun")
                {
                    Console.WriteLine("Enter Code");
                    Console.WriteLine("'D' for discount, 'E' for employee, 'F' for free, 'L' for Late");
                    IRentEngine rentEngine2 = powerTool;
                    PowerToolService powerToolService = new PowerToolService(impactDriver, nailGun, impactWrench, rentEngine2);
                    powerToolService.RentalEngine(Console.ReadLine());

                    powerToolService.NGFastenerType();
                    powerToolService.NGPowerType();
                    powerToolService.NGPriceTag();
                } // if nail gun
                else if (toolInput == "Impact Wrench")
                {
                    Console.WriteLine("Enter Code");
                    Console.WriteLine("'D' for discount, 'E' for employee, 'F' for free, 'L' for Late");
                    IRentEngine rentEngine2 = powerTool;
                    PowerToolService powerToolService = new PowerToolService(impactDriver, nailGun, impactWrench, rentEngine2);
                    powerToolService.RentalEngine(Console.ReadLine());

                    powerToolService.IWFastenerType();
                    powerToolService.IWPowerType();
                    powerToolService.IWPriceTag();
                } // if impact wrench

            } // power tool else if selector


        } // Main
    } // Program class
} // namespace