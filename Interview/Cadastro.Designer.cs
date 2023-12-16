namespace Interview
{
    partial class Cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            button1 = new Button();
            input_nome = new TextBox();
            label2 = new Label();
            label3 = new Label();
            input_telefone = new TextBox();
            label4 = new Label();
            input_data = new DateTimePicker();
            label6 = new Label();
            input_tipo = new ComboBox();
            input_inscricaoFisica = new CheckBox();
            label7 = new Label();
            label8 = new Label();
            input_inscricao = new TextBox();
            input_cpf = new TextBox();
            input_genero = new ComboBox();
            label9 = new Label();
            input_nascimento = new DateTimePicker();
            label10 = new Label();
            toolTip1 = new ToolTip(components);
            input_block = new CheckBox();
            label13 = new Label();
            input_senha = new TextBox();
            label14 = new Label();
            input_confirmacaoSenha = new TextBox();
            button2 = new Button();
            groupBox1 = new GroupBox();
            input_inscricaoIsenta = new CheckBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label_senha2 = new Label();
            label_senha = new Label();
            label5 = new Label();
            input_email = new TextBox();
            toolTip2 = new ToolTip(components);
            toolTip3 = new ToolTip(components);
            toolTip4 = new ToolTip(components);
            toolTip5 = new ToolTip(components);
            toolTip6 = new ToolTip(components);
            toolTip7 = new ToolTip(components);
            toolTip8 = new ToolTip(components);
            toolTip9 = new ToolTip(components);
            toolTip10 = new ToolTip(components);
            toolTip11 = new ToolTip(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(181, 25);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de cliente";
            // 
            // button1
            // 
            button1.Location = new Point(465, 9);
            button1.Name = "button1";
            button1.Size = new Size(75, 25);
            button1.TabIndex = 1;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // input_nome
            // 
            input_nome.Location = new Point(12, 66);
            input_nome.MaxLength = 150;
            input_nome.Name = "input_nome";
            input_nome.PlaceholderText = "Nome ou razão social do cliente";
            input_nome.Size = new Size(248, 23);
            input_nome.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 3;
            label2.Text = "Nome / Razão social";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 101);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 5;
            label3.Text = "Telefone";
            // 
            // input_telefone
            // 
            input_telefone.Location = new Point(12, 119);
            input_telefone.MaxLength = 11;
            input_telefone.Name = "input_telefone";
            input_telefone.PlaceholderText = "Telefone do cliente";
            input_telefone.Size = new Size(248, 23);
            input_telefone.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(286, 101);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 7;
            label4.Text = "Data de cadastro";
            // 
            // input_data
            // 
            input_data.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            input_data.Location = new Point(286, 119);
            input_data.Name = "input_data";
            input_data.Size = new Size(248, 23);
            input_data.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 19);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 10;
            label6.Text = "Tipo de pessoa";
            // 
            // input_tipo
            // 
            input_tipo.FormattingEnabled = true;
            input_tipo.Items.AddRange(new object[] { "Física", "Jurídica" });
            input_tipo.Location = new Point(6, 37);
            input_tipo.Name = "input_tipo";
            input_tipo.Size = new Size(248, 23);
            input_tipo.TabIndex = 6;
            input_tipo.SelectedIndexChanged += input_tipo_SelectedIndexChanged_1;
            // 
            // input_inscricaoFisica
            // 
            input_inscricaoFisica.AutoSize = true;
            input_inscricaoFisica.Enabled = false;
            input_inscricaoFisica.Location = new Point(6, 66);
            input_inscricaoFisica.Name = "input_inscricaoFisica";
            input_inscricaoFisica.Size = new Size(222, 19);
            input_inscricaoFisica.TabIndex = 7;
            input_inscricaoFisica.Text = "Inscrição estadual para Pessoa Física?";
            input_inscricaoFisica.UseVisualStyleBackColor = true;
            input_inscricaoFisica.Visible = false;
            input_inscricaoFisica.CheckedChanged += input_inscricaoFisica_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(274, 91);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 14;
            label7.Text = "CPF / CNPJ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 91);
            label8.Name = "label8";
            label8.Size = new Size(101, 15);
            label8.TabIndex = 16;
            label8.Text = "Inscrição estadual";
            // 
            // input_inscricao
            // 
            input_inscricao.Enabled = false;
            input_inscricao.Location = new Point(6, 109);
            input_inscricao.MaxLength = 12;
            input_inscricao.Name = "input_inscricao";
            input_inscricao.PlaceholderText = "Inscrição estadual do cliente";
            input_inscricao.Size = new Size(248, 23);
            input_inscricao.TabIndex = 8;
            // 
            // input_cpf
            // 
            input_cpf.Location = new Point(274, 109);
            input_cpf.MaxLength = 14;
            input_cpf.Name = "input_cpf";
            input_cpf.PlaceholderText = "Nome ou razão social do cliente";
            input_cpf.Size = new Size(248, 23);
            input_cpf.TabIndex = 9;
            input_cpf.TextChanged += input_cpf_TextChanged;
            // 
            // input_genero
            // 
            input_genero.Enabled = false;
            input_genero.FormattingEnabled = true;
            input_genero.Items.AddRange(new object[] { "Feminino", "Masculino", "Outro" });
            input_genero.Location = new Point(6, 161);
            input_genero.Name = "input_genero";
            input_genero.Size = new Size(248, 23);
            input_genero.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 143);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 17;
            label9.Text = "Gênero";
            // 
            // input_nascimento
            // 
            input_nascimento.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            input_nascimento.Enabled = false;
            input_nascimento.Location = new Point(274, 161);
            input_nascimento.Name = "input_nascimento";
            input_nascimento.Size = new Size(248, 23);
            input_nascimento.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(274, 143);
            label10.Name = "label10";
            label10.Size = new Size(112, 15);
            label10.TabIndex = 19;
            label10.Text = "Data de nascimento";
            // 
            // input_block
            // 
            input_block.AutoSize = true;
            input_block.Location = new Point(6, 22);
            input_block.Name = "input_block";
            input_block.Size = new Size(83, 19);
            input_block.TabIndex = 12;
            input_block.Text = "Bloqueado";
            input_block.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 18);
            label13.Name = "label13";
            label13.Size = new Size(39, 15);
            label13.TabIndex = 25;
            label13.Text = "Senha";
            // 
            // input_senha
            // 
            input_senha.Location = new Point(6, 36);
            input_senha.MaxLength = 15;
            input_senha.Name = "input_senha";
            input_senha.Size = new Size(248, 23);
            input_senha.TabIndex = 15;
            input_senha.TextChanged += input_senha_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 69);
            label14.Name = "label14";
            label14.Size = new Size(122, 15);
            label14.TabIndex = 27;
            label14.Text = "Confimação de senha";
            // 
            // input_confirmacaoSenha
            // 
            input_confirmacaoSenha.Location = new Point(6, 87);
            input_confirmacaoSenha.MaxLength = 15;
            input_confirmacaoSenha.Name = "input_confirmacaoSenha";
            input_confirmacaoSenha.Size = new Size(248, 23);
            input_confirmacaoSenha.TabIndex = 16;
            input_confirmacaoSenha.TextChanged += input_confirmacaoSenha_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(188, 552);
            button2.Name = "button2";
            button2.Size = new Size(177, 35);
            button2.TabIndex = 100;
            button2.Text = "Adicionar cliente";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(input_inscricaoIsenta);
            groupBox1.Controls.Add(input_tipo);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(input_inscricaoFisica);
            groupBox1.Controls.Add(input_cpf);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(input_inscricao);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(input_nascimento);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(input_genero);
            groupBox1.Controls.Add(label10);
            groupBox1.Location = new Point(12, 159);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(528, 202);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações pessoais";
            // 
            // input_inscricaoIsenta
            // 
            input_inscricaoIsenta.AutoSize = true;
            input_inscricaoIsenta.Enabled = false;
            input_inscricaoIsenta.Location = new Point(6, 66);
            input_inscricaoIsenta.Name = "input_inscricaoIsenta";
            input_inscricaoIsenta.Size = new Size(159, 19);
            input_inscricaoIsenta.TabIndex = 7;
            input_inscricaoIsenta.Text = "Inscrição estadual Isenta?";
            input_inscricaoIsenta.UseVisualStyleBackColor = true;
            input_inscricaoIsenta.Visible = false;
            input_inscricaoIsenta.CheckedChanged += input_inscricaoIsenta_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(input_block);
            groupBox2.Location = new Point(12, 367);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(528, 54);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            groupBox2.Text = "Situação do cliente";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label_senha2);
            groupBox3.Controls.Add(label_senha);
            groupBox3.Controls.Add(input_senha);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(input_confirmacaoSenha);
            groupBox3.Controls.Add(label14);
            groupBox3.Location = new Point(12, 427);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(528, 119);
            groupBox3.TabIndex = 31;
            groupBox3.TabStop = false;
            groupBox3.Text = "Senha de acesso";
            // 
            // label_senha2
            // 
            label_senha2.AutoSize = true;
            label_senha2.Location = new Point(260, 90);
            label_senha2.Name = "label_senha2";
            label_senha2.Size = new Size(136, 15);
            label_senha2.TabIndex = 29;
            label_senha2.Text = "As senhas não conferem";
            label_senha2.Visible = false;
            // 
            // label_senha
            // 
            label_senha.AutoSize = true;
            label_senha.ForeColor = Color.FromArgb(16, 16, 16);
            label_senha.Location = new Point(260, 39);
            label_senha.Name = "label_senha";
            label_senha.Size = new Size(70, 15);
            label_senha.TabIndex = 28;
            label_senha.Text = "Senha Fraca";
            label_senha.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(286, 48);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 33;
            label5.Text = "Email";
            // 
            // input_email
            // 
            input_email.Location = new Point(286, 66);
            input_email.MaxLength = 150;
            input_email.Name = "input_email";
            input_email.PlaceholderText = "Email do cliente";
            input_email.Size = new Size(248, 23);
            input_email.TabIndex = 3;
            // 
            // toolTip2
            // 
            toolTip2.ToolTipTitle = "Nome completo ou Razão Social do Cliente";
            // 
            // toolTip3
            // 
            toolTip3.ToolTipTitle = " E-mail do Cliente";
            // 
            // toolTip4
            // 
            toolTip4.ToolTipTitle = "Telefone do Cliente.";
            // 
            // toolTip5
            // 
            toolTip5.ToolTipTitle = "Selecione o tipo de Pessoa";
            // 
            // toolTip6
            // 
            toolTip6.ToolTipTitle = ": Insira o CPF ou o CNPJ do Cliente";
            // 
            // toolTip7
            // 
            toolTip7.ToolTipTitle = ": Inscrição Estadual do Cliente, selecionar Isento caso assim for";
            // 
            // toolTip8
            // 
            toolTip8.ToolTipTitle = " Selecione o gênero do Cliente";
            // 
            // toolTip9
            // 
            toolTip9.ToolTipTitle = ": Data de nascimento do Cliente";
            // 
            // toolTip10
            // 
            toolTip10.ToolTipTitle = "Bloqueio o acesso do Cliente na sua Loja;";
            // 
            // toolTip11
            // 
            toolTip11.ToolTipTitle = " Cadastre a senha de acesso do seu Cliente;";
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 594);
            Controls.Add(label5);
            Controls.Add(input_email);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(input_data);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(input_telefone);
            Controls.Add(label2);
            Controls.Add(input_nome);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Cadastro";
            Text = "Cadastro de cliente";
            Load += Cadastro_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox input_nome;
        private Label label2;
        private Label label3;
        private TextBox input_telefone;
        private Label label4;
        private DateTimePicker input_data;
        private Label label6;
        private ComboBox input_tipo;
        private CheckBox input_inscricaoFisica;
        private Label label7;
        private Label label8;
        private TextBox input_inscricao;
        private TextBox input_cpf;
        private ComboBox input_genero;
        private Label label9;
        private DateTimePicker input_nascimento;
        private Label label10;
        private ToolTip toolTip1;
        private CheckBox input_block;
        private Label label13;
        private TextBox input_senha;
        private Label label14;
        private TextBox input_confirmacaoSenha;
        private Button button2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label5;
        private TextBox input_email;
        private CheckBox input_inscricaoIsenta;
        private Label label_senha2;
        private Label label_senha;
        private ToolTip toolTip2;
        private ToolTip toolTip3;
        private ToolTip toolTip4;
        private ToolTip toolTip5;
        private ToolTip toolTip6;
        private ToolTip toolTip7;
        private ToolTip toolTip8;
        private ToolTip toolTip9;
        private ToolTip toolTip10;
        private ToolTip toolTip11;
    }
}