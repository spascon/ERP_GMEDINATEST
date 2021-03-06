using ERP_GMEDINA.Models;
using System.Web.Mvc;
// <copyright file="ListaPreciosControllerTest.cs">Copyright ©  2014</copyright>

using System;
using ERP_GMEDINA.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ERP_GMEDINA.Controllers.Tests
{
    /// <summary>Esta clase contiene pruebas unitarias parametrizadas para ListaPreciosController</summary>
    [TestClass]
    [PexClass(typeof(ListaPreciosController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ListaPreciosControllerTest
    {

        /// <summary>Código auxiliar de prueba para .ctor()</summary>
        [PexMethod]
        public ListaPreciosController ConstructorTest()
        {
            ListaPreciosController target = new ListaPreciosController();
            return target;
            // TODO: agregar aserciones a método ListaPreciosControllerTest.ConstructorTest()
        }

        /// <summary>Código auxiliar de prueba para ActivarListaPrecio(Int32, Boolean)</summary>
        [PexMethod(MaxBranches = 320000)]
        public JsonResult ActivarListaPrecioTest(
            [PexAssumeUnderTest]ListaPreciosController target,
            int CodLp,
            bool Activo
        )
        {
            JsonResult result = target.ActivarListaPrecio(CodLp, Activo);
            return result;
            // TODO: agregar aserciones a método ListaPreciosControllerTest.ActivarListaPrecioTest(ListaPreciosController, Int32, Boolean)
        }

        /// <summary>Código auxiliar de prueba para Create()</summary>
        [PexMethod]
        public ActionResult CreateTest([PexAssumeUnderTest]ListaPreciosController target)
        {
            ActionResult result = target.Create();
            return result;
            // TODO: agregar aserciones a método ListaPreciosControllerTest.CreateTest(ListaPreciosController)
        }

        /// <summary>Código auxiliar de prueba para Create(tbListaPrecio)</summary>
        [PexMethod]
        public ActionResult CreateTest01([PexAssumeUnderTest]ListaPreciosController target, tbListaPrecio tbListaPrecio)
        {
            ActionResult result = target.Create(tbListaPrecio);
            return result;
            // TODO: agregar aserciones a método ListaPreciosControllerTest.CreateTest01(ListaPreciosController, tbListaPrecio)
        }

        /// <summary>Código auxiliar de prueba para Delete(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public ActionResult DeleteTest([PexAssumeUnderTest]ListaPreciosController target, int? id)
        {
            ActionResult result = target.Delete(id);
            return result;
            // TODO: agregar aserciones a método ListaPreciosControllerTest.DeleteTest(ListaPreciosController, Nullable`1<Int32>)
        }

        /// <summary>Código auxiliar de prueba para DeleteConfirmed(Int32)</summary>
        [PexMethod]
        public ActionResult DeleteConfirmedTest([PexAssumeUnderTest]ListaPreciosController target, int id)
        {
            ActionResult result = target.DeleteConfirmed(id);
            return result;
            // TODO: agregar aserciones a método ListaPreciosControllerTest.DeleteConfirmedTest(ListaPreciosController, Int32)
        }

        /// <summary>Código auxiliar de prueba para Details(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public ActionResult DetailsTest([PexAssumeUnderTest]ListaPreciosController target, int? id)
        {
            ActionResult result = target.Details(id);
            return result;
            // TODO: agregar aserciones a método ListaPreciosControllerTest.DetailsTest(ListaPreciosController, Nullable`1<Int32>)
        }

        /// <summary>Código auxiliar de prueba para Edit(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public ActionResult EditTest([PexAssumeUnderTest]ListaPreciosController target, int? id)
        {
            ActionResult result = target.Edit(id);
            return result;
            // TODO: agregar aserciones a método ListaPreciosControllerTest.EditTest(ListaPreciosController, Nullable`1<Int32>)
        }

        /// <summary>Código auxiliar de prueba para Edit(tbListaPrecio)</summary>
        [PexMethod]
        public ActionResult EditTest01([PexAssumeUnderTest]ListaPreciosController target, tbListaPrecio tbListaPrecio)
        {
            ActionResult result = target.Edit(tbListaPrecio);
            return result;
            // TODO: agregar aserciones a método ListaPreciosControllerTest.EditTest01(ListaPreciosController, tbListaPrecio)
        }

        /// <summary>Código auxiliar de prueba para GetListadoDetalleEdit(Int32)</summary>
        [PexMethod]
        public ActionResult GetListadoDetalleEditTest([PexAssumeUnderTest]ListaPreciosController target, int listp_Id)
        {
            ActionResult result = target.GetListadoDetalleEdit(listp_Id);
            return result;
            // TODO: agregar aserciones a método ListaPreciosControllerTest.GetListadoDetalleEditTest(ListaPreciosController, Int32)
        }

        /// <summary>Código auxiliar de prueba para GuardarListadoPrecioDetalle(tbListadoPrecioDetalle)</summary>
        [PexMethod]
        public JsonResult GuardarListadoPrecioDetalleTest(
            [PexAssumeUnderTest]ListaPreciosController target,
            tbListadoPrecioDetalle ListadoPrecioDetalles
        )
        {
            JsonResult result = target.GuardarListadoPrecioDetalle(ListadoPrecioDetalles);
            return result;
            // TODO: agregar aserciones a método ListaPreciosControllerTest.GuardarListadoPrecioDetalleTest(ListaPreciosController, tbListadoPrecioDetalle)
        }

        /// <summary>Código auxiliar de prueba para InactivarListaPrecio(Int32, Boolean)</summary>
        [PexMethod]
        public JsonResult InactivarListaPrecioTest(
            [PexAssumeUnderTest]ListaPreciosController target,
            int CodLp,
            bool Activo
        )
        {
            JsonResult result = target.InactivarListaPrecio(CodLp, Activo);
            return result;
            // TODO: agregar aserciones a método ListaPreciosControllerTest.InactivarListaPrecioTest(ListaPreciosController, Int32, Boolean)
        }

        /// <summary>Código auxiliar de prueba para Index()</summary>
        [PexMethod]
        public ActionResult IndexTest([PexAssumeUnderTest]ListaPreciosController target)
        {
            ActionResult result = target.Index();
            return result;
            // TODO: agregar aserciones a método ListaPreciosControllerTest.IndexTest(ListaPreciosController)
        }

        /// <summary>Código auxiliar de prueba para QuitarPrecioDetalle(tbListadoPrecioDetalle)</summary>
        [PexMethod]
        public JsonResult QuitarPrecioDetalleTest(
            [PexAssumeUnderTest]ListaPreciosController target,
            tbListadoPrecioDetalle ListadoPrecioDetalle
        )
        {
            JsonResult result = target.QuitarPrecioDetalle(ListadoPrecioDetalle);
            return result;
            // TODO: agregar aserciones a método ListaPreciosControllerTest.QuitarPrecioDetalleTest(ListaPreciosController, tbListadoPrecioDetalle)
        }

        /// <summary>Código auxiliar de prueba para SaveDetalleEdit(tbListadoPrecioDetalle)</summary>
        [PexMethod]
        public JsonResult SaveDetalleEditTest(
            [PexAssumeUnderTest]ListaPreciosController target,
            tbListadoPrecioDetalle FacturaDetalleEdit
        )
        {
            JsonResult result = target.SaveDetalleEdit(FacturaDetalleEdit);
            return result;
            // TODO: agregar aserciones a método ListaPreciosControllerTest.SaveDetalleEditTest(ListaPreciosController, tbListadoPrecioDetalle)
        }

        /// <summary>Código auxiliar de prueba para SaveFacturaDetalleEdit(tbFacturaDetalle)</summary>
        [PexMethod]
        public JsonResult SaveFacturaDetalleEditTest([PexAssumeUnderTest]ListaPreciosController target, tbFacturaDetalle FacturaDetalleEdit)
        {
            JsonResult result = target.SaveFacturaDetalleEdit(FacturaDetalleEdit);
            return result;
            // TODO: agregar aserciones a método ListaPreciosControllerTest.SaveFacturaDetalleEditTest(ListaPreciosController, tbFacturaDetalle)
        }

        /// <summary>Código auxiliar de prueba para SaveListaPrecioDetalle(tbListadoPrecioDetalle)</summary>
        [PexMethod]
        public JsonResult SaveListaPrecioDetalleTest([PexAssumeUnderTest]ListaPreciosController target, tbListadoPrecioDetalle ListaDetalle)
        {
            JsonResult result = target.SaveListaPrecioDetalle(ListaDetalle);
            return result;
            // TODO: agregar aserciones a método ListaPreciosControllerTest.SaveListaPrecioDetalleTest(ListaPreciosController, tbListadoPrecioDetalle)
        }

        /// <summary>Código auxiliar de prueba para UpdateListadoPrecioDetalle(tbListadoPrecioDetalle)</summary>
        [PexMethod]
        public ActionResult UpdateListadoPrecioDetalleTest(
            [PexAssumeUnderTest]ListaPreciosController target,
            tbListadoPrecioDetalle EditListadoPrecioDetalle
        )
        {
            ActionResult result = target.UpdateListadoPrecioDetalle(EditListadoPrecioDetalle);
            return result;
            // TODO: agregar aserciones a método ListaPreciosControllerTest.UpdateListadoPrecioDetalleTest(ListaPreciosController, tbListadoPrecioDetalle)
        }

        /// <summary>Código auxiliar de prueba para getListadoPrecioDetalle(Int32)</summary>
        [PexMethod]
        public JsonResult getListadoPrecioDetalleTest([PexAssumeUnderTest]ListaPreciosController target, int lispd_Id)
        {
            JsonResult result = target.getListadoPrecioDetalle(lispd_Id);
            return result;
            // TODO: agregar aserciones a método ListaPreciosControllerTest.getListadoPrecioDetalleTest(ListaPreciosController, Int32)
        }
    }
}
