using ERP_GMEDINA.Models;
using System.Web.Mvc;
// <copyright file="SucursalControllerTest.cs">Copyright ©  2014</copyright>

using System;
using ERP_ZORZAL.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ERP_ZORZAL.Controllers.Tests
{
    /// <summary>Esta clase contiene pruebas unitarias parametrizadas para SucursalController</summary>
    [TestClass]
    [PexClass(typeof(SucursalController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class SucursalControllerTest
    {

        /// <summary>Código auxiliar de prueba para .ctor()</summary>
        [PexMethod(MaxBranches = 320000)]
        public SucursalController ConstructorTest()
        {
            SucursalController target = new SucursalController();
            return target;
            // TODO: agregar aserciones a método SucursalControllerTest.ConstructorTest()
        }

        /// <summary>Código auxiliar de prueba para Create()</summary>
        [PexMethod]
        public ActionResult CreateTest([PexAssumeUnderTest]SucursalController target)
        {
            ActionResult result = target.Create();
            return result;
            // TODO: agregar aserciones a método SucursalControllerTest.CreateTest(SucursalController)
        }

        /// <summary>Código auxiliar de prueba para Create(tbSucursal)</summary>
        [PexMethod]
        public ActionResult CreateTest01([PexAssumeUnderTest]SucursalController target, tbSucursal tbSucursal)
        {
            ActionResult result = target.Create(tbSucursal);
            return result;
            // TODO: agregar aserciones a método SucursalControllerTest.CreateTest01(SucursalController, tbSucursal)
        }

        /// <summary>Código auxiliar de prueba para Delete(Nullable`1&lt;Int16&gt;)</summary>
        [PexMethod]
        public ActionResult DeleteTest([PexAssumeUnderTest]SucursalController target, short? id)
        {
            ActionResult result = target.Delete(id);
            return result;
            // TODO: agregar aserciones a método SucursalControllerTest.DeleteTest(SucursalController, Nullable`1<Int16>)
        }

        /// <summary>Código auxiliar de prueba para DeleteConfirmed(Int16)</summary>
        [PexMethod]
        public ActionResult DeleteConfirmedTest([PexAssumeUnderTest]SucursalController target, short id)
        {
            ActionResult result = target.DeleteConfirmed(id);
            return result;
            // TODO: agregar aserciones a método SucursalControllerTest.DeleteConfirmedTest(SucursalController, Int16)
        }

        /// <summary>Código auxiliar de prueba para Details(Nullable`1&lt;Int16&gt;)</summary>
        [PexMethod]
        public ActionResult DetailsTest([PexAssumeUnderTest]SucursalController target, short? id)
        {
            ActionResult result = target.Details(id);
            return result;
            // TODO: agregar aserciones a método SucursalControllerTest.DetailsTest(SucursalController, Nullable`1<Int16>)
        }

        /// <summary>Código auxiliar de prueba para Edit(Nullable`1&lt;Int16&gt;)</summary>
        [PexMethod]
        public ActionResult EditTest([PexAssumeUnderTest]SucursalController target, short? id)
        {
            ActionResult result = target.Edit(id);
            return result;
            // TODO: agregar aserciones a método SucursalControllerTest.EditTest(SucursalController, Nullable`1<Int16>)
        }

        /// <summary>Código auxiliar de prueba para Edit(Nullable`1&lt;Int16&gt;, tbSucursal)</summary>
        [PexMethod]
        public ActionResult EditTest01(
            [PexAssumeUnderTest]SucursalController target,
            short? id,
            tbSucursal tbSucursal
        )
        {
            ActionResult result = target.Edit(id, tbSucursal);
            return result;
            // TODO: agregar aserciones a método SucursalControllerTest.EditTest01(SucursalController, Nullable`1<Int16>, tbSucursal)
        }

        /// <summary>Código auxiliar de prueba para GetMunicipios(String)</summary>
        [PexMethod]
        public JsonResult GetMunicipiosTest([PexAssumeUnderTest]SucursalController target, string CodDepartamento)
        {
            JsonResult result = target.GetMunicipios(CodDepartamento);
            return result;
            // TODO: agregar aserciones a método SucursalControllerTest.GetMunicipiosTest(SucursalController, String)
        }

        /// <summary>Código auxiliar de prueba para Index()</summary>
        [PexMethod]
        public ActionResult IndexTest([PexAssumeUnderTest]SucursalController target)
        {
            ActionResult result = target.Index();
            return result;
            // TODO: agregar aserciones a método SucursalControllerTest.IndexTest(SucursalController)
        }
    }
}
