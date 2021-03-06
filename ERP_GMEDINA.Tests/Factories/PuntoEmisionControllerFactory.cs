using System.Web.Mvc;
using ERP_ZORZAL.Controllers;
using System;
using Microsoft.Pex.Framework;

namespace ERP_ZORZAL.Controllers
{
    /// <summary>A factory for ERP_ZORZAL.Controllers.PuntoEmisionController instances</summary>
    public static partial class PuntoEmisionControllerFactory
    {
        /// <summary>A factory for ERP_ZORZAL.Controllers.PuntoEmisionController instances</summary>
        [PexFactoryMethod(typeof(PuntoEmisionController))]
        public static PuntoEmisionController Create(
            IDependencyResolver value_iDependencyResolver,
            IActionInvoker value_iActionInvoker,
            ITempDataProvider value_iTempDataProvider,
            UrlHelper value_urlHelper,
            ViewEngineCollection value_viewEngineCollection,
            ControllerContext value_controllerContext,
            TempDataDictionary value_tempDataDictionary,
            bool value_b,
            IValueProvider value_iValueProvider,
            ViewDataDictionary value_viewDataDictionary
        )
        {
            PuntoEmisionController puntoEmisionController = new PuntoEmisionController();
            ((Controller)puntoEmisionController).Resolver = value_iDependencyResolver;
            ((Controller)puntoEmisionController).ActionInvoker = value_iActionInvoker;
            ((Controller)puntoEmisionController).TempDataProvider = value_iTempDataProvider;
            ((Controller)puntoEmisionController).Url = value_urlHelper;
            ((Controller)puntoEmisionController).ViewEngineCollection =
              value_viewEngineCollection;
            ((ControllerBase)puntoEmisionController).ControllerContext =
              value_controllerContext;
            ((ControllerBase)puntoEmisionController).TempData = value_tempDataDictionary;
            ((ControllerBase)puntoEmisionController).ValidateRequest = value_b;
            ((ControllerBase)puntoEmisionController).ValueProvider = value_iValueProvider;
            ((ControllerBase)puntoEmisionController).ViewData = value_viewDataDictionary;
            return puntoEmisionController;

            // TODO: Edit factory method of PuntoEmisionController
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
