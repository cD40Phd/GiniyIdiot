namespace GeniyIdiotWinFormsApp
{
    partial class WelcomedForm
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
            WelcomForm_TextWelcom_Label = new Label();
            WelcomForm_Text_Label = new Label();
            WelcomForm_UserName_TextBox = new TextBox();
            WelcomForm_Start_Button = new Button();
            SuspendLayout();
            // 
            // WelcomForm_TextWelcom_Label
            // 
            WelcomForm_TextWelcom_Label.AutoSize = true;
            WelcomForm_TextWelcom_Label.Location = new Point(14, 12);
            WelcomForm_TextWelcom_Label.Name = "WelcomForm_TextWelcom_Label";
            WelcomForm_TextWelcom_Label.Size = new Size(105, 20);
            WelcomForm_TextWelcom_Label.TabIndex = 0;
            WelcomForm_TextWelcom_Label.Text = "Здравствуйте!";
            // 
            // WelcomForm_Text_Label
            // 
            WelcomForm_Text_Label.AutoSize = true;
            WelcomForm_Text_Label.Location = new Point(14, 59);
            WelcomForm_Text_Label.Name = "WelcomForm_Text_Label";
            WelcomForm_Text_Label.Size = new Size(335, 60);
            WelcomForm_Text_Label.TabIndex = 1;
            WelcomForm_Text_Label.Text = "Пожалуйста, придумайте никнейм.\r\nОбязательно должны быть буквы или цифры.\r\nМинимум два символа, максимум двенадцать.";
            // 
            // WelcomForm_UserName_TextBox
            // 
            WelcomForm_UserName_TextBox.Location = new Point(14, 140);
            WelcomForm_UserName_TextBox.Margin = new Padding(3, 4, 3, 4);
            WelcomForm_UserName_TextBox.Name = "WelcomForm_UserName_TextBox";
            WelcomForm_UserName_TextBox.Size = new Size(231, 27);
            WelcomForm_UserName_TextBox.TabIndex = 2;
            // 
            // WelcomForm_Start_Button
            // 
            WelcomForm_Start_Button.Location = new Point(263, 139);
            WelcomForm_Start_Button.Margin = new Padding(3, 4, 3, 4);
            WelcomForm_Start_Button.Name = "WelcomForm_Start_Button";
            WelcomForm_Start_Button.Size = new Size(86, 31);
            WelcomForm_Start_Button.TabIndex = 3;
            WelcomForm_Start_Button.Text = "ok";
            WelcomForm_Start_Button.UseVisualStyleBackColor = true;
            WelcomForm_Start_Button.Click += startButton_Click;
            // 
            // WelcomedForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 197);
            Controls.Add(WelcomForm_Start_Button);
            Controls.Add(WelcomForm_UserName_TextBox);
            Controls.Add(WelcomForm_Text_Label);
            Controls.Add(WelcomForm_TextWelcom_Label);
            Margin = new Padding(3, 4, 3, 4);
            Name = "WelcomedForm";
            Text = "Гений Идиот";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WelcomForm_TextWelcom_Label;
        private Label WelcomForm_Text_Label;
        public TextBox WelcomForm_UserName_TextBox;
        private Button WelcomForm_Start_Button;
    }
}