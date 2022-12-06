namespace LearnEnglish.Desktop.Presentation
{
    partial class FrmNewKey
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
            this.lbl_key_pressed = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_error = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_key_pressed
            // 
            this.lbl_key_pressed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_key_pressed.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_key_pressed.Location = new System.Drawing.Point(-2, 39);
            this.lbl_key_pressed.Name = "lbl_key_pressed";
            this.lbl_key_pressed.Size = new System.Drawing.Size(178, 38);
            this.lbl_key_pressed.TabIndex = 9;
            this.lbl_key_pressed.Text = "none";
            this.lbl_key_pressed.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_key_pressed.Click += new System.EventHandler(this.lbl_key_pressed_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbl_error);
            this.panel1.Controls.Add(this.lbl_key_pressed);
            this.panel1.Location = new System.Drawing.Point(88, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 114);
            this.panel1.TabIndex = 10;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_error.Location = new System.Drawing.Point(37, 88);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(100, 15);
            this.lbl_error.TabIndex = 15;
            this.lbl_error.Text = "already registered";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(69, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Press a keyboard key to identify";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 42);
            this.button1.TabIndex = 12;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_description
            // 
            this.txt_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_description.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_description.Location = new System.Drawing.Point(88, 281);
            this.txt_description.MaxLength = 10;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(178, 20);
            this.txt_description.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(88, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Friendly name";
            // 
            // FrmNewKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 401);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.Name = "FrmNewKey";
            this.Text = "FrmNewKey";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmNewKey_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmNewKey_KeyPress);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.txt_description, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_key_pressed;
        private Panel panel1;
        private Label label1;
        private Button button1;
        private TextBox txt_description;
        private Label label2;
        private Label lbl_error;
    }
}