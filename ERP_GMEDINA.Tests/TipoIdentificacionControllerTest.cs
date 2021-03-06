using ERP_GMEDINA.Models;
using System.Web.Mvc;
// <copyright file="TipoIdentificacionControllerTest.cs">Copyright ©  2014</copyright>

using System;
using ERP_ZORZAL.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ERP_ZORZAL.Controllers.Tests
{
    /// <summary>Esta clase contiene pruebas unitarias parametrizadas para TipoIdentificacionController</summary>
    [TestClass]
    [PexClass(typeof(TipoIdentificacionController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class TipoIdentificacionControllerTest
    {

        /// <summary>Código auxiliar de prueba para .ctor()</summary>
        [PexMethod(MaxBranches = 320000)]
        public TipoIdentificacionController ConstructorTest()
        {
            TipoIdentificacionController target = new TipoIdentificacionController();
            return target;
            // TODO: agregar aserciones a método TipoIdentificacionControllerTest.ConstructorTest()
        }

        /// <summary>Código auxiliar de prueba para Create()</summary>
        [PexMethod]
        public ActionResult CreateTest([PexAssumeUnderTest]TipoIdentificacionController target)
        {
            ActionResult result = target.Create();
            return result;
            // TODO: agregar aserciones a método TipoIdentificacionControllerTest.CreateTest(TipoIdentificacionController)
        }

        /// <summary>Código auxiliar de prueba para Create(tbTipoIdentificacion)</summary>
        [PexMethod]
        public ActionResult CreateTest01(
            [PexAssumeUnderTest]TipoIdentificacionController target,
            tbTipoIdentificacion tbTipoIdentificacion
        )
        {
            ActionResult result = target.Create(tbTipoIdentificacion);
            return result;
            // TODO: agregar aserciones a método TipoIdentificacionControllerTest.CreateTest01(TipoIdentificacionController, tbTipoIdentificacion)
        }

        /// <summary>Código auxiliar de prueba para Delete(Nullable`1&lt;Byte&gt;)</summary>
        [PexMethod]
        public ActionResult DeleteTest([PexAssumeUnderTest]TipoIdentificacionController target, byte? id)
        {
            ActionResult result = target.Delete(id);
            return result;
            // TODO: agregar aserciones a método TipoIdentificacionControllerTest.DeleteTest(TipoIdentificacionController, Nullable`1<Byte>)
        }

        /// <summary>Código auxiliar de prueba para DeleteConfirmed(Byte)</summary>
        [PexMethod]
        public ActionResult DeleteConfirmedTest([PexAssumeUnderTest]TipoIdentificacionController target, byte id)
        {
            ActionResult result = target.DeleteConfirmed(id);
            return result;
            // TODO: agregar aserciones a método TipoIdentificacionControllerTest.DeleteConfirmedTest(TipoIdentificacionController, Byte)
        }

        /// <summary>Código auxiliar de prueba para Details(Nullable`1&lt;Byte&gt;)</summary>
        [PexMethod]
        public ActionResult DetailsTest([PexAssumeUnderTest]TipoIdentificacionController target, byte? id)
        {
            ActionResult result = target.Details(id);
            return result;
            // TODO: agregar aserciones a método TipoIdentificacionControllerTest.DetailsTest(TipoIdentificacionController, Nullable`1<Byte>)
        }

        /// <summary>Código auxiliar de prueba para Edit(Nullable`1&lt;Byte&gt;)</summary>
        [PexMethod]
        public ActionResult EditTest([PexAssumeUnderTest]TipoIdentificacionController target, byte? id)
        {
            ActionResult result = target.Edit(id);
            return result;
            // TODO: agregar aserciones a método TipoIdentificacionControllerTest.EditTest(TipoIdentificacionController, Nullable`1<Byte>)
        }

        /// <summary>Código auxiliar de prueba para Edit(tbTipoIdentificacion)</summary>
        [PexMethod]
        public ActionResult EditTest01(
            [PexAssumeUnderTest]TipoIdentificacionController target,
            tbTipoIdentificacion tbTipoIdentificacion
        )
        {
            ActionResult result = target.Edit(tbTipoIdentificacion);
            return result;
            // TODO: agregar aserciones a método TipoIdentificacionControllerTest.EditTest01(TipoIdentificacionController, tbTipoIdentificacion)
        }

        /// <summary>Código auxiliar de prueba para Index()</summary>
        [PexMethod]
        public ActionResult IndexTest([PexAssumeUnderTest]TipoIdentificacionController target)
        {
            ActionResult result = target.Index();
            return result;
            // TODO: agregar aserciones a método TipoIdentificacionControllerTest.IndexTest(TipoIdentificacionController)
        }
    }
}
