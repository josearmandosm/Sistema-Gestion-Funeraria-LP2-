using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Sistema_Gestion_Funeraria__LP2_.Helper;
using Sistema_Gestion_Funeraria__LP2_.Models;
using Sistema_Gestion_Funeraria__LP2_.Models.DTOs.Usuario;

namespace Web_API_Curso.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly AuthHelper authHelper;
        public UsuarioController(UserManager<ApplicationUser> userManager, AuthHelper authHelper)
        {
            this.userManager = userManager;
            this.authHelper = authHelper;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] NuevoUsuarioDTO nuevoUsuario)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var appUser = new ApplicationUser
                {
                    UserName = nuevoUsuario.Usuario,
                    Email = nuevoUsuario.CorreoElectronico,
                };

                var createdUser = await userManager.CreateAsync(appUser, nuevoUsuario.Contraseña);

                if (createdUser.Succeeded)
                {
                    var roleResult = await userManager.AddToRoleAsync(appUser, "Usuario");
                    if (roleResult.Succeeded)
                    {
                        return Ok(
                            new UsuarioDTO
                            {
                                Usuario = appUser.UserName,
                                CorreoElectronico = appUser.Email,
                                Token = authHelper.GenerateJWTToken(appUser)
                            }
                        );
                    }
                    else
                    {
                        return StatusCode(500, roleResult.Errors);
                    }
                }
                else
                {
                    return StatusCode(500, createdUser.Errors);
                }
            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }
        }
    }
}