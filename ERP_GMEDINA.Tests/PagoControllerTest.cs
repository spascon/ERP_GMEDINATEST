using ERP_GMEDINA.Models;
using System.Web.Mvc;
// <copyright file="PagoControllerTest.cs">Copyright ©  2014</copyright>

using System;
using ERP_GMEDINA.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ERP_GMEDINA.Controllers.Tests
{
    /// <summary>Esta clase contiene pruebas unitarias parametrizadas para PagoController</summary>
    [TestClass]
    [PexClass(typeof(PagoController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class PagoControllerTest
    {

        /// <summary>Código auxiliar de prueba para .ctor()</summary>
        [PexMethod]
        public PagoController ConstructorTest()
        {
            PagoController target = new PagoController();
            return target;
            // TODO: agregar aserciones a método PagoControllerTest.ConstructorTest()
        }

        /// <summary>Código auxiliar de prueba para AnularPago(Int32, Boolean, String)</summary>
        [PexMethod(MaxBranches = 320000)]
        public JsonResult AnularPagoTest(
            [PexAssumeUnderTest]PagoController target,
            int pago_Id,
            bool PagoAnulado,
            string RazonAnulado
        )
        {
            JsonResult result = target.AnularPago(pago_Id, PagoAnulado, RazonAnulado);
            return result;
            // TODO: agregar aserciones a método PagoControllerTest.AnularPagoTest(PagoController, Int32, Boolean, String)
        }

        /// <summary>Código auxiliar de prueba para BuscarFacturaId(Int32)</summary>
        [PexMethod]
        public JsonResult BuscarFacturaIdTest([PexAssumeUnderTest]PagoController target, int fId)
        {
            JsonResult result = target.BuscarFacturaId(fId);
            return result;
            // TODO: agregar aserciones a método PagoControllerTest.BuscarFacturaIdTest(PagoController, Int32)
        }

        /// <summary>Código auxiliar de prueba para Create()</summary>
        [PexMethod]
        public ActionResult CreateTest([PexAssumeUnderTest]PagoController target)
        {
            ActionResult result = target.Create();
            return result;
            // TODO: agregar aserciones a método PagoControllerTest.CreateTest(PagoController)
        }

        /// <summary>Código auxiliar de prueba para Create(tbPago)</summary>
        [PexMethod]
        public ActionResult CreateTest01([PexAssumeUnderTest]PagoController target, tbPago tbPago)
        {
            ActionResult result = target.Create(tbPago);
            return result;
            // TODO: agregar aserciones a método PagoControllerTest.CreateTest01(PagoController, tbPago)
        }

        /// <summary>Código auxiliar de prueba para Delete(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public ActionResult DeleteTest([PexAssumeUnderTest]PagoController target, int? id)
        {
            ActionResult result = target.Delete(id);
            return result;
            // TODO: agregar aserciones a método PagoControllerTest.DeleteTest(PagoController, Nullable`1<Int32>)
        }

        /// <summary>Código auxiliar de prueba para DeleteConfirmed(Int32)</summary>
        [PexMethod]
        public ActionResult DeleteConfirmedTest([PexAssumeUnderTest]PagoController target, int id)
        {
            ActionResult result = target.DeleteConfirmed(id);
            return result;
            // TODO: agregar aserciones a método PagoControllerTest.DeleteConfirmedTest(PagoController, Int32)
        }

        /// <summary>Código auxiliar de prueba para Details(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public ActionResult DetailsTest([PexAssumeUnderTest]PagoController target, int? id)
        {
            ActionResult result = target.Details(id);
            return result;
            // TODO: agregar aserciones a método PagoControllerTest.DetailsTest(PagoController, Nullable`1<Int32>)
        }

        /// <summary>Código auxiliar de prueba para Edit(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public ActionResult EditTest([PexAssumeUnderTest]PagoController target, int? id)
        {
            ActionResult result = target.Edit(id);
            return result;
            // TODO: agregar aserciones a método PagoControllerTest.EditTest(PagoController, Nullable`1<Int32>)
        }

        /// <summary>Código auxiliar de prueba para Edit(tbPago)</summary>
        [PexMethod]
        public ActionResult EditTest01([PexAssumeUnderTest]PagoController target, tbPago tbPago)
        {
            ActionResult result = target.Edit(tbPago);
            return result;
            // TODO: agregar aserciones a método PagoControllerTest.EditTest01(PagoController, tbPago)
        }

        /// <summary>Código auxiliar de prueba para GetFacturaList(Int64)</summary>
        [PexMethod]
        public JsonResult GetFacturaListTest([PexAssumeUnderTest]PagoController target, long tbFactura_clte_Id)
        {
            JsonResult result = target.GetFacturaList(tbFactura_clte_Id);
            return result;
            // TODO: agregar aserciones a método PagoControllerTest.GetFacturaListTest(PagoController, Int64)
        }

        /// <summary>Código auxiliar de prueba para Index()</summary>
        [PexMethod]
        public ActionResult IndexTest([PexAssumeUnderTest]PagoController target)
        {
            ActionResult result = target.Index();
            return result;
            // TODO: agregar aserciones a método PagoControllerTest.IndexTest(PagoController)
        }

        /// <summary>Código auxiliar de prueba para IndexPagoFactura()</summary>
        [PexMethod]
        public ActionResult IndexPagoFacturaTest([PexAssumeUnderTest]PagoController target)
        {
            ActionResult result = target.IndexPagoFactura();
            return result;
            // TODO: agregar aserciones a método PagoControllerTest.IndexPagoFacturaTest(PagoController)
        }
    }
}
