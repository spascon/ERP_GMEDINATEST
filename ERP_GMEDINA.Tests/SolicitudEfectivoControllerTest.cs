using System.Collections.Generic;
using ERP_GMEDINA.Models;
using System.Web.Mvc;
using System;
using ERP_GMEDINA.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ERP_GMEDINA.Controllers.Tests
{
    /// <summary>This class contains parameterized unit tests for SolicitudEfectivoController</summary>
    [TestClass]
    [PexClass(typeof(SolicitudEfectivoController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class SolicitudEfectivoControllerTest
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod(MaxBranches = 320000)]
        public SolicitudEfectivoController ConstructorTest()
        {
            SolicitudEfectivoController target = new SolicitudEfectivoController();
            return target;
            // TODO: add assertions to method SolicitudEfectivoControllerTest.ConstructorTest()
        }


        /// <summary>Test stub for EditEntregaEfectivo(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public ActionResult EditEntregaEfectivoTest([PexAssumeUnderTest]SolicitudEfectivoController target, int? id)
        {
            ActionResult result = target.EditEntregaEfectivo(id);
            return result;
            // TODO: add assertions to method SolicitudEfectivoControllerTest.EditEntregaEfectivoTest(SolicitudEfectivoController, Nullable`1<Int32>)
        }

        /// <summary>Test stub for EditEntregaEfectivo(tbSolicitudEfectivo)</summary>
        [PexMethod]
        public ActionResult EditEntregaEfectivoTest01(
            [PexAssumeUnderTest]SolicitudEfectivoController target,
            tbSolicitudEfectivo tbSolicitudEfectivo
        )
        {
            ActionResult result = target.EditEntregaEfectivo(tbSolicitudEfectivo);
            return result;
            // TODO: add assertions to method SolicitudEfectivoControllerTest.EditEntregaEfectivoTest01(SolicitudEfectivoController, tbSolicitudEfectivo)
        }


    }
}