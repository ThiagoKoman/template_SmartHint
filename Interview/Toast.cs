using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interview
{
    public partial class Toast : Form
    {

        public string Mensagem
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public Toast()
        {
            InitializeComponent();
        }

        private void Toast_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
