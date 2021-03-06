// <copyright file="ActividadEconomicaControllerTest.cs">Copyright ©  2014</copyright>
using System;
using System.Web.Mvc;
using ERP_GMEDINA.Models;
using ERP_ZORZAL.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ERP_ZORZAL.Controllers.Tests
{
    /// <summary>Esta clase contiene pruebas unitarias parametrizadas para ActividadEconomicaController</summary>
    [PexClass(typeof(ActividadEconomicaController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ActividadEconomicaControllerTest
    {
        /// <summary>Código auxiliar de prueba para .ctor()</summary>
        [PexMethod(MaxBranches = 320000)]
        public ActividadEconomicaController ConstructorTest()
        {
            ActividadEconomicaController target = new ActividadEconomicaController();
            return target;
            // TODO: agregar aserciones a método ActividadEconomicaControllerTest.ConstructorTest()
        }

        /// <summary>Código auxiliar de prueba para Create()</summary>
        [PexMethod]
        public ActionResult CreateTest([PexAssumeUnderTest]ActividadEconomicaController target)
        {
            ActionResult result = target.Create();
            return result;
            // TODO: agregar aserciones a método ActividadEconomicaControllerTest.CreateTest(ActividadEconomicaController)
        }

        /// <summary>Código auxiliar de prueba para Create(tbActividadEconomica)</summary>
        [PexMethod]
        public ActionResult CreateTest01(
            [PexAssumeUnderTest]ActividadEconomicaController target,
            tbActividadEconomica tbActividadEconomica
        )
        {
            ActionResult result = target.Create(tbActividadEconomica);
            return result;
            // TODO: agregar aserciones a método ActividadEconomicaControllerTest.CreateTest01(ActividadEconomicaController, tbActividadEconomica)
        }

        /// <summary>Código auxiliar de prueba para DeleteConfirmed(Int16)</summary>
        [PexMethod]
        public ActionResult DeleteConfirmedTest(
            [PexAssumeUnderTest]ActividadEconomicaController target,
            short id
        )
        {
            ActionResult result = target.DeleteConfirmed(id);
            return result;
            // TODO: agregar aserciones a método ActividadEconomicaControllerTest.DeleteConfirmedTest(ActividadEconomicaController, Int16)
        }

        /// <summary>Código auxiliar de prueba para Delete(Nullable`1&lt;Int16&gt;)</summary>
        [PexMethod]
        public ActionResult DeleteTest(
            [PexAssumeUnderTest]ActividadEconomicaController target,
            short? id
        )
        {
            ActionResult result = target.Delete(id);
            return result;
            // TODO: agregar aserciones a método ActividadEconomicaControllerTest.DeleteTest(ActividadEconomicaController, Nullable`1<Int16>)
        }

        /// <summary>Código auxiliar de prueba para Details(Nullable`1&lt;Int16&gt;)</summary>
        [PexMethod]
        public ActionResult DetailsTest(
            [PexAssumeUnderTest]ActividadEconomicaController target,
            short? id
        )
        {
            ActionResult result = target.Details(id);
            return result;
            // TODO: agregar aserciones a método ActividadEconomicaControllerTest.DetailsTest(ActividadEconomicaController, Nullable`1<Int16>)
        }

        /// <summary>Código auxiliar de prueba para Edit(Nullable`1&lt;Int16&gt;)</summary>
        [PexMethod]
        public ActionResult EditTest(
            [PexAssumeUnderTest]ActividadEconomicaController target,
            short? id
        )
        {
            ActionResult result = target.Edit(id);
            return result;
            // TODO: agregar aserciones a método ActividadEconomicaControllerTest.EditTest(ActividadEconomicaController, Nullable`1<Int16>)
        }

        /// <summary>Código auxiliar de prueba para Edit(tbActividadEconomica)</summary>
        [PexMethod]
        public ActionResult EditTest01(
            [PexAssumeUnderTest]ActividadEconomicaController target,
            tbActividadEconomica tbActividadEconomica
        )
        {
            ActionResult result = target.Edit(tbActividadEconomica);
            return result;
            // TODO: agregar aserciones a método ActividadEconomicaControllerTest.EditTest01(ActividadEconomicaController, tbActividadEconomica)
        }

        /// <summary>Código auxiliar de prueba para Index()</summary>
        [PexMethod]
        public ActionResult IndexTest([PexAssumeUnderTest]ActividadEconomicaController target)
        {
            ActionResult result = target.Index();
            return result;
            // TODO: agregar aserciones a método ActividadEconomicaControllerTest.IndexTest(ActividadEconomicaController)
        }
    }
}
