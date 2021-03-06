using ERP_GMEDINA.Models;
using System.Web.Mvc;
using System;
using ERP_GMEDINA.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ERP_GMEDINA.Controllers.Tests
{
    /// <summary>This class contains parameterized unit tests for MovimientoCajaController</summary>
    [TestClass]
    [PexClass(typeof(MovimientoCajaController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class MovimientoCajaControllerTest
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod(MaxBranches = 320000)]
        public MovimientoCajaController ConstructorTest()
        {
            MovimientoCajaController target = new MovimientoCajaController();
            return target;
            // TODO: add assertions to method MovimientoCajaControllerTest.ConstructorTest()
        }

        /// <summary>Test stub for CreateApertura()</summary>
        [PexMethod]
        public ActionResult CreateAperturaTest([PexAssumeUnderTest]MovimientoCajaController target)
        {
            ActionResult result = target.CreateApertura();
            return result;
            // TODO: add assertions to method MovimientoCajaControllerTest.CreateAperturaTest(MovimientoCajaController)
        }

        /// <summary>Test stub for CreateApertura(tbMovimientoCaja)</summary>
        [PexMethod]
        public ActionResult CreateAperturaTest01([PexAssumeUnderTest]MovimientoCajaController target, tbMovimientoCaja tbMovimientoCaja)
        {
            ActionResult result = target.CreateApertura(tbMovimientoCaja);
            return result;
            // TODO: add assertions to method MovimientoCajaControllerTest.CreateAperturaTest01(MovimientoCajaController, tbMovimientoCaja)
        }

        /// <summary>Test stub for GetDenominacion(Int32)</summary>
        [PexMethod]
        public JsonResult GetDenominacionTest([PexAssumeUnderTest]MovimientoCajaController target, int CodMoneda)
        {
            JsonResult result = target.GetDenominacion(CodMoneda);
            return result;
            // TODO: add assertions to method MovimientoCajaControllerTest.GetDenominacionTest(MovimientoCajaController, Int32)
        }

        /// <summary>Test stub for IndexApertura()</summary>
        [PexMethod]
        public ActionResult IndexAperturaTest([PexAssumeUnderTest]MovimientoCajaController target)
        {
            ActionResult result = target.IndexApertura();
            return result;
            // TODO: add assertions to method MovimientoCajaControllerTest.IndexAperturaTest(MovimientoCajaController)
        }

        /// <summary>Test stub for SaveSolicitudEfectivoDetalle(tbSolicitudEfectivoDetalle)</summary>
        [PexMethod]
        public JsonResult SaveSolicitudEfectivoDetalleTest(
            [PexAssumeUnderTest]MovimientoCajaController target,
            tbSolicitudEfectivoDetalle SolicitudEfectivoDet
        )
        {
            JsonResult result = target.SaveSolicitudEfectivoDetalle(SolicitudEfectivoDet);
            return result;
            // TODO: add assertions to method MovimientoCajaControllerTest.SaveSolicitudEfectivoDetalleTest(MovimientoCajaController, tbSolicitudEfectivoDetalle)
        }

        /// <summary>Test stub for SaveSolicitudEfectivoMoneda(tbSolicitudEfectivo)</summary>
        [PexMethod]
        public JsonResult SaveSolicitudEfectivoMonedaTest(
            [PexAssumeUnderTest]MovimientoCajaController target,
            tbSolicitudEfectivo SolicitudEfectivoMon
        )
        {
            JsonResult result = target.SaveSolicitudEfectivoMoneda(SolicitudEfectivoMon);
            return result;
            // TODO: add assertions to method MovimientoCajaControllerTest.SaveSolicitudEfectivoMonedaTest(MovimientoCajaController, tbSolicitudEfectivo)
        }
    }
}
