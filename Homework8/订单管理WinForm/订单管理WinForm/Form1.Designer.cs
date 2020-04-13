namespace 订单管理WinForm
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.lblCurrentState = new System.Windows.Forms.Label();
            this.lblNotice2 = new System.Windows.Forms.Label();
            this.lblCurrentOrder = new System.Windows.Forms.Label();
            this.lblNotice1 = new System.Windows.Forms.Label();
            this.ctrlSplitContainer = new System.Windows.Forms.SplitContainer();
            this.operateGroupBox = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblAddress = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.btnReturnAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch2 = new System.Windows.Forms.Label();
            this.lblSearch1 = new System.Windows.Forms.Label();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.orderSplitContainer = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.itemNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.singlePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSplitContainer)).BeginInit();
            this.ctrlSplitContainer.Panel1.SuspendLayout();
            this.ctrlSplitContainer.Panel2.SuspendLayout();
            this.ctrlSplitContainer.SuspendLayout();
            this.operateGroupBox.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.searchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderSplitContainer)).BeginInit();
            this.orderSplitContainer.Panel1.SuspendLayout();
            this.orderSplitContainer.Panel2.SuspendLayout();
            this.orderSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // infoPanel
            // 
            this.infoPanel.Controls.Add(this.lblCurrentState);
            this.infoPanel.Controls.Add(this.lblNotice2);
            this.infoPanel.Controls.Add(this.lblCurrentOrder);
            this.infoPanel.Controls.Add(this.lblNotice1);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.infoPanel.Location = new System.Drawing.Point(0, 436);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(1114, 32);
            this.infoPanel.TabIndex = 3;
            // 
            // lblCurrentState
            // 
            this.lblCurrentState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentState.AutoSize = true;
            this.lblCurrentState.Location = new System.Drawing.Point(583, 4);
            this.lblCurrentState.Name = "lblCurrentState";
            this.lblCurrentState.Size = new System.Drawing.Size(39, 15);
            this.lblCurrentState.TabIndex = 3;
            this.lblCurrentState.Text = "null";
            // 
            // lblNotice2
            // 
            this.lblNotice2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotice2.AutoSize = true;
            this.lblNotice2.Location = new System.Drawing.Point(495, 4);
            this.lblNotice2.Name = "lblNotice2";
            this.lblNotice2.Size = new System.Drawing.Size(82, 15);
            this.lblNotice2.TabIndex = 2;
            this.lblNotice2.Text = "当前状态：";
            // 
            // lblCurrentOrder
            // 
            this.lblCurrentOrder.AutoSize = true;
            this.lblCurrentOrder.Location = new System.Drawing.Point(152, 4);
            this.lblCurrentOrder.Name = "lblCurrentOrder";
            this.lblCurrentOrder.Size = new System.Drawing.Size(0, 15);
            this.lblCurrentOrder.TabIndex = 1;
            // 
            // lblNotice1
            // 
            this.lblNotice1.AutoSize = true;
            this.lblNotice1.Location = new System.Drawing.Point(4, 4);
            this.lblNotice1.Name = "lblNotice1";
            this.lblNotice1.Size = new System.Drawing.Size(142, 15);
            this.lblNotice1.TabIndex = 0;
            this.lblNotice1.Text = "当前选择订单编号：";
            // 
            // ctrlSplitContainer
            // 
            this.ctrlSplitContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrlSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.ctrlSplitContainer.Name = "ctrlSplitContainer";
            // 
            // ctrlSplitContainer.Panel1
            // 
            this.ctrlSplitContainer.Panel1.Controls.Add(this.operateGroupBox);
            // 
            // ctrlSplitContainer.Panel2
            // 
            this.ctrlSplitContainer.Panel2.Controls.Add(this.searchGroupBox);
            this.ctrlSplitContainer.Size = new System.Drawing.Size(1114, 100);
            this.ctrlSplitContainer.SplitterDistance = 542;
            this.ctrlSplitContainer.TabIndex = 4;
            // 
            // operateGroupBox
            // 
            this.operateGroupBox.Controls.Add(this.flowLayoutPanel2);
            this.operateGroupBox.Controls.Add(this.flowLayoutPanel1);
            this.operateGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operateGroupBox.Location = new System.Drawing.Point(0, 0);
            this.operateGroupBox.Name = "operateGroupBox";
            this.operateGroupBox.Size = new System.Drawing.Size(542, 100);
            this.operateGroupBox.TabIndex = 0;
            this.operateGroupBox.TabStop = false;
            this.operateGroupBox.Text = "订单管理";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.btnImport);
            this.flowLayoutPanel2.Controls.Add(this.btnExport);
            this.flowLayoutPanel2.Controls.Add(this.lblAddress);
            this.flowLayoutPanel2.Controls.Add(this.textBox1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 53);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(536, 34);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(3, 3);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(100, 23);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "导入订单";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(109, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 23);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "导出订单";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(215, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(67, 15);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "文件地址";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(288, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 25);
            this.textBox1.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAddOrder);
            this.flowLayoutPanel1.Controls.Add(this.btnAddItem);
            this.flowLayoutPanel1.Controls.Add(this.btnDeleteOrder);
            this.flowLayoutPanel1.Controls.Add(this.btnDeleteItem);
            this.flowLayoutPanel1.Controls.Add(this.btnUpdate);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 21);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(536, 32);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(3, 3);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(100, 23);
            this.btnAddOrder.TabIndex = 0;
            this.btnAddOrder.Text = "增加订单";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(109, 3);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(100, 23);
            this.btnAddItem.TabIndex = 1;
            this.btnAddItem.Text = "增加明细";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Location = new System.Drawing.Point(215, 3);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteOrder.TabIndex = 2;
            this.btnDeleteOrder.Text = "删除订单";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(321, 3);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteItem.TabIndex = 3;
            this.btnDeleteItem.Text = "删除明细";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(427, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "修改明细";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.btnReturnAll);
            this.searchGroupBox.Controls.Add(this.btnSearch);
            this.searchGroupBox.Controls.Add(this.lblSearch2);
            this.searchGroupBox.Controls.Add(this.lblSearch1);
            this.searchGroupBox.Controls.Add(this.cmbSearch);
            this.searchGroupBox.Controls.Add(this.txtSearch);
            this.searchGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchGroupBox.Location = new System.Drawing.Point(0, 0);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(568, 100);
            this.searchGroupBox.TabIndex = 0;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "查询";
            // 
            // btnReturnAll
            // 
            this.btnReturnAll.Location = new System.Drawing.Point(467, 71);
            this.btnReturnAll.Name = "btnReturnAll";
            this.btnReturnAll.Size = new System.Drawing.Size(100, 23);
            this.btnReturnAll.TabIndex = 5;
            this.btnReturnAll.Text = "显示全部";
            this.btnReturnAll.UseVisualStyleBackColor = true;
            this.btnReturnAll.Click += new System.EventHandler(this.btnReturnAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(467, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearch2
            // 
            this.lblSearch2.AutoSize = true;
            this.lblSearch2.Location = new System.Drawing.Point(218, 49);
            this.lblSearch2.Name = "lblSearch2";
            this.lblSearch2.Size = new System.Drawing.Size(52, 15);
            this.lblSearch2.TabIndex = 3;
            this.lblSearch2.Text = "关键字";
            // 
            // lblSearch1
            // 
            this.lblSearch1.AutoSize = true;
            this.lblSearch1.Location = new System.Drawing.Point(18, 49);
            this.lblSearch1.Name = "lblSearch1";
            this.lblSearch1.Size = new System.Drawing.Size(67, 15);
            this.lblSearch1.TabIndex = 2;
            this.lblSearch1.Text = "查询条件";
            // 
            // cmbSearch
            // 
            this.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Items.AddRange(new object[] {
            "订单编号",
            "用户ID",
            "指定商品编号"});
            this.cmbSearch.Location = new System.Drawing.Point(91, 46);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(121, 23);
            this.cmbSearch.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(276, 44);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(168, 25);
            this.txtSearch.TabIndex = 0;
            // 
            // orderSplitContainer
            // 
            this.orderSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderSplitContainer.Location = new System.Drawing.Point(0, 100);
            this.orderSplitContainer.Name = "orderSplitContainer";
            // 
            // orderSplitContainer.Panel1
            // 
            this.orderSplitContainer.Panel1.Controls.Add(this.dataGridView1);
            // 
            // orderSplitContainer.Panel2
            // 
            this.orderSplitContainer.Panel2.Controls.Add(this.dataGridView2);
            this.orderSplitContainer.Size = new System.Drawing.Size(1114, 336);
            this.orderSplitContainer.SplitterDistance = 495;
            this.orderSplitContainer.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNumberDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn,
            this.orderTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(495, 336);
            this.dataGridView1.TabIndex = 0;
            // 
            // orderNumberDataGridViewTextBoxColumn
            // 
            this.orderNumberDataGridViewTextBoxColumn.DataPropertyName = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn.HeaderText = "订单编号";
            this.orderNumberDataGridViewTextBoxColumn.Name = "orderNumberDataGridViewTextBoxColumn";
            this.orderNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "用户";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerDataGridViewTextBoxColumn.Width = 150;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "总金额";
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderTimeDataGridViewTextBoxColumn
            // 
            this.orderTimeDataGridViewTextBoxColumn.DataPropertyName = "OrderTime";
            this.orderTimeDataGridViewTextBoxColumn.HeaderText = "下单时间";
            this.orderTimeDataGridViewTextBoxColumn.Name = "orderTimeDataGridViewTextBoxColumn";
            this.orderTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(homework5.Order);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemNumberDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.singlePriceDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.itemsBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(615, 336);
            this.dataGridView2.TabIndex = 0;
            // 
            // itemNumberDataGridViewTextBoxColumn
            // 
            this.itemNumberDataGridViewTextBoxColumn.DataPropertyName = "ItemNumber";
            this.itemNumberDataGridViewTextBoxColumn.HeaderText = "商品号";
            this.itemNumberDataGridViewTextBoxColumn.Name = "itemNumberDataGridViewTextBoxColumn";
            this.itemNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "商品名称";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // singlePriceDataGridViewTextBoxColumn
            // 
            this.singlePriceDataGridViewTextBoxColumn.DataPropertyName = "SinglePrice";
            this.singlePriceDataGridViewTextBoxColumn.HeaderText = "单价";
            this.singlePriceDataGridViewTextBoxColumn.Name = "singlePriceDataGridViewTextBoxColumn";
            this.singlePriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "数量";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalPriceDataGridViewTextBoxColumn1
            // 
            this.totalPriceDataGridViewTextBoxColumn1.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn1.HeaderText = "总金额";
            this.totalPriceDataGridViewTextBoxColumn1.Name = "totalPriceDataGridViewTextBoxColumn1";
            this.totalPriceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.orderBindingSource;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 468);
            this.Controls.Add(this.orderSplitContainer);
            this.Controls.Add(this.ctrlSplitContainer);
            this.Controls.Add(this.infoPanel);
            this.Name = "Form1";
            this.Text = "YYZ\'s订单管理系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.ctrlSplitContainer.Panel1.ResumeLayout(false);
            this.ctrlSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSplitContainer)).EndInit();
            this.ctrlSplitContainer.ResumeLayout(false);
            this.operateGroupBox.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.orderSplitContainer.Panel1.ResumeLayout(false);
            this.orderSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderSplitContainer)).EndInit();
            this.orderSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label lblNotice1;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.SplitContainer ctrlSplitContainer;
        private System.Windows.Forms.SplitContainer orderSplitContainer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox operateGroupBox;
        private System.Windows.Forms.Label lblCurrentOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn singlePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label lblNotice2;
        private System.Windows.Forms.Label lblCurrentState;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.Button btnReturnAll;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch2;
        private System.Windows.Forms.Label lblSearch1;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnUpdate;
    }
}

