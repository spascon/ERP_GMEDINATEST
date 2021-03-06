using System.Collections.Generic;
using System.Web.Routing;
using System.Web;
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
    public partial class CuentaBancoControllerTest
    {


[TestMethod]
[PexGeneratedBy(typeof(CuentaBancoControllerTest))]
public void CuentaBanco_CreateTest1()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      ViewEngineCollection viewEngineCollection;
      CuentaBancoController cuentaBancoController;
      ActionResult actionResult;
      IViewEngine[] iViewEngines = new IViewEngine[0];
      viewEngineCollection =
        new ViewEngineCollection((IList<IViewEngine>)iViewEngines);
      cuentaBancoController = CuentaBancoControllerFactory.Create
                                  ((IDependencyResolver)null, (IActionInvoker)null, 
                                   (ITempDataProvider)null, (UrlHelper)null, viewEngineCollection, 
                                   (ControllerContext)null, (TempDataDictionary)null, 
                                   false, (IValueProvider)null, (ViewDataDictionary)null);
      disposables.Add((IDisposable)cuentaBancoController);
      actionResult = this.CreateTest01(cuentaBancoController, (tbCuentasBanco)null);
      disposables.Dispose();
      Assert.IsNotNull((object)actionResult);
      Assert.IsNotNull((object)cuentaBancoController);
      Assert.IsNotNull(((Controller)cuentaBancoController).AsyncManager);
      Assert.IsNotNull
          (((Controller)cuentaBancoController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)cuentaBancoController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)cuentaBancoController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)cuentaBancoController).Url);
      Assert.IsNull(((ControllerBase)cuentaBancoController).ControllerContext);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)cuentaBancoController).ValidateRequest);
    }
}
    }
}
