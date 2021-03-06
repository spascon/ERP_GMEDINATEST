using ERP_GMEDINA.Models;
using System.Web.Mvc;
using System;
using ERP_ZORZAL.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ERP_ZORZAL.Controllers.Tests
{
    /// <summary>This class contains parameterized unit tests for BancoController</summary>
    [TestClass]
    [PexClass(typeof(BancoController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class BancoControllerTest
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod(MaxBranches = 320000)]
        public BancoController ConstructorTest()
        {
            BancoController target = new BancoController();
            return target;
            // TODO: add assertions to method BancoControllerTest.ConstructorTest()
        }

        /// <summary>Test stub for Create()</summary>
        [PexMethod]
        public ActionResult CreateTest([PexAssumeUnderTest]BancoController target)
        {
            ActionResult result = target.Create();
            return result;
            // TODO: add assertions to method BancoControllerTest.CreateTest(BancoController)
        }

        /// <summary>Test stub for Create(tbBanco)</summary>
        [PexMethod]
        public ActionResult CreateTest01([PexAssumeUnderTest]BancoController target, tbBanco tbBanco)
        {
            ActionResult result = target.Create(tbBanco);
            return result;
            // TODO: add assertions to method BancoControllerTest.CreateTest01(BancoController, tbBanco)
        }

        /// <summary>Test stub for Details(Nullable`1&lt;Int16&gt;)</summary>
        [PexMethod]
        public ActionResult DetailsTest([PexAssumeUnderTest]BancoController target, short? id)
        {
            ActionResult result = target.Details(id);
            return result;
            // TODO: add assertions to method BancoControllerTest.DetailsTest(BancoController, Nullable`1<Int16>)
        }

        /// <summary>Test stub for Edit(Nullable`1&lt;Int16&gt;)</summary>
        [PexMethod]
        public ActionResult EditTest([PexAssumeUnderTest]BancoController target, short? id)
        {
            ActionResult result = target.Edit(id);
            return result;
            // TODO: add assertions to method BancoControllerTest.EditTest(BancoController, Nullable`1<Int16>)
        }

        /// <summary>Test stub for Edit(tbBanco)</summary>
        [PexMethod]
        public ActionResult EditTest01([PexAssumeUnderTest]BancoController target, tbBanco tbBanco)
        {
            ActionResult result = target.Edit(tbBanco);
            return result;
            // TODO: add assertions to method BancoControllerTest.EditTest01(BancoController, tbBanco)
        }

        /// <summary>Test stub for Index()</summary>
        [PexMethod]
        public ActionResult IndexTest([PexAssumeUnderTest]BancoController target)
        {
            ActionResult result = target.Index();
            return result;
            // TODO: add assertions to method BancoControllerTest.IndexTest(BancoController)
        }
    }
}
