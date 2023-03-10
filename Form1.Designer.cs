namespace db
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputNama = new System.Windows.Forms.TextBox();
            this.inputSeries = new System.Windows.Forms.TextBox();
            this.add_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.data_gunpla = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.inputHarga = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.inputId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_save = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_gunpla)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(13, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "nama :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "series :";
            // 
            // inputNama
            // 
            this.inputNama.ForeColor = System.Drawing.Color.Gray;
            this.inputNama.Location = new System.Drawing.Point(11, 17);
            this.inputNama.Name = "inputNama";
            this.inputNama.Size = new System.Drawing.Size(225, 23);
            this.inputNama.TabIndex = 3;
            // 
            // inputSeries
            // 
            this.inputSeries.Location = new System.Drawing.Point(12, 62);
            this.inputSeries.Name = "inputSeries";
            this.inputSeries.Size = new System.Drawing.Size(224, 23);
            this.inputSeries.TabIndex = 4;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(13, 137);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(71, 22);
            this.add_button.TabIndex = 5;
            this.add_button.Text = "add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "E:\\download\\images.jpeg";
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 162);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 45.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(323, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(571, 84);
            this.label3.TabIndex = 10;
            this.label3.Text = "list katalog gunpla";
            // 
            // data_gunpla
            // 
            this.data_gunpla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_gunpla.Location = new System.Drawing.Point(22, 185);
            this.data_gunpla.Name = "data_gunpla";
            this.data_gunpla.RowTemplate.Height = 25;
            this.data_gunpla.Size = new System.Drawing.Size(714, 253);
            this.data_gunpla.TabIndex = 11;
            this.data_gunpla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_gunpla_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 22);
            this.button1.TabIndex = 12;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputHarga
            // 
            this.inputHarga.Location = new System.Drawing.Point(12, 108);
            this.inputHarga.Name = "inputHarga";
            this.inputHarga.Size = new System.Drawing.Size(224, 23);
            this.inputHarga.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "harga saat ini :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1045, 162);
            this.panel1.TabIndex = 15;
            // 
            // inputId
            // 
            this.inputId.Location = new System.Drawing.Point(12, 197);
            this.inputId.Name = "inputId";
            this.inputId.Size = new System.Drawing.Size(224, 23);
            this.inputId.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "id :";
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(90, 137);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(71, 22);
            this.bt_save.TabIndex = 18;
            this.bt_save.Text = "save";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.bt_save);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.inputId);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.inputHarga);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.add_button);
            this.panel2.Controls.Add(this.inputSeries);
            this.panel2.Controls.Add(this.inputNama);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(746, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 260);
            this.panel2.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel3.Location = new System.Drawing.Point(12, 176);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(739, 262);
            this.panel3.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 450);
            this.Controls.Add(this.data_gunpla);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_gunpla)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox inputNama;
        private TextBox inputSeries;
        private Button add_button;
        private PictureBox pictureBox1;
        private Label label3;
        private DataGridView data_gunpla;
        private Button button1;
        private TextBox inputHarga;
        private Label label4;
        private Panel panel1;
        private TextBox inputId;
        private Label label5;
        private Button bt_save;
        private Panel panel2;
        private Panel panel3;
    }
}