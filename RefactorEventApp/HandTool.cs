using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorEventApp
{
    public class HandTool : ITool
    {
        private ToolInfo tool;
        public HandTool(string newName, string newFastener, string newHandleOrPowerType, double newPrice)
        {
            tool = new ToolInfo(newName, newFastener, newHandleOrPowerType, newPrice);
        }

        void ITool.ToolName()
        {
            Console.WriteLine("Hand Tool: " + tool.Name);
        }
        void ITool.FastenerType()
        {
            Console.WriteLine(tool.Fastener);
        }
        void ITool.HandleOrPowerType()
        {
            Console.WriteLine(tool.HandleOrPowerType);
        }
        void ITool.PriceTag()
        {
            Console.WriteLine("$" + tool.RentPrice);
        }

        //void IScrewdriver.FastenerType()
        //{
        //    Console.WriteLine("Screwdriver fastener type: " + tool.Fastener);
        //}
        //void IScrewdriver.HandleType()
        //{
        //    Console.WriteLine("Screwdriver handle material: " + tool.HandleOrPowerType);
        //}
        //void IScrewdriver.PriceTag()
        //{
        //    Console.WriteLine("Screwdriver rent price: " + tool.RentPrice);
        //}
        //// end of Screwdriver methods

        //void IHammer.FastenerType()
        //{
        //    Console.WriteLine("Hammer fastener type: " + tool.Fastener);
        //}
        //void IHammer.HandleType()
        //{
        //    Console.WriteLine("Hammer handle material: " + tool.HandleOrPowerType);
        //}
        //void IHammer.PriceTag()
        //{
        //    Console.WriteLine("Hammer rent price: " + tool.RentPrice);
        //}
        //// end of Hammer methods

        //void IWrench.FastenerType()
        //{
        //    Console.WriteLine("Wrench fastener type: " + tool.Fastener);
        //}
        //void IWrench.HandleType()
        //{
        //    Console.WriteLine("Wrench handle material: " + tool.HandleOrPowerType);
        //}
        //void IWrench.PriceTag()
        //{
        //    Console.WriteLine("Wrench rent price: " + tool.RentPrice);
        //}
        //// end of Wrench methods

        //double IRentEngine.RentalEngine(string code)
        //{
        //    string rentalCode = code.ToUpper();
        //    if (rentalCode == "D")
        //    {
        //        tool.RentPrice = tool.RentPrice - (tool.RentPrice * 0.10);
        //    }
        //    else if (rentalCode == "E")
        //    {
        //        tool.RentPrice = tool.RentPrice - (tool.RentPrice * 0.25);
        //    }
        //    else if (rentalCode == "F")
        //    {
        //        tool.RentPrice = 0.00;
        //    }
        //    else if (rentalCode == "L")
        //    {
        //        tool.RentPrice = tool.RentPrice + (tool.RentPrice * 0.10);
        //    }
        //    else
        //    {
        //        tool.RentPrice = tool.RentPrice;
        //    }
        //    return tool.RentPrice;
        //} // RentEngine

        public override string ToString()
        {
            return tool.ToString();
        }
    } // Tool class
}
