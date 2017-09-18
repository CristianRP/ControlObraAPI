using ControlObraAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace ControlObraAPI.Controllers
{
    public class GeneralViewFilterController : ApiController
    {
        private CFB_BuildEntities db = new CFB_BuildEntities();

        // GET: api/Proyecto
        [Route("api/Proyecto")]
        public IEnumerable<VISTA_PROYECTO_MODELO_OBRA_ACTIVIDAD_TAREA_DETALLE3_Result> GetProyecto(int tipoConsulta)
        {
            return db.VISTA_PROYECTO_MODELO_OBRA_ACTIVIDAD_TAREA_DETALLE3(tipoConsulta, null, null, null, null).AsEnumerable();
        }

        // GET: api/Modelo
        [Route("api/Modelo")]
        public IEnumerable<VISTA_PROYECTO_MODELO_OBRA_ACTIVIDAD_TAREA_DETALLE3_Result> GetModelo(int tipoConsulta, int parametro)
        {
            return db.VISTA_PROYECTO_MODELO_OBRA_ACTIVIDAD_TAREA_DETALLE3(tipoConsulta, parametro, null, null, null).AsEnumerable();
        }

        // GET: api/Obra
        [Route("api/Obra")]
        public IEnumerable<VISTA_PROYECTO_MODELO_OBRA_ACTIVIDAD_TAREA_DETALLE3_Result> GetObra(int tipoConsulta, int parametro, int parametro1)
        {
            return db.VISTA_PROYECTO_MODELO_OBRA_ACTIVIDAD_TAREA_DETALLE3(tipoConsulta, parametro, parametro1, null, null).AsEnumerable();
        }

        // GET: api/Actividad
        [Route("api/Actividad")]
        public IEnumerable<VISTA_PROYECTO_MODELO_OBRA_ACTIVIDAD_TAREA_DETALLE3_Result> GetActividad(int tipoConsulta, int parametro, int parametro1)
        {
            return db.VISTA_PROYECTO_MODELO_OBRA_ACTIVIDAD_TAREA_DETALLE3(tipoConsulta, parametro, parametro1, null, null).AsEnumerable();
        }

        // GET: api/Tarea
        [Route("api/Tarea")]
        public IEnumerable<VISTA_PROYECTO_MODELO_OBRA_ACTIVIDAD_TAREA_DETALLE3_Result> GetTarea(int tipoConsulta, int parametro, int parametro1, 
            int parametro2, int parametro3)
        {
            return db.VISTA_PROYECTO_MODELO_OBRA_ACTIVIDAD_TAREA_DETALLE3(tipoConsulta, parametro, parametro1, parametro2, parametro3).AsEnumerable();
        }

        // GET: api/Detalle
        [Route("api/Detalle")]
        public IEnumerable<VISTA_PROYECTO_MODELO_OBRA_ACTIVIDAD_TAREA_DETALLE3_Result> GetDetalle(int tipoConsulta, int parametro, int parametro1,
            int parametro2, int parametro3)
        {
            return db.VISTA_PROYECTO_MODELO_OBRA_ACTIVIDAD_TAREA_DETALLE3(tipoConsulta, parametro, parametro1, parametro2, parametro3).AsEnumerable();
        }

        // POST: api/

        // GET: api/GeneralViewFilter/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Requisicion
        [ResponseType(typeof(Requisicion))]
        [Route("api/Requisicion")]
        public async Task<IHttpActionResult> RequisicionPost(Requisicion req)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.INSERT_PREREQ(req.CodProyecto, req.CodModelo, req.CodLote, req.CodActividad, req.CodTarea,
                req.CodDetalle, req.Cantidad, req.CodUnidad, req.EsUnidad, req.Solicitado, req.Despacho,
                req.Bodega, req.Incluir, req.Numero, req.Usuario, req.IdDispositivo, req.Tipo, req.Estado);
            await db.SaveChangesAsync();
            return Ok(req);
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
