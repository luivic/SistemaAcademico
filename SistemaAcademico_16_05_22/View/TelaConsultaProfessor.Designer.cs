
namespace SistemaAcademico_16_05_22.View
{
    partial class TelaConsultaProfessor
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
            this.tblprof = new System.Windows.Forms.DataGridView();
            this.numprof = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblprof)).BeginInit();
            this.SuspendLayout();
            // 
            // tblprof
            // 
            this.tblprof.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.tblprof.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblprof.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numprof,
            this.titula,
            this.nome,
            this.login,
            this.senha,
            this.perfil});
            this.tblprof.Location = new System.Drawing.Point(91, 12);
            this.tblprof.Name = "tblprof";
            this.tblprof.Size = new System.Drawing.Size(460, 292);
            this.tblprof.TabIndex = 0;
            this.tblprof.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblprof_CellContentClick);
            // 
            // numprof
            // 
            this.numprof.HeaderText = "Númeo.Prof";
            this.numprof.Name = "numprof";
            // 
            // titula
            // 
            this.titula.HeaderText = "Titulação";
            this.titula.Name = "titula";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(586, 348);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(38, 15);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Voltar";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            // 
            // login
            // 
            this.login.HeaderText = "Login";
            this.login.Name = "login";
            // 
            // senha
            // 
            this.senha.HeaderText = "Senha";
            this.senha.Name = "senha";
            // 
            // perfil
            // 
            this.perfil.HeaderText = "Perfil";
            this.perfil.Name = "perfil";
            // 
            // TelaConsultaProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(663, 380);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tblprof);
            this.Name = "TelaConsultaProfessor";
            this.Text = "TelaConsultaProfessor";
            ((System.ComponentModel.ISupportInitialize)(this.tblprof)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblprof;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numprof;
        private System.Windows.Forms.DataGridViewTextBoxColumn titula;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridViewTextBoxColumn senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn perfil;
    }
}