using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using ERP_ZORZAL.Controllers;
using Microsoft.Pex.Framework.Generated;
// <copyright file="DevolucionControllerTest._CreateDevolucionDetalle1Test.g.cs">Copyright ©  2014</copyright>
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
    public partial class DevolucionControllerTest
    {

[TestMethod]
[PexGeneratedBy(typeof(DevolucionControllerTest))]

[PexDescription("el estado de la prueba fue: path bounds exceeded")]
public void _CreateDevolucionDetalle1Test932()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      DevolucionController devolucionController;
      ActionResult actionResult;
      devolucionController = new DevolucionController();
      ((Controller)devolucionController).Resolver = (IDependencyResolver)null;
      ((Controller)devolucionController).ActionInvoker = (IActionInvoker)null;
      ((Controller)devolucionController).TempDataProvider = (ITempDataProvider)null;
      ((Controller)devolucionController).Url = (UrlHelper)null;
      ((Controller)devolucionController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)devolucionController).ControllerContext =
        (ControllerContext)null;
      ((ControllerBase)devolucionController).TempData = (TempDataDictionary)null;
      ((ControllerBase)devolucionController).ValidateRequest = false;
      ((ControllerBase)devolucionController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)devolucionController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)devolucionController);
      actionResult = this._CreateDevolucionDetalle1Test(devolucionController);
      disposables.Dispose();
    }
}
    }
}
