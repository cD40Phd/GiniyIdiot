namespace GeniyIdiotWinFormsApp
{
    partial class ResultForm
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
            ResultForm_Result_DataGridView = new DataGridView();
            dateTimeUserTest = new DataGridViewTextBoxColumn();
            NameColum = new DataGridViewTextBoxColumn();
            answerCount = new DataGridViewTextBoxColumn();
            diagnos = new DataGridViewTextBoxColumn();
            timeTest = new DataGridViewTextBoxColumn();
            averageAllWaitingUserAnswered = new DataGridViewTextBoxColumn();
            deleteUser_ResultForm_button = new Button();
            ((System.ComponentModel.ISupportInitialize)ResultForm_Result_DataGridView).BeginInit();
            SuspendLayout();
            // 
            // ResultForm_Result_DataGridView
            // 
            ResultForm_Result_DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ResultForm_Result_DataGridView.Columns.AddRange(new DataGridViewColumn[] { dateTimeUserTest, NameColum, answerCount, diagnos, timeTest, averageAllWaitingUserAnswered });
            ResultForm_Result_DataGridView.Location = new Point(14, 12);
            ResultForm_Result_DataGridView.MultiSelect = false;
            ResultForm_Result_DataGridView.Name = "ResultForm_Result_DataGridView";
            ResultForm_Result_DataGridView.RowHeadersWidth = 51;
            ResultForm_Result_DataGridView.RowTemplate.Height = 29;
            ResultForm_Result_DataGridView.Size = new Size(877, 447);
            ResultForm_Result_DataGridView.TabIndex = 0;
            ResultForm_Result_DataGridView.KeyDown += ResultForm_Result_DataGridView_KeyDown;
            // 
            // dateTimeUserTest
            // 
            dateTimeUserTest.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dateTimeUserTest.HeaderText = "Дата прохождения теста";
            dateTimeUserTest.MinimumWidth = 20;
            dateTimeUserTest.Name = "dateTimeUserTest";
            dateTimeUserTest.Width = 197;
            // 
            // NameColum
            // 
            NameColum.HeaderText = "Имя";
            NameColum.MinimumWidth = 6;
            NameColum.Name = "NameColum";
            NameColum.ReadOnly = true;
            NameColum.Width = 125;
            // 
            // answerCount
            // 
            answerCount.HeaderText = "Кол-во ответов";
            answerCount.MinimumWidth = 6;
            answerCount.Name = "answerCount";
            answerCount.ReadOnly = true;
            answerCount.Width = 125;
            // 
            // diagnos
            // 
            diagnos.HeaderText = "Диагноз";
            diagnos.MinimumWidth = 6;
            diagnos.Name = "diagnos";
            diagnos.ReadOnly = true;
            diagnos.Width = 125;
            // 
            // timeTest
            // 
            timeTest.HeaderText = "Длительность теста";
            timeTest.MinimumWidth = 6;
            timeTest.Name = "timeTest";
            timeTest.Width = 125;
            // 
            // averageAllWaitingUserAnswered
            // 
            averageAllWaitingUserAnswered.HeaderText = "Среднее время теста пользователя";
            averageAllWaitingUserAnswered.MinimumWidth = 6;
            averageAllWaitingUserAnswered.Name = "averageAllWaitingUserAnswered";
            averageAllWaitingUserAnswered.Width = 125;
            // 
            // deleteUser_ResultForm_button
            // 
            deleteUser_ResultForm_button.Location = new Point(797, 477);
            deleteUser_ResultForm_button.Name = "deleteUser_ResultForm_button";
            deleteUser_ResultForm_button.Size = new Size(94, 29);
            deleteUser_ResultForm_button.TabIndex = 1;
            deleteUser_ResultForm_button.Text = "удалить";
            deleteUser_ResultForm_button.UseVisualStyleBackColor = true;
            deleteUser_ResultForm_button.Click += deleteUser_ResultForm_button_Click;
            // 
            // ResultForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 518);
            Controls.Add(deleteUser_ResultForm_button);
            Controls.Add(ResultForm_Result_DataGridView);
            Name = "ResultForm";
            Text = "Гений Идиот - результаты";
            Load += ResultForm_Load;
            ((System.ComponentModel.ISupportInitialize)ResultForm_Result_DataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ResultForm_Result_DataGridView;
        private Button deleteUser_ResultForm_button;
        private DataGridViewTextBoxColumn dateTimeUserTest;
        private DataGridViewTextBoxColumn NameColum;
        private DataGridViewTextBoxColumn answerCount;
        private DataGridViewTextBoxColumn diagnos;
        private DataGridViewTextBoxColumn timeTest;
        private DataGridViewTextBoxColumn averageAllWaitingUserAnswered;
    }
}