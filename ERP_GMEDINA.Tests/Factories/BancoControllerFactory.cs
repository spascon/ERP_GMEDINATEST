using System.Web.Mvc;
using ERP_ZORZAL.Controllers;
// <copyright file="BancoControllerFactory.cs">Copyright ©  2014</copyright>

using System;
using Microsoft.Pex.Framework;

namespace ERP_ZORZAL.Controllers
{
    /// <summary>A factory for ERP_ZORZAL.Controllers.BancoController instances</summary>
    public static partial class BancoControllerFactory
    {
        /// <summary>A factory for ERP_ZORZAL.Controllers.BancoController instances</summary>
        [PexFactoryMethod(typeof(BancoController))]
        public static BancoController Create(
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
            BancoController bancoController = new BancoController();
            ((Controller)bancoController).Resolver = value_iDependencyResolver;
            ((Controller)bancoController).ActionInvoker = value_iActionInvoker;
            ((Controller)bancoController).TempDataProvider = value_iTempDataProvider;
            ((Controller)bancoController).Url = value_urlHelper;
            ((Controller)bancoController).ViewEngineCollection = value_viewEngineCollection;
            ((ControllerBase)bancoController).ControllerContext = value_controllerContext;
            ((ControllerBase)bancoController).TempData = value_tempDataDictionary;
            ((ControllerBase)bancoController).ValidateRequest = value_b;
            ((ControllerBase)bancoController).ValueProvider = value_iValueProvider;
            ((ControllerBase)bancoController).ViewData = value_viewDataDictionary;
            return bancoController;

            // TODO: Edit factory method of BancoController
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
