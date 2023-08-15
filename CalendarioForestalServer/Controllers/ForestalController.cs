using CalendarioForestalServer.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;

namespace CalendarioForestalServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForestalController : ControllerBase
    {
        public readonly IConfiguration _configuration;  
        public ForestalController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        [Route("GetAllRegistros")]
        public JsonResult GetRegistros()
        {
            SqlConnection con = new(_configuration.GetConnectionString("ForestalDb").ToString());
            string query = "Select r.idRegistro,r.fecha, fl.nombreFaseLunar, e.nombreEpoca, t.nombreTiempo, ar.nombreCicloArbol, c.nombreCambio, ct.nombreCuatrimestre, a.idActividad, a.nombreActividad from LISTACTIVIDAD as l JOIN Actividad as a ON a.idActividad = l.idActividad JOIN Registro as r ON r.idRegistro = l.idRegistro JOIN faselunar as fl ON fl.idFaseLunar = r.idFaseLunar JOIN epoca as e ON e.idEpoca = r.idEpoca JOIN tiempo as t ON t.idTiempo = r.idTiempo JOIN arbol as ar ON ar.idArbol = r.idArbol JOIN cambiosol as c ON c.idCambioSol = r.idCambioSol JOIN cuatrimestre as ct ON ct.idCuatrimestre = r.idCuatrimestre;";
            SqlDataAdapter da = new(query, con);
            DataTable dt = new();
            da.Fill(dt);
            Response response = new();
            List<Registro> registros = new();
            if (dt.Rows.Count>0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Registro registro = new();
                    registro.IdRegistro = Convert.ToInt32(dt.Rows[i]["idRegistro"]);
                    registro.Fecha = (DateTime)dt.Rows[i]["fecha"];
                    registro.NombreFaseLunar = dt.Rows[i]["nombreFaseLunar"].ToString();
                    registro.NombreEpoca = dt.Rows[i]["nombreEpoca"].ToString(); ;
                    registro.NombreTiempo = dt.Rows[i]["nombreTiempo"].ToString(); 
                    registro.NombreCicloArbol = dt.Rows[i]["nombreCicloArbol"].ToString();
                    registro.NombreCambioSol = dt.Rows[i]["nombreCambio"].ToString(); 
                    registro.NombreCuatrimestre = dt.Rows[i]["nombreCuatrimestre"].ToString(); 
                    registro.IdActividad = Convert.ToInt32(dt.Rows[i]["idActividad"]);
                    registro.NombreActividad = dt.Rows[i]["nombreActividad"].ToString(); 
                    registros.Add(registro);
                }
            }
            if (registros.Count >0)
            {
                return new JsonResult(registros);
            }
            else
            {
                response.Status = 404;
                response.Message = "No Data Found";
                return new JsonResult(response);
            }

        }

    }
}
