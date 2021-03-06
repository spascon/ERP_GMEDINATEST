using System.Web.Mvc;
using ERP_ZORZAL.Controllers;
using System;
using Microsoft.Pex.Framework;

namespace ERP_ZORZAL.Controllers
{
    /// <summary>A factory for ERP_ZORZAL.Controllers.PedidoController instances</summary>
    public static partial class PedidoControllerFactory
    {
        /// <summary>A factory for ERP_ZORZAL.Controllers.PedidoController instances</summary>
        [PexFactoryMethod(typeof(PedidoController))]
        public static PedidoController Create(
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
            PedidoController pedidoController = new PedidoController();
            ((Controller)pedidoController).Resolver = value_iDependencyResolver;
            ((Controller)pedidoController).ActionInvoker = value_iActionInvoker;
            ((Controller)pedidoController).TempDataProvider = value_iTempDataProvider;
            ((Controller)pedidoController).Url = value_urlHelper;
            ((Controller)pedidoController).ViewEngineCollection = value_viewEngineCollection;
            ((ControllerBase)pedidoController).ControllerContext = value_controllerContext;
            ((ControllerBase)pedidoController).TempData = value_tempDataDictionary;
            ((ControllerBase)pedidoController).ValidateRequest = value_b;
            ((ControllerBase)pedidoController).ValueProvider = value_iValueProvider;
            ((ControllerBase)pedidoController).ViewData = value_viewDataDictionary;
            return pedidoController;

            // TODO: Edit factory method of PedidoController
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
