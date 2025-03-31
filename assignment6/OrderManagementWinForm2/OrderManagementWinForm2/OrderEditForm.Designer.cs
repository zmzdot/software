namespace OrderManagementWinForm2
{
    partial class OrderEditForm
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
            textBoxOrderId = new TextBox();
            labelOrderId = new Label();
            labelCustomer = new Label();
            textBoxCustomer = new TextBox();
            dataGridViewOrderDetails = new DataGridView();
            buttonAddDetail = new Button();
            buttonDeleteDetails = new Button();
            buttonSave = new Button();
            buttonCancel = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBoxQuantity = new TextBox();
            textBoxProduct = new TextBox();
            textBoxPrice = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderDetails).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxOrderId
            // 
            textBoxOrderId.Location = new Point(3, 31);
            textBoxOrderId.Name = "textBoxOrderId";
            textBoxOrderId.Size = new Size(91, 23);
            textBoxOrderId.TabIndex = 0;
            // 
            // labelOrderId
            // 
            labelOrderId.AutoSize = true;
            labelOrderId.Location = new Point(3, 0);
            labelOrderId.Name = "labelOrderId";
            labelOrderId.Size = new Size(45, 17);
            labelOrderId.TabIndex = 1;
            labelOrderId.Text = "订单ID";
            // 
            // labelCustomer
            // 
            labelCustomer.AutoSize = true;
            labelCustomer.Location = new Point(100, 0);
            labelCustomer.Name = "labelCustomer";
            labelCustomer.Size = new Size(44, 17);
            labelCustomer.TabIndex = 2;
            labelCustomer.Text = "客户名";
            // 
            // textBoxCustomer
            // 
            textBoxCustomer.Location = new Point(100, 31);
            textBoxCustomer.Name = "textBoxCustomer";
            textBoxCustomer.Size = new Size(91, 23);
            textBoxCustomer.TabIndex = 3;
            // 
            // dataGridViewOrderDetails
            // 
            dataGridViewOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrderDetails.Location = new Point(168, 12);
            dataGridViewOrderDetails.Name = "dataGridViewOrderDetails";
            dataGridViewOrderDetails.Size = new Size(240, 150);
            dataGridViewOrderDetails.TabIndex = 4;
            dataGridViewOrderDetails.CellContentClick += dataGridViewOrderDetails_CellContentClick;
            // 
            // buttonAddDetail
            // 
            buttonAddDetail.Location = new Point(147, 247);
            buttonAddDetail.Name = "buttonAddDetail";
            buttonAddDetail.Size = new Size(75, 23);
            buttonAddDetail.TabIndex = 5;
            buttonAddDetail.Text = "添加明细";
            buttonAddDetail.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteDetails
            // 
            buttonDeleteDetails.Location = new Point(333, 247);
            buttonDeleteDetails.Name = "buttonDeleteDetails";
            buttonDeleteDetails.Size = new Size(75, 23);
            buttonDeleteDetails.TabIndex = 6;
            buttonDeleteDetails.Text = "删除明细";
            buttonDeleteDetails.UseVisualStyleBackColor = true;
            buttonDeleteDetails.Click += buttonDeleteDetails_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(3, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 7;
            buttonSave.Text = "保存";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(103, 3);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 8;
            buttonCancel.Text = "取消";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(buttonSave, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonCancel, 1, 0);
            tableLayoutPanel1.Location = new Point(394, 418);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(200, 29);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(labelOrderId, 0, 0);
            tableLayoutPanel2.Controls.Add(textBoxOrderId, 0, 1);
            tableLayoutPanel2.Controls.Add(labelCustomer, 1, 0);
            tableLayoutPanel2.Controls.Add(textBoxQuantity, 4, 1);
            tableLayoutPanel2.Controls.Add(textBoxCustomer, 1, 1);
            tableLayoutPanel2.Controls.Add(textBoxProduct, 2, 1);
            tableLayoutPanel2.Controls.Add(textBoxPrice, 3, 1);
            tableLayoutPanel2.Controls.Add(label1, 2, 0);
            tableLayoutPanel2.Controls.Add(label2, 3, 0);
            tableLayoutPanel2.Controls.Add(label3, 4, 0);
            tableLayoutPanel2.Location = new Point(47, 185);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(489, 56);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Location = new Point(391, 31);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(95, 23);
            textBoxQuantity.TabIndex = 6;
            textBoxQuantity.TextChanged += textBox3_TextChanged;
            // 
            // textBoxProduct
            // 
            textBoxProduct.Location = new Point(197, 31);
            textBoxProduct.Name = "textBoxProduct";
            textBoxProduct.Size = new Size(91, 23);
            textBoxProduct.TabIndex = 4;
            textBoxProduct.TextChanged += textBox1_TextChanged;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(294, 31);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(91, 23);
            textBoxPrice.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(197, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 7;
            label1.Text = "产品名称";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(294, 0);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 8;
            label2.Text = "价格";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(391, 0);
            label3.Name = "label3";
            label3.Size = new Size(32, 17);
            label3.TabIndex = 9;
            label3.Text = "数量";
            // 
            // OrderEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(buttonDeleteDetails);
            Controls.Add(buttonAddDetail);
            Controls.Add(dataGridViewOrderDetails);
            Controls.Add(tableLayoutPanel2);
            Name = "OrderEditForm";
            Text = "OrderEditForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderDetails).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxOrderId;
        private Label labelOrderId;
        private Label labelCustomer;
        private TextBox textBoxCustomer;
        public DataGridView dataGridViewOrderDetails;
        private Button buttonAddDetail;
        private Button buttonDeleteDetails;
        private Button buttonSave;
        private Button buttonCancel;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBoxProduct;
        private TextBox textBoxPrice;
        private TextBox textBoxQuantity;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}