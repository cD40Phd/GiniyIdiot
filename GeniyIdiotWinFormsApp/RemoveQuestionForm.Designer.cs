namespace GeniyIdiotWinFormsApp
{
    partial class RemoveQuestionForm
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
            ListQuestion_Questions_ListBox = new ListBox();
            ListQuestionsForms_questionDelete_button = new Button();
            ListQuestionForm_clueText_label = new Label();
            SuspendLayout();
            // 
            // ListQuestion_Questions_ListBox
            // 
            ListQuestion_Questions_ListBox.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ListQuestion_Questions_ListBox.FormattingEnabled = true;
            ListQuestion_Questions_ListBox.ItemHeight = 17;
            ListQuestion_Questions_ListBox.Location = new Point(14, 13);
            ListQuestion_Questions_ListBox.Name = "ListQuestion_Questions_ListBox";
            ListQuestion_Questions_ListBox.Size = new Size(769, 191);
            ListQuestion_Questions_ListBox.TabIndex = 0;
            ListQuestion_Questions_ListBox.SelectedIndexChanged += ListQuestion_Questions_ListBox_SelectedIndexChanged;
            ListQuestion_Questions_ListBox.KeyDown += ListQuestion_Questions_ListBox_KeyDown_1;
            // 
            // ListQuestionsForms_questionDelete_button
            // 
            ListQuestionsForms_questionDelete_button.Enabled = false;
            ListQuestionsForms_questionDelete_button.Location = new Point(14, 219);
            ListQuestionsForms_questionDelete_button.Name = "ListQuestionsForms_questionDelete_button";
            ListQuestionsForms_questionDelete_button.Size = new Size(106, 30);
            ListQuestionsForms_questionDelete_button.TabIndex = 1;
            ListQuestionsForms_questionDelete_button.Text = "удалить";
            ListQuestionsForms_questionDelete_button.UseVisualStyleBackColor = true;
            ListQuestionsForms_questionDelete_button.Click += ListQuestionsForms_questionDelete_button_Click;
            // 
            // ListQuestionForm_clueText_label
            // 
            ListQuestionForm_clueText_label.AutoSize = true;
            ListQuestionForm_clueText_label.Location = new Point(132, 223);
            ListQuestionForm_clueText_label.Name = "ListQuestionForm_clueText_label";
            ListQuestionForm_clueText_label.Size = new Size(233, 21);
            ListQuestionForm_clueText_label.TabIndex = 2;
            ListQuestionForm_clueText_label.Text = "для удаления выделите вопрос";
            // 
            // RemoveQuestionForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 266);
            Controls.Add(ListQuestionForm_clueText_label);
            Controls.Add(ListQuestionsForms_questionDelete_button);
            Controls.Add(ListQuestion_Questions_ListBox);
            Name = "RemoveQuestionForm";
            Text = "Гений Идиот - удаление вопроса";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ListQuestion_Questions_ListBox;
        private Button ListQuestionsForms_questionDelete_button;
        private Label ListQuestionForm_clueText_label;
    }
}