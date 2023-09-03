namespace EmpresaCadeteria;

public enum EstadoPedido
{
	Entregado,
	Pendiente,
	Cancelado
}

public class Pedido
{
	private int nro;
	private string descripcion;
	private Cliente cliente;
	private EstadoPedido estado;

	public int Nro { get => nro; }
	public string Descripcion { get => descripcion; }
	public Cliente Cliente { get => cliente; }
	public EstadoPedido Estado { get => estado; }

	public Pedido(int numero, string descripcion, EstadoPedido estado, string nomCliente, string dirCliente, string telCliente = null, string referencia = null)
	{
		this.nro = numero;
		this.descripcion = descripcion;
		this.cliente = new Cliente(nomCliente, dirCliente, telCliente, referencia);
		this.estado = estado;
	}

	private string VerDireccionCliente()
	{
		return Cliente.Direccion; 
	}

	public string VerDatosCliente()
	{
		return $"Nombre: {Cliente.Nombre}\nDirección: {VerDireccionCliente()}\nTeléfono: {Cliente.Telefono}\nReferencias: {Cliente.ReferenciaDireccion}";
	}
}
