using System.ComponentModel;

namespace SourceCode
{
    partial class frmAdmin
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
                new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpCreateUser = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.chkAdmin = new System.Windows.Forms.CheckBox();
            this.tpShowUsers = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvShowUsers = new System.Windows.Forms.DataGridView();
            this.grpDeleteUser = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.nudUserID = new System.Windows.Forms.NumericUpDown();
            this.lblUserID = new System.Windows.Forms.Label();
            this.tpBusiness = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.grpDeleteBusiness = new System.Windows.Forms.GroupBox();
            this.btnDeleteBusiness = new System.Windows.Forms.Button();
            this.cmbBusiness = new System.Windows.Forms.ComboBox();
            this.grpCreateBusiness = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCreateBusiness = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBusinessName = new System.Windows.Forms.TextBox();
            this.txtBusinessDescription = new System.Windows.Forms.RichTextBox();
            this.tpProduct = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbDeleteProductBusiness = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.cmbProductBusiness = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.tpOrders = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvShowOrders = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.tpGraphic = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpCreateUser.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.tpShowUsers.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvShowUsers)).BeginInit();
            this.grpDeleteUser.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.nudUserID)).BeginInit();
            this.tpBusiness.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.grpDeleteBusiness.SuspendLayout();
            this.grpCreateBusiness.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tpProduct.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tpOrders.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvShowOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpCreateUser);
            this.tabControl1.Controls.Add(this.tpShowUsers);
            this.tabControl1.Controls.Add(this.tpBusiness);
            this.tabControl1.Controls.Add(this.tpProduct);
            this.tabControl1.Controls.Add(this.tpOrders);
            this.tabControl1.Controls.Add(this.tpGraphic);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(701, 712);
            this.tabControl1.TabIndex = 0;
            // 
            // tpCreateUser
            // 
            this.tpCreateUser.Controls.Add(this.tableLayoutPanel1);
            this.tpCreateUser.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tpCreateUser.Location = new System.Drawing.Point(4, 29);
            this.tpCreateUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpCreateUser.Name = "tpCreateUser";
            this.tpCreateUser.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpCreateUser.Size = new System.Drawing.Size(693, 679);
            this.tpCreateUser.TabIndex = 0;
            this.tpCreateUser.Text = "Crear usuario";
            this.tpCreateUser.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.14019F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.102804F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.75701F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 217F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnCreateUser, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtPassword, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtFullName, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtUsername, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.chkAdmin, 3, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.09705F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.90295F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(687, 675);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::SourceCode.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(248, 48);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(3, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 90);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre completo :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(3, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 89);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(3, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 82);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contraseña : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateUser.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (37)))), ((int) (((byte) (103)))));
            this.btnCreateUser.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnCreateUser.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (227)))),
                ((int) (((byte) (238)))), ((int) (((byte) (211)))));
            this.btnCreateUser.Location = new System.Drawing.Point(248, 534);
            this.btnCreateUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(177, 62);
            this.btnCreateUser.TabIndex = 9;
            this.btnCreateUser.Text = "Crear usuario";
            this.btnCreateUser.UseVisualStyleBackColor = false;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPassword.Location = new System.Drawing.Point(431, 445);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(211, 32);
            this.txtPassword.TabIndex = 7;
            // 
            // txtFullName
            // 
            this.txtFullName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtFullName.Location = new System.Drawing.Point(431, 274);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(211, 32);
            this.txtFullName.TabIndex = 5;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUsername.Location = new System.Drawing.Point(431, 363);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(211, 32);
            this.txtUsername.TabIndex = 6;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // chkAdmin
            // 
            this.chkAdmin.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (37)))),
                ((int) (((byte) (103)))));
            this.chkAdmin.Location = new System.Drawing.Point(431, 481);
            this.chkAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkAdmin.Size = new System.Drawing.Size(154, 25);
            this.chkAdmin.TabIndex = 8;
            this.chkAdmin.Text = "Administrador";
            this.chkAdmin.UseVisualStyleBackColor = true;
            // 
            // tpShowUsers
            // 
            this.tpShowUsers.Controls.Add(this.tableLayoutPanel2);
            this.tpShowUsers.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tpShowUsers.Location = new System.Drawing.Point(4, 25);
            this.tpShowUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpShowUsers.Name = "tpShowUsers";
            this.tpShowUsers.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpShowUsers.Size = new System.Drawing.Size(693, 683);
            this.tpShowUsers.TabIndex = 1;
            this.tpShowUsers.Text = "Usuarios registrados";
            this.tpShowUsers.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.dgvShowUsers, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.grpDeleteUser, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(687, 671);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dgvShowUsers
            // 
            this.dgvShowUsers.AllowUserToAddRows = false;
            this.dgvShowUsers.AllowUserToDeleteRows = false;
            this.dgvShowUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int) (((byte) (97)))),
                ((int) (((byte) (62)))), ((int) (((byte) (142)))));
            this.dgvShowUsers.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShowUsers.Location = new System.Drawing.Point(3, 2);
            this.dgvShowUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvShowUsers.Name = "dgvShowUsers";
            this.dgvShowUsers.ReadOnly = true;
            this.dgvShowUsers.RowHeadersVisible = false;
            this.dgvShowUsers.RowTemplate.Height = 24;
            this.dgvShowUsers.Size = new System.Drawing.Size(681, 475);
            this.dgvShowUsers.TabIndex = 0;
            // 
            // grpDeleteUser
            // 
            this.grpDeleteUser.Controls.Add(this.tableLayoutPanel3);
            this.grpDeleteUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDeleteUser.Location = new System.Drawing.Point(3, 481);
            this.grpDeleteUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDeleteUser.Name = "grpDeleteUser";
            this.grpDeleteUser.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDeleteUser.Size = new System.Drawing.Size(681, 188);
            this.grpDeleteUser.TabIndex = 1;
            this.grpDeleteUser.TabStop = false;
            this.grpDeleteUser.Text = "Eliminar usuario";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel3.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel3.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel3.Controls.Add(this.btnDeleteUser, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.nudUserID, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblUserID, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 42);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(675, 142);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (37)))), ((int) (((byte) (103)))));
            this.btnDeleteUser.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnDeleteUser.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (227)))),
                ((int) (((byte) (238)))), ((int) (((byte) (211)))));
            this.btnDeleteUser.Location = new System.Drawing.Point(451, 40);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(221, 62);
            this.btnDeleteUser.TabIndex = 10;
            this.btnDeleteUser.Text = "Borrar usuario";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // nudUserID
            // 
            this.nudUserID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudUserID.Location = new System.Drawing.Point(273, 51);
            this.nudUserID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudUserID.Name = "nudUserID";
            this.nudUserID.Size = new System.Drawing.Size(126, 39);
            this.nudUserID.TabIndex = 0;
            // 
            // lblUserID
            // 
            this.lblUserID.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserID.Location = new System.Drawing.Point(3, 55);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(218, 32);
            this.lblUserID.TabIndex = 2;
            this.lblUserID.Text = "Ingrese ID : ";
            // 
            // tpBusiness
            // 
            this.tpBusiness.Controls.Add(this.tableLayoutPanel4);
            this.tpBusiness.Location = new System.Drawing.Point(4, 25);
            this.tpBusiness.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpBusiness.Name = "tpBusiness";
            this.tpBusiness.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpBusiness.Size = new System.Drawing.Size(693, 683);
            this.tpBusiness.TabIndex = 2;
            this.tpBusiness.Text = "Negocios";
            this.tpBusiness.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.grpDeleteBusiness, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.grpCreateBusiness, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel4.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(687, 679);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // grpDeleteBusiness
            // 
            this.grpDeleteBusiness.Controls.Add(this.btnDeleteBusiness);
            this.grpDeleteBusiness.Controls.Add(this.cmbBusiness);
            this.grpDeleteBusiness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDeleteBusiness.Location = new System.Drawing.Point(3, 511);
            this.grpDeleteBusiness.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDeleteBusiness.Name = "grpDeleteBusiness";
            this.grpDeleteBusiness.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDeleteBusiness.Size = new System.Drawing.Size(681, 166);
            this.grpDeleteBusiness.TabIndex = 1;
            this.grpDeleteBusiness.TabStop = false;
            this.grpDeleteBusiness.Text = "Borrar negocio";
            // 
            // btnDeleteBusiness
            // 
            this.btnDeleteBusiness.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteBusiness.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (37)))), ((int) (((byte) (103)))));
            this.btnDeleteBusiness.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnDeleteBusiness.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (227)))),
                ((int) (((byte) (238)))), ((int) (((byte) (211)))));
            this.btnDeleteBusiness.Location = new System.Drawing.Point(452, 52);
            this.btnDeleteBusiness.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteBusiness.Name = "btnDeleteBusiness";
            this.btnDeleteBusiness.Size = new System.Drawing.Size(184, 62);
            this.btnDeleteBusiness.TabIndex = 12;
            this.btnDeleteBusiness.Text = "Borrar negocio";
            this.btnDeleteBusiness.UseVisualStyleBackColor = false;
            this.btnDeleteBusiness.Click += new System.EventHandler(this.btnDeleteBusiness_Click);
            // 
            // cmbBusiness
            // 
            this.cmbBusiness.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cmbBusiness.FormattingEnabled = true;
            this.cmbBusiness.Location = new System.Drawing.Point(43, 72);
            this.cmbBusiness.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBusiness.Name = "cmbBusiness";
            this.cmbBusiness.Size = new System.Drawing.Size(334, 39);
            this.cmbBusiness.TabIndex = 0;
            // 
            // grpCreateBusiness
            // 
            this.grpCreateBusiness.Controls.Add(this.tableLayoutPanel5);
            this.grpCreateBusiness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCreateBusiness.Location = new System.Drawing.Point(3, 2);
            this.grpCreateBusiness.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCreateBusiness.Name = "grpCreateBusiness";
            this.grpCreateBusiness.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCreateBusiness.Size = new System.Drawing.Size(681, 505);
            this.grpCreateBusiness.TabIndex = 0;
            this.grpCreateBusiness.TabStop = false;
            this.grpCreateBusiness.Text = "Crear negocio";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.btnCreateBusiness, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.txtBusinessName, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.txtBusinessDescription, 0, 3);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 5;
            this.tableLayoutPanel5.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.88608F));
            this.tableLayoutPanel5.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.11392F));
            this.tableLayoutPanel5.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel5.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 178F));
            this.tableLayoutPanel5.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(675, 481);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // btnCreateBusiness
            // 
            this.btnCreateBusiness.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateBusiness.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (37)))), ((int) (((byte) (103)))));
            this.btnCreateBusiness.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnCreateBusiness.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (227)))),
                ((int) (((byte) (238)))), ((int) (((byte) (211)))));
            this.btnCreateBusiness.Location = new System.Drawing.Point(3, 412);
            this.btnCreateBusiness.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateBusiness.Name = "btnCreateBusiness";
            this.btnCreateBusiness.Size = new System.Drawing.Size(669, 62);
            this.btnCreateBusiness.TabIndex = 11;
            this.btnCreateBusiness.Text = "Agregar negocio";
            this.btnCreateBusiness.UseVisualStyleBackColor = false;
            this.btnCreateBusiness.Click += new System.EventHandler(this.btnCreateBusiness_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(171, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(333, 39);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nombre";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(171, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(333, 39);
            this.label5.TabIndex = 13;
            this.label5.Text = "Descripción";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtBusinessName
            // 
            this.txtBusinessName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBusinessName.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtBusinessName.Location = new System.Drawing.Point(224, 122);
            this.txtBusinessName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBusinessName.Name = "txtBusinessName";
            this.txtBusinessName.Size = new System.Drawing.Size(226, 39);
            this.txtBusinessName.TabIndex = 14;
            // 
            // txtBusinessDescription
            // 
            this.txtBusinessDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBusinessDescription.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtBusinessDescription.Location = new System.Drawing.Point(170, 230);
            this.txtBusinessDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBusinessDescription.Name = "txtBusinessDescription";
            this.txtBusinessDescription.Size = new System.Drawing.Size(335, 122);
            this.txtBusinessDescription.TabIndex = 15;
            this.txtBusinessDescription.Text = "";
            // 
            // tpProduct
            // 
            this.tpProduct.Controls.Add(this.tableLayoutPanel6);
            this.tpProduct.Location = new System.Drawing.Point(4, 25);
            this.tpProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpProduct.Name = "tpProduct";
            this.tpProduct.Size = new System.Drawing.Size(693, 683);
            this.tpProduct.TabIndex = 3;
            this.tpProduct.Text = "Productos";
            this.tpProduct.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel8, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(693, 683);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.81081F));
            this.tableLayoutPanel8.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.18919F));
            this.tableLayoutPanel8.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 333F));
            this.tableLayoutPanel8.Controls.Add(this.cmbDeleteProductBusiness, 2, 2);
            this.tableLayoutPanel8.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.label9, 2, 1);
            this.tableLayoutPanel8.Controls.Add(this.btnDeleteProduct, 0, 4);
            this.tableLayoutPanel8.Controls.Add(this.cmbProduct, 0, 2);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 343);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 5;
            this.tableLayoutPanel8.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.70588F));
            this.tableLayoutPanel8.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.29412F));
            this.tableLayoutPanel8.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel8.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel8.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel8.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(687, 338);
            this.tableLayoutPanel8.TabIndex = 1;
            // 
            // cmbDeleteProductBusiness
            // 
            this.cmbDeleteProductBusiness.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbDeleteProductBusiness.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbDeleteProductBusiness.FormattingEnabled = true;
            this.cmbDeleteProductBusiness.Location = new System.Drawing.Point(397, 132);
            this.cmbDeleteProductBusiness.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDeleteProductBusiness.Name = "cmbDeleteProductBusiness";
            this.cmbDeleteProductBusiness.Size = new System.Drawing.Size(246, 36);
            this.cmbDeleteProductBusiness.TabIndex = 13;
            this.cmbDeleteProductBusiness.SelectedIndexChanged +=
                new System.EventHandler(this.cmbDeleteProductBusiness_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.Location = new System.Drawing.Point(3, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(244, 42);
            this.label8.TabIndex = 0;
            this.label8.Text = "Producto";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label9
            // 
            this.label9.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.Location = new System.Drawing.Point(356, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(328, 42);
            this.label9.TabIndex = 5;
            this.label9.Text = "Negocio";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (37)))), ((int) (((byte) (103)))));
            this.tableLayoutPanel8.SetColumnSpan(this.btnDeleteProduct, 3);
            this.btnDeleteProduct.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (227)))),
                ((int) (((byte) (238)))), ((int) (((byte) (211)))));
            this.btnDeleteProduct.Location = new System.Drawing.Point(3, 284);
            this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(681, 51);
            this.btnDeleteProduct.TabIndex = 12;
            this.btnDeleteProduct.Text = "Borrar producto";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // cmbProduct
            // 
            this.cmbProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbProduct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(3, 132);
            this.cmbProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(244, 36);
            this.cmbProduct.TabIndex = 3;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.81081F));
            this.tableLayoutPanel7.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.18919F));
            this.tableLayoutPanel7.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 333F));
            this.tableLayoutPanel7.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.txtProductName, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.cmbProductBusiness, 2, 2);
            this.tableLayoutPanel7.Controls.Add(this.label7, 2, 1);
            this.tableLayoutPanel7.Controls.Add(this.btnAddProduct, 0, 4);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 5;
            this.tableLayoutPanel7.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.70588F));
            this.tableLayoutPanel7.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.29412F));
            this.tableLayoutPanel7.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel7.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel7.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(687, 337);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(3, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 42);
            this.label6.TabIndex = 0;
            this.label6.Text = "Producto";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtProductName
            // 
            this.txtProductName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtProductName.Location = new System.Drawing.Point(19, 131);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(212, 34);
            this.txtProductName.TabIndex = 2;
            // 
            // cmbProductBusiness
            // 
            this.cmbProductBusiness.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbProductBusiness.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbProductBusiness.FormattingEnabled = true;
            this.cmbProductBusiness.Location = new System.Drawing.Point(397, 131);
            this.cmbProductBusiness.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProductBusiness.Name = "cmbProductBusiness";
            this.cmbProductBusiness.Size = new System.Drawing.Size(246, 36);
            this.cmbProductBusiness.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.Location = new System.Drawing.Point(356, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(328, 42);
            this.label7.TabIndex = 5;
            this.label7.Text = "Negocio";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (37)))), ((int) (((byte) (103)))));
            this.tableLayoutPanel7.SetColumnSpan(this.btnAddProduct, 3);
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnAddProduct.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (227)))),
                ((int) (((byte) (238)))), ((int) (((byte) (211)))));
            this.btnAddProduct.Location = new System.Drawing.Point(3, 283);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(681, 51);
            this.btnAddProduct.TabIndex = 12;
            this.btnAddProduct.Text = "Agregar producto";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // tpOrders
            // 
            this.tpOrders.Controls.Add(this.tableLayoutPanel9);
            this.tpOrders.Location = new System.Drawing.Point(4, 25);
            this.tpOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpOrders.Name = "tpOrders";
            this.tpOrders.Size = new System.Drawing.Size(693, 683);
            this.tpOrders.TabIndex = 4;
            this.tpOrders.Text = "Órdenes";
            this.tpOrders.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Controls.Add(this.dgvShowOrders, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.07658F));
            this.tableLayoutPanel9.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.92342F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(693, 683);
            this.tableLayoutPanel9.TabIndex = 0;
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
            this.tableLayoutPanel9.SetColumnSpan(this.dgvShowOrders, 3);
            this.dgvShowOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShowOrders.Location = new System.Drawing.Point(3, 84);
            this.dgvShowOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvShowOrders.Name = "dgvShowOrders";
            this.dgvShowOrders.ReadOnly = true;
            this.dgvShowOrders.RowHeadersVisible = false;
            this.dgvShowOrders.RowTemplate.Height = 24;
            this.dgvShowOrders.Size = new System.Drawing.Size(687, 597);
            this.dgvShowOrders.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(687, 82);
            this.label10.TabIndex = 0;
            this.label10.Text = "Órdenes";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpGraphic
            // 
            this.tpGraphic.Location = new System.Drawing.Point(4, 25);
            this.tpGraphic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpGraphic.Name = "tpGraphic";
            this.tpGraphic.Size = new System.Drawing.Size(693, 683);
            this.tpGraphic.TabIndex = 6;
            this.tpGraphic.Text = "Negocio por demanda";
            this.tpGraphic.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel10.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(686, 81);
            this.label11.TabIndex = 0;
            this.label11.Text = "Órdenes";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 712);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAdmin";
            this.Text = "Hugo Administrador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdmin_FormClosing);
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpCreateUser.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.tpShowUsers.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvShowUsers)).EndInit();
            this.grpDeleteUser.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.nudUserID)).EndInit();
            this.tpBusiness.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.grpDeleteBusiness.ResumeLayout(false);
            this.grpCreateBusiness.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tpProduct.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tpOrders.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvShowOrders)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpShowUsers;
        private System.Windows.Forms.TabPage tpCreateUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkAdmin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox grpDeleteUser;
        private System.Windows.Forms.DataGridView dgvShowUsers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.NumericUpDown nudUserID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TabPage tpBusiness;
        private System.Windows.Forms.GroupBox grpCreateBusiness;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox grpDeleteBusiness;
        private System.Windows.Forms.Button btnCreateBusiness;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtBusinessDescription;
        private System.Windows.Forms.TextBox txtBusinessName;
        private System.Windows.Forms.ComboBox cmbBusiness;
        private System.Windows.Forms.Button btnDeleteBusiness;
        private System.Windows.Forms.TabPage tpProduct;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbDeleteProductBusiness;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.ComboBox cmbProductBusiness;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TabPage tpGraphic;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TabPage tpOrders;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.DataGridView dgvShowOrders;
    }
}