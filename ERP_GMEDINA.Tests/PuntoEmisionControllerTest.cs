using ERP_GMEDINA.Models;
using System.Web.Mvc;
using System;
using ERP_ZORZAL.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ERP_ZORZAL.Controllers.Tests
{
    /// <summary>This class contains parameterized unit tests for PuntoEmisionController</summary>
    [TestClass]
    [PexClass(typeof(PuntoEmisionController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class PuntoEmisionControllerTest
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod(MaxBranches = 320000)]
        public PuntoEmisionController ConstructorTest()
        {
            PuntoEmisionController target = new PuntoEmisionController();
            return target;
            // TODO: add assertions to method PuntoEmisionControllerTest.ConstructorTest()
        }

        /// <summary>Test stub for Create()</summary>
        [PexMethod]
        public ActionResult CreateTest([PexAssumeUnderTest]PuntoEmisionController target)
        {
            ActionResult result = target.Create();
            return result;
            // TODO: add assertions to method PuntoEmisionControllerTest.CreateTest(PuntoEmisionController)
        }

        /// <summary>Test stub for Create(tbPuntoEmision)</summary>
        [PexMethod]
        public ActionResult CreateTest01([PexAssumeUnderTest]PuntoEmisionController target, tbPuntoEmision tbPuntoEmision)
        {
            ActionResult result = target.Create(tbPuntoEmision);
            return result;
            // TODO: add assertions to method PuntoEmisionControllerTest.CreateTest01(PuntoEmisionController, tbPuntoEmision)
        }

        /// <summary>Test stub for Delete(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public ActionResult DeleteTest([PexAssumeUnderTest]PuntoEmisionController target, int? id)
        {
            ActionResult result = target.Delete(id);
            return result;
            // TODO: add assertions to method PuntoEmisionControllerTest.DeleteTest(PuntoEmisionController, Nullable`1<Int32>)
        }

        /// <summary>Test stub for DeleteConfirmed(Int32)</summary>
        [PexMethod]
        public ActionResult DeleteConfirmedTest([PexAssumeUnderTest]PuntoEmisionController target, int id)
        {
            ActionResult result = target.DeleteConfirmed(id);
            return result;
            // TODO: add assertions to method PuntoEmisionControllerTest.DeleteConfirmedTest(PuntoEmisionController, Int32)
        }

        /// <summary>Test stub for Details(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public ActionResult DetailsTest([PexAssumeUnderTest]PuntoEmisionController target, int? id)
        {
            ActionResult result = target.Details(id);
            return result;
            // TODO: add assertions to method PuntoEmisionControllerTest.DetailsTest(PuntoEmisionController, Nullable`1<Int32>)
        }

        /// <summary>Test stub for Edit(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public ActionResult EditTest([PexAssumeUnderTest]PuntoEmisionController target, int? id)
        {
            ActionResult result = target.Edit(id);
            return result;
            // TODO: add assertions to method PuntoEmisionControllerTest.EditTest(PuntoEmisionController, Nullable`1<Int32>)
        }

        /// <summary>Test stub for Edit(tbPuntoEmision)</summary>
        [PexMethod]
        public ActionResult EditTest01([PexAssumeUnderTest]PuntoEmisionController target, tbPuntoEmision PuntoEmision)
        {
            ActionResult result = target.Edit(PuntoEmision);
            return result;
            // TODO: add assertions to method PuntoEmisionControllerTest.EditTest01(PuntoEmisionController, tbPuntoEmision)
        }

        /// <summary>Test stub for Index()</summary>
        [PexMethod]
        public ActionResult IndexTest([PexAssumeUnderTest]PuntoEmisionController target)
        {
            ActionResult result = target.Index();
            return result;
            // TODO: add assertions to method PuntoEmisionControllerTest.IndexTest(PuntoEmisionController)
        }

        /// <summary>Test stub for RemovePuntoEmisionDetalle(tbPuntoEmisionDetalle)</summary>
        [PexMethod]
        public JsonResult RemovePuntoEmisionDetalleTest([PexAssumeUnderTest]PuntoEmisionController target, tbPuntoEmisionDetalle PuntoEmisionDet)
        {
            JsonResult result = target.RemovePuntoEmisionDetalle(PuntoEmisionDet);
            return result;
            // TODO: add assertions to method PuntoEmisionControllerTest.RemovePuntoEmisionDetalleTest(PuntoEmisionController, tbPuntoEmisionDetalle)
        }

        /// <summary>Test stub for SaveCreateNumeracion(tbPuntoEmisionDetalle)</summary>
        [PexMethod]
        public JsonResult SaveCreateNumeracionTest(
            [PexAssumeUnderTest]PuntoEmisionController target,
            tbPuntoEmisionDetalle CreatePuntoEmisionDetalle
        )
        {
            JsonResult result = target.SaveCreateNumeracion(CreatePuntoEmisionDetalle);
            return result;
            // TODO: add assertions to method PuntoEmisionControllerTest.SaveCreateNumeracionTest(PuntoEmisionController, tbPuntoEmisionDetalle)
        }

        /// <summary>Test stub for SaveEditNumeracion(tbPuntoEmisionDetalle)</summary>
        [PexMethod]
        public JsonResult SaveEditNumeracionTest(
            [PexAssumeUnderTest]PuntoEmisionController target,
            tbPuntoEmisionDetalle EditPuntoEmisionDetalle
        )
        {
            JsonResult result = target.SaveEditNumeracion(EditPuntoEmisionDetalle);
            return result;
            // TODO: add assertions to method PuntoEmisionControllerTest.SaveEditNumeracionTest(PuntoEmisionController, tbPuntoEmisionDetalle)
        }

        /// <summary>Test stub for SavePuntoEmisionDetalle(tbPuntoEmisionDetalle)</summary>
        [PexMethod]
        public JsonResult SavePuntoEmisionDetalleTest([PexAssumeUnderTest]PuntoEmisionController target, tbPuntoEmisionDetalle PuntoEmisionDet)
        {
            JsonResult result = target.SavePuntoEmisionDetalle(PuntoEmisionDet);
            return result;
            // TODO: add assertions to method PuntoEmisionControllerTest.SavePuntoEmisionDetalleTest(PuntoEmisionController, tbPuntoEmisionDetalle)
        }
    }
}
