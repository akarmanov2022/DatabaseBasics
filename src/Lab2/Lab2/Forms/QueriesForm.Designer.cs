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
            this.requestExamples1 = new Lab2.Controls.RequestExamples();
            this.SuspendLayout();
            // 
            // requestExamples1
            // 
            this.requestExamples1.BackColor = System.Drawing.SystemColors.Control;
            this.requestExamples1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requestExamples1.Location = new System.Drawing.Point(10, 10);
            this.requestExamples1.Margin = new System.Windows.Forms.Padding(10);
            this.requestExamples1.Name = "requestExamples1";
            this.requestExamples1.Size = new System.Drawing.Size(907, 523);
            this.requestExamples1.TabIndex = 0;
            // 
            // QueriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 543);
            this.Controls.Add(this.requestExamples1);
            this.Name = "QueriesForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Запросы";
            this.ResumeLayout(false);
        }

        private Lab2.Controls.RequestExamples requestExamples1;

        #endregion
    }
}