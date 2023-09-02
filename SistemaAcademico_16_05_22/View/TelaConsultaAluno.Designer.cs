
namespace SistemaAcademico_16_05_22.View
{
    partial class TelaConsultaAluno
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
            this.btncad = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.numa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblaluno)).BeginInit();
            this.SuspendLayout();
            // 
            // tblaluno
            // 
            this.tblaluno.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.tblaluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblaluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numa,
            this.curso});
            this.tblaluno.Location = new System.Drawing.Point(67, 12);
            this.tblaluno.Name = "tblaluno";
            this.tblaluno.Size = new System.Drawing.Size(429, 295);
            this.tblaluno.TabIndex = 0;
            this.tblaluno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btncad
            // 
            this.btncad.Location = new System.Drawing.Point(252, 339);
            this.btncad.Name = "btncad";
            this.btncad.Size = new System.Drawing.Size(75, 23);
            this.btncad.TabIndex = 1;
            this.btncad.Text = "Consultar";
            this.btncad.UseVisualStyleBackColor = true;
            this.btncad.Click += new System.EventHandler(this.btncad_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(516, 370);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(38, 15);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Voltar";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // numa
            // 
            this.numa.HeaderText = "Numero.A";
            this.numa.Name = "numa";
            // 
            // curso
            // 
            this.curso.HeaderText = "Curso";
            this.curso.Name = "curso";
            // 
            // TelaConsultaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(583, 402);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btncad);
            this.Controls.Add(this.tblaluno);
            this.Name = "TelaConsultaAluno";
            this.Text = "TelaConsultaAluno";
            this.Load += new System.EventHandler(this.TelaConsultaAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblaluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblaluno;
        private System.Windows.Forms.Button btncad;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numa;
        private System.Windows.Forms.DataGridViewTextBoxColumn curso;
    }
}