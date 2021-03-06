using System.Web.Mvc;
using ERP_GMEDINA.Controllers;
using System;
using Microsoft.Pex.Framework;

namespace ERP_GMEDINA.Controllers
{
    /// <summary>A factory for ERP_GMEDINA.Controllers.ClienteController instances</summary>
    public static partial class ClienteControllerFactory
    {
        /// <summary>A factory for ERP_GMEDINA.Controllers.ClienteController instances</summary>
        [PexFactoryMethod(typeof(ClienteController))]
        public static ClienteController Create(
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
            ClienteController clienteController = new ClienteController();
            ((Controller)clienteController).Resolver = value_iDependencyResolver;
            ((Controller)clienteController).ActionInvoker = value_iActionInvoker;
            ((Controller)clienteController).TempDataProvider = value_iTempDataProvider;
            ((Controller)clienteController).Url = value_urlHelper;
            ((Controller)clienteController).ViewEngineCollection =
              value_viewEngineCollection;
            ((ControllerBase)clienteController).ControllerContext = value_controllerContext;
            ((ControllerBase)clienteController).TempData = value_tempDataDictionary;
            ((ControllerBase)clienteController).ValidateRequest = value_b;
            ((ControllerBase)clienteController).ValueProvider = value_iValueProvider;
            ((ControllerBase)clienteController).ViewData = value_viewDataDictionary;
            return clienteController;

            // TODO: Edit factory method of ClienteController
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
