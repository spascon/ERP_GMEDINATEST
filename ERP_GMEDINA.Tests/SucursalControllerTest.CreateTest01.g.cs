using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP_GMEDINA.Models;
using System.Web.Mvc;
using ERP_ZORZAL.Controllers;
using Microsoft.Pex.Framework.Generated;
// <copyright file="SucursalControllerTest.CreateTest01.g.cs">Copyright ©  2014</copyright>
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
    public partial class SucursalControllerTest
    {

[TestMethod]
[PexGeneratedBy(typeof(SucursalControllerTest))]

[PexDescription("el estado de la prueba fue: path bounds exceeded")]
public void CreateTest01775()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      SucursalController sucursalController;
      ActionResult actionResult;
      sucursalController = new SucursalController();
      ((Controller)sucursalController).Resolver = (IDependencyResolver)null;
      ((Controller)sucursalController).ActionInvoker = (IActionInvoker)null;
      ((Controller)sucursalController).TempDataProvider = (ITempDataProvider)null;
      ((Controller)sucursalController).Url = (UrlHelper)null;
      ((Controller)sucursalController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)sucursalController).ControllerContext =
        (ControllerContext)null;
      ((ControllerBase)sucursalController).TempData = (TempDataDictionary)null;
      ((ControllerBase)sucursalController).ValidateRequest = false;
      ((ControllerBase)sucursalController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)sucursalController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)sucursalController);
      actionResult = this.CreateTest01(sucursalController, (tbSucursal)null);
      disposables.Dispose();
    }
}
    }
}
