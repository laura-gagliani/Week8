
namespace EquazioniSecondoGrado.WinForm
{
    partial class EquationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalcola = new System.Windows.Forms.Button();
            this.coeffA = new System.Windows.Forms.TextBox();
            this.coeffB = new System.Windows.Forms.TextBox();
            this.coeffC = new System.Windows.Forms.TextBox();
            this.textBoxSoluzioni = new System.Windows.Forms.TextBox();
            this.textBoxEquazione = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcola
            // 
            this.btnCalcola.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCalcola.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalcola.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCalcola.Location = new System.Drawing.Point(492, 65);
            this.btnCalcola.Name = "btnCalcola";
            this.btnCalcola.Size = new System.Drawing.Size(209, 82);
            this.btnCalcola.TabIndex = 0;
            this.btnCalcola.Text = "Calcola";
            this.btnCalcola.UseVisualStyleBackColor = false;
            this.btnCalcola.Click += new System.EventHandler(this.btnCalcola_Click);
            // 
            // coeffA
            // 
            this.coeffA.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coeffA.Location = new System.Drawing.Point(221, 81);
            this.coeffA.Name = "coeffA";
            this.coeffA.PlaceholderText = "a";
            this.coeffA.Size = new System.Drawing.Size(45, 50);
            this.coeffA.TabIndex = 1;
            this.coeffA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // coeffB
            // 
            this.coeffB.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coeffB.Location = new System.Drawing.Point(307, 81);
            this.coeffB.Name = "coeffB";
            this.coeffB.PlaceholderText = "b";
            this.coeffB.Size = new System.Drawing.Size(45, 50);
            this.coeffB.TabIndex = 2;
            this.coeffB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // coeffC
            // 
            this.coeffC.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coeffC.Location = new System.Drawing.Point(398, 81);
            this.coeffC.Name = "coeffC";
            this.coeffC.PlaceholderText = "c";
            this.coeffC.Size = new System.Drawing.Size(45, 50);
            this.coeffC.TabIndex = 3;
            this.coeffC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSoluzioni
            // 
            this.textBoxSoluzioni.BackColor = System.Drawing.Color.White;
            this.textBoxSoluzioni.Enabled = false;
            this.textBoxSoluzioni.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSoluzioni.Location = new System.Drawing.Point(61, 289);
            this.textBoxSoluzioni.Name = "textBoxSoluzioni";
            this.textBoxSoluzioni.PlaceholderText = "Soluzioni";
            this.textBoxSoluzioni.Size = new System.Drawing.Size(640, 45);
            this.textBoxSoluzioni.TabIndex = 4;
            // 
            // textBoxEquazione
            // 
            this.textBoxEquazione.BackColor = System.Drawing.Color.White;
            this.textBoxEquazione.Enabled = false;
            this.textBoxEquazione.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEquazione.Location = new System.Drawing.Point(61, 229);
            this.textBoxEquazione.Name = "textBoxEquazione";
            this.textBoxEquazione.PlaceholderText = "Riepilogo equazione";
            this.textBoxEquazione.Size = new System.Drawing.Size(640, 45);
            this.textBoxEquazione.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\Users\\laura\\Desktop\\calculator-drawing.jpg";
            this.pictureBox1.Location = new System.Drawing.Point(33, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 178);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // EquationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(766, 406);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxEquazione);
            this.Controls.Add(this.textBoxSoluzioni);
            this.Controls.Add(this.coeffC);
            this.Controls.Add(this.coeffB);
            this.Controls.Add(this.coeffA);
            this.Controls.Add(this.btnCalcola);
            this.Name = "EquationForm";
            this.Text = "Equazioni di secondo grado";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcola;
        private System.Windows.Forms.TextBox coeffA;
        private System.Windows.Forms.TextBox coeffB;
        private System.Windows.Forms.TextBox coeffC;
        private System.Windows.Forms.TextBox textBoxSoluzioni;
        private System.Windows.Forms.TextBox textBoxEquazione;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

