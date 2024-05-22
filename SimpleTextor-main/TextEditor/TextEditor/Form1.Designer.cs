
namespace TextEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скопироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.повторитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выделитьВсёToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.снятьВыделениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.leftAlignStripButton = new System.Windows.Forms.ToolStripButton();
            this.centerAlignStripButton = new System.Windows.Forms.ToolStripButton();
            this.rightAlignStripButton = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.изменитьЦвет = new System.Windows.Forms.ColorDialog();
            this.cont = new System.Windows.Forms.RichTextBox();
            this.шрифт = new System.Windows.Forms.Button();
            this.boldStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.italicStripButton = new System.Windows.Forms.ToolStripButton();
            this.underlineStripButton = new System.Windows.Forms.ToolStripButton();
            this.increaseStripButton = new System.Windows.Forms.ToolStripButton();
            this.decreaseStripButton = new System.Windows.Forms.ToolStripButton();
            this.clearFormattingStripButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.colorStripDropDownButton,
            this.leftAlignStripButton,
            this.centerAlignStripButton,
            this.rightAlignStripButton,
            this.boldStripButton3,
            this.italicStripButton,
            this.underlineStripButton,
            this.increaseStripButton,
            this.decreaseStripButton,
            this.clearFormattingStripButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 23);
            this.файлToolStripMenuItem.Text = "Файл";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // новыйToolStripMenuItem
            // 
            this.новыйToolStripMenuItem.Name = "новыйToolStripMenuItem";
            this.новыйToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.новыйToolStripMenuItem.Text = "Новый ";
            this.новыйToolStripMenuItem.Click += new System.EventHandler(this.новыйToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.скопироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.вырезатьToolStripMenuItem,
            this.отменитьToolStripMenuItem,
            this.повторитьToolStripMenuItem,
            this.выделитьВсёToolStripMenuItem,
            this.снятьВыделениеToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 23);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // скопироватьToolStripMenuItem
            // 
            this.скопироватьToolStripMenuItem.Name = "скопироватьToolStripMenuItem";
            this.скопироватьToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.скопироватьToolStripMenuItem.Text = "Скопировать";
            this.скопироватьToolStripMenuItem.Click += new System.EventHandler(this.скопироватьToolStripMenuItem_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.вставитьToolStripMenuItem_Click);
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.вырезатьToolStripMenuItem.Text = "Вырезать";
            this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.вырезатьToolStripMenuItem_Click);
            // 
            // отменитьToolStripMenuItem
            // 
            this.отменитьToolStripMenuItem.Name = "отменитьToolStripMenuItem";
            this.отменитьToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.отменитьToolStripMenuItem.Text = "Отменить";
            this.отменитьToolStripMenuItem.Click += new System.EventHandler(this.отменитьToolStripMenuItem_Click);
            // 
            // повторитьToolStripMenuItem
            // 
            this.повторитьToolStripMenuItem.Name = "повторитьToolStripMenuItem";
            this.повторитьToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.повторитьToolStripMenuItem.Text = "Повторить";
            this.повторитьToolStripMenuItem.Click += new System.EventHandler(this.повторитьToolStripMenuItem_Click);
            // 
            // выделитьВсёToolStripMenuItem
            // 
            this.выделитьВсёToolStripMenuItem.Name = "выделитьВсёToolStripMenuItem";
            this.выделитьВсёToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.выделитьВсёToolStripMenuItem.Text = "Выделить всё";
            this.выделитьВсёToolStripMenuItem.Click += new System.EventHandler(this.выделитьВсёToolStripMenuItem_Click);
            // 
            // снятьВыделениеToolStripMenuItem
            // 
            this.снятьВыделениеToolStripMenuItem.Name = "снятьВыделениеToolStripMenuItem";
            this.снятьВыделениеToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.снятьВыделениеToolStripMenuItem.Text = "Снять выделение";
            this.снятьВыделениеToolStripMenuItem.Click += new System.EventHandler(this.снятьВыделениеToolStripMenuItem_Click);
            // 
            // colorStripDropDownButton
            // 
            this.colorStripDropDownButton.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.colorStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colorStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.colorStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("colorStripDropDownButton.Image")));
            this.colorStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colorStripDropDownButton.Name = "colorStripDropDownButton";
            this.colorStripDropDownButton.Size = new System.Drawing.Size(29, 20);
            this.colorStripDropDownButton.Text = "Font Color";
            this.colorStripDropDownButton.Click += new System.EventHandler(this.colorStripDropDownButton_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // leftAlignStripButton
            // 
            this.leftAlignStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.leftAlignStripButton.Image = ((System.Drawing.Image)(resources.GetObject("leftAlignStripButton.Image")));
            this.leftAlignStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.leftAlignStripButton.Name = "leftAlignStripButton";
            this.leftAlignStripButton.Size = new System.Drawing.Size(23, 20);
            this.leftAlignStripButton.Text = "Left Align";
            this.leftAlignStripButton.Click += new System.EventHandler(this.leftAlignStripButton_Click);
            // 
            // centerAlignStripButton
            // 
            this.centerAlignStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.centerAlignStripButton.Image = ((System.Drawing.Image)(resources.GetObject("centerAlignStripButton.Image")));
            this.centerAlignStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.centerAlignStripButton.Name = "centerAlignStripButton";
            this.centerAlignStripButton.Size = new System.Drawing.Size(23, 20);
            this.centerAlignStripButton.Text = "Center Align";
            this.centerAlignStripButton.Click += new System.EventHandler(this.centerAlignStripButton_Click_1);
            // 
            // rightAlignStripButton
            // 
            this.rightAlignStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rightAlignStripButton.Image = ((System.Drawing.Image)(resources.GetObject("rightAlignStripButton.Image")));
            this.rightAlignStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rightAlignStripButton.Name = "rightAlignStripButton";
            this.rightAlignStripButton.Size = new System.Drawing.Size(23, 20);
            this.rightAlignStripButton.Text = "Right Align";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cont
            // 
            this.cont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cont.Location = new System.Drawing.Point(0, 27);
            this.cont.Name = "cont";
            this.cont.Size = new System.Drawing.Size(800, 423);
            this.cont.TabIndex = 0;
            this.cont.Text = "";
            // 
            // шрифт
            // 
            this.шрифт.Location = new System.Drawing.Point(352, 2);
            this.шрифт.Name = "шрифт";
            this.шрифт.Size = new System.Drawing.Size(75, 25);
            this.шрифт.TabIndex = 2;
            this.шрифт.Text = "Шрифт";
            this.шрифт.UseVisualStyleBackColor = true;
            this.шрифт.Click += new System.EventHandler(this.шрифт_Click);
            // 
            // boldStripButton3
            // 
            this.boldStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.boldStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("boldStripButton3.Image")));
            this.boldStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boldStripButton3.Name = "boldStripButton3";
            this.boldStripButton3.Size = new System.Drawing.Size(23, 20);
            this.boldStripButton3.Text = "Bold";
            this.boldStripButton3.Click += new System.EventHandler(this.boldStripButton3_Click);
            // 
            // italicStripButton
            // 
            this.italicStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.italicStripButton.Image = ((System.Drawing.Image)(resources.GetObject("italicStripButton.Image")));
            this.italicStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italicStripButton.Name = "italicStripButton";
            this.italicStripButton.Size = new System.Drawing.Size(23, 20);
            this.italicStripButton.Text = "Italics";
            this.italicStripButton.Click += new System.EventHandler(this.italicStripButton_Click);
            // 
            // underlineStripButton
            // 
            this.underlineStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.underlineStripButton.Image = ((System.Drawing.Image)(resources.GetObject("underlineStripButton.Image")));
            this.underlineStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underlineStripButton.Name = "underlineStripButton";
            this.underlineStripButton.Size = new System.Drawing.Size(23, 20);
            this.underlineStripButton.Text = "Underline";
            this.underlineStripButton.Click += new System.EventHandler(this.underlineStripButton_Click);
            // 
            // increaseStripButton
            // 
            this.increaseStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.increaseStripButton.Image = ((System.Drawing.Image)(resources.GetObject("increaseStripButton.Image")));
            this.increaseStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.increaseStripButton.Name = "increaseStripButton";
            this.increaseStripButton.Size = new System.Drawing.Size(23, 20);
            this.increaseStripButton.Text = "Increase Font Size";
            this.increaseStripButton.Click += new System.EventHandler(this.increaseStripButton_Click);
            // 
            // decreaseStripButton
            // 
            this.decreaseStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.decreaseStripButton.Image = ((System.Drawing.Image)(resources.GetObject("decreaseStripButton.Image")));
            this.decreaseStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.decreaseStripButton.Name = "decreaseStripButton";
            this.decreaseStripButton.Size = new System.Drawing.Size(23, 20);
            this.decreaseStripButton.Text = "Decrease Font Size";
            this.decreaseStripButton.Click += new System.EventHandler(this.decreaseStripButton_Click);
            // 
            // clearFormattingStripButton
            // 
            this.clearFormattingStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clearFormattingStripButton.Image = ((System.Drawing.Image)(resources.GetObject("clearFormattingStripButton.Image")));
            this.clearFormattingStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearFormattingStripButton.Name = "clearFormattingStripButton";
            this.clearFormattingStripButton.Size = new System.Drawing.Size(23, 20);
            this.clearFormattingStripButton.Text = "Clear All Formatting";
            this.clearFormattingStripButton.Click += new System.EventHandler(this.clearFormattingStripButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.шрифт);
            this.Controls.Add(this.cont);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Текстовый редактор";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скопироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem отменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem повторитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выделитьВсёToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem снятьВыделениеToolStripMenuItem;
        private System.Windows.Forms.ColorDialog изменитьЦвет;
        private System.Windows.Forms.ToolStripDropDownButton colorStripDropDownButton;
        private System.Windows.Forms.RichTextBox cont;
        private System.Windows.Forms.ToolStripButton leftAlignStripButton;
        private System.Windows.Forms.ToolStripButton centerAlignStripButton;
        private System.Windows.Forms.ToolStripButton rightAlignStripButton;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button шрифт;
        private System.Windows.Forms.ToolStripButton boldStripButton3;
        private System.Windows.Forms.ToolStripButton italicStripButton;
        private System.Windows.Forms.ToolStripButton underlineStripButton;
        private System.Windows.Forms.ToolStripButton increaseStripButton;
        private System.Windows.Forms.ToolStripButton decreaseStripButton;
        private System.Windows.Forms.ToolStripButton clearFormattingStripButton;
    }
}

