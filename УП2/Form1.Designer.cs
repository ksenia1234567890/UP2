namespace УП2
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
            this.components = new System.ComponentModel.Container();
            this.db = new System.Windows.Forms.DataGridView();
            this.attractionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.amusement_parkDataSet = new УП2.Amusement_parkDataSet();
            this.attractionsTableAdapter = new УП2.Amusement_parkDataSetTableAdapters.attractionsTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.safety = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.limitations = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.locus = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.db)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attractionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amusement_parkDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // db
            // 
            this.db.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db.Location = new System.Drawing.Point(1, -2);
            this.db.Name = "db";
            this.db.Size = new System.Drawing.Size(743, 760);
            this.db.TabIndex = 0;
            // 
            // attractionsBindingSource
            // 
            this.attractionsBindingSource.DataMember = "attractions";
            this.attractionsBindingSource.DataSource = this.amusement_parkDataSet;
            // 
            // amusement_parkDataSet
            // 
            this.amusement_parkDataSet.DataSetName = "Amusement_parkDataSet";
            this.amusement_parkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attractionsTableAdapter
            // 
            this.attractionsTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.safety);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.limitations);
            this.groupBox1.Controls.Add(this.description);
            this.groupBox1.Controls.Add(this.locus);
            this.groupBox1.Controls.Add(this.price);
            this.groupBox1.Controls.Add(this.title);
            this.groupBox1.Location = new System.Drawing.Point(802, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 463);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление аттракциона";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Безопасность";
            // 
            // safety
            // 
            this.safety.Location = new System.Drawing.Point(150, 255);
            this.safety.Multiline = true;
            this.safety.Name = "safety";
            this.safety.Size = new System.Drawing.Size(312, 52);
            this.safety.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(442, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Локация";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ограничения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Описание";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название";
            // 
            // limitations
            // 
            this.limitations.Location = new System.Drawing.Point(150, 177);
            this.limitations.Multiline = true;
            this.limitations.Name = "limitations";
            this.limitations.Size = new System.Drawing.Size(312, 52);
            this.limitations.TabIndex = 4;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(150, 93);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(312, 52);
            this.description.TabIndex = 3;
            // 
            // locus
            // 
            this.locus.Location = new System.Drawing.Point(150, 399);
            this.locus.Name = "locus";
            this.locus.Size = new System.Drawing.Size(312, 20);
            this.locus.TabIndex = 2;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(150, 345);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(100, 20);
            this.price.TabIndex = 1;
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(150, 43);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(312, 20);
            this.title.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.delete);
            this.groupBox2.Location = new System.Drawing.Point(802, 512);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(523, 145);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Удаление аттракциона";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(442, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Введите идентификатор аттракциона";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(150, 76);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(226, 20);
            this.delete.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.db);
            this.Name = "Form1";
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attractionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amusement_parkDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView db;
        public Amusement_parkDataSet amusement_parkDataSet;
        public System.Windows.Forms.BindingSource attractionsBindingSource;
        public Amusement_parkDataSetTableAdapters.attractionsTableAdapter attractionsTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox limitations;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox locus;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox delete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox safety;
    }
}

