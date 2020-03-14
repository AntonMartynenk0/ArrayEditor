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
using System.Runtime.Serialization.Formatters.Binary;


namespace ArrayEditor
{
    public partial class Form1 : Form
    {
        List<MasData> Mas = new List<MasData>();
        int N, range_min, range_max, value = 0, count = 0;

        public Form1()
        {
            InitializeComponent();
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            if (Mas != null)
            {
                var table = new DataTable("Array");
                var count = new DataColumn("i");
                var value = new DataColumn("a[i]");

                table.Columns.Add(count);
                table.Columns.Add(value);

                foreach (MasData element_of_mas in Mas)
                {
                    DataRow row = table.NewRow();
                    row["i"] = element_of_mas.count;
                    row["a[i]"] = element_of_mas.value;
                    table.Rows.Add(row);
                }
                dataGridView1.DataSource = table;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button_generate_Click(object sender, EventArgs e)
        {
            Mas.Clear();
            if (numericUpDown_range_min.Value > numericUpDown_range_max.Value)
            {
                decimal additional;
                additional = numericUpDown_range_min.Value;
                numericUpDown_range_min.Value = numericUpDown_range_max.Value;
                numericUpDown_range_max.Value = additional;
            }
            if (textBox_basic_array.Text != "")
            {
                textBox_basic_array.Clear();
            }
            range_min = Convert.ToInt32(numericUpDown_range_min.Value);
            range_max = Convert.ToInt32(numericUpDown_range_max.Value);
            Random rand = new Random();
            for (int i = 0; i < N; i++)
            {
                value = rand.Next(range_min, range_max + 1);
                count = i;
                Mas.Add(new MasData()
                {
                    value = this.value,
                    count = this.count
                });
                textBox_basic_array.Text += this.value + " ";
            }
            UpdateGrid();
        }


        private void Serialize(string name)
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<MasData>));
            using (FileStream fs = new FileStream(name, FileMode.Create))
            {
                xml.Serialize(fs, Mas);
            }
        }

        private List<MasData> DeSerialize(string name)
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<MasData>));

            using (FileStream fs = new FileStream(name, FileMode.Open))
            {
                return (List<MasData>)xml.Deserialize(fs);
            }
        }

        private void button_save_f1_Click(object sender, EventArgs e)
        {
            saveFileDialogF2.FileName = "F1";
            if (saveFileDialogF1.ShowDialog() == DialogResult.OK)
            {
                string NameOfFile = Convert.ToString(saveFileDialogF1.FileName);
                Serialize(NameOfFile);
            }
        }
        private void button_save_f2_Click(object sender, EventArgs e)
        {
            saveFileDialogF2.FileName = "F2";
            if (saveFileDialogF2.ShowDialog() == DialogResult.OK)
            {
                string NameOfFile = Convert.ToString(saveFileDialogF2.FileName);
                Serialize(NameOfFile);
            }
        }

        private void button_open_f1_Click(object sender, EventArgs e)
        {
                openFileDialogF2.FileName = "F1";
            if (openFileDialogF1.ShowDialog() == DialogResult.OK)
            {
                string NameOfFile = openFileDialogF1.FileName;
                UpdateGrid();
                dataGridView1.Columns.Clear();
                List<MasData> Mas = DeSerialize(NameOfFile);
                var table = new DataTable("Array");
                var count = new DataColumn("i");
                var value = new DataColumn("a[i]");

                table.Columns.Add(count);
                table.Columns.Add(value);

                foreach (MasData element_of_mas in Mas)
                {
                    DataRow row = table.NewRow();
                    row["i"] = element_of_mas.count;
                    row["a[i]"] = element_of_mas.value;
                    table.Rows.Add(row);
                }
                dataGridView1.DataSource = table;
            }
        }
        private void button_open_f2_Click(object sender, EventArgs e)
        {
            openFileDialogF2.FileName = "F2";
            if (openFileDialogF2.ShowDialog() == DialogResult.OK)
            {                
                string NameOfFile = openFileDialogF2.FileName;
                UpdateGrid();
                dataGridView1.Columns.Clear();
                List<MasData> Mas = DeSerialize(NameOfFile);
                var table = new DataTable("Array");
                var count = new DataColumn("i");
                var value = new DataColumn("a[i]");

                table.Columns.Add(count);
                table.Columns.Add(value);

                foreach (MasData element_of_mas in Mas)
                {
                    DataRow row = table.NewRow();
                    row["i"] = element_of_mas.count;
                    row["a[i]"] = element_of_mas.value;
                    table.Rows.Add(row);
                }
                dataGridView1.DataSource = table;
            }
        }

        private void numericUpDown_size_ValueChanged(object sender, EventArgs e)
        {
            N = Convert.ToInt32(numericUpDown_size.Value);
        }
        private void numericUpDown_range_max_ValueChanged(object sender, EventArgs e)
        {
            range_max = Convert.ToInt32(numericUpDown_range_max.Value);
        }
        private void numericUpDown_range_min_ValueChanged(object sender, EventArgs e)
        {
            range_min = Convert.ToInt32(numericUpDown_range_min.Value);
        }
    }
}
