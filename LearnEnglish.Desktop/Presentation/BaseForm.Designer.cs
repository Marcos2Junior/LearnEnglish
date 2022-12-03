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
            this.btn_minimize = new System.Windows.Forms.Button();
            this.p_navigate.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_navigate
            // 
            this.p_navigate.Controls.Add(this.btn_theme);
            this.p_navigate.Controls.Add(this.btn_minimize);
            this.p_navigate.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_navigate.Location = new System.Drawing.Point(0, 0);
            this.p_navigate.Name = "p_navigate";
            this.p_navigate.Size = new System.Drawing.Size(800, 33);
            this.p_navigate.TabIndex = 8;
            // 
            // btn_theme
            // 
            this.btn_theme.Location = new System.Drawing.Point(664, 6);
            this.btn_theme.Name = "btn_theme";
            this.btn_theme.Size = new System.Drawing.Size(76, 19);
            this.btn_theme.TabIndex = 10;
            this.btn_theme.Text = "Theme";
            this.btn_theme.UseVisualStyleBackColor = true;
            this.btn_theme.Click += new System.EventHandler(this.btn_theme_Click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.Location = new System.Drawing.Point(761, 6);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(22, 19);
            this.btn_minimize.TabIndex = 9;
            this.btn_minimize.Text = "_";
            this.btn_minimize.UseVisualStyleBackColor = true;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
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
        private Button btn_theme;
        private Button btn_minimize;
    }
}