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
    }
}
