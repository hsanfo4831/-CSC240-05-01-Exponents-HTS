namespace Exponents
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
            this.UxInputTextBox = new System.Windows.Forms.TextBox();
            this.UxInputLabel1 = new System.Windows.Forms.Label();
            this.xOutputLabel = new System.Windows.Forms.Label();
            this.UxGoButton = new System.Windows.Forms.Button();
            this.UxResetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UxInputTextBox
            // 
            this.UxInputTextBox.Location = new System.Drawing.Point(77, 43);
            this.UxInputTextBox.Name = "UxInputTextBox";
            this.UxInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.UxInputTextBox.TabIndex = 0;
            // 
            // UxInputLabel1
            // 
            this.UxInputLabel1.AutoSize = true;
            this.UxInputLabel1.ForeColor = System.Drawing.Color.White;
            this.UxInputLabel1.Location = new System.Drawing.Point(92, 27);
            this.UxInputLabel1.Name = "UxInputLabel1";
            this.UxInputLabel1.Size = new System.Drawing.Size(85, 13);
            this.UxInputLabel1.TabIndex = 3;
            this.UxInputLabel1.Text = "Enter an integer:";
            // 
            // xOutputLabel
            // 
            this.xOutputLabel.AutoSize = true;
            this.xOutputLabel.Location = new System.Drawing.Point(102, 181);
            this.xOutputLabel.Name = "xOutputLabel";
            this.xOutputLabel.Size = new System.Drawing.Size(0, 13);
            this.xOutputLabel.TabIndex = 4;
            this.xOutputLabel.Visible = false;
            // 
            // UxGoButton
            // 
            this.UxGoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UxGoButton.ForeColor = System.Drawing.Color.White;
            this.UxGoButton.Location = new System.Drawing.Point(95, 94);
            this.UxGoButton.Name = "UxGoButton";
            this.UxGoButton.Size = new System.Drawing.Size(75, 67);
            this.UxGoButton.TabIndex = 6;
            this.UxGoButton.Text = "Go!";
            this.UxGoButton.UseVisualStyleBackColor = true;
            this.UxGoButton.Click += new System.EventHandler(this.xGoButton_Click);
            // 
            // UxResetButton
            // 
            this.UxResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UxResetButton.ForeColor = System.Drawing.Color.White;
            this.UxResetButton.Location = new System.Drawing.Point(95, 208);
            this.UxResetButton.Name = "UxResetButton";
            this.UxResetButton.Size = new System.Drawing.Size(75, 23);
            this.UxResetButton.TabIndex = 7;
            this.UxResetButton.Text = "Reset";
            this.UxResetButton.UseVisualStyleBackColor = true;
            this.UxResetButton.Click += new System.EventHandler(this.xResetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.UxResetButton);
            this.Controls.Add(this.UxGoButton);
            this.Controls.Add(this.xOutputLabel);
            this.Controls.Add(this.UxInputLabel1);
            this.Controls.Add(this.UxInputTextBox);
            this.Name = "Form1";
            this.Text = "Exponents Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UxInputTextBox;
        private System.Windows.Forms.Label UxInputLabel1;
        private System.Windows.Forms.Label xOutputLabel;
        private System.Windows.Forms.Button UxGoButton;
        private System.Windows.Forms.Button UxResetButton;
    }
}

