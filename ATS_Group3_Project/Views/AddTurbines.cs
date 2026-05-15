using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATS_Group3_Project.Views
{
    public partial class frmAddTurbines : Form
    {
        [Key]
        public string TurbineId { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        [Required]
        public int RuntimeHours { get; set; }

        [Required]
        public string Status { get; set; }

        // Foreign Key
        public int FarmId { get; set; }

        [ForeignKey("FarmId")]
        public virtual frmAddWindFarm WindFarm { get; set; }
        public frmAddTurbines()
        {
            InitializeComponent();
        }

        private void Turbines_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Manage managerView = new Manage();

            managerView.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void TxtTurbineId_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtTurbineId.Clear();
            TxtMake.Clear();
            TxtRuntimeHours.Clear();
            TxtStatus.Clear();
            TxtFarmId.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            {
                
               
                //var newTurbine = new Turbine()
                //{
                //    TurbineId = TxtTurbineId.Text,
                //    Make = TxtMake.Text,
                //    Status = TxtStatus.Text,
                
                //};

              
                //if (int.TryParse(TxtRuntimeHours.Text, out int hours)) newTurbine.RuntimeHours = hours;
                //if (int.TryParse(TxtFarmId.Text, out int fId)) newTurbine.WindFarmId = fId;

                
                //TurbineManager manager = new TurbineManager();
                //bool success = manager.AddTurbine(newTurbine);

                //if (success)
                //{
                //    MessageBox.Show("Turbine saved to database successfully!");
                //    this.Close(); 
                //}
                //else
                //{
                //    MessageBox.Show("Error: Could not save to database.");
                //}

            }
        }

            
        

        private void btnClear_Click(object sender, EventArgs e)
        {
            TxtTurbineId.Clear();
            TxtMake.Clear();
            TxtRuntimeHours.Clear();
            TxtStatus.Clear();
            TxtFarmId.Clear();
        
        }
    }
}
