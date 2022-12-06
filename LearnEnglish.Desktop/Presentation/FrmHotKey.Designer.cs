namespace LearnEnglish.Desktop.Presentation
{
    partial class FrmHotKey
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
            this.p_main = new System.Windows.Forms.Panel();
            this.btn_save_changes = new System.Windows.Forms.Button();
            this.btn_add_key = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // p_main
            // 
            this.p_main.Location = new System.Drawing.Point(26, 103);
            this.p_main.Name = "p_main";
            this.p_main.Size = new System.Drawing.Size(380, 356);
            this.p_main.TabIndex = 9;
            // 
            // btn_save_changes
            // 
            this.btn_save_changes.Location = new System.Drawing.Point(301, 465);
            this.btn_save_changes.Name = "btn_save_changes";
            this.btn_save_changes.Size = new System.Drawing.Size(105, 35);
            this.btn_save_changes.TabIndex = 10;
            this.btn_save_changes.Text = "Save changes";
            this.btn_save_changes.UseVisualStyleBackColor = true;
            this.btn_save_changes.Click += new System.EventHandler(this.btn_save_changes_Click);
            // 
            // btn_add_key
            // 
            this.btn_add_key.Location = new System.Drawing.Point(175, 64);
            this.btn_add_key.Name = "btn_add_key";
            this.btn_add_key.Size = new System.Drawing.Size(231, 33);
            this.btn_add_key.TabIndex = 11;
            this.btn_add_key.Text = "Need to add another keyboard key?";
            this.btn_add_key.UseVisualStyleBackColor = true;
            this.btn_add_key.Click += new System.EventHandler(this.btn_add_key_Click);
            // 
            // FrmHotKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 532);
            this.Controls.Add(this.btn_add_key);
            this.Controls.Add(this.btn_save_changes);
            this.Controls.Add(this.p_main);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.Name = "FrmHotKey";
            this.Text = "FrmHotKey";
            this.Load += new System.EventHandler(this.FrmHotKey_Load);
            this.Controls.SetChildIndex(this.p_main, 0);
            this.Controls.SetChildIndex(this.btn_save_changes, 0);
            this.Controls.SetChildIndex(this.btn_add_key, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel p_main;
        private Button btn_save;
        private Button btn_save_changes;
        private Button btn_add_key;
    }
}