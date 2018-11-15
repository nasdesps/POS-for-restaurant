using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// The namespace of this project is Coursework.
namespace Coursework
{
    //This is the parent class and the name of this class is Main. This is a Windows Form Application class where C# language is used to program the system.
    public partial class Main : Form
    {
        //These are class variables
        private bool status = false;
        private int row = 0;
        Dictionary<string, int> salesChart = new Dictionary<string, int>();

        //constructor of this class where all components are initialized.
        public Main()
        {
            InitializeComponent();
        }

        /* private non-return type method which is triggered when importBtn button is clicked.
         * a windows dialog opens where user select the desirable menu in the format of .csv.
         */
        private void importBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            //To filter file format
            dialog.Filter = "Files(*.txt, *.csv)|*.txt;*.csv|All Files (.) |*.*";

            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string val = dialog.FileName;
                importCSV(val);
            }
        }

        /* this is a private non-return type method which is called when importBtn button is clicked
         * after the csv file is opened the details of csv file loads on datagrid view.
         */
        private void importCSV(string filepath)
        {
            try
            {
                //using Microsoft.VisualBasic.FieldIO;
                TextFieldParser csvreader = new TextFieldParser(filepath);

                //set delimeter for the reader to specific value(,)
                csvreader.SetDelimiters(new string[] { "," });

                //csvreader.HasFieldsEnclosedInQuotes = true;
                string[] colFields = csvreader.ReadFields();

                while (!csvreader.EndOfData)
                {
                    string[] fielddata = csvreader.ReadFields();//read all fields of current line

                    //Displaying data from CSV file to gridView
                    for (int i = 1; i == 1;  i++)
                    {
                        int count = menuGrid.Rows.Count;
                        //Console.WriteLine(count);
                        menuGrid.Rows.Add();
                        for (int a = 0; a < fielddata.Length; a++)
                        {
                            menuGrid.Rows[count].Cells[a].Value = fielddata[a];
                            //gridView.Rows[count].Selected = true;
                        }
                        break;
                    }       
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Import CSV File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /* private non-return type method which is triggered when saveBtn button is clicked.
         * user can manually add menu in the datagridview by filling up all the details that are name, category and price.
         */ 
        private void saveBtn_Click(object sender, EventArgs e)
        {
            string name = Convert.ToString(fdname_txtbox.Text);
            string category = Convert.ToString(categorytxt.Text);
            string price = Convert.ToString(price_txtbox.Text);
            if (name != "" && category != "" && price != "")
            {
                if (this.status)
                {
                    menuGrid.Rows[this.row].Cells[0].Value = name;
                    menuGrid.Rows[this.row].Cells[1].Value = category;
                    menuGrid.Rows[this.row].Cells[2].Value = price;

                    MessageBox.Show("Record has been updated.");
                }
                else
                {
                    int count = menuGrid.Rows.Count;
                    menuGrid.Rows.Add();
                    menuGrid.Rows[count].Cells[0].Value = name;
                    menuGrid.Rows[count].Cells[1].Value = category;
                    menuGrid.Rows[count].Cells[2].Value = price;

                    MessageBox.Show("Record has been saved.");
                }
                fdname_txtbox.Text = "";
                categorytxt.Text = "";
                price_txtbox.Text = "";
                this.status = false;
                this.row = 0;
            }
            else 
            {
                MessageBox.Show("Field must not be empty.");
            }

        }

        /* this is a private non-return type method which is triggered when deleteBtn button is clicked.
         * user can delete an item in the menu stored in datagridview.
         */ 
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int selectedRow = menuGrid.CurrentCell.RowIndex;
            if (selectedRow >= 0)
            {
                menuGrid.Rows.RemoveAt(selectedRow);
                //gridview.Refresh();
            }
        }

        /* this is a private non-return type method which is triggered when item in menuGrid datagridview is doubleclicked.
         * the item details of food item in menuGrid is transferred to fields in order item.
        */
        private void menuGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string orderName = Convert.ToString(menuGrid.Rows[e.RowIndex].Cells[0].Value);
            string orderCategory = Convert.ToString(menuGrid.Rows[e.RowIndex].Cells[1].Value);
            string orderPrice = Convert.ToString(menuGrid.Rows[e.RowIndex].Cells[2].Value);
            if (orderName != "" && orderCategory != "" && orderPrice != "")
            {
                this.row = e.RowIndex;
                txtNameOrder.Text = orderName;
                txtCategoryOrder.Text = orderCategory;
                txtPriceOrder.Text = orderPrice;
                txtQuantityOrder.Text = "1";
            }
        }

        /* this is a private non-return type method which is triggered when orderBtn button is clicked.
         * the ordered item is ordered which is displayed in orderGrid datagridview. 
         */
        private void orderBtn_Click(object sender, EventArgs e)
        {
            string editname = Convert.ToString(txtNameOrder.Text);
            string editcategory = Convert.ToString(txtCategoryOrder.Text);
            string editquantity = Convert.ToString(txtQuantityOrder.Text);
            string editprice = Convert.ToString(txtPriceOrder.Text);

            if (editname != "" && editcategory != "" && editquantity != "" && editprice != "")
            {
                if (this.status)
                {
                    orderGrid.Rows[this.row].Cells[0].Value = editname;
                    orderGrid.Rows[this.row].Cells[1].Value = editcategory;
                    orderGrid.Rows[this.row].Cells[2].Value = editquantity;
                    orderGrid.Rows[this.row].Cells[3].Value = Convert.ToInt16(editprice) * Convert.ToInt16(editquantity);

                    MessageBox.Show("Record has been updated.");
                }
                else
                {
                    int count = orderGrid.Rows.Count;
                    orderGrid.Rows.Add();
                    orderGrid.Rows[count].Cells[0].Value = editname;
                    orderGrid.Rows[count].Cells[1].Value = editcategory;
                    orderGrid.Rows[count].Cells[2].Value = editquantity;
                    orderGrid.Rows[count].Cells[3].Value = Convert.ToInt16(editprice) * Convert.ToInt16(editquantity);

                }
                txtNameOrder.Text = "";
                txtCategoryOrder.Text = "";
                txtQuantityOrder.Text = "";
                txtPriceOrder.Text = "";
                this.status = false;
                this.row = 0;
            }
            else
            {
                MessageBox.Show("Field must not be empty.");
            }
        }

        /* this is a private non-return type method which is triggered when calculateBtn button is clicked.
         * the foods price displayed in orderGrid datagridview is calculated and is displayed in txtCalculate textfield.
         */ 
        private void calculateBtn_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int count = orderGrid.Rows.Count - 1;
            for (int i = 0; i <= count; i++)
            {
                int price = Convert.ToInt32(orderGrid.Rows[i].Cells[3].Value);
                sum = sum + price;
            }
            string total = Convert.ToString(sum);
            txtCalculate.Text = total;
        }

        /* this is a private non-return type method which is triggered when orderDeleteBtn button is clicked.
         * the foods stored in orderGrid is deleted when orderDeleteBtn button is clicked.
         */ 
        private void orderDeleteBtn_Click(object sender, EventArgs e)
        {
            int selectedRow = orderGrid.CurrentCell.RowIndex;
            if (selectedRow >= 0)
            {
                orderGrid.Rows.RemoveAt(selectedRow);
            }
        }

        /* this is a private non-return type method which is triggered when chartBtn button is clicked.
         * a pie-chart is generated which shows the details of food item sold.
         */
        private void chartBtn_Click(object sender, EventArgs e)
        {
            salesChartData();
            Chart chart = new Chart(salesChart);
            chart.ShowDialog();
        }

        //this is a private non-return type method which is called when chartBtn button is clicked.
        private void salesChartData()
        {
            int count = orderGrid.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                string category = Convert.ToString(orderGrid.Rows[i].Cells[1].Value);
                int price = Convert.ToInt16(orderGrid.Rows[i].Cells[3].Value);
                if (salesChart.ContainsKey(category))
                {
                    int value = salesChart[category];

                    int total = value + price;

                    salesChart[category] = total;
                }
                else
                {
                    salesChart.Add(category, price);
                }
            }
        }

        /* this is a private non-return type method which is triggered when sortNameBtn button is clicked.
         * bubble sorting algorithm is used to sort food name by price.
         */
        private void sortNameBtn_Click(object sender, EventArgs e)
        {
            int rows = menuGrid.Rows.Count;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 1; j < rows; j++)
                {
                    string firstFoodName = Convert.ToString(menuGrid.Rows[j - 1].Cells[0].Value);
                    string secondFoodName = Convert.ToString(menuGrid.Rows[j].Cells[0].Value);

                    if (string.Compare(firstFoodName, secondFoodName) > 0)
                    {
                        for (int c = 0; c < menuGrid.Columns.Count; c++)
                        {
                            object temp = menuGrid[c, j - 1].Value;
                            menuGrid[c, j - 1].Value = menuGrid[c, j].Value;
                            menuGrid[c, j].Value = temp;
                        }
                    }
                }
            }
        }

        /* this is a private non-return type method which is triggered when sortNameBtn button is clicked.
         * bubble sorting algorithm is used to sort food by price.
         */
        private void sortPriceBtn_Click(object sender, EventArgs e)
        {
            int rows = menuGrid.Rows.Count;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 1; j < rows; j++)
                {
                    string firstItemPrice = Convert.ToString(menuGrid.Rows[j - 1].Cells[2].Value);
                    string secondItemPrice = Convert.ToString(menuGrid.Rows[j].Cells[2].Value);

                    if (Int16.Parse(firstItemPrice) > Int16.Parse(secondItemPrice))
                    {
                        for (int c = 0; c < menuGrid.Columns.Count; c++)
                        {
                            object temp = menuGrid[c, j - 1].Value;
                            menuGrid[c, j - 1].Value = menuGrid[c, j].Value;
                            menuGrid[c, j].Value = temp;
                        }
                    }
                }
            }
        }

        
    }

}
