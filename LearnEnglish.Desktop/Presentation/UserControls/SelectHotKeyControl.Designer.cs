namespace LearnEnglish.Desktop.Presentation.UserControls
{
    partial class SelectHotKeyControl
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
            this.lbl_key = new System.Windows.Forms.Label();
            this.cb_1 = new System.Windows.Forms.ComboBox();
            this.cb_2 = new System.Windows.Forms.ComboBox();
            this.cb_3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_key
            // 
            this.lbl_key.AutoSize = true;
            this.lbl_key.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_key.Location = new System.Drawing.Point(10, 8);
            this.lbl_key.Name = "lbl_key";
            this.lbl_key.Size = new System.Drawing.Size(116, 17);
            this.lbl_key.TabIndex = 16;
            this.lbl_key.Text = "Description hotkey";
            // 
            // cb_1
            // 
            this.cb_1.FormattingEnabled = true;
            this.cb_1.Location = new System.Drawing.Point(6, 34);
            this.cb_1.Name = "cb_1";
            this.cb_1.Size = new System.Drawing.Size(85, 23);
            this.cb_1.TabIndex = 17;
            this.cb_1.SelectedIndexChanged += new System.EventHandler(this.cb_1_SelectedIndexChanged);
            // 
            // cb_2
            // 
            this.cb_2.FormattingEnabled = true;
            this.cb_2.Location = new System.Drawing.Point(97, 34);
            this.cb_2.Name = "cb_2";
            this.cb_2.Size = new System.Drawing.Size(85, 23);
            this.cb_2.TabIndex = 18;
            this.cb_2.SelectedIndexChanged += new System.EventHandler(this.cb_2_SelectedIndexChanged);
            // 
            // cb_3
            // 
            this.cb_3.FormattingEnabled = true;
            this.cb_3.Location = new System.Drawing.Point(188, 34);
            this.cb_3.Name = "cb_3";
            this.cb_3.Size = new System.Drawing.Size(85, 23);
            this.cb_3.TabIndex = 19;
            this.cb_3.SelectedIndexChanged += new System.EventHandler(this.cb_3_SelectedIndexChanged);
            // 
            // SelectHotKeyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cb_3);
            this.Controls.Add(this.cb_2);
            this.Controls.Add(this.cb_1);
            this.Controls.Add(this.lbl_key);
            this.Name = "SelectHotKeyControl";
            this.Size = new System.Drawing.Size(279, 68);
            this.Load += new System.EventHandler(this.SelectHotKeyControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbl_key;
        private ComboBox cb_1;
        private ComboBox cb_2;
        private ComboBox cb_3;
    }
}
