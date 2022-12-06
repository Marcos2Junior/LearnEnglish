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
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_info = new System.Windows.Forms.Button();
            this.btn_theme = new System.Windows.Forms.Button();
            this.p_navigate.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_navigate
            // 
            this.p_navigate.Controls.Add(this.lbl_title);
            this.p_navigate.Controls.Add(this.btn_close);
            this.p_navigate.Controls.Add(this.btn_info);
            this.p_navigate.Controls.Add(this.btn_theme);
            this.p_navigate.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_navigate.Location = new System.Drawing.Point(0, 0);
            this.p_navigate.Name = "p_navigate";
            this.p_navigate.Size = new System.Drawing.Size(985, 40);
            this.p_navigate.TabIndex = 8;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.Location = new System.Drawing.Point(12, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(103, 21);
            this.lbl_title.TabIndex = 9;
            this.lbl_title.Text = "Learn English";
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.AutoEllipsis = true;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_close.Image = global::LearnEnglish.Desktop.Properties.Resources.close_icon;
            this.btn_close.Location = new System.Drawing.Point(942, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(33, 30);
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
            this.btn_info.Location = new System.Drawing.Point(905, 3);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(33, 30);
            this.btn_info.TabIndex = 9;
            this.btn_info.UseVisualStyleBackColor = true;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // btn_theme
            // 
            this.btn_theme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_theme.AutoEllipsis = true;
            this.btn_theme.FlatAppearance.BorderSize = 0;
            this.btn_theme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_theme.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_theme.Image = global::LearnEnglish.Desktop.Properties.Resources.moon_icon;
            this.btn_theme.Location = new System.Drawing.Point(868, 3);
            this.btn_theme.Name = "btn_theme";
            this.btn_theme.Size = new System.Drawing.Size(33, 30);
            this.btn_theme.TabIndex = 11;
            this.btn_theme.UseVisualStyleBackColor = true;
            this.btn_theme.Click += new System.EventHandler(this.btn_theme_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 623);
            this.Controls.Add(this.p_navigate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaseForm";
            this.Activated += new System.EventHandler(this.BaseForm_Activated);
            this.Deactivate += new System.EventHandler(this.BaseForm_Deactivate);
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BaseForm_KeyDown);
            this.p_navigate.ResumeLayout(false);
            this.p_navigate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel p_navigate;
        private Button btn_info;
        private Button btn_theme;
        private Button btn_close;
        private Label lbl_title;
    }
}