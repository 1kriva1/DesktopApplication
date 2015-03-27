namespace TextProcessor
{
    partial class FormTextProcessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTextProcessor));
            this.button_open = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.textBox_editor = new System.Windows.Forms.TextBox();
            this.textBox_pattern = new System.Windows.Forms.TextBox();
            this.textBox_change = new System.Windows.Forms.TextBox();
            this.button_replace = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.saveFD = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(12, 12);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(95, 53);
            this.button_open.TabIndex = 0;
            this.button_open.Text = "Open text";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(12, 81);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(95, 53);
            this.button_save.TabIndex = 1;
            this.button_save.Text = "Save text";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // textBox_editor
            // 
            this.textBox_editor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_editor.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_editor.Location = new System.Drawing.Point(133, 12);
            this.textBox_editor.Multiline = true;
            this.textBox_editor.Name = "textBox_editor";
            this.textBox_editor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_editor.Size = new System.Drawing.Size(498, 388);
            this.textBox_editor.TabIndex = 2;
            this.textBox_editor.WordWrap = false;
            // 
            // textBox_pattern
            // 
            this.textBox_pattern.Location = new System.Drawing.Point(12, 197);
            this.textBox_pattern.Name = "textBox_pattern";
            this.textBox_pattern.Size = new System.Drawing.Size(100, 20);
            this.textBox_pattern.TabIndex = 3;
            // 
            // textBox_change
            // 
            this.textBox_change.Location = new System.Drawing.Point(12, 268);
            this.textBox_change.Name = "textBox_change";
            this.textBox_change.Size = new System.Drawing.Size(100, 20);
            this.textBox_change.TabIndex = 4;
            // 
            // button_replace
            // 
            this.button_replace.Location = new System.Drawing.Point(17, 316);
            this.button_replace.Name = "button_replace";
            this.button_replace.Size = new System.Drawing.Size(95, 53);
            this.button_replace.TabIndex = 5;
            this.button_replace.Text = "Change";
            this.button_replace.UseVisualStyleBackColor = true;
            this.button_replace.Click += new System.EventHandler(this.button_replace_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Changed word";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "New word";
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            // 
            // FormTextProcessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 412);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_replace);
            this.Controls.Add(this.textBox_change);
            this.Controls.Add(this.textBox_pattern);
            this.Controls.Add(this.textBox_editor);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_open);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 450);
            this.Name = "FormTextProcessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Processor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TextBox textBox_editor;
        private System.Windows.Forms.TextBox textBox_pattern;
        private System.Windows.Forms.TextBox textBox_change;
        private System.Windows.Forms.Button button_replace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.SaveFileDialog saveFD;
    }
}

