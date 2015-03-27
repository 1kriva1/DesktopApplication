namespace MouseBot
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_reset = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_repeat = new System.Windows.Forms.Button();
            this.text_x = new System.Windows.Forms.TextBox();
            this.text_y = new System.Windows.Forms.TextBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fail = new System.Windows.Forms.ToolStripMenuItem();
            this.open_x = new System.Windows.Forms.ToolStripMenuItem();
            this.open_y = new System.Windows.Forms.ToolStripMenuItem();
            this.save_y = new System.Windows.Forms.ToolStripMenuItem();
            this.save_x = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.закритиПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.info_programm = new System.Windows.Forms.ToolStripMenuItem();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.saveFD = new System.Windows.Forms.SaveFileDialog();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_reset
            // 
            this.button_reset.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_reset.Location = new System.Drawing.Point(317, 42);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(112, 44);
            this.button_reset.TabIndex = 0;
            this.button_reset.Text = "Сброс";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.Location = new System.Drawing.Point(317, 108);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(112, 86);
            this.button_add.TabIndex = 1;
            this.button_add.Text = " Додати координати мишки";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_repeat
            // 
            this.button_repeat.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_repeat.Location = new System.Drawing.Point(317, 228);
            this.button_repeat.Name = "button_repeat";
            this.button_repeat.Size = new System.Drawing.Size(112, 78);
            this.button_repeat.TabIndex = 2;
            this.button_repeat.Text = "Повторити";
            this.button_repeat.UseVisualStyleBackColor = true;
            this.button_repeat.Click += new System.EventHandler(this.button_repeat_Click);
            // 
            // text_x
            // 
            this.text_x.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.text_x.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_x.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.text_x.Location = new System.Drawing.Point(12, 41);
            this.text_x.Multiline = true;
            this.text_x.Name = "text_x";
            this.text_x.ReadOnly = true;
            this.text_x.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_x.Size = new System.Drawing.Size(140, 264);
            this.text_x.TabIndex = 3;
            // 
            // text_y
            // 
            this.text_y.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.text_y.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_y.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.text_y.Location = new System.Drawing.Point(158, 41);
            this.text_y.Multiline = true;
            this.text_y.Name = "text_y";
            this.text_y.ReadOnly = true;
            this.text_y.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_y.Size = new System.Drawing.Size(135, 264);
            this.text_y.TabIndex = 4;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fail,
            this.info_programm});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(453, 24);
            this.menu.TabIndex = 5;
            this.menu.Text = "menuStrip1";
            // 
            // fail
            // 
            this.fail.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open_x,
            this.open_y,
            this.save_x,
            this.save_y,
            this.toolStripMenuItem1,
            this.закритиПрограмуToolStripMenuItem});
            this.fail.Name = "fail";
            this.fail.Size = new System.Drawing.Size(48, 20);
            this.fail.Text = "Файл";
            // 
            // open_x
            // 
            this.open_x.Name = "open_x";
            this.open_x.Size = new System.Drawing.Size(176, 22);
            this.open_x.Text = "Відкрити \"x\"";
            this.open_x.Click += new System.EventHandler(this.open_x_Click);
            // 
            // open_y
            // 
            this.open_y.Name = "open_y";
            this.open_y.Size = new System.Drawing.Size(176, 22);
            this.open_y.Text = "Відкрити \"y\"";
            this.open_y.Click += new System.EventHandler(this.open_y_Click);
            // 
            // save_y
            // 
            this.save_y.Name = "save_y";
            this.save_y.Size = new System.Drawing.Size(176, 22);
            this.save_y.Text = "Зберегти \"y\"";
            this.save_y.Click += new System.EventHandler(this.save_y_Click);
            // 
            // save_x
            // 
            this.save_x.Name = "save_x";
            this.save_x.Size = new System.Drawing.Size(176, 22);
            this.save_x.Text = "Зберегти \"x\"";
            this.save_x.Click += new System.EventHandler(this.save_x_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(173, 6);
            // 
            // закритиПрограмуToolStripMenuItem
            // 
            this.закритиПрограмуToolStripMenuItem.Name = "закритиПрограмуToolStripMenuItem";
            this.закритиПрограмуToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.закритиПрограмуToolStripMenuItem.Text = "Закрити програму";
            // 
            // info_programm
            // 
            this.info_programm.Name = "info_programm";
            this.info_programm.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.info_programm.Size = new System.Drawing.Size(45, 20);
            this.info_programm.Text = "Інфо";
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 315);
            this.Controls.Add(this.text_y);
            this.Controls.Add(this.text_x);
            this.Controls.Add(this.button_repeat);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Бот клікер";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_repeat;
        private System.Windows.Forms.TextBox text_x;
        private System.Windows.Forms.TextBox text_y;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fail;
        private System.Windows.Forms.ToolStripMenuItem open_x;
        private System.Windows.Forms.ToolStripMenuItem open_y;
        private System.Windows.Forms.ToolStripMenuItem save_y;
        private System.Windows.Forms.ToolStripMenuItem info_programm;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.SaveFileDialog saveFD;
        private System.Windows.Forms.ToolStripMenuItem save_x;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem закритиПрограмуToolStripMenuItem;
    }
}

