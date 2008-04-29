namespace HostController
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.hostDataGrid = new System.Windows.Forms.DataGridView();
            this.hostCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hostIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aboutMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.hostDataGrid)).BeginInit();
            this.notifyMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // hostDataGrid
            // 
            this.hostDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hostDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hostCheck,
            this.hostIP,
            this.hostName});
            this.hostDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hostDataGrid.EnableHeadersVisualStyles = false;
            this.hostDataGrid.Location = new System.Drawing.Point(0, 0);
            this.hostDataGrid.Name = "hostDataGrid";
            this.hostDataGrid.RowHeadersVisible = false;
            this.hostDataGrid.Size = new System.Drawing.Size(547, 386);
            this.hostDataGrid.TabIndex = 0;
            this.hostDataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.hostDataGrid_CellValueChanged);
            this.hostDataGrid.CurrentCellDirtyStateChanged += new System.EventHandler(this.hostDataGrid_CurrentCellDirtyStateChanged);
            // 
            // hostCheck
            // 
            this.hostCheck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hostCheck.Frozen = true;
            this.hostCheck.HeaderText = "";
            this.hostCheck.Name = "hostCheck";
            this.hostCheck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hostCheck.Width = 21;
            // 
            // hostIP
            // 
            this.hostIP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hostIP.HeaderText = "IP";
            this.hostIP.Name = "hostIP";
            // 
            // hostName
            // 
            this.hostName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hostName.HeaderText = "Host Name";
            this.hostName.Name = "hostName";
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.notifyMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Host Controller";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // notifyMenu
            // 
            this.notifyMenu.DropShadowEnabled = false;
            this.notifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuButton,
            this.exitMenuButton});
            this.notifyMenu.Name = "exitStrip";
            this.notifyMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.notifyMenu.Size = new System.Drawing.Size(115, 48);
            this.notifyMenu.Text = "Exit";
            // 
            // aboutMenuButton
            // 
            this.aboutMenuButton.Image = global::HostController.Properties.Resources.information;
            this.aboutMenuButton.Name = "aboutMenuButton";
            this.aboutMenuButton.Size = new System.Drawing.Size(152, 22);
            this.aboutMenuButton.Text = "About";
            this.aboutMenuButton.Click += new System.EventHandler(this.aboutMenuButton_Click);
            // 
            // exitMenuButton
            // 
            this.exitMenuButton.Image = global::HostController.Properties.Resources.cross;
            this.exitMenuButton.Name = "exitMenuButton";
            this.exitMenuButton.Size = new System.Drawing.Size(152, 22);
            this.exitMenuButton.Text = "Exit";
            this.exitMenuButton.Click += new System.EventHandler(this.exitMenuButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 386);
            this.Controls.Add(this.hostDataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.Name = "Main";
            this.Text = "Host Controller";
            this.Resize += new System.EventHandler(this.Main_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.hostDataGrid)).EndInit();
            this.notifyMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView hostDataGrid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hostCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn hostIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn hostName;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip notifyMenu;
        private System.Windows.Forms.ToolStripMenuItem exitMenuButton;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuButton;
    }
}

