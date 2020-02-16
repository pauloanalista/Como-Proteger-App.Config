using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Ilovecode.ProtegerAppConfig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCriptografar_Click(object sender, EventArgs e)
        {
            Helpers.Criptografar();
        }

        private void BtnDescriptografar_Click(object sender, EventArgs e)
        {
            Helpers.Decriptografar();
        }

        private void BtnObterConexao_Click(object sender, EventArgs e)
        {
          lblResultado.Text =   Helpers.GetConnectionString();
        }
    }
}
