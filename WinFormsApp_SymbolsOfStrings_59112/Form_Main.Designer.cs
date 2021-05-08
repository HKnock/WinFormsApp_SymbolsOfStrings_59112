
namespace WinFormsApp_SymbolsOfStrings_59112
{
    partial class form_Main
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label_AboutInput = new System.Windows.Forms.Label();
            this.listBox_Input = new System.Windows.Forms.ListBox();
            this.label_AboutLetter = new System.Windows.Forms.Label();
            this.textBox_Letter = new System.Windows.Forms.TextBox();
            this.button_Open = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_FindLetter = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenu_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenu_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenu_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenu_About = new System.Windows.Forms.ToolStripMenuItem();
            this.button_Task = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 261);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip.Size = new System.Drawing.Size(385, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(193, 17);
            this.toolStripStatusLabel.Text = "Приложение запущено успешно!";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "*.txt|*.txt";
            // 
            // label_AboutInput
            // 
            this.label_AboutInput.AutoSize = true;
            this.label_AboutInput.Location = new System.Drawing.Point(28, 32);
            this.label_AboutInput.Name = "label_AboutInput";
            this.label_AboutInput.Size = new System.Drawing.Size(141, 15);
            this.label_AboutInput.TabIndex = 2;
            this.label_AboutInput.Text = "Набор строк для поиска";
            // 
            // listBox_Input
            // 
            this.listBox_Input.Enabled = false;
            this.listBox_Input.FormattingEnabled = true;
            this.listBox_Input.ItemHeight = 15;
            this.listBox_Input.Items.AddRange(new object[] {
            "Употребляйте с пользой время,",
            "Учиться надо по системе.",
            "Сперва хочу вам в долг вменить",
            "На курсы логики ходить.",
            "Ваш ум, нетронутый доныне,",
            "На них приучат к дисциплине,",
            "Чтоб взял он направленья ось,",
            "Не разбредаясь вкривь и вкось."});
            this.listBox_Input.Location = new System.Drawing.Point(13, 60);
            this.listBox_Input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox_Input.Name = "listBox_Input";
            this.listBox_Input.Size = new System.Drawing.Size(238, 154);
            this.listBox_Input.TabIndex = 3;
            // 
            // label_AboutLetter
            // 
            this.label_AboutLetter.AutoSize = true;
            this.label_AboutLetter.Location = new System.Drawing.Point(278, 32);
            this.label_AboutLetter.Name = "label_AboutLetter";
            this.label_AboutLetter.Size = new System.Drawing.Size(80, 15);
            this.label_AboutLetter.TabIndex = 4;
            this.label_AboutLetter.Text = "Буква поиска";
            // 
            // textBox_Letter
            // 
            this.textBox_Letter.Location = new System.Drawing.Point(303, 74);
            this.textBox_Letter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Letter.MaxLength = 1;
            this.textBox_Letter.Name = "textBox_Letter";
            this.textBox_Letter.Size = new System.Drawing.Size(34, 23);
            this.textBox_Letter.TabIndex = 5;
            // 
            // button_Open
            // 
            this.button_Open.Location = new System.Drawing.Point(28, 221);
            this.button_Open.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(82, 22);
            this.button_Open.TabIndex = 6;
            this.button_Open.Text = "Открыть";
            this.button_Open.UseVisualStyleBackColor = true;
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(152, 221);
            this.button_Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(82, 22);
            this.button_Clear.TabIndex = 7;
            this.button_Clear.Text = "Очистить!";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(280, 221);
            this.button_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(82, 22);
            this.button_Exit.TabIndex = 8;
            this.button_Exit.Text = "Выход";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_FindLetter
            // 
            this.button_FindLetter.Location = new System.Drawing.Point(276, 124);
            this.button_FindLetter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_FindLetter.Name = "button_FindLetter";
            this.button_FindLetter.Size = new System.Drawing.Size(82, 22);
            this.button_FindLetter.TabIndex = 9;
            this.button_FindLetter.Text = "Посчитать!";
            this.button_FindLetter.UseVisualStyleBackColor = true;
            this.button_FindLetter.Click += new System.EventHandler(this.button_FindLetter_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenu_File,
            this.ToolStripMenu_Help});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(385, 24);
            this.menuStrip.TabIndex = 10;
            this.menuStrip.Text = "menuStrip1";
            // 
            // ToolStripMenu_File
            // 
            this.ToolStripMenu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenu_Open,
            this.ToolStripMenu_Clear,
            this.ToolStripMenu_Exit});
            this.ToolStripMenu_File.Name = "ToolStripMenu_File";
            this.ToolStripMenu_File.Size = new System.Drawing.Size(48, 20);
            this.ToolStripMenu_File.Text = "&Файл";
            // 
            // ToolStripMenu_Open
            // 
            this.ToolStripMenu_Open.Name = "ToolStripMenu_Open";
            this.ToolStripMenu_Open.Size = new System.Drawing.Size(126, 22);
            this.ToolStripMenu_Open.Text = "&Открыть";
            this.ToolStripMenu_Open.Click += new System.EventHandler(this.ToolStripMenu_Open_Click);
            // 
            // ToolStripMenu_Clear
            // 
            this.ToolStripMenu_Clear.Name = "ToolStripMenu_Clear";
            this.ToolStripMenu_Clear.Size = new System.Drawing.Size(126, 22);
            this.ToolStripMenu_Clear.Text = "О&чистить";
            this.ToolStripMenu_Clear.Click += new System.EventHandler(this.ToolStripMenu_Clear_Click);
            // 
            // ToolStripMenu_Exit
            // 
            this.ToolStripMenu_Exit.Name = "ToolStripMenu_Exit";
            this.ToolStripMenu_Exit.Size = new System.Drawing.Size(126, 22);
            this.ToolStripMenu_Exit.Text = "&Выход";
            this.ToolStripMenu_Exit.Click += new System.EventHandler(this.ToolStripMenu_Exit_Click);
            // 
            // ToolStripMenu_Help
            // 
            this.ToolStripMenu_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenu_About});
            this.ToolStripMenu_Help.Name = "ToolStripMenu_Help";
            this.ToolStripMenu_Help.Size = new System.Drawing.Size(68, 20);
            this.ToolStripMenu_Help.Text = "&Помощь";
            // 
            // ToolStripMenu_About
            // 
            this.ToolStripMenu_About.Name = "ToolStripMenu_About";
            this.ToolStripMenu_About.Size = new System.Drawing.Size(149, 22);
            this.ToolStripMenu_About.Text = "О &программе";
            this.ToolStripMenu_About.DoubleClick += new System.EventHandler(this.ToolStripMenu_About_DoubleClick);
            // 
            // button_Task
            // 
            this.button_Task.Location = new System.Drawing.Point(276, 168);
            this.button_Task.Name = "button_Task";
            this.button_Task.Size = new System.Drawing.Size(82, 23);
            this.button_Task.TabIndex = 11;
            this.button_Task.Text = "Задание";
            this.button_Task.UseVisualStyleBackColor = true;
            this.button_Task.Click += new System.EventHandler(this.button_Task_Click);
            // 
            // form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 283);
            this.Controls.Add(this.button_Task);
            this.Controls.Add(this.button_FindLetter);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Open);
            this.Controls.Add(this.textBox_Letter);
            this.Controls.Add(this.label_AboutLetter);
            this.Controls.Add(this.listBox_Input);
            this.Controls.Add(this.label_AboutInput);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "form_Main";
            this.Text = "Form1";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label_AboutInput;
        private System.Windows.Forms.ListBox listBox_Input;
        private System.Windows.Forms.Label label_AboutLetter;
        private System.Windows.Forms.TextBox textBox_Letter;
        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_FindLetter;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_File;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Help;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Open;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Clear;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Exit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_About;
        private System.Windows.Forms.Button button_Task;
    }
}

