using ERP_GMEDINA.Models;
using System.Web.Mvc;
// <copyright file="EstadoSolicitudCreditoControllerTest.cs">Copyright ©  2014</copyright>

using System;
using ERP_ZORZAL.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ERP_ZORZAL.Controllers.Tests
{
    /// <summary>Esta clase contiene pruebas unitarias parametrizadas para EstadoSolicitudCreditoController</summary>
    [TestClass]
    [PexClass(typeof(EstadoSolicitudCreditoController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class EstadoSolicitudCreditoControllerTest
    {

        /// <summary>Código auxiliar de prueba para .ctor()</summary>
        [PexMethod(MaxBranches = 320000)]
        public EstadoSolicitudCreditoController ConstructorTest()
        {
            EstadoSolicitudCreditoController target = new EstadoSolicitudCreditoController();
            return target;
            // TODO: agregar aserciones a método EstadoSolicitudCreditoControllerTest.ConstructorTest()
        }

        /// <summary>Código auxiliar de prueba para Create()</summary>
        [PexMethod]
        public ActionResult CreateTest([PexAssumeUnderTest]EstadoSolicitudCreditoController target)
        {
            ActionResult result = target.Create();
            return result;
            // TODO: agregar aserciones a método EstadoSolicitudCreditoControllerTest.CreateTest(EstadoSolicitudCreditoController)
        }

        /// <summary>Código auxiliar de prueba para Create(tbEstadoSolicitudCredito)</summary>
        [PexMethod(MaxBranches = 320000)]
        public ActionResult CreateTest01(
            [PexAssumeUnderTest]EstadoSolicitudCreditoController target,
            tbEstadoSolicitudCredito tbEstadoSolicitudCredito
        )
        {
            ActionResult result = target.Create(tbEstadoSolicitudCredito);
            return result;
            // TODO: agregar aserciones a método EstadoSolicitudCreditoControllerTest.CreateTest01(EstadoSolicitudCreditoController, tbEstadoSolicitudCredito)
        }

        /// <summary>Código auxiliar de prueba para Delete(Nullable`1&lt;Byte&gt;)</summary>
        [PexMethod]
        public ActionResult DeleteTest([PexAssumeUnderTest]EstadoSolicitudCreditoController target, byte? id)
        {
            ActionResult result = target.Delete(id);
            return result;
            // TODO: agregar aserciones a método EstadoSolicitudCreditoControllerTest.DeleteTest(EstadoSolicitudCreditoController, Nullable`1<Byte>)
        }

        /// <summary>Código auxiliar de prueba para DeleteConfirmed(Byte)</summary>
        [PexMethod]
        public ActionResult DeleteConfirmedTest([PexAssumeUnderTest]EstadoSolicitudCreditoController target, byte id)
        {
            ActionResult result = target.DeleteConfirmed(id);
            return result;
            // TODO: agregar aserciones a método EstadoSolicitudCreditoControllerTest.DeleteConfirmedTest(EstadoSolicitudCreditoController, Byte)
        }

        /// <summary>Código auxiliar de prueba para Details(Nullable`1&lt;Byte&gt;)</summary>
        [PexMethod]
        public ActionResult DetailsTest([PexAssumeUnderTest]EstadoSolicitudCreditoController target, byte? id)
        {
            ActionResult result = target.Details(id);
            return result;
            // TODO: agregar aserciones a método EstadoSolicitudCreditoControllerTest.DetailsTest(EstadoSolicitudCreditoController, Nullable`1<Byte>)
        }

        /// <summary>Código auxiliar de prueba para Edit(Nullable`1&lt;Byte&gt;)</summary>
        [PexMethod]
        public ActionResult EditTest([PexAssumeUnderTest]EstadoSolicitudCreditoController target, byte? id)
        {
            ActionResult result = target.Edit(id);
            return result;
            // TODO: agregar aserciones a método EstadoSolicitudCreditoControllerTest.EditTest(EstadoSolicitudCreditoController, Nullable`1<Byte>)
        }

        /// <summary>Código auxiliar de prueba para Edit(tbEstadoSolicitudCredito)</summary>
        [PexMethod]
        public ActionResult EditTest01(
            [PexAssumeUnderTest]EstadoSolicitudCreditoController target,
            tbEstadoSolicitudCredito tbEstadoSolicitudCredito
        )
        {
            ActionResult result = target.Edit(tbEstadoSolicitudCredito);
            return result;
            // TODO: agregar aserciones a método EstadoSolicitudCreditoControllerTest.EditTest01(EstadoSolicitudCreditoController, tbEstadoSolicitudCredito)
        }

        /// <summary>Código auxiliar de prueba para Index()</summary>
        [PexMethod]
        public ActionResult IndexTest([PexAssumeUnderTest]EstadoSolicitudCreditoController target)
        {
            ActionResult result = target.Index();
            return result;
            // TODO: agregar aserciones a método EstadoSolicitudCreditoControllerTest.IndexTest(EstadoSolicitudCreditoController)
        }
    }
}
