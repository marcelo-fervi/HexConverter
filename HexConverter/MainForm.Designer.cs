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
            resultTextBox = new TextBox();
            errorLabel = new Label();
            valuesTypeComboBox = new ComboBox();
            SuspendLayout();
            // 
            // userInputTextBox
            // 
            userInputTextBox.Location = new Point(5, 34);
            userInputTextBox.Multiline = true;
            userInputTextBox.Name = "userInputTextBox";
            userInputTextBox.Size = new Size(290, 20);
            userInputTextBox.TabIndex = 0;
            userInputTextBox.Text = "0x00";
            userInputTextBox.TextChanged += userInputTextBox_TextChanged;
            // 
            // resultTextBox
            // 
            resultTextBox.BackColor = SystemColors.Control;
            resultTextBox.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            resultTextBox.Location = new Point(5, 60);
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
            errorLabel.Location = new Point(5, 95);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(289, 17);
            errorLabel.TabIndex = 3;
            errorLabel.Text = "Ocorreu um erro ao efetuar os cálculos!";
            errorLabel.TextAlign = ContentAlignment.MiddleCenter;
            errorLabel.Visible = false;
            // 
            // valuesTypeComboBox
            // 
            valuesTypeComboBox.FormattingEnabled = true;
            valuesTypeComboBox.Items.AddRange(new object[] { "UINT32 (4 bytes)", "FLOAT (4 bytes)", "LONG (8 bytes)", "DOUBLE (8 bytes)" });
            valuesTypeComboBox.Location = new Point(5, 5);
            valuesTypeComboBox.Name = "valuesTypeComboBox";
            valuesTypeComboBox.Size = new Size(290, 23);
            valuesTypeComboBox.TabIndex = 4;
            valuesTypeComboBox.SelectedIndexChanged += valuesTypeComboBox_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 117);
            Controls.Add(valuesTypeComboBox);
            Controls.Add(errorLabel);
            Controls.Add(resultTextBox);
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
        private TextBox resultTextBox;
        private Label errorLabel;
        private ComboBox valuesTypeComboBox;
    }
}
