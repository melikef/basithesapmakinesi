namespace WinFormsApp4
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
            groupBox1 = new GroupBox();
            number2MaskedTextBox2 = new MaskedTextBox();
            number1MaskedTextBox1 = new MaskedTextBox();
            groupBox2 = new GroupBox();
            operatorComboBox1 = new ComboBox();
            processButton = new Button();
            groupBox3 = new GroupBox();
            resultsListBox1 = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(number2MaskedTextBox2);
            groupBox1.Controls.Add(number1MaskedTextBox1);
            groupBox1.Location = new Point(30, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(438, 140);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "sayılar";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // number2MaskedTextBox2
            // 
            number2MaskedTextBox2.Location = new Point(25, 89);
            number2MaskedTextBox2.Mask = "000000";
            number2MaskedTextBox2.Name = "number2MaskedTextBox2";
            number2MaskedTextBox2.Size = new Size(391, 31);
            number2MaskedTextBox2.TabIndex = 1;
            number2MaskedTextBox2.ValidatingType = typeof(int);
            // 
            // number1MaskedTextBox1
            // 
            number1MaskedTextBox1.Location = new Point(25, 40);
            number1MaskedTextBox1.Mask = "000000";
            number1MaskedTextBox1.Name = "number1MaskedTextBox1";
            number1MaskedTextBox1.Size = new Size(391, 31);
            number1MaskedTextBox1.TabIndex = 0;
            number1MaskedTextBox1.ValidatingType = typeof(int);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(operatorComboBox1);
            groupBox2.Location = new Point(30, 173);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(438, 93);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "islem";
            // 
            // operatorComboBox1
            // 
            operatorComboBox1.FormattingEnabled = true;
            operatorComboBox1.Items.AddRange(new object[] { "+", "-", "*", "/" });
            operatorComboBox1.Location = new Point(25, 41);
            operatorComboBox1.Name = "operatorComboBox1";
            operatorComboBox1.Size = new Size(391, 33);
            operatorComboBox1.TabIndex = 0;
            // 
            // processButton
            // 
            processButton.Location = new Point(138, 283);
            processButton.Name = "processButton";
            processButton.Size = new Size(218, 46);
            processButton.TabIndex = 7;
            processButton.Text = "sonuc icin tıkla";
            processButton.UseVisualStyleBackColor = true;
            processButton.Click += processButton_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(resultsListBox1);
            groupBox3.Location = new Point(30, 357);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(447, 158);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "sonuc";
            // 
            // resultsListBox1
            // 
            resultsListBox1.FormattingEnabled = true;
            resultsListBox1.ItemHeight = 25;
            resultsListBox1.Location = new Point(25, 44);
            resultsListBox1.Name = "resultsListBox1";
            resultsListBox1.Size = new Size(391, 54);
            resultsListBox1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 540);
            Controls.Add(groupBox3);
            Controls.Add(processButton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private MaskedTextBox number1MaskedTextBox1;
        private MaskedTextBox number2MaskedTextBox2;
        private GroupBox groupBox2;
        private ComboBox operatorComboBox1;
        private Button processButton;
        private GroupBox groupBox3;
        private ListBox resultsListBox1;
    }
}
