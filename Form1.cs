using Microsoft.IdentityModel.Tokens;
using System.Runtime.InteropServices;
using WinFormsCRUD.Helpers;
using WinFormsCRUD.Interfaces;
using WinFormsCRUD.ViewModels;

namespace WinFormsCRUD;

public partial class Form1 : Form
{
	private readonly IPessoaRepository _pessoaRepository;

	// Dark Header
	[DllImport("DwmApi")] //System.Runtime.InteropServices
	private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

	protected override void OnHandleCreated(EventArgs e)
	{
		if (DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4) != 0)
			DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);
	}
	public Form1(IPessoaRepository pessoaRepository)
	{
		_pessoaRepository = pessoaRepository;
		InitializeComponent();
	}
	private void Form1_Load(object sender, EventArgs e)
	{
		chkBoxEFCore.Checked = false;

		EnableEfCore();

		LimparForm();
	}

	private async void btnCadastrar_Click(object sender, EventArgs e)
	{
		Cursor cursor = Cursors.WaitCursor;

		if (txtNomePessoa.Text.IsNullOrEmpty())
			MessageBox.Show("Nome da pessoa deve ser informado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

		else
		{
			cursor = Cursors.Default;

			PessoaCreateViewModel createPessoaViewModel = new PessoaCreateViewModel();

			createPessoaViewModel.Nome = txtNomePessoa.Text;

			var pessoaCadastrar = await _pessoaRepository.AddPessoaDapper(createPessoaViewModel);

			MessageBox.Show($"Nova pessoa registrada com exito! Nome informado: {txtNomePessoa.Text}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			cursor = Cursors.Default;
		}
	}

	private async void btnListarDapper_Click(object sender, EventArgs e)
	{
		btnListarDapper.Enabled = false;

		Cursor cursor = Cursors.WaitCursor;

		lstBoxPessoas.Items.Clear();

		var pessoas = await _pessoaRepository.GetPessoasDapper();

		foreach (var item in pessoas)
		{
			lstBoxPessoas.Items.Add(item.PessoaId + " - " + item.Nome);
		}

		cursor = Cursors.Default;

		btnListarDapper.Enabled = true;
	}

	private async void btnListarEfCore_Click(object sender, EventArgs e)
	{
		btnListarEfCore.Enabled = false;

		Cursor cursor = Cursors.WaitCursor;

		lstBoxPessoas.Items.Clear();

		var pessoas = await _pessoaRepository.GetPessoas();

		foreach (var item in pessoas)
		{
			lstBoxPessoas.Items.Add(item.PessoaId + " - " + item.Nome);
		}

		cursor = Cursors.Default;

		btnListarEfCore.Enabled = true;
	}

	private async void btnPesquisarPessoa_Click(object sender, EventArgs e)
	{
		btnPesquisarPessoa.Enabled = false;

		Cursor cursor = Cursors.WaitCursor;

		if (!txtIdPessoa.Text.IsNullOrEmpty())
		{
			var pessoa = await _pessoaRepository.GetPessoaDapper(Int16.Parse(txtIdPessoa.Text));

			if (pessoa != null)
			{
				txtNomePessoa.Text = "";
				lstBoxPessoas.Items.Clear();

				txtNomePessoa.Text = pessoa.Nome;
				lstBoxPessoas.Items.Add(pessoa.PessoaId + " - " + pessoa.Nome);

				// Liberar para edição/deleção
				btnDeletar.Enabled = true;
				btnDeletarDapper.Enabled = true;

				btnEditar.Enabled = true;
				// btnEditarEf.Enabled = true;
			}

			else
			{
				MessageBox.Show("Id inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		else
		{
			MessageBox.Show("Id da pessoa deve ser informado para realizar uma pesquisa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		cursor = Cursors.Default;

		btnPesquisarPessoa.Enabled = true;
	}

	private async void btnPesquisarPessoaEF_Click(object sender, EventArgs e)
	{
		btnPesquisarPessoa.Enabled = false;

		Cursor cursor = Cursors.WaitCursor;

		if (!txtIdPessoa.Text.IsNullOrEmpty())
		{
			// var pessoa = await _pessoaRepository.GetPessoa(Int16.Parse(txtIdPessoa.Text));
			var pessoa = await _pessoaRepository.GetPessoaCompiled(Int16.Parse(txtIdPessoa.Text));

			if (pessoa != null)
			{
				txtNomePessoa.Text = "";
				lstBoxPessoas.Items.Clear();

				txtNomePessoa.Text = pessoa.Nome;
				lstBoxPessoas.Items.Add(pessoa.PessoaId + " - " + pessoa.Nome);

				// Liberar para edição/deleção
				btnDeletar.Enabled = true;
				btnDeletarDapper.Enabled = true;
			}

			else
			{
				MessageBox.Show("Id inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		else
		{
			MessageBox.Show("Id da pessoa deve ser informado para realizar uma pesquisa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		cursor = Cursors.Default;

		btnPesquisarPessoa.Enabled = true;
	}

	private void txtIdPessoa_KeyPress(object sender, KeyPressEventArgs e)
	{
		TextBoxInputNumbers textBoxInputNumber = new TextBoxInputNumbers();
		if (!textBoxInputNumber.TextBoxLimit(e))
		{
			MessageBox.Show("Apenas números são aceitos na busca por Id", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}

	private async void btnDeletarDapper_Click(object sender, EventArgs e)
	{
		if (MessageBox.Show($"{txtNomePessoa.Text} - {txtIdPessoa.Text} será deletado. Deseja confirmar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
		{
			await _pessoaRepository.RemovePessoaDapper(Int16.Parse(txtIdPessoa.Text));
			MessageBox.Show("Pessoa deletada com exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

			lstBoxPessoas.Items.Clear();

			var atualizarLista = await _pessoaRepository.GetPessoasDapper();

			LimparForm();

			foreach (var item in atualizarLista)
			{
				lstBoxPessoas.Items.Add(item.PessoaId + " - " + item.Nome);
			}
		}

		else
		{
			MessageBox.Show("Operação cancelada pelo usuário!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

			LimparForm();
		}
	}

	private async void btnDeletar_Click(object sender, EventArgs e)
	{

		if (MessageBox.Show($"{txtNomePessoa.Text} - {txtIdPessoa.Text} será deletado. Deseja confirmar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
		{
			var pessoaRemove = await _pessoaRepository.GetPessoa(Int16.Parse(txtIdPessoa.Text));

			_pessoaRepository.RemovePessoa(pessoaRemove);
			MessageBox.Show("Pessoa deletada com exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

			lstBoxPessoas.Items.Clear();

			var atualizarLista = await _pessoaRepository.GetPessoas();

			LimparForm();

			foreach (var item in atualizarLista)
			{
				lstBoxPessoas.Items.Add(item.PessoaId + " - " + item.Nome);
			}
		}

		else
		{
			MessageBox.Show("Operação cancelada pelo usuário!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

			LimparForm();
		}
	}

	private async void btnEditar_Click(object sender, EventArgs e)
	{
		if (MessageBox.Show($"{txtNomePessoa.Text} - {txtIdPessoa.Text} será editado. Deseja confirmar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
		{
			var pessoaEditar = await _pessoaRepository.GetPessoaDapper(Int16.Parse(txtIdPessoa.Text));

			PessoaEditViewModel pessoaEditViewModel = new PessoaEditViewModel();

			pessoaEditViewModel.Nome = txtNomePessoa.Text;
			pessoaEditViewModel.PessoaId = Int16.Parse(txtIdPessoa.Text);

			var pessoaCadastrar = await _pessoaRepository.EditPessoaDapper(pessoaEditViewModel);

			lstBoxPessoas.Items.Clear();

			var atualizarLista = await _pessoaRepository.GetPessoasDapper();

			LimparForm();

			foreach (var item in atualizarLista)
			{
				lstBoxPessoas.Items.Add(item.PessoaId + " - " + item.Nome);
			}
		}

		else
		{
			MessageBox.Show("Operação cancelada pelo usuário!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

			LimparForm();
		}

	}

	// Habilitar botões EF
	public void EnableEfCore()
	{
		if (chkBoxEFCore.Checked == true)
		{
			btnDeletar.Visible = true;
			btnPesquisarPessoaEF.Visible = true;
			btnEditarEf.Visible = true;
			btnListarEfCore.Visible = true;
		}

		else if (chkBoxEFCore.Checked == false)
		{
			btnDeletar.Visible = false;
			btnPesquisarPessoaEF.Visible = false;
			btnEditarEf.Visible = false;
			btnListarEfCore.Visible = false;
		}
	}

	private void btnEditarEf_Click(object sender, EventArgs e)
	{
		// TODO
	}

	// Limpar Form
	public void LimparForm()
	{
		lstBoxPessoas.Items.Clear();

		txtIdPessoa.Text = "";
		txtNomePessoa.Text = "";

		btnDeletarDapper.Enabled = false;
		btnDeletar.Enabled = false;

		btnEditar.Enabled = false;
		// btnEditarEf.Enabled = false;
	}

	private void chkBoxEFCore_CheckedChanged(object sender, EventArgs e)
	{
		EnableEfCore();
	}
}