namespace WinFormsCRUD.ViewModels;

public class PessoaEditViewModel
{
	public int PessoaId { get; set; }
	[Required]
	public string Nome { get; set; } = string.Empty!;
}
