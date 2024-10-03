using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorEventApp
{
    public class ToolInfo
    {
        string name; // id
        string fastener; // description
        string handleOrPowerType; // description
        double rentPrice; // fee

        public ToolInfo(string newName, string newFastener, string newHandleOrPowerType, double newPrice)
        {
            name = newName;
            fastener = newFastener;
            handleOrPowerType = newHandleOrPowerType;
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
        public string HandleOrPowerType
        {
            get { return handleOrPowerType; }
            set { handleOrPowerType = value; }
        }
        public double RentPrice
        {
            get { return rentPrice; }
            set { rentPrice = value; }
        }

        public override string ToString()
        {
            return "Tool Name: " + Name.ToString() + ", fastener: " + Fastener.ToString() + ", handle material: "
                + HandleOrPowerType.ToString() + ", rent price: " + RentPrice.ToString();
        }
    } // ToolInfo class
}
