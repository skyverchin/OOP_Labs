namespace Lab_1
{
    partial class TaskTest
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
            this.InputA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.InputB = new System.Windows.Forms.TextBox();
            this.InputC = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input A";
            // 
            // InputA
            // 
            this.InputA.Location = new System.Drawing.Point(106, 40);
            this.InputA.Name = "InputA";
            this.InputA.Size = new System.Drawing.Size(100, 22);
            this.InputA.TabIndex = 2;
            this.InputA.TextChanged += new System.EventHandler(this.InputA_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Input B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Input C";
            // 
            // InputB
            // 
            this.InputB.Location = new System.Drawing.Point(106, 79);
            this.InputB.Name = "InputB";
            this.InputB.Size = new System.Drawing.Size(100, 22);
            this.InputB.TabIndex = 5;
            this.InputB.TextChanged += new System.EventHandler(this.InputB_TextChanged);
            // 
            // InputC
            // 
            this.InputC.Location = new System.Drawing.Point(106, 121);
            this.InputC.Name = "InputC";
            this.InputC.Size = new System.Drawing.Size(100, 22);
            this.InputC.TabIndex = 6;
            this.InputC.TextChanged += new System.EventHandler(this.InputC_TextChanged);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(91, 173);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 7;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click_1);
            // 
            // TaskTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 250);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.InputC);
            this.Controls.Add(this.InputB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InputA);
            this.Controls.Add(this.label1);
            this.Name = "TaskTest";
            this.Text = "TaskTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InputB;
        private System.Windows.Forms.TextBox InputC;
        private System.Windows.Forms.Button SubmitButton;
    }
}

