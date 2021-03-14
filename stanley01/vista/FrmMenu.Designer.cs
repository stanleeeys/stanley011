
namespace stanley01.vista
{
    partial class FrmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.acerdaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLICKPARAMASINFROMACIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arreglosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mATETICASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conexionesBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRUDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acerdaDeToolStripMenuItem,
            this.arreglosToolStripMenuItem,
            this.mATETICASToolStripMenuItem,
            this.conexionesBDToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(350, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // acerdaDeToolStripMenuItem
            // 
            this.acerdaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLICKPARAMASINFROMACIONToolStripMenuItem});
            this.acerdaDeToolStripMenuItem.Name = "acerdaDeToolStripMenuItem";
            this.acerdaDeToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.acerdaDeToolStripMenuItem.Text = "Acerda de";
            // 
            // cLICKPARAMASINFROMACIONToolStripMenuItem
            // 
            this.cLICKPARAMASINFROMACIONToolStripMenuItem.Name = "cLICKPARAMASINFROMACIONToolStripMenuItem";
            this.cLICKPARAMASINFROMACIONToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.cLICKPARAMASINFROMACIONToolStripMenuItem.Text = "CLICK PARA MAS INFROMACION";
            this.cLICKPARAMASINFROMACIONToolStripMenuItem.Click += new System.EventHandler(this.cLICKPARAMASINFROMACIONToolStripMenuItem_Click);
            // 
            // arreglosToolStripMenuItem
            // 
            this.arreglosToolStripMenuItem.Name = "arreglosToolStripMenuItem";
            this.arreglosToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.arreglosToolStripMenuItem.Text = "Arreglos";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(350, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // mATETICASToolStripMenuItem
            // 
            this.mATETICASToolStripMenuItem.Name = "mATETICASToolStripMenuItem";
            this.mATETICASToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.mATETICASToolStripMenuItem.Text = "MATETICAS";
            // 
            // conexionesBDToolStripMenuItem
            // 
            this.conexionesBDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cRUDToolStripMenuItem});
            this.conexionesBDToolStripMenuItem.Name = "conexionesBDToolStripMenuItem";
            this.conexionesBDToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.conexionesBDToolStripMenuItem.Text = "Conexiones BD";
            // 
            // cRUDToolStripMenuItem
            // 
            this.cRUDToolStripMenuItem.Name = "cRUDToolStripMenuItem";
            this.cRUDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cRUDToolStripMenuItem.Text = "CRUD";
            this.cRUDToolStripMenuItem.Click += new System.EventHandler(this.cRUDToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 277);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem acerdaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLICKPARAMASINFROMACIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arreglosToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mATETICASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conexionesBDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRUDToolStripMenuItem;
    }
}