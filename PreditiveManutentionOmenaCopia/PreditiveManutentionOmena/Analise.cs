using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreditiveManutentionOmena
{
    public partial class Analise : Form
    {
        public Analise()
        {
            InitializeComponent();
        }
        public Analise(string momentoTempr, string vibracao)
        {
            InitializeComponent();
            tbDataHora.Text = momentoTempr;
            tbVibra.Text = vibracao;

        }

        private void Analise_Load(object sender, EventArgs e)
        {

        }

        private void motoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public string recebeRelato { get; set; }



        private void CarregaDados_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
