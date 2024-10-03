using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorEventApp
{
    public class PowerTool : IImpactDriver, INailGun, IImpactWrench, IRentEngine
    {
        private ToolInfo tool;
        public PowerTool(string newName, string newFastener, string newHandleMat, double newPrice)
        {
            tool = new ToolInfo(newName, newFastener, newHandleMat, newPrice);
        }

        void IImpactDriver.FastenerType()
        {
            Console.WriteLine("Impact Driver fastener type: " + tool.Fastener);
        }
        void IImpactDriver.PowerType()
        {
            Console.WriteLine("Impact Driver power type: " + tool.HandleOrPowerType);
        }
        void IImpactDriver.PriceTag()
        {
            Console.WriteLine("Impact Driver rent price: " + tool.RentPrice);
        }
        // end of ImpactDriver methods

        void INailGun.FastenerType()
        {
            Console.WriteLine("Nail Gun fastener type: " + tool.Fastener);
        }
        void INailGun.PowerType()
        {
            Console.WriteLine("Nail Gun power type: " + tool.HandleOrPowerType);
        }
        void INailGun.PriceTag()
        {
            Console.WriteLine("Nail Gun rent price: " + tool.RentPrice);
        }
        // end of NailGun methods

        void IImpactWrench.FastenerType()
        {
            Console.WriteLine("Impact Wrench fastener type: " + tool.Fastener);
        }
        void IImpactWrench.PowerType()
        {
            Console.WriteLine("Impact Wrench power type: " + tool.HandleOrPowerType);
        }
        void IImpactWrench.PriceTag()
        {
            Console.WriteLine("Impact Wrench rent price: " + tool.RentPrice);
        }
        // end of ImpactDriver methods

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
        } // RentEngine

        public override string ToString()
        {
            return tool.ToString();
        }
    } // PowerTool class
}
