using Dapper;
using Microsoft.EntityFrameworkCore;
using System.Data;
using WinFormsCRUD.Data;
using WinFormsCRUD.Interfaces;
using WinFormsCRUD.Models;
using WinFormsCRUD.ViewModels;

namespace WinFormsCRUD.Repositories;

public class PessoaRepository : IPessoaRepository
{
	private readonly IDbConnection _dbcConnection;
	private readonly AppDbContext _dbContext;
	public PessoaRepository(IDbConnection dbcConnection, AppDbContext dbContext)
	{
		_dbcConnection = dbcConnection;
		_dbContext = dbContext;
	}

	public void AddPessoa(Pessoa pessoa)
	{
		_dbContext.Add(pessoa);
	}

	public async Task<PessoaCreateViewModel> AddPessoaDapper(PessoaCreateViewModel pessoaCreateViewModel)
	{
		var addPessoaQuery = @"INSERT INTO Pessoas(Nome)
							   VALUES(@Nome);";

		_dbcConnection.Open();

		await _dbcConnection.ExecuteAsync(addPessoaQuery, new PessoaCreateViewModel()
		{
			Nome = pessoaCreateViewModel.Nome
		});

		_dbcConnection.Close();

		return pessoaCreateViewModel;
	}

	public async Task RemovePessoaDapper(int id)
	{
		var removePessoaQuery = @"DELETE 
								  FROM Pessoas
								  WHERE PessoaId = @PessoaId;";

		_dbcConnection.Open();

		await _dbcConnection.ExecuteAsync(removePessoaQuery, new { PessoaId = id });

		_dbcConnection.Close();
	}

	public void EditPessoa(Pessoa pessoa)
	{
		_dbContext.Update(pessoa);
	}

	public async Task<PessoaEditViewModel> EditPessoaDapper(PessoaEditViewModel pessoaEditViewModel)
	{
		var editPessoaQuery = @"UPDATE Pessoas
								SET Nome = @Nome
								WHERE PessoaId = @PessoaId";

		_dbcConnection.Open();

		await _dbcConnection.ExecuteAsync(editPessoaQuery, new PessoaEditViewModel()
		{
			Nome = pessoaEditViewModel.Nome,
			PessoaId = pessoaEditViewModel.PessoaId
		});

		_dbcConnection.Close();

		return pessoaEditViewModel;
	}

	public async Task<Pessoa> GetPessoa(int id)
	{
		var pessoa = await _dbContext.Pessoas
			.Where(x => x.PessoaId == id)
			.FirstOrDefaultAsync();

		return pessoa;
	}

	public async Task<PessoaToListViewModel> GetPessoaDapper(int id)
	{
		var getPessoaQuery = @"SELECT PessoaId,
							   	      Nome
							   FROM Pessoas
							   WHERE PessoaId = @PessoaId;";

		_dbcConnection.Open();

		var result = await _dbcConnection.QueryFirstOrDefaultAsync<PessoaToListViewModel>(getPessoaQuery, new PessoaToListViewModel()
		{
			PessoaId = id
		});

		_dbcConnection.Close();

		return result;
	}

	public async Task<IEnumerable<Pessoa>> GetPessoas()
	{
		return await _dbContext.Pessoas.AsNoTracking().ToListAsync();
	}

	public async Task<IEnumerable<Pessoa>> GetPessoasDapper()
	{
		var getPessoasQuery = @"SELECT PessoaId,
											 Nome
									  FROM Pessoas
									  ORDER BY PessoaId ASC;";

		_dbcConnection.Open();

		var result = await _dbcConnection.QueryAsync<Pessoa>(getPessoasQuery);

		_dbcConnection.Close();

		return result.ToList();
	}

	public void RemovePessoa(Pessoa pessoa)
	{
		_dbContext.Remove(pessoa);
	}

	public async Task<bool> SaveAll()
	{
		return await _dbContext.SaveChangesAsync() > 0;
	}
}
