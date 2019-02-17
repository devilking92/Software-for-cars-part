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
using System.IO;
using System.Reflection;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private string MySqlConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString;
        int update_id = 0;
        private long last_product_insert_id=0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MySqlConnection dbConnection = new MySqlConnection(MySqlConnectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM carparts.carmarks", dbConnection);
            MySqlCommand cmd_engine = new MySqlCommand("SELECT * FROM carparts.engines ORDER BY `engines`.`name` DESC", dbConnection);
            MySqlCommand cmd_category = new MySqlCommand("SELECT * FROM carparts.carcategory", dbConnection);
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

                dbConnection.Open();
                render = cmd_engine.ExecuteReader();
                string name2 = "";
                cmbengine.Items.Add(name2);
                while (render.Read())
                {
                    cmbengine.Items.Add(render.GetString("name"));
                }
                dbConnection.Close();

                dbConnection.Open();
                render = cmd_category.ExecuteReader();
                string name3 = "";
                cmbcategory.Items.Add(name3);
                while (render.Read())
                {
                    cmbcategory.Items.Add(render.GetString("name"));
                }
                dbConnection.Close();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                this.cmbmodel.Items.Clear();
                string name2 = "";
                cmbmodel.Items.Add(name2);
                while (render.Read())
                {
                    cmbmodel.Items.Add(render.GetString("Model"));
                }
                dbConnection.Close();

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            MySqlConnection dbConnection = new MySqlConnection(MySqlConnectionString);
            string query = "INSERT INTO `products`(`name`, `mark`, `model`, `doors`, `engines`, `hp`, `cubic`, `gearbox`, `typeCar`, `serialNumber`, `category`, `subCategory`)" +
            " VALUES('"+ txbproductName.Text +"','"+ cmbMarka.Text +"','" + cmbmodel.Text +"','"+ cmbdoor.Text +"','" + cmbengine.Text +"','"+ txbhp.Text +"','"+ txbcubic.Text +"','"+ cmbgearbox.Text +"','"+ cmbtypeCar.Text +"','"+  txbserialNumber.Text +"','"+ cmbcategory.Text +"','"+ cmbSubCategory.Text +"')";
            MySqlCommand cmd = new MySqlCommand(query, dbConnection);
            dbConnection.Open();
            int check = cmd.ExecuteNonQuery();
            if (check > 0)
            {
              MessageBox.Show("Добавянето е успешно");
            }
            dbConnection.Close();
            txbproductName.Text = "";
            txbcubic.Text = "";
            txbhp.Text = "";
            txbserialNumber.Text = "";
            cmbcategory.Text = "";
            cmbdoor.Text = "";
            cmbengine.Text = "";
            cmbgearbox.Text = "";
            cmbMarka.Text = "";
            cmbmodel.Text = "";
            cmbtypeCar.Text = "";
            cmbSubCategory.Text = "";
            last_product_insert_id = cmd.LastInsertedId;
            dbConnection.Close();
            if (MetroFramework.MetroMessageBox.Show(this, "Желаете ли да добавите изображения към този продукт?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                uploadImages();
            }
            else {
                Form1 frm1 = new Form1();
                frm1.Activate();
            }
        }

        public void updateProductInformation(int id, string product_name,string product_mark, string product_model,string product_door,string product_engine,int product_hp,int product_cubic,string product_gearbox,string product_typeCar,string product_serialNumber, string product_category, string product_subcategory)
        {
            groupBox1.Visible = true;
            btnUpdate.Visible = true;

            txbproductName.Text = product_name;
            cmbengine.Text = product_engine;
            cmbMarka.Text = product_mark;
            cmbmodel.Text = product_model;
            cmbgearbox.Text = product_gearbox;
            cmbcategory.Text = product_category;
            txbhp.Text = product_hp.ToString();
            txbcubic.Text = product_cubic.ToString();
            cmbdoor.Text = product_door;
            cmbtypeCar.Text = product_typeCar;
            txbserialNumber.Text = product_serialNumber;
            cmbSubCategory.Text = product_subcategory;
            update_id = id;

            listBoxItems();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MySqlConnection dbConnection = new MySqlConnection(MySqlConnectionString);
            string update_query = "UPDATE `products` SET `name`='" + txbproductName.Text + "',`mark`='" + cmbMarka.Text + "',`model`='" + cmbmodel.Text + "',`doors`='" + cmbdoor.Text + "',`engines`='" + cmbengine.Text + "',`hp`='" + txbhp.Text + "',`cubic`='" + txbcubic.Text + "',`gearbox`='" + cmbgearbox.Text + "',`typeCar`='" + cmbtypeCar.Text + "',`serialNumber`='" + txbserialNumber.Text + "',`category`='" + cmbcategory.Text + "',`subCategory`='"+ cmbSubCategory.Text +"' WHERE id='" + update_id +"'";
            MySqlCommand cmd = new MySqlCommand(update_query, dbConnection);
            dbConnection.Open();
            int check = cmd.ExecuteNonQuery();
            if (check > 0)
            {
                MessageBox.Show("Промените са направени успешно");
                this.Close();
            }
            dbConnection.Close();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Activate();
        }

        private void cmbcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection dbConnection = new MySqlConnection(MySqlConnectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM carparts.carsubcategory WHERE id_category ='" + cmbcategory.SelectedIndex + "'", dbConnection);
            MySqlDataReader render;

            try
            {
                dbConnection.Open();
                render = cmd.ExecuteReader();
                this.cmbSubCategory.Items.Clear();
                string name2 = "";
                cmbSubCategory.Items.Add(name2);
                while (render.Read())
                {
                    cmbSubCategory.Items.Add(render.GetString("name"));
                }
                dbConnection.Close();

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        string file_size(long byteCount)
        {
            string[] suf = { "B", "KB", "MB", "GB", "TB", "PB", "EB" }; //Longs run out around EB
            if (byteCount == 0)
                return "0" + suf[0];
            long bytes = Math.Abs(byteCount);
            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return (Math.Sign(byteCount) * num).ToString() + suf[place];
        }
        

        private void uploadImages()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            //Add filter, if you want to allow all extenssions just remove it.
            openFileDialog.Filter = "Images (*.BMP;*.JPG;*.GIF;*.PNG;*.JPEG)|*.BMP;*.JPG;*.GIF;*.JPEG;*.PNG|" + "All files (*.*)|*.*";

            // Set multiselect true for slecting multiple files
            openFileDialog.Multiselect = true;

            // Show open file dialog and check if Open button is pressed.
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                // Set directory name and create it.
                string directory = "Files";

                Directory.CreateDirectory(directory);

                MySqlConnection dbConnection = new MySqlConnection(MySqlConnectionString);
                dbConnection.Open();
                // Read all files.
                foreach (string fileName in openFileDialog.FileNames)
                {

                    // Get file name without its path.
                    int randomNumber = new Random().Next();
                    string newFile = directory + "/" + randomNumber + Path.GetFileName(fileName);
                    FileInfo fi = new FileInfo(fileName);
                    var size = file_size(fi.Length);
                    string file_name = randomNumber + fi.Name;
                    string file_ext = fi.Extension;

                    //ResizeImage(fileName, newFile, 100, 100, true);
                    Image OriginalImage = Image.FromFile(fileName);

                    string query = "INSERT INTO `productspictures`(`id_product`, `name`, `size`, `ext`)" +
                    " VALUES('" + (int)last_product_insert_id + "','" + file_name + "', '" + size + "','" + file_ext + "')";
                    MySqlCommand cmd = new MySqlCommand(query, dbConnection);
                    
                    cmd.ExecuteNonQuery();

                    // Save picture
                    OriginalImage.Save(newFile);

                    // Clear handle to original file so that we can overwrite it if necessary
                    OriginalImage.Dispose();

                    
                    
                }
                dbConnection.Close();
                MessageBox.Show("Добавянето е успешно");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedImage = listBox1.SelectedItems[0].ToString();
                if (!string.IsNullOrEmpty(selectedImage))
                {
                    var fullPath = Path.Combine("Files/", selectedImage);

                    previewImageDelete.Image = Image.FromFile(fullPath);
                }
            }
            catch (Exception)
            {
               // MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteButtonImages_Click(object sender, EventArgs e)
        {
            string fullPath = "";
            if (listBox1.SelectedIndex != -1)
            {
                fullPath = Path.Combine(@"Files\", listBox1.SelectedItem.ToString());
                if (System.IO.File.Exists(fullPath))
                {
                    previewImageDelete.Image.Dispose();
                    previewImageDelete.Image = null;

                    try
                    {
                        var msg = MessageBox.Show("Сигурни ли сте че искате да изтриете този запис", "Изтриване", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (msg == DialogResult.OK)
                        {
                            MySqlConnection dbConnection = new MySqlConnection(MySqlConnectionString);
                            MySqlCommand cmd = new MySqlCommand("DELETE FROM carparts.productspictures WHERE name='" + listBox1.SelectedItem.ToString() + "'", dbConnection);

                            dbConnection.Open();

                            cmd.ExecuteReader();

                            dbConnection.Close();
                            listBox1.Items.Remove(listBox1.Items[listBox1.SelectedIndex]);
                            Form1 frm1 = new Form1();
                            frm1.pictureBox1.Image.Dispose();
                            frm1.pictureBox1.Image = null;
                        }
                    }
                    catch (Exception)
                    {
                       // MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    File.Delete(fullPath);
                    MessageBox.Show("Изтриването е успешно");
                }
                else
                {
                    MessageBox.Show("Изтриването е неуспешно");
                }
            }
        }

        private void btnAddNewImages_Click(object sender, EventArgs e)
        {
            string query = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();

            //Add filter, if you want to allow all extenssions just remove it.
            openFileDialog.Filter = "Images (*.BMP;*.JPG;*.GIF;*.PNG;*.JPEG)|*.BMP;*.JPG;*.GIF;*.JPEG;*.PNG|" + "All files (*.*)|*.*";

            // Set multiselect true for slecting multiple files
            openFileDialog.Multiselect = true;

            // Show open file dialog and check if Open button is pressed.
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                // Set directory name and create it.
                string directory = "Files";

                Directory.CreateDirectory(directory);

                MySqlConnection dbConnection = new MySqlConnection(MySqlConnectionString);

                // Read all files.
                foreach (string fileName in openFileDialog.FileNames)
                {
                    int randomNumber = new Random().Next();
                    // Get file name without its path.
                    string newFile = directory + "/" + randomNumber + Path.GetFileName(fileName);
                    FileInfo fi = new FileInfo(fileName);
                    var size = file_size(fi.Length);
                    string file_name = randomNumber + fi.Name;
                    string file_ext = fi.Extension;

                    //ResizeImage(fileName, newFile, 100, 100, true);
                    Image OriginalImage = Image.FromFile(fileName);

                    query = "INSERT INTO `productspictures`(`id_product`, `name`, `size`, `ext`)" +
                    " VALUES('" + update_id + "','" + file_name + "', '" + size + "','" + file_ext + "')";
                    MySqlCommand cmd = new MySqlCommand(query, dbConnection);
                    dbConnection.Open();
                    cmd.ExecuteNonQuery();

                    // Save picture
                    OriginalImage.Save(newFile);

                    // Clear handle to original file so that we can overwrite it if necessary
                    OriginalImage.Dispose();

                    dbConnection.Close();

                }
                MessageBox.Show("Добавянето е успешно");
                listBoxItems();
            }
        }

        private void listBoxItems()
        {
            listBox1.Items.Clear();
            MySqlConnection dbConnection = new MySqlConnection(MySqlConnectionString);
            MySqlCommand cmd_images = new MySqlCommand("SELECT * FROM carparts.productspictures WHERE `id_product`='" + update_id + "'", dbConnection);
            MySqlDataReader render;

            try
            {
                dbConnection.Open();
                render = cmd_images.ExecuteReader();
                
                while (render.Read())
                {
                    listBox1.Items.Add(render.GetString("name"));
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
