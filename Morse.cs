using System;
using System.Windows.Forms;

namespace Morse_code_learning
{
    public partial class MorseLearningForm : Form
    {
        public MorseLearningForm()
        {
            InitializeComponent();
        }

        readonly string[] grupe = {"E", "L", "V", "0", "A", "S", "Q", "=", "T", "2", "O", "C", "D", "5", "R", "?", "I", "3", "G", "X", "F", "4", "J", "N", "U", "7", "H", " ,", "8", " .", "K", "B", "P", "3", "M", "Y", "Z", "W", "1", "6"};

       
        
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void ProgressBar_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Lectia_Nr_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void NumericUpDown_NrLectie_ValueChanged(object sender, EventArgs e)
        {

            decimal NrLectie = NumericUpDown_NrLectie.Value + 1;
            int NrCaracter1 = (int)NrLectie * 2 - 4;
            int NrCaracter2 = NrCaracter1 + 1;

            string rezultat = grupe[NrCaracter1] + "," + grupe[NrCaracter2];
            CaractereLectieCurenta.Text = rezultat.ToString();
        }

        private void CaractereLectieCurenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void Grupa_1_Cod_Morse_TextChanged(object sender, EventArgs e)
        {

        }

        private void Grupa_2_Cod_Morse_TextChanged(object sender, EventArgs e)
        {

        }

        private void Grupa_3_Cod_Morse_TextChanged(object sender, EventArgs e)
        {

        }

        private void Grupa_4_Cod_Morse_TextChanged(object sender, EventArgs e)
        {

        }

        private void Grupa_5_Cod_Morse_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void Caracter_Morse_Curent_TextChanged(object sender, EventArgs e)
        {

        }

        private void MorseLearningForm_Load(object sender, EventArgs e)
        {
            
        }

        private void CheckBox_Sart_Stop_Lectie_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton_Cod_Ascuns_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void RadioButton_Cod_La_Vedere_CheckedChanged(object sender, EventArgs e)
        {

        }
       
    }


}
