using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6_2
{
    public partial class formCRUD : Form
    {
        #region FormInitilization
        //universal car repository variable to be used throughout the program
        CarRepository repository;
        public formCRUD()
        {
            InitializeComponent();
        }
        #endregion

        #region ResetData
        private void ResetData()
            //resets all the form controls to the default values and formats cells in the datagridview to year only and currency
        {
            txtVIN.Clear();
            txtMake.Clear();
            txtModel.Clear();
            txtPrice.Clear();
            cboAbility.SelectedIndex = -1;
            dataCars.DataSource = null;
            dataCars.DataSource = repository.GetCars();
            dataCars.Columns[3].DefaultCellStyle.Format = "yyyy";
            dateYear.Format = DateTimePickerFormat.Custom;
            dateYear.CustomFormat = "yyyy";
            dateYear.ShowUpDown = true;
            dataCars.Columns["Year"].DefaultCellStyle.Format = "yyyy";
            dataCars.Columns["Price"].DefaultCellStyle.Format = "c";
        }
        #endregion

        #region IsValid
        private bool IsValid()
        {
            //error handling boolean for items that do not allow nulls in the database
            if (txtVIN.Text == string.Empty)
            {
                MessageBox.Show("All vehicle records must include a VIN.", "S.H.I.E.L.D. ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtMake.Text == string.Empty)
            {
                MessageBox.Show("All vehicle records must inclue a make.", "S.H.I.E.L.D. ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (dateYear.Value == null)
            {
                MessageBox.Show("All vehicle records must include a year of upgrade.", "S.H.I.E.L.D. ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cboAbility.SelectedIndex == -1)
            {
                MessageBox.Show("All vehicle records must include abilities. If none, select 'NONE'.", "S.H.I.E.L.D. ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            btnAdd.Enabled = true;
            return true;
        }
        #endregion

        #region FormLoad
        private void formCRUD_Load(object sender, EventArgs e)
        {
            //loads the form and places the data from the SQL databse in the datagridview
            repository = new CarRepository();
            cboAbility.Items.AddRange(new string[] { "Flying", "Floating", "Cloaking", "Weapons", "None" });
            ResetData();
            pnlControls.Visible = false;
        }
        #endregion

        #region AddButton
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //shows the text boxes for the controls on the form and enables the save button
            pnlControls.Visible = true;
        }
        #endregion

        #region SaveButton
        private void btnSave_Click(object sender, EventArgs e)
        {
            //if all of the required fields are filled, the add button will enable and allow the user to save a new car.
            if (IsValid())
            {
                
                var newcar = new Car();
                newcar.VIN = txtVIN.Text;
                newcar.Make = txtMake.Text;
                newcar.Model = txtModel.Text;
                newcar.Year = dateYear.Value;
                newcar.Price = Convert.ToDecimal(txtPrice.Text);
                newcar.Ability = cboAbility.SelectedItem.ToString();
                repository.AddRecord(newcar);
                ResetData();
                MessageBox.Show("Record added successfully!", "Vehicle in S.H.I.E.L.D. Database");
            }
        }
        #endregion

        #region UpdateButton
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.dataCars.SelectedRows.Count > 0)
            {
                var vin = Convert.ToString(txtVIN.Text);
                var cartoupdate = repository.FindCar(vin);
                cartoupdate.Make = txtMake.Text;
                cartoupdate.Model = txtModel.Text;
                cartoupdate.Year = dateYear.Value;
                cartoupdate.Price = Convert.ToDecimal(txtPrice.Text);
                cartoupdate.Ability = Convert.ToString(cboAbility.SelectedItem);
                repository.UpdateCar(vin, cartoupdate);
                ResetData();
                MessageBox.Show("Car record successfully updated!", "S.H.I.E.L.D. Record Updated");
            }

            //else
            //{
            //    MessageBox.Show("Please select a record to update!", "S.H.I.E.L.D. Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }
        #endregion

        #region DeleteButton
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult t = MessageBox.Show("Are you sure you want to delete this record?", "Remove record from S.H.I.E.L.D. Directory", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (t == DialogResult.Yes)
            {
                var vin = dataCars.CurrentRow.Cells[0].Value;
                var cartodelete = repository.FindCar(vin.ToString());
                repository.DeleteCar(cartodelete);
                ResetData();
            }
          
        }
        #endregion

        #region SelectFromDataGridView
        private void dataCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0)
            {
                DataGridViewRow row = this.dataCars.Rows[e.RowIndex];
                txtVIN.Text = row.Cells["VIN"].Value.ToString();
                txtMake.Text = row.Cells["Make"].Value.ToString();
                txtModel.Text = row.Cells["Model"].Value.ToString();
                dateYear.Value = Convert.ToDateTime(row.Cells["Year"].Value.ToString());
                txtPrice.Text = row.Cells["Price"].Value.ToString();
                cboAbility.SelectedItem = row.Cells["Ability"].Value.ToString();
                txtVIN.ReadOnly = true;
            }
        }
        #endregion

        #region ExitProgram
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region MainMenu
        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formStart startForm = new formStart();
            startForm.Show();
            this.Hide();
        }
        #endregion

        #region InputValidations

        private void txtVIN_Leave(object sender, EventArgs e)
        {
            //requires the vin to be exactly 10 characters
            if (txtVIN.TextLength != 10)
            {
                MessageBox.Show("Please enter a VIN that is 10 exactly characters!", "Check VIN length", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtMake_Leave(object sender, EventArgs e)
        {
            //restricts the make to 20 characters or less
            if (txtMake.TextLength > 20)
            {
                MessageBox.Show("We don't drive cars with names that long!", "Check Make length", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtModel_Leave(object sender, EventArgs e)
        {
            //restricts the model to 20 characters or less
            if (txtModel.TextLength > 20)
            {
                MessageBox.Show("Abbreviate if you have to!", "Check Make length", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //restricts the textbox's accepted values to decimal numbers less than 100,000.
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar !='.') && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Price must only contain numbers and a decimal point!", "Currency values only", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            decimal price = 100000.00m;
            Decimal.TryParse(txtPrice.Text, out price);
            if (price > 100000.00m && txtPrice.Text !="")
            {
                MessageBox.Show("WHOA! We don't have the budget to pay that much for a car!", "Check your price, Agent.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void dateYear_Validating(object sender, CancelEventArgs e)
        {
            if (dateYear.Value.Year < 1925)
            {
                MessageBox.Show("That tech is ancient, Agent! Don't even bother adding it to the database.", "OLD TECH ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (dateYear.Value.Year > DateTime.Now.Year + 1)
            {
                MessageBox.Show("Time travel is NOT allowed! Agents are on the way to your location!", "TIME CRIME ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
