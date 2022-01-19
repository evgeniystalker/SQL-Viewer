
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace SQL_Viewer
{
    class ColoringText
    {
        /// <summary>
        /// Метод ищет коментарии.
        /// </summary>
        /// <param name="richTextBox">Ричтекстбокс полностю</param>
        static public List<int[]> FindComments(RichTextBox richTextBox)
        {

            List<int[]> listComents = new List<int[]>();
            //comment -- 
            int indStart = 0;
            int indEnd = 0;
            while (indStart != -1)
            {
                indStart = richTextBox.Text.IndexOf("--", indStart);
                if (indStart != -1)
                {
                    indEnd = richTextBox.Text.IndexOf('\n', indStart);
                    indEnd = indEnd != -1 ? indEnd - 1 : richTextBox.Text.Length - 1;
                    listComents.Add(new int[] { indStart, indEnd });
                    indStart = indEnd;
                }
            }
            //comment /*  */

            indStart = 0;
            while (indStart != -1)
            {
                indStart = richTextBox.Text.IndexOf("/*", indStart);
                if (indStart != -1)
                {
                    indEnd = richTextBox.Text.IndexOf("*/", indStart + 2);
                    indEnd = (indEnd != -1) ? indEnd + 1 : richTextBox.Text.Length - 1;
                    listComents.Add(new int[] { indStart, indEnd });
                    if (indEnd == richTextBox.Text.Length - 1)
                    { break; }
                    indStart = indEnd;
                }

            }

            return listComents;
        }


        /// <summary>
        /// Метод ищет все скобки, устарел не используется.
        /// </summary>
        /// <param name="richTextBox">Ричтекстбокс полностю</param>
        static public List<List<int[]>> FindScobsIndexOf(RichTextBox richTextBox, List<int[]> listComments)
        {
            var rank = 0;
            int indStart = 0;
            int indEnd = richTextBox.Text.Length - 1;
            List<List<int[]>> listRanks = new List<List<int[]>>();


            while (true)
            {
                indStart = richTextBox.Text.IndexOf('(', indStart);
                if (indStart == -1)
                {
                    break;
                }
                if (listRanks.Count <= rank)
                {
                    //Добавить новый ранк(список).
                    listRanks.Add(new List<int[]>());
                }
                //Добавить новый массив в список ранга // Если не в коменте//если не входит перейти к следующей (
                bool vhodit = false;
                foreach (var indexComment in listComments)

                {
                    if ((indexComment[0] < indStart) && (indStart < indexComment[1]))
                    {
                        vhodit = true;
                        indStart++;
                        break;
                    }
                }
                if (vhodit == false)
                {
                    ////Добавить новый массив в список ранга
                    listRanks[rank].Add(new int[] { indStart, 0 });
                    rank++;//счетчик ранга
                    indStart = indStart + 1;

                    while (true)
                    {
                        indEnd = richTextBox.Text.IndexOf('(', indStart);
                        if (indEnd != -1)
                        {
                            int b = richTextBox.Text.IndexOf(')', indStart, indEnd - indStart + 1);
                            if (b == -1)
                            {
                                break;
                            }
                            rank--;
                            listRanks[rank][listRanks[rank].Count - 1][1] = b;
                            indStart = b + 1;

                        }
                        //обработка последней скобки если нет больше открытых.
                        else
                        {
                            int b = richTextBox.Text.IndexOf(')', indStart);
                            if (b == -1)
                            {
                                break;
                            }
                            rank--;
                            listRanks[rank][listRanks[rank].Count - 1][1] = b;
                            indStart = b + 1;
                            break;
                        }

                    }
                }

            }




            //for (int i = 0; i < richTextBox.Text.Length; i++)
            //{
            //    if (richTextBox.Text[i] == '(')
            //    {
            //        if (listRanks.Count <= rank)
            //        {
            //            //Добавить новый ранк(список).
            //            listRanks.Add(new List<int[]>());
            //        }
            //        //Добавить новый массив в список ранга
            //        listRanks[rank].Add(new int[] { i, 0 });
            //        rank++;//счетчик ранга
            //    }
            //    else if ((richTextBox.Text[i] == ')') && (rank != 0))
            //    {
            //        //Опустить ранг и записать индекс конечной скобы в последний созданный массив.
            //        rank--
;
            //        listRanks[rank][listRanks[rank].Count - 1][1] = i;

            //    }
            //}

            return listRanks;
        }
        /// <summary>
        /// Метод красящий от скобки '(' до скобки ')'
        /// </summary>
        /// <param name="richTextBox"></param>
        /// <param name="listColor"></param>
        /// <param name="groupButton"></param>

        /// <param name="listScobs"></param>
        static public void ColoringScobs(RichTextBox richTextBox, in List<Button> groupButton, in Button buttonComments, in Button syntaxButonn, List<List<int[]>> listScobs, List<int[]> listComment)
        {

            var indStart = 0;
            var indEnd = richTextBox.Text.Length - 1;
            var temp = richTextBox.SelectionStart;


            //Красим все в черный.
            richTextBox.SelectionStart = indStart;
            richTextBox.SelectionLength = (indEnd + 1) - indStart;
            richTextBox.SelectionColor = groupButton[0].BackColor;
            richTextBox.DeselectAll();


            //Начинаем покраску. c=1; для перебора цвета.
            for (int i = 0, c = 1; i < listScobs.Count; i++, c++)
            {
                if (c >= groupButton.Count)
                {
                    c = 1;
                }
                for (int j = 0; j < listScobs[i].Count; j++)
                {

                    indStart = listScobs[i][j][0];
                    indEnd = listScobs[i][j][1];

                    try
                    {
                        richTextBox.SelectionStart = indStart;
                        richTextBox.SelectionLength = (indEnd + 1) - indStart;
                        richTextBox.SelectionColor = groupButton[c].BackColor;
                        richTextBox.DeselectAll();
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        MessageBox.Show($"Разница индексов конечной ({indEnd}) +1 и начальной ({indStart}) скобки меньше 0");
                    }


                }

            }
            //Syntax word
            List<int[]> wordsIndex = FindSyntaxWords(richTextBox, new List<string> { "select ", "from ", "begin ", "end ", "insert ", "update ", "values ", "if ", "left ", "right ", "join " });
            foreach (var index in wordsIndex)
            {
                richTextBox.SelectionStart = index[0];
                richTextBox.SelectionLength = index[1] + 1 - index[0];
                richTextBox.SelectionColor = syntaxButonn.BackColor;
                richTextBox.DeselectAll();
            }

            //comment
            foreach (var index in listComment)
            {

                richTextBox.SelectionStart = index[0];
                richTextBox.SelectionLength = index[1] + 1 - index[0];
                richTextBox.SelectionColor = buttonComments.BackColor;
                richTextBox.DeselectAll();
            }

            //Возврат индикатора
            richTextBox.SelectionStart = temp;
        }

        /// <summary>
        /// Метод ищет все скобки через REGEX.
        /// </summary>
        /// <param name="richTextBox">Ричтекстбокс полностю</param>
        static public List<List<int[]>> FindScobsRegex(RichTextBox richTextBox, List<int[]> listComments)
        {
            var rank = 0;
            List<List<int[]>> listRanks = new List<List<int[]>>();
            Regex regex = new Regex(@"\(|\)");
            MatchCollection matches = regex.Matches(richTextBox.Text);



            foreach (Match match in matches)
            {
                bool checkComment = false;
                foreach (var indexComment in listComments)
                {
                    if ((indexComment[0] <= match.Index) && (match.Index <= indexComment[1]))

                    {
                        checkComment = true;
                        break;
                    }

                }

                if ((match.Value == "(") && (checkComment == false))
                {
                    if (listRanks.Count <= rank)
                    {
                        //Добавить новый ранк(список).
                        listRanks.Add(new List<int[]>());
                    }
                    listRanks[rank].Add(new int[] { match.Index, richTextBox.Text.Length - 1 });

                    rank++;//счетчик ранга

                }
                else if ((match.Value == ")") && (checkComment == false))
                {
                    if (rank == 0)
                    {
                        if (listRanks.Count <= rank)
                        {
                            //Добавить новый ранк(список).
                            listRanks.Add(new List<int[]>());
                        }
                        listRanks[rank].Add(new int[] { match.Index, match.Index });
                    }
                    else
                    {
                        rank--;

                        listRanks[rank][listRanks[rank].Count - 1][1] = match.Index;

                    }
                    //Если не записал скобку понизить ранк

                }

            }
            return listRanks;
        }
        static public List<int[]> FindSyntaxWords(RichTextBox richTextBox, List<string> words)
        {
            //Select
            List<int[]> syntaxWords = new List<int[]>();


            foreach (var word in words)
            {
                int indStart = 0;
                int indEnd = 0;
                while (indStart != -1)
                {
                    indStart = richTextBox.Text.IndexOf(word, indStart, StringComparison.CurrentCultureIgnoreCase);
                    if (indStart != -1)
                    {
                        indEnd = indStart + word.Length - 1;

                        syntaxWords.Add(new int[] { indStart, indEnd });

                        indStart = indEnd;
                    }
                }

            }
            return syntaxWords;
        }

    }
}