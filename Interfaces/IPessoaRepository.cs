using WinFormsCRUD.Models;
using WinFormsCRUD.ViewModels;

namespace WinFormsCRUD.Interfaces;
public interface IPessoaRepository
{
	Task<IEnumerable<Pessoa>> GetPessoas();
	Task<IEnumerable<Pessoa>> GetPessoasDapper();
	Task<Pessoa> GetPessoa(int id);
	Task<PessoaToListViewModel> GetPessoaDapper(int id);
	void AddPessoa(Pessoa pessoa);
	Task<PessoaCreateViewModel> AddPessoaDapper(PessoaCreateViewModel pessoaCreateViewModel);
	void EditPessoa(Pessoa pessoa);
	Task<PessoaEditViewModel> EditPessoaDapper(PessoaEditViewModel pessoaEditViewModel);
	void RemovePessoa(Pessoa pessoa);
	Task RemovePessoaDapper(int id);
	Task<bool> SaveAll();
}
