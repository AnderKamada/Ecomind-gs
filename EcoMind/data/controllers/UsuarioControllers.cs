using Microsoft.AspNetCore.Mvc;
using ConsumoEnergetico.Data;

[ApiController]
[Route("api/[controller]")]
public class UsuarioControllers : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public UsuarioControllers(ApplicationDbContext context)
    {
        _context = context;
    }

    // Endpoint: Obter todos os usuários
    [HttpGet]
    public IActionResult GetUsuarios()
    {
        var usuarios = _context.Usuarios.ToList();
        return Ok(usuarios);
    }

    // Endpoint: Obter um usuário por ID
    [HttpGet("{id}")]
    public IActionResult GetUsuario(int id)
    {
        var usuario = _context.Usuarios.Find(id);
        if (usuario == null)
            return NotFound();

        return Ok(usuario);
    }

    // Endpoint: Criar um novo usuário
    [HttpPost]
    public IActionResult CreateUsuario([FromBody] Usuario usuario)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        _context.Usuarios.Add(usuario);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetUsuario), new { id = usuario.Id }, usuario);
    }

    // Endpoint: Atualizar um usuário existente
    [HttpPut("{id}")]
    public IActionResult UpdateUsuario(int id, [FromBody] Usuario usuarioAtualizado)
    {
        var usuario = _context.Usuarios.Find(id);
        if (usuario == null)
            return NotFound();

        usuario.Nome = usuarioAtualizado.Nome;
        usuario.Email = usuarioAtualizado.Email;
        _context.SaveChanges();

        return NoContent();
    }

    // Endpoint: Deletar um usuário
    [HttpDelete("{id}")]
    public IActionResult DeleteUsuario(int id)
    {
        var usuario = _context.Usuarios.Find(id);
        if (usuario == null)
            return NotFound();

        _context.Usuarios.Remove(usuario);
        _context.SaveChanges();

        return NoContent();
    }
}
