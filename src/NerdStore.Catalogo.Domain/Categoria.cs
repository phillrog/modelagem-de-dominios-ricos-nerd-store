using NerdStore.Core.DomainObjects;

namespace NerdStore.Catalogo.Domain
{
	public class Categoria : Entity, IAggregateRoot
	{
		public string Nome { get; private set; }
		public int Codigo { get; private set; }

		public Categoria(string nome, int codigo)
		{
			Nome = nome;
			Codigo = codigo;
		}

		public override string ToString()
		{
			return $"{Nome} - {Codigo}";
		}
	}
}
