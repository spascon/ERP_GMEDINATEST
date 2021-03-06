using ERP_GMEDINA.Models;
using System.Web.Mvc;
using System;
using ERP_GMEDINA.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ERP_GMEDINA.Controllers.Tests
{
    /// <summary>Esta clase contiene pruebas unitarias parametrizadas para CuponDescuentoController</summary>
    [TestClass]
    [PexClass(typeof(CuponDescuentoController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class CuponDescuentoControllerTest
    {

        /// <summary>Código auxiliar de prueba para .ctor()</summary>
        [PexMethod]
        public CuponDescuentoController ConstructorTest()
        {
            CuponDescuentoController target = new CuponDescuentoController();
            return target;
            // TODO: agregar aserciones a método CuponDescuentoControllerTest.ConstructorTest()
        }

        /// <summary>Código auxiliar de prueba para AnularCuponDescuento(Int32, Boolean)</summary>
        [PexMethod(MaxBranches = 320000)]
        public JsonResult AnularCuponDescuentoTest(
            [PexAssumeUnderTest]CuponDescuentoController target,
            int cdtoId,
            bool Anulada
        )
        {
            JsonResult result = target.AnularCuponDescuento(cdtoId, Anulada);
            return result;
            // TODO: agregar aserciones a método CuponDescuentoControllerTest.AnularCuponDescuentoTest(CuponDescuentoController, Int32, Boolean)
        }

        /// <summary>Código auxiliar de prueba para Create()</summary>
        [PexMethod]
        public ActionResult CreateTest([PexAssumeUnderTest]CuponDescuentoController target)
        {
            ActionResult result = target.Create();
            return result;
            // TODO: agregar aserciones a método CuponDescuentoControllerTest.CreateTest(CuponDescuentoController)
        }

        /// <summary>Código auxiliar de prueba para Create(tbCuponDescuento)</summary>
        [PexMethod]
        public ActionResult CreateTest01([PexAssumeUnderTest]CuponDescuentoController target, tbCuponDescuento tbCuponDescuento)
        {
            ActionResult result = target.Create(tbCuponDescuento);
            return result;
            // TODO: agregar aserciones a método CuponDescuentoControllerTest.CreateTest01(CuponDescuentoController, tbCuponDescuento)
        }

        /// <summary>Código auxiliar de prueba para Delete(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public ActionResult DeleteTest([PexAssumeUnderTest]CuponDescuentoController target, int? id)
        {
            ActionResult result = target.Delete(id);
            return result;
            // TODO: agregar aserciones a método CuponDescuentoControllerTest.DeleteTest(CuponDescuentoController, Nullable`1<Int32>)
        }

        /// <summary>Código auxiliar de prueba para DeleteConfirmed(Int32)</summary>
        [PexMethod]
        public ActionResult DeleteConfirmedTest([PexAssumeUnderTest]CuponDescuentoController target, int id)
        {
            ActionResult result = target.DeleteConfirmed(id);
            return result;
            // TODO: agregar aserciones a método CuponDescuentoControllerTest.DeleteConfirmedTest(CuponDescuentoController, Int32)
        }

        /// <summary>Código auxiliar de prueba para Details(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod(MaxConstraintSolverTime = 2)]
        public ActionResult DetailsTest([PexAssumeUnderTest]CuponDescuentoController target, int? id)
        {
            ActionResult result = target.Details(id);
            return result;
            // TODO: agregar aserciones a método CuponDescuentoControllerTest.DetailsTest(CuponDescuentoController, Nullable`1<Int32>)
        }

        /// <summary>Código auxiliar de prueba para Edit(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public ActionResult EditTest([PexAssumeUnderTest]CuponDescuentoController target, int? id)
        {
            ActionResult result = target.Edit(id);
            return result;
            // TODO: agregar aserciones a método CuponDescuentoControllerTest.EditTest(CuponDescuentoController, Nullable`1<Int32>)
        }

        /// <summary>Código auxiliar de prueba para Edit(tbCuponDescuento)</summary>
        [PexMethod]
        public ActionResult EditTest01([PexAssumeUnderTest]CuponDescuentoController target, tbCuponDescuento tbCuponDescuento)
        {
            ActionResult result = target.Edit(tbCuponDescuento);
            return result;
            // TODO: agregar aserciones a método CuponDescuentoControllerTest.EditTest01(CuponDescuentoController, tbCuponDescuento)
        }

        /// <summary>Código auxiliar de prueba para Index()</summary>
        [PexMethod]
        public ActionResult IndexTest([PexAssumeUnderTest]CuponDescuentoController target)
        {
            ActionResult result = target.Index();
            return result;
            // TODO: agregar aserciones a método CuponDescuentoControllerTest.IndexTest(CuponDescuentoController)
        }
    }
}
