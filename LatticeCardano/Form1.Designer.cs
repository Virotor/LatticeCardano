namespace LatticeCardano
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.fileNameOpen = new System.Windows.Forms.TextBox();
            this.nameKey = new System.Windows.Forms.TextBox();
            this.nameSave = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.choise = new System.Windows.Forms.CheckBox();
            this.start = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.valueSize = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.originalFile = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.encryptionFile = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.encryptionFile)).BeginInit();
            this.SuspendLayout();
            // 
            // fileNameOpen
            // 
            this.fileNameOpen.Location = new System.Drawing.Point(12, 12);
            this.fileNameOpen.Name = "fileNameOpen";
            this.fileNameOpen.Size = new System.Drawing.Size(146, 20);
            this.fileNameOpen.TabIndex = 0;
            // 
            // nameKey
            // 
            this.nameKey.Location = new System.Drawing.Point(12, 38);
            this.nameKey.Name = "nameKey";
            this.nameKey.Size = new System.Drawing.Size(146, 20);
            this.nameKey.TabIndex = 1;
            // 
            // nameSave
            // 
            this.nameSave.Location = new System.Drawing.Point(12, 64);
            this.nameSave.Name = "nameSave";
            this.nameSave.Size = new System.Drawing.Size(146, 20);
            this.nameSave.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Открыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(174, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Открыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 64);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Открыть";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // choise
            // 
            this.choise.AutoSize = true;
            this.choise.Checked = true;
            this.choise.CheckState = System.Windows.Forms.CheckState.Checked;
            this.choise.Location = new System.Drawing.Point(311, 12);
            this.choise.Name = "choise";
            this.choise.Size = new System.Drawing.Size(91, 17);
            this.choise.TabIndex = 6;
            this.choise.Text = "Шифрование";
            this.choise.UseVisualStyleBackColor = true;
            this.choise.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(289, 64);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 7;
            this.start.Text = "Начать";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.button4_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 659);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1280, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 111);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Minimum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(180, 45);
            this.trackBar1.TabIndex = 9;
            this.trackBar1.Value = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // valueSize
            // 
            this.valueSize.AutoSize = true;
            this.valueSize.Location = new System.Drawing.Point(199, 111);
            this.valueSize.Name = "valueSize";
            this.valueSize.Size = new System.Drawing.Size(13, 13);
            this.valueSize.TabIndex = 10;
            this.valueSize.Text = "5";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(22, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(441, 450);
            this.dataGridView1.TabIndex = 11;
            // 
            // originalFile
            // 
            chartArea1.Name = "ChartArea1";
            this.originalFile.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.originalFile.Legends.Add(legend1);
            this.originalFile.Location = new System.Drawing.Point(523, 174);
            this.originalFile.Name = "originalFile";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            this.originalFile.Series.Add(series1);
            this.originalFile.Size = new System.Drawing.Size(745, 212);
            this.originalFile.TabIndex = 12;
            this.originalFile.Text = "chart1";
            // 
            // encryptionFile
            // 
            chartArea2.Name = "ChartArea1";
            this.encryptionFile.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.encryptionFile.Legends.Add(legend2);
            this.encryptionFile.Location = new System.Drawing.Point(523, 405);
            this.encryptionFile.Name = "encryptionFile";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            this.encryptionFile.Series.Add(series2);
            this.encryptionFile.Size = new System.Drawing.Size(745, 219);
            this.encryptionFile.TabIndex = 12;
            this.encryptionFile.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(488, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.encryptionFile);
            this.Controls.Add(this.originalFile);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.valueSize);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.choise);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nameSave);
            this.Controls.Add(this.nameKey);
            this.Controls.Add(this.fileNameOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.encryptionFile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fileNameOpen;
        private System.Windows.Forms.TextBox nameKey;
        private System.Windows.Forms.TextBox nameSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox choise;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label valueSize;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart originalFile;
        private System.Windows.Forms.DataVisualization.Charting.Chart encryptionFile;
        private System.Windows.Forms.Label label1;
    }
}

