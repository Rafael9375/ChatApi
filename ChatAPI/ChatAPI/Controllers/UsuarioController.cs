using ChatAPI.Context;
using ChatAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ChatAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        public readonly DBChatContext db;

        public UsuarioController(DBChatContext _db)
        {
            db = _db;
        }

        [HttpGet]
        public List<Usuario> Get()
        {
            var lista = this.db.Usuarios.ToList();
            
            return lista;
        }
    }
}
