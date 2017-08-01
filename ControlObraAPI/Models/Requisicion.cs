using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControlObraAPI.Models
{
    public class Requisicion
    {
        public int CodProyecto { get; set; }
        public int CodModelo { get; set; }
        public int CodLote { get; set; }
        public int CodActividad { get; set; }
        public int CodTarea { get; set; }
        public int CodDetalle { get; set; }
        public decimal Cantidad { get; set; }
        public int CodUnidad { get; set; }
        public string EsUnidad { get; set; }
        public decimal Solicitado { get; set; }
        public decimal Despacho { get; set; }
        public decimal Bodega { get; set; }
        public string Incluir { get; set; }
        public int Numero { get; set; }
        public int Usuario { get; set; }
        public string IdDispositivo { get; set; }
        public string Tipo { get; set; }
        public string Estado { get; set; }

        public Requisicion() { }

        public Requisicion(int codProyecto, int codModelo, int codLote, int codActividad, int codTarea,
            int codDetalle, decimal cantidad, int codUnidad, string esUnidad, decimal solicitado,
            decimal despacho, decimal bodega, string incluir, int numero, int usuario, string idDispositivo,
            string tipo, string estado)
        {
            this.CodProyecto = codProyecto;
            this.CodModelo = codModelo;
            this.CodLote = codLote;
            this.CodActividad = codActividad;
            this.CodTarea = codTarea;
            this.CodDetalle = codDetalle;
            this.Cantidad = cantidad;
            this.CodUnidad = codUnidad;
            this.EsUnidad = esUnidad;
            this.Solicitado = solicitado;
            this.Despacho = despacho;
            this.Bodega = bodega;
            this.Incluir = incluir;
            this.Numero = numero;
            this.Usuario = usuario;
            this.IdDispositivo = idDispositivo;
            this.Tipo = tipo;
            this.Estado = estado;
        }

    }
}