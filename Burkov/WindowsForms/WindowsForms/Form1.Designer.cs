namespace WindowsForms
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fullNameBox = new System.Windows.Forms.TextBox();
            this.birthDateBox = new System.Windows.Forms.DateTimePicker();
            this.rankBox = new System.Windows.Forms.ComboBox();
            this.raitingBox = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.placeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.scoreColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.scoreBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTournamentBox = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tournametntNameBox = new System.Windows.Forms.TextBox();
            this.placeBox = new System.Windows.Forms.NumericUpDown();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.fullNameBox);
            this.groupBox1.Controls.Add(this.birthDateBox);
            this.groupBox1.Controls.Add(this.rankBox);
            this.groupBox1.Controls.Add(this.raitingBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные о шахматисте";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Рейтинг";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Разряд";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Дата рождения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ФИО";
            // 
            // fullNameBox
            // 
            this.fullNameBox.Location = new System.Drawing.Point(188, 19);
            this.fullNameBox.Name = "fullNameBox";
            this.fullNameBox.Size = new System.Drawing.Size(227, 20);
            this.fullNameBox.TabIndex = 3;
            // 
            // birthDateBox
            // 
            this.birthDateBox.Location = new System.Drawing.Point(188, 98);
            this.birthDateBox.Name = "birthDateBox";
            this.birthDateBox.Size = new System.Drawing.Size(227, 20);
            this.birthDateBox.TabIndex = 2;
            // 
            // rankBox
            // 
            this.rankBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rankBox.FormattingEnabled = true;
            this.rankBox.Items.AddRange(new object[] {
            "4 разряд",
            "3 разряд",
            "2 разряд",
            "1 разряд",
            "Кандидат в мастера",
            "Мастер",
            "Международный мастер",
            "Гроссмейстер"});
            this.rankBox.Location = new System.Drawing.Point(188, 71);
            this.rankBox.Name = "rankBox";
            this.rankBox.Size = new System.Drawing.Size(227, 21);
            this.rankBox.TabIndex = 1;
            // 
            // raitingBox
            // 
            this.raitingBox.Location = new System.Drawing.Point(188, 45);
            this.raitingBox.Name = "raitingBox";
            this.raitingBox.Size = new System.Drawing.Size(227, 20);
            this.raitingBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addButton);
            this.groupBox2.Controls.Add(this.deleteButton);
            this.groupBox2.Controls.Add(this.listView);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.scoreBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dateTournamentBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tournametntNameBox);
            this.groupBox2.Controls.Add(this.placeBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 332);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные о турнирах";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(340, 302);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(9, 302);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.placeColumn,
            this.scoreColumn,
            this.dateColumn});
            this.listView.Location = new System.Drawing.Point(12, 123);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(403, 173);
            this.listView.TabIndex = 11;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Название";
            this.nameColumn.Width = 112;
            // 
            // placeColumn
            // 
            this.placeColumn.Text = "Занятое место";
            this.placeColumn.Width = 94;
            // 
            // scoreColumn
            // 
            this.scoreColumn.Text = "Процент очков";
            this.scoreColumn.Width = 87;
            // 
            // dateColumn
            // 
            this.dateColumn.Text = "Дата проведения";
            this.dateColumn.Width = 105;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Дата проведения";
            // 
            // scoreBox
            // 
            this.scoreBox.Location = new System.Drawing.Point(188, 71);
            this.scoreBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.scoreBox.Name = "scoreBox";
            this.scoreBox.Size = new System.Drawing.Size(227, 20);
            this.scoreBox.TabIndex = 7;
            this.scoreBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Процент набранных очков";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Название";
            // 
            // dateTournamentBox
            // 
            this.dateTournamentBox.Location = new System.Drawing.Point(188, 97);
            this.dateTournamentBox.Name = "dateTournamentBox";
            this.dateTournamentBox.Size = new System.Drawing.Size(227, 20);
            this.dateTournamentBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Занятое место";
            // 
            // tournametntNameBox
            // 
            this.tournametntNameBox.Location = new System.Drawing.Point(188, 19);
            this.tournametntNameBox.Name = "tournametntNameBox";
            this.tournametntNameBox.Size = new System.Drawing.Size(227, 20);
            this.tournametntNameBox.TabIndex = 4;
            // 
            // placeBox
            // 
            this.placeBox.Location = new System.Drawing.Point(188, 45);
            this.placeBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.placeBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.placeBox.Name = "placeBox";
            this.placeBox.Size = new System.Drawing.Size(227, 20);
            this.placeBox.TabIndex = 6;
            this.placeBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(352, 484);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(21, 484);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 14;
            this.loadButton.Text = "Загрузить";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 515);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox fullNameBox;
        private System.Windows.Forms.DateTimePicker birthDateBox;
        private System.Windows.Forms.ComboBox rankBox;
        private System.Windows.Forms.MaskedTextBox raitingBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader placeColumn;
        private System.Windows.Forms.ColumnHeader scoreColumn;
        private System.Windows.Forms.ColumnHeader dateColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown scoreBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTournamentBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tournametntNameBox;
        private System.Windows.Forms.NumericUpDown placeBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

