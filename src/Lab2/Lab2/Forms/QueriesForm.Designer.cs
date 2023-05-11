using System.ComponentModel;

namespace Lab2.Forms
{
    partial class QueriesForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBoxSql = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonExecute = new System.Windows.Forms.Button();
            this.DataGridViewResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxSql
            // 
            this.TextBoxSql.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSql.Location = new System.Drawing.Point(12, 35);
            this.TextBoxSql.Multiline = true;
            this.TextBoxSql.Name = "TextBoxSql";
            this.TextBoxSql.Size = new System.Drawing.Size(776, 166);
            this.TextBoxSql.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "SQL-запрос:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ButtonExecute
            // 
            this.ButtonExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonExecute.Location = new System.Drawing.Point(713, 207);
            this.ButtonExecute.Name = "ButtonExecute";
            this.ButtonExecute.Size = new System.Drawing.Size(75, 23);
            this.ButtonExecute.TabIndex = 2;
            this.ButtonExecute.Text = "Выполнить";
            this.ButtonExecute.UseVisualStyleBackColor = true;
            this.ButtonExecute.Click += new System.EventHandler(this.ButtonExecute_Click);
            // 
            // DataGridViewResult
            // 
            this.DataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewResult.Location = new System.Drawing.Point(12, 236);
            this.DataGridViewResult.Name = "DataGridViewResult";
            this.DataGridViewResult.Size = new System.Drawing.Size(776, 202);
            this.DataGridViewResult.TabIndex = 3;
            // 
            // QueriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGridViewResult);
            this.Controls.Add(this.ButtonExecute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxSql);
            this.Name = "QueriesForm";
            this.Text = "Запросы";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button ButtonExecute;

        private System.Windows.Forms.DataGridView DataGridViewResult;

        private System.Windows.Forms.TextBox TextBoxSql;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}