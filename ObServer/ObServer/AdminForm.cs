using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObServer
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
        }
        Users users = new Users();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string user = comboBoxEdit1.SelectedItem.ToString();
            if (user!=""&&user!=null)
            {
                comboBoxEdit1.Text = "";
                users.addObserver(user);
                listBox4.Items.Add(user);
                comboBoxEdit1.Properties.Items.Remove(user);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                string user = listBox4.SelectedItem.ToString();
                users.removeObserver(user);
                listBox4.Items.Remove(user);
                comboBoxEdit1.Properties.Items.Add(user);
            }
            catch (Exception)
            {
            }
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text==""||richTextBox1.Text==null)
            {
                XtraMessageBox.Show("Lütfen Mesajınızı Giriniz!", "Hata Mesajı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UserObserver userObserver = new UserObserver();
                userObserver.notify(richTextBox1.Text, listBox1.Items.Add, listBox2.Items.Add, listBox3.Items.Add);
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            comboBoxEdit1.Text = "";
        }
    }
}
