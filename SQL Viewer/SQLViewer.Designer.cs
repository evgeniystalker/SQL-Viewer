
namespace SQL_Viewer
{
    partial class SQLViewer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выделитьВсёToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.опрограммеtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusCountRow = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusCountIndex = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusPosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.contextMenuStripForTabsControl = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.создатьВкладкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьВкладкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переименоватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВкладкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBoxMain = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1RichTextBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.выделитьВсёToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.contextMenuStripForTabsControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.contextMenuStrip1RichTextBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.очиститьToolStripMenuItem,
            this.закрытьToolStripMenuItem,
            this.опрограммеtoolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(894, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выделитьВсёToolStripMenuItem,
            this.копироватьToolStripMenuItem,
            this.вырезатьToolStripMenuItem,
            this.вставитьToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // выделитьВсёToolStripMenuItem
            // 
            this.выделитьВсёToolStripMenuItem.Name = "выделитьВсёToolStripMenuItem";
            this.выделитьВсёToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.выделитьВсёToolStripMenuItem.Text = "Выделить все";
            this.выделитьВсёToolStripMenuItem.Click += new System.EventHandler(this.выделитьВсёToolStripMenuItem_Click);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.вырезатьToolStripMenuItem.Text = "Вырезать";
            this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.вырезатьToolStripMenuItem_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.вставитьToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // опрограммеtoolStripMenuItem
            // 
            this.опрограммеtoolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.опрограммеtoolStripMenuItem.Name = "опрограммеtoolStripMenuItem";
            this.опрограммеtoolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.опрограммеtoolStripMenuItem.Text = "О программе";
            this.опрограммеtoolStripMenuItem.Click += new System.EventHandler(this.опрограммеtoolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusCountRow,
            this.toolStripStatusCountIndex,
            this.toolStripStatusPosition});
            this.statusStrip1.Location = new System.Drawing.Point(0, 727);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(894, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusCountRow
            // 
            this.toolStripStatusCountRow.Name = "toolStripStatusCountRow";
            this.toolStripStatusCountRow.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusCountRow.Text = "Количество строк: 0";
            // 
            // toolStripStatusCountIndex
            // 
            this.toolStripStatusCountIndex.Name = "toolStripStatusCountIndex";
            this.toolStripStatusCountIndex.Size = new System.Drawing.Size(100, 17);
            this.toolStripStatusCountIndex.Text = "Индекс строки: 0";
            // 
            // toolStripStatusPosition
            // 
            this.toolStripStatusPosition.Name = "toolStripStatusPosition";
            this.toolStripStatusPosition.Size = new System.Drawing.Size(77, 17);
            this.toolStripStatusPosition.Text = "стр 1 : стлб 0";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(894, 703);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(787, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(104, 697);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор цвета:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Цвет текста:";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(23, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(75, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Применить цвета";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.ContextMenuStrip = this.contextMenuStripForTabsControl;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(778, 697);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            // 
            // contextMenuStripForTabsControl
            // 
            this.contextMenuStripForTabsControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьВкладкуToolStripMenuItem,
            this.сохранитьВкладкуToolStripMenuItem,
            this.переименоватьToolStripMenuItem,
            this.удалитьВкладкуToolStripMenuItem});
            this.contextMenuStripForTabsControl.Name = "contextMenuStripForTabsControl";
            this.contextMenuStripForTabsControl.Size = new System.Drawing.Size(162, 92);
            // 
            // создатьВкладкуToolStripMenuItem
            // 
            this.создатьВкладкуToolStripMenuItem.Name = "создатьВкладкуToolStripMenuItem";
            this.создатьВкладкуToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.создатьВкладкуToolStripMenuItem.Text = "Создать";
            this.создатьВкладкуToolStripMenuItem.Click += new System.EventHandler(this.создатьВкладкуToolStripMenuItem_Click);
            // 
            // сохранитьВкладкуToolStripMenuItem
            // 
            this.сохранитьВкладкуToolStripMenuItem.Name = "сохранитьВкладкуToolStripMenuItem";
            this.сохранитьВкладкуToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.сохранитьВкладкуToolStripMenuItem.Text = "Сохранить";
            this.сохранитьВкладкуToolStripMenuItem.Click += new System.EventHandler(this.сохранитьВкладкуToolStripMenuItem_Click);
            // 
            // переименоватьToolStripMenuItem
            // 
            this.переименоватьToolStripMenuItem.Name = "переименоватьToolStripMenuItem";
            this.переименоватьToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.переименоватьToolStripMenuItem.Text = "Переименовать";
            this.переименоватьToolStripMenuItem.Click += new System.EventHandler(this.переименоватьToolStripMenuItem_Click);
            // 
            // удалитьВкладкуToolStripMenuItem
            // 
            this.удалитьВкладкуToolStripMenuItem.Name = "удалитьВкладкуToolStripMenuItem";
            this.удалитьВкладкуToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.удалитьВкладкуToolStripMenuItem.Text = "Удалить";
            this.удалитьВкладкуToolStripMenuItem.Click += new System.EventHandler(this.удалитьВкладкуToolStripMenuItem_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBoxMain);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(770, 671);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SQL 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBoxMain
            // 
            this.richTextBoxMain.ContextMenuStrip = this.contextMenuStrip1RichTextBox;
            this.richTextBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxMain.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxMain.Name = "richTextBoxMain";
            this.richTextBoxMain.Size = new System.Drawing.Size(764, 665);
            this.richTextBoxMain.TabIndex = 1;
            this.richTextBoxMain.Text = "";
            this.richTextBoxMain.SelectionChanged += new System.EventHandler(this.richTextBoxMain_SelectionChanged);
            this.richTextBoxMain.TextChanged += new System.EventHandler(this.richTextBoxMain_TextChanged);
            // 
            // contextMenuStrip1RichTextBox
            // 
            this.contextMenuStrip1RichTextBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выделитьВсёToolStripMenuItem1,
            this.вырезатьToolStripMenuItem1,
            this.копироватьToolStripMenuItem1,
            this.вставитьToolStripMenuItem1});
            this.contextMenuStrip1RichTextBox.Name = "contextMenuStrip1";
            this.contextMenuStrip1RichTextBox.Size = new System.Drawing.Size(149, 92);
            // 
            // выделитьВсёToolStripMenuItem1
            // 
            this.выделитьВсёToolStripMenuItem1.Name = "выделитьВсёToolStripMenuItem1";
            this.выделитьВсёToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.выделитьВсёToolStripMenuItem1.Text = "Выделить всё";
            this.выделитьВсёToolStripMenuItem1.Click += new System.EventHandler(this.выделитьВсёToolStripMenuItem_Click);
            // 
            // вырезатьToolStripMenuItem1
            // 
            this.вырезатьToolStripMenuItem1.Name = "вырезатьToolStripMenuItem1";
            this.вырезатьToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.вырезатьToolStripMenuItem1.Text = "Вырезать";
            this.вырезатьToolStripMenuItem1.Click += new System.EventHandler(this.вырезатьToolStripMenuItem_Click);
            // 
            // копироватьToolStripMenuItem1
            // 
            this.копироватьToolStripMenuItem1.Name = "копироватьToolStripMenuItem1";
            this.копироватьToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.копироватьToolStripMenuItem1.Text = "Копировать";
            this.копироватьToolStripMenuItem1.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // вставитьToolStripMenuItem1
            // 
            this.вставитьToolStripMenuItem1.Name = "вставитьToolStripMenuItem1";
            this.вставитьToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.вставитьToolStripMenuItem1.Text = "Вставить";
            this.вставитьToolStripMenuItem1.Click += new System.EventHandler(this.вставитьToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 749);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SQL Viewer";
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.contextMenuStripForTabsControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.contextMenuStrip1RichTextBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusCountRow;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem выделитьВсёToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1RichTextBox;
        private System.Windows.Forms.ToolStripMenuItem выделитьВсёToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusCountIndex;
        private System.Windows.Forms.ToolStripMenuItem опрограммеtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusPosition;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripForTabsControl;
        private System.Windows.Forms.ToolStripMenuItem создатьВкладкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВкладкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьВкладкуToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBoxMain;
        private System.Windows.Forms.ToolStripMenuItem переименоватьToolStripMenuItem;
    }
}


