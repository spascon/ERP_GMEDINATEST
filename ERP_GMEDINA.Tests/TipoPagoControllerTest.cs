using ERP_GMEDINA.Models;
using System.Web.Mvc;
using System;
using ERP_ZORZAL.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ERP_ZORZAL.Controllers.Tests
{
    /// <summary>Esta clase contiene pruebas unitarias parametrizadas para TipoPagoController</summary>
    [TestClass]
    [PexClass(typeof(TipoPagoController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class TipoPagoControllerTest
    {

        /// <summary>Código auxiliar de prueba para .ctor()</summary>
        [PexMethod(MaxBranches = 320000)]
        public TipoPagoController ConstructorTest()
        {
            TipoPagoController target = new TipoPagoController();
            return target;
            // TODO: agregar aserciones a método TipoPagoControllerTest.ConstructorTest()
        }

        /// <summary>Código auxiliar de prueba para Create()</summary>
        [PexMethod]
        public ActionResult CreateTest([PexAssumeUnderTest]TipoPagoController target)
        {
            ActionResult result = target.Create();
            return result;
            // TODO: agregar aserciones a método TipoPagoControllerTest.CreateTest(TipoPagoController)
        }

        /// <summary>Código auxiliar de prueba para Create(tbTipoPago)</summary>
        [PexMethod]
        public ActionResult CreateTest01([PexAssumeUnderTest]TipoPagoController target, tbTipoPago tbTipoPago)
        {
            ActionResult result = target.Create(tbTipoPago);
            return result;
            // TODO: agregar aserciones a método TipoPagoControllerTest.CreateTest01(TipoPagoController, tbTipoPago)
        }

        /// <summary>Código auxiliar de prueba para Delete(Nullable`1&lt;Int16&gt;)</summary>
        [PexMethod]
        public ActionResult DeleteTest([PexAssumeUnderTest]TipoPagoController target, short? id)
        {
            ActionResult result = target.Delete(id);
            return result;
            // TODO: agregar aserciones a método TipoPagoControllerTest.DeleteTest(TipoPagoController, Nullable`1<Int16>)
        }

        /// <summary>Código auxiliar de prueba para DeleteConfirmed(Int16)</summary>
        [PexMethod]
        public ActionResult DeleteConfirmedTest([PexAssumeUnderTest]TipoPagoController target, short id)
        {
            ActionResult result = target.DeleteConfirmed(id);
            return result;
            // TODO: agregar aserciones a método TipoPagoControllerTest.DeleteConfirmedTest(TipoPagoController, Int16)
        }

        /// <summary>Código auxiliar de prueba para Details(Nullable`1&lt;Int16&gt;)</summary>
        [PexMethod]
        public ActionResult DetailsTest([PexAssumeUnderTest]TipoPagoController target, short? id)
        {
            ActionResult result = target.Details(id);
            return result;
            // TODO: agregar aserciones a método TipoPagoControllerTest.DetailsTest(TipoPagoController, Nullable`1<Int16>)
        }

        /// <summary>Código auxiliar de prueba para Edit(Nullable`1&lt;Int16&gt;)</summary>
        [PexMethod]
        public ActionResult EditTest([PexAssumeUnderTest]TipoPagoController target, short? id)
        {
            ActionResult result = target.Edit(id);
            return result;
            // TODO: agregar aserciones a método TipoPagoControllerTest.EditTest(TipoPagoController, Nullable`1<Int16>)
        }

        /// <summary>Código auxiliar de prueba para Edit(tbTipoPago)</summary>
        [PexMethod]
        public ActionResult EditTest01([PexAssumeUnderTest]TipoPagoController target, tbTipoPago tbTipoPago)
        {
            ActionResult result = target.Edit(tbTipoPago);
            return result;
            // TODO: agregar aserciones a método TipoPagoControllerTest.EditTest01(TipoPagoController, tbTipoPago)
        }

        /// <summary>Código auxiliar de prueba para Index()</summary>
        [PexMethod]
        public ActionResult IndexTest([PexAssumeUnderTest]TipoPagoController target)
        {
            ActionResult result = target.Index();
            return result;
            // TODO: agregar aserciones a método TipoPagoControllerTest.IndexTest(TipoPagoController)
        }
    }
}
