using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace Student_Info_Database_Creator
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        StudentsToXML database = null;
        //StudentsToXML databaseCopy = null;
        private bool isChanged;
        BindingSource bs = new BindingSource();
        //private bool same;

        public Form1()
        {
            InitializeComponent();
            timer.Start();
            timer.Tick += Timer_Tick;
            tsslTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tsslTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены?", "Info", MessageBoxButtons.YesNo) == DialogResult.Yes) this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (database != null)
            {
                if (tbName.Text != "" && tbUniver.Text != "" && tbFaculty.Text != "" && tbDepart.Text != "" && tbAge.Text != "" && tbCourse.Text != "" && tbGroupe.Text != "" && tbCity.Text != "")
                {
                    bool correct = false;
                    do
                    {
                        try
                        {
                            bs.AddNew();
                            bs.MoveNext();
                            ClearText();
                            isChanged = true;
                            correct = true;
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Проверьте правильность введенных данных", "Info", MessageBoxButtons.OK);
                            correct = false;
                            return;
                        }
                    }
                    while (!correct);
                }
                else
                {
                    MessageBox.Show("Проверьте, все ли поля заполнены", "Info", MessageBoxButtons.OK);
                }
            } else
            {
                MessageBox.Show("Создайте или откройте файл для базы данных", "Info", MessageBoxButtons.OK);
            }
        }

        private void ClearText()
        {
            tbName.Text = "";
            tbUniver.Text = "";
            tbFaculty.Text = "";
            tbDepart.Text = "";
            tbAge.Text = "";
            tbCourse.Text = "";
            tbGroupe.Text = "";
            tbCity.Text = "";
        }

        private void BindingData()
        {
            bs.DataSource = database;
            bs.DataMember = "List";
            DGV.DataSource = bs;
            UnbindingData();
            tbName.DataBindings.Add("Text", bs, "FIO");
            tbUniver.DataBindings.Add("Text", bs, "Univercity");
            tbFaculty.DataBindings.Add("Text", bs, "Faculty");
            tbDepart.DataBindings.Add("Text", bs, "Department");
            tbAge.DataBindings.Add("Text", bs, "Age");
            tbCourse.DataBindings.Add("Text", bs, "Course");
            tbGroupe.DataBindings.Add("Text", bs, "Group");
            tbCity.DataBindings.Add("Text", bs, "City");
            bindingNavigator1.BindingSource = bs;
        }

        private void UnbindingData()
        {
            tbName.DataBindings.Clear();
            tbUniver.DataBindings.Clear();
            tbFaculty.DataBindings.Clear();
            tbDepart.DataBindings.Clear();
            tbAge.DataBindings.Clear();
            tbCourse.DataBindings.Clear();
            tbGroupe.DataBindings.Clear();
            tbCity.DataBindings.Clear();
        }
        
        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isChanged)
            {
                if (MessageBox.Show("Сохранить изменения в текущей базе?", "Info", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    database.Save();
                }
            }
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Только *.XML|*.XML|All files|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                tsslCurrentFile.Text = Path.GetFileName(dialog.FileName);
                database = new StudentsToXML(dialog.FileName);
                BindingData();
                isChanged = true;
                bs.AddNew();
            };
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isChanged)
            {
                if (MessageBox.Show("Сохранить изменения в текущей базе?", "Info", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    database.Save();
                }
            }
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Только *.XML|*.XML|All files|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                tsslCurrentFile.Text = Path.GetFileName(dialog.FileName);
                database = new StudentsToXML(dialog.FileName);
                database.Load();
                isChanged = true;
                BindingData();
            };
        }

        private void CreditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Credits about = new Credits();
            about.ShowDialog();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            database.Save();
            isChanged = false;
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Только *.XML|*.XML|All files|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                tsslCurrentFile.Text = Path.GetFileName(dialog.FileName);
                database.FileName = tsslCurrentFile.Text;
                database.Save();
                isChanged = false;
            };
        }
    }
}
