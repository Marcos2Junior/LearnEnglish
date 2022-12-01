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
            this.SuspendLayout();
            // 
            // p_navigate
            // 
            this.p_navigate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.p_navigate.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_navigate.Location = new System.Drawing.Point(0, 0);
            this.p_navigate.Name = "p_navigate";
            this.p_navigate.Size = new System.Drawing.Size(800, 22);
            this.p_navigate.TabIndex = 8;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(57)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.p_navigate);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaseForm";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel p_navigate;
    }
}