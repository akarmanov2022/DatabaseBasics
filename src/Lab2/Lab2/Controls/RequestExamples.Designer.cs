using System.ComponentModel;

namespace Lab2.Controls
{
    partial class RequestExamples
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataGridViewSql = new System.Windows.Forms.DataGridView();
            this.TextBoxSql = new System.Windows.Forms.TextBox();
            this.ButtonExecute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSql)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewSql
            // 
            this.DataGridViewSql.AllowUserToAddRows = false;
            this.DataGridViewSql.AllowUserToDeleteRows = false;
            this.DataGridViewSql.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewSql.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewSql.Location = new System.Drawing.Point(3, 265);
            this.DataGridViewSql.Name = "DataGridViewSql";
            this.DataGridViewSql.ReadOnly = true;
            this.DataGridViewSql.Size = new System.Drawing.Size(703, 270);
            this.DataGridViewSql.TabIndex = 1;
            // 
            // TextBoxSql
            // 
            this.TextBoxSql.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSql.AutoCompleteCustomSource.AddRange(new string[] { "SELECT", "DELETE", "FROM", "INSERT", "UPDATE" });
            this.TextBoxSql.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TextBoxSql.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TextBoxSql.Location = new System.Drawing.Point(3, 26);
            this.TextBoxSql.Multiline = true;
            this.TextBoxSql.Name = "TextBoxSql";
            this.TextBoxSql.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBoxSql.Size = new System.Drawing.Size(703, 204);
            this.TextBoxSql.TabIndex = 2;
            // 
            // ButtonExecute
            // 
            this.ButtonExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonExecute.Location = new System.Drawing.Point(631, 236);
            this.ButtonExecute.Name = "ButtonExecute";
            this.ButtonExecute.Size = new System.Drawing.Size(75, 23);
            this.ButtonExecute.TabIndex = 3;
            this.ButtonExecute.Text = "Выполнить";
            this.ButtonExecute.UseVisualStyleBackColor = true;
            this.ButtonExecute.Click += new System.EventHandler(this.ButtonExecute_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Запрос:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RequestExamples
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonExecute);
            this.Controls.Add(this.TextBoxSql);
            this.Controls.Add(this.DataGridViewSql);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "RequestExamples";
            this.Size = new System.Drawing.Size(706, 538);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSql)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button ButtonExecute;

        private System.Windows.Forms.TextBox TextBoxSql;

        private System.Windows.Forms.DataGridView DataGridViewSql;

        #endregion
    }
}