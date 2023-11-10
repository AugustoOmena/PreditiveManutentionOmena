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

        public Analise(string momentoTempr, string vibracao, int vibraCalc, int temperaturaCalc, string vib, string tem)
        {
            InitializeComponent();
            tbDataHora.Text = momentoTempr;
            tbVibra.Text = vibracao;
            if (temperaturaCalc == 0 && vibraCalc == 0)
            {
                tbTemp.Text = "O motor está em bom estado de funcionamento.";
            } else if (temperaturaCalc >= 1 && vibraCalc >= 1)
            {
                tbTemp.Text ="Em " + vib + " o Motor atingiu alta na temperatura; além disso em " + tem + " apresentou vibração acima do ideal. > Precisa de manutenção URGENTE. - Omena Preditive";
            } else
            {
                if (vibraCalc > 0)
                {
                    tbTemp.Text = vib + " Motor está com Alta na vibração, Pode estar relacionado a falha na fixaçao do motor. - Omena Preditive";
                    tbTemp.Text += "\n";
                }
                if (temperaturaCalc > 0)
                {
                    tbTemp.Text = tem + " Motor está com Alta na temperatura, Precisa ser resfriado agora. - Omena Preditive";
                    tbTemp.Text += "\n";
                }

            }
        }

        private void Analise_Load(object sender, EventArgs e)
        {

        CarregaDados.Start();

        }

        private void motoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public string recebeRelato { get; set; }


        public int umdois = 0;
        public double kwh = 0;
        public double CUS = 0;
        private void CarregaDados_Tick(object sender, EventArgs e)
        {
                umdois++;
                seg.Value = umdois;
                seg.Text = umdois.ToString();
                
                if (umdois == 60)
                {
                umdois = 0;
                    if (tbContatos.Text != "")
                    {
                    List<string> listString = new List<string>();
                    var palavras = tbContatos.Text.Split('\n');
                        for (short i = 0; i < palavras.Length; i++)
                        {
                        listString.Add(palavras[i]);
                        }

                    EnviaMensagemWhatsApp zap = new EnviaMensagemWhatsApp();
                    zap.SendMessage(tbTemp.Text, listString);
                    CUS = (3000 * 0.017) / 1000;
                    consumo.Text = (kwh + 0.5).ToString() + " kWh / R$ " + CUS ;
                    consumoFuturo.Text = "1008 kWh / R$ 907,2";
                    tbContatos.Text = "";
                    }
                }
        }

        private void tbConsumo_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
