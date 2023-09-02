
namespace SistemaAcademico_16_05_22.View
{
    partial class TelaConsultaDisciplina
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
            this.tbldisciplina = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cred = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tbldisciplina)).BeginInit();
            this.SuspendLayout();
            // 
            // tbldisciplina
            // 
            this.tbldisciplina.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.tbldisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbldisciplina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nome,
            this.cred});
            this.tbldisciplina.Location = new System.Drawing.Point(29, 24);
            this.tbldisciplina.Name = "tbldisciplina";
            this.tbldisciplina.Size = new System.Drawing.Size(344, 276);
            this.tbldisciplina.TabIndex = 0;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            // 
            // cred
            // 
            this.cred.HeaderText = "Créditos";
            this.cred.Name = "cred";
            // 
            // btnconsultar
            // 
            this.btnconsultar.Location = new System.Drawing.Point(186, 318);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(75, 23);
            this.btnconsultar.TabIndex = 1;
            this.btnconsultar.Text = "Consultar";
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(420, 351);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(38, 15);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Voltar";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // TelaConsultaDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(487, 373);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnconsultar);
            this.Controls.Add(this.tbldisciplina);
            this.Name = "TelaConsultaDisciplina";
            this.Text = "TelaConsultaDisciplina";
            this.Load += new System.EventHandler(this.TelaConsultaDisciplina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbldisciplina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tbldisciplina;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cred;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}