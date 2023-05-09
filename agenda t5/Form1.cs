using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agenda_t5
{
    public partial class txtSobrenome : Form
    {
        public txtSobrenome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddContato_Click(object sender, EventArgs e) 
        {
            Contato objetoContato = new Contato();
            lstContatos.Items.Add(objetoContato.ToString());

        }
    }
}
