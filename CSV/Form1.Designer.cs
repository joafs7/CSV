namespace CSV
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
            dgv_CSV = new DataGridView();
            btn_Load = new Button();
            btn_lower_higher = new Button();
            btn_Style = new Button();
            btn_Media = new Button();
            btn_average = new Button();
            txt_notaMayor = new TextBox();
            txt_menorNota = new TextBox();
            txt_Media = new TextBox();
            txt_Moda = new TextBox();
            lbl_notaMayor = new Label();
            lbl_notaMenor = new Label();
            txt_mediana = new TextBox();
            label1 = new Label();
            btn_clean = new Button();
            cmBox_Errores = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgv_CSV).BeginInit();
            SuspendLayout();
            // 
            // dgv_CSV
            // 
            dgv_CSV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_CSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_CSV.Location = new Point(12, 26);
            dgv_CSV.Name = "dgv_CSV";
            dgv_CSV.RowHeadersWidth = 62;
            dgv_CSV.Size = new Size(1765, 464);
            dgv_CSV.TabIndex = 0;
            // 
            // btn_Load
            // 
            btn_Load.BackColor = Color.FromArgb(128, 255, 128);
            btn_Load.Font = new Font("Calibri", 11F);
            btn_Load.Location = new Point(136, 524);
            btn_Load.Name = "btn_Load";
            btn_Load.Size = new Size(274, 91);
            btn_Load.TabIndex = 1;
            btn_Load.Text = "Cargar CSV";
            btn_Load.UseVisualStyleBackColor = false;
            btn_Load.Click += btn_Load_Click;
            // 
            // btn_lower_higher
            // 
            btn_lower_higher.BackColor = Color.FromArgb(128, 255, 128);
            btn_lower_higher.Font = new Font("Calibri", 11F);
            btn_lower_higher.Location = new Point(445, 524);
            btn_lower_higher.Name = "btn_lower_higher";
            btn_lower_higher.Size = new Size(274, 91);
            btn_lower_higher.TabIndex = 2;
            btn_lower_higher.Text = "Mayor y Menor nota";
            btn_lower_higher.UseVisualStyleBackColor = false;
            btn_lower_higher.Click += btn_lower_higher_Click;
            // 
            // btn_Style
            // 
            btn_Style.BackColor = Color.FromArgb(128, 255, 128);
            btn_Style.Font = new Font("Calibri", 11F);
            btn_Style.Location = new Point(1379, 524);
            btn_Style.Name = "btn_Style";
            btn_Style.Size = new Size(274, 91);
            btn_Style.TabIndex = 3;
            btn_Style.Text = "Moda";
            btn_Style.UseVisualStyleBackColor = false;
            btn_Style.Click += btn_Style_Click;
            // 
            // btn_Media
            // 
            btn_Media.BackColor = Color.FromArgb(128, 255, 128);
            btn_Media.Font = new Font("Calibri", 11F);
            btn_Media.Location = new Point(747, 524);
            btn_Media.Name = "btn_Media";
            btn_Media.Size = new Size(274, 91);
            btn_Media.TabIndex = 4;
            btn_Media.Text = "Media";
            btn_Media.UseVisualStyleBackColor = false;
            btn_Media.Click += btn_Media_Click;
            // 
            // btn_average
            // 
            btn_average.BackColor = Color.FromArgb(128, 255, 128);
            btn_average.Font = new Font("Calibri", 11F);
            btn_average.Location = new Point(1064, 524);
            btn_average.Name = "btn_average";
            btn_average.Size = new Size(274, 91);
            btn_average.TabIndex = 5;
            btn_average.Text = "Mediana";
            btn_average.UseVisualStyleBackColor = false;
            btn_average.Click += btn_average_Click;
            // 
            // txt_notaMayor
            // 
            txt_notaMayor.Enabled = false;
            txt_notaMayor.Font = new Font("Calibri", 11F);
            txt_notaMayor.Location = new Point(472, 648);
            txt_notaMayor.Name = "txt_notaMayor";
            txt_notaMayor.Size = new Size(247, 34);
            txt_notaMayor.TabIndex = 6;
            // 
            // txt_menorNota
            // 
            txt_menorNota.Enabled = false;
            txt_menorNota.Font = new Font("Calibri", 11F);
            txt_menorNota.Location = new Point(472, 720);
            txt_menorNota.Name = "txt_menorNota";
            txt_menorNota.Size = new Size(247, 34);
            txt_menorNota.TabIndex = 7;
            // 
            // txt_Media
            // 
            txt_Media.Enabled = false;
            txt_Media.Font = new Font("Calibri", 11F);
            txt_Media.Location = new Point(785, 651);
            txt_Media.Name = "txt_Media";
            txt_Media.Size = new Size(196, 34);
            txt_Media.TabIndex = 9;
            // 
            // txt_Moda
            // 
            txt_Moda.Enabled = false;
            txt_Moda.Font = new Font("Calibri", 11F);
            txt_Moda.Location = new Point(1415, 648);
            txt_Moda.Name = "txt_Moda";
            txt_Moda.Size = new Size(196, 34);
            txt_Moda.TabIndex = 10;
            // 
            // lbl_notaMayor
            // 
            lbl_notaMayor.AutoSize = true;
            lbl_notaMayor.Font = new Font("Calibri", 11F);
            lbl_notaMayor.ForeColor = Color.White;
            lbl_notaMayor.Location = new Point(282, 651);
            lbl_notaMayor.Name = "lbl_notaMayor";
            lbl_notaMayor.Size = new Size(120, 27);
            lbl_notaMayor.TabIndex = 12;
            lbl_notaMayor.Text = "Nota mayor";
            // 
            // lbl_notaMenor
            // 
            lbl_notaMenor.AutoSize = true;
            lbl_notaMenor.Font = new Font("Calibri", 11F);
            lbl_notaMenor.ForeColor = Color.White;
            lbl_notaMenor.Location = new Point(282, 726);
            lbl_notaMenor.Name = "lbl_notaMenor";
            lbl_notaMenor.Size = new Size(122, 27);
            lbl_notaMenor.TabIndex = 13;
            lbl_notaMenor.Text = "Nota menor";
            // 
            // txt_mediana
            // 
            txt_mediana.BackColor = Color.WhiteSmoke;
            txt_mediana.Enabled = false;
            txt_mediana.Font = new Font("Calibri", 11F);
            txt_mediana.ForeColor = Color.Black;
            txt_mediana.Location = new Point(1111, 651);
            txt_mediana.Name = "txt_mediana";
            txt_mediana.Size = new Size(196, 34);
            txt_mediana.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 11F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(282, 795);
            label1.Name = "label1";
            label1.Size = new Size(183, 27);
            label1.TabIndex = 15;
            label1.Text = "Registros Omitidos";
            // 
            // btn_clean
            // 
            btn_clean.BackColor = Color.Red;
            btn_clean.Font = new Font("Calibri", 11F);
            btn_clean.Location = new Point(1605, 795);
            btn_clean.Name = "btn_clean";
            btn_clean.Size = new Size(181, 60);
            btn_clean.TabIndex = 16;
            btn_clean.Text = "Limpiar";
            btn_clean.UseVisualStyleBackColor = false;
            btn_clean.Click += btn_clean_Click;
            // 
            // cmBox_Errores
            // 
            cmBox_Errores.Font = new Font("Calibri", 11F);
            cmBox_Errores.FormattingEnabled = true;
            cmBox_Errores.Location = new Point(470, 797);
            cmBox_Errores.Name = "cmBox_Errores";
            cmBox_Errores.Size = new Size(511, 35);
            cmBox_Errores.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(1819, 870);
            Controls.Add(cmBox_Errores);
            Controls.Add(btn_clean);
            Controls.Add(label1);
            Controls.Add(lbl_notaMenor);
            Controls.Add(lbl_notaMayor);
            Controls.Add(txt_Moda);
            Controls.Add(txt_Media);
            Controls.Add(txt_mediana);
            Controls.Add(txt_menorNota);
            Controls.Add(txt_notaMayor);
            Controls.Add(btn_average);
            Controls.Add(btn_Media);
            Controls.Add(btn_Style);
            Controls.Add(btn_lower_higher);
            Controls.Add(btn_Load);
            Controls.Add(dgv_CSV);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_CSV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_CSV;
        private Button btn_Load;
        private Button btn_lower_higher;
        private Button btn_Style;
        private Button btn_Media;
        private Button btn_average;
        private TextBox txt_notaMayor;
        private TextBox txt_menorNota;
        private TextBox txt_Media;
        private TextBox txt_Moda;
        private Label lbl_notaMayor;
        private Label lbl_notaMenor;
        private TextBox txt_mediana;
        private Label label1;
        private Button btn_clean;
        private ComboBox cmBox_Errores;
    }
}
