using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("productos")]
public class Conexion : Controller
{
    private IMongoCollection<Productos> _productos;

    [HttpGet("mongo")]
    public IActionResult ListarProductosMongoDB()
    {
        var client = new MongoClient(CadenasConexion.MONGO_DB);
        var database = client.GetDatabase("practica2_zaira_jose");
        _productos = database.GetCollection<Productos>("TiendaElectronica");
        var list = _productos.Find(FilterDefinition<Productos>.Empty).ToList();

        return Ok(list);
    }

    [HttpGet]
    public ActionResult<List<Productos>> Get()
    {
        return _productos.Find(producto => true).ToList();
    }
}