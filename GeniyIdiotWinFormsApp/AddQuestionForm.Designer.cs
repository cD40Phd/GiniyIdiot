namespace GeniyIdiotWinFormsApp
{
    partial class AddQuestionForm
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
            AddQuestionForm_clueTExt_label = new Label();
            AddQuestionForm_questionTextNew_textBox = new TextBox();
            AddQuestionForm_answerNumer_textBox = new TextBox();
            AddQuestionForm_questionAdd_button_button = new Button();
            SuspendLayout();
            // 
            // AddQuestionForm_clueTExt_label
            // 
            AddQuestionForm_clueTExt_label.AutoSize = true;
            AddQuestionForm_clueTExt_label.Location = new Point(24, 14);
            AddQuestionForm_clueTExt_label.Name = "AddQuestionForm_clueTExt_label";
            AddQuestionForm_clueTExt_label.Size = new Size(269, 20);
            AddQuestionForm_clueTExt_label.TabIndex = 0;
            AddQuestionForm_clueTExt_label.Text = "Заполните поля и нажмите добавить";
            // 
            // AddQuestionForm_questionTextNew_textBox
            // 
            AddQuestionForm_questionTextNew_textBox.Location = new Point(24, 37);
            AddQuestionForm_questionTextNew_textBox.Name = "AddQuestionForm_questionTextNew_textBox";
            AddQuestionForm_questionTextNew_textBox.Size = new Size(512, 27);
            AddQuestionForm_questionTextNew_textBox.TabIndex = 1;
            AddQuestionForm_questionTextNew_textBox.Text = "Ваш вопрос";
            AddQuestionForm_questionTextNew_textBox.TextChanged += AddQuestionForm_questionTextNew_textBox_TextChanged;
            // 
            // AddQuestionForm_answerNumer_textBox
            // 
            AddQuestionForm_answerNumer_textBox.Location = new Point(542, 37);
            AddQuestionForm_answerNumer_textBox.Name = "AddQuestionForm_answerNumer_textBox";
            AddQuestionForm_answerNumer_textBox.Size = new Size(125, 27);
            AddQuestionForm_answerNumer_textBox.TabIndex = 2;
            AddQuestionForm_answerNumer_textBox.Text = "целое число";
            AddQuestionForm_answerNumer_textBox.TextChanged += AddQuestionForm_answerNumer_textBox_TextChanged;
            // 
            // AddQuestionForm_questionAdd_button_button
            // 
            AddQuestionForm_questionAdd_button_button.Location = new Point(683, 37);
            AddQuestionForm_questionAdd_button_button.Name = "AddQuestionForm_questionAdd_button_button";
            AddQuestionForm_questionAdd_button_button.Size = new Size(94, 29);
            AddQuestionForm_questionAdd_button_button.TabIndex = 3;
            AddQuestionForm_questionAdd_button_button.Text = "добавить";
            AddQuestionForm_questionAdd_button_button.UseVisualStyleBackColor = true;
            AddQuestionForm_questionAdd_button_button.Click += AddQuestionForm_questionAdd_button_button_Click;
            // 
            // AddQuestionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 91);
            Controls.Add(AddQuestionForm_questionAdd_button_button);
            Controls.Add(AddQuestionForm_answerNumer_textBox);
            Controls.Add(AddQuestionForm_questionTextNew_textBox);
            Controls.Add(AddQuestionForm_clueTExt_label);
            Name = "AddQuestionForm";
            Text = "Гений Идиот - добавление вопроса";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AddQuestionForm_clueTExt_label;
        private TextBox AddQuestionForm_questionTextNew_textBox;
        private TextBox AddQuestionForm_answerNumer_textBox;
        private Button AddQuestionForm_questionAdd_button_button;
    }
}