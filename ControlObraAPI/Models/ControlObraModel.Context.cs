﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ControlObraAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CFB_BuildEntities : DbContext
    {
        public CFB_BuildEntities()
            : base("name=CFB_BuildEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<VISTA_PROYECTO_MODELO_OBRA_ACTIVIDAD_TAREA_DETALLE_Result> VISTA_PROYECTO_MODELO_OBRA_ACTIVIDAD_TAREA_DETALLE(Nullable<int> tIPO_CONSULTA, Nullable<int> pARAMETRO1, Nullable<int> pARAMETRO2, Nullable<int> pARAMETRO3, Nullable<int> pARAMETRO4)
        {
            var tIPO_CONSULTAParameter = tIPO_CONSULTA.HasValue ?
                new ObjectParameter("TIPO_CONSULTA", tIPO_CONSULTA) :
                new ObjectParameter("TIPO_CONSULTA", typeof(int));
    
            var pARAMETRO1Parameter = pARAMETRO1.HasValue ?
                new ObjectParameter("PARAMETRO1", pARAMETRO1) :
                new ObjectParameter("PARAMETRO1", typeof(int));
    
            var pARAMETRO2Parameter = pARAMETRO2.HasValue ?
                new ObjectParameter("PARAMETRO2", pARAMETRO2) :
                new ObjectParameter("PARAMETRO2", typeof(int));
    
            var pARAMETRO3Parameter = pARAMETRO3.HasValue ?
                new ObjectParameter("PARAMETRO3", pARAMETRO3) :
                new ObjectParameter("PARAMETRO3", typeof(int));
    
            var pARAMETRO4Parameter = pARAMETRO4.HasValue ?
                new ObjectParameter("PARAMETRO4", pARAMETRO4) :
                new ObjectParameter("PARAMETRO4", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VISTA_PROYECTO_MODELO_OBRA_ACTIVIDAD_TAREA_DETALLE_Result>("VISTA_PROYECTO_MODELO_OBRA_ACTIVIDAD_TAREA_DETALLE", tIPO_CONSULTAParameter, pARAMETRO1Parameter, pARAMETRO2Parameter, pARAMETRO3Parameter, pARAMETRO4Parameter);
        }
    
        public virtual ObjectResult<VISTA_PROYECTO_MODELO_OBRA_ACTIVIDAD_TAREA_DETALLE1_Result> VISTA_PROYECTO_MODELO_OBRA_ACTIVIDAD_TAREA_DETALLE1(Nullable<int> tIPO_CONSULTA, Nullable<int> pARAMETRO1, Nullable<int> pARAMETRO2, Nullable<int> pARAMETRO3, Nullable<int> pARAMETRO4)
        {
            var tIPO_CONSULTAParameter = tIPO_CONSULTA.HasValue ?
                new ObjectParameter("TIPO_CONSULTA", tIPO_CONSULTA) :
                new ObjectParameter("TIPO_CONSULTA", typeof(int));
    
            var pARAMETRO1Parameter = pARAMETRO1.HasValue ?
                new ObjectParameter("PARAMETRO1", pARAMETRO1) :
                new ObjectParameter("PARAMETRO1", typeof(int));
    
            var pARAMETRO2Parameter = pARAMETRO2.HasValue ?
                new ObjectParameter("PARAMETRO2", pARAMETRO2) :
                new ObjectParameter("PARAMETRO2", typeof(int));
    
            var pARAMETRO3Parameter = pARAMETRO3.HasValue ?
                new ObjectParameter("PARAMETRO3", pARAMETRO3) :
                new ObjectParameter("PARAMETRO3", typeof(int));
    
            var pARAMETRO4Parameter = pARAMETRO4.HasValue ?
                new ObjectParameter("PARAMETRO4", pARAMETRO4) :
                new ObjectParameter("PARAMETRO4", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VISTA_PROYECTO_MODELO_OBRA_ACTIVIDAD_TAREA_DETALLE1_Result>("VISTA_PROYECTO_MODELO_OBRA_ACTIVIDAD_TAREA_DETALLE1", tIPO_CONSULTAParameter, pARAMETRO1Parameter, pARAMETRO2Parameter, pARAMETRO3Parameter, pARAMETRO4Parameter);
        }
    
        public virtual ObjectResult<VISTA_PROYECTO_MODELO_OBRA_ACTIVIDAD_TAREA_DETALLE2_Result> VISTA_PROYECTO_MODELO_OBRA_ACTIVIDAD_TAREA_DETALLE2(Nullable<int> tIPO_CONSULTA, Nullable<int> pARAMETRO1, Nullable<int> pARAMETRO2, Nullable<int> pARAMETRO3, Nullable<int> pARAMETRO4)
        {
            var tIPO_CONSULTAParameter = tIPO_CONSULTA.HasValue ?
                new ObjectParameter("TIPO_CONSULTA", tIPO_CONSULTA) :
                new ObjectParameter("TIPO_CONSULTA", typeof(int));
    
            var pARAMETRO1Parameter = pARAMETRO1.HasValue ?
                new ObjectParameter("PARAMETRO1", pARAMETRO1) :
                new ObjectParameter("PARAMETRO1", typeof(int));
    
            var pARAMETRO2Parameter = pARAMETRO2.HasValue ?
                new ObjectParameter("PARAMETRO2", pARAMETRO2) :
                new ObjectParameter("PARAMETRO2", typeof(int));
    
            var pARAMETRO3Parameter = pARAMETRO3.HasValue ?
                new ObjectParameter("PARAMETRO3", pARAMETRO3) :
                new ObjectParameter("PARAMETRO3", typeof(int));
    
            var pARAMETRO4Parameter = pARAMETRO4.HasValue ?
                new ObjectParameter("PARAMETRO4", pARAMETRO4) :
                new ObjectParameter("PARAMETRO4", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VISTA_PROYECTO_MODELO_OBRA_ACTIVIDAD_TAREA_DETALLE2_Result>("VISTA_PROYECTO_MODELO_OBRA_ACTIVIDAD_TAREA_DETALLE2", tIPO_CONSULTAParameter, pARAMETRO1Parameter, pARAMETRO2Parameter, pARAMETRO3Parameter, pARAMETRO4Parameter);
        }
    
        public virtual int INSERT_PREREQ(Nullable<int> cOD_PROYECTO, Nullable<int> cOD_MODELO, Nullable<int> cOD_LOTE, Nullable<int> cOD_ACTIVIDAD, Nullable<int> cOD_TAREA, Nullable<int> cOD_DETALLE, Nullable<decimal> cANTIDAD, Nullable<int> cOD_UNIDAD, string eS_UNIDAD, Nullable<decimal> sOLICITADO, Nullable<decimal> dESPACHO, Nullable<decimal> bODEGA, string iNCLUIR, Nullable<int> nUMERO, Nullable<int> uSUARIO, string iDDISPOSITIVO, string tIPO, string eSTADO)
        {
            var cOD_PROYECTOParameter = cOD_PROYECTO.HasValue ?
                new ObjectParameter("COD_PROYECTO", cOD_PROYECTO) :
                new ObjectParameter("COD_PROYECTO", typeof(int));
    
            var cOD_MODELOParameter = cOD_MODELO.HasValue ?
                new ObjectParameter("COD_MODELO", cOD_MODELO) :
                new ObjectParameter("COD_MODELO", typeof(int));
    
            var cOD_LOTEParameter = cOD_LOTE.HasValue ?
                new ObjectParameter("COD_LOTE", cOD_LOTE) :
                new ObjectParameter("COD_LOTE", typeof(int));
    
            var cOD_ACTIVIDADParameter = cOD_ACTIVIDAD.HasValue ?
                new ObjectParameter("COD_ACTIVIDAD", cOD_ACTIVIDAD) :
                new ObjectParameter("COD_ACTIVIDAD", typeof(int));
    
            var cOD_TAREAParameter = cOD_TAREA.HasValue ?
                new ObjectParameter("COD_TAREA", cOD_TAREA) :
                new ObjectParameter("COD_TAREA", typeof(int));
    
            var cOD_DETALLEParameter = cOD_DETALLE.HasValue ?
                new ObjectParameter("COD_DETALLE", cOD_DETALLE) :
                new ObjectParameter("COD_DETALLE", typeof(int));
    
            var cANTIDADParameter = cANTIDAD.HasValue ?
                new ObjectParameter("CANTIDAD", cANTIDAD) :
                new ObjectParameter("CANTIDAD", typeof(decimal));
    
            var cOD_UNIDADParameter = cOD_UNIDAD.HasValue ?
                new ObjectParameter("COD_UNIDAD", cOD_UNIDAD) :
                new ObjectParameter("COD_UNIDAD", typeof(int));
    
            var eS_UNIDADParameter = eS_UNIDAD != null ?
                new ObjectParameter("ES_UNIDAD", eS_UNIDAD) :
                new ObjectParameter("ES_UNIDAD", typeof(string));
    
            var sOLICITADOParameter = sOLICITADO.HasValue ?
                new ObjectParameter("SOLICITADO", sOLICITADO) :
                new ObjectParameter("SOLICITADO", typeof(decimal));
    
            var dESPACHOParameter = dESPACHO.HasValue ?
                new ObjectParameter("DESPACHO", dESPACHO) :
                new ObjectParameter("DESPACHO", typeof(decimal));
    
            var bODEGAParameter = bODEGA.HasValue ?
                new ObjectParameter("BODEGA", bODEGA) :
                new ObjectParameter("BODEGA", typeof(decimal));
    
            var iNCLUIRParameter = iNCLUIR != null ?
                new ObjectParameter("INCLUIR", iNCLUIR) :
                new ObjectParameter("INCLUIR", typeof(string));
    
            var nUMEROParameter = nUMERO.HasValue ?
                new ObjectParameter("NUMERO", nUMERO) :
                new ObjectParameter("NUMERO", typeof(int));
    
            var uSUARIOParameter = uSUARIO.HasValue ?
                new ObjectParameter("USUARIO", uSUARIO) :
                new ObjectParameter("USUARIO", typeof(int));
    
            var iDDISPOSITIVOParameter = iDDISPOSITIVO != null ?
                new ObjectParameter("IDDISPOSITIVO", iDDISPOSITIVO) :
                new ObjectParameter("IDDISPOSITIVO", typeof(string));
    
            var tIPOParameter = tIPO != null ?
                new ObjectParameter("TIPO", tIPO) :
                new ObjectParameter("TIPO", typeof(string));
    
            var eSTADOParameter = eSTADO != null ?
                new ObjectParameter("ESTADO", eSTADO) :
                new ObjectParameter("ESTADO", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INSERT_PREREQ", cOD_PROYECTOParameter, cOD_MODELOParameter, cOD_LOTEParameter, cOD_ACTIVIDADParameter, cOD_TAREAParameter, cOD_DETALLEParameter, cANTIDADParameter, cOD_UNIDADParameter, eS_UNIDADParameter, sOLICITADOParameter, dESPACHOParameter, bODEGAParameter, iNCLUIRParameter, nUMEROParameter, uSUARIOParameter, iDDISPOSITIVOParameter, tIPOParameter, eSTADOParameter);
        }
    
        public virtual ObjectResult<VISTA_PROYECTO_MODELO_OBRA_ACTIVIDAD_TAREA_DETALLE3_Result> VISTA_PROYECTO_MODELO_OBRA_ACTIVIDAD_TAREA_DETALLE3(Nullable<int> tIPO_CONSULTA, Nullable<int> pARAMETRO1, Nullable<int> pARAMETRO2, Nullable<int> pARAMETRO3, Nullable<int> pARAMETRO4)
        {
            var tIPO_CONSULTAParameter = tIPO_CONSULTA.HasValue ?
                new ObjectParameter("TIPO_CONSULTA", tIPO_CONSULTA) :
                new ObjectParameter("TIPO_CONSULTA", typeof(int));
    
            var pARAMETRO1Parameter = pARAMETRO1.HasValue ?
                new ObjectParameter("PARAMETRO1", pARAMETRO1) :
                new ObjectParameter("PARAMETRO1", typeof(int));
    
            var pARAMETRO2Parameter = pARAMETRO2.HasValue ?
                new ObjectParameter("PARAMETRO2", pARAMETRO2) :
                new ObjectParameter("PARAMETRO2", typeof(int));
    
            var pARAMETRO3Parameter = pARAMETRO3.HasValue ?
                new ObjectParameter("PARAMETRO3", pARAMETRO3) :
                new ObjectParameter("PARAMETRO3", typeof(int));
    
            var pARAMETRO4Parameter = pARAMETRO4.HasValue ?
                new ObjectParameter("PARAMETRO4", pARAMETRO4) :
                new ObjectParameter("PARAMETRO4", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VISTA_PROYECTO_MODELO_OBRA_ACTIVIDAD_TAREA_DETALLE3_Result>("VISTA_PROYECTO_MODELO_OBRA_ACTIVIDAD_TAREA_DETALLE3", tIPO_CONSULTAParameter, pARAMETRO1Parameter, pARAMETRO2Parameter, pARAMETRO3Parameter, pARAMETRO4Parameter);
        }
    }
}
