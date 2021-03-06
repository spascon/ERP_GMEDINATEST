using System.Web.Mvc;
using ERP_ZORZAL.Controllers;
// <copyright file="CuentaBancoControllerFactory.cs">Copyright ©  2014</copyright>

using System;
using Microsoft.Pex.Framework;

namespace ERP_ZORZAL.Controllers
{
    /// <summary>A factory for ERP_ZORZAL.Controllers.CuentaBancoController instances</summary>
    public static partial class CuentaBancoControllerFactory
    {
        /// <summary>A factory for ERP_ZORZAL.Controllers.CuentaBancoController instances</summary>
        [PexFactoryMethod(typeof(CuentaBancoController))]
        public static CuentaBancoController Create(
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
            CuentaBancoController cuentaBancoController = new CuentaBancoController();
            ((Controller)cuentaBancoController).Resolver = value_iDependencyResolver;
            ((Controller)cuentaBancoController).ActionInvoker = value_iActionInvoker;
            ((Controller)cuentaBancoController).TempDataProvider = value_iTempDataProvider;
            ((Controller)cuentaBancoController).Url = value_urlHelper;
            ((Controller)cuentaBancoController).ViewEngineCollection =
              value_viewEngineCollection;
            ((ControllerBase)cuentaBancoController).ControllerContext =
              value_controllerContext;
            ((ControllerBase)cuentaBancoController).TempData = value_tempDataDictionary;
            ((ControllerBase)cuentaBancoController).ValidateRequest = value_b;
            ((ControllerBase)cuentaBancoController).ValueProvider = value_iValueProvider;
            ((ControllerBase)cuentaBancoController).ViewData = value_viewDataDictionary;
            return cuentaBancoController;

            // TODO: Edit factory method of CuentaBancoController
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
