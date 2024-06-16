
using ListEmployee.Field;

namespace ListEmployee
{
    partial class ListEmployee
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
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fieldStatisticGroupBindingSource = new BindingSource(components);
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            dataGridView2 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            departmentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            postDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            uneployDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fieldPersonBindingSource = new BindingSource(components);
            button2 = new Button();
            button1 = new Button();
            tabPage2 = new TabPage();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            Data = new DataGridViewTextBoxColumn();
            Value = new DataGridViewTextBoxColumn();
            dataGridViewComboBoxColumn1 = new DataGridViewComboBoxColumn();
            customCollectionBindingSource = new BindingSource(components);
            statusBindingSource1 = new BindingSource(components);
            statusBindingSource = new BindingSource(components);
            connectionSettingsBindingSource = new BindingSource(components);
            Column1 = new DataGridViewComboBoxColumn();
            Column2 = new DataGridViewComboBoxColumn();
            Column3 = new DataGridViewComboBoxColumn();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fieldStatisticGroupBindingSource).BeginInit();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fieldPersonBindingSource).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customCollectionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)statusBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)statusBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)connectionSettingsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dateDataGridViewTextBoxColumn, countDataGridViewTextBoxColumn });
            dataGridView1.DataSource = fieldStatisticGroupBindingSource;
            dataGridView1.GridColor = SystemColors.Window;
            dataGridView1.Location = new Point(62, 213);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 44;
            dataGridView1.RowTemplate.DefaultCellStyle.NullValue = "1";
            dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowTemplate.ReadOnly = true;
            dataGridView1.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridView1.ScrollBars = ScrollBars.Horizontal;
            dataGridView1.Size = new Size(1140, 265);
            dataGridView1.TabIndex = 7;
            dataGridView1.DataSource = FieldStatisticGroup.FieldsStatisticGroup;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            dateDataGridViewTextBoxColumn.MinimumWidth = 150;
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            dateDataGridViewTextBoxColumn.ReadOnly = true;
            dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // countDataGridViewTextBoxColumn
            // 
            countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            countDataGridViewTextBoxColumn.HeaderText = "Колличество";
            countDataGridViewTextBoxColumn.MinimumWidth = 150;
            countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            countDataGridViewTextBoxColumn.ReadOnly = true;
            countDataGridViewTextBoxColumn.Width = 150;
            // 
            // fieldStatisticGroupBindingSource
            // 
            fieldStatisticGroupBindingSource.DataSource = typeof(FieldStatisticGroup);
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Location = new Point(1, 3);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1275, 516);
            tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView2);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1267, 488);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Главная";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.Anchor = AnchorStyles.None;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView2.BackgroundColor = SystemColors.Window;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, fullNameDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, departmentDataGridViewTextBoxColumn, postDataGridViewTextBoxColumn, employDataGridViewTextBoxColumn, uneployDataGridViewTextBoxColumn });
            dataGridView2.DataSource = fieldPersonBindingSource;
            dataGridView2.GridColor = SystemColors.Window;
            dataGridView2.Location = new Point(20, 119);
            dataGridView2.MinimumSize = new Size(0, 20);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 25;
            dataGridView2.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridView2.Size = new Size(1230, 359);
            dataGridView2.TabIndex = 3;
            dataGridView2.DataSource = FieldPerson.FieldsPerson;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 42;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            fullNameDataGridViewTextBoxColumn.Width = 83;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.ReadOnly = true;
            statusDataGridViewTextBoxColumn.Width = 64;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            departmentDataGridViewTextBoxColumn.ReadOnly = true;
            departmentDataGridViewTextBoxColumn.Width = 95;
            // 
            // postDataGridViewTextBoxColumn
            // 
            postDataGridViewTextBoxColumn.DataPropertyName = "Post";
            postDataGridViewTextBoxColumn.HeaderText = "Post";
            postDataGridViewTextBoxColumn.Name = "postDataGridViewTextBoxColumn";
            postDataGridViewTextBoxColumn.ReadOnly = true;
            postDataGridViewTextBoxColumn.Width = 55;
            // 
            // employDataGridViewTextBoxColumn
            // 
            employDataGridViewTextBoxColumn.DataPropertyName = "Employ";
            employDataGridViewTextBoxColumn.HeaderText = "Employ";
            employDataGridViewTextBoxColumn.Name = "employDataGridViewTextBoxColumn";
            employDataGridViewTextBoxColumn.ReadOnly = true;
            employDataGridViewTextBoxColumn.Width = 72;
            // 
            // uneployDataGridViewTextBoxColumn
            // 
            uneployDataGridViewTextBoxColumn.DataPropertyName = "Uneploy";
            uneployDataGridViewTextBoxColumn.HeaderText = "Uneploy";
            uneployDataGridViewTextBoxColumn.Name = "uneployDataGridViewTextBoxColumn";
            uneployDataGridViewTextBoxColumn.ReadOnly = true;
            uneployDataGridViewTextBoxColumn.Width = 76;
            // 
            // fieldPersonBindingSource
            // 
            fieldPersonBindingSource.DataSource = typeof(FieldPerson);
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(20, 41);
            button2.Name = "button2";
            button2.Size = new Size(170, 37);
            button2.TabIndex = 2;
            button2.Text = "Панель сортировки";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(1087, 41);
            button1.Name = "button1";
            button1.Size = new Size(163, 37);
            button1.TabIndex = 1;
            button1.Text = "Обновить список";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(dateTimePicker2);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(dateTimePicker1);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1267, 488);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Статистика";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Value = DateTime.Now;
            dateTimePicker2.MaxDate = DateTime.Now;
            dateTimePicker2.Location = new Point(368, 150);
            dateTimePicker2.MaxDate = DateTime.Now;
            dateTimePicker2.MinDate = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(368, 104);
            label3.Name = "label3";
            label3.Size = new Size(171, 19);
            label3.TabIndex = 5;
            label3.Text = "Выберите конечную дату";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.MaxDate = DateTime.Now;
            dateTimePicker1.Location = new Point(62, 150);
            dateTimePicker1.MaxDate = DateTime.Now;
            dateTimePicker1.MinDate = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.Value = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(62, 104);
            label2.Name = "label2";
            label2.Size = new Size(177, 19);
            label2.TabIndex = 3;
            label2.Text = "Выберите начальную дату";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(368, 45);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(650, 29);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 27);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 1;
            label1.Text = "Выберите статус";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(62, 45);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(241, 29);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.DataSource = FieldFilter.FieldsFilterStatus;
            comboBox1.DisplayMember = "text";
            // 
            // Data
            // 
            Data.HeaderText = "Дата";
            Data.Name = "Data";
            Data.ReadOnly = true;
            // 
            // Value
            // 
            Value.HeaderText = "Кол-во";
            Value.Name = "Value";
            Value.ReadOnly = true;
            // 
            // dataGridViewComboBoxColumn1
            // 
            dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            // 
            // Column1
            // 
            Column1.HeaderText = "ФИО";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Column3";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // ListEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1273, 517);
            Controls.Add(tabControl);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "ListEmployee";
            Text = "Form1";
            Load += ListEmployee_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fieldStatisticGroupBindingSource).EndInit();
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)fieldPersonBindingSource).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)customCollectionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)statusBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)statusBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)connectionSettingsBindingSource).EndInit();
            ResumeLayout(false);
        }

        //private void listView1_MouseDoubleClick(object sender, ColumnClickEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        #endregion

        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private BindingSource statusBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private BindingSource statusBindingSource1;
        private BindingSource customCollectionBindingSource;
        private BindingSource connectionSettingsBindingSource;
        private DataGridView dataGridView1;
        private DataGridViewComboBoxColumn Column1;
        private DataGridViewComboBoxColumn Column2;
        private DataGridViewComboBoxColumn Column3;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn Value;
        private BindingSource fieldStatisticGroupBindingSource;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn postDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn uneployDataGridViewTextBoxColumn;
        private BindingSource fieldPersonBindingSource;
    }
}
