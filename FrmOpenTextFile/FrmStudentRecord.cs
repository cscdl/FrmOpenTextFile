﻿using System;
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
    public partial class FrmStudentRecord : Form
    {
        public FrmStudentRecord()
        {
            InitializeComponent();
        }

        private void DisplayToList()
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            string path = openFileDialog1.FileName;

            using (StreamReader streamReader = File.OpenText(path))
            {
                string _getText = "";
                while ((_getText = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(_getText);
                    lvShowText.Items.Add(_getText);
                }
            }
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            DisplayToList();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Uploaded!");
            lvShowText.Items.Clear();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmRegistration registration = new FrmRegistration();
            registration.ShowDialog();
            
        }

        private void FrmStudentRecord_Load(object sender, EventArgs e)
        {

        }
    }
}
