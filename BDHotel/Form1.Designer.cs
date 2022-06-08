
namespace BDHotel
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_Employees = new System.Windows.Forms.Label();
            this.Grid_Employees = new System.Windows.Forms.DataGridView();
            this.bt_Add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_Sort1 = new System.Windows.Forms.Button();
            this.bt_Sort2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Search = new System.Windows.Forms.Button();
            this.CB_Post = new System.Windows.Forms.ComboBox();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_SearchFN = new System.Windows.Forms.Button();
            this.bt_SearchLN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Employees)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Employees
            // 
            this.lb_Employees.AutoSize = true;
            this.lb_Employees.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Employees.Location = new System.Drawing.Point(410, 9);
            this.lb_Employees.Name = "lb_Employees";
            this.lb_Employees.Size = new System.Drawing.Size(214, 24);
            this.lb_Employees.TabIndex = 0;
            this.lb_Employees.Text = "Список сотрудников";
            // 
            // Grid_Employees
            // 
            this.Grid_Employees.AllowUserToAddRows = false;
            this.Grid_Employees.AllowUserToDeleteRows = false;
            this.Grid_Employees.AllowUserToResizeColumns = false;
            this.Grid_Employees.AllowUserToResizeRows = false;
            this.Grid_Employees.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.Grid_Employees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid_Employees.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Grid_Employees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_Employees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Grid_Employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid_Employees.DefaultCellStyle = dataGridViewCellStyle4;
            this.Grid_Employees.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Grid_Employees.EnableHeadersVisualStyles = false;
            this.Grid_Employees.Location = new System.Drawing.Point(12, 49);
            this.Grid_Employees.Name = "Grid_Employees";
            this.Grid_Employees.RowHeadersVisible = false;
            this.Grid_Employees.Size = new System.Drawing.Size(1003, 352);
            this.Grid_Employees.TabIndex = 1;
            // 
            // bt_Add
            // 
            this.bt_Add.Location = new System.Drawing.Point(863, 6);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(153, 40);
            this.bt_Add.TabIndex = 2;
            this.bt_Add.Text = "Добавить сотрудника";
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(704, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Удалить сотрудника";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(545, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Изменить информацию о сотруднике";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_Sort1
            // 
            this.bt_Sort1.Location = new System.Drawing.Point(12, 4);
            this.bt_Sort1.Name = "bt_Sort1";
            this.bt_Sort1.Size = new System.Drawing.Size(279, 24);
            this.bt_Sort1.TabIndex = 5;
            this.bt_Sort1.Text = "Отсортировать весь список по возрастанию имени ";
            this.bt_Sort1.UseVisualStyleBackColor = true;
            this.bt_Sort1.Click += new System.EventHandler(this.bt_Sort1_Click);
            // 
            // bt_Sort2
            // 
            this.bt_Sort2.Location = new System.Drawing.Point(12, 25);
            this.bt_Sort2.Name = "bt_Sort2";
            this.bt_Sort2.Size = new System.Drawing.Size(279, 24);
            this.bt_Sort2.TabIndex = 6;
            this.bt_Sort2.Text = "Отсортировать весь список по убыванию имени ";
            this.bt_Sort2.UseVisualStyleBackColor = true;
            this.bt_Sort2.Click += new System.EventHandler(this.bt_Sort2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 40);
            this.button3.TabIndex = 7;
            this.button3.Text = "Обновить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.bt_Add);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(-2, 407);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 54);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.bt_Search);
            this.panel2.Controls.Add(this.CB_Post);
            this.panel2.Location = new System.Drawing.Point(181, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 56);
            this.panel2.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Должность:";
            // 
            // bt_Search
            // 
            this.bt_Search.Location = new System.Drawing.Point(27, 26);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(279, 23);
            this.bt_Search.TabIndex = 20;
            this.bt_Search.Text = "Вывести сотрудников этой должности";
            this.bt_Search.UseVisualStyleBackColor = true;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // CB_Post
            // 
            this.CB_Post.FormattingEnabled = true;
            this.CB_Post.Location = new System.Drawing.Point(98, 3);
            this.CB_Post.Name = "CB_Post";
            this.CB_Post.Size = new System.Drawing.Size(208, 21);
            this.CB_Post.TabIndex = 18;
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(62, 4);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(156, 20);
            this.txt_Search.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Поиск:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bt_SearchLN);
            this.panel3.Controls.Add(this.bt_SearchFN);
            this.panel3.Controls.Add(this.txt_Search);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(626, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(398, 31);
            this.panel3.TabIndex = 11;
            // 
            // bt_SearchFN
            // 
            this.bt_SearchFN.Location = new System.Drawing.Point(223, 2);
            this.bt_SearchFN.Name = "bt_SearchFN";
            this.bt_SearchFN.Size = new System.Drawing.Size(85, 23);
            this.bt_SearchFN.TabIndex = 11;
            this.bt_SearchFN.Text = "По имени";
            this.bt_SearchFN.UseVisualStyleBackColor = true;
            this.bt_SearchFN.Click += new System.EventHandler(this.bt_SearchFN_Click);
            // 
            // bt_SearchLN
            // 
            this.bt_SearchLN.Location = new System.Drawing.Point(307, 2);
            this.bt_SearchLN.Name = "bt_SearchLN";
            this.bt_SearchLN.Size = new System.Drawing.Size(85, 23);
            this.bt_SearchLN.TabIndex = 12;
            this.bt_SearchLN.Text = "По фамилиии";
            this.bt_SearchLN.UseVisualStyleBackColor = true;
            this.bt_SearchLN.Click += new System.EventHandler(this.bt_SearchLN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1027, 462);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_Sort2);
            this.Controls.Add(this.bt_Sort1);
            this.Controls.Add(this.Grid_Employees);
            this.Controls.Add(this.lb_Employees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сотрудники отеля";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Employees)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Employees;
        private System.Windows.Forms.DataGridView Grid_Employees;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_Sort1;
        private System.Windows.Forms.Button bt_Sort2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CB_Post;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bt_SearchLN;
        private System.Windows.Forms.Button bt_SearchFN;
    }
}

