namespace CourseWork
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.студентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСтудентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьСтудентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьСтудентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.курсовыеРаботыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКурсовуюРаботуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьКурсовуюРаботуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьКурсовуюРаботуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дополнительноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокПреподавателейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лучшиеРаботыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.максимальныеВыбросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(226, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Студенты";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(830, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Курсовые работы";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(537, 172);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellEnter);
            this.dataGridView1.Click += new System.EventHandler(this.DataGridView1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.Location = new System.Drawing.Point(634, 62);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(537, 172);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(36, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 59);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить студента";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 5;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(167, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 59);
            this.button2.TabIndex = 5;
            this.button2.Text = "Удалить студента";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 5;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(311, 253);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(221, 59);
            this.button3.TabIndex = 6;
            this.button3.Text = "Редактировать студента";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 5;
            this.button4.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(653, 253);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(221, 59);
            this.button4.TabIndex = 7;
            this.button4.Text = "Добавить курсовую работу";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightCoral;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderSize = 5;
            this.button5.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.Location = new System.Drawing.Point(792, 318);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(221, 59);
            this.button5.TabIndex = 8;
            this.button5.Text = "Удалить курсовую работу";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.BorderSize = 5;
            this.button6.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.Location = new System.Drawing.Point(930, 253);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(221, 59);
            this.button6.TabIndex = 9;
            this.button6.Text = "Редактировать курсовую работу";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.BorderSize = 5;
            this.button7.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.Location = new System.Drawing.Point(243, 516);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(145, 29);
            this.button7.TabIndex = 10;
            this.button7.Text = "Список преподавателей";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button8.FlatAppearance.BorderSize = 5;
            this.button8.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.Location = new System.Drawing.Point(766, 516);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(182, 29);
            this.button8.TabIndex = 11;
            this.button8.Text = "Информация о предметах";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button9.FlatAppearance.BorderSize = 5;
            this.button9.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.Location = new System.Drawing.Point(498, 516);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(145, 29);
            this.button9.TabIndex = 12;
            this.button9.Text = "Лучшие работы";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.дополнительноToolStripMenuItem,
            this.студентыToolStripMenuItem,
            this.курсовыеРаботыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1192, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // студентыToolStripMenuItem
            // 
            this.студентыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьСтудентаToolStripMenuItem,
            this.редактироватьСтудентаToolStripMenuItem,
            this.удалитьСтудентаToolStripMenuItem});
            this.студентыToolStripMenuItem.Name = "студентыToolStripMenuItem";
            this.студентыToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.студентыToolStripMenuItem.Text = "Студенты";
            // 
            // добавитьСтудентаToolStripMenuItem
            // 
            this.добавитьСтудентаToolStripMenuItem.Name = "добавитьСтудентаToolStripMenuItem";
            this.добавитьСтудентаToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.добавитьСтудентаToolStripMenuItem.Text = "Добавить студента";
            this.добавитьСтудентаToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // редактироватьСтудентаToolStripMenuItem
            // 
            this.редактироватьСтудентаToolStripMenuItem.Name = "редактироватьСтудентаToolStripMenuItem";
            this.редактироватьСтудентаToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.редактироватьСтудентаToolStripMenuItem.Text = "Редактировать студента";
            this.редактироватьСтудентаToolStripMenuItem.Click += new System.EventHandler(this.button3_Click);
            // 
            // удалитьСтудентаToolStripMenuItem
            // 
            this.удалитьСтудентаToolStripMenuItem.Name = "удалитьСтудентаToolStripMenuItem";
            this.удалитьСтудентаToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.удалитьСтудентаToolStripMenuItem.Text = "Удалить студента";
            this.удалитьСтудентаToolStripMenuItem.Click += new System.EventHandler(this.button2_Click);
            // 
            // курсовыеРаботыToolStripMenuItem
            // 
            this.курсовыеРаботыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьКурсовуюРаботуToolStripMenuItem,
            this.редактироватьКурсовуюРаботуToolStripMenuItem,
            this.удалитьКурсовуюРаботуToolStripMenuItem});
            this.курсовыеРаботыToolStripMenuItem.Name = "курсовыеРаботыToolStripMenuItem";
            this.курсовыеРаботыToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.курсовыеРаботыToolStripMenuItem.Text = "Курсовые работы";
            // 
            // добавитьКурсовуюРаботуToolStripMenuItem
            // 
            this.добавитьКурсовуюРаботуToolStripMenuItem.Name = "добавитьКурсовуюРаботуToolStripMenuItem";
            this.добавитьКурсовуюРаботуToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.добавитьКурсовуюРаботуToolStripMenuItem.Text = "Добавить курсовую работу";
            this.добавитьКурсовуюРаботуToolStripMenuItem.Click += new System.EventHandler(this.button4_Click);
            // 
            // редактироватьКурсовуюРаботуToolStripMenuItem
            // 
            this.редактироватьКурсовуюРаботуToolStripMenuItem.Name = "редактироватьКурсовуюРаботуToolStripMenuItem";
            this.редактироватьКурсовуюРаботуToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.редактироватьКурсовуюРаботуToolStripMenuItem.Text = "Редактировать курсовую работу";
            this.редактироватьКурсовуюРаботуToolStripMenuItem.Click += new System.EventHandler(this.button6_Click);
            // 
            // удалитьКурсовуюРаботуToolStripMenuItem
            // 
            this.удалитьКурсовуюРаботуToolStripMenuItem.Name = "удалитьКурсовуюРаботуToolStripMenuItem";
            this.удалитьКурсовуюРаботуToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.удалитьКурсовуюРаботуToolStripMenuItem.Text = "Удалить курсовую работу";
            this.удалитьКурсовуюРаботуToolStripMenuItem.Click += new System.EventHandler(this.button5_Click);
            // 
            // дополнительноToolStripMenuItem
            // 
            this.дополнительноToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокПреподавателейToolStripMenuItem,
            this.лучшиеРаботыToolStripMenuItem,
            this.максимальныеВыбросыToolStripMenuItem});
            this.дополнительноToolStripMenuItem.Name = "дополнительноToolStripMenuItem";
            this.дополнительноToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.дополнительноToolStripMenuItem.Text = "Дополнительно";
            // 
            // списокПреподавателейToolStripMenuItem
            // 
            this.списокПреподавателейToolStripMenuItem.Name = "списокПреподавателейToolStripMenuItem";
            this.списокПреподавателейToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.списокПреподавателейToolStripMenuItem.Text = "Список преподавателей";
            this.списокПреподавателейToolStripMenuItem.Click += new System.EventHandler(this.button7_Click);
            // 
            // лучшиеРаботыToolStripMenuItem
            // 
            this.лучшиеРаботыToolStripMenuItem.Name = "лучшиеРаботыToolStripMenuItem";
            this.лучшиеРаботыToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.лучшиеРаботыToolStripMenuItem.Text = "Лучшие работы";
            this.лучшиеРаботыToolStripMenuItem.Click += new System.EventHandler(this.button9_Click);
            // 
            // максимальныеВыбросыToolStripMenuItem
            // 
            this.максимальныеВыбросыToolStripMenuItem.Name = "максимальныеВыбросыToolStripMenuItem";
            this.максимальныеВыбросыToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.максимальныеВыбросыToolStripMenuItem.Text = "Максимальные выбросы";
            this.максимальныеВыбросыToolStripMenuItem.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1192, 557);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Программа мониторинга загрязнения окружающей среды";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem студентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьСтудентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьСтудентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьСтудентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem курсовыеРаботыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьКурсовуюРаботуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьКурсовуюРаботуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьКурсовуюРаботуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дополнительноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокПреподавателейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лучшиеРаботыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem максимальныеВыбросыToolStripMenuItem;
    }
}

