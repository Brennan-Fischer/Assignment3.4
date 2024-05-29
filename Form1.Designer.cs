namespace Assignment3._4
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
            AddButton = new Button();
            StrengthBox = new TextBox();
            TemperatureBox = new TextBox();
            SizeBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            CoffeeListBox = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CoffeeListBox).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(AddButton);
            groupBox1.Controls.Add(StrengthBox);
            groupBox1.Controls.Add(TemperatureBox);
            groupBox1.Controls.Add(SizeBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(54, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(334, 333);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(165, 231);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 6;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // StrengthBox
            // 
            StrengthBox.Location = new Point(162, 162);
            StrengthBox.Name = "StrengthBox";
            StrengthBox.Size = new Size(125, 27);
            StrengthBox.TabIndex = 5;
            // 
            // TemperatureBox
            // 
            TemperatureBox.Location = new Point(162, 105);
            TemperatureBox.Name = "TemperatureBox";
            TemperatureBox.Size = new Size(125, 27);
            TemperatureBox.TabIndex = 4;
            // 
            // SizeBox
            // 
            SizeBox.Location = new Point(162, 55);
            SizeBox.Name = "SizeBox";
            SizeBox.Size = new Size(125, 27);
            SizeBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 169);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 2;
            label3.Text = "Strength";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 112);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 1;
            label2.Text = "Temperature";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 55);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 0;
            label1.Text = "Size";
            // 
            // CoffeeListBox
            // 
            CoffeeListBox.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CoffeeListBox.Location = new Point(428, 65);
            CoffeeListBox.Name = "CoffeeListBox";
            CoffeeListBox.RowHeadersWidth = 51;
            CoffeeListBox.Size = new Size(459, 272);
            CoffeeListBox.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 463);
            Controls.Add(CoffeeListBox);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CoffeeListBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button AddButton;
        private TextBox StrengthBox;
        private TextBox TemperatureBox;
        private TextBox SizeBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView CoffeeListBox;
    }
}
