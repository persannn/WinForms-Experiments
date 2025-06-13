namespace WinFormsTestApp
{
    partial class FormCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalculator));
            tableLayoutPanel = new TableLayoutPanel();
            buttonDelete = new Button();
            buttonEnter = new Button();
            labelDisplay = new Label();
            buttonMinus = new Button();
            buttonPlus = new Button();
            button9 = new Button();
            button6 = new Button();
            button3 = new Button();
            button2 = new Button();
            button5 = new Button();
            button8 = new Button();
            button4 = new Button();
            button7 = new Button();
            button1 = new Button();
            button0 = new Button();
            buttonDot = new Button();
            buttonMulti = new Button();
            buttonDiv = new Button();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 5;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel.Controls.Add(buttonDelete, 3, 0);
            tableLayoutPanel.Controls.Add(buttonEnter, 4, 0);
            tableLayoutPanel.Controls.Add(labelDisplay, 0, 0);
            tableLayoutPanel.Controls.Add(buttonMinus, 0, 2);
            tableLayoutPanel.Controls.Add(buttonPlus, 0, 1);
            tableLayoutPanel.Controls.Add(button9, 4, 1);
            tableLayoutPanel.Controls.Add(button6, 4, 2);
            tableLayoutPanel.Controls.Add(button3, 4, 3);
            tableLayoutPanel.Controls.Add(button2, 3, 3);
            tableLayoutPanel.Controls.Add(button5, 3, 2);
            tableLayoutPanel.Controls.Add(button8, 3, 1);
            tableLayoutPanel.Controls.Add(button4, 2, 2);
            tableLayoutPanel.Controls.Add(button7, 2, 1);
            tableLayoutPanel.Controls.Add(button1, 2, 3);
            tableLayoutPanel.Controls.Add(button0, 1, 3);
            tableLayoutPanel.Controls.Add(buttonDot, 0, 3);
            tableLayoutPanel.Controls.Add(buttonMulti, 1, 1);
            tableLayoutPanel.Controls.Add(buttonDiv, 1, 2);
            tableLayoutPanel.Location = new Point(6, 6);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 4;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel.Size = new Size(540, 720);
            tableLayoutPanel.TabIndex = 0;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonDelete.AutoSize = true;
            buttonDelete.BackColor = Color.IndianRed;
            buttonDelete.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDelete.Location = new Point(327, 3);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(102, 174);
            buttonDelete.TabIndex = 17;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonEnter
            // 
            buttonEnter.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonEnter.AutoSize = true;
            buttonEnter.BackColor = SystemColors.ActiveCaption;
            buttonEnter.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEnter.Location = new Point(435, 3);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(102, 174);
            buttonEnter.TabIndex = 16;
            buttonEnter.Text = "Enter";
            buttonEnter.UseVisualStyleBackColor = false;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // labelDisplay
            // 
            labelDisplay.AutoSize = true;
            labelDisplay.BackColor = Color.FromArgb(255, 255, 216);
            labelDisplay.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel.SetColumnSpan(labelDisplay, 3);
            labelDisplay.Dock = DockStyle.Fill;
            labelDisplay.FlatStyle = FlatStyle.Popup;
            labelDisplay.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDisplay.Location = new Point(3, 0);
            labelDisplay.MaximumSize = new Size(544, 174);
            labelDisplay.MinimumSize = new Size(318, 174);
            labelDisplay.Name = "labelDisplay";
            labelDisplay.Size = new Size(318, 174);
            labelDisplay.TabIndex = 0;
            labelDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonMinus
            // 
            buttonMinus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonMinus.AutoSize = true;
            buttonMinus.BackColor = SystemColors.ActiveCaption;
            buttonMinus.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonMinus.Location = new Point(3, 363);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(102, 174);
            buttonMinus.TabIndex = 11;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = false;
            buttonMinus.Click += button_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonPlus.AutoSize = true;
            buttonPlus.BackColor = SystemColors.ActiveCaption;
            buttonPlus.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonPlus.Location = new Point(3, 183);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(102, 174);
            buttonPlus.TabIndex = 12;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = false;
            buttonPlus.Click += button_Click;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button9.AutoSize = true;
            button9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.Location = new Point(435, 183);
            button9.Name = "button9";
            button9.Size = new Size(102, 174);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button6.AutoSize = true;
            button6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(435, 363);
            button6.Name = "button6";
            button6.Size = new Size(102, 174);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.AutoSize = true;
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(435, 543);
            button3.Name = "button3";
            button3.Size = new Size(102, 174);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.AutoSize = true;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(327, 543);
            button2.Name = "button2";
            button2.Size = new Size(102, 174);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button5.AutoSize = true;
            button5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(327, 363);
            button5.Name = "button5";
            button5.Size = new Size(102, 174);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button_Click;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button8.AutoSize = true;
            button8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.Location = new Point(327, 183);
            button8.Name = "button8";
            button8.Size = new Size(102, 174);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button4.AutoSize = true;
            button4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(219, 363);
            button4.Name = "button4";
            button4.Size = new Size(102, 174);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_Click;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button7.AutoSize = true;
            button7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(219, 183);
            button7.Name = "button7";
            button7.Size = new Size(102, 174);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.AutoSize = true;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(219, 543);
            button1.Name = "button1";
            button1.Size = new Size(102, 174);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_Click;
            // 
            // button0
            // 
            button0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button0.AutoSize = true;
            button0.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button0.Location = new Point(111, 543);
            button0.Name = "button0";
            button0.Size = new Size(102, 174);
            button0.TabIndex = 10;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button_Click;
            // 
            // buttonDot
            // 
            buttonDot.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonDot.AutoSize = true;
            buttonDot.BackColor = SystemColors.ActiveCaption;
            buttonDot.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDot.Location = new Point(3, 543);
            buttonDot.Name = "buttonDot";
            buttonDot.Size = new Size(102, 174);
            buttonDot.TabIndex = 13;
            buttonDot.Text = ".";
            buttonDot.UseVisualStyleBackColor = false;
            buttonDot.Click += button_Click;
            // 
            // buttonMulti
            // 
            buttonMulti.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonMulti.AutoSize = true;
            buttonMulti.BackColor = SystemColors.ActiveCaption;
            buttonMulti.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonMulti.Location = new Point(111, 183);
            buttonMulti.Name = "buttonMulti";
            buttonMulti.Size = new Size(102, 174);
            buttonMulti.TabIndex = 14;
            buttonMulti.Text = "*";
            buttonMulti.UseVisualStyleBackColor = false;
            buttonMulti.Click += button_Click;
            // 
            // buttonDiv
            // 
            buttonDiv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonDiv.AutoSize = true;
            buttonDiv.BackColor = SystemColors.ActiveCaption;
            buttonDiv.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDiv.Location = new Point(111, 363);
            buttonDiv.Name = "buttonDiv";
            buttonDiv.Size = new Size(102, 174);
            buttonDiv.TabIndex = 15;
            buttonDiv.Text = "/";
            buttonDiv.UseVisualStyleBackColor = false;
            buttonDiv.Click += button_Click;
            // 
            // FormCalculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(552, 733);
            Controls.Add(tableLayoutPanel);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormCalculator";
            Padding = new Padding(8);
            Text = "Calculator";
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }
        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private Label labelDisplay;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button0;
        private Button buttonMinus;
        private Button buttonPlus;
        private Button buttonDot;
        private Button buttonMulti;
        private Button buttonDiv;
        private Button buttonEnter;
        private Button buttonDelete;
    }
}