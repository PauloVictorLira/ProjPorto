using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjPorto.Models
{
	public class Movimentacao
	{
		[Key]
		public int Id { get; set; }
		[Display(Name = "Tipo")]
		public TipoMovimentacao TipoMovimentacao { get; set; }
		[Display(Name = "Data/Hora do Início")]
		public DateTime Inicio { get; set; }
		[Display(Name = "Data/Hora do Fim")]
		public DateTime Fim { get; set; }
		public int ConteinerId { get; set; }
		public Conteiner Conteiner { get; set; }
	}
}
