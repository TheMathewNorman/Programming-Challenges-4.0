namespace Count_Character_Occurence
{
    partial class Input
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.chkWhiteSpace = new System.Windows.Forms.CheckBox();
            this.chkPunctuation = new System.Windows.Forms.CheckBox();
            this.chkCaseInsensitive = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtInput.Location = new System.Drawing.Point(0, 0);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(566, 348);
            this.txtInput.TabIndex = 0;
            // 
            // btnCount
            // 
            this.btnCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCount.Location = new System.Drawing.Point(0, 380);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(566, 33);
            this.btnCount.TabIndex = 1;
            this.btnCount.Text = "Count Characters";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // chkWhiteSpace
            // 
            this.chkWhiteSpace.AutoSize = true;
            this.chkWhiteSpace.Location = new System.Drawing.Point(13, 355);
            this.chkWhiteSpace.Name = "chkWhiteSpace";
            this.chkWhiteSpace.Size = new System.Drawing.Size(107, 17);
            this.chkWhiteSpace.TabIndex = 2;
            this.chkWhiteSpace.Text = "Omit Whitespace";
            this.chkWhiteSpace.UseVisualStyleBackColor = true;
            // 
            // chkPunctuation
            // 
            this.chkPunctuation.AutoSize = true;
            this.chkPunctuation.Location = new System.Drawing.Point(126, 355);
            this.chkPunctuation.Name = "chkPunctuation";
            this.chkPunctuation.Size = new System.Drawing.Size(107, 17);
            this.chkPunctuation.TabIndex = 3;
            this.chkPunctuation.Text = "Omit Punctuation";
            this.chkPunctuation.UseVisualStyleBackColor = true;
            // 
            // chkCaseInsensitive
            // 
            this.chkCaseInsensitive.AutoSize = true;
            this.chkCaseInsensitive.Location = new System.Drawing.Point(239, 354);
            this.chkCaseInsensitive.Name = "chkCaseInsensitive";
            this.chkCaseInsensitive.Size = new System.Drawing.Size(103, 17);
            this.chkCaseInsensitive.TabIndex = 4;
            this.chkCaseInsensitive.Text = "Case Insensitive";
            this.chkCaseInsensitive.UseVisualStyleBackColor = true;
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 413);
            this.Controls.Add(this.chkCaseInsensitive);
            this.Controls.Add(this.chkPunctuation);
            this.Controls.Add(this.chkWhiteSpace);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.txtInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Input";
            this.Text = "Character Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.CheckBox chkWhiteSpace;
        private System.Windows.Forms.CheckBox chkPunctuation;
        private System.Windows.Forms.CheckBox chkCaseInsensitive;
    }
}

