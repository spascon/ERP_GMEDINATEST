using System.Collections.Generic;
using System.Web.Routing;
using System.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP_GMEDINA.Models;
using System.Web.Mvc;
using ERP_ZORZAL.Controllers;
using Microsoft.Pex.Framework.Generated;
// <copyright file="TipoPagoControllerTest.EditTest01.g.cs">Copyright ©  2014</copyright>
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
    public partial class TipoPagoControllerTest
    {

[TestMethod]
[PexGeneratedBy(typeof(TipoPagoControllerTest))]
public void EditTest01188()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      TipoPagoController tipoPagoController;
      ActionResult actionResult;
      tipoPagoController = new TipoPagoController();
      ((Controller)tipoPagoController).Resolver = (IDependencyResolver)null;
      ((Controller)tipoPagoController).ActionInvoker = (IActionInvoker)null;
      ((Controller)tipoPagoController).TempDataProvider = (ITempDataProvider)null;
      ((Controller)tipoPagoController).Url = (UrlHelper)null;
      ((Controller)tipoPagoController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)tipoPagoController).ControllerContext =
        (ControllerContext)null;
      ((ControllerBase)tipoPagoController).TempData = (TempDataDictionary)null;
      ((ControllerBase)tipoPagoController).ValidateRequest = false;
      ((ControllerBase)tipoPagoController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)tipoPagoController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)tipoPagoController);
      actionResult = this.EditTest01(tipoPagoController, (tbTipoPago)null);
      disposables.Dispose();
      Assert.IsNotNull((object)tipoPagoController);
      Assert.IsNotNull(((Controller)tipoPagoController).AsyncManager);
      Assert.IsNotNull
          (((Controller)tipoPagoController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)tipoPagoController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)tipoPagoController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)tipoPagoController).Url);
      Assert.IsNull(((ControllerBase)tipoPagoController).ControllerContext);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)tipoPagoController).ValidateRequest);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(TipoPagoControllerTest))]
public void EditTest0199()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      TipoPagoController tipoPagoController;
      ActionResult actionResult;
      ControllerContext s0 = new ControllerContext();
      s0.Controller = (ControllerBase)null;
      s0.HttpContext = (HttpContextBase)null;
      s0.RequestContext = (RequestContext)null;
      s0.RouteData = (RouteData)null;
      tipoPagoController = new TipoPagoController();
      ((Controller)tipoPagoController).Resolver = (IDependencyResolver)null;
      ((Controller)tipoPagoController).ActionInvoker = (IActionInvoker)null;
      ((Controller)tipoPagoController).TempDataProvider = (ITempDataProvider)null;
      ((Controller)tipoPagoController).Url = (UrlHelper)null;
      ((Controller)tipoPagoController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)tipoPagoController).ControllerContext = s0;
      ((ControllerBase)tipoPagoController).TempData = (TempDataDictionary)null;
      ((ControllerBase)tipoPagoController).ValidateRequest = false;
      ((ControllerBase)tipoPagoController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)tipoPagoController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)tipoPagoController);
      actionResult = this.EditTest01(tipoPagoController, (tbTipoPago)null);
      disposables.Dispose();
      Assert.IsNotNull((object)tipoPagoController);
      Assert.IsNotNull(((Controller)tipoPagoController).AsyncManager);
      Assert.IsNotNull
          (((Controller)tipoPagoController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)tipoPagoController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)tipoPagoController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)tipoPagoController).Url);
      Assert.IsNotNull(((ControllerBase)tipoPagoController).ControllerContext);
      Assert.IsNull
          (((ControllerBase)tipoPagoController).ControllerContext.Controller);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)tipoPagoController).ValidateRequest);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(TipoPagoControllerTest))]
public void EditTest019901()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      TipoPagoController tipoPagoController;
      ActionResult actionResult;
      ControllerContext s0 = new ControllerContext();
      s0.Controller = (ControllerBase)null;
      s0.HttpContext = (HttpContextBase)null;
      RequestContext s1 = new RequestContext();
      s1.HttpContext = (HttpContextBase)null;
      s1.RouteData = (RouteData)null;
      s0.RequestContext = s1;
      s0.RouteData = (RouteData)null;
      tipoPagoController = new TipoPagoController();
      ((Controller)tipoPagoController).Resolver = (IDependencyResolver)null;
      ((Controller)tipoPagoController).ActionInvoker = (IActionInvoker)null;
      ((Controller)tipoPagoController).TempDataProvider = (ITempDataProvider)null;
      ((Controller)tipoPagoController).Url = (UrlHelper)null;
      ((Controller)tipoPagoController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)tipoPagoController).ControllerContext = s0;
      ((ControllerBase)tipoPagoController).TempData = (TempDataDictionary)null;
      ((ControllerBase)tipoPagoController).ValidateRequest = false;
      ((ControllerBase)tipoPagoController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)tipoPagoController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)tipoPagoController);
      actionResult = this.EditTest01(tipoPagoController, (tbTipoPago)null);
      disposables.Dispose();
      Assert.IsNotNull((object)tipoPagoController);
      Assert.IsNotNull(((Controller)tipoPagoController).AsyncManager);
      Assert.IsNotNull
          (((Controller)tipoPagoController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)tipoPagoController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)tipoPagoController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)tipoPagoController).Url);
      Assert.IsNotNull(((ControllerBase)tipoPagoController).ControllerContext);
      Assert.IsNull
          (((ControllerBase)tipoPagoController).ControllerContext.Controller);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)tipoPagoController).ValidateRequest);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(TipoPagoControllerTest))]
public void EditTest019902()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      RouteData routeData;
      TipoPagoController tipoPagoController;
      ActionResult actionResult;
      routeData = new RouteData((RouteBase)null, (IRouteHandler)null);
      ControllerContext s0 = new ControllerContext();
      s0.Controller = (ControllerBase)null;
      s0.HttpContext = (HttpContextBase)null;
      s0.RequestContext = (RequestContext)null;
      s0.RouteData = routeData;
      tipoPagoController = new TipoPagoController();
      ((Controller)tipoPagoController).Resolver = (IDependencyResolver)null;
      ((Controller)tipoPagoController).ActionInvoker = (IActionInvoker)null;
      ((Controller)tipoPagoController).TempDataProvider = (ITempDataProvider)null;
      ((Controller)tipoPagoController).Url = (UrlHelper)null;
      ((Controller)tipoPagoController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)tipoPagoController).ControllerContext = s0;
      ((ControllerBase)tipoPagoController).TempData = (TempDataDictionary)null;
      ((ControllerBase)tipoPagoController).ValidateRequest = false;
      ((ControllerBase)tipoPagoController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)tipoPagoController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)tipoPagoController);
      actionResult = this.EditTest01(tipoPagoController, (tbTipoPago)null);
      disposables.Dispose();
      Assert.IsNotNull((object)tipoPagoController);
      Assert.IsNotNull(((Controller)tipoPagoController).AsyncManager);
      Assert.IsNotNull
          (((Controller)tipoPagoController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)tipoPagoController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)tipoPagoController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)tipoPagoController).Url);
      Assert.IsNotNull(((ControllerBase)tipoPagoController).ControllerContext);
      Assert.IsNull
          (((ControllerBase)tipoPagoController).ControllerContext.Controller);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)tipoPagoController).ValidateRequest);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(TipoPagoControllerTest))]
public void EditTest0118801()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      TempDataDictionary tempDataDictionary;
      TipoPagoController tipoPagoController;
      ActionResult actionResult;
      tempDataDictionary = new TempDataDictionary();
      tipoPagoController = new TipoPagoController();
      ((Controller)tipoPagoController).Resolver = (IDependencyResolver)null;
      ((Controller)tipoPagoController).ActionInvoker = (IActionInvoker)null;
      ((Controller)tipoPagoController).TempDataProvider = (ITempDataProvider)null;
      ((Controller)tipoPagoController).Url = (UrlHelper)null;
      ((Controller)tipoPagoController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)tipoPagoController).ControllerContext =
        (ControllerContext)null;
      ((ControllerBase)tipoPagoController).TempData = tempDataDictionary;
      ((ControllerBase)tipoPagoController).ValidateRequest = false;
      ((ControllerBase)tipoPagoController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)tipoPagoController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)tipoPagoController);
      actionResult = this.EditTest01(tipoPagoController, (tbTipoPago)null);
      disposables.Dispose();
      Assert.IsNotNull((object)tipoPagoController);
      Assert.IsNotNull(((Controller)tipoPagoController).AsyncManager);
      Assert.IsNotNull
          (((Controller)tipoPagoController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)tipoPagoController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)tipoPagoController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)tipoPagoController).Url);
      Assert.IsNull(((ControllerBase)tipoPagoController).ControllerContext);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)tipoPagoController).ValidateRequest);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(TipoPagoControllerTest))]
public void EditTest0118802()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      ViewEngineCollection viewEngineCollection;
      TipoPagoController tipoPagoController;
      ActionResult actionResult;
      IViewEngine[] iViewEngines = new IViewEngine[0];
      viewEngineCollection =
        new ViewEngineCollection((IList<IViewEngine>)iViewEngines);
      tipoPagoController = new TipoPagoController();
      ((Controller)tipoPagoController).Resolver = (IDependencyResolver)null;
      ((Controller)tipoPagoController).ActionInvoker = (IActionInvoker)null;
      ((Controller)tipoPagoController).TempDataProvider = (ITempDataProvider)null;
      ((Controller)tipoPagoController).Url = (UrlHelper)null;
      ((Controller)tipoPagoController).ViewEngineCollection = viewEngineCollection;
      ((ControllerBase)tipoPagoController).ControllerContext =
        (ControllerContext)null;
      ((ControllerBase)tipoPagoController).TempData = (TempDataDictionary)null;
      ((ControllerBase)tipoPagoController).ValidateRequest = false;
      ((ControllerBase)tipoPagoController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)tipoPagoController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)tipoPagoController);
      actionResult = this.EditTest01(tipoPagoController, (tbTipoPago)null);
      disposables.Dispose();
      Assert.IsNotNull((object)tipoPagoController);
      Assert.IsNotNull(((Controller)tipoPagoController).AsyncManager);
      Assert.IsNotNull
          (((Controller)tipoPagoController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)tipoPagoController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)tipoPagoController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)tipoPagoController).Url);
      Assert.IsNull(((ControllerBase)tipoPagoController).ControllerContext);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)tipoPagoController).ValidateRequest);
    }
}
    }
}
