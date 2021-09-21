using MarsRoverApp.BAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarsRoverApp
{
    public partial class frmRover : Form
    {
        public frmRover()
        {
            InitializeComponent();
        }


        private void btnMove_Click(object sender, EventArgs e)
        {
            try
            {
                var maxPosition = txtMaxPosition.Text.Trim().Split(' ').Select(int.Parse).ToList();
                var roverPosition = Convert.ToString(txtRoverPosition.Text.Trim()).Split(' ');

                var movingOrder = Convert.ToString(txtMovingOrder.Text.Trim());

                lblResult.Text = startMoving(maxPosition, roverPosition, movingOrder);

                grpResult.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in processing request : " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string startMoving(List<int> maxPosition, string[] roverPosition, string movingOrder)
        {
            try
            {
                //Validations
                this.validateInputData(maxPosition, roverPosition, movingOrder);
                RoverPosition rPosition = new RoverPosition();

                rPosition.X = Convert.ToInt32(roverPosition[0]);
                rPosition.Y = Convert.ToInt32(roverPosition[1]);
                rPosition.Direction = (Directions)Enum.Parse(typeof(Directions), roverPosition[2].ToString());


                return rPosition.StartMoving(maxPosition, movingOrder);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void validateInputData(List<int> maxPosition, string[] roverPosition, string movingOrder)
        {
            try
            {
                if (maxPosition.Count() != 2)
                    throw new Exception("Max. limit is not entered in correct format. Please enter data in 'X Y' format.");
                if (roverPosition.Count() != 3)
                    throw new Exception("Rover Position is not entered in correct format. Please enter data in 'X Y Dir' format.");
                if (string.IsNullOrEmpty(movingOrder))
                    throw new Exception("Please enter moving order.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaxPosition.Text = "";
            txtRoverPosition.Text = "";
            txtMovingOrder.Text = "";

            lblResult.Text = "";
            grpResult.Visible = false;
        }


    }
}
