namespace WinFormsCRUD
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			lstBoxPessoas = new ListBox();
			btnListarDapper = new Button();
			btnListarEfCore = new Button();
			txtNomePessoa = new TextBox();
			txtIdPessoa = new TextBox();
			btnCadastrar = new Button();
			label1 = new Label();
			label2 = new Label();
			btnPesquisarPessoa = new Button();
			btnPesquisarPessoaEF = new Button();
			btnDeletar = new Button();
			btnDeletarDapper = new Button();
			btnEditarEf = new Button();
			btnEditar = new Button();
			chkBoxEFCore = new CheckBox();
			SuspendLayout();
			// 
			// lstBoxPessoas
			// 
			lstBoxPessoas.BackColor = Color.FromArgb(46, 46, 46);
			lstBoxPessoas.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
			lstBoxPessoas.ForeColor = Color.White;
			lstBoxPessoas.FormattingEnabled = true;
			lstBoxPessoas.ItemHeight = 37;
			lstBoxPessoas.Location = new Point(12, 190);
			lstBoxPessoas.Name = "lstBoxPessoas";
			lstBoxPessoas.Size = new Size(616, 263);
			lstBoxPessoas.TabIndex = 2;
			// 
			// btnListarDapper
			// 
			btnListarDapper.BackColor = Color.FromArgb(30, 94, 255);
			btnListarDapper.Cursor = Cursors.Hand;
			btnListarDapper.FlatStyle = FlatStyle.Flat;
			btnListarDapper.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			btnListarDapper.ForeColor = SystemColors.ButtonFace;
			btnListarDapper.Location = new Point(509, 460);
			btnListarDapper.Name = "btnListarDapper";
			btnListarDapper.Size = new Size(119, 35);
			btnListarDapper.TabIndex = 1;
			btnListarDapper.TabStop = false;
			btnListarDapper.Text = "Listar Dapper";
			btnListarDapper.UseVisualStyleBackColor = false;
			btnListarDapper.Click += btnListarDapper_Click;
			// 
			// btnListarEfCore
			// 
			btnListarEfCore.BackColor = Color.FromArgb(30, 94, 255);
			btnListarEfCore.Cursor = Cursors.Hand;
			btnListarEfCore.FlatStyle = FlatStyle.Flat;
			btnListarEfCore.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			btnListarEfCore.ForeColor = SystemColors.ButtonFace;
			btnListarEfCore.Location = new Point(382, 460);
			btnListarEfCore.Name = "btnListarEfCore";
			btnListarEfCore.Size = new Size(121, 35);
			btnListarEfCore.TabIndex = 2;
			btnListarEfCore.TabStop = false;
			btnListarEfCore.Text = "Listar EF Core";
			btnListarEfCore.UseVisualStyleBackColor = false;
			btnListarEfCore.Click += btnListarEfCore_Click;
			// 
			// txtNomePessoa
			// 
			txtNomePessoa.BackColor = Color.LightGray;
			txtNomePessoa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtNomePessoa.ForeColor = Color.Black;
			txtNomePessoa.Location = new Point(12, 102);
			txtNomePessoa.Name = "txtNomePessoa";
			txtNomePessoa.Size = new Size(308, 34);
			txtNomePessoa.TabIndex = 1;
			// 
			// txtIdPessoa
			// 
			txtIdPessoa.BackColor = Color.LightGray;
			txtIdPessoa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtIdPessoa.ForeColor = Color.Black;
			txtIdPessoa.Location = new Point(12, 35);
			txtIdPessoa.Name = "txtIdPessoa";
			txtIdPessoa.Size = new Size(126, 34);
			txtIdPessoa.TabIndex = 0;
			txtIdPessoa.KeyPress += txtIdPessoa_KeyPress;
			// 
			// btnCadastrar
			// 
			btnCadastrar.BackColor = Color.FromArgb(30, 94, 255);
			btnCadastrar.Cursor = Cursors.Hand;
			btnCadastrar.FlatStyle = FlatStyle.Flat;
			btnCadastrar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			btnCadastrar.ForeColor = SystemColors.ButtonFace;
			btnCadastrar.Location = new Point(326, 103);
			btnCadastrar.Name = "btnCadastrar";
			btnCadastrar.Size = new Size(119, 35);
			btnCadastrar.TabIndex = 5;
			btnCadastrar.TabStop = false;
			btnCadastrar.Text = "Cadastrar";
			btnCadastrar.UseVisualStyleBackColor = false;
			btnCadastrar.Click += btnCadastrar_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = SystemColors.Info;
			label1.Location = new Point(12, 4);
			label1.Name = "label1";
			label1.Size = new Size(29, 28);
			label1.TabIndex = 6;
			label1.Text = "Id";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label2.ForeColor = SystemColors.Info;
			label2.Location = new Point(12, 71);
			label2.Name = "label2";
			label2.Size = new Size(66, 28);
			label2.TabIndex = 7;
			label2.Text = "Nome";
			// 
			// btnPesquisarPessoa
			// 
			btnPesquisarPessoa.BackColor = Color.FromArgb(30, 94, 255);
			btnPesquisarPessoa.Cursor = Cursors.Hand;
			btnPesquisarPessoa.FlatStyle = FlatStyle.Flat;
			btnPesquisarPessoa.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			btnPesquisarPessoa.ForeColor = SystemColors.ButtonFace;
			btnPesquisarPessoa.Location = new Point(144, 34);
			btnPesquisarPessoa.Name = "btnPesquisarPessoa";
			btnPesquisarPessoa.Size = new Size(119, 35);
			btnPesquisarPessoa.TabIndex = 8;
			btnPesquisarPessoa.TabStop = false;
			btnPesquisarPessoa.Text = "Pesquisar!";
			btnPesquisarPessoa.UseVisualStyleBackColor = false;
			btnPesquisarPessoa.Click += btnPesquisarPessoa_Click;
			// 
			// btnPesquisarPessoaEF
			// 
			btnPesquisarPessoaEF.BackColor = Color.FromArgb(30, 94, 255);
			btnPesquisarPessoaEF.Cursor = Cursors.Hand;
			btnPesquisarPessoaEF.FlatStyle = FlatStyle.Flat;
			btnPesquisarPessoaEF.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			btnPesquisarPessoaEF.ForeColor = SystemColors.ButtonFace;
			btnPesquisarPessoaEF.Location = new Point(269, 34);
			btnPesquisarPessoaEF.Name = "btnPesquisarPessoaEF";
			btnPesquisarPessoaEF.Size = new Size(119, 35);
			btnPesquisarPessoaEF.TabIndex = 9;
			btnPesquisarPessoaEF.TabStop = false;
			btnPesquisarPessoaEF.Text = "Pesquisar EF";
			btnPesquisarPessoaEF.UseVisualStyleBackColor = false;
			btnPesquisarPessoaEF.Visible = false;
			btnPesquisarPessoaEF.Click += btnPesquisarPessoaEF_Click;
			// 
			// btnDeletar
			// 
			btnDeletar.BackColor = Color.FromArgb(30, 94, 255);
			btnDeletar.Cursor = Cursors.Hand;
			btnDeletar.FlatStyle = FlatStyle.Flat;
			btnDeletar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			btnDeletar.ForeColor = SystemColors.ButtonFace;
			btnDeletar.Location = new Point(137, 460);
			btnDeletar.Name = "btnDeletar";
			btnDeletar.Size = new Size(119, 35);
			btnDeletar.TabIndex = 11;
			btnDeletar.TabStop = false;
			btnDeletar.Text = "Remover EF";
			btnDeletar.UseVisualStyleBackColor = false;
			btnDeletar.Click += btnDeletar_Click;
			// 
			// btnDeletarDapper
			// 
			btnDeletarDapper.BackColor = Color.FromArgb(30, 94, 255);
			btnDeletarDapper.Cursor = Cursors.Hand;
			btnDeletarDapper.Enabled = false;
			btnDeletarDapper.FlatStyle = FlatStyle.Flat;
			btnDeletarDapper.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			btnDeletarDapper.ForeColor = SystemColors.ButtonFace;
			btnDeletarDapper.Location = new Point(12, 460);
			btnDeletarDapper.Name = "btnDeletarDapper";
			btnDeletarDapper.Size = new Size(119, 35);
			btnDeletarDapper.TabIndex = 10;
			btnDeletarDapper.TabStop = false;
			btnDeletarDapper.Text = "Remover";
			btnDeletarDapper.UseVisualStyleBackColor = false;
			btnDeletarDapper.Click += btnDeletarDapper_Click;
			// 
			// btnEditarEf
			// 
			btnEditarEf.BackColor = Color.FromArgb(30, 94, 255);
			btnEditarEf.Cursor = Cursors.Hand;
			btnEditarEf.FlatStyle = FlatStyle.Flat;
			btnEditarEf.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			btnEditarEf.ForeColor = SystemColors.ButtonFace;
			btnEditarEf.Location = new Point(137, 142);
			btnEditarEf.Name = "btnEditarEf";
			btnEditarEf.Size = new Size(121, 35);
			btnEditarEf.TabIndex = 13;
			btnEditarEf.TabStop = false;
			btnEditarEf.Text = "Editar EF";
			btnEditarEf.UseVisualStyleBackColor = false;
			btnEditarEf.Visible = false;
			btnEditarEf.Click += btnEditarEf_Click;
			// 
			// btnEditar
			// 
			btnEditar.BackColor = Color.FromArgb(30, 94, 255);
			btnEditar.Cursor = Cursors.Hand;
			btnEditar.FlatStyle = FlatStyle.Flat;
			btnEditar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			btnEditar.ForeColor = SystemColors.ButtonFace;
			btnEditar.Location = new Point(12, 142);
			btnEditar.Name = "btnEditar";
			btnEditar.Size = new Size(119, 35);
			btnEditar.TabIndex = 12;
			btnEditar.TabStop = false;
			btnEditar.Text = "Editar";
			btnEditar.UseVisualStyleBackColor = false;
			btnEditar.Click += btnEditar_Click;
			// 
			// chkBoxEFCore
			// 
			chkBoxEFCore.AutoSize = true;
			chkBoxEFCore.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			chkBoxEFCore.ForeColor = SystemColors.ControlLightLight;
			chkBoxEFCore.Location = new Point(438, 12);
			chkBoxEFCore.Name = "chkBoxEFCore";
			chkBoxEFCore.Size = new Size(190, 54);
			chkBoxEFCore.TabIndex = 14;
			chkBoxEFCore.Text = "Habilitar Operações\r\ncom EF Core ";
			chkBoxEFCore.UseVisualStyleBackColor = true;
			chkBoxEFCore.CheckedChanged += chkBoxEFCore_CheckedChanged;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(9F, 23F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(13, 37, 75);
			ClientSize = new Size(640, 501);
			Controls.Add(chkBoxEFCore);
			Controls.Add(btnEditarEf);
			Controls.Add(btnEditar);
			Controls.Add(btnDeletar);
			Controls.Add(btnDeletarDapper);
			Controls.Add(btnPesquisarPessoaEF);
			Controls.Add(btnPesquisarPessoa);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(btnCadastrar);
			Controls.Add(txtIdPessoa);
			Controls.Add(txtNomePessoa);
			Controls.Add(btnListarEfCore);
			Controls.Add(btnListarDapper);
			Controls.Add(lstBoxPessoas);
			Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "Form1";
			Text = "Pessoas";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ListBox lstBoxPessoas;
		private Button btnListarDapper;
		private Button btnListarEfCore;
		private TextBox txtNomePessoa;
		private TextBox txtIdPessoa;
		private Button btnCadastrar;
		private Label label1;
		private Label label2;
		private Button btnPesquisarPessoa;
		private Button btnPesquisarPessoaEF;
		private Button btnDeletar;
		private Button btnDeletarDapper;
		private Button btnEditarEf;
		private Button btnEditar;
		private CheckBox chkBoxEFCore;
	}
}