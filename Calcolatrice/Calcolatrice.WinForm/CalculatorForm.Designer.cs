﻿
namespace Calcolatrice.WinForm
{
    partial class CalculatorForm
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
            this.textValue = new System.Windows.Forms.TextBox();
            this.labelRisultato = new System.Windows.Forms.Label();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnVirgola = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSottr = new System.Windows.Forms.Button();
            this.btnMolt = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnCanc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textValue
            // 
            this.textValue.Location = new System.Drawing.Point(12, 40);
            this.textValue.Name = "textValue";
            this.textValue.ReadOnly = true;
            this.textValue.Size = new System.Drawing.Size(159, 31);
            this.textValue.TabIndex = 0;
            // 
            // labelRisultato
            // 
            this.labelRisultato.AutoSize = true;
            this.labelRisultato.Location = new System.Drawing.Point(12, 9);
            this.labelRisultato.Name = "labelRisultato";
            this.labelRisultato.Size = new System.Drawing.Size(59, 25);
            this.labelRisultato.TabIndex = 1;
            this.labelRisultato.Text = "Result";
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(12, 88);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(49, 37);
            this.btn7.TabIndex = 2;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(67, 88);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(49, 37);
            this.btn8.TabIndex = 3;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(122, 88);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(49, 37);
            this.btn9.TabIndex = 4;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(12, 131);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(49, 37);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(67, 131);
            this.btn5.Name = "btn5";
            this.btn5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn5.Size = new System.Drawing.Size(49, 37);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(122, 131);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(49, 37);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(122, 174);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(49, 37);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(67, 174);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(49, 37);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 174);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(49, 37);
            this.btn1.TabIndex = 10;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnVirgola
            // 
            this.btnVirgola.Location = new System.Drawing.Point(12, 217);
            this.btnVirgola.Name = "btnVirgola";
            this.btnVirgola.Size = new System.Drawing.Size(49, 37);
            this.btnVirgola.TabIndex = 11;
            this.btnVirgola.Text = ",";
            this.btnVirgola.UseVisualStyleBackColor = true;
            this.btnVirgola.Click += new System.EventHandler(this.btnVirgola_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(67, 217);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(49, 37);
            this.btn0.TabIndex = 12;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(122, 217);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(49, 37);
            this.btnEquals.TabIndex = 13;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(177, 217);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(49, 37);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Tag = "somma";
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSottr
            // 
            this.btnSottr.Location = new System.Drawing.Point(177, 174);
            this.btnSottr.Name = "btnSottr";
            this.btnSottr.Size = new System.Drawing.Size(49, 37);
            this.btnSottr.TabIndex = 15;
            this.btnSottr.Text = "-";
            this.btnSottr.UseVisualStyleBackColor = true;
            this.btnSottr.Click += new System.EventHandler(this.btnSottr_Click);
            // 
            // btnMolt
            // 
            this.btnMolt.Location = new System.Drawing.Point(177, 131);
            this.btnMolt.Name = "btnMolt";
            this.btnMolt.Size = new System.Drawing.Size(49, 37);
            this.btnMolt.TabIndex = 16;
            this.btnMolt.Text = "*";
            this.btnMolt.UseVisualStyleBackColor = true;
            this.btnMolt.Click += new System.EventHandler(this.btnMolt_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(177, 88);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(49, 37);
            this.btnDiv.TabIndex = 17;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnCanc
            // 
            this.btnCanc.Location = new System.Drawing.Point(177, 37);
            this.btnCanc.Name = "btnCanc";
            this.btnCanc.Size = new System.Drawing.Size(49, 37);
            this.btnCanc.TabIndex = 18;
            this.btnCanc.Text = "C";
            this.btnCanc.UseVisualStyleBackColor = true;
            this.btnCanc.Click += new System.EventHandler(this.btnCanc_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 271);
            this.Controls.Add(this.btnCanc);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMolt);
            this.Controls.Add(this.btnSottr);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnVirgola);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.labelRisultato);
            this.Controls.Add(this.textValue);
            this.Name = "CalculatorForm";
            this.Text = "MyCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textValue;
        private System.Windows.Forms.Label labelRisultato;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnVirgola;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSottr;
        private System.Windows.Forms.Button btnMolt;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnCanc;
    }
}

