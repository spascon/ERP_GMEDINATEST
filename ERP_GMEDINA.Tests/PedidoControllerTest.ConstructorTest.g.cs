using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
public void PedidosPorFacturar_ConstructorTest()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      PedidoController pedidoController;
      pedidoController = this.ConstructorTest();
      disposables.Add((IDisposable)pedidoController);
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
          (true, ((ControllerBase)pedidoController).ValidateRequest);
    }
}
    }
}
