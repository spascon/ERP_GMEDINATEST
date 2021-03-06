using ERP_GMEDINA.Models;
using System.Web.Mvc;
// <copyright file="SolicitudCreditoControllerTest.cs">Copyright ©  2014</copyright>

using System;
using ERP_ZORZAL.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ERP_ZORZAL.Controllers.Tests
{
    /// <summary>Esta clase contiene pruebas unitarias parametrizadas para SolicitudCreditoController</summary>
    [TestClass]
    [PexClass(typeof(SolicitudCreditoController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class SolicitudCreditoControllerTest
    {

        /// <summary>Código auxiliar de prueba para .ctor()</summary>
        [PexMethod]
        public SolicitudCreditoController ConstructorTest()
        {
            SolicitudCreditoController target = new SolicitudCreditoController();
            return target;
            // TODO: agregar aserciones a método SolicitudCreditoControllerTest.ConstructorTest()
        }

        /// <summary>Código auxiliar de prueba para AceptarSolicitud(Int32, Int32)</summary>
        [PexMethod(MaxBranches = 320000)]
        public JsonResult AceptarSolicitudTest(
            [PexAssumeUnderTest]SolicitudCreditoController target,
            int CodSolicitud,
            int estado
        )
        {
            JsonResult result = target.AceptarSolicitud(CodSolicitud, estado);
            return result;
            // TODO: agregar aserciones a método SolicitudCreditoControllerTest.AceptarSolicitudTest(SolicitudCreditoController, Int32, Int32)
        }

        /// <summary>Código auxiliar de prueba para Create()</summary>
        [PexMethod]
        public ActionResult CreateTest([PexAssumeUnderTest]SolicitudCreditoController target)
        {
            ActionResult result = target.Create();
            return result;
            // TODO: agregar aserciones a método SolicitudCreditoControllerTest.CreateTest(SolicitudCreditoController)
        }

        /// <summary>Código auxiliar de prueba para Create(tbSolicitudCredito)</summary>
        [PexMethod]
        public ActionResult CreateTest01(
            [PexAssumeUnderTest]SolicitudCreditoController target,
            tbSolicitudCredito tbSolicitudCredito
        )
        {
            ActionResult result = target.Create(tbSolicitudCredito);
            return result;
            // TODO: agregar aserciones a método SolicitudCreditoControllerTest.CreateTest01(SolicitudCreditoController, tbSolicitudCredito)
        }

        /// <summary>Código auxiliar de prueba para Delete(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public ActionResult DeleteTest([PexAssumeUnderTest]SolicitudCreditoController target, int? id)
        {
            ActionResult result = target.Delete(id);
            return result;
            // TODO: agregar aserciones a método SolicitudCreditoControllerTest.DeleteTest(SolicitudCreditoController, Nullable`1<Int32>)
        }

        /// <summary>Código auxiliar de prueba para DeleteConfirmed(Int32)</summary>
        [PexMethod]
        public ActionResult DeleteConfirmedTest([PexAssumeUnderTest]SolicitudCreditoController target, int id)
        {
            ActionResult result = target.DeleteConfirmed(id);
            return result;
            // TODO: agregar aserciones a método SolicitudCreditoControllerTest.DeleteConfirmedTest(SolicitudCreditoController, Int32)
        }

        /// <summary>Código auxiliar de prueba para DenegarSolCredito(Int32, Byte)</summary>
        [PexMethod]
        public JsonResult DenegarSolCreditoTest(
            [PexAssumeUnderTest]SolicitudCreditoController target,
            int credID,
            byte Denegado
        )
        {
            JsonResult result = target.DenegarSolCredito(credID, Denegado);
            return result;
            // TODO: agregar aserciones a método SolicitudCreditoControllerTest.DenegarSolCreditoTest(SolicitudCreditoController, Int32, Byte)
        }

        /// <summary>Código auxiliar de prueba para Details(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public ActionResult DetailsTest([PexAssumeUnderTest]SolicitudCreditoController target, int? id)
        {
            ActionResult result = target.Details(id);
            return result;
            // TODO: agregar aserciones a método SolicitudCreditoControllerTest.DetailsTest(SolicitudCreditoController, Nullable`1<Int32>)
        }

        /// <summary>Código auxiliar de prueba para Edit(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public ActionResult EditTest([PexAssumeUnderTest]SolicitudCreditoController target, int? id)
        {
            ActionResult result = target.Edit(id);
            return result;
            // TODO: agregar aserciones a método SolicitudCreditoControllerTest.EditTest(SolicitudCreditoController, Nullable`1<Int32>)
        }

        /// <summary>Código auxiliar de prueba para Edit(tbSolicitudCredito)</summary>
        [PexMethod]
        public ActionResult EditTest01(
            [PexAssumeUnderTest]SolicitudCreditoController target,
            tbSolicitudCredito tbSolicitudCredito
        )
        {
            ActionResult result = target.Edit(tbSolicitudCredito);
            return result;
            // TODO: agregar aserciones a método SolicitudCreditoControllerTest.EditTest01(SolicitudCreditoController, tbSolicitudCredito)
        }

        /// <summary>Código auxiliar de prueba para Index()</summary>
        [PexMethod]
        public ActionResult IndexTest([PexAssumeUnderTest]SolicitudCreditoController target)
        {
            ActionResult result = target.Index();
            return result;
            // TODO: agregar aserciones a método SolicitudCreditoControllerTest.IndexTest(SolicitudCreditoController)
        }

        /// <summary>Código auxiliar de prueba para IndexSolicitud()</summary>
        [PexMethod]
        public ActionResult IndexSolicitudTest([PexAssumeUnderTest]SolicitudCreditoController target)
        {
            ActionResult result = target.IndexSolicitud();
            return result;
            // TODO: agregar aserciones a método SolicitudCreditoControllerTest.IndexSolicitudTest(SolicitudCreditoController)
        }

        /// <summary>Código auxiliar de prueba para UpdateSolicitudCredito(tbSolicitudCredito)</summary>
        [PexMethod]
        public ActionResult UpdateSolicitudCreditoTest(
            [PexAssumeUnderTest]SolicitudCreditoController target,
            tbSolicitudCredito EditSolicitudCredito
        )
        {
            ActionResult result = target.UpdateSolicitudCredito(EditSolicitudCredito);
            return result;
            // TODO: agregar aserciones a método SolicitudCreditoControllerTest.UpdateSolicitudCreditoTest(SolicitudCreditoController, tbSolicitudCredito)
        }
    }
}
