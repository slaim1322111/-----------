using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace TextEditor
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cont.Clear();
            openFileDialog1.FileName = @"NewDocument.txt";
            openFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|All files (*.*)|*.*";
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName == String.Empty) return;

            try
            {
                StreamReader reader = new StreamReader(openFileDialog1.FileName, Encoding.GetEncoding(1251));
                cont.Text = reader.ReadToEnd();
                reader.Close();
            }
            catch
            {
                MessageBox.Show("Не удалось открыть файл.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        void SAVE()
        {
            saveFileDialog1.FileName = openFileDialog1.FileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter writer = new StreamWriter(saveFileDialog1.FileName, false, System.Text.Encoding.GetEncoding(1251));
                    writer.Write(cont.Text);
                    writer.Close();
                }
                catch
                {
                    MessageBox.Show("Не удалось сохранить файл.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SAVE();
        }

        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Желаете сохранить документ?", "Ошибка", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
                SAVE();
            Application.Restart();
        }

        private void скопироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cont.Copy();
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataFormats.Format format = DataFormats.GetFormat(DataFormats.UnicodeText);
            cont.Paste(format);
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cont.Cut();
        }

        private void выделитьВсёToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cont.SelectAll();
        }

        private void снятьВыделениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cont.DeselectAll();
        }

        private void отменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cont.Undo();
        }

        private void повторитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cont.Redo();
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void изменитьЦветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                cont.SelectionColor = colorDialog.Color;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void colorStripDropDownButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                cont.SelectionColor = colorDialog.Color;
            }
        }

        private void centerAlignStripButton_Click_1(object sender, EventArgs e)
        {
            cont.SelectionAlignment = HorizontalAlignment.Center;
        }


        private void fontSizeComboBox_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                cont.SelectionFont = fontDialog.Font;
            }
        }


        private void leftAlignStripButton_Click(object sender, EventArgs e)
        {
            cont.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void rightAlignStripButton_Click(object sender, EventArgs e)
        {
            cont.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void шрифт_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                cont.SelectionFont = fontDialog.Font;
            }
        }

        private void boldStripButton3_Click(object sender, EventArgs e)
        {
           
            Font currentFont = cont.SelectionFont;

           
            FontStyle newFontStyle = currentFont.Style ^ FontStyle.Bold;

          
            cont.SelectionFont = new Font(currentFont, newFontStyle);
        }

        private void italicStripButton_Click(object sender, EventArgs e)
        {
       
            Font currentFont = cont.SelectionFont;

        
            FontStyle newFontStyle = currentFont.Style ^ FontStyle.Italic;

            
            cont.SelectionFont = new Font(currentFont, newFontStyle);
        }

        private void underlineStripButton_Click(object sender, EventArgs e)
        {
        
            Font currentFont = cont.SelectionFont;

          
            FontStyle newFontStyle = currentFont.Style ^ FontStyle.Underline;

      
            cont.SelectionFont = new Font(currentFont, newFontStyle);
        }

        private void printPreviewStripButton_Click(object sender, EventArgs e)
        {
            string searchWord = "слово"; 

            int index = 0;
            while (index < cont.TextLength)
            {
                index = cont.Find(searchWord, index, RichTextBoxFinds.None);
                if (index == -1) break;

                
                cont.SelectionBackColor = Color.Yellow;

                index += searchWord.Length;
            }
        }

        private void increaseStripButton_Click(object sender, EventArgs e)
        {
            if (cont.SelectionFont != null)
            {
                float newSize = cont.SelectionFont.Size + 1; 
                if (newSize >= 1) 
                {
                    cont.SelectionFont = new Font(cont.SelectionFont.FontFamily, newSize, cont.SelectionFont.Style);
                }
            }
        }

        private void decreaseStripButton_Click(object sender, EventArgs e)
        {
            if (cont.SelectionFont != null)
            {
                float newSize = cont.SelectionFont.Size - 1; 
                if (newSize >= 1) 
                {
                    cont.SelectionFont = new Font(cont.SelectionFont.FontFamily, newSize, cont.SelectionFont.Style);
                }
            }
        }

        private void clearFormattingStripButton_Click(object sender, EventArgs e)
        {
            cont.SelectionFont = null;
            cont.SelectionColor = Color.Black;
            cont.SelectionBackColor = Color.White;
            cont.SelectionAlignment = HorizontalAlignment.Left;
            cont.SelectionBullet = false;
            cont.SelectionIndent = 0;
            cont.SelectionHangingIndent = 0;
            cont.SelectionRightIndent = 0;
            cont.SelectionCharOffset = 0;
            cont.SelectionLength = 0;
        }
    }
}
