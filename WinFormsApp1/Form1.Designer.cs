namespace WinFormsApp1
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
            label1 = new Label();
            numericUpDown = new NumericUpDown();
            button1 = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(306, 20);
            label1.TabIndex = 0;
            label1.Text = "Kérem adjon meg egy pozitív egész számot: ";
            label1.Click += label1_Click;
            // 
            // numericUpDown
            // 
            numericUpDown.Location = new Point(334, 21);
            numericUpDown.Name = "numericUpDown";
            numericUpDown.Size = new Size(88, 27);
            numericUpDown.TabIndex = 1;
            numericUpDown.ValueChanged += numericUpDown_ValueChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.Location = new Point(273, 85);
            button1.Name = "button1";
            button1.Size = new Size(276, 58);
            button1.TabIndex = 2;
            button1.Text = "Kattintson ide az eredményért";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(108, 201);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(590, 165);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Eredmény: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 70);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(numericUpDown);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Prime Numbers";
            ((System.ComponentModel.ISupportInitialize)numericUpDown).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numericUpDown;
        private Button button1;
        private GroupBox groupBox1;
        private Label label2;
    }
}
