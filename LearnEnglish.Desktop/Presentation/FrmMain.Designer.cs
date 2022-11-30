namespace LearnEnglish.Desktop.Presentation
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_change_translate = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.txt_filter = new System.Windows.Forms.ComboBox();
            this.lbl_description = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_change_translate
            // 
            this.btn_change_translate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_change_translate.Location = new System.Drawing.Point(412, 80);
            this.btn_change_translate.Name = "btn_change_translate";
            this.btn_change_translate.Size = new System.Drawing.Size(168, 23);
            this.btn_change_translate.TabIndex = 1;
            this.btn_change_translate.Text = "Change translate";
            this.btn_change_translate.UseVisualStyleBackColor = true;
            this.btn_change_translate.Click += new System.EventHandler(this.btn_change_translate_Click);
            // 
            // btn_create
            // 
            this.btn_create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_create.Location = new System.Drawing.Point(586, 80);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(168, 23);
            this.btn_create.TabIndex = 2;
            this.btn_create.Text = "New translate";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // txt_filter
            // 
            this.txt_filter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_filter.FormattingEnabled = true;
            this.txt_filter.Location = new System.Drawing.Point(24, 29);
            this.txt_filter.Name = "txt_filter";
            this.txt_filter.Size = new System.Drawing.Size(730, 29);
            this.txt_filter.TabIndex = 3;
            this.txt_filter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_filter_KeyDown);
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(24, 9);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(67, 15);
            this.lbl_description.TabIndex = 4;
            this.lbl_description.Text = "Description";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 115);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.txt_filter);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.btn_change_translate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_change_translate;
        private Button btn_create;
        private ComboBox txt_filter;
        private Label lbl_description;
    }
}