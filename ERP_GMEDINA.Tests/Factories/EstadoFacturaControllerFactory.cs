using System.Web.Mvc;
using Inspinia_MVC5_SeedProject.Controllers;
// <copyright file="EstadoFacturaControllerFactory.cs">Copyright ©  2014</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Inspinia_MVC5_SeedProject.Controllers
{
    /// <summary>A factory for Inspinia_MVC5_SeedProject.Controllers.EstadoFacturaController instances</summary>
    public static partial class EstadoFacturaControllerFactory
    {
        /// <summary>A factory for Inspinia_MVC5_SeedProject.Controllers.EstadoFacturaController instances</summary>
        [PexFactoryMethod(typeof(EstadoFacturaController))]
        public static EstadoFacturaController Create(
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
            EstadoFacturaController estadoFacturaController = new EstadoFacturaController();
            ((Controller)estadoFacturaController).Resolver = value_iDependencyResolver;
            ((Controller)estadoFacturaController).ActionInvoker = value_iActionInvoker;
            ((Controller)estadoFacturaController).TempDataProvider = value_iTempDataProvider;
            ((Controller)estadoFacturaController).Url = value_urlHelper;
            ((Controller)estadoFacturaController).ViewEngineCollection =
              value_viewEngineCollection;
            ((ControllerBase)estadoFacturaController).ControllerContext =
              value_controllerContext;
            ((ControllerBase)estadoFacturaController).TempData = value_tempDataDictionary;
            ((ControllerBase)estadoFacturaController).ValidateRequest = value_b;
            ((ControllerBase)estadoFacturaController).ValueProvider = value_iValueProvider;
            ((ControllerBase)estadoFacturaController).ViewData = value_viewDataDictionary;
            return estadoFacturaController;

            // TODO: Edit factory method of EstadoFacturaController
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
