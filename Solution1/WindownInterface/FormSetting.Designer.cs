namespace WindownInterface
{
    partial class FormSetting
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
            label2 = new Label();
            checkBox1 = new CheckBox();
            textBoxPlayer1 = new TextBox();
            textBoxPlayer2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            toggleRow = new NumericUpDown();
            toggleColumns = new NumericUpDown();
            buttonStart = new Button();
            ((System.ComponentModel.ISupportInitialize)toggleRow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)toggleColumns).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 11);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Players:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 44);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Player 1:";
            label2.Click += label2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(48, 73);
            checkBox1.Margin = new Padding(2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(70, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Player 2:";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // textBoxPlayer1
            // 
            textBoxPlayer1.Location = new Point(134, 44);
            textBoxPlayer1.Margin = new Padding(2);
            textBoxPlayer1.Name = "textBoxPlayer1";
            textBoxPlayer1.Size = new Size(106, 23);
            textBoxPlayer1.TabIndex = 3;
            textBoxPlayer1.TextChanged += textBox1_TextChanged;
            // 
            // textBoxPlayer2
            // 
            textBoxPlayer2.Enabled = false;
            textBoxPlayer2.Location = new Point(134, 73);
            textBoxPlayer2.Margin = new Padding(2);
            textBoxPlayer2.Name = "textBoxPlayer2";
            textBoxPlayer2.Size = new Size(106, 23);
            textBoxPlayer2.TabIndex = 4;
            textBoxPlayer2.Text = "[Computer]";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 127);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 5;
            label3.Text = "Board Size:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(153, 157);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 6;
            label4.Text = "Cols:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 157);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 7;
            label5.Text = "Rows:";
            // 
            // toggleRow
            // 
            toggleRow.Location = new Point(111, 157);
            toggleRow.Margin = new Padding(2);
            toggleRow.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            toggleRow.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            toggleRow.Name = "toggleRow";
            toggleRow.Size = new Size(38, 23);
            toggleRow.TabIndex = 8;
            toggleRow.Value = new decimal(new int[] { 4, 0, 0, 0 });
            toggleRow.ValueChanged += toglleRow_ValueChanged;
            // 
            // toggleColumns
            // 
            toggleColumns.Location = new Point(192, 157);
            toggleColumns.Margin = new Padding(2);
            toggleColumns.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            toggleColumns.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            toggleColumns.Name = "toggleColumns";
            toggleColumns.Size = new Size(48, 23);
            toggleColumns.TabIndex = 9;
            toggleColumns.Value = new decimal(new int[] { 4, 0, 0, 0 });
            toggleColumns.ValueChanged += toggleColumns_ValueChanged;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(48, 191);
            buttonStart.Margin = new Padding(2);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(192, 20);
            buttonStart.TabIndex = 10;
            buttonStart.Text = "Start!";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // FormSetting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(buttonStart);
            Controls.Add(toggleColumns);
            Controls.Add(toggleRow);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxPlayer2);
            Controls.Add(textBoxPlayer1);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "FormSetting";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)toggleRow).EndInit();
            ((System.ComponentModel.ISupportInitialize)toggleColumns).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private CheckBox checkBox1;
        private TextBox textBoxPlayer1;
        private TextBox textBoxPlayer2;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown toggleRow;
        private NumericUpDown toggleColumns;
        private Button buttonStart;
    }
}
