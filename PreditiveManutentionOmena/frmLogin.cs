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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String User = "Augusto Omena";
            String Password = "senai";

            if(txtUsuario.Text == User & txtSenha.Text == Password)
            {
                MessageBox.Show("Acesso Liberado!");
                Alert FrMain = new Alert();
                FrMain.Show();
                this.Hide();

            } else
            {
                MessageBox.Show("Usuário/Senha Incorretos! ");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Acesse seu Email Para alterar a senha.");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlogin.Visible = true;
            this.pnlogin.Controls.Clear();
            criaConta frmInicio_Vrb = new criaConta() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmInicio_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlogin.Controls.Add(frmInicio_Vrb);
            frmInicio_Vrb.Show();

            label5.Visible = true;
            btnlogin.Visible = false;
            btnCriaConta.Visible = false;
            esqueceuSenha.Visible = false;
            txtUsuario.Visible = false;
            txtSenha.Visible = false;
            lbusuario.Text = "Nome";
            lblogin.Visible = false;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.pnlogin.Controls.Clear();
            this.pnlogin.Visible = false;

            label5.Visible = false;
            btnlogin.Visible = true;
            btnCriaConta.Visible = true;
            esqueceuSenha.Visible = true;
            txtUsuario.Visible = true;
            txtSenha.Visible = true;
            lbusuario.Text = "Usuário";
            lblogin.Visible = true;
        }
    }
}
