using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace TablePrint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            print_table(web, grid);
        }

        private void print_table(WebBrowser web, DataGridView grid)
        {
            web.ScriptErrorsSuppressed = true;
            StringBuilder html = new StringBuilder();
            html.AppendLine("<table border='1' width='300' cellpadding='0' cellspacing='0'>"); // open table
            html.AppendLine("<tr>"); //open string line
            foreach (DataGridViewColumn cols in grid.Columns)
            {
                html.AppendLine("<th>" + cols.HeaderText + "</th>");
            }

            html.AppendLine("</tr>"); //close string line

            foreach (DataGridViewRow rows in grid.Rows)
            {
                html.AppendLine("<tr>");
                foreach (DataGridViewColumn cols in grid.Columns)
                {
                    html.AppendLine("<td>" + (grid[cols.Index,rows.Index].Value??"") + "</td>");
                }
                html.AppendLine("</tr>");
            }

            html.Append("</table>");// close table
            html.AppendLine("<script> window.print(); </script>");
            web.DocumentText = html.ToString();
        }

        private void excel_table(DataGridView grid)
        {
            
            StringBuilder csv = new StringBuilder();            
            foreach (DataGridViewColumn cols in grid.Columns)
            {
                csv.Append(cols.HeaderText+";");
            }

            csv.AppendLine();

            foreach (DataGridViewRow rows in grid.Rows)
            {
                
                foreach (DataGridViewColumn cols in grid.Columns)
                {
                    csv.Append((grid[cols.Index, rows.Index].Value ?? "") + ";");
                }
                csv.AppendLine();
            }
            File.WriteAllText("table.csv", csv.ToString(), Encoding.UTF8);
            Process.Start("table.csv");
        }

        private void button_excel_Click(object sender, EventArgs e)
        {
            excel_table(grid);
        }
    }
}
