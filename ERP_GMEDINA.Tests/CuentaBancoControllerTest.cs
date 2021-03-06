using ERP_GMEDINA.Models;
using System.Web.Mvc;
using System;
using ERP_ZORZAL.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ERP_ZORZAL.Controllers.Tests
{
    /// <summary>This class contains parameterized unit tests for CuentaBancoController</summary>
    [TestClass]
    [PexClass(typeof(CuentaBancoController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class CuentaBancoControllerTest
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod(MaxBranches = 320000)]
        public CuentaBancoController ConstructorTest()
        {
            CuentaBancoController target = new CuentaBancoController();
            return target;
            // TODO: add assertions to method CuentaBancoControllerTest.ConstructorTest()
        }

        /// <summary>Test stub for Create()</summary>
        [PexMethod]
        public ActionResult CreateTest([PexAssumeUnderTest]CuentaBancoController target)
        {
            ActionResult result = target.Create();
            return result;
            // TODO: add assertions to method CuentaBancoControllerTest.CreateTest(CuentaBancoController)
        }

        /// <summary>Test stub for Create(tbCuentasBanco)</summary>
        [PexMethod]
        public ActionResult CreateTest01([PexAssumeUnderTest]CuentaBancoController target, tbCuentasBanco tbCuentasBanco)
        {
            ActionResult result = target.Create(tbCuentasBanco);
            return result;
            // TODO: add assertions to method CuentaBancoControllerTest.CreateTest01(CuentaBancoController, tbCuentasBanco)
        }

        /// <summary>Test stub for Delete(Nullable`1&lt;Int16&gt;)</summary>
        [PexMethod]
        public ActionResult DeleteTest([PexAssumeUnderTest]CuentaBancoController target, short? id)
        {
            ActionResult result = target.Delete(id);
            return result;
            // TODO: add assertions to method CuentaBancoControllerTest.DeleteTest(CuentaBancoController, Nullable`1<Int16>)
        }

        /// <summary>Test stub for DeleteConfirmed(Int16)</summary>
        [PexMethod]
        public ActionResult DeleteConfirmedTest([PexAssumeUnderTest]CuentaBancoController target, short id)
        {
            ActionResult result = target.DeleteConfirmed(id);
            return result;
            // TODO: add assertions to method CuentaBancoControllerTest.DeleteConfirmedTest(CuentaBancoController, Int16)
        }

        /// <summary>Test stub for Details(Nullable`1&lt;Int16&gt;)</summary>
        [PexMethod]
        public ActionResult DetailsTest([PexAssumeUnderTest]CuentaBancoController target, short? id)
        {
            ActionResult result = target.Details(id);
            return result;
            // TODO: add assertions to method CuentaBancoControllerTest.DetailsTest(CuentaBancoController, Nullable`1<Int16>)
        }

        /// <summary>Test stub for Edit(Nullable`1&lt;Int16&gt;)</summary>
        [PexMethod(MaxConstraintSolverTime = 2)]
        public ActionResult EditTest([PexAssumeUnderTest]CuentaBancoController target, short? id)
        {
            ActionResult result = target.Edit(id);
            return result;
            // TODO: add assertions to method CuentaBancoControllerTest.EditTest(CuentaBancoController, Nullable`1<Int16>)
        }

        /// <summary>Test stub for Edit(tbCuentasBanco)</summary>
        [PexMethod]
        public ActionResult EditTest01([PexAssumeUnderTest]CuentaBancoController target, tbCuentasBanco CuentasBanco)
        {
            ActionResult result = target.Edit(CuentasBanco);
            return result;
            // TODO: add assertions to method CuentaBancoControllerTest.EditTest01(CuentaBancoController, tbCuentasBanco)
        }

        /// <summary>Test stub for Index()</summary>
        [PexMethod(MaxConstraintSolverTime = 2)]
        public ActionResult IndexTest([PexAssumeUnderTest]CuentaBancoController target)
        {
            ActionResult result = target.Index();
            return result;
            // TODO: add assertions to method CuentaBancoControllerTest.IndexTest(CuentaBancoController)
        }
    }
}
