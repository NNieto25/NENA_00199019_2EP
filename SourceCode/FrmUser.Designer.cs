using System.ComponentModel;

namespace SourceCode
{
    partial class FrmUser
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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(FrmUser));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpOrder = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvShowOrders = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.cmbBusiness = new System.Windows.Forms.ComboBox();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.cmbAddress = new System.Windows.Forms.ComboBox();
            this.nudOrderID = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tpAddAddress = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddAddress = new System.Windows.Forms.Button();
            this.dgvShowAddress = new System.Windows.Forms.DataGridView();
            this.txtNewAddress = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUpdateAddress = new System.Windows.Forms.TextBox();
            this.nudAddressID = new System.Windows.Forms.NumericUpDown();
            this.btnDeleteAddress = new System.Windows.Forms.Button();
            this.btnUpdateAddress = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpOrder.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvShowOrders)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.nudOrderID)).BeginInit();
            this.tpAddAddress.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvShowAddress)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.nudAddressID)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpOrder);
            this.tabControl1.Controls.Add(this.tpAddAddress);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(701, 712);
            this.tabControl1.TabIndex = 0;
            // 
            // tpOrder
            // 
            this.tpOrder.Controls.Add(this.tableLayoutPanel2);
            this.tpOrder.Location = new System.Drawing.Point(4, 29);
            this.tpOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpOrder.Name = "tpOrder";
            this.tpOrder.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpOrder.Size = new System.Drawing.Size(693, 679);
            this.tpOrder.TabIndex = 0;
            this.tpOrder.Text = "Realizar orden";
            this.tpOrder.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.49501F));
            this.tableLayoutPanel2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.50499F));
            this.tableLayoutPanel2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 244F));
            this.tableLayoutPanel2.Controls.Add(this.dgvShowOrders, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDeleteOrder, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.nudOrderID, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.29542F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.70458F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(687, 675);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dgvShowOrders
            // 
            this.dgvShowOrders.AllowUserToAddRows = false;
            this.dgvShowOrders.AllowUserToDeleteRows = false;
            this.dgvShowOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int) (((byte) (97)))),
                ((int) (((byte) (62)))), ((int) (((byte) (142)))));
            this.dgvShowOrders.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel2.SetColumnSpan(this.dgvShowOrders, 3);
            this.dgvShowOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShowOrders.Location = new System.Drawing.Point(3, 204);
            this.dgvShowOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvShowOrders.Name = "dgvShowOrders";
            this.dgvShowOrders.ReadOnly = true;
            this.dgvShowOrders.RowHeadersVisible = false;
            this.dgvShowOrders.RowTemplate.Height = 24;
            this.dgvShowOrders.Size = new System.Drawing.Size(681, 383);
            this.dgvShowOrders.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.groupBox2, 2);
            this.groupBox2.Controls.Add(this.cmbProducts);
            this.groupBox2.Controls.Add(this.cmbBusiness);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(436, 198);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Compra";
            // 
            // cmbProducts
            // 
            this.cmbProducts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbProducts.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(95, 119);
            this.cmbProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(246, 36);
            this.cmbProducts.TabIndex = 5;
            this.cmbProducts.Text = "Selecciona un producto";
            // 
            // cmbBusiness
            // 
            this.cmbBusiness.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbBusiness.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbBusiness.FormattingEnabled = true;
            this.cmbBusiness.Location = new System.Drawing.Point(95, 25);
            this.cmbBusiness.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBusiness.Name = "cmbBusiness";
            this.cmbBusiness.Size = new System.Drawing.Size(246, 36);
            this.cmbBusiness.TabIndex = 4;
            this.cmbBusiness.Text = "Selecciona una empresa";
            this.cmbBusiness.SelectedIndexChanged += new System.EventHandler(this.cmbBusiness_SelectedIndexChanged);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteOrder.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (37)))), ((int) (((byte) (103)))));
            this.btnDeleteOrder.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnDeleteOrder.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (227)))),
                ((int) (((byte) (238)))), ((int) (((byte) (211)))));
            this.btnDeleteOrder.Location = new System.Drawing.Point(473, 601);
            this.btnDeleteOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(183, 62);
            this.btnDeleteOrder.TabIndex = 18;
            this.btnDeleteOrder.Text = "Eliminar orden";
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnOrder);
            this.groupBox3.Controls.Add(this.cmbAddress);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(445, 2);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(239, 198);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Envío";
            // 
            // btnOrder
            // 
            this.btnOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (37)))),
                ((int) (((byte) (103)))));
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnOrder.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (227)))), ((int) (((byte) (238)))),
                ((int) (((byte) (211)))));
            this.btnOrder.Location = new System.Drawing.Point(28, 107);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(161, 62);
            this.btnOrder.TabIndex = 13;
            this.btnOrder.Text = "Ordenar";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // cmbAddress
            // 
            this.cmbAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbAddress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbAddress.FormattingEnabled = true;
            this.cmbAddress.Location = new System.Drawing.Point(28, 25);
            this.cmbAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAddress.Name = "cmbAddress";
            this.cmbAddress.Size = new System.Drawing.Size(161, 36);
            this.cmbAddress.TabIndex = 4;
            this.cmbAddress.Text = "ID dirección";
            // 
            // nudOrderID
            // 
            this.nudOrderID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudOrderID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nudOrderID.Location = new System.Drawing.Point(294, 615);
            this.nudOrderID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudOrderID.Name = "nudOrderID";
            this.nudOrderID.Size = new System.Drawing.Size(86, 34);
            this.nudOrderID.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(3, 589);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 86);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ingrese un ID de orden";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpAddAddress
            // 
            this.tpAddAddress.Controls.Add(this.tableLayoutPanel1);
            this.tpAddAddress.Location = new System.Drawing.Point(4, 25);
            this.tpAddAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpAddAddress.Name = "tpAddAddress";
            this.tpAddAddress.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpAddAddress.Size = new System.Drawing.Size(693, 683);
            this.tpAddAddress.TabIndex = 1;
            this.tpAddAddress.Text = "Direcciones";
            this.tpAddAddress.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.13065F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.86935F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.tableLayoutPanel1.Controls.Add(this.btnAddAddress, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvShowAddress, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtNewAddress, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.92793F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.07207F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(687, 679);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnAddAddress
            // 
            this.btnAddAddress.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (37)))), ((int) (((byte) (103)))));
            this.btnAddAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddAddress.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnAddAddress.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (227)))),
                ((int) (((byte) (238)))), ((int) (((byte) (211)))));
            this.btnAddAddress.Location = new System.Drawing.Point(504, 2);
            this.btnAddAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddAddress.Name = "btnAddAddress";
            this.btnAddAddress.Size = new System.Drawing.Size(180, 59);
            this.btnAddAddress.TabIndex = 13;
            this.btnAddAddress.Text = "Agregar";
            this.btnAddAddress.UseVisualStyleBackColor = false;
            this.btnAddAddress.Click += new System.EventHandler(this.btnAddAddress_Click);
            // 
            // dgvShowAddress
            // 
            this.dgvShowAddress.AllowUserToAddRows = false;
            this.dgvShowAddress.AllowUserToDeleteRows = false;
            this.dgvShowAddress.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowAddress.BackgroundColor = System.Drawing.Color.FromArgb(((int) (((byte) (97)))),
                ((int) (((byte) (62)))), ((int) (((byte) (142)))));
            this.dgvShowAddress.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvShowAddress, 3);
            this.dgvShowAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShowAddress.Location = new System.Drawing.Point(3, 230);
            this.dgvShowAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvShowAddress.Name = "dgvShowAddress";
            this.dgvShowAddress.ReadOnly = true;
            this.dgvShowAddress.RowHeadersVisible = false;
            this.dgvShowAddress.RowTemplate.Height = 24;
            this.dgvShowAddress.Size = new System.Drawing.Size(681, 447);
            this.dgvShowAddress.TabIndex = 1;
            // 
            // txtNewAddress
            // 
            this.txtNewAddress.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtNewAddress, 2);
            this.txtNewAddress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNewAddress.Location = new System.Drawing.Point(3, 14);
            this.txtNewAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewAddress.Name = "txtNewAddress";
            this.txtNewAddress.Size = new System.Drawing.Size(495, 34);
            this.txtNewAddress.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 3);
            this.groupBox1.Controls.Add(this.txtUpdateAddress);
            this.groupBox1.Controls.Add(this.nudAddressID);
            this.groupBox1.Controls.Add(this.btnDeleteAddress);
            this.groupBox1.Controls.Add(this.btnUpdateAddress);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 65);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(681, 161);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificar";
            // 
            // txtUpdateAddress
            // 
            this.txtUpdateAddress.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.txtUpdateAddress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUpdateAddress.Location = new System.Drawing.Point(98, 67);
            this.txtUpdateAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUpdateAddress.Name = "txtUpdateAddress";
            this.txtUpdateAddress.Size = new System.Drawing.Size(369, 34);
            this.txtUpdateAddress.TabIndex = 17;
            // 
            // nudAddressID
            // 
            this.nudAddressID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nudAddressID.Location = new System.Drawing.Point(6, 65);
            this.nudAddressID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudAddressID.Name = "nudAddressID";
            this.nudAddressID.Size = new System.Drawing.Size(86, 34);
            this.nudAddressID.TabIndex = 16;
            this.nudAddressID.ValueChanged += new System.EventHandler(this.nudAddressID_ValueChanged);
            // 
            // btnDeleteAddress
            // 
            this.btnDeleteAddress.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (37)))), ((int) (((byte) (103)))));
            this.btnDeleteAddress.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnDeleteAddress.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (227)))),
                ((int) (((byte) (238)))), ((int) (((byte) (211)))));
            this.btnDeleteAddress.Location = new System.Drawing.Point(518, 82);
            this.btnDeleteAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteAddress.Name = "btnDeleteAddress";
            this.btnDeleteAddress.Size = new System.Drawing.Size(162, 58);
            this.btnDeleteAddress.TabIndex = 15;
            this.btnDeleteAddress.Text = "Eliminar";
            this.btnDeleteAddress.UseVisualStyleBackColor = false;
            this.btnDeleteAddress.Click += new System.EventHandler(this.btnDeleteAddress_Click);
            // 
            // btnUpdateAddress
            // 
            this.btnUpdateAddress.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (37)))), ((int) (((byte) (103)))));
            this.btnUpdateAddress.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnUpdateAddress.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (227)))),
                ((int) (((byte) (238)))), ((int) (((byte) (211)))));
            this.btnUpdateAddress.Location = new System.Drawing.Point(518, 10);
            this.btnUpdateAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateAddress.Name = "btnUpdateAddress";
            this.btnUpdateAddress.Size = new System.Drawing.Size(162, 58);
            this.btnUpdateAddress.TabIndex = 14;
            this.btnUpdateAddress.Text = "Modificar";
            this.btnUpdateAddress.UseVisualStyleBackColor = false;
            this.btnUpdateAddress.Click += new System.EventHandler(this.btnUpdateAddress_Click);
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 712);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmUser";
            this.Text = "Hugo Usuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmUser_FormClosing);
            this.Load += new System.EventHandler(this.FrmUser_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpOrder.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvShowOrders)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.nudOrderID)).EndInit();
            this.tpAddAddress.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvShowAddress)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.nudAddressID)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpAddAddress;
        private System.Windows.Forms.TabPage tpOrder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudAddressID;
        private System.Windows.Forms.TextBox txtUpdateAddress;
        private System.Windows.Forms.Button btnUpdateAddress;
        private System.Windows.Forms.Button btnDeleteAddress;
        private System.Windows.Forms.Button btnAddAddress;
        private System.Windows.Forms.TextBox txtNewAddress;
        private System.Windows.Forms.DataGridView dgvShowAddress;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudOrderID;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.DataGridView dgvShowOrders;
        private System.Windows.Forms.ComboBox cmbBusiness;
        private System.Windows.Forms.ComboBox cmbProducts;
        private System.Windows.Forms.ComboBox cmbAddress;
    }
}