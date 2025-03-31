namespace OrderManagementWinForm2
{
    partial class Form1
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
            dataGridViewOrders = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonCreateOrder = new Button();
            buttonDeleteOrder = new Button();
            buttonUpdateOrder = new Button();
            buttonQueryOrder = new Button();
            textBoxQuery = new TextBox();
            comboBoxQueryType = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Dock = DockStyle.Fill;
            dataGridViewOrders.Location = new Point(0, 0);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.Size = new Size(800, 450);
            dataGridViewOrders.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(buttonCreateOrder, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonDeleteOrder, 1, 0);
            tableLayoutPanel1.Controls.Add(buttonUpdateOrder, 2, 0);
            tableLayoutPanel1.Controls.Add(buttonQueryOrder, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 420);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 30);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // buttonCreateOrder
            // 
            buttonCreateOrder.Location = new Point(3, 3);
            buttonCreateOrder.Name = "buttonCreateOrder";
            buttonCreateOrder.Size = new Size(75, 23);
            buttonCreateOrder.TabIndex = 2;
            buttonCreateOrder.Text = "创建订单";
            buttonCreateOrder.UseVisualStyleBackColor = true;
            buttonCreateOrder.Click += buttonCreateOrder_Click;
            // 
            // buttonDeleteOrder
            // 
            buttonDeleteOrder.Location = new Point(203, 3);
            buttonDeleteOrder.Name = "buttonDeleteOrder";
            buttonDeleteOrder.Size = new Size(75, 23);
            buttonDeleteOrder.TabIndex = 3;
            buttonDeleteOrder.Text = "删除订单";
            buttonDeleteOrder.UseVisualStyleBackColor = true;
            buttonDeleteOrder.Click += buttonDeleteOrder_Click;
            // 
            // buttonUpdateOrder
            // 
            buttonUpdateOrder.Location = new Point(403, 3);
            buttonUpdateOrder.Name = "buttonUpdateOrder";
            buttonUpdateOrder.Size = new Size(75, 23);
            buttonUpdateOrder.TabIndex = 4;
            buttonUpdateOrder.Text = "修改订单";
            buttonUpdateOrder.UseVisualStyleBackColor = true;
            buttonUpdateOrder.Click += buttonUpdateOrder_Click;
            // 
            // buttonQueryOrder
            // 
            buttonQueryOrder.Location = new Point(603, 3);
            buttonQueryOrder.Name = "buttonQueryOrder";
            buttonQueryOrder.Size = new Size(75, 23);
            buttonQueryOrder.TabIndex = 5;
            buttonQueryOrder.Text = "查询订单";
            buttonQueryOrder.UseVisualStyleBackColor = true;
            // 
            // textBoxQuery
            // 
            textBoxQuery.Location = new Point(603, 394);
            textBoxQuery.Name = "textBoxQuery";
            textBoxQuery.Size = new Size(100, 23);
            textBoxQuery.TabIndex = 2;
            // 
            // comboBoxQueryType
            // 
            comboBoxQueryType.FormattingEnabled = true;
            comboBoxQueryType.Items.AddRange(new object[] { "按订单ID", "按客户", "按产品" });
            comboBoxQueryType.Location = new Point(603, 363);
            comboBoxQueryType.Name = "comboBoxQueryType";
            comboBoxQueryType.Size = new Size(121, 25);
            comboBoxQueryType.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxQueryType);
            Controls.Add(textBoxQuery);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dataGridViewOrders);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewOrders;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonCreateOrder;
        private Button buttonDeleteOrder;
        private Button buttonUpdateOrder;
        private Button buttonQueryOrder;
        private TextBox textBoxQuery;
        private ComboBox comboBoxQueryType;
    }
}
