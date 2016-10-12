using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace so_thu_sai_gon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mmuClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblThoiGian.Text = string.Format("Bây giờ là {0}:{1}:{2} ngày {3} tháng {4} năm {5}",
                                                             DateTime.Now.Hour,
                                                             DateTime.Now.Minute,
                                                             DateTime.Now.Second,
                                                             DateTime.Now.Day,
                                                             DateTime.Now.Month,
                                                             DateTime.Now.Year);

        }

        private void mmuLoad_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("thumoi.txt");
            if (reader == null) return;
            string input = null;
            while ((input = reader.ReadLine())!=null)
            {
                lstThuMoi.Items.Add(input);
            }
            reader.Close();

        
         using(StreamReader rs = new StreamReader ("danhsachthu.txt"))
         {
           input = null;
            while ((input = rs.ReadLine())!=null)
                lstDanhSach.Items.Add(input);

         }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("danhsachthu.txt");
            if (writer == null) return;
            foreach (var item in lstDanhSach.Items)
                writer.WriteLine(item.ToString());
            writer.Close();
        }
        private void ListBox_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox lb = (ListBox)sender;
            for (int i = 0; i < lb.Items.Count; i++)
            {
                if (lb.GetSelected(i))
                {
                    lb.DoDragDrop(lb.Text, DragDropEffects.Copy);
                }
            }
        }
        private void ListBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void lstThuMoi_DragDrop(object sender, DragEventArgs e)
        {
            lstDanhSach.Items.Remove((string)e.Data.GetData(DataFormats.Text));
            lstThuMoi.Items.Add((string)e.Data.GetData(DataFormats.Text));
        }

        private void lstDanhSach_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            lstDanhSach.Items.Add((string)e.Data.GetData(DataFormats.Text));
            lstThuMoi.Items.Remove((string)e.Data.GetData(DataFormats.Text));
        }
    }
}
