using ERP_GMEDINA.Models;
using System.Web.Mvc;
// <copyright file="DevolucionControllerTest.cs">Copyright ©  2014</copyright>

using System;
using ERP_ZORZAL.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ERP_ZORZAL.Controllers.Tests
{
    /// <summary>Esta clase contiene pruebas unitarias parametrizadas para DevolucionController</summary>
    [TestClass]
    [PexClass(typeof(DevolucionController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class DevolucionControllerTest
    {

        /// <summary>Código auxiliar de prueba para .ctor()</summary>
        [PexMethod]
        public DevolucionController ConstructorTest()
        {
            DevolucionController target = new DevolucionController();
            return target;
            // TODO: agregar aserciones a método DevolucionControllerTest.ConstructorTest()
        }

        /// <summary>Código auxiliar de prueba para AnularDevolucion(Int32, Boolean)</summary>
        [PexMethod(MaxBranches = 320000)]
        public JsonResult AnularDevolucionTest(
            [PexAssumeUnderTest]DevolucionController target,
            int CodDevolucion,
            bool Estado
        )
        {
            JsonResult result = target.AnularDevolucion(CodDevolucion, Estado);
            return result;
            // TODO: agregar aserciones a método DevolucionControllerTest.AnularDevolucionTest(DevolucionController, Int32, Boolean)
        }

        /// <summary>Código auxiliar de prueba para BuscarCodigoProducto(Int32, String)</summary>
        [PexMethod]
        public ActionResult BuscarCodigoProductoTest(
            [PexAssumeUnderTest]DevolucionController target,
            int CodFactura,
            string CodProducto
        )
        {
            ActionResult result = target.BuscarCodigoProducto(CodFactura, CodProducto);
            return result;
            // TODO: agregar aserciones a método DevolucionControllerTest.BuscarCodigoProductoTest(DevolucionController, Int32, String)
        }

        /// <summary>Código auxiliar de prueba para Create()</summary>
        [PexMethod]
        public ActionResult CreateTest([PexAssumeUnderTest]DevolucionController target)
        {
            ActionResult result = target.Create();
            return result;
            // TODO: agregar aserciones a método DevolucionControllerTest.CreateTest(DevolucionController)
        }

        /// <summary>Código auxiliar de prueba para Create(tbDevolucion)</summary>
        [PexMethod]
        public ActionResult CreateTest01([PexAssumeUnderTest]DevolucionController target, tbDevolucion tbDevolucion)
        {
            ActionResult result = target.Create(tbDevolucion);
            return result;
            // TODO: agregar aserciones a método DevolucionControllerTest.CreateTest01(DevolucionController, tbDevolucion)
        }

        /// <summary>Código auxiliar de prueba para CreateNotaCredito()</summary>
        [PexMethod]
        public ActionResult CreateNotaCreditoTest([PexAssumeUnderTest]DevolucionController target)
        {
            ActionResult result = target.CreateNotaCredito();
            return result;
            // TODO: agregar aserciones a método DevolucionControllerTest.CreateNotaCreditoTest(DevolucionController)
        }

        /// <summary>Código auxiliar de prueba para CreateNotaCredito(tbNotaCredito)</summary>
        [PexMethod]
        public ActionResult CreateNotaCreditoTest01([PexAssumeUnderTest]DevolucionController target, tbNotaCredito tbNotaCredito)
        {
            ActionResult result = target.CreateNotaCredito(tbNotaCredito);
            return result;
            // TODO: agregar aserciones a método DevolucionControllerTest.CreateNotaCreditoTest01(DevolucionController, tbNotaCredito)
        }

        /// <summary>Código auxiliar de prueba para Delete(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public ActionResult DeleteTest([PexAssumeUnderTest]DevolucionController target, int? id)
        {
            ActionResult result = target.Delete(id);
            return result;
            // TODO: agregar aserciones a método DevolucionControllerTest.DeleteTest(DevolucionController, Nullable`1<Int32>)
        }

        /// <summary>Código auxiliar de prueba para DeleteConfirmed(Int32)</summary>
        [PexMethod]
        public ActionResult DeleteConfirmedTest([PexAssumeUnderTest]DevolucionController target, int id)
        {
            ActionResult result = target.DeleteConfirmed(id);
            return result;
            // TODO: agregar aserciones a método DevolucionControllerTest.DeleteConfirmedTest(DevolucionController, Int32)
        }

        /// <summary>Código auxiliar de prueba para Details(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public ActionResult DetailsTest([PexAssumeUnderTest]DevolucionController target, int? id)
        {
            ActionResult result = target.Details(id);
            return result;
            // TODO: agregar aserciones a método DevolucionControllerTest.DetailsTest(DevolucionController, Nullable`1<Int32>)
        }

        /// <summary>Código auxiliar de prueba para Edit(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public ActionResult EditTest([PexAssumeUnderTest]DevolucionController target, int? id)
        {
            ActionResult result = target.Edit(id);
            return result;
            // TODO: agregar aserciones a método DevolucionControllerTest.EditTest(DevolucionController, Nullable`1<Int32>)
        }

        /// <summary>Código auxiliar de prueba para Edit(tbDevolucion)</summary>
        [PexMethod]
        public ActionResult EditTest01([PexAssumeUnderTest]DevolucionController target, tbDevolucion tbDevolucion)
        {
            ActionResult result = target.Edit(tbDevolucion);
            return result;
            // TODO: agregar aserciones a método DevolucionControllerTest.EditTest01(DevolucionController, tbDevolucion)
        }

        /// <summary>Código auxiliar de prueba para EmitirNotaCredito(tbDevolucion)</summary>
        [PexMethod]
        [PexAllowedException(typeof(NullReferenceException))]
        public ActionResult EmitirNotaCreditoTest([PexAssumeUnderTest]DevolucionController target, tbDevolucion Devolucion)
        {
            ActionResult result = target.EmitirNotaCredito(Devolucion);
            return result;
            // TODO: agregar aserciones a método DevolucionControllerTest.EmitirNotaCreditoTest(DevolucionController, tbDevolucion)
        }

        /// <summary>Código auxiliar de prueba para FiltrarModal(String)</summary>
        [PexMethod(MaxConditions = 81000)]
        public JsonResult FiltrarModalTest([PexAssumeUnderTest]DevolucionController target, string CodCliente)
        {
            JsonResult result = target.FiltrarModal(CodCliente);
            return result;
            // TODO: agregar aserciones a método DevolucionControllerTest.FiltrarModalTest(DevolucionController, String)
        }

        /// <summary>Código auxiliar de prueba para FiltrarModalProducto(Int32)</summary>
        [PexMethod]
        public JsonResult FiltrarModalProductoTest([PexAssumeUnderTest]DevolucionController target, int FacturaID)
        {
            JsonResult result = target.FiltrarModalProducto(FacturaID);
            return result;
            // TODO: agregar aserciones a método DevolucionControllerTest.FiltrarModalProductoTest(DevolucionController, Int32)
        }

        /// <summary>Código auxiliar de prueba para GetDevolucionDetalle(Int64)</summary>
        [PexMethod]
        public JsonResult GetDevolucionDetalleTest([PexAssumeUnderTest]DevolucionController target, long devolucionId)
        {
            JsonResult result = target.GetDevolucionDetalle(devolucionId);
            return result;
            // TODO: agregar aserciones a método DevolucionControllerTest.GetDevolucionDetalleTest(DevolucionController, Int64)
        }

        /// <summary>Código auxiliar de prueba para GetDevolucionDetalleEditar(Int64)</summary>
        [PexMethod]
        public JsonResult GetDevolucionDetalleEditarTest([PexAssumeUnderTest]DevolucionController target, long DetalleDevID)
        {
            JsonResult result = target.GetDevolucionDetalleEditar(DetalleDevID);
            return result;
            // TODO: agregar aserciones a método DevolucionControllerTest.GetDevolucionDetalleEditarTest(DevolucionController, Int64)
        }

        /// <summary>Código auxiliar de prueba para Index()</summary>
        [PexMethod]
        public ActionResult IndexTest([PexAssumeUnderTest]DevolucionController target)
        {
            ActionResult result = target.Index();
            return result;
            // TODO: agregar aserciones a método DevolucionControllerTest.IndexTest(DevolucionController)
        }

        /// <summary>Código auxiliar de prueba para InsertDevolucion(tbDevolucionDetalle)</summary>
        [PexMethod]
        public JsonResult InsertDevolucionTest([PexAssumeUnderTest]DevolucionController target, tbDevolucionDetalle DetalleDevolucioncont)
        {
            JsonResult result = target.InsertDevolucion(DetalleDevolucioncont);
            return result;
            // TODO: agregar aserciones a método DevolucionControllerTest.InsertDevolucionTest(DevolucionController, tbDevolucionDetalle)
        }

        /// <summary>Código auxiliar de prueba para RemoveDevolucionDetalle(tbDevolucionDetalle)</summary>
        [PexMethod]
        public JsonResult RemoveDevolucionDetalleTest([PexAssumeUnderTest]DevolucionController target, tbDevolucionDetalle DetalleDevolucioncont)
        {
            JsonResult result = target.RemoveDevolucionDetalle(DetalleDevolucioncont);
            return result;
            // TODO: agregar aserciones a método DevolucionControllerTest.RemoveDevolucionDetalleTest(DevolucionController, tbDevolucionDetalle)
        }

        /// <summary>Código auxiliar de prueba para UpdateDevolucionDetalle(tbDevolucionDetalle)</summary>
        [PexMethod]
        public ActionResult UpdateDevolucionDetalleTest([PexAssumeUnderTest]DevolucionController target, tbDevolucionDetalle EditDevolucionDetalle)
        {
            ActionResult result = target.UpdateDevolucionDetalle(EditDevolucionDetalle);
            return result;
            // TODO: agregar aserciones a método DevolucionControllerTest.UpdateDevolucionDetalleTest(DevolucionController, tbDevolucionDetalle)
        }

        /// <summary>Código auxiliar de prueba para _CreateDevolucionDetalle()</summary>
        [PexMethod(MaxConditions = 8000)]
        public ActionResult _CreateDevolucionDetalleTest([PexAssumeUnderTest]DevolucionController target)
        {
            ActionResult result = target._CreateDevolucionDetalle();
            return result;
            // TODO: agregar aserciones a método DevolucionControllerTest._CreateDevolucionDetalleTest(DevolucionController)
        }

        /// <summary>Código auxiliar de prueba para _CreateDevolucionDetalle1()</summary>
        [PexMethod]
        public ActionResult _CreateDevolucionDetalle1Test([PexAssumeUnderTest]DevolucionController target)
        {
            ActionResult result = target._CreateDevolucionDetalle1();
            return result;
            // TODO: agregar aserciones a método DevolucionControllerTest._CreateDevolucionDetalle1Test(DevolucionController)
        }
    }
}
