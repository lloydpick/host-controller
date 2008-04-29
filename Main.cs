using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace HostController
{
    public partial class Main : Form
    {
        string hostsLocation = "C:\\WINDOWS\\system32\\drivers\\etc\\hosts";
        bool builtList = false;

        public Main()
        {
            InitializeComponent();
            notifyIcon.Text = Application.ProductName.ToString() + " v" + Application.ProductVersion.ToString();
            this.Text = Application.ProductName.ToString() + " v" + Application.ProductVersion.ToString();
            readHostFile();
         }

        private void readHostFile()
        {
            int counter = 0;
            string line;

            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader(hostsLocation);
            while ((line = file.ReadLine()) != null)
            {
                string[] result = line.Split(new Char[] { '	' });
                if (result.Length == 2)
                {
                    if ((result[0].Length > 0) && (result[1].Length > 0))
                    {
                        if (result[0][0] == '#')
                        {
                            hostDataGrid.Rows.Add(false, result[0].Substring(1), result[1]);
                        }
                        else
                        {
                            hostDataGrid.Rows.Add(true, result[0], result[1]);
                        }
                    }
                }
                counter++;
            }

            file.Close();

            builtList = true;
        }

        private void writeHostFile()
        {
            // create a writer and open the file
            TextWriter tw = new StreamWriter(hostsLocation);
            string output = "";

            foreach (DataGridViewRow row in this.hostDataGrid.Rows)
            {
                output = "";
                if (row.Cells["hostCheck"].Value != null)
                {
                    if (row.Cells["hostCheck"].Value.ToString() == "False")
                    {
                        output = "#";
                    }
                }

                output = output + row.Cells["hostIP"].Value + "	" + row.Cells["hostName"].Value;

                if (output.Length > 10)
                {
                    tw.WriteLine(output);
                }
            }

            // close the stream
            tw.Close();
        }

        private void hostDataGrid_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (builtList)
            {
                if (hostDataGrid.IsCurrentCellDirty)
                {
                    hostDataGrid.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            }
        }

        private void hostDataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (builtList)
            {
                writeHostFile();
            }
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                Hide();
            }
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void aboutMenuButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Application.ProductName.ToString() + " v" + Application.ProductVersion.ToString() + "\n© " + Application.CompanyName.ToString() + " 2008\n\nAuthor: Lloyd Pick\nE-mail: lloyd.pick@tnwa.net", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitMenuButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}