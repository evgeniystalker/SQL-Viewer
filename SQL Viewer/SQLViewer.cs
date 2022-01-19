
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Viewer
{
    public partial class SQLViewer : Form
    {
        List<Color> listColor = new List<Color> {
                Color.Black,
                Color.LimeGreen,
                Color.MediumVioletRed,
                Color.Blue,

                Color.SaddleBrown,
                Color.SlateGray,
                Color.Brown,
                Color.Orange,
                Color.Empty,
                Color.Empty,
                Color.Empty,
                Color.Red,
                Color.MediumSlateBlue

        };
        List<Button> groupButton = new List<Button>();
        Button CommentButtom = new Button();
        Button SyntaxButton = new Button();

        public SQLViewer()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 6;// loadButton
        }

        //Строка состояния
        private void richTextBoxMain_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusCountRow.Text = "Количество строк: " + (tabControl1.SelectedTab.Controls[0] as RichTextBox).Lines.Length;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<int[]> listComments = ColoringText.FindComments(tabControl1.SelectedTab.Controls[0] as RichTextBox);
            List<List<int[]>> listScobs = ColoringText.FindScobsRegex(tabControl1.SelectedTab.Controls[0] as RichTextBox, listComments);
            ColoringText.ColoringScobs(tabControl1.SelectedTab.Controls[0] as RichTextBox, groupButton, CommentButtom, SyntaxButton, listScobs, listComments);
        }

        private void LoadButton(int CountButton)
        {
            if (groupButton.Count < CountButton)
            {
                for (int i = groupButton.Count; i < CountButton; i++)
                {
                    groupButton.Add(new Button());
                    groupButton[i].Location = new System.Drawing.Point(20, 100 + (i) * 25);
                    groupButton[i].Name = "autobutton" + (i);
                    groupButton[i].Size = new System.Drawing.Size(75, 23);
                    groupButton[i].TabIndex = 3 + (i);
                    groupButton[i].UseVisualStyleBackColor = true;
                    groupButton[i].Click += new System.EventHandler(this.groupButton_Click);
                    groupButton[i].BackColor = listColor[i];
                    this.groupBox1.Controls.Add(groupButton[i]);

                    if (i != 0)
                    {
                        Label label = new Label();
                        label.Text = i + ":";
                        label.AutoSize = true;
                        label.Location = new System.Drawing.Point(2, 105 + (i) * 25);
                        label.Name = i + ":";
                        this.groupBox1.Controls.Add(label);
                    }

                }
            }
            else

            {
                for (int i = groupButton.Count - 1; i >= CountButton; i--)
                {
                    groupBox1.Controls.Remove(groupButton[i]);
                    groupButton.Remove(groupButton[i]);
                    groupBox1.Controls.Remove(groupBox1.Controls[i + ":"]);
                }
            }
        }

        private void LoadButtonComment(int i)
        {
            Label LabelComment = new Label();
            LabelComment.Location = new System.Drawing.Point(12, 100 + (11) * 25);
            LabelComment.Text = "Цвет \nкомментариев: ";
            LabelComment.TextAlign = ContentAlignment.MiddleCenter;
            LabelComment.Name = "ColorComment";
            LabelComment.AutoSize = true;
            this.groupBox1.Controls.Add(LabelComment);

            CommentButtom.Location = new System.Drawing.Point(20, 110 + (11 + 1) * 25);
            CommentButtom.Name = "CommentButton";
            CommentButtom.Size = new System.Drawing.Size(75, 23);
            CommentButtom.TabIndex = 3 + (11);
            CommentButtom.UseVisualStyleBackColor = true;
            CommentButtom.Click += new System.EventHandler(this.groupButton_Click);
            CommentButtom.BackColor = listColor[11];
            this.groupBox1.Controls.Add(CommentButtom);
        }

        private void LoadButtonSyntax(int i)
        {
            Label LabelSyntax = new Label();
            LabelSyntax.Location = new System.Drawing.Point(12, 100 + (11) * 25 + i * 10);
            LabelSyntax.Text = "Цвет \nсинтаксиса слов: ";
            LabelSyntax.TextAlign = ContentAlignment.MiddleCenter;
            LabelSyntax.Name = "ColorSyntaxWords";
            LabelSyntax.AutoSize = true;
            this.groupBox1.Controls.Add(LabelSyntax);

            SyntaxButton.Location = new System.Drawing.Point(20, 110 + (11 + 1) * 25 + i * 10);
            SyntaxButton.Name = "SyntaxButton";
            SyntaxButton.Size = new System.Drawing.Size(75, 23);
            SyntaxButton.TabIndex = 3 + (12);
            SyntaxButton.UseVisualStyleBackColor = true;
            SyntaxButton.Click += new System.EventHandler(this.groupButton_Click);
            SyntaxButton.BackColor = listColor[12];
            this.groupBox1.Controls.Add(SyntaxButton);

        }
        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (tabControl1.SelectedTab.Controls[0] as RichTextBox).Copy();
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (tabControl1.SelectedTab.Controls[0] as RichTextBox).Cut();
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (tabControl1.SelectedTab.Controls[0] as RichTextBox).Paste();
        }

        private void выделитьВсёToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (tabControl1.SelectedTab.Controls[0] as RichTextBox).SelectAll();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = ".txt";
            openFileDialog.Filter = "Текстовые файлы (*.txt)| *.txt|Текстовые файлы (*.rtf)| *.rtf";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(openFileDialog.FileName) == ".txt")
                    (tabControl1.SelectedTab.Controls[0] as RichTextBox).Text = File.ReadAllText(openFileDialog.FileName);

                else if (Path.GetExtension(openFileDialog.FileName) == ".rtf")
                    (tabControl1.SelectedTab.Controls[0] as RichTextBox).Rtf = File.ReadAllText(openFileDialog.FileName);
            }

            Console.WriteLine("Выбран файл: " + openFileDialog.FileName);

        }


        private void groupButton_Click(object sender, EventArgs e)
        {


            if (DialogResult.OK == colorDialog1.ShowDialog())
            {
                (sender as Button).BackColor = colorDialog1.Color;
                listColor[(sender as Button).TabIndex - 3] = colorDialog1.Color;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadButton(comboBox1.SelectedIndex + 1);
            LoadButtonComment(comboBox1.SelectedIndex + 1);
            LoadButtonSyntax(comboBox1.SelectedIndex + 2);
        }

        private void richTextBoxMain_SelectionChanged(object sender, EventArgs e)
        {
            RichTextBox richTextBox = (tabControl1.SelectedTab.Controls[0] as RichTextBox);
            toolStripStatusCountIndex.Text = "Индекс строки: " + (richTextBox.SelectionStart + richTextBox.SelectionLength);
            toolStripStatusPosition.Text = "Строка: " + (richTextBox.GetLineFromCharIndex(richTextBox.SelectionStart + richTextBox.SelectionLength) + 1) + "| столбец: " + (richTextBox.SelectionStart + richTextBox.SelectionLength - richTextBox.GetFirstCharIndexOfCurrentLine());
        }

        private void опрограммеtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработчики: Кудик Е.А., Ибрагимов А.М.");
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (tabControl1.SelectedTab.Controls[0] as RichTextBox).Clear();
        }

        private void создатьВкладкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = tabControl1.TabCount + 1;
            TabPage tab = new TabPage();
            RichTextBox richTextBox = new RichTextBox();
            richTextBox.TextChanged += new System.EventHandler(this.richTextBoxMain_TextChanged);
            richTextBox.SelectionChanged += new System.EventHandler(this.richTextBoxMain_SelectionChanged);

            richTextBox.ContextMenuStrip = this.contextMenuStrip1RichTextBox;
            richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            richTextBox.Location = new System.Drawing.Point(3, 3);
            richTextBox.Name = "richTextBoxMain";
            richTextBox.Size = new System.Drawing.Size(765, 668);
            richTextBox.TabIndex = 1;
            richTextBox.Text = "";
            tab.Controls.Add(richTextBox);
            tab.Location = new System.Drawing.Point(4, 22);
            tab.Name = "tabPage" + i;
            tab.Padding = new System.Windows.Forms.Padding(3);
            tab.Size = new System.Drawing.Size(771, 674);
            tab.TabIndex = i - 1;

            tab.Text = "SQL " + i;
            tab.UseVisualStyleBackColor = true;
            this.tabControl1.Controls.Add(tab);
            this.tabControl1.SelectTab(tab);
        }

        private void удалитьВкладкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Действительно удалить вкладку " + tabControl1.SelectedTab.Text, "", MessageBoxButtons.YesNo))
                if (tabControl1.TabCount <= 1)
                    MessageBox.Show("Невозможно удалить послденюю вкладку!");
                else
                    tabControl1.Controls.Remove(tabControl1.SelectedTab);
        }

        private void tabControl1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                for (int i = 0; i < tabControl1.TabCount; i++)
                {
                    if (tabControl1.GetTabRect(i).Contains(e.Location))
                    {
                        tabControl1.SelectTab(i);
                    }
                }
            }
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if ((sender as TabControl).SelectedIndex == tabControl1.TabCount - 1)
                создатьВкладкуToolStripMenuItem_Click(sender, e);
        }

        private void переименоватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form rename = new FormRenameTab();

            // rename.Parent = this;
            rename.StartPosition = FormStartPosition.Manual;
            rename.DesktopLocation = new Point(this.Location.X + this.Width / 2 - rename.Width / 2, this.Location.Y + this.Height / 2 - rename.Height / 2);
            rename.Text = tabControl1.SelectedTab.Text;
            rename.Controls["renameTextBox"].Text = rename.Text;
            (rename.Controls["renameTextBox"] as TextBox).Select();
            (rename.Controls["renameTextBox"] as TextBox).SelectAll();
            rename.ShowDialog(this);
            if (rename.DialogResult == DialogResult.OK)
            {
                tabControl1.SelectedTab.Text = rename.Controls["renameTextBox"].Text;
            }
        }

        private void сохранитьВкладкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.Filter = "Текстовые файлы (*.rtf)| *.rtf|Текстовые файлы (*.txt)| *.txt";
            saveFileDialog.FileName = tabControl1.SelectedTab.Text;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                if (Path.GetExtension(saveFileDialog.FileName) == ".txt")
                    File.WriteAllText(saveFileDialog.FileName, (tabControl1.SelectedTab.Controls[0] as RichTextBox).Text);

                else if (Path.GetExtension(saveFileDialog.FileName) == ".rtf")
                    File.WriteAllText(saveFileDialog.FileName, (tabControl1.SelectedTab.Controls[0] as RichTextBox).Rtf);
            }

            Console.WriteLine("Сохранен файл: " + saveFileDialog.FileName);
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {

        }
    }
}
