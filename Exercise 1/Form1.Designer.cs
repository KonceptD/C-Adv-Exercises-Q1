namespace Exercise_1
{
    partial class Form1
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
            listBox = new ListBox();
            textBox = new TextBox();
            btnsave = new Button();
            SuspendLayout();
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(52, 66);
            listBox.Name = "listBox";
            listBox.Size = new Size(145, 214);
            listBox.TabIndex = 0;
            listBox.SelectedIndexChanged += listBox_SelectedIndexChanged;
            // 
            // textBox
            // 
            textBox.Location = new Point(255, 66);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(323, 177);
            textBox.TabIndex = 1;
            // 
            // btnsave
            // 
            btnsave.Location = new Point(377, 257);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(75, 23);
            btnsave.TabIndex = 2;
            btnsave.Text = "save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 450);
            Controls.Add(btnsave);
            Controls.Add(textBox);
            Controls.Add(listBox);
            Name = "Form1";
            Text = "My Week Days";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox;
        private TextBox textBox;
        private Button btnsave;
    }
}