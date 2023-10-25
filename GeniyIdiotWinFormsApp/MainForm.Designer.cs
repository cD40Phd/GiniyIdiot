namespace GeniyIdiotWinFormsApp
{
    partial class mainForm
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
            components = new System.ComponentModel.Container();
            MainForm_NumberQuestion_label = new Label();
            MainForm_Question_Textlabel = new Label();
            MainForm_AnswerQuestion_TextBox = new TextBox();
            MainForm_NextQuestion_button = new Button();
            menuStrip1 = new MenuStrip();
            MainForm_ToolStrip_MenuItem = new ToolStripMenuItem();
            MainForm_Result_ToolStripMenuItem = new ToolStripMenuItem();
            MainForm_Reset_ToolStripMenuItem = new ToolStripMenuItem();
            MainForm_Exit_ToolStripMenuItem = new ToolStripMenuItem();
            вопросыToolStripMenuItem = new ToolStripMenuItem();
            добавитьВопосToolStripMenuItem = new ToolStripMenuItem();
            удалитьВопросToolStripMenuItem = new ToolStripMenuItem();
            limitTime_MainForm_timer = new System.Windows.Forms.Timer(components);
            visualTimer_MainForm_label = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // MainForm_NumberQuestion_label
            // 
            MainForm_NumberQuestion_label.AutoSize = true;
            MainForm_NumberQuestion_label.Location = new Point(16, 51);
            MainForm_NumberQuestion_label.Name = "MainForm_NumberQuestion_label";
            MainForm_NumberQuestion_label.Size = new Size(125, 21);
            MainForm_NumberQuestion_label.TabIndex = 0;
            MainForm_NumberQuestion_label.Text = "Вопрос номер 1";
            // 
            // MainForm_Question_Textlabel
            // 
            MainForm_Question_Textlabel.AutoSize = true;
            MainForm_Question_Textlabel.Location = new Point(16, 93);
            MainForm_Question_Textlabel.Name = "MainForm_Question_Textlabel";
            MainForm_Question_Textlabel.Size = new Size(146, 21);
            MainForm_Question_Textlabel.TabIndex = 1;
            MainForm_Question_Textlabel.Text = "Здесь текст вопоса";
            // 
            // MainForm_AnswerQuestion_TextBox
            // 
            MainForm_AnswerQuestion_TextBox.Location = new Point(16, 130);
            MainForm_AnswerQuestion_TextBox.Margin = new Padding(3, 4, 3, 4);
            MainForm_AnswerQuestion_TextBox.Name = "MainForm_AnswerQuestion_TextBox";
            MainForm_AnswerQuestion_TextBox.Size = new Size(60, 29);
            MainForm_AnswerQuestion_TextBox.TabIndex = 2;
            // 
            // MainForm_NextQuestion_button
            // 
            MainForm_NextQuestion_button.Location = new Point(16, 182);
            MainForm_NextQuestion_button.Margin = new Padding(3, 4, 3, 4);
            MainForm_NextQuestion_button.Name = "MainForm_NextQuestion_button";
            MainForm_NextQuestion_button.Size = new Size(97, 33);
            MainForm_NextQuestion_button.TabIndex = 3;
            MainForm_NextQuestion_button.Text = "далее";
            MainForm_NextQuestion_button.UseVisualStyleBackColor = true;
            MainForm_NextQuestion_button.Click += nextbutton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { MainForm_ToolStrip_MenuItem, вопросыToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1028, 29);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // MainForm_ToolStrip_MenuItem
            // 
            MainForm_ToolStrip_MenuItem.DropDownItems.AddRange(new ToolStripItem[] { MainForm_Result_ToolStripMenuItem, MainForm_Reset_ToolStripMenuItem, MainForm_Exit_ToolStripMenuItem });
            MainForm_ToolStrip_MenuItem.Name = "MainForm_ToolStrip_MenuItem";
            MainForm_ToolStrip_MenuItem.Size = new Size(61, 25);
            MainForm_ToolStrip_MenuItem.Text = "Файл";
            // 
            // MainForm_Result_ToolStripMenuItem
            // 
            MainForm_Result_ToolStripMenuItem.Name = "MainForm_Result_ToolStripMenuItem";
            MainForm_Result_ToolStripMenuItem.Size = new Size(164, 26);
            MainForm_Result_ToolStripMenuItem.Text = "Результат";
            MainForm_Result_ToolStripMenuItem.Click += результатToolStripMenuItem_Click;
            // 
            // MainForm_Reset_ToolStripMenuItem
            // 
            MainForm_Reset_ToolStripMenuItem.Name = "MainForm_Reset_ToolStripMenuItem";
            MainForm_Reset_ToolStripMenuItem.Size = new Size(164, 26);
            MainForm_Reset_ToolStripMenuItem.Text = "Рестарт";
            MainForm_Reset_ToolStripMenuItem.Click += рестартToolStripMenuItem_Click;
            // 
            // MainForm_Exit_ToolStripMenuItem
            // 
            MainForm_Exit_ToolStripMenuItem.Name = "MainForm_Exit_ToolStripMenuItem";
            MainForm_Exit_ToolStripMenuItem.Size = new Size(164, 26);
            MainForm_Exit_ToolStripMenuItem.Text = "Выход";
            MainForm_Exit_ToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // вопросыToolStripMenuItem
            // 
            вопросыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { добавитьВопосToolStripMenuItem, удалитьВопросToolStripMenuItem });
            вопросыToolStripMenuItem.Name = "вопросыToolStripMenuItem";
            вопросыToolStripMenuItem.Size = new Size(87, 25);
            вопросыToolStripMenuItem.Text = "Вопросы";
            // 
            // добавитьВопосToolStripMenuItem
            // 
            добавитьВопосToolStripMenuItem.Name = "добавитьВопосToolStripMenuItem";
            добавитьВопосToolStripMenuItem.Size = new Size(209, 26);
            добавитьВопосToolStripMenuItem.Text = "Добавить вопос";
            добавитьВопосToolStripMenuItem.Click += добавитьВопосToolStripMenuItem_Click;
            // 
            // удалитьВопросToolStripMenuItem
            // 
            удалитьВопросToolStripMenuItem.Name = "удалитьВопросToolStripMenuItem";
            удалитьВопросToolStripMenuItem.Size = new Size(209, 26);
            удалитьВопросToolStripMenuItem.Text = "Удалить вопрос";
            удалитьВопросToolStripMenuItem.Click += удалитьВопросToolStripMenuItem_Click;
            // 
            // limitTime_MainForm_timer
            // 
            limitTime_MainForm_timer.Interval = 1000;
            limitTime_MainForm_timer.Tick += limitTime_MainForm_timer_Tick;
            // 
            // visualTimer_MainForm_label
            // 
            visualTimer_MainForm_label.AutoSize = true;
            visualTimer_MainForm_label.Location = new Point(325, 51);
            visualTimer_MainForm_label.Name = "visualTimer_MainForm_label";
            visualTimer_MainForm_label.Size = new Size(149, 21);
            visualTimer_MainForm_label.TabIndex = 5;
            visualTimer_MainForm_label.Text = "Выделенное время:";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 294);
            Controls.Add(visualTimer_MainForm_label);
            Controls.Add(MainForm_NextQuestion_button);
            Controls.Add(MainForm_AnswerQuestion_TextBox);
            Controls.Add(MainForm_Question_Textlabel);
            Controls.Add(MainForm_NumberQuestion_label);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "mainForm";
            Text = "Гений Идиот";
            Load += mainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MainForm_NumberQuestion_label;
        private Label MainForm_Question_Textlabel;
        private TextBox MainForm_AnswerQuestion_TextBox;
        private Button MainForm_NextQuestion_button;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem MainForm_ToolStrip_MenuItem;
        private ToolStripMenuItem MainForm_Result_ToolStripMenuItem;
        private ToolStripMenuItem MainForm_Reset_ToolStripMenuItem;
        private ToolStripMenuItem MainForm_Exit_ToolStripMenuItem;
        private ToolStripMenuItem вопросыToolStripMenuItem;
        private ToolStripMenuItem добавитьВопосToolStripMenuItem;
        private ToolStripMenuItem удалитьВопросToolStripMenuItem;
        private System.Windows.Forms.Timer limitTime_MainForm_timer;
        private Label visualTimer_MainForm_label;
    }
}