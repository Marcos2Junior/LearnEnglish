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
            this.lbl_description = new System.Windows.Forms.Label();
            this.txt_filter = new System.Windows.Forms.TextBox();
            this.dg_result = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_result)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_change_translate
            // 
            this.btn_change_translate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_change_translate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(100)))), ((int)(((byte)(102)))));
            this.btn_change_translate.FlatAppearance.BorderSize = 0;
            this.btn_change_translate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_change_translate.ForeColor = System.Drawing.Color.White;
            this.btn_change_translate.Location = new System.Drawing.Point(410, 40);
            this.btn_change_translate.Name = "btn_change_translate";
            this.btn_change_translate.Size = new System.Drawing.Size(168, 23);
            this.btn_change_translate.TabIndex = 1;
            this.btn_change_translate.Text = "Change translate";
            this.btn_change_translate.UseVisualStyleBackColor = false;
            this.btn_change_translate.Click += new System.EventHandler(this.btn_change_translate_Click);
            // 
            // btn_create
            // 
            this.btn_create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(100)))), ((int)(((byte)(102)))));
            this.btn_create.FlatAppearance.BorderSize = 0;
            this.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_create.ForeColor = System.Drawing.Color.White;
            this.btn_create.Location = new System.Drawing.Point(584, 40);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(168, 23);
            this.btn_create.TabIndex = 2;
            this.btn_create.Text = "New translate";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.ForeColor = System.Drawing.Color.White;
            this.lbl_description.Location = new System.Drawing.Point(22, 48);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(67, 15);
            this.lbl_description.TabIndex = 4;
            this.lbl_description.Text = "Description";
            // 
            // txt_filter
            // 
            this.txt_filter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(100)))), ((int)(((byte)(102)))));
            this.txt_filter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_filter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_filter.Location = new System.Drawing.Point(22, 70);
            this.txt_filter.Name = "txt_filter";
            this.txt_filter.Size = new System.Drawing.Size(730, 22);
            this.txt_filter.TabIndex = 5;
            this.txt_filter.TextChanged += new System.EventHandler(this.txt_filter_TextChanged);
            // 
            // dg_result
            // 
            this.dg_result.AllowUserToAddRows = false;
            this.dg_result.AllowUserToDeleteRows = false;
            this.dg_result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_result.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_result.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dg_result.GridColor = System.Drawing.SystemColors.Control;
            this.dg_result.Location = new System.Drawing.Point(22, 104);
            this.dg_result.Name = "dg_result";
            this.dg_result.ReadOnly = true;
            this.dg_result.RowHeadersVisible = false;
            this.dg_result.RowTemplate.Height = 25;
            this.dg_result.Size = new System.Drawing.Size(730, 134);
            this.dg_result.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Value";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Translate";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Last Update";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(57)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(779, 261);
            this.Controls.Add(this.dg_result);
            this.Controls.Add(this.txt_filter);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.btn_change_translate);
            this.Name = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Controls.SetChildIndex(this.btn_change_translate, 0);
            this.Controls.SetChildIndex(this.btn_create, 0);
            this.Controls.SetChildIndex(this.lbl_description, 0);
            this.Controls.SetChildIndex(this.txt_filter, 0);
            this.Controls.SetChildIndex(this.dg_result, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dg_result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_change_translate;
        private Button btn_create;
        private Label lbl_description;
        private TextBox txt_filter;
        private DataGridView dg_result;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewButtonColumn Column4;
        private DataGridViewButtonColumn Column5;
    }
}