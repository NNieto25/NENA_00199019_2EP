using System;
using System.Data;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using PieChart = LiveCharts.WinForms.PieChart;

namespace SourceCode
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text.Equals("")|| txtUsername.Text.Equals("")||txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Debe rellenar los campos", "Hugo", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    User user = new User();
                    user.Fullname = txtFullName.Text;
                    user.Username = txtUsername.Text;
                    user.Password = txtPassword.Text;
                    user.UserType = chkAdmin.Checked;
                    UserDAO.CreateUser(user);
                    UpdateTable();
                    //Limpiando los controles
                    txtPassword.Clear();
                    txtUsername.Clear();
                    txtFullName.Clear();
                    chkAdmin.Checked = false;
                    MessageBox.Show("El usuario ha sido creado con éxito.", "Hugo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ha ocurrido un error.", "Hugo", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            txtPassword.Text = txtUsername.Text;
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            UpdateTable();
            UpdateCmbBusiness();
            UpdatedgvShowOrders();
            //Gráfico de pastel
            PieChart pieGraphic = new PieChart();
            Controls.Add(pieGraphic);
            pieGraphic.Parent = tabControl1.TabPages[5];
            pieGraphic.Top = 10;
            pieGraphic.Left = 10;
            pieGraphic.Width = pieGraphic.Parent.Width - 20;
            pieGraphic.Height = pieGraphic.Parent.Height - 20;
            pieGraphic.Series = null;
            SeriesCollection collection = new SeriesCollection();
            DataTable dataTable = ProductDAO.GetSumByProduct();
            foreach (DataRow row in dataTable.Rows)
            {
                collection.Add(new PieSeries
                {
                    Title = row[0].ToString(), Values = new ChartValues<int> {Convert.ToInt32(row[1].ToString())},
                    DataLabels = true
                });
            }

            pieGraphic.Series = collection;
            pieGraphic.LegendLocation = LegendLocation.Bottom;
        }

        private void UpdatedgvShowOrders()
        {
            dgvShowOrders.DataSource = null;
            dgvShowOrders.DataSource = OrderDAO.GetOrderTable();
        }

        private void UpdateCmbBusiness()
        {
            //ComboBox de pestaña negocios
            cmbBusiness.DataSource = null;
            cmbBusiness.ValueMember = "IdBusiness";
            cmbBusiness.DisplayMember = "Name";
            cmbBusiness.DataSource = BusinessDAO.GetBusiness();
            //ComboBox de agregar producto
            cmbProductBusiness.DataSource = null;
            cmbProductBusiness.ValueMember = "IdBusiness";
            cmbProductBusiness.DisplayMember = "Name";
            cmbProductBusiness.DataSource = BusinessDAO.GetBusiness();
            //ComboBox de borrar producto
            cmbDeleteProductBusiness.DataSource = null;
            cmbDeleteProductBusiness.ValueMember = "IdBusiness";
            cmbDeleteProductBusiness.DisplayMember = "Name";
            cmbDeleteProductBusiness.DataSource = BusinessDAO.GetBusiness();
            UpdateCmbProduct(cmbDeleteProductBusiness.Items.Count>0?
                ((Business)cmbDeleteProductBusiness.SelectedItem).IdBusiness:0);
        }

        private void UpdateCmbProduct(int idBusiness)
        {
            cmbProduct.DataSource = null;
            cmbProduct.ValueMember = "IdProduct";
            cmbProduct.DisplayMember = "Name";
            cmbProduct.DataSource = ProductDAO.GetProducts(idBusiness);
        }

        private void UpdateTable()
        {
            dgvShowUsers.DataSource = null;
            dgvShowUsers.DataSource = UserDAO.GetUsersTable();
            nudUserID.Maximum = Convert.ToInt32(dgvShowUsers.Rows[dgvShowUsers.RowCount - 1].Cells[0].Value.ToString());
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (nudUserID.Value == 0)
            {
                MessageBox.Show("Debe ingresar un ID de usuario.", "Hugo", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (MessageBox.Show($"¿Desea borrar al usuario con ID = {nudUserID.Value}?", "Hugo", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                    {
                        UserDAO.DeleteUser((int)nudUserID.Value);
                        UpdateTable();
                        MessageBox.Show("El usuario ha sido borrado con éxito.", "Hugo", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);    
                    }
                    else
                    {
                        MessageBox.Show("La operación ha sido abortada.", "Hugo", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ha ocurrido un error.", "Hugo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
            }
            
        }

        private void btnCreateBusiness_Click(object sender, EventArgs e)
        {
            if (txtBusinessName.Text.Equals("")|| txtBusinessDescription.Text.Equals(""))
            {
                MessageBox.Show("Debe llenar los campos.", "Hugo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    Business business = new Business();
                    business.Name = txtBusinessName.Text;
                    business.Description = txtBusinessDescription.Text;
                    BusinessDAO.CreateBusiness(business);
                    MessageBox.Show("El negocio ha sido ingresado con éxito.", "Hugo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateCmbBusiness();
                }
                catch (Exception exception)
                { 
                    MessageBox.Show("Ha ocurrido un error.", "Hugo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            txtBusinessDescription.Clear();
            txtBusinessName.Clear();
        }

        private void btnDeleteBusiness_Click(object sender, EventArgs e)
        {
            if (cmbBusiness.Items.Count ==0)
            {
                MessageBox.Show("Actualmente no hay negocios registrados.", "Hugo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
            else
            {
                try
                {
                    var business = (Business) cmbBusiness.SelectedItem;
                    if (MessageBox.Show($"¿Desea borrar el negocio {business.Name}?", "Hugo", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                    {
                        BusinessDAO.DeleteBusiness(business);
                        UpdateCmbBusiness();
                        MessageBox.Show($"{business.Name} ha sido eliminado con éxito.", "Hugo", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);    
                    }
                    else
                    {
                        MessageBox.Show("La operación ha sido abortada.", "Hugo", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ha ocurrido un error.", "Hugo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
            }
            
              
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text.Equals("") || cmbProductBusiness.Items.Count == 0)
            {
                MessageBox.Show("Debe llenar los campos.", "Hugo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    Product product = new Product();
                    product.Name = txtProductName.Text;
                    product.IdBusiness = ((Business) cmbProductBusiness.SelectedItem).IdBusiness;
                    ProductDAO.CreateProduct(product);
                    MessageBox.Show("El producto ha sido ingresado con éxito.", "Hugo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateCmbProduct(((Business) cmbDeleteProductBusiness.SelectedItem).IdBusiness);
                }
                catch (Exception exception)
                { 
                    MessageBox.Show("Ha ocurrido un error." + exception.Message, "Hugo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            txtProductName.Clear();
        }

        private void cmbDeleteProductBusiness_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCmbProduct(((Business)cmbDeleteProductBusiness.SelectedItem).IdBusiness);
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (cmbDeleteProductBusiness.Items.Count==0 || cmbProduct.Items.Count == 0)
            {
                MessageBox.Show("Debe especificar un producto y un negocio.", "Hugo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
            else
            {
                try
                {
                    var business = (Business) cmbDeleteProductBusiness.SelectedItem;
                    var product = (Product) cmbProduct.SelectedItem;
                    if (MessageBox.Show($"¿Desea borrar el producto {product.Name}?", "Hugo", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                    {
                        ProductDAO.DeleteProduct(product, business.IdBusiness);
                        UpdateCmbProduct(business.IdBusiness);
                        MessageBox.Show($"{product.Name} ha sido eliminado con éxito.", "Hugo", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);    
                    }
                    else
                    {
                        MessageBox.Show("La operación ha sido abortada.", "Hugo", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ha ocurrido un error.", "Hugo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }  
            }

        }

        private void frmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}