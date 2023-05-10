namespace Lab2.Forms
{
    partial class MatchesForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatchesForm));
            this.tUSURDataSet = new Lab2.TUSURDataSet();
            this.matchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matchTableAdapter = new Lab2.TUSURDataSetTableAdapters.MatchTableAdapter();
            this.tableAdapterManager = new Lab2.TUSURDataSetTableAdapters.TableAdapterManager();
            this.matchScoreTableAdapter = new Lab2.TUSURDataSetTableAdapters.MatchScoreTableAdapter();
            this.matchScoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.matchBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.matchBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.matchScoreBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.matchScoreDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.teamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchScoreMatchIdfkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamTableAdapter = new Lab2.TUSURDataSetTableAdapters.TeamTableAdapter();
            this.matchLineupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matchLineupTableAdapter = new Lab2.TUSURDataSetTableAdapters.MatchLineupTableAdapter();
            this.matchLineupDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matchLineupMatchIdfkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matchLineupBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.playerTableAdapter = new Lab2.TUSURDataSetTableAdapters.PlayerTableAdapter();
            this.matchLineupPlayerIdfkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            idLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tUSURDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchScoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingNavigator)).BeginInit();
            this.matchBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matchScoreBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchScoreDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchScoreMatchIdfkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchLineupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchLineupDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchLineupMatchIdfkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchLineupBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchLineupPlayerIdfkBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(17, 41);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(17, 68);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 3;
            dateLabel.Text = "Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(17, 101);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(66, 13);
            label1.TabIndex = 6;
            label1.Text = "Счет матча:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(506, 101);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(79, 13);
            label2.TabIndex = 7;
            label2.Text = "Состав матча:";
            // 
            // tUSURDataSet
            // 
            this.tUSURDataSet.DataSetName = "TUSURDataSet";
            this.tUSURDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // matchBindingSource
            // 
            this.matchBindingSource.DataMember = "Match";
            this.matchBindingSource.DataSource = this.tUSURDataSet;
            // 
            // matchTableAdapter
            // 
            this.matchTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LeagueTableTableAdapter = null;
            this.tableAdapterManager.MatchLineupTableAdapter = null;
            this.tableAdapterManager.MatchScoreTableAdapter = this.matchScoreTableAdapter;
            this.tableAdapterManager.MatchTableAdapter = this.matchTableAdapter;
            this.tableAdapterManager.PlayerTableAdapter = null;
            this.tableAdapterManager.TeamTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Lab2.TUSURDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // matchScoreTableAdapter
            // 
            this.matchScoreTableAdapter.ClearBeforeFill = true;
            // 
            // matchScoreBindingSource
            // 
            this.matchScoreBindingSource.DataMember = "MatchScore";
            this.matchScoreBindingSource.DataSource = this.tUSURDataSet;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // matchBindingNavigatorSaveItem
            // 
            this.matchBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.matchBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("matchBindingNavigatorSaveItem.Image")));
            this.matchBindingNavigatorSaveItem.Name = "matchBindingNavigatorSaveItem";
            this.matchBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.matchBindingNavigatorSaveItem.Text = "Save Data";
            this.matchBindingNavigatorSaveItem.Click += new System.EventHandler(this.MatchBindingNavigatorSaveItem_Click);
            // 
            // matchBindingNavigator
            // 
            this.matchBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.matchBindingNavigator.BindingSource = this.matchBindingSource;
            this.matchBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.matchBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.matchBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.matchBindingNavigatorSaveItem});
            this.matchBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.matchBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.matchBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.matchBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.matchBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.matchBindingNavigator.Name = "matchBindingNavigator";
            this.matchBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.matchBindingNavigator.Size = new System.Drawing.Size(984, 25);
            this.matchBindingNavigator.TabIndex = 0;
            this.matchBindingNavigator.Text = "bindingNavigator1";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matchBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(95, 38);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(175, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.matchBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(95, 64);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(175, 20);
            this.dateDateTimePicker.TabIndex = 4;
            // 
            // matchScoreBindingSource1
            // 
            this.matchScoreBindingSource1.DataMember = "MatchScore_Match_Id_fk";
            this.matchScoreBindingSource1.DataSource = this.matchBindingSource;
            // 
            // matchScoreDataGridView
            // 
            this.matchScoreDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.matchScoreDataGridView.AutoGenerateColumns = false;
            this.matchScoreDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.matchScoreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matchScoreDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.matchScoreDataGridView.DataSource = this.matchScoreMatchIdfkBindingSource;
            this.matchScoreDataGridView.Location = new System.Drawing.Point(95, 101);
            this.matchScoreDataGridView.Name = "matchScoreDataGridView";
            this.matchScoreDataGridView.ReadOnly = true;
            this.matchScoreDataGridView.Size = new System.Drawing.Size(392, 348);
            this.matchScoreDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TeamId";
            this.dataGridViewTextBoxColumn3.DataSource = this.teamBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "TeamName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Team";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "Id";
            // 
            // teamBindingSource
            // 
            this.teamBindingSource.DataMember = "Team";
            this.teamBindingSource.DataSource = this.tUSURDataSet;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Goals";
            this.dataGridViewTextBoxColumn4.HeaderText = "Goals";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // matchScoreMatchIdfkBindingSource
            // 
            this.matchScoreMatchIdfkBindingSource.DataMember = "MatchScore_Match_Id_fk";
            this.matchScoreMatchIdfkBindingSource.DataSource = this.matchBindingSource;
            // 
            // teamTableAdapter
            // 
            this.teamTableAdapter.ClearBeforeFill = true;
            // 
            // matchLineupBindingSource
            // 
            this.matchLineupBindingSource.DataMember = "MatchLineup_Match_Id_fk";
            this.matchLineupBindingSource.DataSource = this.matchBindingSource;
            // 
            // matchLineupTableAdapter
            // 
            this.matchLineupTableAdapter.ClearBeforeFill = true;
            // 
            // matchLineupDataGridView
            // 
            this.matchLineupDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.matchLineupDataGridView.AutoGenerateColumns = false;
            this.matchLineupDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.matchLineupDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matchLineupDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6});
            this.matchLineupDataGridView.DataSource = this.matchLineupBindingSource;
            this.matchLineupDataGridView.Location = new System.Drawing.Point(584, 101);
            this.matchLineupDataGridView.Name = "matchLineupDataGridView";
            this.matchLineupDataGridView.ReadOnly = true;
            this.matchLineupDataGridView.Size = new System.Drawing.Size(388, 348);
            this.matchLineupDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PlayerId";
            this.dataGridViewTextBoxColumn6.DataSource = this.playerBindingSource;
            this.dataGridViewTextBoxColumn6.DisplayMember = "PlayerName";
            this.dataGridViewTextBoxColumn6.HeaderText = "Player";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.ValueMember = "Id";
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataMember = "Player";
            this.playerBindingSource.DataSource = this.tUSURDataSet;
            // 
            // matchLineupMatchIdfkBindingSource
            // 
            this.matchLineupMatchIdfkBindingSource.DataMember = "MatchLineup_Match_Id_fk";
            this.matchLineupMatchIdfkBindingSource.DataSource = this.matchBindingSource;
            // 
            // matchLineupBindingSource1
            // 
            this.matchLineupBindingSource1.DataMember = "MatchLineup";
            this.matchLineupBindingSource1.DataSource = this.tUSURDataSet;
            // 
            // playerTableAdapter
            // 
            this.playerTableAdapter.ClearBeforeFill = true;
            // 
            // matchLineupPlayerIdfkBindingSource
            // 
            this.matchLineupPlayerIdfkBindingSource.DataMember = "MatchLineup_Player_Id_fk";
            this.matchLineupPlayerIdfkBindingSource.DataSource = this.playerBindingSource;
            // 
            // MatchesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.matchLineupDataGridView);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.matchScoreDataGridView);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(this.matchBindingNavigator);
            this.MaximumSize = new System.Drawing.Size(1000, 500);
            this.Name = "MatchesForm";
            this.Text = "Матчи";
            this.Load += new System.EventHandler(this.MatchesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tUSURDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchScoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingNavigator)).EndInit();
            this.matchBindingNavigator.ResumeLayout(false);
            this.matchBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matchScoreBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchScoreDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchScoreMatchIdfkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchLineupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchLineupDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchLineupMatchIdfkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchLineupBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchLineupPlayerIdfkBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TUSURDataSet tUSURDataSet;
        private System.Windows.Forms.BindingSource matchBindingSource;
        private TUSURDataSetTableAdapters.MatchTableAdapter matchTableAdapter;
        private TUSURDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private TUSURDataSetTableAdapters.MatchScoreTableAdapter matchScoreTableAdapter;
        private System.Windows.Forms.BindingSource matchScoreBindingSource;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton matchBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator matchBindingNavigator;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.BindingSource matchScoreBindingSource1;
        private System.Windows.Forms.DataGridView matchScoreDataGridView;
        private System.Windows.Forms.BindingSource matchScoreMatchIdfkBindingSource;
        private System.Windows.Forms.BindingSource teamBindingSource;
        private TUSURDataSetTableAdapters.TeamTableAdapter teamTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource matchLineupBindingSource;
        private TUSURDataSetTableAdapters.MatchLineupTableAdapter matchLineupTableAdapter;
        private System.Windows.Forms.DataGridView matchLineupDataGridView;
        private System.Windows.Forms.BindingSource matchLineupMatchIdfkBindingSource;
        private System.Windows.Forms.BindingSource matchLineupBindingSource1;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private TUSURDataSetTableAdapters.PlayerTableAdapter playerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource matchLineupPlayerIdfkBindingSource;
    }
}