using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO.Ports;//
using System.IO;//
using System.Threading;
using System.Reflection.Emit;
using System.Linq.Expressions;


namespace PreditiveManutentionOmena
{
    public partial class Alert : Form
    {
        public int T = 0;
        public int V = 0;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nwidthEllipse,
        int nHeightEllipse

        );
        
        public Alert()
        {
            InitializeComponent();
            serialPort1.PortName = "COM9";
            serialPort1.BaudRate = 9600;

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnInicio.Height;
            pnlNav.Top = btnInicio.Top;
            pnlNav.Left = btnInicio.Left;
            btnInicio.BackColor = Color.FromArgb(46, 51, 73);

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnInicio.Height;
            pnlNav.Top = btnInicio.Top;
            pnlNav.Left = btnInicio.Left;
            btnInicio.BackColor = Color.FromArgb(46, 51, 73);
            lbTela.Text = ("Início");

            this.panel6.Controls.Clear();
            this.panel6.Visible = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSair.Height;
            pnlNav.Top = btnSair.Top;
            pnlNav.Left = btnSair.Left;
            btnSair.BackColor = Color.FromArgb(46, 51, 73);
            Close();
            Application.Exit();
        }

        private void pnlNav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAnalise_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAnalise.Height;
            pnlNav.Top = btnAnalise.Top;
            pnlNav.Left = btnAnalise.Left;
            btnAnalise.BackColor = Color.FromArgb(46, 51, 73);
            lbTela.Text = ("Análise");

            panel6.Visible = true;
            this.panel6.Controls.Clear();
            Analise frmInicio_Vrb = new Analise(tbAlertas.Text, tbTempr.Text, V, T, tempoVibra, tempoTemperatura) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmInicio_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panel6.Controls.Add(frmInicio_Vrb);
            frmInicio_Vrb.Show();
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCalendario.Height;
            pnlNav.Top = btnCalendario.Top;
            pnlNav.Left = btnCalendario.Left;
            btnCalendario.BackColor = Color.FromArgb(46, 51, 73);
            lbTela.Text = ("Calendário");

            panel6.Visible = true;
            this.panel6.Controls.Clear();
            Calendario frmInicio_Vrb = new Calendario() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmInicio_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panel6.Controls.Add(frmInicio_Vrb);
            frmInicio_Vrb.Show();
        }

        private void btnAtendimento_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAtendimento.Height;
            pnlNav.Top = btnAtendimento.Top;
            pnlNav.Left = btnAtendimento.Left;
            btnAtendimento.BackColor = Color.FromArgb(46, 51, 73);
            lbTela.Text = ("Atendimento");

            panel6.Visible = true;
            this.panel6.Controls.Clear();
            Atendimento frmInicio_Vrb = new Atendimento() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmInicio_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panel6.Controls.Add(frmInicio_Vrb);
            frmInicio_Vrb.Show();
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnConfiguracoes.Height;
            pnlNav.Top = btnConfiguracoes.Top;
            pnlNav.Left = btnConfiguracoes.Left;
            btnConfiguracoes.BackColor = Color.FromArgb(46, 51, 73);
            lbTela.Text = ("Configurações");

            panel6.Visible = true;
            this.panel6.Controls.Clear();
            Configuracoes frmInicio_Vrb = new Configuracoes() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmInicio_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panel6.Controls.Add(frmInicio_Vrb);
            frmInicio_Vrb.Show();
        }

        private void btnInicio_Leave(object sender, EventArgs e)
        {
            btnInicio.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAnalise_Leave(object sender, EventArgs e)
        {
            btnAnalise.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCalendario_Leave(object sender, EventArgs e)
        {
            btnCalendario.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAtendimento_Leave(object sender, EventArgs e)
        {
            btnAtendimento.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSair_Leave(object sender, EventArgs e)
        {
            btnSair.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnConfiguracoes_Leave(object sender, EventArgs e)
        {
            btnConfiguracoes.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnLigaLed_Click(object sender, EventArgs e)
        {

        }

        private void btnDesligaLed_Click(object sender, EventArgs e)
        {

        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
        }
        public int vibracao { get; set; }
        public double temperatura { get; set; } = 28;
        public int enviaInformacoes { get; set; }

        public int TemperaturaFixa { get; private set; } = 28;
        private void button1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                RecebeVerificaDadosDoMonitor.Stop();
                vibrando.Stop();
                intMotoresConectados.Text = "0";
                naoVibra.Stop();
                //TemperaturaOK.Start();
                Resfriando.Stop();
                Aquecendo.Stop();
                ApagaMonitor.Stop();
                lbCorrente.Text = "0.00A";
                lbPotencia.Text = "0W";

            } else
            {
                try
                {
                    serialPort1.Open();
                    RecebeVerificaDadosDoMonitor.Start();
                    TemperaturaOK.Stop();
                    enviaInformacoes = 1;
                    intMotoresConectados.Text = "1";
                    ApagaMonitor.Start();
                    lbCorrente.Text = "2.97A";
                    lbPotencia.Text = "3000W";
                } catch
                {
                    Console.Write("Não existem Portas conectadas... ");
                } finally
                {

                }

            
            }
            int contador = 0;
            if ( contador < 50)
            {
                contador++;
                pbVibracao.Value = contador;
            }
            
        }
        string recebeTodosDados;
        public string receberDados { get; private set; }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
            

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void timer2_Tick(object sender, EventArgs e) 
        {
            
        }

        private void pbVibracao_Click(object sender, EventArgs e)
        {
            
        }



        private void Resfriando_Tick(object sender, EventArgs e)
        {
            pTemperatura.Visible = false;
            mostraOuNaoAviso = true;
            if (temperatura > 0)
            {
                temperatura += -0.5;
            }
            chart1.Series["Temperatura"].Points.AddY(temperatura);
            
            if (cpTemperatura.Value > 0)
            {
                cpTemperatura.Value -= 5;
            }
            cpTemperatura.Text = cpTemperatura.Value + "%";
        }
        bool mostraOuNaoAviso = true;
        private void Aquecendo_Tick(object sender, EventArgs e)  //  Curva para cima
        {

            if (temperatura < 29.5)
            {
                temperatura += 0.3;
            } else if (temperatura < 32.5)
            {
                temperatura += 1;
            } else if (temperatura < 38)
            {
                temperatura += 3;
            } else if (temperatura < 42)
            {
                temperatura += 0.9;
            } else if (temperatura < 44)
            {
                temperatura += 0;
            }
            chart1.Series["Temperatura"].Points.AddY(temperatura);
            
            try
            {
                if (cpTemperatura.Value < 100)
                {
                    cpTemperatura.Value += 5;
                    chart2.Series["Temperatura"].Points.Add(1);
                }
            } catch
            {
                cpTemperatura.Value = 100;
                pTemperatura.Visible = true;
                if (mostraOuNaoAviso == true)
                {
                    mostraOuNaoAviso = false;
                    tbTempr.Text += "Temperatura em Alta " + DateTime.Now.ToString() + "              ";
                    tempoTemperatura = DateTime.Now.ToString();
                    tbTempr.Text += "\n";
                    T++;
                }
            } finally
            {
                cpTemperatura.Text = cpTemperatura.Value + "%";
            }
            
        }
        public string tempoVibra;
        public string tempoTemperatura;
        private void TemperaturaOK_Tick(object sender, EventArgs e)
        {
            chart1.Series["Temperatura"].Points.AddY(27);
            cpTemperatura.Text = ("27%");
            cpTemperatura.Value = (27);
            
            chart2.Series["Temperatura"].Points.Add(27);
        }

        private void ApagaMonitor_Tick(object sender, EventArgs e)
        {
            tbMonitor.Text = "";
            chart2.Series["Temperatura"].Points.Clear();
            chart2.Series["Alertas"].Points.Clear();
        }

        private void RecebeVerificaDadosDoMonitor_Tick(object sender, EventArgs e) ////////////////////////////////// 
        {
            tbMonitor.Text += serialPort1.ReadExisting();
            //tbMonitor.Text = serialPort1.ReadLine();

            recebeTodosDados = serialPort1.ReadLine();
            //recebeTodosDados = tbMonitor.Text;
            
            
                //recebeTodosDados.Substring(4, 1);
            
                try
                {

                    if (recebeTodosDados == "10")
                    {
                        tbSensorTemperatura.Text = "Temperatura Alta";
                        tbSensorVibracao.Text = "Vibração OK";
                        vibrando.Stop();
                        naoVibra.Start();

                        Resfriando.Stop();
                        Aquecendo.Start();
                        TemperaturaOK.Stop();
                    }
                    if (recebeTodosDados == "00")
                    {
                        tbSensorTemperatura.Text = "Temperatura Alta";
                        tbSensorVibracao.Text = "Vibração ALTA";
                        naoVibra.Stop();
                        vibrando.Start();

                        Resfriando.Stop();
                        Aquecendo.Start();
                        TemperaturaOK.Stop();
                    }
                    if (recebeTodosDados == "11")
                    {
                        tbSensorTemperatura.Text = "Temperatura OK";
                        tbSensorVibracao.Text = "Vibração OK";
                        vibrando.Stop();
                        naoVibra.Start();
                        pTemperatura.Visible = false; //para nao mostrar o pbalerta

                        if (temperatura > TemperaturaFixa)
                        {
                            Resfriando.Start();
                            TemperaturaOK.Stop();
                        } else
                        {
                            TemperaturaOK.Start();
                            Resfriando.Stop();
                        }

                        Aquecendo.Stop();
                    }
                    if (recebeTodosDados == "01")
                    {
                        tbSensorTemperatura.Text = "Temperatura OK";
                        tbSensorVibracao.Text = "Vibração ALTA";
                        naoVibra.Stop();
                        vibrando.Start();
                        pTemperatura.Visible = false;

                        if (temperatura > TemperaturaFixa)
                        {
                            Resfriando.Start();
                        } else
                        {
                            TemperaturaOK.Start();
                            Resfriando.Stop();
                        }
                        Aquecendo.Stop();
                    }
                    if (recebeTodosDados == "71")
                {
                    if (tbNum.Text != "Pesquise por algo..." || tbNum.Text == "")
                    {
                        EnviaMensagemWhatsApp zap = new EnviaMensagemWhatsApp();
                        zap.SendMessage("Alerta de Incendio! Fogo detectado", tbNum.Text);
                    }
                }

                } catch
                {
                    label3.Text = "Erro";
                } finally
                {

                }
            
        }

        private void vibrando_Tick(object sender, EventArgs e)
        {
            if (pbVibracao.Value >= 100 || pbVibracao.Value > 80)
            {
                pbVibracao.Value = 100;
                serialPort1.WriteLine("1");
                pbAlert.Visible = true;
                tbAlertas.Text += ("Alta na Vibração " + DateTime.Now.ToString() + "            ");
                tempoVibra = DateTime.Now.ToString();
                tbAlertas.Text += "\n";
                V++;
                chart2.Series["Alertas"].Points.Add(17);
            } else if (pbVibracao.Value == 85)
            {

                pbVibracao.Value += 15;
            } else if (pbVibracao.Value <= 80)
            {
                pbVibracao.Value += 20;

            }
            cVibracao.Series["Vibração"].Points.AddY(pbVibracao.Value);
            chart2.Series["Alertas"].Points.Add(vibracao);
            pbVibracao.Text = pbVibracao.Value.ToString() + "%";
        }

        private void naoVibra_Tick(object sender, EventArgs e)
        {
            if (pbVibracao.Value < 101 && pbVibracao.Value > 4)
            {
                pbVibracao.Value -= 5;
            }
            cVibracao.Series["Vibração"].Points.AddY(pbVibracao.Value);
            
            pbVibracao.Text = pbVibracao.Value.ToString() + "%";
            if (pbAlert.Visible == true)
            {
                pbAlert.Visible = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
