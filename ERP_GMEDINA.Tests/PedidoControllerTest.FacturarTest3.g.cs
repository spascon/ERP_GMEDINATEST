using System.Web.Routing;
using System.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP_GMEDINA.Models;
using System.Web.Mvc;
using ERP_ZORZAL.Controllers;
using Microsoft.Pex.Framework.Generated;
// <copyright file="PedidoControllerTest.FacturarTest.g.cs">Copyright ©  2014</copyright>
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
    public partial class PedidoControllerTest
    {


[TestMethod]
[PexGeneratedBy(typeof(PedidoControllerTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void Pedido_FacturarTest()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      PedidoController pedidoController;
      ActionResult actionResult;
      ControllerContext s0 = new ControllerContext();
      s0.Controller = (ControllerBase)null;
      s0.HttpContext = (HttpContextBase)null;
      RequestContext s1 = new RequestContext();
      s1.HttpContext = (HttpContextBase)null;
      s1.RouteData = (RouteData)null;
      s0.RequestContext = s1;
      s0.RouteData = (RouteData)null;
      pedidoController = new PedidoController();
      ((Controller)pedidoController).Resolver = (IDependencyResolver)null;
      ((Controller)pedidoController).ActionInvoker = (IActionInvoker)null;
      ((Controller)pedidoController).TempDataProvider = (ITempDataProvider)null;
      ((Controller)pedidoController).Url = (UrlHelper)null;
      ((Controller)pedidoController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)pedidoController).ControllerContext = s0;
      ((ControllerBase)pedidoController).TempData = (TempDataDictionary)null;
      ((ControllerBase)pedidoController).ValidateRequest = false;
      ((ControllerBase)pedidoController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)pedidoController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)pedidoController);
      actionResult = this.FacturarTest(pedidoController, (tbPedido)null);
      disposables.Dispose();
    }
}
    }
}
