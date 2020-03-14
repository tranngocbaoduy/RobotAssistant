using RobotAssistant.Model;
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

namespace RobotAssistant
{
    public partial class Form1 : Form
    {
        public static ArrayList listDoctor { get; set; }

        public Doctor doctorSelected { get; set; }

        //Constructor
        public Form1()
        {
            InitializeComponent();
            Form1.listDoctor = new ArrayList(); // khởi tạo mảng Doctor 
            CreateDataDoctor(); // tạo dữ liệu mẫu cho Doctor
            InitListView();
            LoadDoctor(); // load dữ liệu mẫu lên trên cái list view
        }

        public void InitListView()
        {
            lvDoctor.Columns.Add("No.");
            lvDoctor.Columns.Add("Id");
            lvDoctor.Columns.Add("Name");
            lvDoctor.Columns.Add("Phone");
            lvDoctor.Columns.Add("Address");
            lvDoctor.AutoArrange = true;
            lvDoctor.GridLines = true;
            lvDoctor.FullRowSelect = true;

            // view thành từng cột
            lvDoctor.View = View.Details;
        }

        // load list doctor lên interface
        public void LoadDoctor()
        {
            lvDoctor.Items.Clear();
            // tạo ra sub item 
            // ví dụ 3 doctor -> 0, 1, 2 
            Doctor temp;
            for (int i = 0; i < Form1.listDoctor.Count; i++)
            {
                ListViewItem subItem = new ListViewItem();
                temp = (Doctor)Form1.listDoctor[i];
                subItem.Text = i.ToString();
                subItem.SubItems.Add(temp.id.ToString());
                subItem.SubItems.Add(temp.name.ToString());
                subItem.SubItems.Add(temp.phone.ToString());
                subItem.SubItems.Add(temp.address.ToString());
                lvDoctor.Items.Add(subItem);
            }
        }

        public void CreateDataDoctor()
        {
            // tạo ra các Doctor
            Doctor d1 = new Doctor("0001", "Doctor 1", "1234565789", "123 Greenwich U");
            Doctor d2 = new Doctor("0002", "Doctor 2", "1234565789", "123 Greenwich U");
            Doctor d3 = new Doctor("0003", "Doctor 3", "1234565789", "123 Greenwich U");
            Doctor d4 = new Doctor("0004", "Doctor 4", "1234565789", "123 Greenwich U");

            // add vào list 
            listDoctor.Add(d1);
            listDoctor.Add(d2);
            listDoctor.Add(d3);
            listDoctor.Add(d4);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDoctor formAddDoctor = new AddDoctor("add");
            formAddDoctor.ShowDialog();
            if(AddDoctor.doctor!= null)
            {
                Doctor d = new Doctor(AddDoctor.doctor);
                // value type: int, double, char, string, boolean
                // reference type: Doctor, Patient, ...

                //AddDoctor.doctor; trong bộ nhớ address : 123
                //d trong bộ nhớ address: 234
                //d= AddDoctor.doctor; address của d = address của AddDoctor.doctor;

                if (string.IsNullOrEmpty(d.id.ToString()) || string.IsNullOrEmpty(d.phone.ToString()) || string.IsNullOrEmpty(d.name.ToString()) || string.IsNullOrEmpty(d.address.ToString()))
                {
                    // không có gì thay đổi vì thông tin nhập vào không đầy dủ
                }
                else
                {
                    listDoctor.Add(d);
                    MessageBox.Show("Add successful");
                    LoadDoctor();
                }
            } 
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lsv = sender as ListView;
            if (lsv.SelectedItems.Count == 1)
            {
                ListViewItem item = lsv.SelectedItems[0];
                int index = Convert.ToInt32(item.Text);
                doctorSelected = (Doctor)Form1.listDoctor[index]; 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AddDoctor formUpdate = new AddDoctor("update");
            int index = Form1.listDoctor.IndexOf(this.doctorSelected);
            AddDoctor.doctor.id = doctorSelected.id;
            AddDoctor.doctor.name = doctorSelected.name;
            AddDoctor.doctor.phone = doctorSelected.phone;
            AddDoctor.doctor.address = doctorSelected.address;
            formUpdate.ShowDialog();

            Doctor d = (Doctor)listDoctor[index];
            d.id = AddDoctor.doctor.id;
            d.name = AddDoctor.doctor.name;
            d.address = AddDoctor.doctor.address;
            d.phone = AddDoctor.doctor.phone;
            AddDoctor.doctor = null;
            LoadDoctor();
            MessageBox.Show("Update successful"); 
        }

        private void btnRemoveDoctor_Click(object sender, EventArgs e)
        { 
            Form1.listDoctor.Remove(this.doctorSelected);
            LoadDoctor();
            MessageBox.Show("Delete successful");
        }
    }
}
