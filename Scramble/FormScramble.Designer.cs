namespace Scramble

{
    partial class FormScramble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormScramble));
            label1 = new Label();
            buttonScramble = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 60);
            label1.Margin = new Padding(6, 3, 6, 3);
            label1.Name = "label1";
            label1.Size = new Size(174, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter your message here:";
            // 
            // buttonScramble
            // 
            buttonScramble.BackColor = SystemColors.ActiveCaption;
            buttonScramble.FlatStyle = FlatStyle.Popup;
            buttonScramble.ImageAlign = ContentAlignment.TopRight;
            buttonScramble.Location = new Point(70, 150);
            buttonScramble.Margin = new Padding(6, 3, 6, 3);
            buttonScramble.Name = "buttonScramble";
            buttonScramble.Size = new Size(80, 30);
            buttonScramble.TabIndex = 1;
            buttonScramble.Text = "Scramble";
            buttonScramble.UseVisualStyleBackColor = false;
            buttonScramble.Click += buttonScramble_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(70, 100);
            textBox1.Margin = new Padding(6, 3, 6, 3);
            textBox1.MaxLength = 20;
            textBox1.MinimumSize = new Size(180, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(223, 27);
            textBox1.TabIndex = 3;
            // 
            // FormScramble
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(382, 233);
            Controls.Add(textBox1);
            Controls.Add(buttonScramble);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(400, 280);
            MinimumSize = new Size(400, 280);
            Name = "FormScramble";
            Text = "Scramble";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonScramble;
        private TextBox textBox1;
    }
}
