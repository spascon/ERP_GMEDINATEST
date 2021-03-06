using ERP_GMEDINA.Models;
using System.Web.Mvc;
// <copyright file="DenominacionControllerTest.cs">Copyright ©  2014</copyright>

using System;
using ERP_ZORZAL.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ERP_ZORZAL.Controllers.Tests
{
    /// <summary>This class contains parameterized unit tests for DenominacionController</summary>
    [TestClass]
    [PexClass(typeof(DenominacionController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class DenominacionControllerTest
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod(MaxBranches = 320000)]
        public DenominacionController ConstructorTest()
        {
            DenominacionController target = new DenominacionController();
            return target;
            // TODO: add assertions to method DenominacionControllerTest.ConstructorTest()
        }

        /// <summary>Test stub for Create()</summary>
        [PexMethod]
        public ActionResult CreateTest([PexAssumeUnderTest]DenominacionController target)
        {
            ActionResult result = target.Create();
            return result;
            // TODO: add assertions to method DenominacionControllerTest.CreateTest(DenominacionController)
        }

        /// <summary>Test stub for Create(tbDenominacion)</summary>
        [PexMethod]
        public ActionResult CreateTest01([PexAssumeUnderTest]DenominacionController target, tbDenominacion tbDenominacion)
        {
            ActionResult result = target.Create(tbDenominacion);
            return result;
            // TODO: add assertions to method DenominacionControllerTest.CreateTest01(DenominacionController, tbDenominacion)
        }

        /// <summary>Test stub for Delete(Nullable`1&lt;Int16&gt;)</summary>
        [PexMethod]
        public ActionResult DeleteTest([PexAssumeUnderTest]DenominacionController target, short? id)
        {
            ActionResult result = target.Delete(id);
            return result;
            // TODO: add assertions to method DenominacionControllerTest.DeleteTest(DenominacionController, Nullable`1<Int16>)
        }

        /// <summary>Test stub for DeleteConfirmed(Int16)</summary>
        [PexMethod]
        public ActionResult DeleteConfirmedTest([PexAssumeUnderTest]DenominacionController target, short id)
        {
            ActionResult result = target.DeleteConfirmed(id);
            return result;
            // TODO: add assertions to method DenominacionControllerTest.DeleteConfirmedTest(DenominacionController, Int16)
        }

        /// <summary>Test stub for Details(Nullable`1&lt;Int16&gt;)</summary>
        [PexMethod]
        public ActionResult DetailsTest([PexAssumeUnderTest]DenominacionController target, short? id)
        {
            ActionResult result = target.Details(id);
            return result;
            // TODO: add assertions to method DenominacionControllerTest.DetailsTest(DenominacionController, Nullable`1<Int16>)
        }

        /// <summary>Test stub for Edit(Nullable`1&lt;Int16&gt;)</summary>
        [PexMethod]
        public ActionResult EditTest([PexAssumeUnderTest]DenominacionController target, short? id)
        {
            ActionResult result = target.Edit(id);
            return result;
            // TODO: add assertions to method DenominacionControllerTest.EditTest(DenominacionController, Nullable`1<Int16>)
        }

        /// <summary>Test stub for Edit(tbDenominacion)</summary>
        [PexMethod]
        public ActionResult EditTest01([PexAssumeUnderTest]DenominacionController target, tbDenominacion tbDenominacion)
        {
            ActionResult result = target.Edit(tbDenominacion);
            return result;
            // TODO: add assertions to method DenominacionControllerTest.EditTest01(DenominacionController, tbDenominacion)
        }

        /// <summary>Test stub for Index()</summary>
        [PexMethod]
        public ActionResult IndexTest([PexAssumeUnderTest]DenominacionController target)
        {
            ActionResult result = target.Index();
            return result;
            // TODO: add assertions to method DenominacionControllerTest.IndexTest(DenominacionController)
        }
    }
}
