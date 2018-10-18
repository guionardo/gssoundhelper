namespace GSSoundHelper.Components
{
    partial class KeyEdit
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkCtrl = new System.Windows.Forms.CheckBox();
            this.chkAlt = new System.Windows.Forms.CheckBox();
            this.chkShift = new System.Windows.Forms.CheckBox();
            this.cmbLetters = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkWin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkCtrl
            // 
            this.chkCtrl.AutoSize = true;
            this.chkCtrl.Location = new System.Drawing.Point(54, 33);
            this.chkCtrl.Name = "chkCtrl";
            this.chkCtrl.Size = new System.Drawing.Size(41, 17);
            this.chkCtrl.TabIndex = 0;
            this.chkCtrl.Text = "Ctrl";
            this.chkCtrl.UseVisualStyleBackColor = true;
            // 
            // chkAlt
            // 
            this.chkAlt.AutoSize = true;
            this.chkAlt.Location = new System.Drawing.Point(101, 33);
            this.chkAlt.Name = "chkAlt";
            this.chkAlt.Size = new System.Drawing.Size(38, 17);
            this.chkAlt.TabIndex = 1;
            this.chkAlt.Text = "Alt";
            this.chkAlt.UseVisualStyleBackColor = true;
            // 
            // chkShift
            // 
            this.chkShift.AutoSize = true;
            this.chkShift.Location = new System.Drawing.Point(144, 33);
            this.chkShift.Name = "chkShift";
            this.chkShift.Size = new System.Drawing.Size(47, 17);
            this.chkShift.TabIndex = 2;
            this.chkShift.Text = "Shift";
            this.chkShift.UseVisualStyleBackColor = true;
            // 
            // cmbLetters
            // 
            this.cmbLetters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLetters.FormattingEnabled = true;
            this.cmbLetters.Location = new System.Drawing.Point(43, 6);
            this.cmbLetters.Name = "cmbLetters";
            this.cmbLetters.Size = new System.Drawing.Size(148, 21);
            this.cmbLetters.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tecla";
            // 
            // chkWin
            // 
            this.chkWin.AutoSize = true;
            this.chkWin.Location = new System.Drawing.Point(6, 33);
            this.chkWin.Name = "chkWin";
            this.chkWin.Size = new System.Drawing.Size(45, 17);
            this.chkWin.TabIndex = 5;
            this.chkWin.Text = "Win";
            this.chkWin.UseVisualStyleBackColor = true;
            // 
            // KeyEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkWin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbLetters);
            this.Controls.Add(this.chkShift);
            this.Controls.Add(this.chkAlt);
            this.Controls.Add(this.chkCtrl);
            this.Name = "KeyEdit";
            this.Size = new System.Drawing.Size(194, 58);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkCtrl;
        private System.Windows.Forms.CheckBox chkAlt;
        private System.Windows.Forms.CheckBox chkShift;
        private System.Windows.Forms.ComboBox cmbLetters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkWin;
    }
}
