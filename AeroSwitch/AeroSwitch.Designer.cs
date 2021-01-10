namespace AeroSwitch
{
	partial class AeroSwitch
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AeroSwitch));
			this.toggleAero = new System.Windows.Forms.Button();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.notifyIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toggleAeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.notifyIconMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// toggleAero
			// 
			this.toggleAero.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toggleAero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toggleAero.Location = new System.Drawing.Point(0, 0);
			this.toggleAero.Name = "toggleAero";
			this.toggleAero.Size = new System.Drawing.Size(240, 218);
			this.toggleAero.TabIndex = 1;
			this.toggleAero.Text = "Toggle Aero";
			this.toggleAero.UseVisualStyleBackColor = true;
			this.toggleAero.Click += new System.EventHandler(this.toggleAero_Click);
			// 
			// notifyIcon
			// 
			this.notifyIcon.ContextMenuStrip = this.notifyIconMenu;
			this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("AeroSwitch16x16")));
			this.notifyIcon.Text = "AeroSwitch";
			this.notifyIcon.Visible = true;
			this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
			// 
			// notifyIconMenu
			// 
			this.notifyIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toggleAeroToolStripMenuItem,
            this.showWindowToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.notifyIconMenu.Name = "notifyIconMenu";
			this.notifyIconMenu.Size = new System.Drawing.Size(151, 70);
			// 
			// toggleAeroToolStripMenuItem
			// 
			this.toggleAeroToolStripMenuItem.Name = "toggleAeroToolStripMenuItem";
			this.toggleAeroToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.toggleAeroToolStripMenuItem.Text = "Toggle Aero";
			this.toggleAeroToolStripMenuItem.Click += new System.EventHandler(this.toggleAeroToolStripMenuItem_Click);
			// 
			// showWindowToolStripMenuItem
			// 
			this.showWindowToolStripMenuItem.Name = "showWindowToolStripMenuItem";
			this.showWindowToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.showWindowToolStripMenuItem.Text = "Show Window";
			this.showWindowToolStripMenuItem.Click += new System.EventHandler(this.showWindowToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// AeroSwitch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(240, 218);
			this.Controls.Add(this.toggleAero);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("AeroSwitch")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(256, 256);
			this.MinimumSize = new System.Drawing.Size(256, 256);
			this.Name = "AeroSwitch";
			this.Text = "AeroSwitch";
			this.Load += new System.EventHandler(this.AeroSwitch_Load);
			this.notifyIconMenu.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button toggleAero;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.ContextMenuStrip notifyIconMenu;
		private System.Windows.Forms.ToolStripMenuItem toggleAeroToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem showWindowToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
	}
}

