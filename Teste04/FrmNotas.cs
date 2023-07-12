using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Testes04e05;

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
            lblAvisoAno.Visible = false;

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
            else if (txtAno.Text == "")
            {
                lblAvisoAno.Visible = true;
            }
            else
            {
                double nota1 = Convert.ToDouble(txt1Sem.Text);
                double nota2 = Convert.ToDouble(txt2Sem.Text);
                double media = (nota1 + nota2) / 2;
                string status = "";
                int ano = Convert.ToInt32(txtAno.Text);

                if (media < 6.5)
                {
                    status = "Reprovado";
                    lblNotaStatus.ForeColor = Color.Red;
                }
                else if (media >= 6.5)
                {
                    status = "Aprovado";
                    lblNotaStatus.ForeColor = Color.Green;
                }
                lblNotaStatus.Text = status;

                using (SqlConnection connection = new SQL().connection)
                {
                    try
                    {
                        connection.Open();
                        string sql = "INSERT INTO Notas(Nome, Nota1Semestre, Nota2Semestre, Ano, MediaAnual, Status)" +
                                     "VALUES(@Nome, @Nota1Semestre, @Nota2Semestre, @Ano, @MediaAnual, @Status)";

                        SqlCommand command = new SqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@Nome", aluno);
                        command.Parameters.AddWithValue("@Nota1Semestre", nota1);
                        command.Parameters.AddWithValue("@Nota2Semestre", nota2);
                        command.Parameters.AddWithValue("@Ano", ano);
                        command.Parameters.AddWithValue("@MediaAnual", media);
                        command.Parameters.AddWithValue("@Status", status);

                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                    connection.Close();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
