using RFIDSystemTest.Business.Implementations.Competitors;
using RFIDSystemTest.Business.Implementations.States;
using RFIDSystemTest.Business.Interfaces.Competitors;
using RFIDSystemTest.Business.Interfaces.States;
using RFIDSystemTest.Warriror;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.App_Start
{
    /// <summary>
    /// Ninject Bindings
    /// </summary>
    public class NinjectBindings : Ninject.Modules.NinjectModule
    {
        /// <summary>
        /// Load the bindings
        /// </summary>
        public override void Load()
        {
            Bind<IHttpService>().To<HttpService>();
            Bind<IKitStateService>().To<KitStateService>();
            Bind<ICompetitorService>().To<CompetitorService>();
        }// End of Load function

    }// End of NinjectBindings class
}
