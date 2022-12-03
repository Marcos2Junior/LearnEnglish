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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_change_translate = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.lbl_description = new System.Windows.Forms.Label();
            this.txt_filter = new System.Windows.Forms.TextBox();
            this.dg_result = new System.Windows.Forms.DataGridView();
            this.column_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_translate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_last_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_details = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.txt_filter.ForeColor = System.Drawing.Color.White;
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
            this.dg_result.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_value,
            this.column_translate,
            this.column_last_update,
            this.column_details});
            this.dg_result.GridColor = System.Drawing.SystemColors.Control;
            this.dg_result.Location = new System.Drawing.Point(22, 104);
            this.dg_result.Name = "dg_result";
            this.dg_result.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_result.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_result.RowHeadersVisible = false;
            this.dg_result.RowTemplate.Height = 25;
            this.dg_result.Size = new System.Drawing.Size(730, 134);
            this.dg_result.TabIndex = 6;
            // 
            // column_value
            // 
            this.column_value.HeaderText = "Value";
            this.column_value.Name = "column_value";
            this.column_value.ReadOnly = true;
            this.column_value.Width = 145;
            // 
            // column_translate
            // 
            this.column_translate.HeaderText = "Translate";
            this.column_translate.Name = "column_translate";
            this.column_translate.ReadOnly = true;
            this.column_translate.Width = 146;
            // 
            // column_last_update
            // 
            this.column_last_update.HeaderText = "Last Update";
            this.column_last_update.Name = "column_last_update";
            this.column_last_update.ReadOnly = true;
            this.column_last_update.Width = 145;
            // 
            // column_details
            // 
            this.column_details.HeaderText = "";
            this.column_details.Name = "column_details";
            this.column_details.ReadOnly = true;
            this.column_details.Width = 146;
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
        private DataGridViewTextBoxColumn column_value;
        private DataGridViewTextBoxColumn column_translate;
        private DataGridViewTextBoxColumn column_last_update;
        private DataGridViewButtonColumn column_details;
    }
}