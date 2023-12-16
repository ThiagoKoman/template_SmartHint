namespace Interview
{
    public partial class Filtro : Form
    {
        private ActualFilter filter;
        public ActualFilter information { get; set; }
        public ActualFilter modInformation { get; private set; }


        public Filtro()
        {
            InitializeComponent();
        }

        private void Filtro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (filter_name.Text != "")
            {
                filter.name = filter_name.Text;
            }

            if (filter_email.Text != "")
            {
                filter.email = filter_email.Text;
            }

            if (filter_tel.Text != "")
            {
                filter.tel = filter_tel.Text;
            }

            if (filter_data.Value.Equals(""))
            {
                string formattedDateTime = filter_data.Value.ToString("yyyy-MM-dd HH:mm:ss");
                filter.data = formattedDateTime;
            }

            if (filter_block.Text == "Sim")
            {
                filter.block = 1;
            }
            else if (filter_block.Text == "Não")
            {
                filter.block = 0;
            }
            else
            {
                filter.block = -1;
            }

            modInformation = filter;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
