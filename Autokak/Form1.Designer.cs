namespace Autokak
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
            DGV = new DataGridView();
            rszam = new DataGridViewTextBoxColumn();
            tipus = new DataGridViewTextBoxColumn();
            uzh = new DataGridViewTextBoxColumn();
            tank = new DataGridViewTextBoxColumn();
            ftkm = new DataGridViewTextBoxColumn();
            label1 = new Label();
            tb_rsz = new TextBox();
            label2 = new Label();
            tb_tipus = new TextBox();
            label3 = new Label();
            tb_tank = new TextBox();
            label4 = new Label();
            tb_futottkm = new TextBox();
            label5 = new Label();
            dtp_uzem = new DateTimePicker();
            btn_mentes = new Button();
            groupBox1 = new GroupBox();
            rb_n = new RadioButton();
            rb_i = new RadioButton();
            dtp_ki = new DateTimePicker();
            kivonas = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // DGV
            // 
            DGV.AllowUserToAddRows = false;
            DGV.AllowUserToDeleteRows = false;
            DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.Columns.AddRange(new DataGridViewColumn[] { rszam, tipus, uzh, tank, ftkm, kivonas });
            DGV.Location = new Point(12, 30);
            DGV.Name = "DGV";
            DGV.ReadOnly = true;
            DGV.Size = new Size(676, 513);
            DGV.TabIndex = 0;
            // 
            // rszam
            // 
            rszam.HeaderText = "Rendszám";
            rszam.Name = "rszam";
            rszam.ReadOnly = true;
            // 
            // tipus
            // 
            tipus.HeaderText = "Típus";
            tipus.Name = "tipus";
            tipus.ReadOnly = true;
            // 
            // uzh
            // 
            uzh.HeaderText = "Üzembe helyezés ideje";
            uzh.Name = "uzh";
            uzh.ReadOnly = true;
            // 
            // tank
            // 
            tank.HeaderText = "Tank";
            tank.Name = "tank";
            tank.ReadOnly = true;
            // 
            // ftkm
            // 
            ftkm.HeaderText = "Futott kilóméter";
            ftkm.Name = "ftkm";
            ftkm.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(722, 44);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 1;
            label1.Text = "Rendszám";
            // 
            // tb_rsz
            // 
            tb_rsz.Location = new Point(789, 41);
            tb_rsz.Name = "tb_rsz";
            tb_rsz.Size = new Size(100, 23);
            tb_rsz.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(722, 86);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 1;
            label2.Text = "típus";
            // 
            // tb_tipus
            // 
            tb_tipus.Location = new Point(781, 83);
            tb_tipus.Name = "tb_tipus";
            tb_tipus.Size = new Size(100, 23);
            tb_tipus.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(722, 184);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 1;
            label3.Text = "tank";
            // 
            // tb_tank
            // 
            tb_tank.Location = new Point(781, 181);
            tb_tank.Name = "tb_tank";
            tb_tank.Size = new Size(100, 23);
            tb_tank.TabIndex = 2;
            tb_tank.TextChanged += tb_tank_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(722, 224);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 1;
            label4.Text = "futott km";
            // 
            // tb_futottkm
            // 
            tb_futottkm.Location = new Point(781, 221);
            tb_futottkm.Name = "tb_futottkm";
            tb_futottkm.Size = new Size(100, 23);
            tb_futottkm.TabIndex = 2;
            tb_futottkm.TextChanged += tb_futottkm_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(722, 145);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 1;
            label5.Text = "Üzembe helyezés";
            // 
            // dtp_uzem
            // 
            dtp_uzem.CustomFormat = "yyyy-MM-dd";
            dtp_uzem.Format = DateTimePickerFormat.Custom;
            dtp_uzem.Location = new Point(825, 139);
            dtp_uzem.Name = "dtp_uzem";
            dtp_uzem.Size = new Size(138, 23);
            dtp_uzem.TabIndex = 3;
            // 
            // btn_mentes
            // 
            btn_mentes.Location = new Point(722, 423);
            btn_mentes.Name = "btn_mentes";
            btn_mentes.Size = new Size(241, 110);
            btn_mentes.TabIndex = 4;
            btn_mentes.Text = "mentés";
            btn_mentes.UseVisualStyleBackColor = true;
            btn_mentes.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rb_n);
            groupBox1.Controls.Add(rb_i);
            groupBox1.Location = new Point(722, 250);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(159, 90);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "forgalomból kivont?";
            // 
            // rb_n
            // 
            rb_n.AutoSize = true;
            rb_n.Location = new Point(18, 53);
            rb_n.Name = "rb_n";
            rb_n.Size = new Size(51, 19);
            rb_n.TabIndex = 0;
            rb_n.TabStop = true;
            rb_n.Text = "Nem";
            rb_n.UseVisualStyleBackColor = true;
            rb_n.CheckedChanged += rb_n_CheckedChanged;
            // 
            // rb_i
            // 
            rb_i.AutoSize = true;
            rb_i.Location = new Point(18, 28);
            rb_i.Name = "rb_i";
            rb_i.Size = new Size(48, 19);
            rb_i.TabIndex = 0;
            rb_i.TabStop = true;
            rb_i.Text = "Igen";
            rb_i.UseVisualStyleBackColor = true;
            rb_i.CheckedChanged += rb_i_CheckedChanged;
            // 
            // dtp_ki
            // 
            dtp_ki.CustomFormat = "yyyy-MM-dd";
            dtp_ki.Format = DateTimePickerFormat.Custom;
            dtp_ki.Location = new Point(722, 346);
            dtp_ki.Name = "dtp_ki";
            dtp_ki.Size = new Size(200, 23);
            dtp_ki.TabIndex = 6;
            // 
            // kivonas
            // 
            kivonas.HeaderText = "Kivonás ideje";
            kivonas.Name = "kivonas";
            kivonas.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 555);
            Controls.Add(dtp_ki);
            Controls.Add(groupBox1);
            Controls.Add(btn_mentes);
            Controls.Add(dtp_uzem);
            Controls.Add(tb_futottkm);
            Controls.Add(label4);
            Controls.Add(tb_tank);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(tb_tipus);
            Controls.Add(label2);
            Controls.Add(tb_rsz);
            Controls.Add(label1);
            Controls.Add(DGV);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DGV).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGV;
        private DataGridViewTextBoxColumn rszam;
        private DataGridViewTextBoxColumn tipus;
        private DataGridViewTextBoxColumn uzh;
        private DataGridViewTextBoxColumn tank;
        private DataGridViewTextBoxColumn ftkm;
        private Label label1;
        private TextBox tb_rsz;
        private Label label2;
        private TextBox tb_tipus;
        private Label label3;
        private TextBox tb_tank;
        private Label label4;
        private TextBox tb_futottkm;
        private Label label5;
        private DateTimePicker dtp_uzem;
        private Button btn_mentes;
        private GroupBox groupBox1;
        private RadioButton rb_n;
        private RadioButton rb_i;
        private DateTimePicker dtp_ki;
        private DataGridViewTextBoxColumn kivonas;
    }
}
