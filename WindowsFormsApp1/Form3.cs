using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        private string MySqlConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString;
        private int idUpdateDB = 0, querry_DB = 0, SelectedRowId = 0;
        private string querry = "", update_query_DB = "";

        public Form3()
        {
            InitializeComponent();
        }

        private void btnAddMarka_Click(object sender, EventArgs e)
        {
            Panel_1.Visible = false;
            btnBackToAddPanel.Visible = true;
            addMarkaPanel.Visible = true;
            addMarkaPanel.Location = new Point(15, 71);
            btnBackToAddPanel.Location = new Point(15, 0);
        }

        private void btnBackToAddPanel_Click(object sender, EventArgs e)
        {
            Panel_1.Visible = true;
            btnBackToAddPanel.Visible = false;
            addMarkaPanel.Visible = false;
            addModelPanel.Visible = false;
            addCategoryPanel.Visible = false;
            addSubCategoryPanel.Visible = false;
            addEnginePanel.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO carmarks (Mark) VALUES('" + addMarkTextBox.Text + "')";
            MySqlConnection dbConnection = new MySqlConnection(MySqlConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, dbConnection);
            dbConnection.Open();
            int check = cmd.ExecuteNonQuery();
            if(check > 0)
            {
                MessageBox.Show("Добавянето е успешно");
            }
            dbConnection.Close();
            addMarkTextBox.Text = "";
            refreshAftherAdd();
        }

        private void btnAddModel_Click(object sender, EventArgs e)
        {
            Panel_1.Visible = false;
            btnBackToAddPanel.Visible = true;
            addModelPanel.Visible = true;
            addModelPanel.Location = new Point(15, 71);
            btnBackToAddPanel.Location = new Point(15, 0);
        }

        private void btnSaveModel_Click(object sender, EventArgs e)
        {
            MySqlConnection dbConnection = new MySqlConnection(MySqlConnectionString);
            if(cmbMarka.SelectedIndex > 0){
                string query = "INSERT INTO carmodels (id_marks,Model,Ot,Do) VALUES('" + cmbMarka.SelectedIndex + "','" + addModelTextBox.Text + "','" + addOtTextBox.Text + "','" + addDoTextBox.Text + "')";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection);
                dbConnection.Open();
                int check = cmd.ExecuteNonQuery();
                if (check > 0)
                {
                    MessageBox.Show("Добавянето е успешно");
                }
                dbConnection.Close();
                addModelTextBox.Text = "";
                cmbMarka.Text = "";
                addOtTextBox.Text = "";
                addDoTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Не сте избрали марка автомобил!!!");
            }
           
        }

        private void btnSaveCategory_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO carcategory (name) VALUES('" + addCategoryTextBox.Text + "')";
            MySqlConnection dbConnection = new MySqlConnection(MySqlConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, dbConnection);
            dbConnection.Open();
            int check = cmd.ExecuteNonQuery();
            if (check > 0)
            {
                MessageBox.Show("Добавянето е успешно");
            }
            dbConnection.Close();
            addCategoryTextBox.Text = "";
            refreshAftherAdd();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            Panel_1.Visible = false;
            btnBackToAddPanel.Visible = true;
            addCategoryPanel.Visible = true;
            addCategoryPanel.Location = new Point(15, 71);
            btnBackToAddPanel.Location = new Point(15, 0);
        }

        private void btnAddSubCategory_Click(object sender, EventArgs e)
        {
            Panel_1.Visible = false;
            btnBackToAddPanel.Visible = true;
            addSubCategoryPanel.Visible = true;
            addSubCategoryPanel.Location = new Point(15, 71);
            btnBackToAddPanel.Location = new Point(15, 0);
        }

        private void btnSaveSubCategory_Click(object sender, EventArgs e)
        {
            MySqlConnection dbConnection = new MySqlConnection(MySqlConnectionString);
            if (cmbCategory.SelectedIndex > 0){
                string query = "INSERT INTO carsubcategory (id_category,name) VALUES('" + cmbCategory.SelectedIndex + "','" + addSubCategoryTextBox.Text + "')";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection);
                dbConnection.Open();
                int check = cmd.ExecuteNonQuery();
                if (check > 0)
                {
                    MessageBox.Show("Добавянето е успешно");
                }
                dbConnection.Close();
                cmbCategory.Text = "";
                addSubCategoryTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Не сте избрали категория!!!");
            }
        }

        private void btnAddEngine_Click(object sender, EventArgs e)
        {
            Panel_1.Visible = false;
            btnBackToAddPanel.Visible = true;
            addEnginePanel.Visible = true;
            addEnginePanel.Location = new Point(15, 71);
            btnBackToAddPanel.Location = new Point(15, 0);
        }

        private void btnSaveEngine_Click(object sender, EventArgs e)
        {
            MySqlConnection dbConnection = new MySqlConnection(MySqlConnectionString);
            string query = "INSERT INTO engines (name) VALUES('" + addEngineTextBox.Text + "')";
            MySqlCommand cmd = new MySqlCommand(query, dbConnection);
            dbConnection.Open();
            int check = cmd.ExecuteNonQuery();
            if (check > 0)
            {
                MessageBox.Show("Добавянето е успешно");
            }
            dbConnection.Close();
            cmbCategory.Text = "";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Size = new Size(520, 460);
            AddPage.Size = new Size(480, 390);

            MySqlConnection dbConnection = new MySqlConnection(MySqlConnectionString);
            MySqlCommand cmd_mark = new MySqlCommand("SELECT * FROM carparts.carmarks", dbConnection);
            MySqlCommand cmd_category = new MySqlCommand("SELECT * FROM carparts.carcategory", dbConnection);
            MySqlDataReader render;

            try
            {
                dbConnection.Open();
                render = cmd_mark.ExecuteReader();
                string name = "";
                cmbMarka.Items.Add(name);
                while (render.Read())
                {
                    cmbMarka.Items.Add(render.GetString("Mark"));
                }
                dbConnection.Close();

                dbConnection.Open();
                render = cmd_category.ExecuteReader();
                string name2 = "";
                cmbCategory.Items.Add(name2);
                while (render.Read())
                {
                    cmbCategory.Items.Add(render.GetString("name"));
                }
                dbConnection.Close();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            panelUpdateDB.Visible = true;
            metroGridUpdateDB.Visible = false;
        }

        private void btnUpdateMarka_Click(object sender, EventArgs e)
        {
            querry = "";
            panelUpdateDB.Visible = false;
            groupBox1.Visible = true;
            metroGridUpdateDB.Visible = true;
            groupBox1.Location = new Point(6, 0);
            querry_DB = 1;

            MySqlConnection dbConnection = new MySqlConnection(MySqlConnectionString);
            querry = "SELECT id, Mark  FROM carparts.carmarks";

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
                metroGridUpdateDB.DataSource = bSource;
                DataAdapter.Update(dbTable);
                dbConnection.Close();

                DataGridViewColumn column = metroGridUpdateDB.Columns[0];
                column.Visible = false;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateModel_Click(object sender, EventArgs e)
        {
            querry = "";

            panelUpdateDB.Visible = false;
            groupBox1.Visible = true;
            metroGridUpdateDB.Visible = true;
            groupBox1.Location = new Point(6, 0);
            querry_DB = 2;

            MySqlConnection dbConnection = new MySqlConnection(MySqlConnectionString);
            querry = "SELECT id,Model,Ot,Do FROM carparts.carmodels";

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
                metroGridUpdateDB.DataSource = bSource;
                DataAdapter.Update(dbTable);
                dbConnection.Close();

                DataGridViewColumn column = metroGridUpdateDB.Columns[0];
                column.Visible = false;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            querry = "";
            panelUpdateDB.Visible = false;
            groupBox1.Visible = true;
            metroGridUpdateDB.Visible = true;
            groupBox1.Location = new Point(6, 0);
            querry_DB = 3;

            MySqlConnection dbConnection = new MySqlConnection(MySqlConnectionString);
            querry = "SELECT id, name FROM carparts.carcategory";

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
                metroGridUpdateDB.DataSource = bSource;
                DataAdapter.Update(dbTable);
                dbConnection.Close();

                DataGridViewColumn column = metroGridUpdateDB.Columns[0];
                column.Visible = false;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateSubCategory_Click(object sender, EventArgs e)
        {
            querry = "";
            panelUpdateDB.Visible = false;
            groupBox1.Visible = true;
            metroGridUpdateDB.Visible = true;
            groupBox1.Location = new Point(6, 0);
            querry_DB = 4;

            MySqlConnection dbConnection = new MySqlConnection(MySqlConnectionString);
            querry = "SELECT id, name FROM carparts.carsubcategory";

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
                metroGridUpdateDB.DataSource = bSource;
                DataAdapter.Update(dbTable);
                dbConnection.Close();

                DataGridViewColumn column = metroGridUpdateDB.Columns[0];
                column.Visible = false;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroGridUpdateDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ForDelete_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                var msg = MessageBox.Show("Сигурни ли сте че искате да изтриете този запис", "Изтриване", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (msg == DialogResult.OK)
                {
                    MySqlConnection dbConnection = new MySqlConnection(MySqlConnectionString);

                    string delete_query_DB = "";
                    switch (querry_DB)
                    {
                        case 1:
                            { delete_query_DB = "DELETE FROM carparts.carmarks WHERE id='" + SelectedRowId + "'"; }
                            break;
                        case 2:
                            { delete_query_DB = "DELETE FROM carparts.carmodels WHERE id='" + SelectedRowId + "'"; }
                            break;
                        case 3:
                            { delete_query_DB = "DELETE FROM carparts.carcategory WHERE id='" + SelectedRowId + "'"; }
                            break;
                        case 4:
                            { delete_query_DB = "DELETE FROM carparts.carsubcategory WHERE id = '" + SelectedRowId + "'"; }
                            break;
                        case 5:
                            { delete_query_DB = "DELETE FROM carparts.engines WHERE id='" + SelectedRowId + "'"; }
                            break;
                    }

                    MySqlCommand cmd = new MySqlCommand(delete_query_DB, dbConnection);

                    dbConnection.Open();

                    cmd.ExecuteReader();

                    dbConnection.Close();
                    ReloadDataGrid(querry_DB);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateEngine_Click(object sender, EventArgs e)
        {
            querry = "";
            panelUpdateDB.Visible = false;
            groupBox1.Visible = true;
            metroGridUpdateDB.Visible = true;
            groupBox1.Location = new Point(6, 0);
            querry_DB = 5;

            MySqlConnection dbConnection = new MySqlConnection(MySqlConnectionString);
            querry = "SELECT id, name FROM carparts.engines";

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
                metroGridUpdateDB.DataSource = bSource;
                DataAdapter.Update(dbTable);
                dbConnection.Close();

                DataGridViewColumn column = metroGridUpdateDB.Columns[0];
                column.Visible = false;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroGridUpdateDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRowId = int.Parse(metroGridUpdateDB.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection dbConnection = new MySqlConnection(MySqlConnectionString);
            string search_query = "";
            switch (querry_DB)
            {
                case 1:
                    { search_query = "SELECT id, Mark  FROM carparts.carmarks WHERE CONCAT(`Mark`) LIKE '%" + metroTextBox1.Text + "%'"; }
                    break;
                case 2:
                    { search_query = "SELECT id,Model,Ot,Do FROM carparts.carmodels WHERE CONCAT(`Model`, `Ot`, `Do`) LIKE '%" + metroTextBox1.Text + "%'"; }
                    break;
                case 3:
                    { search_query = "SELECT id, name FROM carparts.carcategory WHERE CONCAT(`name`) LIKE '%" + metroTextBox1.Text + "%'"; }
                    break;
                case 4:
                    { search_query = "SELECT id, name FROM carparts.carsubcategory WHERE CONCAT(`name`) LIKE '%" + metroTextBox1.Text + "%'"; }
                    break;
                case 5:
                    { search_query = "SELECT id, name FROM carparts.engines WHERE CONCAT(`name`) LIKE '%" + metroTextBox1.Text + "%'"; }
                    break;
            }
            MySqlCommand cmd = new MySqlCommand(search_query, dbConnection);
            try
            {
                dbConnection.Open();
                MySqlDataAdapter DataAdapter = new MySqlDataAdapter();
                DataAdapter.SelectCommand = cmd;
                DataTable dbTable = new DataTable();
                DataAdapter.Fill(dbTable);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbTable;
                metroGridUpdateDB.DataSource = bSource;
                DataAdapter.Update(dbTable);
                dbConnection.Close();

                DataGridViewColumn column = metroGridUpdateDB.Columns[0];
                column.Visible = false;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroGridUpdateDB_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                idUpdateDB = int.Parse(metroGridUpdateDB.Rows[e.RowIndex].Cells[0].Value.ToString());
                string nameUpdate = string.Format(metroGridUpdateDB.Rows[e.RowIndex].Cells[1].Value.ToString());


                MySqlConnection dbConnection = new MySqlConnection(MySqlConnectionString);

                switch (querry_DB)
                {
                    case 1:
                        { update_query_DB = "UPDATE carparts.carmarks SET Mark='" + nameUpdate + "' WHERE id='"+ idUpdateDB +"'"; }
                        break;
                    case 2:
                        {
                            int OtUpdate = int.Parse(metroGridUpdateDB.Rows[e.RowIndex].Cells[2].Value.ToString());
                            int DoUpdate = int.Parse(metroGridUpdateDB.Rows[e.RowIndex].Cells[3].Value.ToString());
                            update_query_DB = "UPDATE carparts.carmodels SET Model='" + nameUpdate + "', Ot='" + OtUpdate + "', Do='" + DoUpdate + "' WHERE id='" + idUpdateDB + "'";
                        }
                        break;
                    case 3:
                        { update_query_DB = "UPDATE carparts.carcategory SET name='" + nameUpdate + "' WHERE id='" + idUpdateDB + "'"; }
                        break;
                    case 4:
                        { update_query_DB = "UPDATE carparts.carsubcategory SET name='" + nameUpdate + "' WHERE id='" + idUpdateDB + "'"; }
                        break;
                    case 5:
                        { update_query_DB = "UPDATE carparts.engines SET name='" + nameUpdate + "' WHERE id='" + idUpdateDB + "'"; }
                        break;
                }

                MySqlCommand cmd = new MySqlCommand(update_query_DB, dbConnection);
                dbConnection.Open();
                int check = cmd.ExecuteNonQuery();
                if (check > 0)
                {
                    MessageBox.Show("Промените са направени успешно");
                    
                }
                dbConnection.Close();
            }
        }

        private void ReloadDataGrid(int querry_refresh)
        {
            MySqlConnection dbConnection = new MySqlConnection(MySqlConnectionString);
            string update_query_refresh = "";
            switch (querry_refresh)
            {
                case 1:
                    { update_query_refresh = "SELECT id, Mark  FROM carparts.carmarks"; }
                    break;
                case 2:
                    { update_query_refresh = "SELECT id,Model,Ot,Do FROM carparts.carmodels"; }
                    break;
                case 3:
                    { update_query_refresh = "SELECT id, name FROM carparts.carcategory"; }
                    break;
                case 4:
                    { update_query_refresh = "SELECT id, name FROM carparts.carsubcategory"; }
                    break;
                case 5:
                    { update_query_refresh = "SELECT id, name FROM carparts.engines"; }
                    break;
            }
            MySqlCommand cmd = new MySqlCommand(update_query_refresh, dbConnection);
            try
            {
                dbConnection.Open();
                MySqlDataAdapter DataAdapter = new MySqlDataAdapter();
                DataAdapter.SelectCommand = cmd;
                DataTable dbTable = new DataTable();
                DataAdapter.Fill(dbTable);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbTable;
                metroGridUpdateDB.DataSource = bSource;
                DataAdapter.Update(dbTable);
                dbConnection.Close();

                DataGridViewColumn column = metroGridUpdateDB.Columns[0];
                column.Visible = false;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refreshAftherAdd()
        {
            cmbMarka.Items.Clear();
            cmbCategory.Items.Clear();

            MySqlConnection dbConnection = new MySqlConnection(MySqlConnectionString);
            MySqlCommand cmd_mark = new MySqlCommand("SELECT * FROM carparts.carmarks", dbConnection);
            MySqlCommand cmd_category = new MySqlCommand("SELECT * FROM carparts.carcategory", dbConnection);
            MySqlDataReader render;

            try
            {
                dbConnection.Open();
                render = cmd_mark.ExecuteReader();
                string name = "";
                cmbMarka.Items.Add(name);
                while (render.Read())
                {
                    cmbMarka.Items.Add(render.GetString("Mark"));
                }
                dbConnection.Close();

                dbConnection.Open();
                render = cmd_category.ExecuteReader();
                string name2 = "";
                cmbCategory.Items.Add(name2);
                while (render.Read())
                {
                    cmbCategory.Items.Add(render.GetString("name"));
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
