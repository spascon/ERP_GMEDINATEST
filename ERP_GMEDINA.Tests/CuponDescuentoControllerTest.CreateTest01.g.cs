using System.Collections.Generic;
using System.Web.Routing;
using System.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP_GMEDINA.Models;
using System.Web.Mvc;
using ERP_GMEDINA.Controllers;
using Microsoft.Pex.Framework.Generated;
// <copyright file="CuponDescuentoControllerTest.CreateTest01.g.cs">Copyright ©  2014</copyright>
// <auto-generated>
// Este archivo contiene pruebas generadas automáticamente.
// No modifique el archivo manualmente.
// 
// Si el contenido del archivo se queda obsoleto, puede eliminarlo.
// Por ejemplo, si ya no se compila.
// </auto-generated>
using System;

namespace ERP_GMEDINA.Controllers.Tests
{
    public partial class CuponDescuentoControllerTest
    {

[TestMethod]
[PexGeneratedBy(typeof(CuponDescuentoControllerTest))]
public void CreateTest01853()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      CuponDescuentoController cuponDescuentoController;
      ActionResult actionResult;
      cuponDescuentoController = new CuponDescuentoController();
      ((Controller)cuponDescuentoController).Resolver = (IDependencyResolver)null;
      ((Controller)cuponDescuentoController).ActionInvoker = (IActionInvoker)null;
      ((Controller)cuponDescuentoController).TempDataProvider =
        (ITempDataProvider)null;
      ((Controller)cuponDescuentoController).Url = (UrlHelper)null;
      ((Controller)cuponDescuentoController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)cuponDescuentoController).ControllerContext =
        (ControllerContext)null;
      ((ControllerBase)cuponDescuentoController).TempData = (TempDataDictionary)null;
      ((ControllerBase)cuponDescuentoController).ValidateRequest = false;
      ((ControllerBase)cuponDescuentoController).ValueProvider =
        (IValueProvider)null;
      ((ControllerBase)cuponDescuentoController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)cuponDescuentoController);
      actionResult =
        this.CreateTest01(cuponDescuentoController, (tbCuponDescuento)null);
      disposables.Dispose();
      Assert.IsNotNull((object)cuponDescuentoController);
      Assert.IsNotNull(((Controller)cuponDescuentoController).AsyncManager);
      Assert.IsNotNull
          (((Controller)cuponDescuentoController).AsyncManager.OutstandingOperations
          );
      Assert.IsNotNull
          (((Controller)cuponDescuentoController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)cuponDescuentoController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)cuponDescuentoController).Url);
      Assert.IsNull(((ControllerBase)cuponDescuentoController).ControllerContext);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)cuponDescuentoController).ValidateRequest);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(CuponDescuentoControllerTest))]
public void CreateTest0188()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      CuponDescuentoController cuponDescuentoController;
      ActionResult actionResult;
      ControllerContext s0 = new ControllerContext();
      s0.Controller = (ControllerBase)null;
      s0.HttpContext = (HttpContextBase)null;
      s0.RequestContext = (RequestContext)null;
      s0.RouteData = (RouteData)null;
      cuponDescuentoController = new CuponDescuentoController();
      ((Controller)cuponDescuentoController).Resolver = (IDependencyResolver)null;
      ((Controller)cuponDescuentoController).ActionInvoker = (IActionInvoker)null;
      ((Controller)cuponDescuentoController).TempDataProvider =
        (ITempDataProvider)null;
      ((Controller)cuponDescuentoController).Url = (UrlHelper)null;
      ((Controller)cuponDescuentoController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)cuponDescuentoController).ControllerContext = s0;
      ((ControllerBase)cuponDescuentoController).TempData = (TempDataDictionary)null;
      ((ControllerBase)cuponDescuentoController).ValidateRequest = false;
      ((ControllerBase)cuponDescuentoController).ValueProvider =
        (IValueProvider)null;
      ((ControllerBase)cuponDescuentoController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)cuponDescuentoController);
      actionResult =
        this.CreateTest01(cuponDescuentoController, (tbCuponDescuento)null);
      disposables.Dispose();
      Assert.IsNotNull((object)cuponDescuentoController);
      Assert.IsNotNull(((Controller)cuponDescuentoController).AsyncManager);
      Assert.IsNotNull
          (((Controller)cuponDescuentoController).AsyncManager.OutstandingOperations
          );
      Assert.IsNotNull
          (((Controller)cuponDescuentoController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)cuponDescuentoController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)cuponDescuentoController).Url);
      Assert.IsNotNull(((ControllerBase)cuponDescuentoController).ControllerContext);
      Assert.IsNull
          (((ControllerBase)cuponDescuentoController).ControllerContext.Controller);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)cuponDescuentoController).ValidateRequest);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(CuponDescuentoControllerTest))]
public void CreateTest018801()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      CuponDescuentoController cuponDescuentoController;
      ActionResult actionResult;
      ControllerContext s0 = new ControllerContext();
      s0.Controller = (ControllerBase)null;
      s0.HttpContext = (HttpContextBase)null;
      RequestContext s1 = new RequestContext();
      s1.HttpContext = (HttpContextBase)null;
      s1.RouteData = (RouteData)null;
      s0.RequestContext = s1;
      s0.RouteData = (RouteData)null;
      cuponDescuentoController = new CuponDescuentoController();
      ((Controller)cuponDescuentoController).Resolver = (IDependencyResolver)null;
      ((Controller)cuponDescuentoController).ActionInvoker = (IActionInvoker)null;
      ((Controller)cuponDescuentoController).TempDataProvider =
        (ITempDataProvider)null;
      ((Controller)cuponDescuentoController).Url = (UrlHelper)null;
      ((Controller)cuponDescuentoController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)cuponDescuentoController).ControllerContext = s0;
      ((ControllerBase)cuponDescuentoController).TempData = (TempDataDictionary)null;
      ((ControllerBase)cuponDescuentoController).ValidateRequest = false;
      ((ControllerBase)cuponDescuentoController).ValueProvider =
        (IValueProvider)null;
      ((ControllerBase)cuponDescuentoController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)cuponDescuentoController);
      actionResult =
        this.CreateTest01(cuponDescuentoController, (tbCuponDescuento)null);
      disposables.Dispose();
      Assert.IsNotNull((object)cuponDescuentoController);
      Assert.IsNotNull(((Controller)cuponDescuentoController).AsyncManager);
      Assert.IsNotNull
          (((Controller)cuponDescuentoController).AsyncManager.OutstandingOperations
          );
      Assert.IsNotNull
          (((Controller)cuponDescuentoController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)cuponDescuentoController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)cuponDescuentoController).Url);
      Assert.IsNotNull(((ControllerBase)cuponDescuentoController).ControllerContext);
      Assert.IsNull
          (((ControllerBase)cuponDescuentoController).ControllerContext.Controller);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)cuponDescuentoController).ValidateRequest);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(CuponDescuentoControllerTest))]
public void CreateTest0185301()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      TempDataDictionary tempDataDictionary;
      CuponDescuentoController cuponDescuentoController;
      ActionResult actionResult;
      tempDataDictionary = new TempDataDictionary();
      cuponDescuentoController = new CuponDescuentoController();
      ((Controller)cuponDescuentoController).Resolver = (IDependencyResolver)null;
      ((Controller)cuponDescuentoController).ActionInvoker = (IActionInvoker)null;
      ((Controller)cuponDescuentoController).TempDataProvider =
        (ITempDataProvider)null;
      ((Controller)cuponDescuentoController).Url = (UrlHelper)null;
      ((Controller)cuponDescuentoController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)cuponDescuentoController).ControllerContext =
        (ControllerContext)null;
      ((ControllerBase)cuponDescuentoController).TempData = tempDataDictionary;
      ((ControllerBase)cuponDescuentoController).ValidateRequest = false;
      ((ControllerBase)cuponDescuentoController).ValueProvider =
        (IValueProvider)null;
      ((ControllerBase)cuponDescuentoController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)cuponDescuentoController);
      actionResult =
        this.CreateTest01(cuponDescuentoController, (tbCuponDescuento)null);
      disposables.Dispose();
      Assert.IsNotNull((object)cuponDescuentoController);
      Assert.IsNotNull(((Controller)cuponDescuentoController).AsyncManager);
      Assert.IsNotNull
          (((Controller)cuponDescuentoController).AsyncManager.OutstandingOperations
          );
      Assert.IsNotNull
          (((Controller)cuponDescuentoController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)cuponDescuentoController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)cuponDescuentoController).Url);
      Assert.IsNull(((ControllerBase)cuponDescuentoController).ControllerContext);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)cuponDescuentoController).ValidateRequest);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(CuponDescuentoControllerTest))]
public void CreateTest0185302()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      ViewEngineCollection viewEngineCollection;
      CuponDescuentoController cuponDescuentoController;
      ActionResult actionResult;
      IViewEngine[] iViewEngines = new IViewEngine[0];
      viewEngineCollection =
        new ViewEngineCollection((IList<IViewEngine>)iViewEngines);
      cuponDescuentoController = new CuponDescuentoController();
      ((Controller)cuponDescuentoController).Resolver = (IDependencyResolver)null;
      ((Controller)cuponDescuentoController).ActionInvoker = (IActionInvoker)null;
      ((Controller)cuponDescuentoController).TempDataProvider =
        (ITempDataProvider)null;
      ((Controller)cuponDescuentoController).Url = (UrlHelper)null;
      ((Controller)cuponDescuentoController).ViewEngineCollection =
        viewEngineCollection;
      ((ControllerBase)cuponDescuentoController).ControllerContext =
        (ControllerContext)null;
      ((ControllerBase)cuponDescuentoController).TempData = (TempDataDictionary)null;
      ((ControllerBase)cuponDescuentoController).ValidateRequest = false;
      ((ControllerBase)cuponDescuentoController).ValueProvider =
        (IValueProvider)null;
      ((ControllerBase)cuponDescuentoController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)cuponDescuentoController);
      actionResult =
        this.CreateTest01(cuponDescuentoController, (tbCuponDescuento)null);
      disposables.Dispose();
      Assert.IsNotNull((object)cuponDescuentoController);
      Assert.IsNotNull(((Controller)cuponDescuentoController).AsyncManager);
      Assert.IsNotNull
          (((Controller)cuponDescuentoController).AsyncManager.OutstandingOperations
          );
      Assert.IsNotNull
          (((Controller)cuponDescuentoController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)cuponDescuentoController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)cuponDescuentoController).Url);
      Assert.IsNull(((ControllerBase)cuponDescuentoController).ControllerContext);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)cuponDescuentoController).ValidateRequest);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(CuponDescuentoControllerTest))]
public void CreateTest018802()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      RouteData routeData;
      CuponDescuentoController cuponDescuentoController;
      ActionResult actionResult;
      routeData = new RouteData((RouteBase)null, (IRouteHandler)null);
      ControllerContext s0 = new ControllerContext();
      s0.Controller = (ControllerBase)null;
      s0.HttpContext = (HttpContextBase)null;
      s0.RequestContext = (RequestContext)null;
      s0.RouteData = routeData;
      cuponDescuentoController = new CuponDescuentoController();
      ((Controller)cuponDescuentoController).Resolver = (IDependencyResolver)null;
      ((Controller)cuponDescuentoController).ActionInvoker = (IActionInvoker)null;
      ((Controller)cuponDescuentoController).TempDataProvider =
        (ITempDataProvider)null;
      ((Controller)cuponDescuentoController).Url = (UrlHelper)null;
      ((Controller)cuponDescuentoController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)cuponDescuentoController).ControllerContext = s0;
      ((ControllerBase)cuponDescuentoController).TempData = (TempDataDictionary)null;
      ((ControllerBase)cuponDescuentoController).ValidateRequest = false;
      ((ControllerBase)cuponDescuentoController).ValueProvider =
        (IValueProvider)null;
      ((ControllerBase)cuponDescuentoController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)cuponDescuentoController);
      actionResult =
        this.CreateTest01(cuponDescuentoController, (tbCuponDescuento)null);
      disposables.Dispose();
      Assert.IsNotNull((object)cuponDescuentoController);
      Assert.IsNotNull(((Controller)cuponDescuentoController).AsyncManager);
      Assert.IsNotNull
          (((Controller)cuponDescuentoController).AsyncManager.OutstandingOperations
          );
      Assert.IsNotNull
          (((Controller)cuponDescuentoController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)cuponDescuentoController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)cuponDescuentoController).Url);
      Assert.IsNotNull(((ControllerBase)cuponDescuentoController).ControllerContext);
      Assert.IsNull
          (((ControllerBase)cuponDescuentoController).ControllerContext.Controller);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)cuponDescuentoController).ValidateRequest);
    }
}
    }
}
