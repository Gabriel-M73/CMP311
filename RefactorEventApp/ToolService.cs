using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorEventApp
{
    public class ToolService
    {
        private readonly ITool _tool;

        //private readonly IScrewdriver _screwdriver;
        //private readonly IHammer _hammer;
        //private readonly IWrench _wrench;
        //private readonly IRentEngine _rentEngine;
        public ToolService(ITool tool)
        {
            _tool = tool;
        }

        public void ToolName()
        {
            _tool.ToolName();
        }
        public void FastenerType()
        {
            _tool.FastenerType();
        }
        public void HandleOrPowerType()
        {
            _tool.HandleOrPowerType();
        }
        public void PriceTag()
        {
            _tool.PriceTag();
        }

        //public void SFastenerType()
        //{
        //    _screwdriver.FastenerType();
        //}
        //public void SHandleType()
        //{
        //    _screwdriver.HandleType();
        //}
        //public void SPriceTag()
        //{
        //    _screwdriver.PriceTag();
        //}
        //// end of screwdriver methods

        //public void HFastenerType()
        //{
        //    _hammer.FastenerType();
        //}
        //public void HHandleType()
        //{
        //    _hammer.HandleType();
        //}
        //public void HPriceTag()
        //{
        //    _hammer.PriceTag();
        //}
        //// end of hammer methods

        //public void WFastenerType()
        //{
        //    _wrench.FastenerType();
        //}
        //public void WHandleType()
        //{
        //    _wrench.HandleType();
        //}
        //public void WPriceTag()
        //{
        //    _wrench.PriceTag();
        //}
        //// end of wrench methods

        //public void RentalEngine(string code)
        //{
        //    _rentEngine.RentalEngine(code);
        //}

    }// ToolService class
} // namespace
