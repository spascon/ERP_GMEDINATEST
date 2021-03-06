using ERP_GMEDINA.Models;
using System.Web.Mvc;
using System;
using ERP_GMEDINA.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ERP_GMEDINA.Controllers.Tests
{
    /// <summary>This class contains parameterized unit tests for ClienteController</summary>
    [TestClass]
    [PexClass(typeof(ClienteController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ClienteControllerTest
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public ClienteController ConstructorTest()
        {
            ClienteController target = new ClienteController();
            return target;
            // TODO: add assertions to method ClienteControllerTest.ConstructorTest()
        }

        /// <summary>Test stub for ActivarCliente(Int32, Boolean, String)</summary>
        [PexMethod(MaxBranches = 320000)]
        public JsonResult ActivarClienteTest(
            [PexAssumeUnderTest]ClienteController target,
            int CodCliente,
            bool Activo,
            string RazonInactivo
        )
        {
            tbCliente Cliente = new tbCliente() { clte_Id = 1, clte_EsActivo = true, clte_RazonInactivo = "Moroso" };
            JsonResult result = target.ActivarCliente(CodCliente, Activo, RazonInactivo);
            return result;
            // TODO: add assertions to method ClienteControllerTest.ActivarClienteTest(ClienteController, Int32, Boolean, String)
        }

        /// <summary>Test stub for Create()</summary>
        [PexMethod]
        public ActionResult CreateTest([PexAssumeUnderTest]ClienteController target)
        {
            ActionResult result = target.Create();
            return result;
            // TODO: add assertions to method ClienteControllerTest.CreateTest(ClienteController)
        }

        /// <summary>Test stub for Create(tbCliente, String)</summary>
        [PexMethod]
        public ActionResult CreateTest01(
            [PexAssumeUnderTest]ClienteController target,
            tbCliente tbCliente,
            String dep_Codigo
        )
        {

            ActionResult result = target.Create(tbCliente,dep_Codigo = "0401");
            return result;
            // TODO: add assertions to method ClienteControllerTest.CreateTest01(ClienteController, tbCliente, String)
        }

        /// <summary>Test stub for Delete(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public ActionResult DeleteTest([PexAssumeUnderTest]ClienteController target, int? id)
        {
            ActionResult result = target.Delete(id);
            return result;
            // TODO: add assertions to method ClienteControllerTest.DeleteTest(ClienteController, Nullable`1<Int32>)
        }

        /// <summary>Test stub for DeleteConfirmed(Int32)</summary>
        [PexMethod]
        public ActionResult DeleteConfirmedTest([PexAssumeUnderTest]ClienteController target, int id)
        {
            ActionResult result = target.DeleteConfirmed(id);
            return result;
            // TODO: add assertions to method ClienteControllerTest.DeleteConfirmedTest(ClienteController, Int32)
        }

        /// <summary>Test stub for Details(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public ActionResult DetailsTest([PexAssumeUnderTest]ClienteController target, int? id)
        {
            ActionResult result = target.Details(id);
            return result;
            // TODO: add assertions to method ClienteControllerTest.DetailsTest(ClienteController, Nullable`1<Int32>)
        }

        /// <summary>Test stub for Edit(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public ActionResult EditTest([PexAssumeUnderTest]ClienteController target, int? id)
        {
            ActionResult result = target.Edit(id);
            return result;
            // TODO: add assertions to method ClienteControllerTest.EditTest(ClienteController, Nullable`1<Int32>)
        }

        /// <summary>Test stub for Edit(tbCliente, String)</summary>
        [PexMethod]
        public ActionResult EditTest01(
            [PexAssumeUnderTest]ClienteController target,
            tbCliente tbCliente,
            string dep_Codigo
        )
        {
            ActionResult result = target.Edit(tbCliente, dep_Codigo = "0401");
            return result;
            // TODO: add assertions to method ClienteControllerTest.EditTest01(ClienteController, tbCliente, String)
        }

        /// <summary>Test stub for GetIdentificacion(Boolean)</summary>
        [PexMethod]
        public JsonResult GetIdentificacionTest([PexAssumeUnderTest]ClienteController target, bool CodIdentificacion)
        {
            JsonResult result = target.GetIdentificacion(CodIdentificacion);
            return result;
            // TODO: add assertions to method ClienteControllerTest.GetIdentificacionTest(ClienteController, Boolean)
        }

        /// <summary>Test stub for GetMunicipios(String)</summary>
        [PexMethod]
        public JsonResult GetMunicipiosTest([PexAssumeUnderTest]ClienteController target, string CodDepartamento)
        {
            JsonResult result = target.GetMunicipios(CodDepartamento);
            return result;
            // TODO: add assertions to method ClienteControllerTest.GetMunicipiosTest(ClienteController, String)
        }

        /// <summary>Test stub for GetNacionalidades(String)</summary>
        [PexMethod]
        public JsonResult GetNacionalidadesTest([PexAssumeUnderTest]ClienteController target, string term)
        {
            JsonResult result = target.GetNacionalidades(term);
            return result;
            // TODO: add assertions to method ClienteControllerTest.GetNacionalidadesTest(ClienteController, String)
        }

        /// <summary>Test stub for InactivarCliente(Int32, Boolean, String)</summary>
        [PexMethod]
        public JsonResult InactivarClienteTest(
            [PexAssumeUnderTest]ClienteController target,
            int CodCliente,
            bool Activo,
            string RazonInactivo
        )
        {
            tbCliente Cliente = new tbCliente() {clte_Id = 1, clte_EsActivo=true, clte_RazonInactivo= "Cliente con mora" };
            JsonResult result = target.InactivarCliente(CodCliente, Activo, RazonInactivo);
            return result;
            // TODO: add assertions to method ClienteControllerTest.InactivarClienteTest(ClienteController, Int32, Boolean, String)
        }

        /// <summary>Test stub for Index()</summary>
        [PexMethod]
        public ActionResult IndexTest([PexAssumeUnderTest]ClienteController target)
        {
            ActionResult result = target.Index();
            return result;
            // TODO: add assertions to method ClienteControllerTest.IndexTest(ClienteController)
        }

        /// <summary>Test stub for Index(String, String, String)</summary>
        [PexMethod]
        public ActionResult IndexTest01(
            [PexAssumeUnderTest]ClienteController target,
            string identificacion,
            string nombre,
            string telefono
        )
        {
            tbCliente Cliente = new tbCliente() {clte_Identificacion ="0501200001189",clte_Nombres="Brayan", clte_Telefono= "99586541" };
            ActionResult result = target.Index(identificacion, nombre, telefono);
            return result;
            // TODO: add assertions to method ClienteControllerTest.IndexTest01(ClienteController, String, String, String)
        }
    }
}
