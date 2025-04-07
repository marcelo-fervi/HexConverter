namespace HexConverter
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
            userInputTextBox = new TextBox();
            valuesTypeListBox = new ListBox();
            resultTextBox = new TextBox();
            errorLabel = new Label();
            SuspendLayout();
            // 
            // userInputTextBox
            // 
            userInputTextBox.Location = new Point(5, 47);
            userInputTextBox.Multiline = true;
            userInputTextBox.Name = "userInputTextBox";
            userInputTextBox.Size = new Size(290, 20);
            userInputTextBox.TabIndex = 0;
            userInputTextBox.Text = "0x00";
            userInputTextBox.TextChanged += userInputTextBox_TextChanged;
            // 
            // valuesTypeListBox
            // 
            valuesTypeListBox.FormattingEnabled = true;
            valuesTypeListBox.ItemHeight = 15;
            valuesTypeListBox.Items.AddRange(new object[] { "UINT32 (4 bytes)", "FLOAT (4 bytes)", "LONG (8 bytes)", "DOUBLE (8 bytes)" });
            valuesTypeListBox.Location = new Point(5, 7);
            valuesTypeListBox.Name = "valuesTypeListBox";
            valuesTypeListBox.Size = new Size(290, 34);
            valuesTypeListBox.TabIndex = 1;
            valuesTypeListBox.SelectedIndexChanged += valuesTypeListBox_SelectedIndexChanged;
            // 
            // resultTextBox
            // 
            resultTextBox.BackColor = SystemColors.Control;
            resultTextBox.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            resultTextBox.Location = new Point(5, 73);
            resultTextBox.Multiline = true;
            resultTextBox.Name = "resultTextBox";
            resultTextBox.ReadOnly = true;
            resultTextBox.Size = new Size(290, 33);
            resultTextBox.TabIndex = 2;
            resultTextBox.Text = "0";
            resultTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // errorLabel
            // 
            errorLabel.BackColor = Color.LightGray;
            errorLabel.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold);
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(5, 108);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(289, 17);
            errorLabel.TabIndex = 3;
            errorLabel.Text = "Ocorreu um erro ao efetuar os cálculos!";
            errorLabel.TextAlign = ContentAlignment.MiddleCenter;
            errorLabel.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 130);
            Controls.Add(errorLabel);
            Controls.Add(resultTextBox);
            Controls.Add(valuesTypeListBox);
            Controls.Add(userInputTextBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hex Converter";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userInputTextBox;
        private ListBox valuesTypeListBox;
        private TextBox resultTextBox;
        private Label errorLabel;
    }
}
