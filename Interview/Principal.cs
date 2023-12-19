using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Interview
{
    public partial class Principal : Form
    {
        private MySqlConnection conexao;
        private int count;
        private int page = 1;
        private ActualFilter globalInfo;

        public Principal()
        {
            InitializeComponent();

            globalInfo = new ActualFilter
            {
                name = null,
                email = null,
                tel = null,
                data = null,
                block = -1
            };
        }

        private void Principal_Load(object sender, EventArgs e)
        {

            string strConexao = "server=localhost;uid=root;pwd=1234;database=interview";
            conexao = new MySqlConnection(strConexao);

            CarregarDados();
        }

        private void CarregarDados()
        {
            try
            {
                conexao.Open();
                string consulta = "SELECT COUNT(*) FROM clientes";

                var comando = new MySqlCommand(consulta, conexao);
                count = (Convert.ToInt32(comando.ExecuteScalar()) / 20) + 1;

                textPagination.Text = page + " de " + count.ToString();

                if (page == count)
                {
                    btn_next.Enabled = false;
                    btn_previous.Enabled = false;
                }

                var adaptador = new MySqlDataAdapter("SELECT id,nome,email,telefone,data_cadastro,bloqueado FROM clientes LIMIT 0,20 ", conexao);
                var dataTable = new DataTable();
                adaptador.Fill(dataTable);

                if (dataGrid.Columns.Contains("Selecionar"))
                {
                    dataGrid.Columns.Remove("Selecionar");
                }

                //Adicionando checkbox na primeira coluna
                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                checkBoxColumn.HeaderText = "Selecionar";
                checkBoxColumn.Name = "Selecionar";
                checkBoxColumn.ReadOnly = false;
                dataGrid.Columns.Insert(0, checkBoxColumn);


                if (dataGrid.Columns.Contains("Ação"))
                {
                    dataGrid.Columns.Remove("Ação");
                }
                
                //Adicionando botão de edição na ultima coluna
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.Name = "Ação";
                buttonColumn.Text = "Editar";
                buttonColumn.UseColumnTextForButtonValue = true;

               

                dataGrid.DataSource = dataTable;
                dataGrid.Columns.Add(buttonColumn);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }


        private void btn_next_Click(object sender, EventArgs e)
        {
            if (page < count)
            {
                page++;
                textPagination.Text = page + " de " + count.ToString();
                setDataView();
            }

            if (page == count)
            {
                btn_next.Enabled = false;
            }
            else
            {
                btn_next.Enabled = true;
            }

            if (page != 1 && count > 1)
            {
                btn_previous.Enabled = true;
            }
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            if (page > 1)
            {
                page--;
                textPagination.Text = page + " de " + count.ToString();
                setDataView();
            }

            if (page == 1)
            {
                btn_previous.Enabled = false;
            }
            else
            {
                btn_previous.Enabled = true;
            }

            if (page != count && count > 1)
            {
                btn_next.Enabled = true;
            }
        }

        private string moutWhere()
        {
            string where = "";

            if (globalInfo.name != null)
            {
                where = where + $"nome LIKE '%{globalInfo.name}%'";
            }

            if (globalInfo.email != null)
            {
                if (where != "")
                {
                    where = where + " AND ";
                }
                where = where + $" email LIKE '%{globalInfo.email}%' ";
            }

            if (globalInfo.tel != null)
            {
                if (where != "")
                {
                    where = where + " AND ";
                }
                where = where + $" telefone LIKE '%{globalInfo.tel}%' ";
            }

            if (globalInfo.data != null)
            {
                if (where != "")
                {
                    where = where + " AND ";
                }
                where = where + $" data_cadastro LIKE '%{globalInfo.data}%' ";
            }

            if (globalInfo.block != -1)
            {
                if (where != "")
                {
                    where = where + " AND ";
                }
                where = where + $" bloqueado LIKE '%{globalInfo.block}%' ";
            }
            return where;
        }

        private void btn_cleanFilter_Click(object sender, EventArgs e)
        {
            globalInfo.name = null;
            globalInfo.email = null;
            globalInfo.tel = null;
            globalInfo.data = null;
            globalInfo.block = -1;
            setDataView();
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            Filtro filter = new Filtro();
            filter.information = globalInfo;

            DialogResult result = filter.ShowDialog();

            if (result == DialogResult.OK)
            {
                globalInfo = filter.modInformation;
                page = 1;
                setDataView();
            }
            else
            {
                MessageBox.Show("Nenhum filtro foi aplicado!");
            }
        }

        private void setDataView()
        {
            string where = moutWhere();

            string command = $"SELECT id,nome,email,telefone,data_cadastro,bloqueado FROM clientes";

            if (where != "")
            {
                command = command + " WHERE " + where;
            }

            command = command + $" LIMIT {(page * 20) - 20},20 ";

            var adaptador = new MySqlDataAdapter(command, conexao);
            var dataTable = new DataTable();
            adaptador.Fill(dataTable);

            dataGrid.DataSource = dataTable;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Cliente pessoa = new Cliente();
            Cadastro cliente = new Cadastro(conexao, pessoa, "INSERT");

            DialogResult result = cliente.ShowDialog();
            if (result == DialogResult.OK)
            {
                CarregarDados();
            }
        }

        private void Botao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Botão Clicado!");
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGrid.Columns["Ação"].Index && e.RowIndex >= 0)
            {
                string id = dataGrid.Rows[e.RowIndex].Cells["id"].Value.ToString();

                string command = $"SELECT * FROM clientes WHERE id = {id}";

                var adaptador = new MySqlDataAdapter(command, conexao);
                var dataTable = new DataTable();
                adaptador.Fill(dataTable);


                Cliente pessoa = new Cliente();

                pessoa.nome = dataTable.Rows[0]["nome"].ToString();
                pessoa.email = dataTable.Rows[0]["email"].ToString();
                pessoa.telefone = dataTable.Rows[0]["telefone"].ToString();
                pessoa.data_cadastro = dataTable.Rows[0]["data_cadastro"].ToString();
                pessoa.pessoa = dataTable.Rows[0]["pessoa"].ToString();
                pessoa.cpf = pessoa.pessoa == "Física" ? dataTable.Rows[0]["cpf"].ToString() : dataTable.Rows[0]["cnpj"].ToString();
                pessoa.inscricao_estadual = dataTable.Rows[0]["inscricao_estadual"].ToString();
                pessoa.genero = dataTable.Rows[0]["genero"].ToString(); 
                pessoa.nascimento = dataTable.Rows[0]["nascimento"].ToString(); 
                pessoa.bloqueado = dataTable.Rows[0]["bloqueado"].ToString();
                pessoa.senha = dataTable.Rows[0]["senha"].ToString();
                pessoa.inscricao_estadual_isento = dataTable.Rows[0]["inscricao_estadual_isento"].ToString(); ;

                Cadastro cliente = new Cadastro(conexao, pessoa, "UPDATE");

                DialogResult result = cliente.ShowDialog();
                if (result == DialogResult.OK)
                {
                    CarregarDados();
                }

            }
        }
    }
}
