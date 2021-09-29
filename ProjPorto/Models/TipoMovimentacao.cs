using System.ComponentModel.DataAnnotations;

namespace ProjPorto.Models
{
	public enum TipoMovimentacao
	{
		embarque, 
		descarga,
		[Display(Name = "gate in")]
		gate_in,
		[Display(Name = "gate out")]
		gate_out, 
		reposicionamento, 
		pesagem, 
		scanner
	}
}