using System.Web.Routing;
using System.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using ERP_ZORZAL.Controllers;
using Microsoft.Pex.Framework.Generated;
// <copyright file="SolicitudCreditoControllerTest.IndexSolicitudTest.g.cs">Copyright ©  2014</copyright>
// <auto-generated>
// Este archivo contiene pruebas generadas automáticamente.
// No modifique el archivo manualmente.
// 
// Si el contenido del archivo se queda obsoleto, puede eliminarlo.
// Por ejemplo, si ya no se compila.
// </auto-generated>
using System;

namespace ERP_ZORZAL.Controllers.Tests
{
    public partial class SolicitudCreditoControllerTest
    {


[TestMethod]
[PexGeneratedBy(typeof(SolicitudCreditoControllerTest))]
public void SolicitudCredito_Index()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      RouteData routeData;
      SolicitudCreditoController solicitudCreditoController;
      ActionResult actionResult;
      routeData = new RouteData((RouteBase)null, (IRouteHandler)null);
      ControllerContext s0 = new ControllerContext();
      s0.Controller = (ControllerBase)null;
      s0.HttpContext = (HttpContextBase)null;
      s0.RequestContext = (RequestContext)null;
      s0.RouteData = routeData;
      solicitudCreditoController = new SolicitudCreditoController();
      ((Controller)solicitudCreditoController).Resolver = (IDependencyResolver)null;
      ((Controller)solicitudCreditoController).ActionInvoker = (IActionInvoker)null;
      ((Controller)solicitudCreditoController).TempDataProvider =
        (ITempDataProvider)null;
      ((Controller)solicitudCreditoController).Url = (UrlHelper)null;
      ((Controller)solicitudCreditoController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)solicitudCreditoController).ControllerContext = s0;
      ((ControllerBase)solicitudCreditoController).TempData =
        (TempDataDictionary)null;
      ((ControllerBase)solicitudCreditoController).ValidateRequest = false;
      ((ControllerBase)solicitudCreditoController).ValueProvider =
        (IValueProvider)null;
      ((ControllerBase)solicitudCreditoController).ViewData =
        (ViewDataDictionary)null;
      disposables.Add((IDisposable)solicitudCreditoController);
      actionResult = this.IndexSolicitudTest(solicitudCreditoController);
      disposables.Dispose();
      Assert.IsNotNull((object)solicitudCreditoController);
      Assert.IsNotNull(((Controller)solicitudCreditoController).AsyncManager);
      Assert.IsNotNull(((Controller)solicitudCreditoController).AsyncManager
                         .OutstandingOperations);
      Assert.IsNotNull
          (((Controller)solicitudCreditoController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)solicitudCreditoController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)solicitudCreditoController).Url);
      Assert.IsNotNull
          (((ControllerBase)solicitudCreditoController).ControllerContext);
      Assert.IsNull
          (((ControllerBase)solicitudCreditoController).ControllerContext.Controller
          );
      Assert.AreEqual<bool>
          (false, ((ControllerBase)solicitudCreditoController).ValidateRequest);
    }
}
    }
}
