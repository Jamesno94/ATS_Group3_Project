using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ATS_Group3_Project
{
    public partial class frmTurbSimData : Form
    {
        private User _user;
        private WindFarmManager _windFarmManager = new WindFarmManager();

        public frmTurbSimData()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Whitelee
            //Beinn an Tuirc
            //Clyde
            string windFarmId;
            List<Turbine> turbines = null;

            if (cboWIndFarms.SelectedIndex == 0)
            {
                windFarmId = "WL-FARM";
                turbines = new TurbineManager().GetTurbinesByFarmId(windFarmId);
            }
            else if (cboWIndFarms.SelectedIndex == 1)
            {
                windFarmId = "BT-FARM";
                turbines = new TurbineManager().GetTurbinesByFarmId(windFarmId);
            }
            else if (cboWIndFarms.SelectedIndex == 2)
            {
                windFarmId = "CL-FARM";
                turbines = new TurbineManager().GetTurbinesByFarmId(windFarmId);
            }

            if (turbines != null)
            {
                for (int i = 0; i < turbines.Count; i++)
                {
                    lstTest.Items.Add(turbines[i].TurbineId);
                }
            }
        }
    }
}
