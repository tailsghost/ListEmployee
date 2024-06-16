using ListEmployee.Field;

namespace ListEmployee
{
    partial class CustomMessageBox
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
            checkedListBox1 = new CheckedListBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            checkedListBox2 = new CheckedListBox();
            label3 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            comboBox3 = new ComboBox();
            label6 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(109, 190);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(260, 40);
            checkedListBox1.TabIndex = 0;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            checkedListBox1.DataSource = FieldSortInfo.FieldsMenuSortType;
            checkedListBox1.DisplayMember = "display";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(124, 157);
            label1.Name = "label1";
            label1.Size = new Size(197, 21);
            label1.TabIndex = 1;
            label1.Text = "Выберите тип сортировки";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(319, 617);
            button1.Name = "button1";
            button1.Size = new Size(103, 32);
            button1.TabIndex = 2;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(138, 9);
            label2.Name = "label2";
            label2.Size = new Size(170, 21);
            label2.TabIndex = 3;
            label2.Text = "Выберите пункт меню";
            // 
            // checkedListBox2
            // 
            checkedListBox2.CheckOnClick = true;
            checkedListBox2.DisplayMember = "display";
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Location = new Point(36, 44);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(360, 94);
            checkedListBox2.TabIndex = 4;
            checkedListBox2.SelectedIndexChanged += checkedListBox2_SelectedIndexChanged;
            checkedListBox2.DataSource = FieldSortInfo.FieldsMenuSort;
            checkedListBox2.DisplayMember = "display";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(109, 259);
            label3.Name = "label3";
            label3.Size = new Size(212, 21);
            label3.TabIndex = 6;
            label3.Text = "Выберите типы фильтрации";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14F);
            textBox1.Location = new Point(12, 532);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(410, 40);
            textBox1.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.DisplayMember = "text";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 341);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(410, 29);
            comboBox1.TabIndex = 10;
            comboBox1.DataSource = FieldFilter.FieldsFilterStatus;
            comboBox1.DisplayMember = "text";
            // 
            // comboBox2
            // 
            comboBox2.DisplayMember = "text";
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Segoe UI", 12F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(12, 415);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(410, 29);
            comboBox2.TabIndex = 11;
            comboBox2.DataSource = FieldFilter.FieldsFilterDepartment;
            comboBox2.DisplayMember = "text";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 323);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 12;
            label4.Text = "Статус";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 394);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 13;
            label5.Text = "Отдел";
            // 
            // comboBox3
            // 
            comboBox3.DisplayMember = "text";
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.Font = new Font("Segoe UI", 12F);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(12, 478);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(410, 29);
            comboBox3.TabIndex = 14;
            comboBox3.DataSource = FieldFilter.FieldsFilterPosition;
            comboBox3.DisplayMember = "text";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 458);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 15;
            label6.Text = "Должность";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(12, 617);
            button2.Name = "button2";
            button2.Size = new Size(120, 32);
            button2.TabIndex = 16;
            button2.Text = "Закрыть";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // CustomMessageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 661);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(comboBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(checkedListBox2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(checkedListBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "CustomMessageBox";
            Text = "CustomMessageBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBox1;
        private Label label1;
        private Button button1;
        private Label label2;
        private CheckedListBox checkedListBox2;
        private Label label3;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label4;
        private Label label5;
        private ComboBox comboBox3;
        private Label label6;
        private Button button2;
    }
}