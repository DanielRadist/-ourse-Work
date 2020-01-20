namespace Attendance_tracking_system_csharp
{
    partial class FormAdminMain
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
            this.menuStripFormAdminMain = new System.Windows.Forms.MenuStrip();
            this.выбратьГруппуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripFormAdminMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripFormAdminMain
            // 
            this.menuStripFormAdminMain.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStripFormAdminMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбратьГруппуToolStripMenuItem});
            this.menuStripFormAdminMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripFormAdminMain.Name = "menuStripFormAdminMain";
            this.menuStripFormAdminMain.Size = new System.Drawing.Size(1264, 27);
            this.menuStripFormAdminMain.TabIndex = 0;
            this.menuStripFormAdminMain.Text = "menuStrip";
            // 
            // выбратьГруппуToolStripMenuItem
            // 
            this.выбратьГруппуToolStripMenuItem.Name = "выбратьГруппуToolStripMenuItem";
            this.выбратьГруппуToolStripMenuItem.Size = new System.Drawing.Size(122, 23);
            this.выбратьГруппуToolStripMenuItem.Text = "Выбрать группу";
            // 
            // FormAdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.menuStripFormAdminMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MainMenuStrip = this.menuStripFormAdminMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAdminMain";
            this.Text = "FormAdminMain";
            this.menuStripFormAdminMain.ResumeLayout(false);
            this.menuStripFormAdminMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripFormAdminMain;
        private System.Windows.Forms.ToolStripMenuItem выбратьГруппуToolStripMenuItem;

    }
}