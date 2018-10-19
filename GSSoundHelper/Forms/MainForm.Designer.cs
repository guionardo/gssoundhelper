namespace GSSoundHelper
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.niMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miConfigurar = new System.Windows.Forms.ToolStripMenuItem();
            this.miSair = new System.Windows.Forms.ToolStripMenuItem();
            this.chkRunWithWindows = new System.Windows.Forms.CheckBox();
            this.gbShortKey = new System.Windows.Forms.GroupBox();
            this.chkWin = new System.Windows.Forms.CheckBox();
            this.chkShift = new System.Windows.Forms.CheckBox();
            this.chkAlt = new System.Windows.Forms.CheckBox();
            this.chkCtrl = new System.Windows.Forms.CheckBox();
            this.cmbLetters = new System.Windows.Forms.ComboBox();
            this.miSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.niMenu.SuspendLayout();
            this.gbShortKey.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGravar
            // 
            resources.ApplyResources(this.btnGravar, "btnGravar");
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // btnMinimizar
            // 
            resources.ApplyResources(this.btnMinimizar, "btnMinimizar");
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.niMenu;
            resources.ApplyResources(this.notifyIcon, "notifyIcon");
            // 
            // niMenu
            // 
            this.niMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miConfigurar,
            this.miSobre,
            this.toolStripSeparator1,
            this.miSair});
            this.niMenu.Name = "niMenu";
            resources.ApplyResources(this.niMenu, "niMenu");
            // 
            // miConfigurar
            // 
            this.miConfigurar.Name = "miConfigurar";
            resources.ApplyResources(this.miConfigurar, "miConfigurar");
            this.miConfigurar.Click += new System.EventHandler(this.NotifyMenuClick);
            // 
            // miSair
            // 
            this.miSair.Name = "miSair";
            resources.ApplyResources(this.miSair, "miSair");
            this.miSair.Click += new System.EventHandler(this.NotifyMenuClick);
            // 
            // chkRunWithWindows
            // 
            resources.ApplyResources(this.chkRunWithWindows, "chkRunWithWindows");
            this.chkRunWithWindows.Name = "chkRunWithWindows";
            this.chkRunWithWindows.UseVisualStyleBackColor = true;
            // 
            // gbShortKey
            // 
            this.gbShortKey.Controls.Add(this.chkWin);
            this.gbShortKey.Controls.Add(this.chkShift);
            this.gbShortKey.Controls.Add(this.chkAlt);
            this.gbShortKey.Controls.Add(this.chkCtrl);
            this.gbShortKey.Controls.Add(this.cmbLetters);
            resources.ApplyResources(this.gbShortKey, "gbShortKey");
            this.gbShortKey.Name = "gbShortKey";
            this.gbShortKey.TabStop = false;
            // 
            // chkWin
            // 
            resources.ApplyResources(this.chkWin, "chkWin");
            this.chkWin.Name = "chkWin";
            this.chkWin.UseVisualStyleBackColor = true;
            // 
            // chkShift
            // 
            resources.ApplyResources(this.chkShift, "chkShift");
            this.chkShift.Name = "chkShift";
            this.chkShift.UseVisualStyleBackColor = true;
            // 
            // chkAlt
            // 
            resources.ApplyResources(this.chkAlt, "chkAlt");
            this.chkAlt.Name = "chkAlt";
            this.chkAlt.UseVisualStyleBackColor = true;
            // 
            // chkCtrl
            // 
            resources.ApplyResources(this.chkCtrl, "chkCtrl");
            this.chkCtrl.Name = "chkCtrl";
            this.chkCtrl.UseVisualStyleBackColor = true;
            // 
            // cmbLetters
            // 
            this.cmbLetters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLetters.FormattingEnabled = true;
            resources.ApplyResources(this.cmbLetters, "cmbLetters");
            this.cmbLetters.Name = "cmbLetters";
            // 
            // miSobre
            // 
            this.miSobre.Name = "miSobre";
            resources.ApplyResources(this.miSobre, "miSobre");
            this.miSobre.Click += new System.EventHandler(this.NotifyMenuClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.gbShortKey);
            this.Controls.Add(this.chkRunWithWindows);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnGravar);
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.niMenu.ResumeLayout(false);
            this.gbShortKey.ResumeLayout(false);
            this.gbShortKey.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.CheckBox chkRunWithWindows;
        private System.Windows.Forms.ContextMenuStrip niMenu;
        private System.Windows.Forms.ToolStripMenuItem miConfigurar;
        private System.Windows.Forms.ToolStripMenuItem miSair;
        private System.Windows.Forms.GroupBox gbShortKey;
        private System.Windows.Forms.ComboBox cmbLetters;
        private System.Windows.Forms.CheckBox chkWin;
        private System.Windows.Forms.CheckBox chkShift;
        private System.Windows.Forms.CheckBox chkAlt;
        private System.Windows.Forms.CheckBox chkCtrl;
        private System.Windows.Forms.ToolStripMenuItem miSobre;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

