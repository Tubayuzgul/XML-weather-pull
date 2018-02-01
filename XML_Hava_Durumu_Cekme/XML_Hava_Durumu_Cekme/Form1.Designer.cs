namespace XML_Hava_Durumu_Cekme
{
    partial class Form1
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
            this.txtbolge = new System.Windows.Forms.TextBox();
            this.txtperyot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdurum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnhavadurumu = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bölge :";
            // 
            // txtbolge
            // 
            this.txtbolge.Location = new System.Drawing.Point(105, 44);
            this.txtbolge.Multiline = true;
            this.txtbolge.Name = "txtbolge";
            this.txtbolge.Size = new System.Drawing.Size(170, 29);
            this.txtbolge.TabIndex = 1;
            // 
            // txtperyot
            // 
            this.txtperyot.Location = new System.Drawing.Point(105, 93);
            this.txtperyot.Multiline = true;
            this.txtperyot.Name = "txtperyot";
            this.txtperyot.Size = new System.Drawing.Size(170, 29);
            this.txtperyot.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Peryot :";
            // 
            // txtil
            // 
            this.txtil.Location = new System.Drawing.Point(105, 143);
            this.txtil.Multiline = true;
            this.txtil.Name = "txtil";
            this.txtil.Size = new System.Drawing.Size(170, 29);
            this.txtil.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(21, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "İli :";
            // 
            // txtdurum
            // 
            this.txtdurum.Location = new System.Drawing.Point(105, 195);
            this.txtdurum.Multiline = true;
            this.txtdurum.Name = "txtdurum";
            this.txtdurum.Size = new System.Drawing.Size(170, 29);
            this.txtdurum.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(21, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Durum :";
            // 
            // btnhavadurumu
            // 
            this.btnhavadurumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhavadurumu.Location = new System.Drawing.Point(105, 266);
            this.btnhavadurumu.Name = "btnhavadurumu";
            this.btnhavadurumu.Size = new System.Drawing.Size(180, 50);
            this.btnhavadurumu.TabIndex = 8;
            this.btnhavadurumu.Text = "Hava Durumunu Göster";
            this.btnhavadurumu.UseVisualStyleBackColor = true;
            this.btnhavadurumu.Click += new System.EventHandler(this.btnhavadurumu_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(301, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(495, 399);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnhavadurumu);
            this.Controls.Add(this.txtdurum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtperyot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbolge);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "İzmir İçin Hava Durumu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbolge;
        private System.Windows.Forms.TextBox txtperyot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdurum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnhavadurumu;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

