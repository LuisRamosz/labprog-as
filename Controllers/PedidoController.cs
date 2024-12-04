using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class PedidoController : ControllerBase
{
    private readonly IPedidoRepository _repository;

    public PedidoController(IPedidoRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public ActionResult<List<Pedido>> GetAll()
    {
        return Ok(_repository.GetAll());
    }

    [HttpGet("{id}")]
    public ActionResult<Pedido> GetById(int id)
    {
         var pedidoEncontrado = _repository.GetById(id);

        if(pedidoEncontrado == null)
            return NotFound();

        return pedidoEncontrado;
    }

    [HttpPost]
    public ActionResult Post(Pedido pedido)
    {
        _repository.Post(pedido);
        return Created();
    }
    
    [HttpPut("{id}")]
    public ActionResult Put(int id, Pedido pedidoAtualizado)
    {
        var pedidoEncontrado = _repository.Put(id, pedidoAtualizado);
        
        if(pedidoEncontrado == null)
            return NotFound();
        
        return Ok(pedidoEncontrado);
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        var pedidoEncontrado = _repository.Delete(id);
        
        if(pedidoEncontrado == null)
            return NotFound();
        
        return NoContent();
    }
}