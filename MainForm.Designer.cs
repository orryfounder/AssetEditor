namespace AssetEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddAssetMenuSubItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAssetMenuSubItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAssetsMenuSubItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuSubItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeEnterpriseMenuSubItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extensionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumMonetariesMenuSubItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumNonCashMenuSubItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumCashMenuSubItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumOtherMonetaryMenuSubItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalSumMenuSubItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avgMonetariesMenuSubItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countAssetsMenuSubItems = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.AssetGroupsListView = new System.Windows.Forms.ListView();
            this.AssetsGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.changeButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avgNonCashMenuSubItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avgCashMenuSubItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avgOtherMonetaryMenuSubItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avgAllMonetariesMenuSubItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AssetsGridView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(932, 492);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.editMenuItem,
            this.settingsMenuItem,
            this.extensionMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(932, 22);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddAssetMenuSubItem,
            this.deleteAssetMenuSubItem,
            this.clearAssetsMenuSubItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(48, 18);
            this.fileMenuItem.Text = "Файл";
            // 
            // AddAssetMenuSubItem
            // 
            this.AddAssetMenuSubItem.Name = "AddAssetMenuSubItem";
            this.AddAssetMenuSubItem.Size = new System.Drawing.Size(214, 22);
            this.AddAssetMenuSubItem.Text = "Создать актив";
            this.AddAssetMenuSubItem.Click += new System.EventHandler(this.AddAssetMenuSubItem_Click);
            // 
            // deleteAssetMenuSubItem
            // 
            this.deleteAssetMenuSubItem.Name = "deleteAssetMenuSubItem";
            this.deleteAssetMenuSubItem.Size = new System.Drawing.Size(214, 22);
            this.deleteAssetMenuSubItem.Text = "Удалить актив";
            this.deleteAssetMenuSubItem.Click += new System.EventHandler(this.DeleteAssetMenuSubItem_Click);
            // 
            // clearAssetsMenuSubItem
            // 
            this.clearAssetsMenuSubItem.Name = "clearAssetsMenuSubItem";
            this.clearAssetsMenuSubItem.Size = new System.Drawing.Size(214, 22);
            this.clearAssetsMenuSubItem.Text = "Очистить список активов";
            this.clearAssetsMenuSubItem.Click += new System.EventHandler(this.ClearAssetsMenuSubItem_Click);
            // 
            // editMenuItem
            // 
            this.editMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editMenuSubItem});
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(59, 18);
            this.editMenuItem.Text = "Правка";
            // 
            // editMenuSubItem
            // 
            this.editMenuSubItem.Name = "editMenuSubItem";
            this.editMenuSubItem.Size = new System.Drawing.Size(154, 22);
            this.editMenuSubItem.Text = "Редактировать";
            this.editMenuSubItem.Click += new System.EventHandler(this.EditMenuSubItem_Click);
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeEnterpriseMenuSubItem});
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.Size = new System.Drawing.Size(79, 18);
            this.settingsMenuItem.Text = "Настройки";
            // 
            // changeEnterpriseMenuSubItem
            // 
            this.changeEnterpriseMenuSubItem.Name = "changeEnterpriseMenuSubItem";
            this.changeEnterpriseMenuSubItem.Size = new System.Drawing.Size(196, 22);
            this.changeEnterpriseMenuSubItem.Text = "Сменить предприятие";
            this.changeEnterpriseMenuSubItem.Click += new System.EventHandler(this.ChangeEnterpriseMenuSubItem_Click);
            // 
            // extensionMenuItem
            // 
            this.extensionMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumMonetariesMenuSubItem,
            this.avgMonetariesMenuSubItem,
            this.countAssetsMenuSubItems});
            this.extensionMenuItem.Name = "extensionMenuItem";
            this.extensionMenuItem.Size = new System.Drawing.Size(89, 18);
            this.extensionMenuItem.Text = "Расширения";
            // 
            // sumMonetariesMenuSubItem
            // 
            this.sumMonetariesMenuSubItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumNonCashMenuSubItem,
            this.sumCashMenuSubItem,
            this.sumOtherMonetaryMenuSubItem,
            this.totalSumMenuSubItem});
            this.sumMonetariesMenuSubItem.Name = "sumMonetariesMenuSubItem";
            this.sumMonetariesMenuSubItem.Size = new System.Drawing.Size(285, 22);
            this.sumMonetariesMenuSubItem.Text = "Сумма денежных активов";
            // 
            // sumNonCashMenuSubItem
            // 
            this.sumNonCashMenuSubItem.Name = "sumNonCashMenuSubItem";
            this.sumNonCashMenuSubItem.Size = new System.Drawing.Size(180, 22);
            this.sumNonCashMenuSubItem.Text = "Безналичные";
            this.sumNonCashMenuSubItem.Click += new System.EventHandler(this.SumNonCashMenuSubItem_Click);
            // 
            // sumCashMenuSubItem
            // 
            this.sumCashMenuSubItem.Name = "sumCashMenuSubItem";
            this.sumCashMenuSubItem.Size = new System.Drawing.Size(180, 22);
            this.sumCashMenuSubItem.Text = "Наличные";
            this.sumCashMenuSubItem.Click += new System.EventHandler(this.SumCashMenuSubItem_Click);
            // 
            // sumOtherMonetaryMenuSubItem
            // 
            this.sumOtherMonetaryMenuSubItem.Name = "sumOtherMonetaryMenuSubItem";
            this.sumOtherMonetaryMenuSubItem.Size = new System.Drawing.Size(180, 22);
            this.sumOtherMonetaryMenuSubItem.Text = "Другие";
            this.sumOtherMonetaryMenuSubItem.Click += new System.EventHandler(this.SumOtherMonetaryMenuSubItem_Click);
            // 
            // totalSumMenuSubItem
            // 
            this.totalSumMenuSubItem.Name = "totalSumMenuSubItem";
            this.totalSumMenuSubItem.Size = new System.Drawing.Size(180, 22);
            this.totalSumMenuSubItem.Text = "Общая сумма";
            this.totalSumMenuSubItem.Click += new System.EventHandler(this.TotalSumMenuSubItem_Click);
            // 
            // avgMonetariesMenuSubItem
            // 
            this.avgMonetariesMenuSubItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avgNonCashMenuSubItem,
            this.avgCashMenuSubItem,
            this.avgOtherMonetaryMenuSubItem,
            this.avgAllMonetariesMenuSubItem});
            this.avgMonetariesMenuSubItem.Name = "avgMonetariesMenuSubItem";
            this.avgMonetariesMenuSubItem.Size = new System.Drawing.Size(285, 22);
            this.avgMonetariesMenuSubItem.Text = "Средняя стоимость денежных активов";
            // 
            // countAssetsMenuSubItems
            // 
            this.countAssetsMenuSubItems.Name = "countAssetsMenuSubItems";
            this.countAssetsMenuSubItems.Size = new System.Drawing.Size(285, 22);
            this.countAssetsMenuSubItems.Text = "Количество активов";
            this.countAssetsMenuSubItems.Click += new System.EventHandler(this.CountAssetsMenuSubItems_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(3, 25);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.AssetGroupsListView);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.AssetsGridView);
            this.splitContainer.Size = new System.Drawing.Size(926, 408);
            this.splitContainer.SplitterDistance = 249;
            this.splitContainer.TabIndex = 3;
            // 
            // AssetGroupsListView
            // 
            this.AssetGroupsListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.AssetGroupsListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.AssetGroupsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AssetGroupsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AssetGroupsListView.FullRowSelect = true;
            this.AssetGroupsListView.HideSelection = false;
            this.AssetGroupsListView.LabelWrap = false;
            this.AssetGroupsListView.Location = new System.Drawing.Point(0, 0);
            this.AssetGroupsListView.MultiSelect = false;
            this.AssetGroupsListView.Name = "AssetGroupsListView";
            this.AssetGroupsListView.Size = new System.Drawing.Size(249, 408);
            this.AssetGroupsListView.TabIndex = 0;
            this.AssetGroupsListView.UseCompatibleStateImageBehavior = false;
            this.AssetGroupsListView.View = System.Windows.Forms.View.List;
            this.AssetGroupsListView.ItemActivate += new System.EventHandler(this.AssetGroupsListView_ItemActivate);
            // 
            // AssetsGridView
            // 
            this.AssetsGridView.AllowUserToAddRows = false;
            this.AssetsGridView.AllowUserToDeleteRows = false;
            this.AssetsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AssetsGridView.BackgroundColor = System.Drawing.Color.White;
            this.AssetsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssetsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AssetsGridView.Location = new System.Drawing.Point(0, 0);
            this.AssetsGridView.MultiSelect = false;
            this.AssetsGridView.Name = "AssetsGridView";
            this.AssetsGridView.ReadOnly = true;
            this.AssetsGridView.Size = new System.Drawing.Size(673, 408);
            this.AssetsGridView.TabIndex = 0;
            this.AssetsGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AssetsGridView_CellMouseDown);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.Controls.Add(this.changeButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.deleteButton, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.addButton, 5, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 439);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(926, 30);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // changeButton
            // 
            this.changeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changeButton.Location = new System.Drawing.Point(23, 3);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(84, 24);
            this.changeButton.TabIndex = 0;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteButton.Location = new System.Drawing.Point(703, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(84, 24);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.Location = new System.Drawing.Point(813, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(84, 24);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(129, 26);
            // 
            // ChangeToolStripMenuItem
            // 
            this.ChangeToolStripMenuItem.Name = "ChangeToolStripMenuItem";
            this.ChangeToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.ChangeToolStripMenuItem.Text = "Изменить";
            this.ChangeToolStripMenuItem.Click += new System.EventHandler(this.ChangeToolStripMenuItem_Click);
            // 
            // avgNonCashMenuSubItem
            // 
            this.avgNonCashMenuSubItem.Name = "avgNonCashMenuSubItem";
            this.avgNonCashMenuSubItem.Size = new System.Drawing.Size(202, 22);
            this.avgNonCashMenuSubItem.Text = "Безналичные";
            this.avgNonCashMenuSubItem.Click += new System.EventHandler(this.AvgNonCashMenuSubItem_Click);
            // 
            // avgCashMenuSubItem
            // 
            this.avgCashMenuSubItem.Name = "avgCashMenuSubItem";
            this.avgCashMenuSubItem.Size = new System.Drawing.Size(202, 22);
            this.avgCashMenuSubItem.Text = "Наличные";
            this.avgCashMenuSubItem.Click += new System.EventHandler(this.AvgCashMenuSubItem_Click);
            // 
            // avgOtherMonetaryMenuSubItem
            // 
            this.avgOtherMonetaryMenuSubItem.Name = "avgOtherMonetaryMenuSubItem";
            this.avgOtherMonetaryMenuSubItem.Size = new System.Drawing.Size(202, 22);
            this.avgOtherMonetaryMenuSubItem.Text = "Другие";
            this.avgOtherMonetaryMenuSubItem.Click += new System.EventHandler(this.AvgOtherMonetaryMenuSubItem_Click);
            // 
            // avgAllMonetariesMenuSubItem
            // 
            this.avgAllMonetariesMenuSubItem.Name = "avgAllMonetariesMenuSubItem";
            this.avgAllMonetariesMenuSubItem.Size = new System.Drawing.Size(202, 22);
            this.avgAllMonetariesMenuSubItem.Text = "Всех денежных активов";
            this.avgAllMonetariesMenuSubItem.Click += new System.EventHandler(this.AvgAllMonetariesMenuSubItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(932, 492);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(948, 531);
            this.Name = "MainForm";
            this.Text = "Редактор активов";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AssetsGridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeEnterpriseMenuSubItem;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ListView AssetGroupsListView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        public System.Windows.Forms.DataGridView AssetsGridView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ChangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddAssetMenuSubItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAssetMenuSubItem;
        private System.Windows.Forms.ToolStripMenuItem clearAssetsMenuSubItem;
        private System.Windows.Forms.ToolStripMenuItem editMenuSubItem;
        private System.Windows.Forms.ToolStripMenuItem extensionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumMonetariesMenuSubItem;
        private System.Windows.Forms.ToolStripMenuItem avgMonetariesMenuSubItem;
        private System.Windows.Forms.ToolStripMenuItem countAssetsMenuSubItems;
        private System.Windows.Forms.ToolStripMenuItem sumNonCashMenuSubItem;
        private System.Windows.Forms.ToolStripMenuItem sumCashMenuSubItem;
        private System.Windows.Forms.ToolStripMenuItem sumOtherMonetaryMenuSubItem;
        private System.Windows.Forms.ToolStripMenuItem totalSumMenuSubItem;
        private System.Windows.Forms.ToolStripMenuItem avgNonCashMenuSubItem;
        private System.Windows.Forms.ToolStripMenuItem avgCashMenuSubItem;
        private System.Windows.Forms.ToolStripMenuItem avgOtherMonetaryMenuSubItem;
        private System.Windows.Forms.ToolStripMenuItem avgAllMonetariesMenuSubItem;
    }
}

