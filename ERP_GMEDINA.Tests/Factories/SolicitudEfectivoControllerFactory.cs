using System.Web.Mvc;
using ERP_GMEDINA.Controllers;
using System;
using Microsoft.Pex.Framework;

namespace ERP_GMEDINA.Controllers
{
    /// <summary>A factory for ERP_GMEDINA.Controllers.SolicitudEfectivoController instances</summary>
    public static partial class SolicitudEfectivoControllerFactory
    {
        /// <summary>A factory for ERP_GMEDINA.Controllers.SolicitudEfectivoController instances</summary>
        [PexFactoryMethod(typeof(SolicitudEfectivoController))]
        public static SolicitudEfectivoController Create(
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
            SolicitudEfectivoController solicitudEfectivoController
               = new SolicitudEfectivoController();
            ((Controller)solicitudEfectivoController).Resolver = value_iDependencyResolver;
            ((Controller)solicitudEfectivoController).ActionInvoker = value_iActionInvoker;
            ((Controller)solicitudEfectivoController).TempDataProvider =
              value_iTempDataProvider;
            ((Controller)solicitudEfectivoController).Url = value_urlHelper;
            ((Controller)solicitudEfectivoController).ViewEngineCollection =
              value_viewEngineCollection;
            ((ControllerBase)solicitudEfectivoController).ControllerContext =
              value_controllerContext;
            ((ControllerBase)solicitudEfectivoController).TempData =
              value_tempDataDictionary;
            ((ControllerBase)solicitudEfectivoController).ValidateRequest = value_b;
            ((ControllerBase)solicitudEfectivoController).ValueProvider =
              value_iValueProvider;
            ((ControllerBase)solicitudEfectivoController).ViewData =
              value_viewDataDictionary;
            return solicitudEfectivoController;

            // TODO: Edit factory method of SolicitudEfectivoController
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
