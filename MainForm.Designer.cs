


namespace SplitTheDiff
{
    partial class MainForm
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
			resultLabel = new Label();
			numericUpDown1 = new NumericUpDown();
			numericUpDown2 = new NumericUpDown();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
			SuspendLayout();
			// 
			// resultLabel
			// 
			resultLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			resultLabel.AutoSize = true;
			resultLabel.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
			resultLabel.Location = new Point(357, 249);
			resultLabel.Name = "resultLabel";
			resultLabel.Size = new Size(88, 106);
			resultLabel.TabIndex = 3;
			resultLabel.Text = "0";
			resultLabel.TextAlign = ContentAlignment.TopRight;
			// 
			// numericUpDown1
			// 
			numericUpDown1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			numericUpDown1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
			numericUpDown1.Location = new Point(12, 12);
			numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
			numericUpDown1.Name = "numericUpDown1";
			numericUpDown1.Size = new Size(433, 114);
			numericUpDown1.TabIndex = 1;
			numericUpDown1.TextAlign = HorizontalAlignment.Right;
			numericUpDown1.ValueChanged += NumericUpDown_ValueChanged;
			numericUpDown1.KeyDown += NumericUpDown_KeyDown;
			numericUpDown1.KeyUp += NumericUpDown_KeyUp;
			// 
			// numericUpDown2
			// 
			numericUpDown2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			numericUpDown2.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
			numericUpDown2.Location = new Point(12, 132);
			numericUpDown2.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
			numericUpDown2.Name = "numericUpDown2";
			numericUpDown2.Size = new Size(433, 114);
			numericUpDown2.TabIndex = 2;
			numericUpDown2.TextAlign = HorizontalAlignment.Right;
			numericUpDown2.ValueChanged += NumericUpDown_ValueChanged;
			numericUpDown2.KeyDown += NumericUpDown_KeyDown;
			numericUpDown2.KeyUp += NumericUpDown_KeyUp;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(457, 364);
			Controls.Add(numericUpDown2);
			Controls.Add(numericUpDown1);
			Controls.Add(resultLabel);
			Name = "MainForm";
			Text = "Split The Diff";
			Load += MainForm_Load;
			((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label resultLabel;
		private NumericUpDown numericUpDown1;
		private NumericUpDown numericUpDown2;
	}
}
