
namespace SistemaAcademico_16_05_22.View
{
    partial class TelaProfessorNotas3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.rdbnota1 = new System.Windows.Forms.RadioButton();
            this.rdbnota2 = new System.Windows.Forms.RadioButton();
            this.rdbexame = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lançamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Selecione ";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(57, 171);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rdbexame);
            this.panel1.Controls.Add(this.rdbnota2);
            this.panel1.Controls.Add(this.rdbnota1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(28, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 211);
            this.panel1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "o Tipo:";
            // 
            // rdbnota1
            // 
            this.rdbnota1.AutoSize = true;
            this.rdbnota1.Location = new System.Drawing.Point(57, 71);
            this.rdbnota1.Name = "rdbnota1";
            this.rdbnota1.Size = new System.Drawing.Size(54, 17);
            this.rdbnota1.TabIndex = 7;
            this.rdbnota1.TabStop = true;
            this.rdbnota1.Text = "Nota1";
            this.rdbnota1.UseVisualStyleBackColor = true;
            this.rdbnota1.CheckedChanged += new System.EventHandler(this.rdbnota1_CheckedChanged);
            // 
            // rdbnota2
            // 
            this.rdbnota2.AutoSize = true;
            this.rdbnota2.Location = new System.Drawing.Point(57, 104);
            this.rdbnota2.Name = "rdbnota2";
            this.rdbnota2.Size = new System.Drawing.Size(54, 17);
            this.rdbnota2.TabIndex = 8;
            this.rdbnota2.TabStop = true;
            this.rdbnota2.Text = "Nota2";
            this.rdbnota2.UseVisualStyleBackColor = true;
            this.rdbnota2.CheckedChanged += new System.EventHandler(this.rdbnota2_CheckedChanged);
            // 
            // rdbexame
            // 
            this.rdbexame.AutoSize = true;
            this.rdbexame.Location = new System.Drawing.Point(57, 136);
            this.rdbexame.Name = "rdbexame";
            this.rdbexame.Size = new System.Drawing.Size(57, 17);
            this.rdbexame.TabIndex = 9;
            this.rdbexame.TabStop = true;
            this.rdbexame.Text = "Exame";
            this.rdbexame.UseVisualStyleBackColor = true;
            this.rdbexame.CheckedChanged += new System.EventHandler(this.rdbexame_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(127, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "de";
            // 
            // TelaProfessorNotas3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(315, 385);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaProfessorNotas3";
            this.Text = "TelaProfessorNotas3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbexame;
        private System.Windows.Forms.RadioButton rdbnota2;
        private System.Windows.Forms.RadioButton rdbnota1;
        private System.Windows.Forms.Label label5;
    }
}