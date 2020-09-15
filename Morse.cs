using System;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;

namespace Morse_code_learning
{
    public partial class MorseLearningForm : Form
    {
        public MorseLearningForm()
        {
           
            InitializeComponent();
            

        }

        readonly string[] simbol = {"E", "L", "V", "0", "A", "S", "Q", "=", "T", "2", "O", "C", "D", "5", "R", "?", "I", "3", "G", "X", "F", "4", "J", "N", "U", "7", "H", " , ", "8", " . ", "K", "B", "P", "3", "M", "Y", "Z", "W", "1", "6"};
        string[] vspace = { " " };
        string SirNou, SirGrupa1, SirGrupa2, SirGrupa3, SirGrupa4, SirGrupa5 ;
        int i = 0;
        int CodAscuns = 0;

        private void NumericUpDown_NrLectie_ValueChanged(object sender, EventArgs e)
        {
           


            decimal NrLectie = NumericUpDown_NrLectie.Value -1 ;
            int NrCaracter1 = (int)NrLectie * 2 ;
            int NrCaracter2 = NrCaracter1 + 1;
            int NrCaracter = NrCaracter1;

            string SirRezultat = " "+simbol[NrCaracter1] + "," + simbol[NrCaracter2];
            CaractereLectieCurenta.Text = SirRezultat.ToString();
            
            string SirRezultat1 = " " + simbol[0] + "," + simbol[1];
            int NrLectie1 = (int) NrLectie;
            if (NrCaracter1 > 0)
            {
                for (int i = 1 ; i < NrLectie1+1 ; i++)
                {

                    SirRezultat1 = SirRezultat1 + "," + simbol[i*2] + "," + simbol[i*2+1];

                }
                
            }

            ProgressBar.Text = SirRezultat1.ToString();
        }
        private void ProgressBar_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void Lectia_Nr_TextChanged(object sender, EventArgs e)
        {

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

       

        public void Lectie_DoarGrupaNoua_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
            
        }
        public void START_Click(object sender, EventArgs e)
        {
            i = 1;
            SirGrupa1 = vspace[0];
            SirGrupa2 = vspace[0];
            SirGrupa3 = vspace[0];
            SirGrupa4 = vspace[0];
            SirGrupa5 = vspace[0];
            Grupa_1_Cod_Morse.Text = SirGrupa1.ToString();
            Grupa_2_Cod_Morse.Text = SirGrupa1.ToString();
            Grupa_3_Cod_Morse.Text = SirGrupa1.ToString();
            Grupa_4_Cod_Morse.Text = SirGrupa1.ToString();
            Grupa_5_Cod_Morse.Text = SirGrupa1.ToString();

        }


        public void STOP_Click(object sender, EventArgs e)
        {

            i = 0;
            

        }
        public void MorseLearningForm_Load(object sender, EventArgs e)
        {

          




            //  if(Boolean TX == true);
            //  if  tx true > generez caracter conf conditii lectie
            //  generez morse_code aferent caracter
            //  afisez caracter in > caracter curent Box 
            //                     > si apoi in grupa_x  Box




        }

        private void RadioButton_Cod_Ascuns_CheckedChanged(object sender, EventArgs e)
        {
           if( RadioButton_Cod_Ascuns.Checked == true) CodAscuns = 1;
            i = 0;
        }
        private void RadioButton_Cod_La_Vedere_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton_Cod_La_Vedere.Checked == true) CodAscuns = 0;
            i = 0;
        }
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if(i==51) i = 0;
            if (i > 0)
            {
                if (i == i / 2 * 2)
                {
                    Thread.Sleep(300);
                    Caracter_Morse_Curent.Text = vspace[0].ToString();
                   
                    Thread.Sleep(700);
                }
                else
                { 
                decimal NrLectie = NumericUpDown_NrLectie.Value;
                int NrCaracterTX_Max = (int)NrLectie * 2;
                int NrCaracterTX_Min = 0;

                    if (Lectie_DoarGrupaNoua_CheckBox.Checked)
                    {

                    NrCaracterTX_Min = (int)NrLectie * 2 - 2;

                    }

                Random rnd = new Random();

                int NrCaracterTX = rnd.Next(NrCaracterTX_Min, NrCaracterTX_Max);
                string CaracterRandomRezultat = simbol[NrCaracterTX];
                if(CodAscuns == 0 )Caracter_Morse_Curent.Text = CaracterRandomRezultat.ToString();
                Morse_Code Play = new Morse_Code(CaracterRandomRezultat);
                    if (i < 11)
                    {
                        SirGrupa1 = SirGrupa1 + vspace[0] + CaracterRandomRezultat;
                       if (CodAscuns==0) Grupa_1_Cod_Morse.Text = SirGrupa1.ToString();
                    }

                    else if (i < 21)
                    {
                        SirGrupa2 = SirGrupa2 + vspace[0] + CaracterRandomRezultat;
                        if (CodAscuns == 0) Grupa_2_Cod_Morse.Text = SirGrupa2.ToString();
                    }
                    else if (i < 31)
                    {
                        SirGrupa3 = SirGrupa3 + vspace[0] + CaracterRandomRezultat;
                        if (CodAscuns == 0) Grupa_3_Cod_Morse.Text = SirGrupa3.ToString();
                    }
                    else if (i < 41)
                    {
                        SirGrupa4 = SirGrupa4 + vspace[0] + CaracterRandomRezultat;
                       if (CodAscuns==0) Grupa_4_Cod_Morse.Text = SirGrupa4.ToString();
                    }
                    else 
                    {
                        SirGrupa5 = SirGrupa5 + vspace[0] + CaracterRandomRezultat;
                        if (CodAscuns == 0) Grupa_5_Cod_Morse.Text = SirGrupa5.ToString();
                    }
                }
                if (i==50)
                {
                    Grupa_1_Cod_Morse.Text = SirGrupa1.ToString();
                    Grupa_2_Cod_Morse.Text = SirGrupa2.ToString();
                    Grupa_3_Cod_Morse.Text = SirGrupa3.ToString();
                    Grupa_4_Cod_Morse.Text = SirGrupa4.ToString();
                    Grupa_5_Cod_Morse.Text = SirGrupa5.ToString();
                }
                i++;
            }
        }
    }


}
