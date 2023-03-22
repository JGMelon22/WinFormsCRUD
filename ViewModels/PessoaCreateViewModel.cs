namespace WinFormsCRUD.ViewModels;

public class PessoaCreateViewModel
{

	[Column("Nome"), DataType("VARCHAR(100)")]
	[Required]
	public string Nome { get; set; } = string.Empty!;
}
