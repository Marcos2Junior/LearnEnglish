namespace LearnEnglish.Desktop.Presentation
{
    partial class FrmCreateText
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
            this.btn_create = new System.Windows.Forms.Button();
            this.txt_value = new System.Windows.Forms.TextBox();
            this.txt_translate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(218, 175);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(125, 31);
            this.btn_create.TabIndex = 0;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // txt_value
            // 
            this.txt_value.Location = new System.Drawing.Point(12, 48);
            this.txt_value.Name = "txt_value";
            this.txt_value.PlaceholderText = "Text in English";
            this.txt_value.Size = new System.Drawing.Size(331, 23);
            this.txt_value.TabIndex = 1;
            // 
            // txt_translate
            // 
            this.txt_translate.Location = new System.Drawing.Point(12, 99);
            this.txt_translate.Name = "txt_translate";
            this.txt_translate.PlaceholderText = "Text in Portuguese";
            this.txt_translate.Size = new System.Drawing.Size(331, 23);
            this.txt_translate.TabIndex = 2;
            // 
            // FrmCreateText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 223);
            this.Controls.Add(this.txt_translate);
            this.Controls.Add(this.txt_value);
            this.Controls.Add(this.btn_create);
            this.Name = "FrmCreateText";
            this.Text = "FrmCreateText";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_create;
        private TextBox txt_value;
        private TextBox txt_translate;
    }
}