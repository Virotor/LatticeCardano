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
            if (choise.Checked)
            {
                LatticeCardano latticeCardano = new LatticeCardano(trackBar1.Value, pathToFileOpen, pathToFileSave, pathToKey);
                latticeCardano.InitCart(Takematrix());
                latticeCardano.EncryptionFile();
                latticeCardano.WriteKey();
            }
            else
            {
                LatticeCardano latticeCardano = new LatticeCardano(pathToFileOpen, pathToFileSave, pathToKey);
                latticeCardano.ReadKey();
                latticeCardano.DecipherFile();
                //latticeCardano.InitCart(new int[,] { { 1, 1, 0, 0 }, { 1, 1, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } });
                //latticeCardano.WriteKey();
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
           // dataGridView1.Rows.Add(trackBar1.Value);
            

        }

        private int[,] Takematrix()
        {
            var res = new int[trackBar1.Value, trackBar1.Value];
            for(int i=0; i < trackBar1.Value; i++)
            {
                for(int j = 0; j < trackBar1.Value; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value!=null)
                    {
                        res[i, j] = 1;
                    }
                }
            }
            return res;
        }
    }
}
