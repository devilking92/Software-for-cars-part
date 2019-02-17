using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        private string MySqlConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString;

        public Form4()
        {
            InitializeComponent();
        }

        public void PreviewImages(float id)
        {
            MySqlConnection dbConnection = new MySqlConnection(MySqlConnectionString);
            MySqlCommand cmd_images = new MySqlCommand("SELECT * FROM carparts.productspictures WHERE `id_product`='"+ id +"'", dbConnection);
            MySqlDataReader render;

            try
            {
                dbConnection.Open();
                render = cmd_images.ExecuteReader();

                while (render.Read())
                {
                    listBoxImages.Items.Add(render.GetString("name"));
                }
                dbConnection.Close();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedImage = listBoxImages.SelectedItems[0].ToString();
                if (!string.IsNullOrEmpty(selectedImage))
                {
                    var fullPath = Path.Combine("Files/",selectedImage);

                    picturesPreview.Image = Image.FromFile(fullPath);
                }
            }
            catch (Exception)
            {
               // MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form4 f = new Form4();
            f.Close();
        }
    }
}
