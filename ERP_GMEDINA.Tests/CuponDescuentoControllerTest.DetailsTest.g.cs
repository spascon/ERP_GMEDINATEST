using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using ERP_GMEDINA.Controllers;
using Microsoft.Pex.Framework.Generated;
// <copyright file="CuponDescuentoControllerTest.DetailsTest.g.cs">Copyright ©  2014</copyright>
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
public void DetailsTest839()
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
      actionResult = this.DetailsTest(cuponDescuentoController, default(int?));
      disposables.Dispose();
      Assert.IsNotNull((object)cuponDescuentoController);
      Assert.IsNotNull(((Controller)cuponDescuentoController).AsyncManager);
      Assert.IsNotNull
          (((Controller)cuponDescuentoController).AsyncManager.OutstandingOperations
          );
      Assert.IsNotNull
          (((Controller)cuponDescuentoController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)cuponDescuentoController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)cuponDescuentoController).Url);
      Assert.IsNull(((ControllerBase)cuponDescuentoController).ControllerContext);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)cuponDescuentoController).ValidateRequest);
    }
}
    }
}
