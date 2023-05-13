﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Form
{
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
        }

        private void AddStudentBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Students addStudents = new Add_Students();
            addStudents.ShowDialog();
        }
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
            }
        }

        private void StudentRecordsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentRecordsForm studentRecordsForm = new StudentRecordsForm();
            studentRecordsForm.ShowDialog();
        }

        private void SearchStudentBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchStudentForm searchStudentForm = new SearchStudentForm();
            searchStudentForm.ShowDialog();
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminSettingsForm adminSettingsForm = new AdminSettingsForm();
            adminSettingsForm.ShowDialog();
        }
    }
}
