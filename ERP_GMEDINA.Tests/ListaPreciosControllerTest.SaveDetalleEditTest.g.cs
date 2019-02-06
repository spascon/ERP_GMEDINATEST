using System.Web.Routing;
using System.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP_GMEDINA.Models;
using System.Web.Mvc;
using ERP_GMEDINA.Controllers;
using Microsoft.Pex.Framework.Generated;
// <copyright file="ListaPreciosControllerTest.SaveDetalleEditTest.g.cs">Copyright ©  2014</copyright>
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
    public partial class ListaPreciosControllerTest
    {

[TestMethod]
[PexGeneratedBy(typeof(ListaPreciosControllerTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void SaveDetalleEditTestThrowsNullReferenceException102()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      ListaPreciosController listaPreciosController;
      JsonResult jsonResult;
      listaPreciosController = new ListaPreciosController();
      ((Controller)listaPreciosController).Resolver = (IDependencyResolver)null;
      ((Controller)listaPreciosController).ActionInvoker = (IActionInvoker)null;
      ((Controller)listaPreciosController).TempDataProvider =
        (ITempDataProvider)null;
      ((Controller)listaPreciosController).Url = (UrlHelper)null;
      ((Controller)listaPreciosController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)listaPreciosController).ControllerContext =
        (ControllerContext)null;
      ((ControllerBase)listaPreciosController).TempData = (TempDataDictionary)null;
      ((ControllerBase)listaPreciosController).ValidateRequest = false;
      ((ControllerBase)listaPreciosController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)listaPreciosController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)listaPreciosController);
      jsonResult = this.SaveDetalleEditTest
                       (listaPreciosController, (tbListadoPrecioDetalle)null);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(ListaPreciosControllerTest))]
[PexRaisedException(typeof(NotImplementedException))]
public void SaveDetalleEditTestThrowsNotImplementedException160()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      ListaPreciosController listaPreciosController;
      JsonResult jsonResult;
      ControllerContext s0 = new ControllerContext();
      s0.Controller = (ControllerBase)null;
      s0.HttpContext = (HttpContextBase)null;
      s0.RequestContext = (RequestContext)null;
      s0.RouteData = (RouteData)null;
      listaPreciosController = new ListaPreciosController();
      ((Controller)listaPreciosController).Resolver = (IDependencyResolver)null;
      ((Controller)listaPreciosController).ActionInvoker = (IActionInvoker)null;
      ((Controller)listaPreciosController).TempDataProvider =
        (ITempDataProvider)null;
      ((Controller)listaPreciosController).Url = (UrlHelper)null;
      ((Controller)listaPreciosController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)listaPreciosController).ControllerContext = s0;
      ((ControllerBase)listaPreciosController).TempData = (TempDataDictionary)null;
      ((ControllerBase)listaPreciosController).ValidateRequest = false;
      ((ControllerBase)listaPreciosController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)listaPreciosController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)listaPreciosController);
      jsonResult = this.SaveDetalleEditTest
                       (listaPreciosController, (tbListadoPrecioDetalle)null);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(ListaPreciosControllerTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void SaveDetalleEditTestThrowsNullReferenceException341()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      ListaPreciosController listaPreciosController;
      JsonResult jsonResult;
      ControllerContext s0 = new ControllerContext();
      s0.Controller = (ControllerBase)null;
      s0.HttpContext = (HttpContextBase)null;
      RequestContext s1 = new RequestContext();
      s1.HttpContext = (HttpContextBase)null;
      s1.RouteData = (RouteData)null;
      s0.RequestContext = s1;
      s0.RouteData = (RouteData)null;
      listaPreciosController = new ListaPreciosController();
      ((Controller)listaPreciosController).Resolver = (IDependencyResolver)null;
      ((Controller)listaPreciosController).ActionInvoker = (IActionInvoker)null;
      ((Controller)listaPreciosController).TempDataProvider =
        (ITempDataProvider)null;
      ((Controller)listaPreciosController).Url = (UrlHelper)null;
      ((Controller)listaPreciosController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)listaPreciosController).ControllerContext = s0;
      ((ControllerBase)listaPreciosController).TempData = (TempDataDictionary)null;
      ((ControllerBase)listaPreciosController).ValidateRequest = false;
      ((ControllerBase)listaPreciosController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)listaPreciosController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)listaPreciosController);
      jsonResult = this.SaveDetalleEditTest
                       (listaPreciosController, (tbListadoPrecioDetalle)null);
      disposables.Dispose();
    }
}
    }
}
