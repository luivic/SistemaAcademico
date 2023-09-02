
namespace SistemaAcademico_16_05_22.View
{
    partial class ProfessorNota1
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
            this.tblaluno = new System.Windows.Forms.DataGridView();
            this.aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aprov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.falt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblaluno)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblaluno
            // 
            this.tblaluno.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.tblaluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblaluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aluno,
            this.turm,
            this.n2,
            this.exam,
            this.aprov,
            this.falt});
            this.tblaluno.Location = new System.Drawing.Point(36, 25);
            this.tblaluno.Name = "tblaluno";
            this.tblaluno.Size = new System.Drawing.Size(393, 319);
            this.tblaluno.TabIndex = 0;
            this.tblaluno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // aluno
            // 
            this.aluno.HeaderText = "Aluno";
            this.aluno.Name = "aluno";
            // 
            // turm
            // 
            this.turm.HeaderText = "Turma";
            this.turm.Name = "turm";
            // 
            // n2
            // 
            this.n2.HeaderText = "Nota2";
            this.n2.Name = "n2";
            // 
            // exam
            // 
            this.exam.HeaderText = "Exame";
            this.exam.Name = "exam";
            // 
            // aprov
            // 
            this.aprov.HeaderText = "Aprovado";
            this.aprov.Name = "aprov";
            // 
            // falt
            // 
            this.falt.HeaderText = "Faltas";
            this.falt.Name = "falt";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.txtvalor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(486, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 197);
            this.panel1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(54, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(38, 87);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 20);
            this.txtvalor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "das Notas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o Valor";
            // 
            // ProfessorNota1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(707, 415);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tblaluno);
            this.Name = "ProfessorNota1";
            this.Text = "ProfessorNota1";
            ((System.ComponentModel.ISupportInitialize)(this.tblaluno)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tblaluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn turm;
        private System.Windows.Forms.DataGridViewTextBoxColumn n2;
        private System.Windows.Forms.DataGridViewTextBoxColumn exam;
        private System.Windows.Forms.DataGridViewTextBoxColumn aprov;
        private System.Windows.Forms.DataGridViewTextBoxColumn falt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtvalor;
    }
}