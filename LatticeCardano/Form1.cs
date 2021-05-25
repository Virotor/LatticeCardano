using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatticeCardano
{
    public partial class Form1 : Form
    {

        private string pathToFileOpen = "";
        private string pathToKey = "";
        private string pathToFileSave = "";

        public Form1()
        {
            InitializeComponent();
        }


        private string OpenFile()
        {
            string dirPath = "";
            using (var openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    dirPath = openFileDialog.FileName;
                }
            }

            return dirPath;
        }

        private string SaveFile()
        {
            string dirPath = "";
            using (var openFileDialog = new SaveFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    dirPath = openFileDialog.FileName;
                }
            }

            return dirPath;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            pathToFileOpen = OpenFile();
            fileNameOpen.Text = pathToFileOpen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!choise.Checked)
            {
                pathToKey = OpenFile();
                nameKey.Text = pathToKey;
            }
            else
            {
                pathToKey = SaveFile();
                nameKey.Text = pathToKey;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pathToFileSave = SaveFile();
            nameSave.Text = pathToFileSave;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LatticeCardano latticeCardano;
            try
            {
                label1.Text = "";
                if (choise.Checked)
                {
                    latticeCardano = new LatticeCardano(trackBar1.Value, pathToFileOpen, pathToFileSave, pathToKey);
                    latticeCardano.InitCart(Takematrix());
                    if (latticeCardano.IsCheckedCart())
                    {
                        latticeCardano.EncryptionFile();
                        latticeCardano.WriteKey();
                    }
                }
                else
                {
                    latticeCardano = new LatticeCardano(pathToFileOpen, pathToFileSave, pathToKey);
                    latticeCardano.ReadKey();
                    latticeCardano.DecipherFile();
                }
                var resultForCharts = latticeCardano.TakeFrequencySymbol();

                ChartFrequence(resultForCharts);
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }


        private void ChartFrequence(Dictionary<string, List<long>> frequence) {

            encryptionFile.Legends[0].Enabled = false;
            originalFile.Legends[0].Enabled = false;
            var _ = frequence[frequence.Keys.Last()];
            encryptionFile.Series[0].Points.Clear();
            for(int i = 0; i < 255; i++)
            {
                encryptionFile.Series[0].Points.AddXY(Convert.ToChar(i).ToString(), _[i]);
            }


             _ = frequence[frequence.Keys.First()];
            originalFile.Series[0].Points.Clear();
            for (int i = 0; i < 255; i++)
            {
                originalFile.Series[0].Points.AddXY(Convert.ToChar(i).ToString(), _[i]);
            }
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            valueSize.Text = trackBar1.Value.ToString();
            ChangeGrid();
        }


        private void ChangeGrid()
        {
            dataGridView1.ColumnCount = trackBar1.Value;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridView1.RowCount = trackBar1.Value;
        }

        private int[,] Takematrix()
        {
            bool isEmpty = true;
            if(dataGridView1.Rows.Count < 1)
            {
                throw new Exception("Решётка не задана, задайте, пожалуйста, решётку");
            }
            var res = new int[trackBar1.Value, trackBar1.Value];
            for(int i=0; i < trackBar1.Value; i++)
            {
                for(int j = 0; j < trackBar1.Value; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value!=null)
                    {
                        res[i, j] = 1;
                        isEmpty = false;
                    }
                }
            }
            if (isEmpty)
            {
                throw new Exception("Решётка не задана");
            }
            return res;
        }
    }
}
