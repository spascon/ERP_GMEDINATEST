using System.Collections.Generic;
using ERP_GMEDINA.Models;
using System;
using Microsoft.Pex.Framework;

namespace ERP_GMEDINA.Models
{
    /// <summary>A factory for ERP_GMEDINA.Models.tbSolicitudEfectivo instances</summary>
    public static partial class tbSolicitudEfectivoFactory
    {
        /// <summary>A factory for ERP_GMEDINA.Models.tbSolicitudEfectivo instances</summary>
        [PexFactoryMethod(typeof(tbSolicitudEfectivo))]
        public static tbSolicitudEfectivo Create(
            int value_i,
            int value_i1,
            bool value_b,
            DateTime? value_null,
            int? value_nulli,
            short value_w,
            bool value_b1,
            string value_s,
            int value_i2,
            DateTime value_dt,
            int? value_nulli1,
            DateTime? value_null1,
            tbUsuario value_tbUsuario,
            tbUsuario value_tbUsuario1,
            tbUsuario value_tbUsuario2,
            tbMoneda value_tbMoneda,
            tbMovimientoCaja value_tbMovimientoCaja,
            ICollection<tbSolicitudEfectivoDetalle> value_iCollection
        )
        {
            tbSolicitudEfectivo tbSolicitudEfectivo = new tbSolicitudEfectivo();
            tbSolicitudEfectivo.solef_Id = value_i;
            tbSolicitudEfectivo.mocja_Id = value_i1;
            tbSolicitudEfectivo.solef_EsApertura = value_b;
            tbSolicitudEfectivo.solef_FechaEntrega = value_null;
            tbSolicitudEfectivo.solef_UsuarioEntrega = value_nulli;
            tbSolicitudEfectivo.mnda_Id = value_w;
            tbSolicitudEfectivo.solef_EsAnulada = value_b1;
            tbSolicitudEfectivo.RazonAnulado = value_s;
            tbSolicitudEfectivo.solef_UsuarioCrea = value_i2;
            tbSolicitudEfectivo.solef_FechaCrea = value_dt;
            tbSolicitudEfectivo.solef_UsuarioModifica = value_nulli1;
            tbSolicitudEfectivo.solef_FechaModifica = value_null1;
            tbSolicitudEfectivo.tbUsuario = value_tbUsuario;
            tbSolicitudEfectivo.tbUsuario1 = value_tbUsuario1;
            tbSolicitudEfectivo.tbUsuario2 = value_tbUsuario2;
            tbSolicitudEfectivo.tbMoneda = value_tbMoneda;
            tbSolicitudEfectivo.tbMovimientoCaja = value_tbMovimientoCaja;
            tbSolicitudEfectivo.tbSolicitudEfectivoDetalle = value_iCollection;
            return tbSolicitudEfectivo;

            // TODO: Edit factory method of tbSolicitudEfectivo
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
