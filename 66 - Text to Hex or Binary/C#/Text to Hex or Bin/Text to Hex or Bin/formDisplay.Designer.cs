namespace Text_to_Hex_or_Bin
{
    partial class formDisplay
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
            this.btnToHex = new System.Windows.Forms.Button();
            this.btnToBinary = new System.Windows.Forms.Button();
            this.btnFromHex = new System.Windows.Forms.Button();
            this.btnFromBinary = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 12);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(569, 86);
            this.txtInput.TabIndex = 0;
            // 
            // btnToHex
            // 
            this.btnToHex.Location = new System.Drawing.Point(12, 104);
            this.btnToHex.Name = "btnToHex";
            this.btnToHex.Size = new System.Drawing.Size(146, 23);
            this.btnToHex.TabIndex = 2;
            this.btnToHex.Text = "Convert to Hexadecimal";
            this.btnToHex.UseVisualStyleBackColor = true;
            // 
            // btnToBinary
            // 
            this.btnToBinary.Location = new System.Drawing.Point(164, 104);
            this.btnToBinary.Name = "btnToBinary";
            this.btnToBinary.Size = new System.Drawing.Size(115, 23);
            this.btnToBinary.TabIndex = 3;
            this.btnToBinary.Text = "Convert to Binary";
            this.btnToBinary.UseVisualStyleBackColor = true;
            this.btnToBinary.Click += new System.EventHandler(this.btnToBinary_Click);
            // 
            // btnFromHex
            // 
            this.btnFromHex.Location = new System.Drawing.Point(320, 104);
            this.btnFromHex.Name = "btnFromHex";
            this.btnFromHex.Size = new System.Drawing.Size(144, 23);
            this.btnFromHex.TabIndex = 4;
            this.btnFromHex.Text = "Convert from Hexadecimal";
            this.btnFromHex.UseVisualStyleBackColor = true;
            // 
            // btnFromBinary
            // 
            this.btnFromBinary.Location = new System.Drawing.Point(470, 104);
            this.btnFromBinary.Name = "btnFromBinary";
            this.btnFromBinary.Size = new System.Drawing.Size(111, 23);
            this.btnFromBinary.TabIndex = 5;
            this.btnFromBinary.Text = "Convert from Binary";
            this.btnFromBinary.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 133);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(569, 152);
            this.txtResult.TabIndex = 6;
            // 
            // formDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 297);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnFromBinary);
            this.Controls.Add(this.btnFromHex);
            this.Controls.Add(this.btnToBinary);
            this.Controls.Add(this.btnToHex);
            this.Controls.Add(this.txtInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formDisplay";
            this.Text = "Text to Hexadecimal or Binary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnToHex;
        private System.Windows.Forms.Button btnToBinary;
        private System.Windows.Forms.Button btnFromHex;
        private System.Windows.Forms.Button btnFromBinary;
        private System.Windows.Forms.TextBox txtResult;
    }
}

