namespace LearnEnglish.Desktop.Presentation
{
    partial class BaseForm
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
            this.p_navigate = new System.Windows.Forms.Panel();
            this.btn_theme = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_info = new System.Windows.Forms.Button();
            this.p_navigate.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_navigate
            // 
            this.p_navigate.Controls.Add(this.btn_theme);
            this.p_navigate.Controls.Add(this.btn_close);
            this.p_navigate.Controls.Add(this.btn_info);
            this.p_navigate.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_navigate.Location = new System.Drawing.Point(0, 0);
            this.p_navigate.Name = "p_navigate";
            this.p_navigate.Size = new System.Drawing.Size(800, 40);
            this.p_navigate.TabIndex = 8;
            // 
            // btn_theme
            // 
            this.btn_theme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_theme.AutoEllipsis = true;
            this.btn_theme.FlatAppearance.BorderSize = 0;
            this.btn_theme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_theme.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_theme.Image = global::LearnEnglish.Desktop.Properties.Resources.moon_icon;
            this.btn_theme.Location = new System.Drawing.Point(718, 4);
            this.btn_theme.Name = "btn_theme";
            this.btn_theme.Size = new System.Drawing.Size(35, 30);
            this.btn_theme.TabIndex = 11;
            this.btn_theme.UseVisualStyleBackColor = true;
            this.btn_theme.Click += new System.EventHandler(this.btn_theme_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.AutoEllipsis = true;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_close.Image = global::LearnEnglish.Desktop.Properties.Resources.close_icon;
            this.btn_close.Location = new System.Drawing.Point(757, 4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(35, 30);
            this.btn_close.TabIndex = 10;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_info
            // 
            this.btn_info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_info.AutoEllipsis = true;
            this.btn_info.FlatAppearance.BorderSize = 0;
            this.btn_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_info.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_info.Image = global::LearnEnglish.Desktop.Properties.Resources.info_icon;
            this.btn_info.Location = new System.Drawing.Point(679, 4);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(35, 30);
            this.btn_info.TabIndex = 9;
            this.btn_info.UseVisualStyleBackColor = true;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.p_navigate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaseForm";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.p_navigate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel p_navigate;
        private Button btn_info;
        private Button btn_theme;
        private Button btn_close;
    }
}