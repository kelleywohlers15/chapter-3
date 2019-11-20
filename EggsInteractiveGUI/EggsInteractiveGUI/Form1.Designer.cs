namespace EggsInteractiveGUI
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
            this.txtEntry1 = new System.Windows.Forms.TextBox();
            this.txtEntry2 = new System.Windows.Forms.TextBox();
            this.txtEntry3 = new System.Windows.Forms.TextBox();
            this.txtEntry4 = new System.Windows.Forms.TextBox();
            this.txtEntry5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnResult = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEntry1
            // 
            this.txtEntry1.Location = new System.Drawing.Point(70, 71);
            this.txtEntry1.Name = "txtEntry1";
            this.txtEntry1.Size = new System.Drawing.Size(70, 20);
            this.txtEntry1.TabIndex = 0;
            // 
            // txtEntry2
            // 
            this.txtEntry2.Location = new System.Drawing.Point(178, 71);
            this.txtEntry2.Name = "txtEntry2";
            this.txtEntry2.Size = new System.Drawing.Size(70, 20);
            this.txtEntry2.TabIndex = 1;
            // 
            // txtEntry3
            // 
            this.txtEntry3.Location = new System.Drawing.Point(277, 71);
            this.txtEntry3.Name = "txtEntry3";
            this.txtEntry3.Size = new System.Drawing.Size(70, 20);
            this.txtEntry3.TabIndex = 2;
            // 
            // txtEntry4
            // 
            this.txtEntry4.Location = new System.Drawing.Point(70, 135);
            this.txtEntry4.Name = "txtEntry4";
            this.txtEntry4.Size = new System.Drawing.Size(70, 20);
            this.txtEntry4.TabIndex = 3;
            // 
            // txtEntry5
            // 
            this.txtEntry5.Location = new System.Drawing.Point(178, 135);
            this.txtEntry5.Name = "txtEntry5";
            this.txtEntry5.Size = new System.Drawing.Size(70, 20);
            this.txtEntry5.TabIndex = 4;
            this.txtEntry5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Eggs Produced by each of 5 chickens";
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(147, 205);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(114, 23);
            this.btnResult.TabIndex = 6;
            this.btnResult.Text = "Click to calculate";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_result.Location = new System.Drawing.Point(108, 270);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(201, 52);
            this.lbl_result.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 450);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEntry5);
            this.Controls.Add(this.txtEntry4);
            this.Controls.Add(this.txtEntry3);
            this.Controls.Add(this.txtEntry2);
            this.Controls.Add(this.txtEntry1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEntry1;
        private System.Windows.Forms.TextBox txtEntry2;
        private System.Windows.Forms.TextBox txtEntry3;
        private System.Windows.Forms.TextBox txtEntry4;
        private System.Windows.Forms.TextBox txtEntry5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Label lbl_result;
    }
}

