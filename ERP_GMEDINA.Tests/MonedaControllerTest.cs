using ERP_GMEDINA.Models;
using System.Web.Mvc;
// <copyright file="MonedaControllerTest.cs">Copyright ©  2014</copyright>

using System;
using ERP_ZORZAL.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ERP_ZORZAL.Controllers.Tests
{
    /// <summary>Esta clase contiene pruebas unitarias parametrizadas para MonedaController</summary>
    [TestClass]
    [PexClass(typeof(MonedaController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class MonedaControllerTest
    {

        /// <summary>Código auxiliar de prueba para .ctor()</summary>
        [PexMethod(MaxBranches = 320000)]
        public MonedaController ConstructorTest()
        {
            MonedaController target = new MonedaController();
            return target;
            // TODO: agregar aserciones a método MonedaControllerTest.ConstructorTest()
        }

        /// <summary>Código auxiliar de prueba para Create()</summary>
        [PexMethod]
        public ActionResult CreateTest([PexAssumeUnderTest]MonedaController target)
        {
            ActionResult result = target.Create();
            return result;
            // TODO: agregar aserciones a método MonedaControllerTest.CreateTest(MonedaController)
        }

        /// <summary>Código auxiliar de prueba para Create(tbMoneda)</summary>
        [PexMethod]
        public ActionResult CreateTest01([PexAssumeUnderTest]MonedaController target, tbMoneda tbMoneda)
        {
            ActionResult result = target.Create(tbMoneda);
            return result;
            // TODO: agregar aserciones a método MonedaControllerTest.CreateTest01(MonedaController, tbMoneda)
        }

        /// <summary>Código auxiliar de prueba para Delete(Nullable`1&lt;Int16&gt;)</summary>
        [PexMethod]
        public ActionResult DeleteTest([PexAssumeUnderTest]MonedaController target, short? id)
        {
            ActionResult result = target.Delete(id);
            return result;
            // TODO: agregar aserciones a método MonedaControllerTest.DeleteTest(MonedaController, Nullable`1<Int16>)
        }

        /// <summary>Código auxiliar de prueba para DeleteConfirmed(Int16)</summary>
        [PexMethod]
        public ActionResult DeleteConfirmedTest([PexAssumeUnderTest]MonedaController target, short id)
        {
            ActionResult result = target.DeleteConfirmed(id);
            return result;
            // TODO: agregar aserciones a método MonedaControllerTest.DeleteConfirmedTest(MonedaController, Int16)
        }

        /// <summary>Código auxiliar de prueba para Details(Nullable`1&lt;Int16&gt;)</summary>
        [PexMethod]
        public ActionResult DetailsTest([PexAssumeUnderTest]MonedaController target, short? id)
        {
            ActionResult result = target.Details(id);
            return result;
            // TODO: agregar aserciones a método MonedaControllerTest.DetailsTest(MonedaController, Nullable`1<Int16>)
        }

        /// <summary>Código auxiliar de prueba para Edit(Nullable`1&lt;Int16&gt;)</summary>
        [PexMethod]
        public ActionResult EditTest([PexAssumeUnderTest]MonedaController target, short? id)
        {
            ActionResult result = target.Edit(id);
            return result;
            // TODO: agregar aserciones a método MonedaControllerTest.EditTest(MonedaController, Nullable`1<Int16>)
        }

        /// <summary>Código auxiliar de prueba para Edit(tbMoneda)</summary>
        [PexMethod]
        public ActionResult EditTest01([PexAssumeUnderTest]MonedaController target, tbMoneda tbMoneda)
        {
            ActionResult result = target.Edit(tbMoneda);
            return result;
            // TODO: agregar aserciones a método MonedaControllerTest.EditTest01(MonedaController, tbMoneda)
        }

        /// <summary>Código auxiliar de prueba para Index()</summary>
        [PexMethod]
        public ActionResult IndexTest([PexAssumeUnderTest]MonedaController target)
        {
            ActionResult result = target.Index();
            return result;
            // TODO: agregar aserciones a método MonedaControllerTest.IndexTest(MonedaController)
        }
    }
}
