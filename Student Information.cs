using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPA_Calculation
{
    public partial class Form1 : Form
    {
        List<string> id = new List<string> { };
        List<string> name = new List<string> { };
        List<string> mobile = new List<string> { };
        List<string> age = new List<string> { };
        List<string> address = new List<string> { };
        List<string> gpapoint = new List<string> { };

        double gpapoint1 = 0;
        int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            try
            {
                displayRichTextBox.Text = "";
                top:
                if (idTextBox.Text == "" || nameTextBox.Text == "" || mobileTextBox.Text == "" ||
                    ageTextBox.Text == "" ||
                    addressTextBox.Text == "" || gpapointTextBox.Text == "")
                {
                    MessageBox.Show("Please enter all customer information");
                }
                else
                {
                    if (idTextBox.TextLength == 4)
                    {
                        if (id.Contains(idTextBox.Text))
                        {
                            MessageBox.Show("ID must be Unique");
                            idTextBox.Text = "";
                            goto top;

                        }
                    }
                    else
                    {
                        MessageBox.Show("ID must be 4 digit");
                        idTextBox.Text = "";
                        goto top;
                    }

                    if (nameTextBox.TextLength <= 30)
                    {
                        if (name.Contains(nameTextBox.Text))
                        {
                            MessageBox.Show("name must be Unique");
                            nameTextBox.Text = "";
                            goto top;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Name must be less than 30 character");
                        nameTextBox.Text = "";
                        goto top;

                    }

                    if (mobileTextBox.TextLength == 11)
                    {
                        if (mobile.Contains(mobileTextBox.Text))
                        {
                            MessageBox.Show("mobile number must be Unique");
                            mobileTextBox.Text = "";
                            goto top;

                        }

                    }
                    else
                    {
                        MessageBox.Show("mobile number must be 11 digit");
                        mobileTextBox.Text = "";
                        goto top;
                    }

                    gpapoint1 = Convert.ToDouble(gpapointTextBox.Text);

                    if (gpapoint1 >= 0 && gpapoint1 <= 4)
                    {
                        id.Add(idTextBox.Text);
                        name.Add(nameTextBox.Text);
                        mobile.Add(mobileTextBox.Text);
                        age.Add(ageTextBox.Text);
                        address.Add(addressTextBox.Text);
                        gpapoint.Add(gpapointTextBox.Text);
                    }
                    else
                    {
                        MessageBox.Show("GPA Point must be 0 to 4");
                        gpapointTextBox.Text = "";
                        goto top;

                    }

                    MessageBox.Show("Successfully Saved");

                    idTextBox.Text = "";
                    nameTextBox.Text = "";
                    mobileTextBox.Text = "";
                    ageTextBox.Text = "";
                    addressTextBox.Text = "";
                    gpapointTextBox.Text = "";
                    displayRichTextBox.SelectedText = Environment.NewLine + "Id                :" + id[i];
                    displayRichTextBox.SelectedText = Environment.NewLine + "Name              :" + name[i];
                    displayRichTextBox.SelectedText = Environment.NewLine + "Mobile            :" + mobile[i];
                    displayRichTextBox.SelectedText = Environment.NewLine + "Age               :" + age[i];
                    displayRichTextBox.SelectedText = Environment.NewLine + "Address           :" + address[i];
                    displayRichTextBox.SelectedText = Environment.NewLine + "GPA Point         :" + gpapoint[i];
                    displayRichTextBox.SelectedText = Environment.NewLine + "";
                    i++;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return;
            }

        }

        private void showallButton_Click(object sender, EventArgs e)
        {

            try
            {
                displayRichTextBox.Text = "";
                string x = "";
                double z = 0.0;
                maxTextBox.Text = gpapoint.Max();
                minTextBox.Text = gpapoint.Min();

                for (int j = 0; j < id.Count(); j++)
                {
                    x += "Id :" + id[j] + "\n" + "Name:" + name[j] + "\n" +
                         "Mobile             :" + mobile[j] + "\n" + "Age                 :" + age[j] + "\n" +
                         "Address            :" + address[j] + "\n" + "GPA Point                 :" + gpapoint[j] + "\n";
                    z += Convert.ToDouble(gpapoint[j]);
                    if (gpapoint[j] == maxTextBox.Text)
                    {
                        maxnameTextBox.Text = name[j];
                    }

                    if (gpapoint[j] == minTextBox.Text)
                    {
                        minnameTextBox.Text = name[j];
                    }

                }

                displayRichTextBox.SelectedText = Environment.NewLine + " " + x + "\n";
                avgTextBox.Text = (z / gpapoint.Count()).ToString();
                totalTextBox.Text = z.ToString();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return;
            }

           

        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            try
            {
                displayRichTextBox.Text = "";
                for (int j = 0; j < id.Count(); j++)
                {
                    if (idRadioButton.Checked == true)
                    {
                        if (idTextBox.Text == id[j])
                        {
                            displayRichTextBox.SelectedText = Environment.NewLine + "Id :               " + id[j];
                            displayRichTextBox.SelectedText = Environment.NewLine + "Name:              " + name[j];
                            displayRichTextBox.SelectedText = Environment.NewLine + "Mobile            :" + mobile[j];
                            displayRichTextBox.SelectedText = Environment.NewLine + "Age               :" + age[j];
                            displayRichTextBox.SelectedText = Environment.NewLine + "Address           :" + address[j];
                            displayRichTextBox.SelectedText = Environment.NewLine + "GPA Point         :" + gpapoint[j];
                            displayRichTextBox.SelectedText = Environment.NewLine + "";
                        }
                    }
                    else if (nameRadioButton.Checked == true)
                    {
                        if (nameTextBox.Text == name[j])
                        {
                            displayRichTextBox.SelectedText = Environment.NewLine + "Id :               " + id[j];
                            displayRichTextBox.SelectedText = Environment.NewLine + "Name:              " + name[j];
                            displayRichTextBox.SelectedText = Environment.NewLine + "Mobile            :" + mobile[j];
                            displayRichTextBox.SelectedText = Environment.NewLine + "Age               :" + age[j];
                            displayRichTextBox.SelectedText = Environment.NewLine + "Address           :" + address[j];
                            displayRichTextBox.SelectedText = Environment.NewLine + "GPA Point         :" + gpapoint[j];
                            displayRichTextBox.SelectedText = Environment.NewLine + "";
                        }
                    }
                    else if (mobileRadioButton.Checked == true)
                    {
                        if (mobileTextBox.Text == mobile[j])
                        {
                            displayRichTextBox.SelectedText = Environment.NewLine + "Id                :" + id[j];
                            displayRichTextBox.SelectedText = Environment.NewLine + "Name              :" + name[j];
                            displayRichTextBox.SelectedText = Environment.NewLine + "Mobile            :" + mobile[j];
                            displayRichTextBox.SelectedText = Environment.NewLine + "Age               :" + age[j];
                            displayRichTextBox.SelectedText = Environment.NewLine + "Address           :" + address[j];
                            displayRichTextBox.SelectedText = Environment.NewLine + "GPA Point         :" + gpapoint[j];
                            displayRichTextBox.SelectedText = Environment.NewLine + "";
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message); return;

            }

        }
    }
}
