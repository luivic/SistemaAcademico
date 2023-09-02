
namespace SistemaAcademico_16_05_22.View
{
    partial class TelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnentrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbprof = new System.Windows.Forms.RadioButton();
            this.rdbcord = new System.Windows.Forms.RadioButton();
            this.rdbaluno = new System.Windows.Forms.RadioButton();
            this.rdbsecre = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tela";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "de";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Início";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Selecione ";
            // 
            // btnentrar
            // 
            this.btnentrar.Location = new System.Drawing.Point(43, 285);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Size = new System.Drawing.Size(75, 23);
            this.btnentrar.TabIndex = 4;
            this.btnentrar.Text = "Entrar";
            this.btnentrar.UseVisualStyleBackColor = true;
            this.btnentrar.Click += new System.EventHandler(this.btnentrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rdbprof);
            this.panel1.Controls.Add(this.rdbcord);
            this.panel1.Controls.Add(this.rdbaluno);
            this.panel1.Controls.Add(this.rdbsecre);
            this.panel1.Location = new System.Drawing.Point(197, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 160);
            this.panel1.TabIndex = 5;
            // 
            // rdbprof
            // 
            this.rdbprof.AutoSize = true;
            this.rdbprof.Location = new System.Drawing.Point(12, 124);
            this.rdbprof.Name = "rdbprof";
            this.rdbprof.Size = new System.Drawing.Size(69, 17);
            this.rdbprof.TabIndex = 3;
            this.rdbprof.TabStop = true;
            this.rdbprof.Text = "Professor";
            this.rdbprof.UseVisualStyleBackColor = true;
            // 
            // rdbcord
            // 
            this.rdbcord.AutoSize = true;
            this.rdbcord.Location = new System.Drawing.Point(12, 91);
            this.rdbcord.Name = "rdbcord";
            this.rdbcord.Size = new System.Drawing.Size(86, 17);
            this.rdbcord.TabIndex = 2;
            this.rdbcord.TabStop = true;
            this.rdbcord.Text = "Coordenador";
            this.rdbcord.UseVisualStyleBackColor = true;
            this.rdbcord.CheckedChanged += new System.EventHandler(this.rdbcord_CheckedChanged);
            // 
            // rdbaluno
            // 
            this.rdbaluno.AutoSize = true;
            this.rdbaluno.Location = new System.Drawing.Point(12, 54);
            this.rdbaluno.Name = "rdbaluno";
            this.rdbaluno.Size = new System.Drawing.Size(52, 17);
            this.rdbaluno.TabIndex = 1;
            this.rdbaluno.TabStop = true;
            this.rdbaluno.Text = "Aluno";
            this.rdbaluno.UseVisualStyleBackColor = true;
            // 
            // rdbsecre
            // 
            this.rdbsecre.AutoSize = true;
            this.rdbsecre.Location = new System.Drawing.Point(12, 17);
            this.rdbsecre.Name = "rdbsecre";
            this.rdbsecre.Size = new System.Drawing.Size(73, 17);
            this.rdbsecre.TabIndex = 0;
            this.rdbsecre.TabStop = true;
            this.rdbsecre.Text = "Secretaria";
            this.rdbsecre.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(172, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(118, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "sua";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(90, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Função";
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(342, 366);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnentrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaInicial";
            this.Text = "TelaInicial";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnentrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbprof;
        private System.Windows.Forms.RadioButton rdbcord;
        private System.Windows.Forms.RadioButton rdbaluno;
        private System.Windows.Forms.RadioButton rdbsecre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}