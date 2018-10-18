namespace GSSoundHelper
{
    partial class Form1
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
            this.btnGravar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.keMute = new GSSoundHelper.Components.KeyEdit();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.chkRunWithWindows = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(292, 273);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 0;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(411, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // keMute
            // 
            this.keMute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keMute.Key = System.Windows.Forms.Keys.None;
            this.keMute.Location = new System.Drawing.Point(12, 12);
            this.keMute.Name = "keMute";
            this.keMute.Size = new System.Drawing.Size(194, 58);
            this.keMute.TabIndex = 2;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // chkRunWithWindows
            // 
            this.chkRunWithWindows.AutoSize = true;
            this.chkRunWithWindows.Location = new System.Drawing.Point(12, 85);
            this.chkRunWithWindows.Name = "chkRunWithWindows";
            this.chkRunWithWindows.Size = new System.Drawing.Size(133, 17);
            this.chkRunWithWindows.TabIndex = 3;
            this.chkRunWithWindows.Text = "Iniciar com o Windows";
            this.chkRunWithWindows.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkRunWithWindows);
            this.Controls.Add(this.keMute);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGravar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button button2;
        private Components.KeyEdit keMute;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.CheckBox chkRunWithWindows;
    }
}

