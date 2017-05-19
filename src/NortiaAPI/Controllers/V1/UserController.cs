using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Entities.V1;
using Data.BDD.MSQL;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace NortiaAPI.Controllers.V1
{
    [Route("V1/users", Name = "UserDefault")]
    public class UserController : Controller
    {
        /// <summary>
        /// Get all parcours clients connaissance client PP of one client
        /// </summary>
        /// <param name="ident">The client id</param>
        /// <returns>The list of parcours clients connaissance client PP with an HTTP 200, or error message with an HTTP 500</returns>
        /// <response code="200">Ok</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="500">Error</response>
        [HttpPost("Login")]
        [ProducesResponseType(200)]
        [ProducesResponseType(401)]
        [ProducesResponseType(500)]
        public IActionResult Login([FromBody] User.Identification ident)
        {
            try
            {
                if (ident != null)
                {
                    string sql = "SELECT * FROM Utilisateur WHERE Email='" + ident.Login + "' and Password='" + ident.Password + "'";
                    System.Data.DataTable data = MSQLService.GetDataFromQuery(sql, MSQLService.ConnectionString_WSNortia);

                    if (data.Rows.Count > 0)
                    {
                        User u = new User();
                        u.Id = data.Rows[0]["ID_Salesforce"].ToString();
                        u.CodeNortia = data.Rows[0]["CodeNortia"].ToString();
                        u.Email = data.Rows[0]["Email"].ToString();
                        u.PasswordProvisoire = (bool)data.Rows[0]["PasswordProvisoire"];

                        return Ok(u);
                    }
                    else
                        return Unauthorized();
                }
                else
                    return Unauthorized();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
