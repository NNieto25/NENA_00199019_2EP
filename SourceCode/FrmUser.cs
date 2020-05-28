using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SourceCode
{
    public partial class FrmUser : Form
    {
        private User user;
        public FrmUser(User user)
        {
            this.user = user;
            InitializeComponent();
        }
        private void FrmUser_Load(object sender, EventArgs e)
        {
            UpdateTable();
            UpdateCmbBusiness();
            UpdatecmbProducts();
            UpdateCmbAddress();
            UpdateOrderTable();
        }

        private void UpdateCmbAddress()
        {
            cmbAddress.DataSource = null;
            cmbAddress.ValueMember = nameof(Address.IdAddress);
            cmbAddress.DisplayMember = nameof(Address.SAddress);
            cmbAddress.DataSource = AddressDAO.GetAddress(user.IdUser);
        }
        private void UpdatecmbProducts()
        {
            cmbProducts.DataSource = null;
            cmbProducts.DisplayMember = nameof(Product.Name);
            cmbProducts.ValueMember = nameof(Product.IdProduct);
            cmbProducts.DataSource = ProductDAO.GetProducts((int)cmbBusiness.SelectedValue);
        }

        private void UpdateCmbBusiness()
        {
            cmbBusiness.DataSource = null;
            cmbBusiness.ValueMember = nameof(Business.IdBusiness);
            cmbBusiness.DisplayMember = nameof(Business.Name);
            cmbBusiness.DataSource = BusinessDAO.GetBusiness();
        }
        

        private void UpdateTable()
        {
            dgvShowAddress.DataSource = null;
            dgvShowAddress.DataSource = AddressDAO.GetAddressTable(user.IdUser);
            nudAddressID.Maximum = dgvShowAddress.RowCount>0?Convert.ToInt32(
                dgvShowAddress.Rows[dgvShowAddress.RowCount - 1].Cells[0].Value.ToString()):0;
        }

        private void UpdateOrderTable()
        {
            dgvShowOrders.DataSource = null;
            dgvShowOrders.DataSource = OrderDAO.GetOrderTable(user.IdUser);
            nudOrderID.Maximum = dgvShowOrders.RowCount > 0 ? Convert.ToInt32(
                    dgvShowOrders.Rows[dgvShowOrders.RowCount - 1].Cells[0].Value.ToString()) : 0;
        }
        private void FrmUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            if (txtNewAddress.Text.Equals(""))
            {
                MessageBox.Show("Debe escribir una dirección.", "Hugo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Address address = new Address();
                    address.IdUser = user.IdUser;
                    address.SAddress = txtNewAddress.Text;
                    AddressDAO.CreateAddress(address);
                    UpdateTable();
                    UpdateCmbAddress();
                    MessageBox.Show("La dirección ha sido ingresada con éxito.", "Hugo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ha ocurrido un error.", "Hugo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void btnUpdateAddress_Click(object sender, EventArgs e)
        {
            if (txtUpdateAddress.Text.Equals("") || nudAddressID.Value == 0)
            {
                MessageBox.Show("Debe modificar una dirección existente.", "Hugo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Address address = new Address();
                    address.IdUser = user.IdUser;
                    address.IdAddress = (int) nudAddressID.Value;
                    address.SAddress = txtUpdateAddress.Text;
                    AddressDAO.UpdateAddress(address);
                    UpdateTable();
                    UpdateCmbAddress();
                    MessageBox.Show("La dirección ha sido modificada con éxito.", "Hugo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ha ocurrido un error.", "Hugo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void nudAddressID_ValueChanged(object sender, EventArgs e)
        {
           txtUpdateAddress.Text = AddressDAO.GetAddress((int)nudAddressID.Value,user.IdUser).SAddress;
        }

        private void btnDeleteAddress_Click(object sender, EventArgs e)
        {
            if (txtUpdateAddress.Text.Equals("")|| nudAddressID.Value == 0)
            {
                MessageBox.Show("Debe seleccionar una dirección. ", "Hugo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Address address = new Address();
                    address.IdAddress = Convert.ToInt32(nudAddressID.Value);
                    address.IdUser = user.IdUser;
                    address.SAddress = txtUpdateAddress.Text;
                    AddressDAO.DeleteAddress(address);
                    UpdateTable();
                    UpdateCmbAddress();    
                    MessageBox.Show("La dirección ha sido eliminada con éxito.", "Hugo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ha ocurrido un error.", "Hugo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void cmbBusiness_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatecmbProducts();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (cmbBusiness.Items.Count == 0 || cmbProducts.Items.Count == 0|| cmbAddress.Items.Count == 0)
            {
                MessageBox.Show("Faltan datos en su compra.", "Hugo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Order order = new Order();
                    order.IdProduct = (int)cmbProducts.SelectedValue;
                    order.IdAddress = (int) cmbAddress.SelectedValue;
                    order.CreateDate = DateTime.Now.ToLocalTime();
                    OrderDAO.CreateOrder(order);
                    MessageBox.Show("La orden ha sido realizada con éxito.", "Hugo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateOrderTable();
                    
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ha ocurrido un error. " + exception.Message, "Hugo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (nudOrderID.Value == 0)
            {
                MessageBox.Show("Debe seleccionar una orden", "Hugo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    OrderDAO.DeleteOrder(user.IdUser, (int)nudOrderID.Value);//Orden no le pertenece o no existe
                    MessageBox.Show("La orden ha sido eliminada con éxito.", "Hugo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateOrderTable();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ha ocurrido un error. " + exception.Message, "Hugo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}