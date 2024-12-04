public interface IPedidoRepository
{
    public List<Pedido> GetAll();
    public Pedido GetById(int id);
    public void Post(Pedido pedido);
    public Pedido Put(int id, Pedido pedidoAtualizado);
    public Pedido Delete(int id);
}