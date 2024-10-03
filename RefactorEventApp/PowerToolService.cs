using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorEventApp
{
    public class PowerToolService
    {
        private readonly IImpactDriver _impactDriver;
        private readonly INailGun _nailGun;
        private readonly IImpactWrench _impactWrench;
        private readonly IRentEngine _rentEngine;
        public PowerToolService(IImpactDriver impactDriver, INailGun nailGun, IImpactWrench impactWrench, IRentEngine rentEngine)
        {
            _impactDriver = impactDriver;
            _nailGun = nailGun;
            _impactWrench = impactWrench;
            _rentEngine = rentEngine;
        }
        
        public void IDFastenerType()
        {
            _impactDriver.FastenerType();
        }
        public void IDPowerType()
        {
            _impactDriver.PowerType();
        }
        public void IDPriceTag()
        {
            _impactDriver.PriceTag();
        }
        // end of impact driver methods

        public void NGFastenerType()
        {
            _nailGun.FastenerType();
        }
        public void NGPowerType()
        {
            _nailGun.PowerType();
        }
        public void NGPriceTag()
        {
            _nailGun.PriceTag();
        }
        // end of nail gun methods

        public void IWFastenerType()
        {
            _impactWrench.FastenerType();
        }
        public void IWPowerType()
        {
            _impactWrench.PowerType();
        }
        public void IWPriceTag()
        {
            _impactWrench.PriceTag();
        }
        // end of impact wrench methods

        public void RentalEngine(string code)
        {
            _rentEngine.RentalEngine(code);
        }

    } // PowerToolService class
} // namespace
