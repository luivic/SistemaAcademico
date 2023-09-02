
namespace SistemaAcademico_16_05_22.View
{
    partial class TelaAlunoMatricula
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
            this.tblturma = new System.Windows.Forms.DataGridView();
            this.iden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prof = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tblturma)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblturma
            // 
            this.tblturma.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.tblturma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblturma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iden,
            this.seme,
            this.ano,
            this.ativa,
            this.prof,
            this.dis});
            this.tblturma.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tblturma.Location = new System.Drawing.Point(217, 21);
            this.tblturma.Name = "tblturma";
            this.tblturma.Size = new System.Drawing.Size(434, 311);
            this.tblturma.TabIndex = 0;
            this.tblturma.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblturma_CellContentClick);
            // 
            // iden
            // 
            this.iden.HeaderText = "Identificador";
            this.iden.Name = "iden";
            // 
            // seme
            // 
            this.seme.HeaderText = "Semestre";
            this.seme.Name = "seme";
            // 
            // ano
            // 
            this.ano.HeaderText = "Ano";
            this.ano.Name = "ano";
            // 
            // ativa
            // 
            this.ativa.HeaderText = "Ativa";
            this.ativa.Name = "ativa";
            // 
            // prof
            // 
            this.prof.HeaderText = "Professor";
            this.prof.Name = "prof";
            // 
            // dis
            // 
            this.dis.HeaderText = "Disciplina";
            this.dis.Name = "dis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "aqui para";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ver as Turmas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Clique";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(31, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 139);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "---->";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Digite o identificador da turma: ";
            // 
            // txtid
            // 
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtid.Location = new System.Drawing.Point(238, 32);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(261, 20);
            this.txtid.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(521, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.txtid);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(31, 347);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 65);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // TelaAlunoMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(663, 441);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tblturma);
            this.Name = "TelaAlunoMatricula";
            this.Text = "TelaAlunoMatricula";
            ((System.ComponentModel.ISupportInitialize)(this.tblturma)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tblturma;
        private System.Windows.Forms.DataGridViewTextBoxColumn iden;
        private System.Windows.Forms.DataGridViewTextBoxColumn seme;
        private System.Windows.Forms.DataGridViewTextBoxColumn ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn ativa;
        private System.Windows.Forms.DataGridViewTextBoxColumn prof;
        private System.Windows.Forms.DataGridViewTextBoxColumn dis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
    }
}