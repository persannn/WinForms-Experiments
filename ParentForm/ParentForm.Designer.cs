using Scramble;
using Calculator;

namespace ParentForm
{
    partial class ParentForm
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
            buttonCalculator = new Button();
            buttonScramble = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            labelMenu = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonCalculator
            // 
            buttonCalculator.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonCalculator.AutoSize = true;
            buttonCalculator.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonCalculator.BackColor = SystemColors.ButtonFace;
            buttonCalculator.Cursor = Cursors.Hand;
            buttonCalculator.Font = new Font("Sitka Small", 9F);
            buttonCalculator.Location = new Point(3, 35);
            buttonCalculator.Name = "buttonCalculator";
            buttonCalculator.Padding = new Padding(1);
            buttonCalculator.Size = new Size(204, 58);
            buttonCalculator.TabIndex = 0;
            buttonCalculator.Text = "Calculator";
            buttonCalculator.UseVisualStyleBackColor = false;
            buttonCalculator.Click += buttonCalculator_Click;
            // 
            // buttonScramble
            // 
            buttonScramble.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonScramble.AutoSize = true;
            buttonScramble.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonScramble.BackColor = SystemColors.ButtonFace;
            buttonScramble.Cursor = Cursors.Hand;
            buttonScramble.Font = new Font("Sitka Small", 9F);
            buttonScramble.Location = new Point(213, 35);
            buttonScramble.Name = "buttonScramble";
            buttonScramble.Padding = new Padding(1);
            buttonScramble.Size = new Size(204, 58);
            buttonScramble.TabIndex = 1;
            buttonScramble.Text = "Scramble";
            buttonScramble.UseVisualStyleBackColor = false;
            buttonScramble.Click += buttonScramble_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(buttonCalculator, 0, 1);
            tableLayoutPanel1.Controls.Add(buttonScramble, 1, 1);
            tableLayoutPanel1.Controls.Add(labelMenu, 0, 0);
            tableLayoutPanel1.Location = new Point(150, 100);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Size = new Size(420, 160);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // labelMenu
            // 
            labelMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelMenu.AutoSize = true;
            labelMenu.BackColor = SystemColors.HighlightText;
            tableLayoutPanel1.SetColumnSpan(labelMenu, 2);
            labelMenu.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelMenu.Location = new Point(3, 0);
            labelMenu.Name = "labelMenu";
            labelMenu.Size = new Size(414, 32);
            labelMenu.TabIndex = 2;
            labelMenu.Text = "Menu";
            labelMenu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ParentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(702, 293);
            Controls.Add(tableLayoutPanel1);
            Name = "ParentForm";
            Text = "Parent Form";
            Load += ParentForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCalculator;
        private Button buttonScramble;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelMenu;
        private FormCalculator Calculator;
        private FormScramble Scramble;
    }
}
