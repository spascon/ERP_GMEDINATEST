using ERP_GMEDINA.Models;
using System.Web.Mvc;
using System;
using Inspinia_MVC5_SeedProject.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Inspinia_MVC5_SeedProject.Controllers.Tests
{
    /// <summary>This class contains parameterized unit tests for EstadoFacturaController</summary>
    [TestClass]
    [PexClass(typeof(EstadoFacturaController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class EstadoFacturaControllerTest
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod(MaxBranches = 320000)]
        public EstadoFacturaController ConstructorTest()
        {
            EstadoFacturaController target = new EstadoFacturaController();
            return target;
            // TODO: add assertions to method EstadoFacturaControllerTest.ConstructorTest()
        }

        /// <summary>Test stub for Create()</summary>
        [PexMethod]
        public ActionResult CreateTest([PexAssumeUnderTest]EstadoFacturaController target)
        {
            ActionResult result = target.Create();
            return result;
            // TODO: add assertions to method EstadoFacturaControllerTest.CreateTest(EstadoFacturaController)
        }

        /// <summary>Test stub for Create(tbEstadoFactura)</summary>
        [PexMethod]
        public ActionResult CreateTest01([PexAssumeUnderTest]EstadoFacturaController target, tbEstadoFactura tbEstadoFactura)
        {
            ActionResult result = target.Create(tbEstadoFactura);
            return result;
            // TODO: add assertions to method EstadoFacturaControllerTest.CreateTest01(EstadoFacturaController, tbEstadoFactura)
        }

        /// <summary>Test stub for Delete(Nullable`1&lt;Byte&gt;)</summary>
        [PexMethod]
        public ActionResult DeleteTest([PexAssumeUnderTest]EstadoFacturaController target, byte? id)
        {
            ActionResult result = target.Delete(id);
            return result;
            // TODO: add assertions to method EstadoFacturaControllerTest.DeleteTest(EstadoFacturaController, Nullable`1<Byte>)
        }

        /// <summary>Test stub for DeleteConfirmed(Byte)</summary>
        [PexMethod]
        public ActionResult DeleteConfirmedTest([PexAssumeUnderTest]EstadoFacturaController target, byte id)
        {
            ActionResult result = target.DeleteConfirmed(id);
            return result;
            // TODO: add assertions to method EstadoFacturaControllerTest.DeleteConfirmedTest(EstadoFacturaController, Byte)
        }

        /// <summary>Test stub for Details(Nullable`1&lt;Byte&gt;)</summary>
        [PexMethod]
        public ActionResult DetailsTest([PexAssumeUnderTest]EstadoFacturaController target, byte? id)
        {
            ActionResult result = target.Details(id);
            return result;
            // TODO: add assertions to method EstadoFacturaControllerTest.DetailsTest(EstadoFacturaController, Nullable`1<Byte>)
        }

        /// <summary>Test stub for Edit(Nullable`1&lt;Byte&gt;)</summary>
        [PexMethod]
        public ActionResult EditTest([PexAssumeUnderTest]EstadoFacturaController target, byte? id)
        {
            ActionResult result = target.Edit(id);
            return result;
            // TODO: add assertions to method EstadoFacturaControllerTest.EditTest(EstadoFacturaController, Nullable`1<Byte>)
        }

        /// <summary>Test stub for Edit(tbEstadoFactura)</summary>
        [PexMethod]
        public ActionResult EditTest01([PexAssumeUnderTest]EstadoFacturaController target, tbEstadoFactura tbEstadoFactura)
        {
            ActionResult result = target.Edit(tbEstadoFactura);
            return result;
            // TODO: add assertions to method EstadoFacturaControllerTest.EditTest01(EstadoFacturaController, tbEstadoFactura)
        }

        /// <summary>Test stub for Index()</summary>
        [PexMethod]
        public ActionResult IndexTest([PexAssumeUnderTest]EstadoFacturaController target)
        {
            ActionResult result = target.Index();
            return result;
            // TODO: add assertions to method EstadoFacturaControllerTest.IndexTest(EstadoFacturaController)
        }
    }
}
