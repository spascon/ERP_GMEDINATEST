using ERP_GMEDINA.Models;
using System.Web.Mvc;
using System;
using ERP_ZORZAL.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ERP_ZORZAL.Controllers.Tests
{
    /// <summary>Esta clase contiene pruebas unitarias parametrizadas para CajaController</summary>
    [TestClass]
    [PexClass(typeof(CajaController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class CajaControllerTest
    {

        /// <summary>Código auxiliar de prueba para .ctor()</summary>
        [PexMethod]
        public CajaController ConstructorTest()
        {
            CajaController target = new CajaController();
            return target;
            // TODO: agregar aserciones a método CajaControllerTest.ConstructorTest()
        }

        /// <summary>Código auxiliar de prueba para Create()</summary>
        [PexMethod]
        public ActionResult CreateTest([PexAssumeUnderTest]CajaController target)
        {
            ActionResult result = target.Create();
            return result;
            // TODO: agregar aserciones a método CajaControllerTest.CreateTest(CajaController)
        }

        /// <summary>Código auxiliar de prueba para Create(tbCaja)</summary>
        [PexMethod]
        public ActionResult CreateTest01([PexAssumeUnderTest]CajaController target, tbCaja tbCaja)
        {
            ActionResult result = target.Create(tbCaja);
            return result;
            // TODO: agregar aserciones a método CajaControllerTest.CreateTest01(CajaController, tbCaja)
        }

        /// <summary>Código auxiliar de prueba para Delete(Nullable`1&lt;Int16&gt;)</summary>
        [PexMethod]
        public ActionResult DeleteTest([PexAssumeUnderTest]CajaController target, short? id)
        {
            ActionResult result = target.Delete(id);
            return result;
            // TODO: agregar aserciones a método CajaControllerTest.DeleteTest(CajaController, Nullable`1<Int16>)
        }

        /// <summary>Código auxiliar de prueba para DeleteConfirmed(Int16)</summary>
        [PexMethod]
        public ActionResult DeleteConfirmedTest([PexAssumeUnderTest]CajaController target, short id)
        {
            ActionResult result = target.DeleteConfirmed(id);
            return result;
            // TODO: agregar aserciones a método CajaControllerTest.DeleteConfirmedTest(CajaController, Int16)
        }

        /// <summary>Código auxiliar de prueba para Details(Nullable`1&lt;Int16&gt;)</summary>
        [PexMethod]
        public ActionResult DetailsTest([PexAssumeUnderTest]CajaController target, short? id)
        {
            ActionResult result = target.Details(id);
            return result;
            // TODO: agregar aserciones a método CajaControllerTest.DetailsTest(CajaController, Nullable`1<Int16>)
        }

        /// <summary>Código auxiliar de prueba para Edit(Nullable`1&lt;Int16&gt;)</summary>
        [PexMethod]
        public ActionResult EditTest([PexAssumeUnderTest]CajaController target, short? id)
        {
            ActionResult result = target.Edit(id);
            return result;
            // TODO: agregar aserciones a método CajaControllerTest.EditTest(CajaController, Nullable`1<Int16>)
        }

        /// <summary>Código auxiliar de prueba para Edit(tbCaja)</summary>
        [PexMethod]
        public ActionResult EditTest01([PexAssumeUnderTest]CajaController target, tbCaja tbCaja)
        {
            ActionResult result = target.Edit(tbCaja);
            return result;
            // TODO: agregar aserciones a método CajaControllerTest.EditTest01(CajaController, tbCaja)
        }

        /// <summary>Código auxiliar de prueba para Index()</summary>
        [PexMethod]
        public ActionResult IndexTest([PexAssumeUnderTest]CajaController target)
        {
            ActionResult result = target.Index();
            return result;
            // TODO: agregar aserciones a método CajaControllerTest.IndexTest(CajaController)
        }
    }
}
