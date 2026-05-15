
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ATS_Group3_Project.Views
{

    public partial class WindFarm : Form
    {
        [Key]
        public int FarmId { get; set; }

        [Required]
        [StringLength(100)]
        public string FarmName { get; set; }

        [Required]
        public string Address1 { get; set; }

        public string Address2 { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Postcode { get; set; }

        [Required]
        public string Region { get; set; }




        public WindFarm()
        {
            InitializeComponent();
        }

        private void WindFarm_Load(object sender, EventArgs e)
        {
            txtWindFarmName.Text = FarmName;
            TxtAddress1.Text = Address1;
            TxtAddress2.Text = Address2;
            TxtCity.Text = City;
            TxtPostcode.Text = Postcode;
            TxtRegion.Text = Region;





        }



        private void btnBack_Click(object sender, EventArgs e)
        {

            ManageWindFarms managePage = new ManageWindFarms();


            managePage.Show();


            this.Close();
        }

       



        private void label1_Click(object sender, EventArgs e)
        {

        }

      

        private void btnBack_Click_1(object sender, EventArgs e)
        {

            ManageWindFarms manageForm = new ManageWindFarms();
            manageForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void TxtAddress1_TextChanged(object sender, EventArgs e)
        {

        }


        private void TxtAddress2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TxtCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtWindFarmName_TextChanged(object sender, EventArgs e)
        {

        }

        
        
           private void btnSaveDetails_Click_3(object sender, EventArgs e)
        {
            
            {
             
                global::WindFarm farmData = new global::WindFarm()
                {
                    FarmName = txtWindFarmName.Text,
                    Address1 = TxtAddress1.Text,
                    Address2 = TxtAddress2.Text,
                    City = TxtCity.Text,
                    Postcode = TxtPostcode.Text,
                    Region = TxtRegion.Text
                };

                
                if (string.IsNullOrWhiteSpace(farmData.FarmName))
                {
                    MessageBox.Show("Please enter a Farm Name.");
                    return;
                }

                WindFarmManager manager = new WindFarmManager();

                try
                {
                    if (manager.AddWindFarm(farmData))
                    {
                        MessageBox.Show($"{farmData.FarmName} saved to the database!");

                        // 4. Return to the Management View
                        ManageWindFarms managePage = new ManageWindFarms();
                        managePage.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to save. Check your database connection.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        
        

        

        private void btnclear_Click_3(object sender, EventArgs e)
        {
            txtWindFarmName.Clear();
            TxtAddress1.Clear();
            TxtAddress2.Clear();
            TxtCity.Clear();
            TxtPostcode.Clear();
            TxtRegion.Clear();
        }
    }
}
