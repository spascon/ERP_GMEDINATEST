using ERP_GMEDINA.Models;
using System.Web.Mvc;
using ERP_ZORZAL.Controllers;
// <copyright file="NotaCreditoControllerTest.cs">Copyright ©  2014</copyright>

using System;
using ERP_GMEDINA.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ERP_GMEDINA.Controllers.Tests
{
    /// <summary>Esta clase contiene pruebas unitarias parametrizadas para NotaCreditoController</summary>
    [TestClass]
    [PexClass(typeof(NotaCreditoController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class NotaCreditoControllerTest
    {

        /// <summary>Código auxiliar de prueba para .ctor()</summary>
        [PexMethod]
        public NotaCreditoController ConstructorTest()
        {
            NotaCreditoController target = new NotaCreditoController();
            return target;
            // TODO: agregar aserciones a método NotaCreditoControllerTest.ConstructorTest()
        }

        /// <summary>Código auxiliar de prueba para AnularNotaCredito(Int16, Boolean)</summary>
        [PexMethod(MaxBranches = 320000)]
        public JsonResult AnularNotaCreditoTest(
            [PexAssumeUnderTest]NotaCreditoController target,
            short nocreId,
            bool Anulado
        )
        {
            JsonResult result = target.AnularNotaCredito(nocreId, Anulado);
            return result;
            // TODO: agregar aserciones a método NotaCreditoControllerTest.AnularNotaCreditoTest(NotaCreditoController, Int16, Boolean)
        }

        /// <summary>Código auxiliar de prueba para Create()</summary>
        [PexMethod]
        public ActionResult CreateTest([PexAssumeUnderTest]NotaCreditoController target)
        {
            ActionResult result = target.Create();
            return result;
            // TODO: agregar aserciones a método NotaCreditoControllerTest.CreateTest(NotaCreditoController)
        }

        /// <summary>Código auxiliar de prueba para Create(tbNotaCredito)</summary>
        [PexMethod]
        public ActionResult CreateTest01([PexAssumeUnderTest]NotaCreditoController target, tbNotaCredito tbNotaCredito)
        {
            ActionResult result = target.Create(tbNotaCredito);
            return result;
            // TODO: agregar aserciones a método NotaCreditoControllerTest.CreateTest01(NotaCreditoController, tbNotaCredito)
        }

        /// <summary>Código auxiliar de prueba para Delete(Nullable`1&lt;Int16&gt;)</summary>
        [PexMethod]
        public ActionResult DeleteTest([PexAssumeUnderTest]NotaCreditoController target, short? id)
        {
            ActionResult result = target.Delete(id);
            return result;
            // TODO: agregar aserciones a método NotaCreditoControllerTest.DeleteTest(NotaCreditoController, Nullable`1<Int16>)
        }

        /// <summary>Código auxiliar de prueba para DeleteConfirmed(Int16)</summary>
        [PexMethod]
        public ActionResult DeleteConfirmedTest([PexAssumeUnderTest]NotaCreditoController target, short id)
        {
            ActionResult result = target.DeleteConfirmed(id);
            return result;
            // TODO: agregar aserciones a método NotaCreditoControllerTest.DeleteConfirmedTest(NotaCreditoController, Int16)
        }

        /// <summary>Código auxiliar de prueba para Details(Nullable`1&lt;Int16&gt;)</summary>
        [PexMethod]
        public ActionResult DetailsTest([PexAssumeUnderTest]NotaCreditoController target, short? id)
        {
            ActionResult result = target.Details(id);
            return result;
            // TODO: agregar aserciones a método NotaCreditoControllerTest.DetailsTest(NotaCreditoController, Nullable`1<Int16>)
        }

        /// <summary>Código auxiliar de prueba para Edit(Nullable`1&lt;Int16&gt;)</summary>
        [PexMethod]
        public ActionResult EditTest([PexAssumeUnderTest]NotaCreditoController target, short? id)
        {
            ActionResult result = target.Edit(id);
            return result;
            // TODO: agregar aserciones a método NotaCreditoControllerTest.EditTest(NotaCreditoController, Nullable`1<Int16>)
        }

        /// <summary>Código auxiliar de prueba para Edit(tbNotaCredito)</summary>
        [PexMethod]
        public ActionResult EditTest01([PexAssumeUnderTest]NotaCreditoController target, tbNotaCredito tbNotaCredito)
        {
            ActionResult result = target.Edit(tbNotaCredito);
            return result;
            // TODO: agregar aserciones a método NotaCreditoControllerTest.EditTest01(NotaCreditoController, tbNotaCredito)
        }

        /// <summary>Código auxiliar de prueba para GetCodigoNotaCredito(Int32, Int16)</summary>
        [PexMethod]
        public JsonResult GetCodigoNotaCreditoTest(
            [PexAssumeUnderTest]NotaCreditoController target,
            int CodSucursal,
            short CodCaja
        )
        {
            JsonResult result = target.GetCodigoNotaCredito(CodSucursal, CodCaja);
            return result;
            // TODO: agregar aserciones a método NotaCreditoControllerTest.GetCodigoNotaCreditoTest(NotaCreditoController, Int32, Int16)
        }

        /// <summary>Código auxiliar de prueba para Index()</summary>
        [PexMethod]
        public ActionResult IndexTest([PexAssumeUnderTest]NotaCreditoController target)
        {
            ActionResult result = target.Index();
            return result;
            // TODO: agregar aserciones a método NotaCreditoControllerTest.IndexTest(NotaCreditoController)
        }

        /// <summary>Código auxiliar de prueba para _IndexDevolucion(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public ActionResult _IndexDevolucionTest([PexAssumeUnderTest]NotaCreditoController target, int? id)
        {
            ActionResult result = target._IndexDevolucion(id);
            return result;
            // TODO: agregar aserciones a método NotaCreditoControllerTest._IndexDevolucionTest(NotaCreditoController, Nullable`1<Int32>)
        }
    }
}
