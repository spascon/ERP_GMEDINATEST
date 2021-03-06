using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP_GMEDINA.Models;
using System.Web.Mvc;
using ERP_ZORZAL.Controllers;
using Microsoft.Pex.Framework.Generated;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace ERP_ZORZAL.Controllers.Tests
{
    public partial class PedidoControllerTest
    {

[TestMethod]
[PexGeneratedBy(typeof(PedidoControllerTest))]
public void PedidosPorFacturar_GuardarPedidoDetalleTest()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      PedidoController pedidoController;
      JsonResult jsonResult;
      pedidoController = PedidoControllerFactory.Create
                             ((IDependencyResolver)null, (IActionInvoker)null, 
                              (ITempDataProvider)null, (UrlHelper)null, (ViewEngineCollection)null, 
                              (ControllerContext)null, (TempDataDictionary)null, 
                              false, (IValueProvider)null, (ViewDataDictionary)null);
      disposables.Add((IDisposable)pedidoController);
      jsonResult =
        this.GuardarPedidoDetalleTest(pedidoController, (tbPedidoDetalle)null);
      disposables.Dispose();
      Assert.IsNotNull((object)jsonResult);
      Assert.IsNull(jsonResult.ContentEncoding);
      Assert.AreEqual<string>((string)null, jsonResult.ContentType);
      Assert.IsNotNull(jsonResult.Data);
      Assert.AreEqual<JsonRequestBehavior>
          (JsonRequestBehavior.AllowGet, jsonResult.JsonRequestBehavior);
      Assert.IsNull((object)(jsonResult.MaxJsonLength));
      Assert.IsNull((object)(jsonResult.RecursionLimit));
      Assert.IsNotNull((object)pedidoController);
      Assert.IsNotNull(((Controller)pedidoController).AsyncManager);
      Assert.IsNotNull
          (((Controller)pedidoController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)pedidoController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)pedidoController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)pedidoController).Url);
      Assert.IsNull(((ControllerBase)pedidoController).ControllerContext);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)pedidoController).ValidateRequest);
    }
}
    }
}
