namespace Teste04
{
    partial class FrmNotas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAluno = new System.Windows.Forms.TextBox();
            this.lblAluno = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txt1Sem = new System.Windows.Forms.TextBox();
            this.lbl1Sem = new System.Windows.Forms.Label();
            this.lbl2Sem = new System.Windows.Forms.Label();
            this.txt2Sem = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblNotaStatus = new System.Windows.Forms.Label();
            this.lblAvisoNota1 = new System.Windows.Forms.Label();
            this.lblAvisoNome = new System.Windows.Forms.Label();
            this.lblAvisoNota2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAluno
            // 
            this.txtAluno.Location = new System.Drawing.Point(43, 77);
            this.txtAluno.Name = "txtAluno";
            this.txtAluno.Size = new System.Drawing.Size(304, 23);
            this.txtAluno.TabIndex = 0;
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Location = new System.Drawing.Point(43, 59);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(92, 15);
            this.lblAluno.TabIndex = 1;
            this.lblAluno.Text = "Nome do Aluno";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(43, 260);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(179, 27);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txt1Sem
            // 
            this.txt1Sem.Location = new System.Drawing.Point(43, 198);
            this.txt1Sem.Name = "txt1Sem";
            this.txt1Sem.Size = new System.Drawing.Size(115, 23);
            this.txt1Sem.TabIndex = 3;
            // 
            // lbl1Sem
            // 
            this.lbl1Sem.AutoSize = true;
            this.lbl1Sem.Location = new System.Drawing.Point(43, 180);
            this.lbl1Sem.Name = "lbl1Sem";
            this.lbl1Sem.Size = new System.Drawing.Size(115, 15);
            this.lbl1Sem.TabIndex = 4;
            this.lbl1Sem.Text = "Nota do 1º Semestre";
            // 
            // lbl2Sem
            // 
            this.lbl2Sem.AutoSize = true;
            this.lbl2Sem.Location = new System.Drawing.Point(234, 180);
            this.lbl2Sem.Name = "lbl2Sem";
            this.lbl2Sem.Size = new System.Drawing.Size(115, 15);
            this.lbl2Sem.TabIndex = 6;
            this.lbl2Sem.Text = "Nota do 2º Semestre";
            // 
            // txt2Sem
            // 
            this.txt2Sem.Location = new System.Drawing.Point(232, 198);
            this.txt2Sem.Name = "txt2Sem";
            this.txt2Sem.Size = new System.Drawing.Size(115, 23);
            this.txt2Sem.TabIndex = 5;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(234, 260);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(113, 27);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar Campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(43, 369);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(94, 15);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status do Aluno:";
            // 
            // lblNotaStatus
            // 
            this.lblNotaStatus.AutoSize = true;
            this.lblNotaStatus.ForeColor = System.Drawing.Color.Gray;
            this.lblNotaStatus.Location = new System.Drawing.Point(147, 369);
            this.lblNotaStatus.Name = "lblNotaStatus";
            this.lblNotaStatus.Size = new System.Drawing.Size(100, 15);
            this.lblNotaStatus.TabIndex = 9;
            this.lblNotaStatus.Text = "Nota não enviada";
            // 
            // lblAvisoNota1
            // 
            this.lblAvisoNota1.AutoSize = true;
            this.lblAvisoNota1.ForeColor = System.Drawing.Color.Red;
            this.lblAvisoNota1.Location = new System.Drawing.Point(43, 224);
            this.lblAvisoNota1.Name = "lblAvisoNota1";
            this.lblAvisoNota1.Size = new System.Drawing.Size(110, 15);
            this.lblAvisoNota1.TabIndex = 10;
            this.lblAvisoNota1.Text = "Campo Obrigatório";
            this.lblAvisoNota1.Visible = false;
            // 
            // lblAvisoNome
            // 
            this.lblAvisoNome.AutoSize = true;
            this.lblAvisoNome.ForeColor = System.Drawing.Color.Red;
            this.lblAvisoNome.Location = new System.Drawing.Point(43, 104);
            this.lblAvisoNome.Name = "lblAvisoNome";
            this.lblAvisoNome.Size = new System.Drawing.Size(110, 15);
            this.lblAvisoNome.TabIndex = 11;
            this.lblAvisoNome.Text = "Campo Obrigatório";
            this.lblAvisoNome.Visible = false;
            // 
            // lblAvisoNota2
            // 
            this.lblAvisoNota2.AutoSize = true;
            this.lblAvisoNota2.ForeColor = System.Drawing.Color.Red;
            this.lblAvisoNota2.Location = new System.Drawing.Point(234, 224);
            this.lblAvisoNota2.Name = "lblAvisoNota2";
            this.lblAvisoNota2.Size = new System.Drawing.Size(110, 15);
            this.lblAvisoNota2.TabIndex = 12;
            this.lblAvisoNota2.Text = "Campo Obrigatório";
            this.lblAvisoNota2.Visible = false;
            // 
            // FrmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 450);
            this.Controls.Add(this.lblAvisoNota2);
            this.Controls.Add(this.lblAvisoNome);
            this.Controls.Add(this.lblAvisoNota1);
            this.Controls.Add(this.lblNotaStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lbl2Sem);
            this.Controls.Add(this.txt2Sem);
            this.Controls.Add(this.lbl1Sem);
            this.Controls.Add(this.txt1Sem);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblAluno);
            this.Controls.Add(this.txtAluno);
            this.Name = "FrmNotas";
            this.Text = "Lançamento de Notas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtAluno;
        private Label lblAluno;
        private Button btnEnviar;
        private TextBox txt1Sem;
        private Label lbl1Sem;
        private Label lbl2Sem;
        private TextBox txt2Sem;
        private Button btnLimpar;
        private Label lblStatus;
        private Label lblNotaStatus;
        private Label lblAvisoNota1;
        private Label lblAvisoNome;
        private Label lblAvisoNota2;
    }
}