using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorEventApp
{
    public class ToolService
    {
        private readonly IScrewdriver _screwdriver;
        private readonly IHammer _hammer;
        private readonly IWrench _wrench;
        private readonly IRentEngine _rentEngine;
        public ToolService(IScrewdriver screwdriver, IHammer hammer, IWrench wrench, IRentEngine rentEngine)
        {
            _screwdriver = screwdriver;
            _hammer = hammer;
            _wrench = wrench;
            _rentEngine = rentEngine;
        }
        
        public void SFastenerType()
        {
            _screwdriver.FastenerType();
        }
        public void SHandleType()
        {
            _screwdriver.HandleType();
        }
        public void SPriceTag()
        {
            _screwdriver.PriceTag();
        }
        // end of screwdriver methods

        public void HFastenerType()
        {
            _hammer.FastenerType();
        }
        public void HHandleType()
        {
            _hammer.HandleType();
        }
        public void HPriceTag()
        {
            _hammer.PriceTag();
        }
        // end of hammer methods

        public void WFastenerType()
        {
            _wrench.FastenerType();
        }
        public void WHandleType()
        {
            _wrench.HandleType();
        }
        public void WPriceTag()
        {
            _wrench.PriceTag();
        }
        // end of wrench methods

        public void RentalEngine(string code)
        {
            _rentEngine.RentalEngine(code);
        }

    }// ToolService class
} // namespace
