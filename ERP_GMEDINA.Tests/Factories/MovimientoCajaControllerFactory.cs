using System.Web.Mvc;
using ERP_GMEDINA.Controllers;
using System;
using Microsoft.Pex.Framework;

namespace ERP_GMEDINA.Controllers
{
    /// <summary>A factory for ERP_GMEDINA.Controllers.MovimientoCajaController instances</summary>
    public static partial class MovimientoCajaControllerFactory
    {
        /// <summary>A factory for ERP_GMEDINA.Controllers.MovimientoCajaController instances</summary>
        [PexFactoryMethod(typeof(MovimientoCajaController))]
        public static MovimientoCajaController Create(
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
            MovimientoCajaController movimientoCajaController
               = new MovimientoCajaController();
            ((Controller)movimientoCajaController).Resolver = value_iDependencyResolver;
            ((Controller)movimientoCajaController).ActionInvoker = value_iActionInvoker;
            ((Controller)movimientoCajaController).TempDataProvider =
              value_iTempDataProvider;
            ((Controller)movimientoCajaController).Url = value_urlHelper;
            ((Controller)movimientoCajaController).ViewEngineCollection =
              value_viewEngineCollection;
            ((ControllerBase)movimientoCajaController).ControllerContext =
              value_controllerContext;
            ((ControllerBase)movimientoCajaController).TempData = value_tempDataDictionary;
            ((ControllerBase)movimientoCajaController).ValidateRequest = value_b;
            ((ControllerBase)movimientoCajaController).ValueProvider = value_iValueProvider;
            ((ControllerBase)movimientoCajaController).ViewData = value_viewDataDictionary;
            return movimientoCajaController;

            // TODO: Edit factory method of MovimientoCajaController
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
