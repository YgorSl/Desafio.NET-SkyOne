using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste04
{
    public partial class FrmNotas : Form
    {
        public FrmNotas()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string aluno = txtAluno.Text;
            lblAvisoNome.Visible = false;
            lblAvisoNota1.Visible = false;
            lblAvisoNota2.Visible = false;

            if (aluno == "")
            {
                lblAvisoNome.Visible = true;
            }
            else if (txt1Sem.Text == "")
            {
                lblAvisoNota1.Visible = true;
            }
            else if (txt2Sem.Text == "")
            {
                lblAvisoNota2.Visible = true;
            }
            else
            {
              double nota1 = Convert.ToDouble(txt1Sem.Text);
              double nota2 = Convert.ToDouble(txt2Sem.Text);

              double media = (nota1 + nota2) / 2;
              
              if(media < 6.5)
                {
                    lblNotaStatus.ForeColor = Color.Red;
                    lblNotaStatus.Text = "Reprovado";
                }
              else if(media >= 6.5 )
                {
                    lblNotaStatus.ForeColor = Color.Green;
                    lblNotaStatus.Text = "Aprovado";
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAluno.Clear();
            txt1Sem.Clear();
            txt2Sem.Clear();
            lblNotaStatus.ForeColor = Color.Gray;
            lblNotaStatus.Text = "Nota não enviada";

        }
    }
}
