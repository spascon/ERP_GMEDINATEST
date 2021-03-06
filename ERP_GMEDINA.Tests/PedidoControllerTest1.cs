using ERP_GMEDINA.Models;
using System.Web.Mvc;
// <copyright file="PedidoControllerTest.cs">Copyright ©  2014</copyright>

using System;
using ERP_ZORZAL.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ERP_ZORZAL.Controllers.Tests
{
    /// <summary>Esta clase contiene pruebas unitarias parametrizadas para PedidoController</summary>
    [TestClass]
    [PexClass(typeof(PedidoController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class PedidoControllerTest
    {

        /// <summary>Código auxiliar de prueba para .ctor()</summary>
        [PexMethod]
        public PedidoController ConstructorTest()
        {
            PedidoController target = new PedidoController();
            return target;
            // TODO: agregar aserciones a método PedidoControllerTest.ConstructorTest()
        }

        /// <summary>Código auxiliar de prueba para AnularPedido(Int32, Boolean, String)</summary>
        [PexMethod(MaxBranches = 320000)]
        public JsonResult AnularPedidoTest(
            [PexAssumeUnderTest]PedidoController target,
            int CodPedido,
            bool NoAnulado,
            string RazonAnulado
        )
        {
            JsonResult result = target.AnularPedido(CodPedido, NoAnulado, RazonAnulado);
            return result;
            // TODO: agregar aserciones a método PedidoControllerTest.AnularPedidoTest(PedidoController, Int32, Boolean, String)
        }

        /// <summary>Código auxiliar de prueba para Create()</summary>
        [PexMethod]
        public ActionResult CreateTest([PexAssumeUnderTest]PedidoController target)
        {
            ActionResult result = target.Create();
            return result;
            // TODO: agregar aserciones a método PedidoControllerTest.CreateTest(PedidoController)
        }

        /// <summary>Código auxiliar de prueba para Create(tbPedido)</summary>
        [PexMethod]
        public ActionResult CreateTest01([PexAssumeUnderTest]PedidoController target, tbPedido tbPedido)
        {
            ActionResult result = target.Create(tbPedido);
            return result;
            // TODO: agregar aserciones a método PedidoControllerTest.CreateTest01(PedidoController, tbPedido)
        }

        /// <summary>Código auxiliar de prueba para Delete(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public ActionResult DeleteTest([PexAssumeUnderTest]PedidoController target, int? id)
        {
            ActionResult result = target.Delete(id);
            return result;
            // TODO: agregar aserciones a método PedidoControllerTest.DeleteTest(PedidoController, Nullable`1<Int32>)
        }

        /// <summary>Código auxiliar de prueba para DeleteConfirmed(Int32)</summary>
        [PexMethod]
        public ActionResult DeleteConfirmedTest([PexAssumeUnderTest]PedidoController target, int id)
        {
            ActionResult result = target.DeleteConfirmed(id);
            return result;
            // TODO: agregar aserciones a método PedidoControllerTest.DeleteConfirmedTest(PedidoController, Int32)
        }

        /// <summary>Código auxiliar de prueba para Details(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public ActionResult DetailsTest([PexAssumeUnderTest]PedidoController target, int? id)
        {
            ActionResult result = target.Details(id);
            return result;
            // TODO: agregar aserciones a método PedidoControllerTest.DetailsTest(PedidoController, Nullable`1<Int32>)
        }

        /// <summary>Código auxiliar de prueba para Edit(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public ActionResult EditTest([PexAssumeUnderTest]PedidoController target, int? id)
        {
            ActionResult result = target.Edit(id);
            return result;
            // TODO: agregar aserciones a método PedidoControllerTest.EditTest(PedidoController, Nullable`1<Int32>)
        }

        /// <summary>Código auxiliar de prueba para Edit(Nullable`1&lt;Int32&gt;, tbPedido)</summary>
        [PexMethod]
        public ActionResult EditTest01(
            [PexAssumeUnderTest]PedidoController target,
            int? id,
            tbPedido tbPedido
        )
        {
            ActionResult result = target.Edit(id, tbPedido);
            return result;
            // TODO: agregar aserciones a método PedidoControllerTest.EditTest01(PedidoController, Nullable`1<Int32>, tbPedido)
        }

        /// <summary>Código auxiliar de prueba para EditPedido(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public ActionResult EditPedidoTest([PexAssumeUnderTest]PedidoController target, int? id)
        {
            ActionResult result = target.EditPedido(id);
            return result;
            // TODO: agregar aserciones a método PedidoControllerTest.EditPedidoTest(PedidoController, Nullable`1<Int32>)
        }

        /// <summary>Código auxiliar de prueba para EditPedido(Nullable`1&lt;Int32&gt;, tbPedido)</summary>
        [PexMethod]
        public ActionResult EditPedidoTest01(
            [PexAssumeUnderTest]PedidoController target,
            int? id,
            tbPedido tbPedido
        )
        {
            ActionResult result = target.EditPedido(id, tbPedido);
            return result;
            // TODO: agregar aserciones a método PedidoControllerTest.EditPedidoTest01(PedidoController, Nullable`1<Int32>, tbPedido)
        }

        /// <summary>Código auxiliar de prueba para Facturar(tbPedido)</summary>
        [PexMethod]
        public ActionResult FacturarTest([PexAssumeUnderTest]PedidoController target, tbPedido Pedido)
        {
            ActionResult result = target.Facturar(Pedido);
            return result;
            // TODO: agregar aserciones a método PedidoControllerTest.FacturarTest(PedidoController, tbPedido)
        }

        /// <summary>Código auxiliar de prueba para GetDetallePedido(Int32)</summary>
        [PexMethod]
        public JsonResult GetDetallePedidoTest([PexAssumeUnderTest]PedidoController target, int pedido)
        {
            JsonResult result = target.GetDetallePedido(pedido);
            return result;
            // TODO: agregar aserciones a método PedidoControllerTest.GetDetallePedidoTest(PedidoController, Int32)
        }

        /// <summary>Código auxiliar de prueba para GuardarPedidoDetalle(tbPedidoDetalle)</summary>
        [PexMethod]
        public JsonResult GuardarPedidoDetalleTest([PexAssumeUnderTest]PedidoController target, tbPedidoDetalle PedidoDetalles)
        {
            JsonResult result = target.GuardarPedidoDetalle(PedidoDetalles);
            return result;
            // TODO: agregar aserciones a método PedidoControllerTest.GuardarPedidoDetalleTest(PedidoController, tbPedidoDetalle)
        }

        /// <summary>Código auxiliar de prueba para Index()</summary>
        [PexMethod]
        public ActionResult IndexTest([PexAssumeUnderTest]PedidoController target)
        {
            ActionResult result = target.Index();
            return result;
            // TODO: agregar aserciones a método PedidoControllerTest.IndexTest(PedidoController)
        }

        /// <summary>Código auxiliar de prueba para IndexPedido()</summary>
        [PexMethod]
        public ActionResult IndexPedidoTest([PexAssumeUnderTest]PedidoController target)
        {
            ActionResult result = target.IndexPedido();
            return result;
            // TODO: agregar aserciones a método PedidoControllerTest.IndexPedidoTest(PedidoController)
        }

        /// <summary>Código auxiliar de prueba para QuitarPedidoDetalle(tbPedidoDetalle)</summary>
        [PexMethod]
        public JsonResult QuitarPedidoDetalleTest([PexAssumeUnderTest]PedidoController target, tbPedidoDetalle PedidoDetalle)
        {
            JsonResult result = target.QuitarPedidoDetalle(PedidoDetalle);
            return result;
            // TODO: agregar aserciones a método PedidoControllerTest.QuitarPedidoDetalleTest(PedidoController, tbPedidoDetalle)
        }

        /// <summary>Código auxiliar de prueba para SavePedidoDetalles(tbPedidoDetalle)</summary>
        [PexMethod]
        public JsonResult SavePedidoDetallesTest([PexAssumeUnderTest]PedidoController target, tbPedidoDetalle PedidoDetalle)
        {
            JsonResult result = target.SavePedidoDetalles(PedidoDetalle);
            return result;
            // TODO: agregar aserciones a método PedidoControllerTest.SavePedidoDetallesTest(PedidoController, tbPedidoDetalle)
        }

        /// <summary>Código auxiliar de prueba para UpdatePedidoDetalle(tbPedidoDetalle)</summary>
        [PexMethod]
        public ActionResult UpdatePedidoDetalleTest([PexAssumeUnderTest]PedidoController target, tbPedidoDetalle EditPedidoDetalle)
        {
            ActionResult result = target.UpdatePedidoDetalle(EditPedidoDetalle);
            return result;
            // TODO: agregar aserciones a método PedidoControllerTest.UpdatePedidoDetalleTest(PedidoController, tbPedidoDetalle)
        }

        /// <summary>Código auxiliar de prueba para _IndexCliente()</summary>
        [PexMethod]
        public ActionResult _IndexClienteTest([PexAssumeUnderTest]PedidoController target)
        {
            ActionResult result = target._IndexCliente();
            return result;
            // TODO: agregar aserciones a método PedidoControllerTest._IndexClienteTest(PedidoController)
        }

        /// <summary>Código auxiliar de prueba para _IndexProducto()</summary>
        [PexMethod]
        public ActionResult _IndexProductoTest([PexAssumeUnderTest]PedidoController target)
        {
            ActionResult result = target._IndexProducto();
            return result;
            // TODO: agregar aserciones a método PedidoControllerTest._IndexProductoTest(PedidoController)
        }

        /// <summary>Código auxiliar de prueba para getPedidoDetalle(Int32)</summary>
        [PexMethod]
        public JsonResult getPedidoDetalleTest([PexAssumeUnderTest]PedidoController target, int pedd_Id)
        {
            JsonResult result = target.getPedidoDetalle(pedd_Id);
            return result;
            // TODO: agregar aserciones a método PedidoControllerTest.getPedidoDetalleTest(PedidoController, Int32)
        }
    }
}
