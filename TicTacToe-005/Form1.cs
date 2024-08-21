using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_005
{
    public partial class Form1 : Form
    {
        private int pontosX = 0;
        private int pontosO = 0;
        private int empates = 0;
        private int jogador = 0;

        public Form1()
        {
            InitializeComponent();
            AtualizarPlacar();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text == "")
            {
                btn.Text = (jogador % 2 == 0) ? "X" : "O";
                jogador++;
            }

            VerificarVencedor();
        }

        private void VerificarVencedor()
        {
            bool vencedor = false;

            // Verificação horizontal
            if ((A1.Text == A2.Text && A2.Text == A3.Text && A1.Text != "") ||
                (B1.Text == B2.Text && B2.Text == B3.Text && B1.Text != "") ||
                (C1.Text == C2.Text && C2.Text == C3.Text && C1.Text != ""))
            {
                vencedor = true;
            }
            // Verificação vertical
            else if ((A1.Text == B1.Text && B1.Text == C1.Text && A1.Text != "") ||
                     (A2.Text == B2.Text && B2.Text == C2.Text && A2.Text != "") ||
                     (A3.Text == B3.Text && B3.Text == C3.Text && A3.Text != ""))
            {
                vencedor = true;
            }
            // Verificação diagonal
            else if ((A1.Text == B2.Text && B2.Text == C3.Text && A1.Text != "") ||
                     (A3.Text == B2.Text && B2.Text == C1.Text && A3.Text != ""))
            {
                vencedor = true;
            }

            if (vencedor)
            {
                string ganhador = (jogador % 2 == 1) ? "X" : "O";
                MessageBox.Show(ganhador + " venceu!");
                if (ganhador == "X")
                {
                    pontosX++;
                }
                else
                {
                    pontosO++;
                }
                ResetarJogo();
            }
            else if (jogador == 9)
            {
                empates++;
                MessageBox.Show("Empate!");
                ResetarJogo();
            }
        }

        private void ResetarJogo()
        {
            jogador = 0;

            foreach (Control c in Controls)
            {
                if (c is Button && c.Name != "btnResetar")
                {
                    ((Button)c).Text = "";
                }
            }

            AtualizarPlacar();
        }

        private void AtualizarPlacar()
        {
            lblPontosX.Text = "X: " + pontosX;
            lblPontosO.Text = "O: " + pontosO;
            lblEmpates.Text = "Empates: " + empates;
        }

        private void btnResetar_Click(object sender, EventArgs e)
        {
            pontosX = 0;
            pontosO = 0;
            empates = 0;
            ResetarJogo();
        }
    }
}
