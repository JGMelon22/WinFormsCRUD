using Microsoft.EntityFrameworkCore;

namespace WinFormsCRUD.Models;

[Table("Pessoas")]
[Index(nameof(PessoaId))]
public class Pessoa
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	[Column("PessoaId")]
	public int PessoaId { get; set; }

	[Column("Nome"), DataType("VARCHAR(100)")]
	[Required]
	public string Nome { get; set; } = string.Empty!;
}
