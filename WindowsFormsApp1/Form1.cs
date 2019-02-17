using System;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panelFirstSearch.Location = new Point(this.Width/3,100);
        }

        private string idMarka = "", idModel = "", cmbSortSelectCategory = "";
        public string MySqlConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString;
        int id = 0, product_hp = 0, product_cubic = 0;
        string product_category = "", product_mark = "", product_model = "", product_name = "", product_engine = "", product_door = "", product_gearbox = "", product_typeCar = "", product_serialNumber = "", product_subcategory = "", cmbSubSortSelectCategory = "";

        private void Form1_Resize(object sender, EventArgs e)
        {
            panelFirstSearch.Location = new Point(this.Width / 3, 100);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reload_cmb();
        }

        private void btnGoToAddForm_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.Show();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            MySqlConnection dbConnection = new MySqlConnection(MySqlConnectionString);
            string querry = "";

            if (idMarka != "" && idModel != "" && cmbCategorySort.Text != "" && cmbSubCategorySort.Text != "")
            {
                querry = "SELECT `name`, `mark`, `model`, `doors`, `engines`, `hp`, `cubic`, `gearbox`, `typeCar`, `serialNumber`, `category`, `subCategory`, `id` FROM `products` WHERE `mark` = '" + idMarka + "' AND `model` = '" + idModel + "' AND `category`='" + cmbCategorySort.Text + "' AND `subCategory`='" + cmbSubCategorySort.Text + "' AND CONCAT(`name`, `mark`, `model`, `doors`, `engines`, `hp`, `cubic`, `gearbox`, `typeCar`, `serialNumber`, `category`, `subCategory`) LIKE '%" + searchProduct.Text + "%'";
            }
            else if (idMarka != "" && idModel != "" && cmbCategorySort.Text != "" && cmbSubCategorySort.Text == "")
            {
                querry = "SELECT `name`, `mark`, `model`, `doors`, `engines`, `hp`, `cubic`, `gearbox`, `typeCar`, `serialNumber`, `category`, `subCategory`, `id` FROM `products` WHERE `mark` = '" + idMarka + "' AND `model` = '" + idModel + "' AND `category`='" + cmbCategorySort.Text + "' AND CONCAT(`name`, `mark`, `model`, `doors`, `engines`, `hp`, `cubic`, `gearbox`, `typeCar`, `serialNumber`, `category`, `subCategory`) LIKE '%" + searchProduct.Text + "%'";
            }
            else if (idMarka != "" && idModel != "" && cmbCategorySort.Text == "" && cmbSubCategorySort.Text == "")
            {
                querry = "SELECT `name`, `mark`, `model`, `doors`, `engines`, `hp`, `cubic`, `gearbox`, `typeCar`, `serialNumber`, `category`, `subCategory`, `id` FROM `products` WHERE `mark` = '" + idMarka + "' AND `model` = '" + idModel + "' AND CONCAT(`name`, `mark`, `model`, `doors`, `engines`, `hp`, `cubic`, `gearbox`, `typeCar`, `serialNumber`, `category`, `subCategory`) LIKE '%" + searchProduct.Text + "%'";
            }
            else if (idMarka != "" && idModel == "" && cmbCategorySort.Text == "" && cmbSubCategorySort.Text == "")
            {
                querry = "SELECT `name`, `mark`, `model`, `doors`, `engines`, `hp`, `cubic`, `gearbox`, `typeCar`, `serialNumber`, `category`, `subCategory`, `id` FROM `products` WHERE `mark` = '" + idMarka + "' AND CONCAT(`name`, `mark`, `model`, `doors`, `engines`, `hp`, `cubic`, `gearbox`, `typeCar`, `serialNumber`, `category`, `subCategory`) LIKE '%" + searchProduct.Text + "%'";
            }
            else if (idMarka == "" && idModel == "" && cmbCategorySort.Text == "" && cmbSubCategorySort.Text == "")
            {
                querry = "SELECT `name`, `mark`, `model`, `doors`, `engines`, `hp`, `cubic`, `gearbox`, `typeCar`, `serialNumber`, `category`, `subCategory`, `id` FROM `products` WHERE CONCAT(`name`, `mark`, `model`, `doors`, `engines`, `hp`, `cubic`, `gearbox`, `typeCar`, `serialNumber`, `category`, `subCategory`) LIKE '%" + searchProduct.Text + "%' GROUP BY id";
            }
            else if (idMarka != "" && idModel == "" && cmbCategorySort.Text != "" && cmbSubCategorySort.Text == "")
            {
                querry = "SELECT `name`, `mark`, `model`, `doors`, `engines`, `hp`, `cubic`, `gearbox`, `typeCar`, `serialNumber`, `category`, `subCategory`, `id` FROM `products` WHERE `mark` = '" + idMarka + "' AND `category`='" + cmbCategorySort.Text + "' AND CONCAT(`name`, `mark`, `model`, `doors`, `engines`, `hp`, `cubic`, `gearbox`, `typeCar`, `serialNumber`, `category`, `subCategory`) LIKE '%" + searchProduct.Text + "%'";
            }
            else if (idMarka == "" && idModel == "" && cmbCategorySort.Text != "" && cmbSubCategorySort.Text == "")
            {
                querry = "SELECT `name`, `mark`, `model`, `doors`, `engines`, `hp`, `cubic`, `gearbox`, `typeCar`, `serialNumber`, `category`, `subCategory`, `id` FROM `products` WHERE `category`='" + cmbCategorySort.Text + "' AND CONCAT(`name`, `mark`, `model`, `doors`, `engines`, `hp`, `cubic`, `gearbox`, `typeCar`, `serialNumber`, `category`, `subCategory`) LIKE '%" + searchProduct.Text + "%'";
            }
            else if (idMarka == "" && idModel == "" && cmbCategorySort.Text != "" && cmbSubCategorySort.Text != "")
            {
                querry = "SELECT `name`, `mark`, `model`, `doors`, `engines`, `hp`, `cubic`, `gearbox`, `typeCar`, `serialNumber`, `category`, `subCategory`, `id` FROM `products` WHERE `category`='" + cmbCategorySort.Text + "' AND `subCategory`='" + cmbSubCategorySort.Text + "' AND CONCAT(`name`, `mark`, `model`, `doors`, `engines`, `hp`, `cubic`, `gearbox`, `typeCar`, `serialNumber`, `category`, `subCategory`) LIKE '%" + searchProduct.Text + "%'";
            }
            else if (idMarka != "" && idModel == "" && cmbCategorySort.Text != "" && cmbSubCategorySort.Text != "")
            {
                querry = "SELECT `name`, `mark`, `model`, `doors`, `engines`, `hp`, `cubic`, `gearbox`, `typeCar`, `serialNumber`, `category`, `subCategory`, `id` FROM `products` WHERE `mark` = '" + idMarka + "' AND `category`='" + cmbCategorySort.Text + "' AND `subCategory`='" + cmbSubCategorySort.Text + "' AND CONCAT(`name`, `mark`, `model`, `doors`, `engines`, `hp`, `cubic`, `gearbox`, `typeCar`, `serialNumber`, `category`, `subCategory`) LIKE '%" + searchProduct.Text + "%'";
            }

            MySqlCommand cmd = new MySqlCommand(querry, dbConnection);
            try
            {
                dbConnection.Open();
                MySqlDataAdapter DataAdapter = new MySqlDataAdapter();
                DataAdapter.SelectCommand = cmd;
                DataTable dbTable = new DataTable();
                DataAdapter.Fill(dbTable);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbTable;
                metroGrid1.DataSource = bSource;
                DataAdapter.Update(dbTable);
                dbConnection.Close();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbSubCategorySort_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSubSortSelectCategory = cmbSubCategorySort.SelectedItem.ToString();
        }

        private void search_Click(object sender, EventArgs e)
        {
            panelFirstSearch.Visible = true;
            panelSecondSearch.Visible = false;
            cmbMarka.Text = "";
            cmbModel.Text = "";
            serialNumber.Text = "";
            cmbCategorySort.Text = "";
            cmbSubCategorySort.Text = "";
            searchProduct.Text = "";
            pictureBox1.Visible = false;
            reload_cmb();
        }

        private void metroGrid1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                id = int.Parse(metroGrid1.Rows[e.RowIndex].Cells[12].Value.ToString());
            }

            Form4 frm4 = new Form4();
            frm4.PreviewImages(id);
            frm4.Show();
        }

        private void cmbCategorySort_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection dbConnection = new MySqlConnection(MySqlConnectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM carparts.carsubcategory WHERE id_category ='" + cmbCategorySort.SelectedIndex + "'", dbConnection);
            MySqlDataReader render;

            try
            {
                dbConnection.Open();
                render = cmd.ExecuteReader();
                this.cmbSubCategorySort.Items.Clear();
                string name2 = "";
                cmbSubCategorySort.Items.Add(name2);
                while (render.Read())
                {
                    cmbSubCategorySort.Items.Add(render.GetString("name"));
                }
                dbConnection.Close();

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cmbSortSelectCategory = cmbCategorySort.Text;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.Show();
            Information_load(idMarka, idModel);
        }

        private void add_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void Information_load(string idMarka, string idModel)
        {
            MySqlConnection dbConnection = new MySqlConnection(MySqlConnectionString);
            string querry="";

            if (idMarka != "" && idModel != "" && cmbSortSelectCategory != "" && cmbSubSortSelectCategory != "")
            {
                querry = "SELECT `name`, `mark`, `model`, `doors`, `engines`, `hp`, `cubic`, `gearbox`, `typeCar`, `serialNumber`, `category`, `subCategory`, `id` FROM `products` WHERE `mark` = '" + idMarka + "' AND `model` = '" + idModel + "' AND `category`='" + cmbCategorySort.Text + "' AND `subCategory`='" + cmbSubCategorySort.Text + "'";
            }
            else if (idMarka != "" && idModel != "" && cmbSortSelectCategory != "" && cmbSubSortSelectCategory == "")
            {
                querry = "SELECT `name`, `mark`, `model`, `doors`, `engines`, `hp`, `cubic`, `gearbox`, `typeCar`, `serialNumber`, `category`, `subCategory`, `id` FROM `products` WHERE `mark` = '" + idMarka + "' AND `model` = '" + idModel + "' AND `category`='" + cmbCategorySort.Text + "'";
            }
            else if (idMarka != "" && idModel != "" && cmbSortSelectCategory == "" && cmbSubSortSelectCategory == "")
            {
                querry = "SELECT `name`, `mark`, `model`, `doors`, `engines`, `hp`, `cubic`, `gearbox`, `typeCar`, `serialNumber`, `category`, `subCategory`, `id` FROM `products` WHERE `mark` = '" + idMarka + "' AND `model` = '" + idModel + "'";
            }
            else if (idMarka != "" && idModel == "" && cmbSortSelectCategory == "" && cmbSubSortSelectCategory == "")
            {
                querry = "SELECT `name`, `mark`, `model`, `doors`, `engines`, `hp`, `cubic`, `gearbox`, `typeCar`, `serialNumber`, `category`, `subCategory`, `id` FROM `products` WHERE `mark` = '" + idMarka + "'";
            }
            else if (idMarka == "" && idModel == "" && cmbSortSelectCategory == "" && cmbSubSortSelectCategory == "")
            {
                querry = "SELECT `name`, `mark`, `model`, `doors`, `engines`, `hp`, `cubic`, `gearbox`, `typeCar`, `serialNumber`, `category`, `subCategory`, `id` FROM `products` GROUP BY id";
            }
            else if (idMarka != "" && idModel == "" && cmbSortSelectCategory != "" && cmbSubSortSelectCategory == "")
            {
                querry = "SELECT `name`, `mark`, `model`, `doors`, `engines`, `hp`, `cubic`, `gearbox`, `typeCar`, `serialNumber`, `category`, `subCategory`, `id` FROM `products` WHERE `mark` = '" + idMarka + "' AND `category`='" + cmbCategorySort.Text + "'";
            }
            else if (idMarka == "" && idModel == "" && cmbSortSelectCategory != "" && cmbSubSortSelectCategory == "")
            {
                querry = "SELECT `name`, `mark`, `model`, `doors`, `engines`, `hp`, `cubic`, `gearbox`, `typeCar`, `serialNumber`, `category`, `subCategory`, `id` FROM `products` WHERE `category`='" + cmbCategorySort.Text + "'";
            }
            else if (idMarka == "" && idModel == "" && cmbSortSelectCategory != "" && cmbSubSortSelectCategory != "")
            {
                querry = "SELECT `name`, `mark`, `model`, `doors`, `engines`, `hp`, `cubic`, `gearbox`, `typeCar`, `serialNumber`, `category`, `subCategory`, `id` FROM `products` WHERE `category`='" + cmbCategorySort.Text + "' AND `subCategory`='" + cmbSubCategorySort.Text + "'";
            }
            else if (idMarka != "" && idModel == "" && cmbSortSelectCategory != "" && cmbSubSortSelectCategory != "")
            {
                querry = "SELECT `name`, `mark`, `model`, `doors`, `engines`, `hp`, `cubic`, `gearbox`, `typeCar`, `serialNumber`, `category`, `subCategory`, `id` FROM `products` WHERE `mark` = '" + idMarka + "' AND `category`='" + cmbCategorySort.Text + "' AND `subCategory`='" + cmbSubCategorySort.Text + "'";
            }
            //if (idMarka > 0 && idModel > 0 && serialNumber.Text == "") {
            //    querry = "SELECT `name`, `mark`, `model`, `doors`, `engines`, `hp`, `cubic`, `gearbox`, `typeCar`, `serialNumber`, `category`, `subCategory`, `id` FROM `products` WHERE `mark` = '" + idMarka + "' AND `model` = '" + idModel + "'";
            //    //querry = "SELECT carmarks.Mark, carmodels.Model, carmodels.Ot, carmodels.Do FROM carparts.carmarks INNER JOIN carparts.carmodels  WHERE carmarks.id = '" + idMarka + "' AND `carmodels`.`id_marks` = '" + idMarka + "' AND carmodels.id ='" + idModel + "'" ;
            //}
            //else if (idMarka > 0 && idModel <= 0 && serialNumber.Text == "")
            //{
            //    querry = "SELECT `name`, `mark`, `model`, `doors`, `engines`, `hp`, `cubic`, `gearbox`, `typeCar`, `serialNumber`, `category`, `subCategory`, `id` FROM `products` WHERE `mark` = '" + idMarka + "'";
            //}
            //else if(idMarka == "" && idModel <= 0 && serialNumber.Text == "") {
            //    querry = "SELECT `name`, `mark`, `model`, `doors`, `engines`, `hp`, `cubic`, `gearbox`, `typeCar`, `serialNumber`, `category`, `subCategory`, `id` FROM carparts.products GROUP BY id";
            //}
            if (serialNumber.Text != "")
            {
                querry = "SELECT `name`, `mark`, `model`, `doors`, `engines`, `hp`, `cubic`, `gearbox`, `typeCar`, `serialNumber`, `category`, `subCategory`, `id` FROM carparts.products WHERE serialNumber = '" + serialNumber.Text + "'";
            }

            MySqlCommand cmd = new MySqlCommand(querry, dbConnection);
            try
            {
                dbConnection.Open();
                MySqlDataAdapter DataAdapter = new MySqlDataAdapter();
                DataAdapter.SelectCommand = cmd;
                DataTable dbTable = new DataTable();
                DataAdapter.Fill(dbTable);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbTable;
                metroGrid1.DataSource = bSource;
                DataAdapter.Update(dbTable);
                dbConnection.Close();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            idMarka = cmbMarka.Text;
            idModel = cmbModel.Text;
            Information_load(idMarka, idModel);
            metroGrid1.Visible = true;
            btnDeleteProduct.Visible = true;
            btnUpdateProduct.Visible = true;
            panelFirstSearch.Visible = false;
            panelSecondSearch.Visible = true;
            pictureBox1.Visible = true;

            //DataGridViewColumn column = metroGrid1.Columns[0];
            //column.Width = 60;
            DataGridViewColumn column = metroGrid1.Columns[12];
            column.Visible = false;
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection dbConnection = new MySqlConnection(MySqlConnectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM carparts.carmodels WHERE id_marks ='" + cmbMarka.SelectedIndex + "'", dbConnection);
            MySqlDataReader render;

            try
            {
                dbConnection.Open();
                render = cmd.ExecuteReader();
                this.cmbModel.Items.Clear();
                string name2 = "";
                cmbModel.Items.Add(name2);
                while (render.Read())
                {
                    cmbModel.Items.Add(render.GetString("Model"));
                }
                dbConnection.Close();

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                var msg = MessageBox.Show("Сигурни ли сте че искате да изтриете този запис", "Изтриване", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (msg == DialogResult.OK)
                {
                    MySqlConnection dbConnection = new MySqlConnection(MySqlConnectionString);
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM carparts.products WHERE id='" + id + "'", dbConnection);

                    dbConnection.Open();

                    cmd.ExecuteReader();

                    dbConnection.Close();
                    Information_load(idMarka, idModel);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            frm2.updateProductInformation(id,product_name,product_mark,product_model,product_door,product_engine,product_hp,product_cubic,product_gearbox,product_typeCar,product_serialNumber,product_category,product_subcategory);
        }

        private void metroGrid1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                id = int.Parse(metroGrid1.Rows[e.RowIndex].Cells[12].Value.ToString());
                product_name = string.Format(metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString());
                product_mark = string.Format(metroGrid1.Rows[e.RowIndex].Cells[1].Value.ToString());
                product_model = string.Format(metroGrid1.Rows[e.RowIndex].Cells[2].Value.ToString());
                product_door = string.Format(metroGrid1.Rows[e.RowIndex].Cells[3].Value.ToString());
                product_engine = string.Format(metroGrid1.Rows[e.RowIndex].Cells[4].Value.ToString());
                product_hp = int.Parse(metroGrid1.Rows[e.RowIndex].Cells[5].Value.ToString());
                product_cubic = int.Parse(metroGrid1.Rows[e.RowIndex].Cells[6].Value.ToString());
                product_gearbox = string.Format(metroGrid1.Rows[e.RowIndex].Cells[7].Value.ToString());
                product_typeCar = string.Format(metroGrid1.Rows[e.RowIndex].Cells[8].Value.ToString());
                product_serialNumber = string.Format(metroGrid1.Rows[e.RowIndex].Cells[9].Value.ToString());
                product_category = string.Format(metroGrid1.Rows[e.RowIndex].Cells[10].Value.ToString());
                product_subcategory = string.Format(metroGrid1.Rows[e.RowIndex].Cells[11].Value.ToString());

                try
                {
                    MySqlConnection dbConnection = new MySqlConnection(MySqlConnectionString);
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM carparts.productspictures WHERE id_product = '" + id + "'", dbConnection);
                    MySqlDataReader render;
                
                    dbConnection.Open();
                    render = cmd.ExecuteReader();
                    
                    string file_image_name = "";
                    int br_images = 0;

                    while (render.Read() && br_images < 1)
                    {
                        br_images += 1;
                        file_image_name = render.GetString("name");
                        pictureBox1.ImageLocation = "Files/" + file_image_name;
                    }
                    if(br_images == 0)
                    {
                        pictureBox1.ImageLocation = "Files/";
                    }
                    render.Close();
                    dbConnection.Close();
                    
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void reload_cmb()
        {
            MySqlConnection dbConnection = new MySqlConnection(MySqlConnectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM carparts.carmarks", dbConnection);
            MySqlDataReader render;

            try
            {
                dbConnection.Open();
                render = cmd.ExecuteReader();
                string name = "";
                cmbMarka.Items.Add(name);
                while (render.Read())
                {
                    cmbMarka.Items.Add(render.GetString("Mark"));
                }
                dbConnection.Close();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MySqlCommand cmd_sort = new MySqlCommand("SELECT * FROM carparts.carcategory", dbConnection);
            MySqlDataReader render_sort;

            try
            {
                dbConnection.Open();
                render_sort = cmd_sort.ExecuteReader();
                string name_sort = "";
                cmbCategorySort.Items.Add(name_sort);
                while (render_sort.Read())
                {
                    cmbCategorySort.Items.Add(render_sort.GetString("name"));
                }
                dbConnection.Close();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
