using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Kevin Morgan Dev Test Form

namespace KMDevTest
{
    public partial class Form1 : Form
    {
        //This global integer will control the 2D array that stores client information.
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nameEnter_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void phonelabel_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            //When submit is pressed, data is processed.
            //2D Array is created to store up to 10 customer's data.
            string[,] custData = new string[10,5];

            //Data is entered. Each "pass" is stored on the next array in line. 
            custData[count,0] = nameEnter.Text;
            custData[count, 1] = address.Text;
            custData[count, 2] = email.Text;
            custData[count, 3] = phone.Text;
            custData[count, 4] = "0";

            //Hides and clears customer data entry fields until "Add New" is pressed again.
            nameEnter.Visible = false;
            namelabel.Visible = false;
            nameEnter.Clear();

            address.Visible = false;
            addresslabel.Visible = false;
            address.Clear();

            email.Visible = false;
            emaillabel.Visible = false;
            email.Clear();

            phone.Visible = false;
            phonelabel.Visible = false;
            phone.Clear();

            Submit.Visible = false;

            //Adds customer name to form drop down menues to modify data.
            orderHistory.Items.Add(custData[count,0]);
            custEdit.Items.Add(custData[count, 0]);

            //int i and for loop add customer data to the correct array block.
            int i = 0;
            for (; i < 5; i++)
            {
                 custListBox.Text += custData[count, i] + ", " ;
                 
                //Begins new array when customer data is entered.
                if (i == 5)
                {
                    i = 0;
                    
                }

            }
            //New customer data is entered on a new line and count increases to move to next array.
            custListBox.Text += Environment.NewLine;
            count++;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void orderHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Placeholder message in Order History until functionality is added.
            MessageBox.Show("Order History For This Customer Coming Soon!");
        }

        private void custEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Placeholder message in Edit Customer until functionality is added.
            MessageBox.Show("Edit Customer Coming Soon!");
        }

        private void showInventory_Click(object sender, EventArgs e)
        {
            //Placeholder message in Show Inventory until functionality is added.
            MessageBox.Show("Item\tPrice\tQuantity\nRed1\t$4.99\t3\nBlue1\t$5.50\t4\n\nFurther Functionality Coming Soon!");
        }

        private void addNewCust_Click(object sender, EventArgs e)
        {
            //Fields for customer data entry appear when "add new" is pressed.
            nameEnter.Visible = true;
            namelabel.Visible = true;

            address.Visible = true;
            addresslabel.Visible = true;

            email.Visible = true;
            emaillabel.Visible = true;

            phone.Visible = true;
            phonelabel.Visible = true;

            Submit.Visible = true;
        }
    }
}
