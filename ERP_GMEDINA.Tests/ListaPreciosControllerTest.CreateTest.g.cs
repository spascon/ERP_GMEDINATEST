using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using ERP_GMEDINA.Controllers;
using Microsoft.Pex.Framework.Generated;
// <copyright file="ListaPreciosControllerTest.CreateTest.g.cs">Copyright ©  2014</copyright>
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
    public partial class ListaPreciosControllerTest
    {

[TestMethod]
[PexGeneratedBy(typeof(ListaPreciosControllerTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void CreateTestThrowsNullReferenceException24()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      ListaPreciosController listaPreciosController;
      ActionResult actionResult;
      listaPreciosController = new ListaPreciosController();
      ((Controller)listaPreciosController).Resolver = (IDependencyResolver)null;
      ((Controller)listaPreciosController).ActionInvoker = (IActionInvoker)null;
      ((Controller)listaPreciosController).TempDataProvider =
        (ITempDataProvider)null;
      ((Controller)listaPreciosController).Url = (UrlHelper)null;
      ((Controller)listaPreciosController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)listaPreciosController).ControllerContext =
        (ControllerContext)null;
      ((ControllerBase)listaPreciosController).TempData = (TempDataDictionary)null;
      ((ControllerBase)listaPreciosController).ValidateRequest = false;
      ((ControllerBase)listaPreciosController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)listaPreciosController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)listaPreciosController);
      actionResult = this.CreateTest(listaPreciosController);
      disposables.Dispose();
    }
}
    }
}
