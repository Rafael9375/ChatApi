using ChatAPI.Context;
using ChatAPI.Controllers;
using ChatAPI.Models;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ChatApiXUnitTest
{
    public class UsuarioTest
    {
        [Fact]
        public async Task GetTest()
        {
            var options = new DbContextOptionsBuilder<DBChatContext>()
                .UseInMemoryDatabase($"db-{System.Guid.NewGuid()}")
                .Options;

            await using var db = new DBChatContext(options);
            db.Usuarios.AddRange(
                new Usuario { Id = 1, Nome = "Rafael", Apelido = "Rafa" }

            );
            await db.SaveChangesAsync();
            UsuarioController controller = new UsuarioController(db);
            var result = controller.Get();

            var action = await controller.Get();

            // garante que foi 200 OK
            action.Result.Should().BeOfType<OkObjectResult>();

            var ok = (OkObjectResult)action.Result!;
            var usuarios = (IEnumerable<Usuario>)ok.Value!;

            usuarios.Should().HaveCount(10);
        }
    }
}
