using System.Collections.Generic;
using System.Web.Routing;
using System.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP_GMEDINA.Models;
using System.Web.Mvc;
using ERP_ZORZAL.Controllers;
using Microsoft.Pex.Framework.Generated;
// <copyright file="PedidoControllerTest.UpdatePedidoDetalleTest.g.cs">Copyright ©  2014</copyright>
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
public void PedidoDetalle_UpdateTest()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      TempDataDictionary tempDataDictionary;
      PedidoController pedidoController;
      ActionResult actionResult;
      tempDataDictionary = new TempDataDictionary();
      pedidoController = new PedidoController();
      ((Controller)pedidoController).Resolver = (IDependencyResolver)null;
      ((Controller)pedidoController).ActionInvoker = (IActionInvoker)null;
      ((Controller)pedidoController).TempDataProvider = (ITempDataProvider)null;
      ((Controller)pedidoController).Url = (UrlHelper)null;
      ((Controller)pedidoController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)pedidoController).ControllerContext = (ControllerContext)null;
      ((ControllerBase)pedidoController).TempData = tempDataDictionary;
      ((ControllerBase)pedidoController).ValidateRequest = false;
      ((ControllerBase)pedidoController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)pedidoController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)pedidoController);
      actionResult =
        this.UpdatePedidoDetalleTest(pedidoController, (tbPedidoDetalle)null);
      disposables.Dispose();
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
