
namespace WindowsFormsApp1
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
        protected override void Dispose (bool disposing)
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
        private void InitializeComponent ()
        {
            this.listBoxOfProducts = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.управлениеМагазиномToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьНовыйТоварToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продатьТоварToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.filenameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.authorLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.filenameLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxOfProducts
            // 
            this.listBoxOfProducts.FormattingEnabled = true;
            this.listBoxOfProducts.Location = new System.Drawing.Point(14, 70);
            this.listBoxOfProducts.Name = "listBoxOfProducts";
            this.listBoxOfProducts.Size = new System.Drawing.Size(406, 121);
            this.listBoxOfProducts.TabIndex = 0;
            this.listBoxOfProducts.UseWaitCursor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.управлениеМагазиномToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1022, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.UseWaitCursor = true;
            // 
            // управлениеМагазиномToolStripMenuItem
            // 
            this.управлениеМагазиномToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьНовыйТоварToolStripMenuItem,
            this.продатьТоварToolStripMenuItem1});
            this.управлениеМагазиномToolStripMenuItem.Name = "управлениеМагазиномToolStripMenuItem";
            this.управлениеМагазиномToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.управлениеМагазиномToolStripMenuItem.Text = "Управление магазином";
            // 
            // добавитьНовыйТоварToolStripMenuItem
            // 
            this.добавитьНовыйТоварToolStripMenuItem.Name = "добавитьНовыйТоварToolStripMenuItem";
            this.добавитьНовыйТоварToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.добавитьНовыйТоварToolStripMenuItem.Text = "Добавить новый товар";
            this.добавитьНовыйТоварToolStripMenuItem.Click += new System.EventHandler(this.добавитьНовыйТоварToolStripMenuItem_Click);
            // 
            // продатьТоварToolStripMenuItem1
            // 
            this.продатьТоварToolStripMenuItem1.Name = "продатьТоварToolStripMenuItem1";
            this.продатьТоварToolStripMenuItem1.Size = new System.Drawing.Size(199, 22);
            this.продатьТоварToolStripMenuItem1.Text = "Продать товар";
            this.продатьТоварToolStripMenuItem1.Click += new System.EventHandler(this.продатьТоварToolStripMenuItem1_Click);
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxProductName.Location = new System.Drawing.Point(200, 201);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(220, 26);
            this.textBoxProductName.TabIndex = 2;
            this.textBoxProductName.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Наименование товара";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(146, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Цена";
            this.label2.UseWaitCursor = true;
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.DecimalPlaces = 1;
            this.numericUpDownPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownPrice.Location = new System.Drawing.Point(200, 233);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(173, 26);
            this.numericUpDownPrice.TabIndex = 5;
            this.numericUpDownPrice.UseWaitCursor = true;
            this.numericUpDownPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(94, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количество";
            this.label3.UseWaitCursor = true;
            // 
            // numericUpDownCount
            // 
            this.numericUpDownCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownCount.Location = new System.Drawing.Point(200, 265);
            this.numericUpDownCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCount.Name = "numericUpDownCount";
            this.numericUpDownCount.Size = new System.Drawing.Size(173, 26);
            this.numericUpDownCount.TabIndex = 7;
            this.numericUpDownCount.UseWaitCursor = true;
            this.numericUpDownCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(14, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Список товаров:";
            this.label4.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(437, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(5, 339);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(535, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Автор";
            this.label5.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(460, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Название песни";
            this.label6.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(495, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Имя файла";
            this.label7.UseWaitCursor = true;
            // 
            // authorTextBox
            // 
            this.authorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorTextBox.Location = new System.Drawing.Point(597, 220);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(220, 26);
            this.authorTextBox.TabIndex = 13;
            this.authorTextBox.UseWaitCursor = true;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleTextBox.Location = new System.Drawing.Point(597, 252);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(220, 26);
            this.titleTextBox.TabIndex = 14;
            this.titleTextBox.UseWaitCursor = true;
            // 
            // filenameTextBox
            // 
            this.filenameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filenameTextBox.Location = new System.Drawing.Point(597, 284);
            this.filenameTextBox.Name = "filenameTextBox";
            this.filenameTextBox.Size = new System.Drawing.Size(220, 26);
            this.filenameTextBox.TabIndex = 15;
            this.filenameTextBox.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(465, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 29);
            this.button1.TabIndex = 16;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.AddSongButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(465, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 29);
            this.button2.TabIndex = 17;
            this.button2.Text = "Далее";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.NextSongButton_Click);
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorLabel.Location = new System.Drawing.Point(840, 216);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(0, 20);
            this.authorLabel.TabIndex = 18;
            this.authorLabel.UseWaitCursor = true;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(840, 251);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(0, 20);
            this.titleLabel.TabIndex = 19;
            this.titleLabel.UseWaitCursor = true;
            // 
            // filenameLabel
            // 
            this.filenameLabel.AutoSize = true;
            this.filenameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filenameLabel.Location = new System.Drawing.Point(840, 285);
            this.filenameLabel.Name = "filenameLabel";
            this.filenameLabel.Size = new System.Drawing.Size(0, 20);
            this.filenameLabel.TabIndex = 20;
            this.filenameLabel.UseWaitCursor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(465, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 29);
            this.button3.TabIndex = 21;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.UseWaitCursor = true;
            this.button3.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(795, 44);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(199, 29);
            this.button4.TabIndex = 22;
            this.button4.Text = "Перейти по индексу";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.UseWaitCursor = true;
            this.button4.Click += new System.EventHandler(this.GoToSongButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(869, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 26);
            this.textBox1.TabIndex = 24;
            this.textBox1.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(798, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Индекс:";
            this.label8.UseWaitCursor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(583, 44);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(199, 29);
            this.button5.TabIndex = 25;
            this.button5.Text = "Перейти к началу";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.UseWaitCursor = true;
            this.button5.Click += new System.EventHandler(this.GoToStartButton_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(795, 79);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(199, 29);
            this.button6.TabIndex = 26;
            this.button6.Text = "Удалить композицию";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.UseWaitCursor = true;
            this.button6.Click += new System.EventHandler(this.RemoveSongButton_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(583, 116);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(199, 29);
            this.button7.TabIndex = 27;
            this.button7.Text = "Отчистить плейлист";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.UseWaitCursor = true;
            this.button7.Click += new System.EventHandler(this.ClearPlaylistButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(833, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Текущая композиция:";
            this.label9.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 339);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.filenameLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filenameTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listBoxOfProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task_2_3";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxOfProducts;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem управлениеМагазиномToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьНовыйТоварToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продатьТоварToolStripMenuItem1;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox filenameTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label filenameLabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label9;
    }
}

