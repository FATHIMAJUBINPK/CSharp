using System;
using System.IO;
using System.Collections.Generic;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace TodoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> tasks = new List<string>();
        string filePath = "tasks.txt";

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTask.Text))
            {
                tasks.Add(txtTask.Text);
                listBoxTasks.Items.Add(txtTask.Text);
                txtTask.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a task.");
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllLines(filePath, tasks);
                MessageBox.Show("Tasks saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving file: " + ex.Message);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    tasks.Clear();
                    listBoxTasks.Items.Clear();

                    tasks.AddRange(File.ReadAllLines(filePath));

                    foreach (string task in tasks)
                    {
                        listBoxTasks.Items.Add(task);
                    }
                }
                else
                {
                    MessageBox.Show("No saved tasks found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading file: " + ex.Message);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex != -1)
            {
                int index = listBoxTasks.SelectedIndex;

                tasks.RemoveAt(index);
                listBoxTasks.Items.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Please select a task to delete.");
            }
        }
 

    }
}
