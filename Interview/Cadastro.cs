using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Interview
{
    public partial class Cadastro : Form
    {

        private Cliente cliente;
        private MySqlConnection conexao;
        private string metodo;

        public Cadastro(MySqlConnection conection, Cliente client, string metod)
        {
            conexao = conection;
            cliente = client;
            metodo = metod;
            InitializeComponent();

            input_cpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            input_telefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            if(metodo == "UPDATE")
            {
                input_nome.Text = cliente.nome;
                input_email.Text = cliente.email;
                input_telefone.Text = cliente.telefone;
                if(DateTime.TryParse(cliente.data_cadastro, out DateTime dataConvertida))
                {
                    input_data.Value = dataConvertida;
                }
                input_tipo.Text = cliente.pessoa ;
                input_cpf.Text = cliente.cpf;
                input_inscricao.Text = cliente.inscricao_estadual;
                input_genero.Text = cliente.genero;
                if (DateTime.TryParse(cliente.nascimento, out DateTime dataConvertida2))
                {
                    input_nascimento.Value = dataConvertida2;
                }
                input_block.Checked = int.Parse(cliente.bloqueado) == 1;
                input_senha.Text = cliente.senha;
                input_confirmacaoSenha.Text = cliente.senha;
                input_inscricaoIsenta.Checked = int.Parse(cliente.inscricao_estadual_isento) == 1;
                button2.Text = "Atualizar cliente";

                input_cpf.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string tipo = input_tipo.Text;
            string tipo_value;

            if (tipo == "Física")
            {
                tipo_value = "cpf";
            }
            else
            {
                tipo_value = "cnpj";
            }

            if (metodo == "INSERT" && isValid())
            {
                string command = $"INSERT INTO `clientes` (`nome`, `email`, `telefone`, `data_cadastro`, `pessoa`, `{tipo_value}`, `genero`, `nascimento`, `bloqueado`, `senha`, `inscricao_estadual_isento`, `inscricao_estadual`) VALUES ('{input_nome.Text}', '{input_email.Text}', '{input_telefone.Text}', '{input_data.Value.ToString("yyyy/MM/dd HH:mm:ss")}', '{input_tipo.Text}', '{input_cpf.Text}', '{input_genero.Text}', '{input_nascimento.Value.ToString("yyyy/MM/dd HH:mm:ss")}', '{Convert.ToInt32(input_block.Checked)}', '{input_senha.Text}', '{Convert.ToInt32(input_inscricaoIsenta.Checked)}', '{input_inscricao.Text}');";

                try
                {
                    var adaptador = new MySqlDataAdapter(command, conexao);
                    var dataTable = new DataTable();
                    adaptador.Fill(dataTable);

                    MessageBox.Show($"Usuário inserido com sucesso!");

                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message);
                }
            }
            else if(metodo == "UPDATE")
            {
                string command = $"UPDATE `clientes` SET " +
                    $"`nome` = '{input_nome.Text}', " +
                    $"`email` = '{input_email.Text}', " +
                    $"`telefone` = '{input_telefone.Text}', " +
                    $"`data_cadastro` = '{input_data.Value.ToString("yyyy/MM/dd HH:mm:ss")}'," +
                    $"`pessoa` = '{input_tipo.Text}', " +
                    $"`{tipo_value}` = '{input_cpf.Text}', " +
                    $"`genero` = '{input_genero.Text}', " +
                    $"`nascimento` = '{input_nascimento.Value.ToString("yyyy/MM/dd HH:mm:ss")}', " +
                    $"`bloqueado` = '{Convert.ToInt32(input_block.Checked)}', " +
                    $"`senha` = '{input_senha.Text}', " +
                    $"`inscricao_estadual_isento` = '{Convert.ToInt32(input_inscricaoIsenta.Checked)}' ";

                if(input_inscricao.Text != "")
                {
                    command = command + $", `inscricao_estadual` = '{input_inscricao.Text}' ";
                }

                command = command + $" WHERE (`{tipo_value}` = '{input_cpf.Text}');";
                try
                {
                    var adaptador = new MySqlDataAdapter(command, conexao);
                    var dataTable = new DataTable();
                    adaptador.Fill(dataTable);

                    MessageBox.Show($"Usuário atualizado com sucesso!");

                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message);
                }
            }

        }

        private void input_tipo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            input_cpf.Enabled = true;

            if (input_tipo.Text == "Física")
            {
                input_genero.Enabled = true;
                input_nascimento.Enabled = true;
                input_inscricao.Enabled = false;
                input_inscricao.Text = "";
                input_inscricaoFisica.Enabled = true;
                input_inscricaoFisica.Visible = true;
                input_inscricaoIsenta.Enabled = false;
                input_inscricaoIsenta.Visible = false;
                input_inscricaoIsenta.Checked = false;
                input_cpf.Mask = "999.999.999-99";
                input_cpf.MaxLength = 14;

            }
            else
            {
                input_genero.Enabled = false;
                input_nascimento.Enabled = false;
                input_inscricao.Enabled = true;
                input_inscricaoFisica.Enabled = false;
                input_inscricaoFisica.Visible = false;
                input_inscricaoFisica.Checked = false;
                input_inscricaoIsenta.Enabled = true;
                input_inscricaoIsenta.Visible = true;
                input_cpf.Mask = "99.999.999/9999-99";
                input_cpf.MaxLength = 18;
            }
        }

        private void input_inscricaoFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (input_inscricaoFisica.Checked)
            {
                input_inscricao.Enabled = true;
            }
            else
            {
                input_inscricao.Enabled = false;
                input_inscricao.Text = "";
            }
        }

        private void input_inscricaoIsenta_CheckedChanged(object sender, EventArgs e)
        {
            if (input_inscricaoIsenta.Checked)
            {
                input_inscricao.Enabled = false;
            }
            else
            {
                input_inscricao.Enabled = true;
            }
        }

        private void input_cpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void input_senha_TextChanged(object sender, EventArgs e)
        {
            if (input_senha.Text == "")
            {
                label_senha.Visible = false;
            }
            else
            {
                label_senha.Visible = true;
                if (input_senha.Text.Length < 8)
                {
                    label_senha.ForeColor = ColorTranslator.FromHtml("#000000");
                    label_senha.Text = "Senha precisa de no minimo 8 caracteres";
                }
                else
                {
                    //Verificar caracteres especiais ou numeros
                    int count = 0;
                    bool temSpc = false;
                    char[] especiais = { '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '+', '-', '=', '{', '}', '[', ']', '|', '\\', ':', ';', '<', '>', ',', '.', '?', '/' };
                    bool temNum = false;
                    char[] nums = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

                    // Verifica se o texto contém algum dos caracteres especiais
                    foreach (char c in input_senha.Text)
                    {
                        if (especiais.Contains(c))
                        {
                            temSpc = true;
                        }
                        if (nums.Contains(c))
                        {
                            temNum = true;
                        }
                    }

                    if (temSpc)
                    {
                        count++;
                    }
                    if (temNum)
                    {
                        count++;
                    }
                    if ((input_senha.Text.ToUpper() != input_senha.Text && input_senha.Text.ToLower() != input_senha.Text))
                    {
                        count++;
                    }

                    string[] status = new string[] { "Fraca", "Média", "Forte", "Muito forte" };
                    string[] color = new string[] { "#bf0000", "#bfb500", "#82b500", "#00b527" };

                    label_senha.Text = status[count];
                    label_senha.ForeColor = ColorTranslator.FromHtml(color[count]);

                }
            }
        }

        private void input_confirmacaoSenha_TextChanged(object sender, EventArgs e)
        {
            if (input_confirmacaoSenha.Text != "" && input_confirmacaoSenha.Text != input_senha.Text)
            {
                label_senha2.Visible = true;
            }
            else
            {
                label_senha2.Visible = false;
            }
        }

        private bool isValid()
        {
            
            if(input_nome.Text == "")
            {
                MessageBox.Show("O campo \"Nome / Razão Social\" é obrigatório");
                return false;
            }
            if (input_email.Text == "")
            {
                MessageBox.Show("O campo \"Email\" é obrigatório");
                return false;
            }
            if (input_telefone.Text == "")
            {
                MessageBox.Show("O campo \"Telefone\" é obrigatório");
                return false;
            }
            if (input_tipo.Text == "")
            {
                MessageBox.Show("O campo \"Tipo de pessoa\" é obrigatório");
                return false;
            }
            if (input_cpf.Text == "")
            {
                MessageBox.Show("O campo \"CPF / CNPJ\" é obrigatório");
                return false;
            }
            if (input_senha.Text == "")
            {
                MessageBox.Show("O campo \"Senha\" é obrigatório");
                return false;
            }
            if (input_confirmacaoSenha.Text == "")
            {
                MessageBox.Show("O campo \"Confirmação de senha\" é obrigatório");
                return false;
            }
            if(input_inscricao.Enabled && input_inscricao.Text == "")
            {
                MessageBox.Show("O campo \"Inscrição estadual\" é obrigatório");
                return false;
            }

            try
            {
                string command = $"SELECT id FROM clientes WHERE email = '{input_email.Text}'";

                var adaptador = new MySqlDataAdapter(command, conexao);
                var dataTable = new DataTable();
                adaptador.Fill(dataTable);

                if(dataTable.Rows.Count > 0)
                {
                    MostrarToast("Este e-mail já está cadastrado para outro Cliente");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
                return false;
            }

            try
            {

                string command = "";
                if (input_tipo.Text == "Física")
                {
                    command = $"SELECT id FROM clientes WHERE CPF = {input_cpf.Text}";
                }
                else { 
                    command = $"SELECT id FROM clientes WHERE CNPJ = {input_cpf.Text}";
                }

                var adaptador = new MySqlDataAdapter(command, conexao);
                var dataTable = new DataTable();
                adaptador.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    MostrarToast("Este CPF/CNPJ já está cadastrado para outro Cliente");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
                return false;
            }

            if (input_inscricao.Enabled)
            {
                try
                {
                    string command = $"SELECT id FROM clientes WHERE inscricao_estadual = '{input_inscricao.Text}'";

                    var adaptador = new MySqlDataAdapter(command, conexao);
                    var dataTable = new DataTable();
                    adaptador.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        MostrarToast("Esta Inscrição Estadual já está cadastrada para outro Cliente");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message);
                    return false;
                }
            }

            return true;
        }

        private void MostrarToast(string mensagem)
        {
            var notificationForm = new Toast();
            notificationForm.Mensagem = mensagem;
            notificationForm.Show();

            var timer = new System.Windows.Forms.Timer();
            timer.Interval = 3000; 
            timer.Tick += (s, args) =>
            {
                notificationForm.Close();
                timer.Stop();
                timer.Dispose();
            };
            timer.Start();
            
        }
    }
}
