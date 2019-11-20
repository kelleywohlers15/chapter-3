namespace TestInteractiveGUI
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
            this.txtScore1 = new System.Windows.Forms.TextBox();
            this.txtScore2 = new System.Windows.Forms.TextBox();
            this.txtScore5 = new System.Windows.Forms.TextBox();
            this.txtScore3 = new System.Windows.Forms.TextBox();
            this.txtScore4 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtScore1
            // 
            this.txtScore1.Location = new System.Drawing.Point(156, 75);
            this.txtScore1.Name = "txtScore1";
            this.txtScore1.Size = new System.Drawing.Size(81, 20);
            this.txtScore1.TabIndex = 0;
            // 
            // txtScore2
            // 
            this.txtScore2.Location = new System.Drawing.Point(156, 113);
            this.txtScore2.Name = "txtScore2";
            this.txtScore2.Size = new System.Drawing.Size(81, 20);
            this.txtScore2.TabIndex = 1;
            // 
            // txtScore5
            // 
            this.txtScore5.Location = new System.Drawing.Point(156, 226);
            this.txtScore5.Name = "txtScore5";
            this.txtScore5.Size = new System.Drawing.Size(81, 20);
            this.txtScore5.TabIndex = 2;
            this.txtScore5.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtScore3
            // 
            this.txtScore3.Location = new System.Drawing.Point(156, 148);
            this.txtScore3.Name = "txtScore3";
            this.txtScore3.Size = new System.Drawing.Size(81, 20);
            this.txtScore3.TabIndex = 3;
            // 
            // txtScore4
            // 
            this.txtScore4.Location = new System.Drawing.Point(156, 187);
            this.txtScore4.Name = "txtScore4";
            this.txtScore4.Size = new System.Drawing.Size(81, 20);
            this.txtScore4.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(156, 263);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "button1";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Test Scores";
            // 
            // lblresult
            // 
            this.lblresult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblresult.Location = new System.Drawing.Point(138, 313);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(123, 40);
            this.lblresult.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Click To Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 450);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtScore4);
            this.Controls.Add(this.txtScore3);
            this.Controls.Add(this.txtScore5);
            this.Controls.Add(this.txtScore2);
            this.Controls.Add(this.txtScore1);
            this.Name = "Form1";
            this.Text = "testScores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtScore1;
        private System.Windows.Forms.TextBox txtScore2;
        private System.Windows.Forms.TextBox txtScore5;
        private System.Windows.Forms.TextBox txtScore3;
        private System.Windows.Forms.TextBox txtScore4;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Button button1;
    }
}

