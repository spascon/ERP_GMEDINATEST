using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP_ZORZAL.Controllers;
using Microsoft.Pex.Framework.Generated;
// <copyright file="MonedaControllerTest.ConstructorTest.g.cs">Copyright ©  2014</copyright>
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
    public partial class MonedaControllerTest
    {

[TestMethod]
[PexGeneratedBy(typeof(MonedaControllerTest))]
[Ignore]
[PexDescription("el estado de la prueba fue: path bounds exceeded")]
public void ConstructorTest01()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      MonedaController monedaController;
      monedaController = this.ConstructorTest();
      disposables.Add((IDisposable)monedaController);
      disposables.Dispose();
    }
}
    }
}
