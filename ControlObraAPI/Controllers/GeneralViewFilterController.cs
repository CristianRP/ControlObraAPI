using ControlObraAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ControlObraAPI.Controllers
{
    public class GeneralViewFilterController : ApiController
    {
        private CFB_BuildEntities db = new CFB_BuildEntities();

        // GET: api/Proyecto
        [Route("api/Proyecto")]
        public IEnumerable<VISTA_PROYECTO_MODELO_OBRA_ACTIVIDAD_TAREA_DETALLE2_Result> GetProyecto(int tipoConsulta)
        {
            return db.VISTA_PROYECTO_MODELO_OBRA_ACTIVIDAD_TAREA_DETALLE2(tipoConsulta, null, null, null, null).AsEnumerable();
        }

        // GET: api/Modelo
        [Route("api/Modelo")]
        public IEnumerable<VISTA_PROYECTO_MODELO_OBRA_ACTIVIDAD_TAREA_DETALLE2_Result> GetModelo(int tipoConsulta, int parametro)
        {
            return db.VISTA_PROYECTO_MODELO_OBRA_ACTIVIDAD_TAREA_DETALLE2(tipoConsulta, parametro, null, null, null).AsEnumerable();
        }

        // GET: api/Obra
        [Route("api/Obra")]
        public IEnumerable<VISTA_PROYECTO_MODELO_OBRA_ACTIVIDAD_TAREA_DETALLE2_Result> GetObra(int tipoConsulta, int parametro, int parametro1)
        {
            return db.VISTA_PROYECTO_MODELO_OBRA_ACTIVIDAD_TAREA_DETALLE2(tipoConsulta, parametro, parametro1, null, null).AsEnumerable();
        }

        // GET: api/Actividad
        [Route("api/Actividad")]
        public IEnumerable<VISTA_PROYECTO_MODELO_OBRA_ACTIVIDAD_TAREA_DETALLE2_Result> GetActividad(int tipoConsulta, int parametro, int parametro1)
        {
            return db.VISTA_PROYECTO_MODELO_OBRA_ACTIVIDAD_TAREA_DETALLE2(tipoConsulta, parametro, parametro1, null, null).AsEnumerable();
        }

        // GET: api/Tarea
        [Route("api/Tarea")]
        public IEnumerable<VISTA_PROYECTO_MODELO_OBRA_ACTIVIDAD_TAREA_DETALLE2_Result> GetTarea(int tipoConsulta, int parametro, int parametro1, 
            int parametro2, int parametro3)
        {
            return db.VISTA_PROYECTO_MODELO_OBRA_ACTIVIDAD_TAREA_DETALLE2(tipoConsulta, parametro, parametro1, parametro2, parametro3).AsEnumerable();
        }

        // GET: api/Detalle
        [Route("api/Detalle")]
        public IEnumerable<VISTA_PROYECTO_MODELO_OBRA_ACTIVIDAD_TAREA_DETALLE2_Result> GetDetalle(int tipoConsulta, int parametro, int parametro1,
            int parametro2, int parametro3)
        {
            return db.VISTA_PROYECTO_MODELO_OBRA_ACTIVIDAD_TAREA_DETALLE2(tipoConsulta, parametro, parametro1, parametro2, parametro3).AsEnumerable();
        }

        // GET: api/GeneralViewFilter/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/GeneralViewFilter
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/GeneralViewFilter/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/GeneralViewFilter/5
        public void Delete(int id)
        {
        }
    }
}
