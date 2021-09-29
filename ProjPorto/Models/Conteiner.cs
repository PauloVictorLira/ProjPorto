using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjPorto.Models
{
	public class Conteiner
	{
		[Key]
		public int Id { get; set; }
		public string Cliente { get; set; }
		[Display(Name = "Número")]
		[RegularExpression("[A-Z]{4}[0-9]{7}", ErrorMessage = "4 letras e 7 números (Ex: TEST1234567)")]
		public string Numero { get; set; }
		[Display(Name = "Tipo")]
		public TipoConteiner TipoConteiner { get; set; }
		public Status Status { get; set; }
		public Categoria Categoria { get; set; }
		public List<Movimentacao> Movimentacoes { get; set; }
	}
}
