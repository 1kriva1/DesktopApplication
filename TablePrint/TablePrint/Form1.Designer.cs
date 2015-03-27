namespace TablePrint
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
            this.grid = new System.Windows.Forms.DataGridView();
            this.co_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.co_Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.co_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_print = new System.Windows.Forms.Button();
            this.button_excel = new System.Windows.Forms.Button();
            this.web = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.co_name,
            this.co_Surname,
            this.co_tel});
            this.grid.Location = new System.Drawing.Point(12, 65);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(437, 248);
            this.grid.TabIndex = 0;
            // 
            // co_name
            // 
            this.co_name.HeaderText = "Name";
            this.co_name.Name = "co_name";
            // 
            // co_Surname
            // 
            this.co_Surname.HeaderText = "Surname";
            this.co_Surname.Name = "co_Surname";
            // 
            // co_tel
            // 
            this.co_tel.HeaderText = "Telephon number";
            this.co_tel.Name = "co_tel";
            // 
            // button_print
            // 
            this.button_print.Location = new System.Drawing.Point(12, 12);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(125, 37);
            this.button_print.TabIndex = 1;
            this.button_print.Text = "Print table";
            this.button_print.UseVisualStyleBackColor = true;
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // button_excel
            // 
            this.button_excel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_excel.Location = new System.Drawing.Point(324, 12);
            this.button_excel.Name = "button_excel";
            this.button_excel.Size = new System.Drawing.Size(125, 37);
            this.button_excel.TabIndex = 2;
            this.button_excel.Text = "Export excel";
            this.button_excel.UseVisualStyleBackColor = true;
            this.button_excel.Click += new System.EventHandler(this.button_excel_Click);
            // 
            // web
            // 
            this.web.Location = new System.Drawing.Point(41, 123);
            this.web.MinimumSize = new System.Drawing.Size(20, 20);
            this.web.Name = "web";
            this.web.Size = new System.Drawing.Size(368, 180);
            this.web.TabIndex = 3;
            this.web.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 335);
            this.Controls.Add(this.web);
            this.Controls.Add(this.button_excel);
            this.Controls.Add(this.button_print);
            this.Controls.Add(this.grid);
            this.MinimumSize = new System.Drawing.Size(389, 275);
            this.Name = "Form1";
            this.Text = "Demo print table";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn co_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn co_Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn co_tel;
        private System.Windows.Forms.Button button_print;
        private System.Windows.Forms.Button button_excel;
        private System.Windows.Forms.WebBrowser web;
    }
}

