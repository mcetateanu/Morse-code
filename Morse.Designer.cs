namespace Morse_code_learning
{
    partial class MorseLearningForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RadioButton_Cod_Ascuns = new System.Windows.Forms.RadioButton();
            this.CaractereLectieCurenta = new System.Windows.Forms.TextBox();
            this.NumericUpDown_NrLectie = new System.Windows.Forms.NumericUpDown();
            this.Lectia_Nr = new System.Windows.Forms.TextBox();
            this.ProgressBar = new System.Windows.Forms.TextBox();
            this.RadioButton_Cod_La_Vedere = new System.Windows.Forms.RadioButton();
            this.Grupa_1_Cod_Morse = new System.Windows.Forms.TextBox();
            this.Grupa_2_Cod_Morse = new System.Windows.Forms.TextBox();
            this.Grupa_3_Cod_Morse = new System.Windows.Forms.TextBox();
            this.Grupa_4_Cod_Morse = new System.Windows.Forms.TextBox();
            this.Grupa_5_Cod_Morse = new System.Windows.Forms.TextBox();
            this.Caracter_Morse_Curent = new System.Windows.Forms.TextBox();
            this.Lectie_DoarGrupaNoua_CheckBox = new System.Windows.Forms.CheckBox();
            this.STOP = new System.Windows.Forms.Button();
            this.START = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_NrLectie)).BeginInit();
            this.SuspendLayout();
            // 
            // RadioButton_Cod_Ascuns
            // 
            this.RadioButton_Cod_Ascuns.AutoSize = true;
            this.RadioButton_Cod_Ascuns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButton_Cod_Ascuns.Location = new System.Drawing.Point(52, 388);
            this.RadioButton_Cod_Ascuns.Name = "RadioButton_Cod_Ascuns";
            this.RadioButton_Cod_Ascuns.Size = new System.Drawing.Size(121, 24);
            this.RadioButton_Cod_Ascuns.TabIndex = 1;
            this.RadioButton_Cod_Ascuns.Text = "Cod Ascuns";
            this.RadioButton_Cod_Ascuns.UseVisualStyleBackColor = true;
            this.RadioButton_Cod_Ascuns.CheckedChanged += new System.EventHandler(this.RadioButton_Cod_Ascuns_CheckedChanged);
            // 
            // CaractereLectieCurenta
            // 
            this.CaractereLectieCurenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaractereLectieCurenta.Location = new System.Drawing.Point(240, 67);
            this.CaractereLectieCurenta.Name = "CaractereLectieCurenta";
            this.CaractereLectieCurenta.Size = new System.Drawing.Size(53, 30);
            this.CaractereLectieCurenta.TabIndex = 2;
            this.CaractereLectieCurenta.Text = " E,L";
            this.CaractereLectieCurenta.TextChanged += new System.EventHandler(this.CaractereLectieCurenta_TextChanged);
            // 
            // NumericUpDown_NrLectie
            // 
            this.NumericUpDown_NrLectie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericUpDown_NrLectie.Location = new System.Drawing.Point(158, 67);
            this.NumericUpDown_NrLectie.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NumericUpDown_NrLectie.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDown_NrLectie.Name = "NumericUpDown_NrLectie";
            this.NumericUpDown_NrLectie.Size = new System.Drawing.Size(55, 30);
            this.NumericUpDown_NrLectie.TabIndex = 3;
            this.NumericUpDown_NrLectie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumericUpDown_NrLectie.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDown_NrLectie.ValueChanged += new System.EventHandler(this.NumericUpDown_NrLectie_ValueChanged);
            // 
            // Lectia_Nr
            // 
            this.Lectia_Nr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lectia_Nr.Location = new System.Drawing.Point(53, 67);
            this.Lectia_Nr.Name = "Lectia_Nr";
            this.Lectia_Nr.Size = new System.Drawing.Size(99, 30);
            this.Lectia_Nr.TabIndex = 4;
            this.Lectia_Nr.Text = "Lectia Nr.:";
            this.Lectia_Nr.TextChanged += new System.EventHandler(this.Lectia_Nr_TextChanged);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressBar.Location = new System.Drawing.Point(53, 21);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(805, 30);
            this.ProgressBar.TabIndex = 5;
            this.ProgressBar.Text = " E,L";
            this.ProgressBar.TextChanged += new System.EventHandler(this.ProgressBar_TextChanged);
            // 
            // RadioButton_Cod_La_Vedere
            // 
            this.RadioButton_Cod_La_Vedere.AutoSize = true;
            this.RadioButton_Cod_La_Vedere.Checked = true;
            this.RadioButton_Cod_La_Vedere.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButton_Cod_La_Vedere.Location = new System.Drawing.Point(52, 345);
            this.RadioButton_Cod_La_Vedere.Name = "RadioButton_Cod_La_Vedere";
            this.RadioButton_Cod_La_Vedere.Size = new System.Drawing.Size(142, 24);
            this.RadioButton_Cod_La_Vedere.TabIndex = 6;
            this.RadioButton_Cod_La_Vedere.TabStop = true;
            this.RadioButton_Cod_La_Vedere.Text = "Cod La Vedere";
            this.RadioButton_Cod_La_Vedere.UseVisualStyleBackColor = true;
            this.RadioButton_Cod_La_Vedere.CheckedChanged += new System.EventHandler(this.RadioButton_Cod_La_Vedere_CheckedChanged);
            // 
            // Grupa_1_Cod_Morse
            // 
            this.Grupa_1_Cod_Morse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grupa_1_Cod_Morse.Location = new System.Drawing.Point(52, 162);
            this.Grupa_1_Cod_Morse.Name = "Grupa_1_Cod_Morse";
            this.Grupa_1_Cod_Morse.Size = new System.Drawing.Size(121, 26);
            this.Grupa_1_Cod_Morse.TabIndex = 7;
            this.Grupa_1_Cod_Morse.Text = " ";
            this.Grupa_1_Cod_Morse.TextChanged += new System.EventHandler(this.Grupa_1_Cod_Morse_TextChanged);
            // 
            // Grupa_2_Cod_Morse
            // 
            this.Grupa_2_Cod_Morse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grupa_2_Cod_Morse.Location = new System.Drawing.Point(179, 162);
            this.Grupa_2_Cod_Morse.Name = "Grupa_2_Cod_Morse";
            this.Grupa_2_Cod_Morse.Size = new System.Drawing.Size(120, 26);
            this.Grupa_2_Cod_Morse.TabIndex = 8;
            this.Grupa_2_Cod_Morse.TextChanged += new System.EventHandler(this.Grupa_2_Cod_Morse_TextChanged);
            // 
            // Grupa_3_Cod_Morse
            // 
            this.Grupa_3_Cod_Morse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grupa_3_Cod_Morse.Location = new System.Drawing.Point(305, 162);
            this.Grupa_3_Cod_Morse.Name = "Grupa_3_Cod_Morse";
            this.Grupa_3_Cod_Morse.Size = new System.Drawing.Size(120, 26);
            this.Grupa_3_Cod_Morse.TabIndex = 9;
            this.Grupa_3_Cod_Morse.TextChanged += new System.EventHandler(this.Grupa_3_Cod_Morse_TextChanged);
            // 
            // Grupa_4_Cod_Morse
            // 
            this.Grupa_4_Cod_Morse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grupa_4_Cod_Morse.Location = new System.Drawing.Point(431, 162);
            this.Grupa_4_Cod_Morse.Name = "Grupa_4_Cod_Morse";
            this.Grupa_4_Cod_Morse.Size = new System.Drawing.Size(120, 26);
            this.Grupa_4_Cod_Morse.TabIndex = 10;
            this.Grupa_4_Cod_Morse.TextChanged += new System.EventHandler(this.Grupa_4_Cod_Morse_TextChanged);
            // 
            // Grupa_5_Cod_Morse
            // 
            this.Grupa_5_Cod_Morse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grupa_5_Cod_Morse.Location = new System.Drawing.Point(557, 162);
            this.Grupa_5_Cod_Morse.Name = "Grupa_5_Cod_Morse";
            this.Grupa_5_Cod_Morse.Size = new System.Drawing.Size(120, 26);
            this.Grupa_5_Cod_Morse.TabIndex = 11;
            this.Grupa_5_Cod_Morse.TextChanged += new System.EventHandler(this.Grupa_5_Cod_Morse_TextChanged);
            // 
            // Caracter_Morse_Curent
            // 
            this.Caracter_Morse_Curent.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Caracter_Morse_Curent.Location = new System.Drawing.Point(786, 67);
            this.Caracter_Morse_Curent.Name = "Caracter_Morse_Curent";
            this.Caracter_Morse_Curent.Size = new System.Drawing.Size(72, 64);
            this.Caracter_Morse_Curent.TabIndex = 12;
            this.Caracter_Morse_Curent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Caracter_Morse_Curent.TextChanged += new System.EventHandler(this.Caracter_Morse_Curent_TextChanged);
            // 
            // Lectie_DoarGrupaNoua_CheckBox
            // 
            this.Lectie_DoarGrupaNoua_CheckBox.AutoSize = true;
            this.Lectie_DoarGrupaNoua_CheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lectie_DoarGrupaNoua_CheckBox.Checked = true;
            this.Lectie_DoarGrupaNoua_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Lectie_DoarGrupaNoua_CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lectie_DoarGrupaNoua_CheckBox.Location = new System.Drawing.Point(52, 115);
            this.Lectie_DoarGrupaNoua_CheckBox.Name = "Lectie_DoarGrupaNoua_CheckBox";
            this.Lectie_DoarGrupaNoua_CheckBox.Size = new System.Drawing.Size(212, 28);
            this.Lectie_DoarGrupaNoua_CheckBox.TabIndex = 13;
            this.Lectie_DoarGrupaNoua_CheckBox.Text = "Tx  Doar Grupa Noua";
            this.Lectie_DoarGrupaNoua_CheckBox.UseVisualStyleBackColor = true;
            this.Lectie_DoarGrupaNoua_CheckBox.CheckedChanged += new System.EventHandler(this.Lectie_DoarGrupaNoua_CheckBox_CheckedChanged);
            // 
            // STOP
            // 
            this.STOP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.STOP.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STOP.Location = new System.Drawing.Point(711, 375);
            this.STOP.Name = "STOP";
            this.STOP.Size = new System.Drawing.Size(147, 49);
            this.STOP.TabIndex = 14;
            this.STOP.Text = "STOP  TX";
            this.STOP.UseVisualStyleBackColor = false;
            this.STOP.Click += new System.EventHandler(this.STOP_Click);
            // 
            // START
            // 
            this.START.BackColor = System.Drawing.Color.Lime;
            this.START.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.START.Location = new System.Drawing.Point(711, 308);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(147, 49);
            this.START.TabIndex = 15;
            this.START.Text = "START  TX";
            this.START.UseVisualStyleBackColor = false;
            this.START.Click += new System.EventHandler(this.START_Click);
            // 
            // MorseLearningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 484);
            this.Controls.Add(this.START);
            this.Controls.Add(this.STOP);
            this.Controls.Add(this.Lectie_DoarGrupaNoua_CheckBox);
            this.Controls.Add(this.Caracter_Morse_Curent);
            this.Controls.Add(this.Grupa_5_Cod_Morse);
            this.Controls.Add(this.Grupa_4_Cod_Morse);
            this.Controls.Add(this.Grupa_3_Cod_Morse);
            this.Controls.Add(this.Grupa_2_Cod_Morse);
            this.Controls.Add(this.Grupa_1_Cod_Morse);
            this.Controls.Add(this.RadioButton_Cod_La_Vedere);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.Lectia_Nr);
            this.Controls.Add(this.NumericUpDown_NrLectie);
            this.Controls.Add(this.CaractereLectieCurenta);
            this.Controls.Add(this.RadioButton_Cod_Ascuns);
            this.Name = "MorseLearningForm";
            this.Text = "LearningForm";
            this.Load += new System.EventHandler(this.MorseLearningForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_NrLectie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton RadioButton_Cod_Ascuns;
        private System.Windows.Forms.TextBox CaractereLectieCurenta;
        private System.Windows.Forms.NumericUpDown NumericUpDown_NrLectie;
        private System.Windows.Forms.TextBox Lectia_Nr;
        private System.Windows.Forms.TextBox ProgressBar;
        private System.Windows.Forms.RadioButton RadioButton_Cod_La_Vedere;
        private System.Windows.Forms.TextBox Grupa_1_Cod_Morse;
        private System.Windows.Forms.TextBox Grupa_2_Cod_Morse;
        private System.Windows.Forms.TextBox Grupa_3_Cod_Morse;
        private System.Windows.Forms.TextBox Grupa_4_Cod_Morse;
        private System.Windows.Forms.TextBox Grupa_5_Cod_Morse;
        private System.Windows.Forms.TextBox Caracter_Morse_Curent;
        private System.Windows.Forms.CheckBox Lectie_DoarGrupaNoua_CheckBox;
        private System.Windows.Forms.Button STOP;
        private System.Windows.Forms.Button START;
    }
}

