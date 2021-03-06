// <copyright file="FacturaControllerTest.cs">Copyright ©  2014</copyright>
using System;
using System.Web.Mvc;
using ERP_GMEDINA.Controllers;
using ERP_GMEDINA.Models;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ERP_GMEDINA.Controllers.Tests
{


    /// <summary>This class contains parameterized unit tests for FacturaController</summary>
    [PexClass(typeof(FacturaController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class FacturaControllerTest
    {
        /// <summary>Test stub for AnularFactura(Int32, Boolean, String)</summary>
        [PexMethod(MaxBranches = 320000)]
        public JsonResult AnularFacturaTest(
            [PexAssumeUnderTest]FacturaController target,
            int CodFactura,
            bool FacturaAnulado,
            string RazonAnulado
        )
        {
            tbFactura Factura = new tbFactura() { fact_Id = 11,fact_EsAnulada=true,fact_RazonAnulado="dsadjldjsahsald" };
            JsonResult result = target.AnularFactura(CodFactura, FacturaAnulado, RazonAnulado);
            return result;
            // TODO: add assertions to method FacturaControllerTest.AnularFacturaTest(FacturaController, Int32, Boolean, String)
        }

        /// <summary>Test stub for BuscarCodigoBarras(Int32, String, Int32)</summary>
        [PexMethod]
        public ActionResult BuscarCodigoBarrasTest(
            [PexAssumeUnderTest]FacturaController target,
            int IDSucursal,
            string CodBarra,
            int IDCliente
        )
        {
            ActionResult result = target.BuscarCodigoBarras(IDSucursal, CodBarra, IDCliente)
              ;
            return result;
            // TODO: add assertions to method FacturaControllerTest.BuscarCodigoBarrasTest(FacturaController, Int32, String, Int32)
        }

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public FacturaController ConstructorTest()
        {
            FacturaController target = new FacturaController();
            return target;
            // TODO: add assertions to method FacturaControllerTest.ConstructorTest()
        }

        /// <summary>Test stub for ConsumidorFinal(DatosConsumidorFinal)</summary>
        [PexMethod]
        public JsonResult ConsumidorFinalTest(
            [PexAssumeUnderTest]FacturaController target,
            DatosConsumidorFinal ConsumidorFinal
        )
        {
            JsonResult result = target.ConsumidorFinal(ConsumidorFinal);
            return result;
            // TODO: add assertions to method FacturaControllerTest.ConsumidorFinalTest(FacturaController, DatosConsumidorFinal)
        }

        /// <summary>Test stub for Create()</summary>
        [PexMethod]
        public ActionResult CreateTest([PexAssumeUnderTest]FacturaController target)
        {
            ActionResult result = target.Create();
            return result;
            // TODO: add assertions to method FacturaControllerTest.CreateTest(FacturaController)
        }

        /// <summary>Test stub for Create(tbFactura)</summary>
        [PexMethod]
        public ActionResult CreateTest01(
            [PexAssumeUnderTest]FacturaController target,
            tbFactura tbFactura
        )
        {
            ActionResult result = target.Create(tbFactura);
            return result;
            // TODO: add assertions to method FacturaControllerTest.CreateTest01(FacturaController, tbFactura)
        }

        /// <summary>Test stub for Details(Nullable`1&lt;Int64&gt;)</summary>
        [PexMethod]
        public ActionResult DetailsTest(
            [PexAssumeUnderTest]FacturaController target,
            long? id
        )
        {
            ActionResult result = target.Details(id);
            return result;
            // TODO: add assertions to method FacturaControllerTest.DetailsTest(FacturaController, Nullable`1<Int64>)
        }

        /// <summary>Test stub for Edit(Nullable`1&lt;Int64&gt;)</summary>
        [PexMethod]
        public ActionResult EditTest(
            [PexAssumeUnderTest]FacturaController target,
            long? id
        )
        {
            ActionResult result = target.Edit(id);
            return result;
            // TODO: add assertions to method FacturaControllerTest.EditTest(FacturaController, Nullable`1<Int64>)
        }

        /// <summary>Test stub for Edit(tbFactura)</summary>
        [PexMethod]
        public ActionResult EditTest01(
            [PexAssumeUnderTest]FacturaController target,
            tbFactura tbFactura
        )
        {
            tbFactura factura = new tbFactura() {
            fact_Id = 11};
            ActionResult result = target.Edit(factura);
            return result;
            // TODO: add assertions to method FacturaControllerTest.EditTest01(FacturaController, tbFactura)
        }

        /// <summary>Test stub for GetCantidad(Int16, String)</summary>
        [PexMethod]
        public JsonResult GetCantidadTest(
            [PexAssumeUnderTest]FacturaController target,
            short CodSucursal,
            string CodProducto
        )
        {
            JsonResult result = target.GetCantidad(CodSucursal, CodProducto);
            return result;
            // TODO: add assertions to method FacturaControllerTest.GetCantidadTest(FacturaController, Int16, String)
        }

        /// <summary>Test stub for GetDetalleEdit(Int32)</summary>
        [PexMethod]
        public JsonResult GetDetalleEditTest([PexAssumeUnderTest]FacturaController target, int StudentId)
        {
            JsonResult result = target.GetDetalleEdit(StudentId);
            return result;
            // TODO: add assertions to method FacturaControllerTest.GetDetalleEditTest(FacturaController, Int32)
        }

        /// <summary>Test stub for GetDetallePedido(Int32)</summary>
        [PexMethod]
        public JsonResult GetDetallePedidoTest([PexAssumeUnderTest]FacturaController target, int CodPedido)
        {
            JsonResult result = target.GetDetallePedido(CodPedido);
            return result;
            // TODO: add assertions to method FacturaControllerTest.GetDetallePedidoTest(FacturaController, Int32)
        }

        /// <summary>Test stub for GetEmpleados(String)</summary>
        [PexMethod]
        public JsonResult GetEmpleadosTest([PexAssumeUnderTest]FacturaController target, string term)
        {
            JsonResult result = target.GetEmpleados(term);
            return result;
            // TODO: add assertions to method FacturaControllerTest.GetEmpleadosTest(FacturaController, String)
        }

        /// <summary>Test stub for GetFacturaDetalleD(Int64)</summary>
        [PexMethod]
        public ActionResult GetFacturaDetalleDTest([PexAssumeUnderTest]FacturaController target, long factID)
        {
            ActionResult result = target.GetFacturaDetalleD(factID);
            return result;
            // TODO: add assertions to method FacturaControllerTest.GetFacturaDetalleDTest(FacturaController, Int64)
        }

        /// <summary>Test stub for GetFacturaDetalle(Int64)</summary>
        [PexMethod]
        public ActionResult GetFacturaDetalleTest([PexAssumeUnderTest]FacturaController target, long factID)
        {
            ActionResult result = target.GetFacturaDetalle(factID);
            return result;
            // TODO: add assertions to method FacturaControllerTest.GetFacturaDetalleTest(FacturaController, Int64)
        }

        /// <summary>Test stub for GetNumeroFact(Int32, Int16)</summary>
        [PexMethod]
        public JsonResult GetNumeroFactTest(
            [PexAssumeUnderTest]FacturaController target,
            int CodSucursal,
            short CodCaja
        )
        {
            JsonResult result = target.GetNumeroFact(CodSucursal, CodCaja);
            return result;
            // TODO: add assertions to method FacturaControllerTest.GetNumeroFactTest(FacturaController, Int32, Int16)
        }

        /// <summary>Test stub for GetParametro()</summary>
        [PexMethod]
        public JsonResult GetParametroTest([PexAssumeUnderTest]FacturaController target)
        {
            JsonResult result = target.GetParametro();
            return result;
            // TODO: add assertions to method FacturaControllerTest.GetParametroTest(FacturaController)
        }

        /// <summary>Test stub for GetPrecio(Int32, String)</summary>
        [PexMethod]
        public JsonResult GetPrecioTest(
            [PexAssumeUnderTest]FacturaController target,
            int Cliente,
            string idItem
        )
        {
            JsonResult result = target.GetPrecio(Cliente, idItem);
            return result;
            // TODO: add assertions to method FacturaControllerTest.GetPrecioTest(FacturaController, Int32, String)
        }

        /// <summary>Test stub for IncrementarProducto(String)</summary>
        [PexMethod]
        public JsonResult IncrementarProductoTest(
            [PexAssumeUnderTest]FacturaController target,
            string data_producto
        )
        {
            JsonResult result = target.IncrementarProducto(data_producto);
            return result;
            // TODO: add assertions to method FacturaControllerTest.IncrementarProductoTest(FacturaController, String)
        }

        /// <summary>Test stub for Index()</summary>
        [PexMethod]
        public ActionResult IndexTest([PexAssumeUnderTest]FacturaController target)
        {
            ActionResult result = target.Index();
            return result;
            // TODO: add assertions to method FacturaControllerTest.IndexTest(FacturaController)
        }

        /// <summary>Test stub for Index(String, String, String)</summary>
        [PexMethod]
        public ActionResult IndexTest01(
            [PexAssumeUnderTest]FacturaController target,
            string cliente,
            string fecha,
            string caja
        )
        {
            ActionResult result = target.Index(cliente, fecha, caja);
            return result;
            // TODO: add assertions to method FacturaControllerTest.IndexTest01(FacturaController, String, String, String)
        }

        /// <summary>Test stub for RemoveFacturaDetalleEdit(tbFacturaDetalle)</summary>
        [PexMethod]
        public JsonResult RemoveFacturaDetalleEditTest(
            [PexAssumeUnderTest]FacturaController target,
            tbFacturaDetalle FacturaDetalleC
        )
        {
            JsonResult result = target.RemoveFacturaDetalleEdit(FacturaDetalleC);
            return result;
            // TODO: add assertions to method FacturaControllerTest.RemoveFacturaDetalleEditTest(FacturaController, tbFacturaDetalle)
        }

        /// <summary>Test stub for RemoveFacturaDetalle(tbFacturaDetalle)</summary>
        [PexMethod]
        public JsonResult RemoveFacturaDetalleTest(
            [PexAssumeUnderTest]FacturaController target,
            tbFacturaDetalle FacturaDetalleC
        )
        {
            JsonResult result = target.RemoveFacturaDetalle(FacturaDetalleC);
            return result;
            // TODO: add assertions to method FacturaControllerTest.RemoveFacturaDetalleTest(FacturaController, tbFacturaDetalle)
        }

        /// <summary>Test stub for SaveFacturaDetalleEdit(tbFacturaDetalle)</summary>
        [PexMethod]
        public JsonResult SaveFacturaDetalleEditTest(
            [PexAssumeUnderTest]FacturaController target,
            tbFacturaDetalle FacturaDetalleEdit
        )
        {
            JsonResult result = target.SaveFacturaDetalleEdit(FacturaDetalleEdit);
            return result;
            // TODO: add assertions to method FacturaControllerTest.SaveFacturaDetalleEditTest(FacturaController, tbFacturaDetalle)
        }

        /// <summary>Test stub for SaveFacturaDetalle(tbFacturaDetalle)</summary>
        [PexMethod]
        public JsonResult SaveFacturaDetalleTest(
            [PexAssumeUnderTest]FacturaController target,
            tbFacturaDetalle FacturaDetalleC
        )
        {
            JsonResult result = target.SaveFacturaDetalle(FacturaDetalleC);
            return result;
            // TODO: add assertions to method FacturaControllerTest.SaveFacturaDetalleTest(FacturaController, tbFacturaDetalle)
        }

        /// <summary>Test stub for SaveTerceraEdad(tbFactura)</summary>
        [PexMethod]
        public JsonResult SaveTerceraEdadTest(
            [PexAssumeUnderTest]FacturaController target,
            tbFactura TerceraEdadC
        )
        {
            JsonResult result = target.SaveTerceraEdad(TerceraEdadC);
            return result;
            // TODO: add assertions to method FacturaControllerTest.SaveTerceraEdadTest(FacturaController, tbFactura)
        }

        /// <summary>Test stub for UpdateFacturaDetalle(tbFacturaDetalle)</summary>
        [PexMethod]
        public ActionResult UpdateFacturaDetalleTest(
            [PexAssumeUnderTest]FacturaController target,
            tbFacturaDetalle EditFacturaDetalle
        )
        {
            ActionResult result = target.UpdateFacturaDetalle(EditFacturaDetalle);
            return result;
            // TODO: add assertions to method FacturaControllerTest.UpdateFacturaDetalleTest(FacturaController, tbFacturaDetalle)
        }

        /// <summary>Test stub for Validar()</summary>
        [PexMethod]
        public JsonResult ValidarTest([PexAssumeUnderTest]FacturaController target)
        {
            JsonResult result = target.Validar();
            return result;
            // TODO: add assertions to method FacturaControllerTest.ValidarTest(FacturaController)
        }

        /// <summary>Test stub for _CreateCliente()</summary>
        [PexMethod(MaxBranches = 320000, MaxConditions = 1000)]
        public ActionResult _CreateClienteTest([PexAssumeUnderTest]FacturaController target)
        {
            ActionResult result = target._CreateCliente();
            return result;
            // TODO: add assertions to method FacturaControllerTest._CreateClienteTest(FacturaController)
        }

        /// <summary>Test stub for _CreateCliente(tbCliente, String)</summary>
        [PexMethod(Timeout = 240)]
        public ActionResult _CreateClienteTest01(
            [PexAssumeUnderTest]FacturaController target,
            tbCliente tbCliente,
            string dep_Codigo
        )
        {
            ActionResult result = target._CreateCliente(tbCliente, dep_Codigo);
            return result;
            // TODO: add assertions to method FacturaControllerTest._CreateClienteTest01(FacturaController, tbCliente, String)
        }
       
    }
}
