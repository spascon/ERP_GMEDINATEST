using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using ERP_GMEDINA.Controllers;
using Microsoft.Pex.Framework.Generated;
// <copyright file="CuponDescuentoControllerTest.EditTest.g.cs">Copyright ©  2014</copyright>
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
[Ignore]
[PexDescription("el estado de la prueba fue: path bounds exceeded")]
public void EditTest19()
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
      actionResult = this.EditTest(cuponDescuentoController, default(int?));
      disposables.Dispose();
    }
}
    }
}
