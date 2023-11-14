using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace FrmOpenTextFile
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string docName = txtStudentNo.Text + ".txt";
            string docPath =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string[] userInfo =
                {
                    "Student No. : " + txtStudentNo.Text,
                    "\nFull Name : " + txtLastname.Text + ", " + txtFirstname.Text + " "
                    + txtMI.Text + ".",
                    "\nProgram : " + cbProgram.Text,
                    "\nGender : " + cbGender.Text,
                    "\nAge : " + txtAge.Text,
                    "\nBirthday : " + dtpBirthday.Text,
                    "\nContact No. : " + txtContactNo.Text
                };

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, docName)))
            {
                foreach (string info in userInfo)
                {
                    outputFile.WriteLine(info);
                }

            }

            
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[]
                {
                    "BS Information Technology",
                    "BS Computer Science",
                    "BS Information System",
                    "BS in Accountancy",
                    "BS in Hospitality Management",
                    "BS in Tourism Management"
                };

            for (int i = 0; i < 6; i++)
            {
                cbProgram.Items.Add(ListOfProgram[i].ToString());
            }

            string[] ListOfGender = new string[]
                {
                    "Male",
                    "Female"
                };

            for (int i = 0; i < 2; i++)
            {
                cbGender.Items.Add(ListOfGender[i].ToString());
            }
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            FrmStudentRecord studRecords = new FrmStudentRecord();
            studRecords.ShowDialog();
            Close();
        }
    }
}
