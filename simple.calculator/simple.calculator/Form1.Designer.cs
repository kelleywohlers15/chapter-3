namespace simple.calculator
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
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.btn_results = new System.Windows.Forms.Button();
            this.txt_entry1 = new System.Windows.Forms.TextBox();
            this.txt_entry2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter first number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter second number";
            // 
            // lbl_result
            // 
            this.lbl_result.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_result.Location = new System.Drawing.Point(236, 195);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(100, 23);
            this.lbl_result.TabIndex = 2;
            // 
            // btn_results
            // 
            this.btn_results.Location = new System.Drawing.Point(83, 178);
            this.btn_results.Name = "btn_results";
            this.btn_results.Size = new System.Drawing.Size(105, 46);
            this.btn_results.TabIndex = 3;
            this.btn_results.Text = "Click Me to Get Results";
            this.btn_results.UseVisualStyleBackColor = true;
            this.btn_results.Click += new System.EventHandler(this.btn_results_Click);
            // 
            // txt_entry1
            // 
            this.txt_entry1.Location = new System.Drawing.Point(218, 62);
            this.txt_entry1.Name = "txt_entry1";
            this.txt_entry1.Size = new System.Drawing.Size(100, 20);
            this.txt_entry1.TabIndex = 4;
            // 
            // txt_entry2
            // 
            this.txt_entry2.Location = new System.Drawing.Point(218, 126);
            this.txt_entry2.Name = "txt_entry2";
            this.txt_entry2.Size = new System.Drawing.Size(100, 20);
            this.txt_entry2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 492);
            this.Controls.Add(this.txt_entry2);
            this.Controls.Add(this.txt_entry1);
            this.Controls.Add(this.btn_results);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Button btn_results;
        private System.Windows.Forms.TextBox txt_entry1;
        private System.Windows.Forms.TextBox txt_entry2;
    }
}

