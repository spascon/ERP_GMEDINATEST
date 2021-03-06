using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP_GMEDINA.Controllers;
using Microsoft.Pex.Framework.Generated;
// <copyright file="ClienteControllerTest.ConstructorTest.g.cs">Copyright ©  2014</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace ERP_GMEDINA.Controllers.Tests
{
    public partial class ClienteControllerTest
    {

[TestMethod]
[PexGeneratedBy(typeof(ClienteControllerTest))]
public void Cliente_ConstructorTest()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      ClienteController clienteController;
      clienteController = this.ConstructorTest();
      disposables.Add((IDisposable)clienteController);
      disposables.Dispose();
      Assert.IsNotNull((object)clienteController);
      Assert.IsNotNull(((Controller)clienteController).AsyncManager);
      Assert.IsNotNull
          (((Controller)clienteController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)clienteController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)clienteController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)clienteController).Url);
      Assert.IsNull(((ControllerBase)clienteController).ControllerContext);
      Assert.AreEqual<bool>
          (true, ((ControllerBase)clienteController).ValidateRequest);
    }
}
    }
}
