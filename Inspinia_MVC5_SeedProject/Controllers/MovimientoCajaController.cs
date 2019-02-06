using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ERP_GMEDINA.Models;
using System.Transactions;
//ESTE//
namespace ERP_GMEDINA.Controllers
{
    public class MovimientoCajaController : Controller
    {
        private ERP_ZORZALEntities db = new ERP_ZORZALEntities();
        GeneralFunctions Function = new GeneralFunctions();


        /////////INICIO APERTURA/////////
        // GET: /MovimientoCaja/

        public ActionResult IndexApertura()
        {
            return View(db.tbMovimientoCaja.ToList());
        }
        ///Create Apertura
        public ActionResult CreateApertura()
        {
            try
            {
                int idUser = 0;
                GeneralFunctions Login = new GeneralFunctions();
                List<tbUsuario> User = Login.getUserInformation();
                foreach (tbUsuario Usuario in User)
                {
                    idUser = Convert.ToInt32(Usuario.emp_Id);
                }
                //////Solicitud Efectivo
                tbMovimientoCaja MovimientoCaja = new tbMovimientoCaja();
                //////Solicitud Efectivo
                tbSolicitudEfectivo SolicitudEfectivo = new tbSolicitudEfectivo();
                ViewBag.mnda_Id = new SelectList(db.tbMoneda, "mnda_Id", "mnda_Nombre", SolicitudEfectivo.mnda_Id);
                ViewBag.suc_Descripcion = db.tbUsuario.Where(x => x.usu_Id == idUser).Select(x => x.tbSucursal.suc_Descripcion).SingleOrDefault();
                var suc_Id = db.tbUsuario.Where(x => x.usu_Id == idUser).Select(x => x.tbSucursal.suc_Id).SingleOrDefault();
                ViewBag.UsuarioApertura = db.tbUsuario.Where(x => x.usu_Id == idUser).Select(x => x.usu_NombreUsuario).SingleOrDefault();
                ViewBag.mocja_UsuarioApertura = db.tbUsuario.Where(x => x.usu_Id == idUser).Select(x => x.usu_Id).SingleOrDefault();

                var Cajas = db.tbCaja.Select(s => new {
                    cja_Id = s.cja_Id,
                    cja_Descripcion = s.cja_Descripcion,
                    suc_Id = s.suc_Id
                }).Where(x => x.suc_Id == suc_Id).ToList();

                ViewBag.cja_Id = new SelectList(Cajas, "cja_Id", "cja_Descripcion", MovimientoCaja.cja_Id);
                /////Vistas Parciales
                ViewBag.SolicitudEfectivo = db.tbSolicitudEfectivo.ToList();
                ViewBag.MovimientoCaja = db.tbMovimientoCaja.ToList();
                Session["SolicitudEfectivo"] = null;
                return View();

            }
            catch (Exception Ex)
            {
                ModelState.AddModelError("", "Error al Acceder" + Ex.Message.ToString());
                return View();
            }
        }

        // POST: /MovimientoCaja/CreateApertura
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateApertura([Bind(Include = "mocja_Id,cja_Id,mocja_FechaApetura,mocja_UsuarioApertura,mocja_UsuarioCrea,mocja_FechaCrea")] tbMovimientoCaja tbMovimientoCaja)
        {




            if (ModelState.IsValid)
            {
                try
                {
                    ModelState.Remove("mocja_UsuarioApertura");
                    ModelState.Remove("mocja_UsuarioArquea");
                    ModelState.Remove("mocja_FechaArqueo");
                    ModelState.Remove("mocja_FechaAceptacion");
                    ModelState.Remove("mocja_UsuarioAceptacion");
                    /////////VAR//////////
                    tbMovimientoCaja.mocja_UsuarioArquea = 1;
                    tbMovimientoCaja.mocja_UsuarioAceptacion = 1;
                    bool solef_EsApertura = true;
                    bool solef_EsAnulada = false;
                    tbMovimientoCaja.mocja_FechaApertura = DateTime.Now;
                    ///////////VAR SESSION//////////
                    var list = (List<tbSolicitudEfectivoDetalle>)Session["SolicitudEfectivo"];
                    short moneda = (short)Session["SolicitudEfectivoMoneda"];
                    string MensajeError = "";
                    string MensajeErrorSolicitud = "";
                    string MensajeErrorSolicitudDetalle = "";
                    //////////LISTAS///////////////
                    IEnumerable<object> listMovimientoCaja = null;
                    IEnumerable<object> listSolicitudEfectivo = null;
                    IEnumerable<object> listSolicitudEfectivoDetalle = null;

                    using (TransactionScope Tran = new TransactionScope())
                    {
                        listMovimientoCaja = db.UDP_Vent_tbMovimientoCaja_Apertura_Insert(
                        tbMovimientoCaja.cja_Id,
                        tbMovimientoCaja.mocja_FechaApertura,
                        tbMovimientoCaja.mocja_UsuarioApertura,
                        tbMovimientoCaja.mocja_FechaArqueo,
                        tbMovimientoCaja.mocja_UsuarioArquea,
                        tbMovimientoCaja.mocja_FechaAceptacion,
                        tbMovimientoCaja.mocja_UsuarioAceptacion);
                        foreach (UDP_Vent_tbMovimientoCaja_Apertura_Insert_Result apertura in listMovimientoCaja)

                            MensajeError = apertura.MensajeError;
                        if (MensajeError == "-1")
                        {
                            ModelState.AddModelError("", "No se pudo insertar el registro, favor contacte al administrador.");
                            return View(tbMovimientoCaja);
                        }
                        else
                        {
                            listSolicitudEfectivo = db.UDP_Vent_tbSolicitudEfectivo_Apertura_Insert(
                                    Convert.ToInt32(MensajeError),
                                    solef_EsApertura,
                                    moneda,
                                    solef_EsAnulada

                                    );
                            foreach (UDP_Vent_tbSolicitudEfectivo_Apertura_Insert_Result SolicitudEfectivoMon in listSolicitudEfectivo)
                                MensajeErrorSolicitud = SolicitudEfectivoMon.MensajeError;
                            if (MensajeErrorSolicitud == "-1")
                            {
                                ModelState.AddModelError("", "No se pudo agregar el registro detalle");
                                return View(tbMovimientoCaja);
                            }
                            else
                            {
                                ///////////Solicitud Efectivo Detalle////////////////////
                                if (MensajeErrorSolicitudDetalle != "-1")
                                {
                                    if (list != null)
                                    {
                                        if (list.Count != 0)
                                        {
                                            foreach (tbSolicitudEfectivoDetalle efectivodetalle in list)
                                            {

                                                var SolicitudDetalle = Convert.ToInt32(MensajeErrorSolicitud);
                                                efectivodetalle.solef_Id = SolicitudDetalle;
                                                listSolicitudEfectivoDetalle = db.UDP_Vent_tbSolicitudEfectivoDetalle_Apertura_Insert(
                                                  Convert.ToInt32(MensajeErrorSolicitud),
                                                   efectivodetalle.deno_Id,
                                                   efectivodetalle.soled_CantidadSolicitada,
                                                   efectivodetalle.soled_CantidadEntregada,
                                                   efectivodetalle.soled_MontoEntregado
                                                    );
                                                foreach (UDP_Vent_tbSolicitudEfectivoDetalle_Apertura_Insert_Result SolicitudEfectivoDet in listSolicitudEfectivoDetalle)
                                                {
                                                    MensajeErrorSolicitudDetalle = SolicitudEfectivoDet.MensajeError;
                                                    if (MensajeErrorSolicitudDetalle == "-1")
                                                    {
                                                        ModelState.AddModelError("", "No se pudo agregar el registro detalle");
                                                        return View(tbMovimientoCaja);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    ModelState.AddModelError("", "No se pudo agregar el registro");
                                    return View(tbMovimientoCaja);
                                }

                            }
                            Tran.Complete();
                            return RedirectToAction("Index");
                        }
                    }
                }
                catch (Exception Ex)
                {
                    tbSolicitudEfectivo tbSolicitudEfectivoa = new tbSolicitudEfectivo();
                    //Caja
                    ViewBag.cja_Id = new SelectList(db.tbCaja, "cja_Id", "cja_Descripcion", tbMovimientoCaja.cja_Id);
                    ///Sucursal
                    ViewBag.suc_Id = new SelectList(db.tbSucursal, "suc_Id", "suc_Descripcion");
                    ///Moneda
                    ViewBag.mnda_Id = new SelectList(db.tbMoneda, "mnda_Id", "mnda_Nombre", tbSolicitudEfectivoa.mnda_Id);

                    //ViewBag.MovimientoCaja = db.tbMovimientoCaja.ToList();
                    Ex.Message.ToString();
                    ModelState.AddModelError("", "No se pudo insertar el registro, favor contacte al administrador." + Ex.Message);
                    return View(tbMovimientoCaja);
                }
            }
            tbSolicitudEfectivo tbSolicitudEfectivo = new tbSolicitudEfectivo();
            ///Sucursal
            ViewBag.suc_Id = new SelectList(db.tbSucursal, "suc_Id", "suc_Descripcion");
            //Caja
            ViewBag.cja_Id = new SelectList(db.tbCaja, "cja_Id", "cja_Descripcion", tbMovimientoCaja.cja_Id);
            ///Moneda
            ViewBag.mnda_Id = new SelectList(db.tbMoneda, "mnda_Id", "mnda_Nombre", tbSolicitudEfectivo.mnda_Id);
            //ViewBag.MovimientoCaja = db.tbMovimientoCaja.ToList();
            return View(tbMovimientoCaja);
        }


        ///Variable de Sesion 1
        [HttpPost]
        public JsonResult SaveSolicitudEfectivoDetalle(tbSolicitudEfectivoDetalle SolicitudEfectivoDet)
        {
            try
            {
                List<tbSolicitudEfectivoDetalle> sessionSolicitudEfectivoDetalle = new List<tbSolicitudEfectivoDetalle>();
                var list = (List<tbSolicitudEfectivoDetalle>)Session["SolicitudEfectivo"];
                if (list == null)
                {
                    sessionSolicitudEfectivoDetalle.Add(SolicitudEfectivoDet);
                    Session["SolicitudEfectivo"] = sessionSolicitudEfectivoDetalle;
                }
                else
                {
                    list.Add(SolicitudEfectivoDet);
                    Session["SolicitudEfectivo"] = list;
                }
                return Json("Exito", JsonRequestBehavior.AllowGet);

            }
            catch (Exception Ex)
            {
                Ex.Message.ToString();
                return Json("Fallo", JsonRequestBehavior.AllowGet);
            }
        }

        /////Variable de Sesion 2
        [HttpPost]
        public JsonResult SaveSolicitudEfectivoMoneda(tbSolicitudEfectivo SolicitudEfectivoMon)
        {
            try
            {
                Session["SolicitudEfectivoMoneda"] = SolicitudEfectivoMon.mnda_Id;
                var Datos = Session["SolicitudEfectivoMoneda"];
                return Json("Exito", JsonRequestBehavior.AllowGet);

            }
            catch (Exception Ex)
            {
                Ex.Message.ToString();
                return Json("Fallo", JsonRequestBehavior.AllowGet);
            }
        }


        ////////////TERMINO APERTURA////////////



        [HttpPost]
        public JsonResult GetDenominacion(int CodMoneda)
        {
            try
            {
                var list = db.spGetDenominacionesMoneda(CodMoneda).ToList();
                return Json(list, JsonRequestBehavior.AllowGet);
            }
            catch (Exception Ex)
            {
                Ex.Message.ToString();
                return Json("Fallo", JsonRequestBehavior.AllowGet);
            }
        }

    }
}
