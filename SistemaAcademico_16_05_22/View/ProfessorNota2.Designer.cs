
namespace SistemaAcademico_16_05_22.View
{
    partial class ProfessorNota2
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
            this.alun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aprov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.falt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblaluno)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblaluno
            // 
            this.tblaluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblaluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alun,
            this.turm,
            this.n1,
            this.exam,
            this.aprov,
            this.falt});
            this.tblaluno.Location = new System.Drawing.Point(12, 12);
            this.tblaluno.Name = "tblaluno";
            this.tblaluno.Size = new System.Drawing.Size(384, 311);
            this.tblaluno.TabIndex = 0;
            // 
            // alun
            // 
            this.alun.HeaderText = "Aluno";
            this.alun.Name = "alun";
            // 
            // turm
            // 
            this.turm.HeaderText = "Turma";
            this.turm.Name = "turm";
            // 
            // n1
            // 
            this.n1.HeaderText = "Nota1";
            this.n1.Name = "n1";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.txtvalor);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(473, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 176);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(50, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(37, 84);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 20);
            this.txtvalor.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "das Notas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o valor";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProfessorNota2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(718, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tblaluno);
            this.Name = "ProfessorNota2";
            this.Text = "ProfessorNota2";
            ((System.ComponentModel.ISupportInitialize)(this.tblaluno)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tblaluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn alun;
        private System.Windows.Forms.DataGridViewTextBoxColumn turm;
        private System.Windows.Forms.DataGridViewTextBoxColumn n1;
        private System.Windows.Forms.DataGridViewTextBoxColumn exam;
        private System.Windows.Forms.DataGridViewTextBoxColumn aprov;
        private System.Windows.Forms.DataGridViewTextBoxColumn falt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtvalor;
    }
}