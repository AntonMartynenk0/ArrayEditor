namespace ArrayEditor
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_size = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_range_min = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_range_max = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_basic_array = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox_Operations = new System.Windows.Forms.GroupBox();
            this.radioButtonOperation4 = new System.Windows.Forms.RadioButton();
            this.radioButtonOperation3 = new System.Windows.Forms.RadioButton();
            this.radioButtonOperation2 = new System.Windows.Forms.RadioButton();
            this.radioButtonOperation1 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_open_f2 = new System.Windows.Forms.Button();
            this.button_open_f1 = new System.Windows.Forms.Button();
            this.button_save_f2 = new System.Windows.Forms.Button();
            this.button_save_f1 = new System.Windows.Forms.Button();
            this.button_generate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialogF1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogF1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogF2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogF2 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_range_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_range_max)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox_Operations.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(334, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "От:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(488, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "До:";
            // 
            // numericUpDown_size
            // 
            this.numericUpDown_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_size.Location = new System.Drawing.Point(229, 14);
            this.numericUpDown_size.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown_size.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDown_size.Name = "numericUpDown_size";
            this.numericUpDown_size.Size = new System.Drawing.Size(77, 29);
            this.numericUpDown_size.TabIndex = 1;
            this.numericUpDown_size.ValueChanged += new System.EventHandler(this.numericUpDown_size_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Размерность массива";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(197, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "N:";
            // 
            // numericUpDown_range_min
            // 
            this.numericUpDown_range_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_range_min.Location = new System.Drawing.Point(376, 14);
            this.numericUpDown_range_min.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown_range_min.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDown_range_min.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.numericUpDown_range_min.Name = "numericUpDown_range_min";
            this.numericUpDown_range_min.Size = new System.Drawing.Size(104, 29);
            this.numericUpDown_range_min.TabIndex = 8;
            this.numericUpDown_range_min.ValueChanged += new System.EventHandler(this.numericUpDown_range_min_ValueChanged);
            // 
            // numericUpDown_range_max
            // 
            this.numericUpDown_range_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_range_max.Location = new System.Drawing.Point(530, 14);
            this.numericUpDown_range_max.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown_range_max.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDown_range_max.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.numericUpDown_range_max.Name = "numericUpDown_range_max";
            this.numericUpDown_range_max.Size = new System.Drawing.Size(104, 29);
            this.numericUpDown_range_max.TabIndex = 9;
            this.numericUpDown_range_max.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown_range_max.ValueChanged += new System.EventHandler(this.numericUpDown_range_max_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(313, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "|";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(13, 54);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Исходный массив";
            // 
            // textBox_basic_array
            // 
            this.textBox_basic_array.Location = new System.Drawing.Point(162, 51);
            this.textBox_basic_array.Name = "textBox_basic_array";
            this.textBox_basic_array.ReadOnly = true;
            this.textBox_basic_array.Size = new System.Drawing.Size(472, 26);
            this.textBox_basic_array.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox_Operations);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button_generate);
            this.panel1.Location = new System.Drawing.Point(229, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 328);
            this.panel1.TabIndex = 13;
            // 
            // groupBox_Operations
            // 
            this.groupBox_Operations.Controls.Add(this.radioButtonOperation4);
            this.groupBox_Operations.Controls.Add(this.radioButtonOperation3);
            this.groupBox_Operations.Controls.Add(this.radioButtonOperation2);
            this.groupBox_Operations.Controls.Add(this.radioButtonOperation1);
            this.groupBox_Operations.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox_Operations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Operations.Location = new System.Drawing.Point(209, 68);
            this.groupBox_Operations.Margin = new System.Windows.Forms.Padding(12);
            this.groupBox_Operations.Name = "groupBox_Operations";
            this.groupBox_Operations.Size = new System.Drawing.Size(182, 231);
            this.groupBox_Operations.TabIndex = 3;
            this.groupBox_Operations.TabStop = false;
            this.groupBox_Operations.Text = "Операции";
            // 
            // radioButtonOperation4
            // 
            this.radioButtonOperation4.AutoSize = true;
            this.radioButtonOperation4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonOperation4.Location = new System.Drawing.Point(15, 168);
            this.radioButtonOperation4.Margin = new System.Windows.Forms.Padding(12);
            this.radioButtonOperation4.Name = "radioButtonOperation4";
            this.radioButtonOperation4.Size = new System.Drawing.Size(106, 22);
            this.radioButtonOperation4.TabIndex = 7;
            this.radioButtonOperation4.TabStop = true;
            this.radioButtonOperation4.Text = "Операция 4";
            this.radioButtonOperation4.UseVisualStyleBackColor = true;
            // 
            // radioButtonOperation3
            // 
            this.radioButtonOperation3.AutoSize = true;
            this.radioButtonOperation3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonOperation3.Location = new System.Drawing.Point(15, 122);
            this.radioButtonOperation3.Margin = new System.Windows.Forms.Padding(12);
            this.radioButtonOperation3.Name = "radioButtonOperation3";
            this.radioButtonOperation3.Size = new System.Drawing.Size(106, 22);
            this.radioButtonOperation3.TabIndex = 6;
            this.radioButtonOperation3.TabStop = true;
            this.radioButtonOperation3.Text = "Операция 3";
            this.radioButtonOperation3.UseVisualStyleBackColor = true;
            // 
            // radioButtonOperation2
            // 
            this.radioButtonOperation2.AutoSize = true;
            this.radioButtonOperation2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonOperation2.Location = new System.Drawing.Point(15, 76);
            this.radioButtonOperation2.Margin = new System.Windows.Forms.Padding(12);
            this.radioButtonOperation2.Name = "radioButtonOperation2";
            this.radioButtonOperation2.Size = new System.Drawing.Size(106, 22);
            this.radioButtonOperation2.TabIndex = 5;
            this.radioButtonOperation2.TabStop = true;
            this.radioButtonOperation2.Text = "Операция 2";
            this.radioButtonOperation2.UseVisualStyleBackColor = true;
            // 
            // radioButtonOperation1
            // 
            this.radioButtonOperation1.AutoSize = true;
            this.radioButtonOperation1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonOperation1.Location = new System.Drawing.Point(15, 30);
            this.radioButtonOperation1.Margin = new System.Windows.Forms.Padding(12);
            this.radioButtonOperation1.Name = "radioButtonOperation1";
            this.radioButtonOperation1.Size = new System.Drawing.Size(106, 22);
            this.radioButtonOperation1.TabIndex = 4;
            this.radioButtonOperation1.TabStop = true;
            this.radioButtonOperation1.Text = "Операция 1";
            this.radioButtonOperation1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_open_f2);
            this.panel2.Controls.Add(this.button_open_f1);
            this.panel2.Controls.Add(this.button_save_f2);
            this.panel2.Controls.Add(this.button_save_f1);
            this.panel2.Location = new System.Drawing.Point(8, 68);
            this.panel2.Margin = new System.Windows.Forms.Padding(12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 231);
            this.panel2.TabIndex = 2;
            // 
            // button_open_f2
            // 
            this.button_open_f2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_open_f2.Location = new System.Drawing.Point(13, 181);
            this.button_open_f2.Margin = new System.Windows.Forms.Padding(13);
            this.button_open_f2.Name = "button_open_f2";
            this.button_open_f2.Size = new System.Drawing.Size(160, 30);
            this.button_open_f2.TabIndex = 6;
            this.button_open_f2.Text = "Считать из F2";
            this.button_open_f2.UseVisualStyleBackColor = true;
            this.button_open_f2.Click += new System.EventHandler(this.button_open_f2_Click);
            // 
            // button_open_f1
            // 
            this.button_open_f1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_open_f1.Location = new System.Drawing.Point(13, 125);
            this.button_open_f1.Margin = new System.Windows.Forms.Padding(13);
            this.button_open_f1.Name = "button_open_f1";
            this.button_open_f1.Size = new System.Drawing.Size(160, 30);
            this.button_open_f1.TabIndex = 5;
            this.button_open_f1.Text = "Считать из F1";
            this.button_open_f1.UseVisualStyleBackColor = true;
            this.button_open_f1.Click += new System.EventHandler(this.button_open_f1_Click);
            // 
            // button_save_f2
            // 
            this.button_save_f2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_save_f2.Location = new System.Drawing.Point(13, 69);
            this.button_save_f2.Margin = new System.Windows.Forms.Padding(13);
            this.button_save_f2.Name = "button_save_f2";
            this.button_save_f2.Size = new System.Drawing.Size(160, 30);
            this.button_save_f2.TabIndex = 4;
            this.button_save_f2.Text = "Запись в F2";
            this.button_save_f2.UseVisualStyleBackColor = true;
            this.button_save_f2.Click += new System.EventHandler(this.button_save_f2_Click);
            // 
            // button_save_f1
            // 
            this.button_save_f1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_save_f1.Location = new System.Drawing.Point(13, 13);
            this.button_save_f1.Margin = new System.Windows.Forms.Padding(13);
            this.button_save_f1.Name = "button_save_f1";
            this.button_save_f1.Size = new System.Drawing.Size(160, 30);
            this.button_save_f1.TabIndex = 3;
            this.button_save_f1.Text = "Запись в F1";
            this.button_save_f1.UseVisualStyleBackColor = true;
            this.button_save_f1.Click += new System.EventHandler(this.button_save_f1_Click);
            // 
            // button_generate
            // 
            this.button_generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_generate.Location = new System.Drawing.Point(21, 13);
            this.button_generate.Margin = new System.Windows.Forms.Padding(13);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(369, 30);
            this.button_generate.TabIndex = 0;
            this.button_generate.Text = "Генерировать";
            this.button_generate.UseVisualStyleBackColor = true;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(12, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(209, 328);
            this.dataGridView1.TabIndex = 14;
            // 
            // openFileDialogF1
            // 
            this.openFileDialogF1.DefaultExt = "F1";
            this.openFileDialogF1.FileName = "F1";
            this.openFileDialogF1.Filter = "XML files (*.xml)|*.xml";
            this.openFileDialogF1.InitialDirectory = "C:\\Users\\%User%\\Desktop";
            // 
            // saveFileDialogF1
            // 
            this.saveFileDialogF1.DefaultExt = "F1";
            this.saveFileDialogF1.FileName = "F1";
            this.saveFileDialogF1.Filter = "XML files (*.xml)|*.xml";
            this.saveFileDialogF1.InitialDirectory = "C:\\Users\\%User%\\Desktop";
            this.saveFileDialogF1.RestoreDirectory = true;
            // 
            // openFileDialogF2
            // 
            this.openFileDialogF2.DefaultExt = "F2";
            this.openFileDialogF2.FileName = "F2";
            this.openFileDialogF2.Filter = "XML files (*.xml)|*.xml";
            this.openFileDialogF2.InitialDirectory = "C:\\Users\\%User%\\Desktop";
            // 
            // saveFileDialogF2
            // 
            this.saveFileDialogF2.DefaultExt = "F2";
            this.saveFileDialogF2.FileName = "F2";
            this.saveFileDialogF2.Filter = "XML files (*.xml)|*.xml";
            this.saveFileDialogF2.InitialDirectory = "C:\\Users\\%User%\\Desktop";
            this.saveFileDialogF2.RestoreDirectory = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.button_generate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 642);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_basic_array);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_range_max);
            this.Controls.Add(this.numericUpDown_range_min);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown_size);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "ArrayEditor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_range_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_range_max)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox_Operations.ResumeLayout(false);
            this.groupBox_Operations.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_size;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_range_min;
        private System.Windows.Forms.NumericUpDown numericUpDown_range_max;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_basic_array;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox_Operations;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_open_f2;
        private System.Windows.Forms.Button button_open_f1;
        private System.Windows.Forms.Button button_save_f2;
        private System.Windows.Forms.Button button_save_f1;
        private System.Windows.Forms.RadioButton radioButtonOperation4;
        private System.Windows.Forms.RadioButton radioButtonOperation3;
        private System.Windows.Forms.RadioButton radioButtonOperation2;
        private System.Windows.Forms.RadioButton radioButtonOperation1;
        private System.Windows.Forms.OpenFileDialog openFileDialogF1;
        private System.Windows.Forms.SaveFileDialog saveFileDialogF1;
        private System.Windows.Forms.OpenFileDialog openFileDialogF2;
        private System.Windows.Forms.SaveFileDialog saveFileDialogF2;
    }
}

