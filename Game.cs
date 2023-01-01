using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace AdamAsmaca
{
    public partial class Game : Form
    {
        string[] splitCityName = new string[0];
        public static Random rnd = new Random();
        string cityName;
        int counterScore = 1;
        int life = 6;
        int score = 0;
        bool TF = false;
        public Game()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string answer = Interaction.InputBox("Enter Your Answer.", "GUESS");     

            if (cityName.ToLower() == answer.ToLower())
            {
                guna2MessageDialog1.Show("\n\n😄😄😄😄😄😄😄😄😄😄😄\n😄😄😄😄😄😄😄😄😄😄😄\n😄 CONGRATULATIONS!  😄\n😄😄😄😄😄😄😄😄😄😄😄\n😄😄😄😄😄😄😄😄😄😄😄");
                score = score + counterScore;
                label3.Text = score.ToString();
                StartGame();
            }
            else if (answer!="")
            {
                guna2MessageDialog2.Show("\n\n😫😫😫😫😫😫😫😫😫😫\n😫😫😫😫😫😫😫😫😫😫\n😫😫😫 WRONG!😫😫😫\n😫😫😫😫😫😫😫😫😫😫\n😫😫😫😫😫😫😫😫😫😫");
                life--;
                label2.Text = life.ToString();
            }
            if (answer.ToLower() == "creative by mehmet")                
            {
                labelHack.Visible = true;
                guna2MessageDialog1.Show("\n\n😄😄😄😄😄😄😄😄😄😄😄\n😄😄😄😄😄😄😄😄😄😄😄\n😄😄 CHEATS ACTIVE! 😄😄\n😄😄😄😄😄😄😄😄😄😄😄\n😄😄😄😄😄😄😄😄😄😄😄");
            }
        }

        private void Game_Load(object sender, EventArgs e)
        {
            StartGame();
            timer1.Start();
        }
        public void StartGame()
        {
            foreach (Control item in this.Controls)
                if (item is Panel)
                    foreach (Control item2 in (item as Panel).Controls)
                    {
                        if (item2 is PictureBox)
                            (item2 as PictureBox).Visible = false;
                        if (item2 is Label)
                            (item2 as Label).Visible = false;
                        if (item2 is Guna.UI2.WinForms.Guna2Button)
                            (item2 as Guna.UI2.WinForms.Guna2Button).Enabled = true;
                    }
            foreach (Control item in this.Controls)
                if (item.GetType().ToString() == "System.Windows.Forms.PictureBox") item.Visible = false;
            pictureBox1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            life = 6;
            label2.Text = life.ToString();
            int cityNumber = 0;
            int counter = 0;
            cityNumber = rnd.Next(0, 80);
            cityName = Main.citys[cityNumber];
            Array.Resize(ref splitCityName, cityName.Length);
            counterScore = cityName.Length;
            labelHack.Text = cityName;
            foreach (char c in cityName.ToCharArray())
            {
                splitCityName[counter] = c.ToString();
                counter++;
            }
            //for (int i = 0; i < splitCityName.Length; i++)
            //{
            //    MessageBox.Show(splitCityName[i]);
            //}
            //==========//Harfler ve Çizgiler\\==========\\
            switch (splitCityName.Length)
            {
                case 3:
                    p1.Visible = true;
                    p2.Visible = true;
                    p3.Visible = true;
                    h1.Visible = true;
                    h1.Text = "";
                    h2.Visible = true;
                    h2.Text = "";
                    h3.Visible = true;
                    h3.Text = "";
                    break;
                case 4:
                    p1.Visible = true;
                    p2.Visible = true;
                    p3.Visible = true;
                    p4.Visible = true;
                    h1.Visible = true;
                    h1.Text = "";
                    h2.Visible = true;
                    h2.Text = "";
                    h3.Visible = true;
                    h3.Text = "";
                    h4.Visible = true;
                    h4.Text = "";
                    break;
                case 5:
                    p1.Visible = true;
                    p2.Visible = true;
                    p3.Visible = true;
                    p4.Visible = true;
                    p5.Visible = true;
                    h1.Visible = true;
                    h1.Text = "";
                    h2.Visible = true;
                    h2.Text = "";
                    h3.Visible = true;
                    h3.Text = "";
                    h4.Visible = true;
                    h4.Text = "";
                    h5.Visible = true;
                    h5.Text = "";
                    break;
                case 6:
                    p1.Visible = true;
                    p2.Visible = true;
                    p3.Visible = true;
                    p4.Visible = true;
                    p5.Visible = true;
                    p6.Visible = true;
                    h1.Visible = true;
                    h1.Text = "";
                    h2.Visible = true;
                    h2.Text = "";
                    h3.Visible = true;
                    h3.Text = "";
                    h4.Visible = true;
                    h4.Text = "";
                    h5.Visible = true;
                    h5.Text = "";
                    h6.Visible = true;
                    h6.Text = "";
                    break;
                case 7:
                    p1.Visible = true;
                    p2.Visible = true;
                    p3.Visible = true;
                    p4.Visible = true;
                    p5.Visible = true;
                    p6.Visible = true;
                    p7.Visible = true;
                    h1.Visible = true;
                    h1.Text = "";
                    h2.Visible = true;
                    h2.Text = "";
                    h3.Visible = true;
                    h3.Text = "";
                    h4.Visible = true;
                    h4.Text = "";
                    h5.Visible = true;
                    h5.Text = "";
                    h6.Visible = true;
                    h6.Text = "";
                    h7.Visible = true;
                    h7.Text = "";
                    break;
                case 8:
                    p1.Visible = true;
                    p2.Visible = true;
                    p3.Visible = true;
                    p4.Visible = true;
                    p5.Visible = true;
                    p6.Visible = true;
                    p7.Visible = true;
                    p8.Visible = true;
                    h1.Visible = true;
                    h1.Text = "";
                    h2.Visible = true;
                    h2.Text = "";
                    h3.Visible = true;
                    h3.Text = "";
                    h4.Visible = true;
                    h4.Text = "";
                    h5.Visible = true;
                    h5.Text = "";
                    h6.Visible = true;
                    h6.Text = "";
                    h7.Visible = true;
                    h7.Text = "";
                    h8.Visible = true;
                    h8.Text = "";
                    break;
                case 9:
                    p1.Visible = true;
                    p2.Visible = true;
                    p3.Visible = true;
                    p4.Visible = true;
                    p5.Visible = true;
                    p6.Visible = true;
                    p7.Visible = true;
                    p8.Visible = true;
                    p9.Visible = true;
                    h1.Visible = true;
                    h1.Text = "";
                    h2.Visible = true;
                    h2.Text = "";
                    h3.Visible = true;
                    h3.Text = "";
                    h4.Visible = true;
                    h4.Text = "";
                    h5.Visible = true;
                    h5.Text = "";
                    h6.Visible = true;
                    h6.Text = "";
                    h7.Visible = true;
                    h7.Text = "";
                    h8.Visible = true;
                    h8.Text = "";
                    h9.Visible = true;
                    h9.Text = "";
                    break;
                case 10:
                    p1.Visible = true;
                    p2.Visible = true;
                    p3.Visible = true;
                    p4.Visible = true;
                    p5.Visible = true;
                    p6.Visible = true;
                    p7.Visible = true;
                    p8.Visible = true;
                    p9.Visible = true;
                    p10.Visible = true;
                    h1.Visible = true;
                    h1.Text = "";
                    h2.Visible = true;
                    h2.Text = "";
                    h3.Visible = true;
                    h3.Text = "";
                    h4.Visible = true;
                    h4.Text = "";
                    h5.Visible = true;
                    h5.Text = "";
                    h6.Visible = true;
                    h6.Text = "";
                    h7.Visible = true;
                    h7.Text = "";
                    h8.Visible = true;
                    h8.Text = "";
                    h9.Visible = true;
                    h9.Text = "";
                    h10.Visible = true;
                    h10.Text = "";
                    break;
                case 11:
                    p1.Visible = true;
                    p2.Visible = true;
                    p3.Visible = true;
                    p4.Visible = true;
                    p5.Visible = true;
                    p6.Visible = true;
                    p7.Visible = true;
                    p8.Visible = true;
                    p9.Visible = true;
                    p10.Visible = true;
                    p11.Visible = true;
                    h1.Visible = true;
                    h1.Text = "";
                    h2.Visible = true;
                    h2.Text = "";
                    h3.Visible = true;
                    h3.Text = "";
                    h4.Visible = true;
                    h4.Text = "";
                    h5.Visible = true;
                    h5.Text = "";
                    h6.Visible = true;
                    h6.Text = "";
                    h7.Visible = true;
                    h7.Text = "";
                    h8.Visible = true;
                    h8.Text = "";
                    h9.Visible = true;
                    h9.Text = "";
                    h10.Visible = true;
                    h10.Text = "";
                    h11.Visible = true;
                    h11.Text = "";
                    break;
                case 12:
                    p1.Visible = true;
                    p2.Visible = true;
                    p3.Visible = true;
                    p4.Visible = true;
                    p5.Visible = true;
                    p6.Visible = true;
                    p7.Visible = true;
                    p8.Visible = true;
                    p9.Visible = true;
                    p10.Visible = true;
                    p11.Visible = true;
                    p12.Visible = true;
                    h1.Visible = true;
                    h1.Text = "";
                    h2.Visible = true;
                    h2.Text = "";
                    h3.Visible = true;
                    h3.Text = "";
                    h4.Visible = true;
                    h4.Text = "";
                    h5.Visible = true;
                    h5.Text = "";
                    h6.Visible = true;
                    h6.Text = "";
                    h7.Visible = true;
                    h7.Text = "";
                    h8.Visible = true;
                    h8.Text = "";
                    h9.Visible = true;
                    h9.Text = "";
                    h10.Visible = true;
                    h10.Text = "";
                    h11.Visible = true;
                    h11.Text = "";
                    h12.Visible = true;
                    h12.Text = "";
                    break;
                case 13:
                    p1.Visible = true;
                    p2.Visible = true;
                    p3.Visible = true;
                    p4.Visible = true;
                    p5.Visible = true;
                    p6.Visible = true;
                    p7.Visible = true;
                    p8.Visible = true;
                    p9.Visible = true;
                    p10.Visible = true;
                    p11.Visible = true;
                    p12.Visible = true;
                    p13.Visible = true;
                    h1.Visible = true;
                    h1.Text = "";
                    h2.Visible = true;
                    h2.Text = "";
                    h3.Visible = true;
                    h3.Text = "";
                    h4.Visible = true;
                    h4.Text = "";
                    h5.Visible = true;
                    h5.Text = "";
                    h6.Visible = true;
                    h6.Text = "";
                    h7.Visible = true;
                    h7.Text = "";
                    h8.Visible = true;
                    h8.Text = "";
                    h9.Visible = true;
                    h9.Text = "";
                    h10.Visible = true;
                    h10.Text = "";
                    h11.Visible = true;
                    h11.Text = "";
                    h12.Visible = true;
                    h12.Text = "";
                    h13.Visible = true;
                    h13.Text = "";
                    break;
                case 14:
                    p1.Visible = true;
                    p2.Visible = true;
                    p3.Visible = true;
                    p4.Visible = true;
                    p5.Visible = true;
                    p6.Visible = true;
                    p7.Visible = true;
                    p8.Visible = true;
                    p9.Visible = true;
                    p10.Visible = true;
                    p11.Visible = true;
                    p12.Visible = true;
                    p13.Visible = true;
                    p14.Visible = true;
                    h1.Visible = true;
                    h1.Text = "";
                    h2.Visible = true;
                    h2.Text = "";
                    h3.Visible = true;
                    h3.Text = "";
                    h4.Visible = true;
                    h4.Text = "";
                    h5.Visible = true;
                    h5.Text = "";
                    h6.Visible = true;
                    h6.Text = "";
                    h7.Visible = true;
                    h7.Text = "";
                    h8.Visible = true;
                    h8.Text = "";
                    h9.Visible = true;
                    h9.Text = "";
                    h10.Visible = true;
                    h10.Text = "";
                    h11.Visible = true;
                    h11.Text = "";
                    h12.Visible = true;
                    h12.Text = "";
                    h13.Visible = true;
                    h13.Text = "";
                    h14.Visible = true;
                    h14.Text = "";
                    break;
            }
        }

        private void a_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < splitCityName.Length; i++)
            {
                if (splitCityName[i].ToUpper() == "A")
                {
                    sayac = i + 1;
                    TF = true;
                    switch (sayac)
                    {
                        case 1:
                            h1.Text = "A";
                            counterScore--;
                            break;
                        case 2:
                            h2.Text = "A";
                            counterScore--;
                            break;
                        case 3:
                            h3.Text = "A";
                            counterScore--;
                            break;
                        case 4:
                            h4.Text = "A";
                            counterScore--;
                            break;
                        case 5:
                            h5.Text = "A";
                            counterScore--;
                            break;
                        case 6:
                            h6.Text = "A";
                            counterScore--;
                            break;
                        case 7:
                            h7.Text = "A";
                            counterScore--;
                            break;
                        case 8:
                            h8.Text = "A";
                            counterScore--;
                            break;
                        case 9:
                            h9.Text = "A";
                            counterScore--;
                            break;
                        case 10:
                            h10.Text = "A";
                            counterScore--;
                            break;
                        case 11:
                            h11.Text = "A";
                            counterScore--;
                            break;
                        case 12:
                            h12.Text = "A";
                            counterScore--;
                            break;
                        case 13:
                            h13.Text = "A";
                            counterScore--;
                            break;
                        case 14:
                            h14.Text = "A";
                            counterScore--;
                            break;
                    }
                }
            }
            if (!TF)
            {
                life--;
                label2.Text = life.ToString();
                if (life == 5)
                    stage1.Visible = true;
                if (life + 1 == 5)
                {
                    stage2.Visible = true;
                    stage1.Visible = false;
                }
                if (life + 1 == 4)
                {
                    stage3.Visible = true;
                    stage2.Visible = false;
                }
                if (life + 1 == 3)
                {
                    stage4.Visible = true;
                    stage3.Visible = false;
                }
                if (life + 1 == 2)
                {
                    stage5.Visible = true;
                    stage4.Visible = false;
                }
                if (life + 1 == 1)
                {
                    stage6.Visible = true;
                    stage5.Visible = false;
                }
            }
            TF = false;
            a.Enabled = false;
        }

        private void b_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < splitCityName.Length; i++)
            {
                if (splitCityName[i].ToUpper() == "B")
                {
                    sayac = i + 1;
                    TF = true;
                    switch (sayac)
                    {
                        case 1:
                            h1.Text = "B";
                            counterScore--;
                            break;
                        case 2:
                            h2.Text = "B";
                            counterScore--;
                            break;
                        case 3:
                            h3.Text = "B";
                            counterScore--;
                            break;
                        case 4:
                            h4.Text = "B";
                            counterScore--;
                            break;
                        case 5:
                            h5.Text = "B";
                            counterScore--;
                            break;
                        case 6:
                            h6.Text = "B";
                            counterScore--;
                            break;
                        case 7:
                            h7.Text = "B";
                            counterScore--;
                            break;
                        case 8:
                            h8.Text = "B";
                            counterScore--;
                            break;
                        case 9:
                            h9.Text = "B";
                            counterScore--;
                            break;
                        case 10:
                            h10.Text = "B";
                            counterScore--;
                            break;
                        case 11:
                            h11.Text = "B";
                            counterScore--;
                            break;
                        case 12:
                            h12.Text = "B";
                            counterScore--;
                            break;
                        case 13:
                            h13.Text = "B";
                            counterScore--;
                            break;
                        case 14:
                            h14.Text = "B";
                            counterScore--;
                            break;
                    }
                }

            }
            if (!TF)
            {
                life--;
                label2.Text = life.ToString();
                if (life == 5)
                    stage1.Visible = true;
                if (life + 1 == 5)
                {
                    stage2.Visible = true;
                    stage1.Visible = false;
                }
                if (life + 1 == 4)
                {
                    stage3.Visible = true;
                    stage2.Visible = false;
                }
                if (life + 1 == 3)
                {
                    stage4.Visible = true;
                    stage3.Visible = false;
                }
                if (life + 1 == 2)
                {
                    stage5.Visible = true;
                    stage4.Visible = false;
                }
                if (life + 1 == 1)
                {
                    stage6.Visible = true;
                    stage5.Visible = false;
                }
            }
            b.Enabled = false;
            TF = false;
        }

        private void c_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < splitCityName.Length; i++)
            {
                if (splitCityName[i].ToUpper() == "C")
                {
                    sayac = i + 1;
                    TF = true;
                    switch (sayac)
                    {
                        case 1:
                            h1.Text = "C";
                            counterScore--;
                            break;
                        case 2:
                            h2.Text = "C";
                            counterScore--;
                            break;
                        case 3:
                            h3.Text = "C";
                            counterScore--;
                            break;
                        case 4:
                            h4.Text = "C"; 
                            counterScore--;
                            break;
                        case 5:
                            h5.Text = "C"; 
                            counterScore--;
                            break;
                        case 6:
                            h6.Text = "C"; 
                            counterScore--;
                            break;
                        case 7:
                            h7.Text = "C"; 
                            counterScore--;
                            break;
                        case 8:
                            h8.Text = "C"; 
                            counterScore--;
                            break;
                        case 9:
                            h9.Text = "C"; 
                            counterScore--;
                            break;
                        case 10:
                            h10.Text = "C";
                            counterScore--;
                            break;
                        case 11:
                            h11.Text = "C"; 
                            counterScore--;
                            break;
                        case 12:
                            h12.Text = "C";
                            counterScore--;
                            break;
                        case 13:
                            h13.Text = "C"; 
                            counterScore--;
                            break;
                        case 14:
                            h14.Text = "C"; 
                            counterScore--;
                            break;
                    }
                }

            }
            if (!TF)
            {
                life--;
                label2.Text = life.ToString();
                if (life == 5)
                    stage1.Visible = true;
                if (life + 1 == 5)
                {
                    stage2.Visible = true;
                    stage1.Visible = false;
                }
                if (life + 1 == 4)
                {
                    stage3.Visible = true;
                    stage2.Visible = false;
                }
                if (life + 1 == 3)
                {
                    stage4.Visible = true;
                    stage3.Visible = false;
                }
                if (life + 1 == 2)
                {
                    stage5.Visible = true;
                    stage4.Visible = false;
                }
                if (life + 1 == 1)
                {
                    stage6.Visible = true;
                    stage5.Visible = false;
                }
            }
            c.Enabled = false;
            TF = false;
        }

        private void c2_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < splitCityName.Length; i++)
            {
                if (splitCityName[i].ToUpper() == "Ç")
                {
                    sayac = i + 1;
                    TF = true;
                    switch (sayac)
                    {
                        case 1:
                            h1.Text = "Ç";
                            counterScore--;
                            break;
                        case 2:
                            h2.Text = "Ç";
                            counterScore--;
                            break;
                        case 3:
                            h3.Text = "Ç";
                            counterScore--;
                            break;
                        case 4:
                            h4.Text = "Ç";
                            counterScore--;
                            break;
                        case 5:
                            h5.Text = "Ç";
                            counterScore--;
                            break;
                        case 6:
                            h6.Text = "Ç";
                            counterScore--;
                            break;
                        case 7:
                            h7.Text = "Ç";
                            counterScore--;
                            break;
                        case 8:
                            h8.Text = "Ç";
                            counterScore--;
                            break;
                        case 9:
                            h9.Text = "Ç";
                            counterScore--;
                            break;
                        case 10:
                            h10.Text = "Ç";
                            counterScore--;
                            break;
                        case 11:
                            h11.Text = "Ç";
                            counterScore--;
                            break;
                        case 12:
                            h12.Text = "Ç";
                            counterScore--;
                            break;
                        case 13:
                            h13.Text = "Ç";
                            counterScore--;
                            break;
                        case 14:
                            h14.Text = "Ç";
                            counterScore--;
                            break;
                    }
                }

            }
            if (!TF)
            {
                life--;
                label2.Text = life.ToString();
                if (life == 5)
                    stage1.Visible = true;
                if (life + 1 == 5)
                {
                    stage2.Visible = true;
                    stage1.Visible = false;
                }
                if (life + 1 == 4)
                {
                    stage3.Visible = true;
                    stage2.Visible = false;
                }
                if (life + 1 == 3)
                {
                    stage4.Visible = true;
                    stage3.Visible = false;
                }
                if (life + 1 == 2)
                {
                    stage5.Visible = true;
                    stage4.Visible = false;
                }
                if (life + 1 == 1)
                {
                    stage6.Visible = true;
                    stage5.Visible = false;
                }
            }
            c2.Enabled = false;
            TF = false;
        }

        private void d_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < splitCityName.Length; i++)
            {
                if (splitCityName[i].ToUpper() == "D")
                {
                    sayac = i + 1;
                    TF = true;
                    switch (sayac)
                    {
                        case 1:
                            h1.Text = "D";
                            counterScore--;
                            break;
                        case 2:
                            h2.Text = "D";
                            counterScore--;
                            break;
                        case 3:
                            h3.Text = "D";
                            counterScore--;
                            break;
                        case 4:
                            h4.Text = "D";
                            counterScore--;
                            break;
                        case 5:
                            h5.Text = "D";
                            counterScore--;
                            break;
                        case 6:
                            h6.Text = "D";
                            counterScore--;
                            break;
                        case 7:
                            h7.Text = "D";
                            counterScore--;
                            break;
                        case 8:
                            h8.Text = "D";
                            counterScore--;
                            break;
                        case 9:
                            h9.Text = "D";
                            counterScore--;
                            break;
                        case 10:
                            h10.Text = "D";
                            counterScore--;
                            break;
                        case 11:
                            h11.Text = "D";
                            counterScore--;
                            break;
                        case 12:
                            h12.Text = "D";
                            counterScore--;
                            break;
                        case 13:
                            h13.Text = "D";
                            counterScore--;
                            break;
                        case 14:
                            h14.Text = "D";
                            counterScore--;
                            break;
                    }
                }

            }
            if (!TF)
            {
                life--;
                label2.Text = life.ToString();
                if (life == 5)
                    stage1.Visible = true;
                if (life + 1 == 5)
                {
                    stage2.Visible = true;
                    stage1.Visible = false;
                }
                if (life + 1 == 4)
                {
                    stage3.Visible = true;
                    stage2.Visible = false;
                }
                if (life + 1 == 3)
                {
                    stage4.Visible = true;
                    stage3.Visible = false;
                }
                if (life + 1 == 2)
                {
                    stage5.Visible = true;
                    stage4.Visible = false;
                }
                if (life + 1 == 1)
                {
                    stage6.Visible = true;
                    stage5.Visible = false;
                }
            }
            d.Enabled = false;
            TF = false;
        }

        private void e2_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < splitCityName.Length; i++)
            {
                if (splitCityName[i].ToUpper() == "E")
                {
                    sayac = i + 1;
                    TF = true;
                    switch (sayac)
                    {
                        case 1:
                            h1.Text = "E";
                            counterScore--;
                            break;
                        case 2:
                            h2.Text = "E";
                            counterScore--;
                            break;
                        case 3:
                            h3.Text = "E";
                            counterScore--;
                            break;
                        case 4:
                            h4.Text = "E";
                            counterScore--;
                            break;
                        case 5:
                            h5.Text = "E";
                            counterScore--;
                            break;
                        case 6:
                            h6.Text = "E";
                            counterScore--;
                            break;
                        case 7:
                            h7.Text = "E";
                            counterScore--;
                            break;
                        case 8:
                            h8.Text = "E";
                            counterScore--;
                            break;
                        case 9:
                            h9.Text = "E";
                            counterScore--;
                            break;
                        case 10:
                            h10.Text = "E";
                            counterScore--;
                            break;
                        case 11:
                            h11.Text = "E";
                            counterScore--;
                            break;
                        case 12:
                            h12.Text = "E";
                            counterScore--;
                            break;
                        case 13:
                            h13.Text = "E";
                            counterScore--;
                            break;
                        case 14:
                            h14.Text = "E";
                            counterScore--;
                            break;
                    }
                }

            }
            if (!TF)
            {
                life--;
                label2.Text = life.ToString();
                if (life == 5)
                    stage1.Visible = true;
                if (life + 1 == 5)
                {
                    stage2.Visible = true;
                    stage1.Visible = false;
                }
                if (life + 1 == 4)
                {
                    stage3.Visible = true;
                    stage2.Visible = false;
                }
                if (life + 1 == 3)
                {
                    stage4.Visible = true;
                    stage3.Visible = false;
                }
                if (life + 1 == 2)
                {
                    stage5.Visible = true;
                    stage4.Visible = false;
                }
                if (life + 1 == 1)
                {
                    stage6.Visible = true;
                    stage5.Visible = false;
                }
            }
            e2.Enabled = false;
            TF = false;
        }

        private void f_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < splitCityName.Length; i++)
            {
                if (splitCityName[i].ToUpper() == "F")
                {
                    sayac = i + 1;
                    TF = true;
                    switch (sayac)
                    {
                        case 1:
                            h1.Text = "F";
                            counterScore--;
                            break;
                        case 2:
                            h2.Text = "F";
                            counterScore--;
                            break;
                        case 3:
                            h3.Text = "F";
                            counterScore--;
                            break;
                        case 4:
                            h4.Text = "F";
                            counterScore--;
                            break;
                        case 5:
                            h5.Text = "F";
                            counterScore--;
                            break;
                        case 6:
                            h6.Text = "F";
                            counterScore--;
                            break;
                        case 7:
                            h7.Text = "F";
                            counterScore--;
                            break;
                        case 8:
                            h8.Text = "F";
                            counterScore--;
                            break;
                        case 9:
                            h9.Text = "F";
                            counterScore--;
                            break;
                        case 10:
                            h10.Text = "F";
                            counterScore--;
                            break;
                        case 11:
                            h11.Text = "F";
                            counterScore--;
                            break;
                        case 12:
                            h12.Text = "F";
                            counterScore--;
                            break;
                        case 13:
                            h13.Text = "F";
                            counterScore--;
                            break;
                        case 14:
                            h14.Text = "F";
                            counterScore--;
                            break;
                    }
                }

            }
            if (!TF)
            {
                life--;
                label2.Text = life.ToString();
                if (life == 5)
                    stage1.Visible = true;
                if (life + 1 == 5)
                {
                    stage2.Visible = true;
                    stage1.Visible = false;
                }
                if (life + 1 == 4)
                {
                    stage3.Visible = true;
                    stage2.Visible = false;
                }
                if (life + 1 == 3)
                {
                    stage4.Visible = true;
                    stage3.Visible = false;
                }
                if (life + 1 == 2)
                {
                    stage5.Visible = true;
                    stage4.Visible = false;
                }
                if (life + 1 == 1)
                {
                    stage6.Visible = true;
                    stage5.Visible = false;
                }
            }
            f.Enabled = false;
            TF = false;
        }

        private void g_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < splitCityName.Length; i++)
            {
                if (splitCityName[i].ToUpper() == "G")
                {
                    sayac = i + 1;
                    TF = true;
                    switch (sayac)
                    {
                        case 1:
                            h1.Text = "G";
                            counterScore--;
                            break;
                        case 2:
                            h2.Text = "G";
                            counterScore--;
                            break;
                        case 3:
                            h3.Text = "G";
                            counterScore--;
                            break;
                        case 4:
                            h4.Text = "G";
                            counterScore--;
                            break;
                        case 5:
                            h5.Text = "G";
                            counterScore--;
                            break;
                        case 6:
                            h6.Text = "G";
                            counterScore--;
                            break;
                        case 7:
                            h7.Text = "G";
                            counterScore--;
                            break;
                        case 8:
                            h8.Text = "G";
                            counterScore--;
                            break;
                        case 9:
                            h9.Text = "G";
                            counterScore--;
                            break;
                        case 10:
                            h10.Text = "G";
                            counterScore--;
                            break;
                        case 11:
                            h11.Text = "G";
                            counterScore--;
                            break;
                        case 12:
                            h12.Text = "G";
                            counterScore--;
                            break;
                        case 13:
                            h13.Text = "G";
                            counterScore--;
                            break;
                        case 14:
                            h14.Text = "G";
                            counterScore--;
                            break;
                    }
                }

            }
            if (!TF)
            {
                life--;
                label2.Text = life.ToString();
                if (life == 5)
                    stage1.Visible = true;
                if (life + 1 == 5)
                {
                    stage2.Visible = true;
                    stage1.Visible = false;
                }
                if (life + 1 == 4)
                {
                    stage3.Visible = true;
                    stage2.Visible = false;
                }
                if (life + 1 == 3)
                {
                    stage4.Visible = true;
                    stage3.Visible = false;
                }
                if (life + 1 == 2)
                {
                    stage5.Visible = true;
                    stage4.Visible = false;
                }
                if (life + 1 == 1)
                {
                    stage6.Visible = true;
                    stage5.Visible = false;
                }
            }
            g.Enabled = false;
            TF = false;
        }

        private void g2_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < splitCityName.Length; i++)
            {
                if (splitCityName[i].ToUpper() == "Ğ")
                {
                    sayac = i + 1;
                    TF = true;
                    switch (sayac)
                    {
                        case 1:
                            h1.Text = "Ğ";
                            counterScore--;
                            break;
                        case 2:
                            h2.Text = "Ğ";
                            counterScore--;
                            break;
                        case 3:
                            h3.Text = "Ğ";
                            counterScore--;
                            break;
                        case 4:
                            h4.Text = "Ğ";
                            counterScore--;
                            break;
                        case 5:
                            h5.Text = "Ğ";
                            counterScore--;
                            break;
                        case 6:
                            h6.Text = "Ğ";
                            counterScore--;
                            break;
                        case 7:
                            h7.Text = "Ğ";
                            counterScore--;
                            break;
                        case 8:
                            h8.Text = "Ğ";
                            counterScore--;
                            break;
                        case 9:
                            h9.Text = "Ğ";
                            counterScore--;
                            break;
                        case 10:
                            h10.Text = "Ğ";
                            counterScore--;
                            break;
                        case 11:
                            h11.Text = "Ğ";
                            counterScore--;
                            break;
                        case 12:
                            h12.Text = "Ğ";
                            counterScore--;
                            break;
                        case 13:
                            h13.Text = "Ğ";
                            counterScore--;
                            break;
                        case 14:
                            h14.Text = "Ğ";
                            counterScore--;
                            break;
                    }
                }
            }
            if (!TF)
            {
                life--;
                label2.Text = life.ToString();
                if (life == 5)
                    stage1.Visible = true;
                if (life + 1 == 5)
                {
                    stage2.Visible = true;
                    stage1.Visible = false;
                }
                if (life + 1 == 4)
                {
                    stage3.Visible = true;
                    stage2.Visible = false;
                }
                if (life + 1 == 3)
                {
                    stage4.Visible = true;
                    stage3.Visible = false;
                }
                if (life + 1 == 2)
                {
                    stage5.Visible = true;
                    stage4.Visible = false;
                }
                if (life + 1 == 1)
                {
                    stage6.Visible = true;
                    stage5.Visible = false;
                }
            }
            g2.Enabled = false;
            TF = false;
        }

        private void h_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < splitCityName.Length; i++)
            {
                if (splitCityName[i].ToUpper() == "H")
                {
                    sayac = i + 1;
                    TF = true;
                    switch (sayac)
                    {
                        case 1:
                            h1.Text = "H";
                            counterScore--;
                            break;
                        case 2:
                            h2.Text = "H";
                            counterScore--;
                            break;
                        case 3:
                            h3.Text = "H";
                            counterScore--;
                            break;
                        case 4:
                            h4.Text = "H";
                            counterScore--;
                            break;
                        case 5:
                            h5.Text = "H";
                            counterScore--;
                            break;
                        case 6:
                            h6.Text = "H";
                            counterScore--;
                            break;
                        case 7:
                            h7.Text = "H";
                            counterScore--;
                            break;
                        case 8:
                            h8.Text = "H";
                            counterScore--;
                            break;
                        case 9:
                            h9.Text = "H";
                            counterScore--;
                            break;
                        case 10:
                            h10.Text = "H";
                            counterScore--;
                            break;
                        case 11:
                            h11.Text = "H";
                            counterScore--;
                            break;
                        case 12:
                            h12.Text = "H";
                            counterScore--;
                            break;
                        case 13:
                            h13.Text = "H";
                            counterScore--;
                            break;
                        case 14:
                            h14.Text = "H";
                            counterScore--;
                            break;
                    }
                }

            }
            if (!TF)
            {
                life--;
                label2.Text = life.ToString();
                if (life == 5)
                    stage1.Visible = true;
                if (life + 1 == 5)
                {
                    stage2.Visible = true;
                    stage1.Visible = false;
                }
                if (life + 1 == 4)
                {
                    stage3.Visible = true;
                    stage2.Visible = false;
                }
                if (life + 1 == 3)
                {
                    stage4.Visible = true;
                    stage3.Visible = false;
                }
                if (life + 1 == 2)
                {
                    stage5.Visible = true;
                    stage4.Visible = false;
                }
                if (life + 1 == 1)
                {
                    stage6.Visible = true;
                    stage5.Visible = false;
                }
            }
            h.Enabled = false;
            TF = false;
        }

        private void i_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < splitCityName.Length; i++)
            {
                if (splitCityName[i].ToUpper() == "İ")
                {
                    sayac = i + 1;
                    TF = true;
                    switch (sayac)
                    {
                        case 1:
                            h1.Text = "İ";
                            counterScore--;
                            break;
                        case 2:
                            h2.Text = "İ";
                            counterScore--;
                            break;
                        case 3:
                            h3.Text = "İ";
                            counterScore--;
                            break;
                        case 4:
                            h4.Text = "İ";
                            counterScore--;
                            break;
                        case 5:
                            h5.Text = "İ";
                            counterScore--;
                            break;
                        case 6:
                            h6.Text = "İ";
                            counterScore--;
                            break;
                        case 7:
                            h7.Text = "İ";
                            counterScore--;
                            break;
                        case 8:
                            h8.Text = "İ";
                            counterScore--;
                            break;
                        case 9:
                            h9.Text = "İ";
                            counterScore--;
                            break;
                        case 10:
                            h10.Text = "İ";
                            counterScore--;
                            break;
                        case 11:
                            h11.Text = "İ";
                            counterScore--;
                            break;
                        case 12:
                            h12.Text = "İ";
                            counterScore--;
                            break;
                        case 13:
                            h13.Text = "İ";
                            counterScore--;
                            break;
                        case 14:
                            h14.Text = "İ";
                            counterScore--;
                            break;
                    }
                }

            }
            if (!TF)
            {
                life--;
                label2.Text = life.ToString();
                if (life == 5)
                    stage1.Visible = true;
                if (life + 1 == 5)
                {
                    stage2.Visible = true;
                    stage1.Visible = false;
                }
                if (life + 1 == 4)
                {
                    stage3.Visible = true;
                    stage2.Visible = false;
                }
                if (life + 1 == 3)
                {
                    stage4.Visible = true;
                    stage3.Visible = false;
                }
                if (life + 1 == 2)
                {
                    stage5.Visible = true;
                    stage4.Visible = false;
                }
                if (life + 1 == 1)
                {
                    stage6.Visible = true;
                    stage5.Visible = false;
                }
            }
            i.Enabled = false;
            TF = false;
        }

        private void i2_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < splitCityName.Length; i++)
            {
                if (splitCityName[i].ToUpper() == "I")
                {
                    sayac = i + 1;
                    TF = true;
                    switch (sayac)
                    {
                        case 1:
                            h1.Text = "I";
                            counterScore--;
                            break;
                        case 2:
                            h2.Text = "I";
                            counterScore--;
                            break;
                        case 3:
                            h3.Text = "I";
                            counterScore--;
                            break;
                        case 4:
                            h4.Text = "I";
                            counterScore--;
                            break;
                        case 5:
                            h5.Text = "I";
                            counterScore--;
                            break;
                        case 6:
                            h6.Text = "I";
                            counterScore--;
                            break;
                        case 7:
                            h7.Text = "I";
                            counterScore--;
                            break;
                        case 8:
                            h8.Text = "I";
                            counterScore--;
                            break;
                        case 9:
                            h9.Text = "I";
                            counterScore--;
                            break;
                        case 10:
                            h10.Text = "I";
                            counterScore--;
                            break;
                        case 11:
                            h11.Text = "I";
                            counterScore--;
                            break;
                        case 12:
                            h12.Text = "I";
                            counterScore--;
                            break;
                        case 13:
                            h13.Text = "I";
                            counterScore--;
                            break;
                        case 14:
                            h14.Text = "I";
                            counterScore--;
                            break;
                    }
                }

            }
            if (!TF)
            {
                life--;
                label2.Text = life.ToString();
                if (life == 5)
                    stage1.Visible = true;
                if (life + 1 == 5)
                {
                    stage2.Visible = true;
                    stage1.Visible = false;
                }
                if (life + 1 == 4)
                {
                    stage3.Visible = true;
                    stage2.Visible = false;
                }
                if (life + 1 == 3)
                {
                    stage4.Visible = true;
                    stage3.Visible = false;
                }
                if (life + 1 == 2)
                {
                    stage5.Visible = true;
                    stage4.Visible = false;
                }
                if (life + 1 == 1)
                {
                    stage6.Visible = true;
                    stage5.Visible = false;
                }
            }
            i2.Enabled = false;
            TF = false;
        }

        private void j_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < splitCityName.Length; i++)
            {
                if (splitCityName[i].ToUpper() == "J")
                {
                    sayac = i + 1;
                    TF = true;
                    switch (sayac)
                    {
                        case 1:
                            h1.Text = "J";
                            counterScore--;
                            break;
                        case 2:
                            h2.Text = "J";
                            counterScore--;
                            break;
                        case 3:
                            h3.Text = "J";
                            counterScore--;
                            break;
                        case 4:
                            h4.Text = "J";
                            counterScore--;
                            break;
                        case 5:
                            h5.Text = "J";
                            counterScore--;
                            break;
                        case 6:
                            h6.Text = "J";
                            counterScore--;
                            break;
                        case 7:
                            h7.Text = "J";
                            counterScore--;
                            break;
                        case 8:
                            h8.Text = "J";
                            counterScore--;
                            break;
                        case 9:
                            h9.Text = "J";
                            counterScore--;
                            break;
                        case 10:
                            h10.Text = "J";
                            counterScore--;
                            break;
                        case 11:
                            h11.Text = "J";
                            counterScore--;
                            break;
                        case 12:
                            h12.Text = "J";
                            counterScore--;
                            break;
                        case 13:
                            h13.Text = "J";
                            counterScore--;
                            break;
                        case 14:
                            h14.Text = "J";
                            counterScore--;
                            break;
                    }
                }

            }
            if (!TF)
            {
                life--;
                label2.Text = life.ToString();
                if (life == 5)
                    stage1.Visible = true;
                if (life + 1 == 5)
                {
                    stage2.Visible = true;
                    stage1.Visible = false;
                }
                if (life + 1 == 4)
                {
                    stage3.Visible = true;
                    stage2.Visible = false;
                }
                if (life + 1 == 3)
                {
                    stage4.Visible = true;
                    stage3.Visible = false;
                }
                if (life + 1 == 2)
                {
                    stage5.Visible = true;
                    stage4.Visible = false;
                }
                if (life + 1 == 1)
                {
                    stage6.Visible = true;
                    stage5.Visible = false;
                }
            }
            j.Enabled = false;
            TF = false;
        }

        private void k_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < splitCityName.Length; i++)
            {
                if (splitCityName[i].ToUpper() == "K")
                {
                    sayac = i + 1;
                    TF = true;
                    switch (sayac)
                    {
                        case 1:
                            h1.Text = "K";
                            counterScore--;
                            break;
                        case 2:
                            h2.Text = "K";
                            counterScore--;
                            break;
                        case 3:
                            h3.Text = "K";
                            counterScore--;
                            break;
                        case 4:
                            h4.Text = "K";
                            counterScore--;
                            break;
                        case 5:
                            h5.Text = "K";
                            counterScore--;
                            break;
                        case 6:
                            h6.Text = "K";
                            counterScore--;
                            break;
                        case 7:
                            h7.Text = "K";
                            counterScore--;
                            break;
                        case 8:
                            h8.Text = "K";
                            counterScore--;
                            break;
                        case 9:
                            h9.Text = "K";
                            counterScore--;
                            break;
                        case 10:
                            h10.Text = "K";
                            counterScore--;
                            break;
                        case 11:
                            h11.Text = "K";
                            counterScore--;
                            break;
                        case 12:
                            h12.Text = "K";
                            counterScore--;
                            break;
                        case 13:
                            h13.Text = "K";
                            counterScore--;
                            break;
                        case 14:
                            h14.Text = "K";
                            counterScore--;
                            break;
                    }
                }

            }
            if (!TF)
            {
                life--;
                label2.Text = life.ToString();
                if (life == 5)
                    stage1.Visible = true;
                if (life + 1 == 5)
                {
                    stage2.Visible = true;
                    stage1.Visible = false;
                }
                if (life + 1 == 4)
                {
                    stage3.Visible = true;
                    stage2.Visible = false;
                }
                if (life + 1 == 3)
                {
                    stage4.Visible = true;
                    stage3.Visible = false;
                }
                if (life + 1 == 2)
                {
                    stage5.Visible = true;
                    stage4.Visible = false;
                }
                if (life + 1 == 1)
                {
                    stage6.Visible = true;
                    stage5.Visible = false;
                }
            }
            k.Enabled = false;
            TF = false;
        }

        private void l_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < splitCityName.Length; i++)
            {
                if (splitCityName[i].ToUpper() == "L")
                {
                    sayac = i + 1;
                    TF = true;
                    switch (sayac)
                    {
                        case 1:
                            h1.Text = "L";
                            counterScore--;
                            break;
                        case 2:
                            h2.Text = "L";
                            counterScore--;
                            break;
                        case 3:
                            h3.Text = "L";
                            counterScore--;
                            break;
                        case 4:
                            h4.Text = "L";
                            counterScore--;
                            break;
                        case 5:
                            h5.Text = "L";
                            counterScore--;
                            break;
                        case 6:
                            h6.Text = "L";
                            counterScore--;
                            break;
                        case 7:
                            h7.Text = "L";
                            counterScore--;
                            break;
                        case 8:
                            h8.Text = "L";
                            counterScore--;
                            break;
                        case 9:
                            h9.Text = "L";
                            counterScore--;
                            break;
                        case 10:
                            h10.Text = "L";
                            counterScore--;
                            break;
                        case 11:
                            h11.Text = "L";
                            counterScore--;
                            break;
                        case 12:
                            h12.Text = "L";
                            counterScore--;
                            break;
                        case 13:
                            h13.Text = "L";
                            counterScore--;
                            break;
                        case 14:
                            h14.Text = "L";
                            counterScore--;
                            break;
                    }
                }

            }
            if (!TF)
            {
                life--;
                label2.Text = life.ToString();
                if (life == 5)
                    stage1.Visible = true;
                if (life + 1 == 5)
                {
                    stage2.Visible = true;
                    stage1.Visible = false;
                }
                if (life + 1 == 4)
                {
                    stage3.Visible = true;
                    stage2.Visible = false;
                }
                if (life + 1 == 3)
                {
                    stage4.Visible = true;
                    stage3.Visible = false;
                }
                if (life + 1 == 2)
                {
                    stage5.Visible = true;
                    stage4.Visible = false;
                }
                if (life + 1 == 1)
                {
                    stage6.Visible = true;
                    stage5.Visible = false;
                }
            }
            l.Enabled = false;
            TF = false;
        }

        private void m_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < splitCityName.Length; i++)
            {
                if (splitCityName[i].ToUpper() == "M")
                {
                    sayac = i + 1;
                    TF = true;
                    switch (sayac)
                    {
                        case 1:
                            h1.Text = "M";
                            counterScore--;
                            break;
                        case 2:
                            h2.Text = "M";
                            counterScore--;
                            break;
                        case 3:
                            h3.Text = "M";
                            counterScore--;
                            break;
                        case 4:
                            h4.Text = "M";
                            counterScore--;
                            break;
                        case 5:
                            h5.Text = "M";
                            counterScore--;
                            break;
                        case 6:
                            h6.Text = "M";
                            counterScore--;
                            break;
                        case 7:
                            h7.Text = "M";
                            counterScore--;
                            break;
                        case 8:
                            h8.Text = "M";
                            counterScore--;
                            break;
                        case 9:
                            h9.Text = "M";
                            counterScore--;
                            break;
                        case 10:
                            h10.Text = "M";
                            counterScore--;
                            break;
                        case 11:
                            h11.Text = "M";
                            counterScore--;
                            break;
                        case 12:
                            h12.Text = "M";
                            counterScore--;
                            break;
                        case 13:
                            h13.Text = "M";
                            counterScore--;
                            break;
                        case 14:
                            h14.Text = "M";
                            counterScore--;
                            break;
                    }
                }

            }
            if (!TF)
            {
                life--;
                label2.Text = life.ToString();
                if (life == 5)
                    stage1.Visible = true;
                if (life + 1 == 5)
                {
                    stage2.Visible = true;
                    stage1.Visible = false;
                }
                if (life + 1 == 4)
                {
                    stage3.Visible = true;
                    stage2.Visible = false;
                }
                if (life + 1 == 3)
                {
                    stage4.Visible = true;
                    stage3.Visible = false;
                }
                if (life + 1 == 2)
                {
                    stage5.Visible = true;
                    stage4.Visible = false;
                }
                if (life + 1 == 1)
                {
                    stage6.Visible = true;
                    stage5.Visible = false;
                }
            }
            m.Enabled = false;
            TF = false;
        }

        private void n_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < splitCityName.Length; i++)
            {
                if (splitCityName[i].ToUpper() == "N")
                {
                    sayac = i + 1;
                    TF = true;
                    switch (sayac)
                    {
                        case 1:
                            h1.Text = "N";
                            counterScore--;
                            break;
                        case 2:
                            h2.Text = "N";
                            counterScore--;
                            break;
                        case 3:
                            h3.Text = "N";
                            counterScore--;
                            break;
                        case 4:
                            h4.Text = "N";
                            counterScore--;
                            break;
                        case 5:
                            h5.Text = "N";
                            counterScore--;
                            break;
                        case 6:
                            h6.Text = "N";
                            counterScore--;
                            break;
                        case 7:
                            h7.Text = "N";
                            counterScore--;
                            break;
                        case 8:
                            h8.Text = "N";
                            counterScore--;
                            break;
                        case 9:
                            h9.Text = "N";
                            counterScore--;
                            break;
                        case 10:
                            h10.Text = "N";
                            counterScore--;
                            break;
                        case 11:
                            h11.Text = "N";
                            counterScore--;
                            break;
                        case 12:
                            h12.Text = "N";
                            counterScore--;
                            break;
                        case 13:
                            h13.Text = "N";
                            counterScore--;
                            break;
                        case 14:
                            h14.Text = "N";
                            counterScore--;
                            break;
                    }
                }

            }
            if (!TF)
            {
                life--;
                label2.Text = life.ToString();
                if (life == 5)
                    stage1.Visible = true;
                if (life + 1 == 5)
                {
                    stage2.Visible = true;
                    stage1.Visible = false;
                }
                if (life + 1 == 4)
                {
                    stage3.Visible = true;
                    stage2.Visible = false;
                }
                if (life + 1 == 3)
                {
                    stage4.Visible = true;
                    stage3.Visible = false;
                }
                if (life + 1 == 2)
                {
                    stage5.Visible = true;
                    stage4.Visible = false;
                }
                if (life + 1 == 1)
                {
                    stage6.Visible = true;
                    stage5.Visible = false;
                }
            }
            n.Enabled = false;
            TF = false;
        }

        private void o_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < splitCityName.Length; i++)
            {
                if (splitCityName[i].ToUpper() == "O")
                {
                    sayac = i + 1;
                    TF = true;
                    switch (sayac)
                    {
                        case 1:
                            h1.Text = "O";
                            counterScore--;
                            break;
                        case 2:
                            h2.Text = "O";
                            counterScore--;
                            break;
                        case 3:
                            h3.Text = "O";
                            counterScore--;
                            break;
                        case 4:
                            h4.Text = "O";
                            counterScore--;
                            break;
                        case 5:
                            h5.Text = "O";
                            counterScore--;
                            break;
                        case 6:
                            h6.Text = "O";
                            counterScore--;
                            break;
                        case 7:
                            h7.Text = "O";
                            counterScore--;
                            break;
                        case 8:
                            h8.Text = "O";
                            counterScore--;
                            break;
                        case 9:
                            h9.Text = "O";
                            counterScore--;
                            break;
                        case 10:
                            h10.Text = "O";
                            counterScore--;
                            break;
                        case 11:
                            h11.Text = "O";
                            counterScore--;
                            break;
                        case 12:
                            h12.Text = "O";
                            counterScore--;
                            break;
                        case 13:
                            h13.Text = "O";
                            counterScore--;
                            break;
                        case 14:
                            h14.Text = "O";
                            counterScore--;
                            break;
                    }
                }

            }
            if (!TF)
            {
                life--;
                label2.Text = life.ToString();
                if (life == 5)
                    stage1.Visible = true;
                if (life + 1 == 5)
                {
                    stage2.Visible = true;
                    stage1.Visible = false;
                }
                if (life + 1 == 4)
                {
                    stage3.Visible = true;
                    stage2.Visible = false;
                }
                if (life + 1 == 3)
                {
                    stage4.Visible = true;
                    stage3.Visible = false;
                }
                if (life + 1 == 2)
                {
                    stage5.Visible = true;
                    stage4.Visible = false;
                }
                if (life + 1 == 1)
                {
                    stage6.Visible = true;
                    stage5.Visible = false;
                }
            }
            o.Enabled = false;
            TF = false;
        }

        private void o2_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < splitCityName.Length; i++)
            {
                if (splitCityName[i].ToUpper() == "Ö")
                {
                    sayac = i + 1;
                    TF = true;
                    switch (sayac)
                    {
                        case 1:
                            h1.Text = "Ö";
                            counterScore--;
                            break;
                        case 2:
                            h2.Text = "Ö";
                            counterScore--;
                            break;
                        case 3:
                            h3.Text = "Ö";
                            counterScore--;
                            break;
                        case 4:
                            h4.Text = "Ö";
                            counterScore--;
                            break;
                        case 5:
                            h5.Text = "Ö";
                            counterScore--;
                            break;
                        case 6:
                            h6.Text = "Ö";
                            counterScore--;
                            break;
                        case 7:
                            h7.Text = "Ö";
                            counterScore--;
                            break;
                        case 8:
                            h8.Text = "Ö";
                            counterScore--;
                            break;
                        case 9:
                            h9.Text = "Ö";
                            counterScore--;
                            break;
                        case 10:
                            h10.Text = "Ö";
                            counterScore--;
                            break;
                        case 11:
                            h11.Text = "Ö";
                            counterScore--;
                            break;
                        case 12:
                            h12.Text = "Ö";
                            counterScore--;
                            break;
                        case 13:
                            h13.Text = "Ö";
                            counterScore--;
                            break;
                        case 14:
                            h14.Text = "Ö";
                            counterScore--;
                            break;
                    }
                }

            }
            if (!TF)
            {
                life--;
                label2.Text = life.ToString();
                if (life == 5)
                    stage1.Visible = true;
                if (life + 1 == 5)
                {
                    stage2.Visible = true;
                    stage1.Visible = false;
                }
                if (life + 1 == 4)
                {
                    stage3.Visible = true;
                    stage2.Visible = false;
                }
                if (life + 1 == 3)
                {
                    stage4.Visible = true;
                    stage3.Visible = false;
                }
                if (life + 1 == 2)
                {
                    stage5.Visible = true;
                    stage4.Visible = false;
                }
                if (life + 1 == 1)
                {
                    stage6.Visible = true;
                    stage5.Visible = false;
                }
            }
            o2.Enabled = false;
            TF = false;
        }

        private void p_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < splitCityName.Length; i++)
            {
                if (splitCityName[i].ToUpper() == "P")
                {
                    sayac = i + 1;
                    TF = true;
                    switch (sayac)
                    {
                        case 1:
                            h1.Text = "P";
                            counterScore--;
                            break;
                        case 2:
                            h2.Text = "P";
                            counterScore--;
                            break;
                        case 3:
                            h3.Text = "P";
                            counterScore--;
                            break;
                        case 4:
                            h4.Text = "P";
                            counterScore--;
                            break;
                        case 5:
                            h5.Text = "P";
                            counterScore--;
                            break;
                        case 6:
                            h6.Text = "P";
                            counterScore--;
                            break;
                        case 7:
                            h7.Text = "P";
                            counterScore--;
                            break;
                        case 8:
                            h8.Text = "P";
                            counterScore--;
                            break;
                        case 9:
                            h9.Text = "P";
                            counterScore--;
                            break;
                        case 10:
                            h10.Text = "P";
                            counterScore--;
                            break;
                        case 11:
                            h11.Text = "P";
                            counterScore--;
                            break;
                        case 12:
                            h12.Text = "P";
                            counterScore--;
                            break;
                        case 13:
                            h13.Text = "P";
                            counterScore--;
                            break;
                        case 14:
                            h14.Text = "P";
                            counterScore--;
                            break;
                    }
                }

            }
            if (!TF)
            {
                life--;
                label2.Text = life.ToString();
                if (life == 5)
                    stage1.Visible = true;
                if (life + 1 == 5)
                {
                    stage2.Visible = true;
                    stage1.Visible = false;
                }
                if (life + 1 == 4)
                {
                    stage3.Visible = true;
                    stage2.Visible = false;
                }
                if (life + 1 == 3)
                {
                    stage4.Visible = true;
                    stage3.Visible = false;
                }
                if (life + 1 == 2)
                {
                    stage5.Visible = true;
                    stage4.Visible = false;
                }
                if (life + 1 == 1)
                {
                    stage6.Visible = true;
                    stage5.Visible = false;
                }
            }
            p.Enabled = false;
            TF = false;
        }

        private void r_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < splitCityName.Length; i++)
            {
                if (splitCityName[i].ToUpper() == "R")
                {
                    sayac = i + 1;
                    TF = true;
                    switch (sayac)
                    {
                        case 1:
                            h1.Text = "R";
                            counterScore--;
                            break;
                        case 2:
                            h2.Text = "R";
                            counterScore--;
                            break;
                        case 3:
                            h3.Text = "R";
                            counterScore--;
                            break;
                        case 4:
                            h4.Text = "R";
                            counterScore--;
                            break;
                        case 5:
                            h5.Text = "R";
                            counterScore--;
                            break;
                        case 6:
                            h6.Text = "R";
                            counterScore--;
                            break;
                        case 7:
                            h7.Text = "R";
                            counterScore--;
                            break;
                        case 8:
                            h8.Text = "R";
                            counterScore--;
                            break;
                        case 9:
                            h9.Text = "R";
                            counterScore--;
                            break;
                        case 10:
                            h10.Text = "R";
                            counterScore--;
                            break;
                        case 11:
                            h11.Text = "R";
                            counterScore--;
                            break;
                        case 12:
                            h12.Text = "R";
                            counterScore--;
                            break;
                        case 13:
                            h13.Text = "R";
                            counterScore--;
                            break;
                        case 14:
                            h14.Text = "R";
                            counterScore--;
                            break;
                    }
                }

            }
            if (!TF)
            {
                life--;
                label2.Text = life.ToString();
                if (life == 5)
                    stage1.Visible = true;
                if (life + 1 == 5)
                {
                    stage2.Visible = true;
                    stage1.Visible = false;
                }
                if (life + 1 == 4)
                {
                    stage3.Visible = true;
                    stage2.Visible = false;
                }
                if (life + 1 == 3)
                {
                    stage4.Visible = true;
                    stage3.Visible = false;
                }
                if (life + 1 == 2)
                {
                    stage5.Visible = true;
                    stage4.Visible = false;
                }
                if (life + 1 == 1)
                {
                    stage6.Visible = true;
                    stage5.Visible = false;
                }
            }
            r.Enabled = false;
            TF = false;
        }

        private void s_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < splitCityName.Length; i++)
            {
                if (splitCityName[i].ToUpper() == "S")
                {
                    sayac = i + 1;
                    TF = true;
                    switch (sayac)
                    {
                        case 1:
                            h1.Text = "S";
                            counterScore--;
                            break;
                        case 2:
                            h2.Text = "S";
                            counterScore--;
                            break;
                        case 3:
                            h3.Text = "S";
                            counterScore--;
                            break;
                        case 4:
                            h4.Text = "S";
                            counterScore--;
                            break;
                        case 5:
                            h5.Text = "S";
                            counterScore--;
                            break;
                        case 6:
                            h6.Text = "S";
                            counterScore--;
                            break;
                        case 7:
                            h7.Text = "S";
                            counterScore--;
                            break;
                        case 8:
                            h8.Text = "S";
                            counterScore--;
                            break;
                        case 9:
                            h9.Text = "S";
                            counterScore--;
                            break;
                        case 10:
                            h10.Text = "S";
                            counterScore--;
                            break;
                        case 11:
                            h11.Text = "S";
                            counterScore--;
                            break;
                        case 12:
                            h12.Text = "S";
                            counterScore--;
                            break;
                        case 13:
                            h13.Text = "S";
                            counterScore--;
                            break;
                        case 14:
                            h14.Text = "S";
                            counterScore--;
                            break;
                    }
                }

            }
            if (!TF)
            {
                life--;
                label2.Text = life.ToString();
                if (life == 5)
                    stage1.Visible = true;
                if (life + 1 == 5)
                {
                    stage2.Visible = true;
                    stage1.Visible = false;
                }
                if (life + 1 == 4)
                {
                    stage3.Visible = true;
                    stage2.Visible = false;
                }
                if (life + 1 == 3)
                {
                    stage4.Visible = true;
                    stage3.Visible = false;
                }
                if (life + 1 == 2)
                {
                    stage5.Visible = true;
                    stage4.Visible = false;
                }
                if (life + 1 == 1)
                {
                    stage6.Visible = true;
                    stage5.Visible = false;
                }
            }
            s.Enabled = false;
            TF = false;
        }

        private void s2_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < splitCityName.Length; i++)
            {
                if (splitCityName[i].ToUpper() == "Ş")
                {
                    sayac = i + 1;
                    TF = true;
                    switch (sayac)
                    {
                        case 1:
                            h1.Text = "Ş";
                            counterScore--;
                            break;
                        case 2:
                            h2.Text = "Ş";
                            counterScore--;
                            break;
                        case 3:
                            h3.Text = "Ş";
                            counterScore--;
                            break;
                        case 4:
                            h4.Text = "Ş";
                            counterScore--;
                            break;
                        case 5:
                            h5.Text = "Ş";
                            counterScore--;
                            break;
                        case 6:
                            h6.Text = "Ş";
                            counterScore--;
                            break;
                        case 7:
                            h7.Text = "Ş";
                            counterScore--;
                            break;
                        case 8:
                            h8.Text = "Ş";
                            counterScore--;
                            break;
                        case 9:
                            h9.Text = "Ş";
                            counterScore--;
                            break;
                        case 10:
                            h10.Text = "Ş";
                            counterScore--;
                            break;
                        case 11:
                            h11.Text = "Ş";
                            counterScore--;
                            break;
                        case 12:
                            h12.Text = "Ş";
                            counterScore--;
                            break;
                        case 13:
                            h13.Text = "Ş";
                            counterScore--;
                            break;
                        case 14:
                            h14.Text = "Ş";
                            counterScore--;
                            break;
                    }
                }

            }
            if (!TF)
            {
                life--;
                label2.Text = life.ToString();
                if (life == 5)
                    stage1.Visible = true;
                if (life + 1 == 5)
                {
                    stage2.Visible = true;
                    stage1.Visible = false;
                }
                if (life + 1 == 4)
                {
                    stage3.Visible = true;
                    stage2.Visible = false;
                }
                if (life + 1 == 3)
                {
                    stage4.Visible = true;
                    stage3.Visible = false;
                }
                if (life + 1 == 2)
                {
                    stage5.Visible = true;
                    stage4.Visible = false;
                }
                if (life + 1 == 1)
                {
                    stage6.Visible = true;
                    stage5.Visible = false;
                }
            }
            s2.Enabled = false;
            TF = false;
        }

        private void t_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < splitCityName.Length; i++)
            {
                if (splitCityName[i].ToUpper() == "T")
                {
                    sayac = i + 1;
                    TF = true;
                    switch (sayac)
                    {
                        case 1:
                            h1.Text = "T";
                            counterScore--;
                            break;
                        case 2:
                            h2.Text = "T";
                            counterScore--;
                            break;
                        case 3:
                            h3.Text = "T";
                            counterScore--;
                            break;
                        case 4:
                            h4.Text = "T";
                            counterScore--;
                            break;
                        case 5:
                            h5.Text = "T";
                            counterScore--;
                            break;
                        case 6:
                            h6.Text = "T";
                            counterScore--;
                            break;
                        case 7:
                            h7.Text = "T";
                            counterScore--;
                            break;
                        case 8:
                            h8.Text = "T";
                            counterScore--;
                            break;
                        case 9:
                            h9.Text = "T";
                            counterScore--;
                            break;
                        case 10:
                            h10.Text = "T";
                            counterScore--;
                            break;
                        case 11:
                            h11.Text = "T";
                            counterScore--;
                            break;
                        case 12:
                            h12.Text = "T";
                            counterScore--;
                            break;
                        case 13:
                            h13.Text = "T";
                            counterScore--;
                            break;
                        case 14:
                            h14.Text = "T";
                            counterScore--;
                            break;
                    }
                }

            }
            if (!TF)
            {
                life--;
                label2.Text = life.ToString();
                if (life == 5)
                    stage1.Visible = true;
                if (life + 1 == 5)
                {
                    stage2.Visible = true;
                    stage1.Visible = false;
                }
                if (life + 1 == 4)
                {
                    stage3.Visible = true;
                    stage2.Visible = false;
                }
                if (life + 1 == 3)
                {
                    stage4.Visible = true;
                    stage3.Visible = false;
                }
                if (life + 1 == 2)
                {
                    stage5.Visible = true;
                    stage4.Visible = false;
                }
                if (life + 1 == 1)
                {
                    stage6.Visible = true;
                    stage5.Visible = false;
                }
            }
            t.Enabled = false;
            TF = false;
        }

        private void u_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < splitCityName.Length; i++)
            {
                if (splitCityName[i].ToUpper() == "U")
                {
                    sayac = i + 1;
                    TF = true;
                    switch (sayac)
                    {
                        case 1:
                            h1.Text = "U";
                            counterScore--;
                            break;
                        case 2:
                            h2.Text = "U";
                            counterScore--;
                            break;
                        case 3:
                            h3.Text = "U";
                            counterScore--;
                            break;
                        case 4:
                            h4.Text = "U";
                            counterScore--;
                            break;
                        case 5:
                            h5.Text = "U";
                            counterScore--;
                            break;
                        case 6:
                            h6.Text = "U";
                            counterScore--;
                            break;
                        case 7:
                            h7.Text = "U";
                            counterScore--;
                            break;
                        case 8:
                            h8.Text = "U";
                            counterScore--;
                            break;
                        case 9:
                            h9.Text = "U";
                            counterScore--;
                            break;
                        case 10:
                            h10.Text = "U";
                            counterScore--;
                            break;
                        case 11:
                            h11.Text = "U";
                            counterScore--;
                            break;
                        case 12:
                            h12.Text = "U";
                            counterScore--;
                            break;
                        case 13:
                            h13.Text = "U";
                            counterScore--;
                            break;
                        case 14:
                            h14.Text = "U";
                            counterScore--;
                            break;
                    }
                }

            }
            if (!TF)
            {
                life--;
                label2.Text = life.ToString();
                if (life == 5)
                    stage1.Visible = true;
                if (life + 1 == 5)
                {
                    stage2.Visible = true;
                    stage1.Visible = false;
                }
                if (life + 1 == 4)
                {
                    stage3.Visible = true;
                    stage2.Visible = false;
                }
                if (life + 1 == 3)
                {
                    stage4.Visible = true;
                    stage3.Visible = false;
                }
                if (life + 1 == 2)
                {
                    stage5.Visible = true;
                    stage4.Visible = false;
                }
                if (life + 1 == 1)
                {
                    stage6.Visible = true;
                    stage5.Visible = false;
                }
            }
            u.Enabled = false;
            TF = false;
        }

        private void u2_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < splitCityName.Length; i++)
            {
                if (splitCityName[i].ToUpper() == "Ü")
                {
                    sayac = i + 1;
                    TF = true;
                    switch (sayac)
                    {
                        case 1:
                            h1.Text = "Ü";
                            counterScore--;
                            break;
                        case 2:
                            h2.Text = "Ü";
                            counterScore--;
                            break;
                        case 3:
                            h3.Text = "Ü";
                            counterScore--;
                            break;
                        case 4:
                            h4.Text = "Ü";
                            counterScore--;
                            break;
                        case 5:
                            h5.Text = "Ü";
                            counterScore--;
                            break;
                        case 6:
                            h6.Text = "Ü";
                            counterScore--;
                            break;
                        case 7:
                            h7.Text = "Ü";
                            counterScore--;
                            break;
                        case 8:
                            h8.Text = "Ü";
                            counterScore--;
                            break;
                        case 9:
                            h9.Text = "Ü";
                            counterScore--;
                            break;
                        case 10:
                            h10.Text = "Ü";
                            counterScore--;
                            break;
                        case 11:
                            h11.Text = "Ü";
                            counterScore--;
                            break;
                        case 12:
                            h12.Text = "Ü";
                            counterScore--;
                            break;
                        case 13:
                            h13.Text = "Ü";
                            counterScore--;
                            break;
                        case 14:
                            h14.Text = "Ü";
                            counterScore--;
                            break;
                    }
                }

            }
            if (!TF)
            {
                life--;
                label2.Text = life.ToString();
                if (life == 5)
                    stage1.Visible = true;
                if (life + 1 == 5)
                {
                    stage2.Visible = true;
                    stage1.Visible = false;
                }
                if (life + 1 == 4)
                {
                    stage3.Visible = true;
                    stage2.Visible = false;
                }
                if (life + 1 == 3)
                {
                    stage4.Visible = true;
                    stage3.Visible = false;
                }
                if (life + 1 == 2)
                {
                    stage5.Visible = true;
                    stage4.Visible = false;
                }
                if (life + 1 == 1)
                {
                    stage6.Visible = true;
                    stage5.Visible = false;
                }
            }
            u2.Enabled = false;
            TF = false;
        }

        private void v_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < splitCityName.Length; i++)
            {
                if (splitCityName[i].ToUpper() == "V")
                {
                    sayac = i + 1;
                    TF = true;
                    switch (sayac)
                    {
                        case 1:
                            h1.Text = "V";
                            counterScore--;
                            break;
                        case 2:
                            h2.Text = "V";
                            counterScore--;
                            break;
                        case 3:
                            h3.Text = "V";
                            counterScore--;
                            break;
                        case 4:
                            h4.Text = "V";
                            counterScore--;
                            break;
                        case 5:
                            h5.Text = "V";
                            counterScore--;
                            break;
                        case 6:
                            h6.Text = "V";
                            counterScore--;
                            break;
                        case 7:
                            h7.Text = "V";
                            counterScore--;
                            break;
                        case 8:
                            h8.Text = "V";
                            counterScore--;
                            break;
                        case 9:
                            h9.Text = "V";
                            counterScore--;
                            break;
                        case 10:
                            h10.Text = "V";
                            counterScore--;
                            break;
                        case 11:
                            h11.Text = "V";
                            counterScore--;
                            break;
                        case 12:
                            h12.Text = "V";
                            counterScore--;
                            break;
                        case 13:
                            h13.Text = "V";
                            counterScore--;
                            break;
                        case 14:
                            h14.Text = "V";
                            counterScore--;
                            break;
                    }
                }

            }
            if (!TF)
            {
                life--;
                label2.Text = life.ToString();
                if (life == 5)
                    stage1.Visible = true;
                if (life + 1 == 5)
                {
                    stage2.Visible = true;
                    stage1.Visible = false;
                }
                if (life + 1 == 4)
                {
                    stage3.Visible = true;
                    stage2.Visible = false;
                }
                if (life + 1 == 3)
                {
                    stage4.Visible = true;
                    stage3.Visible = false;
                }
                if (life + 1 == 2)
                {
                    stage5.Visible = true;
                    stage4.Visible = false;
                }
                if (life + 1 == 1)
                {
                    stage6.Visible = true;
                    stage5.Visible = false;
                }
            }
            v.Enabled = false;
            TF = false;
        }

        private void y_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < splitCityName.Length; i++)
            {
                if (splitCityName[i].ToUpper() == "Y")
                {
                    sayac = i + 1;
                    TF = true;
                    switch (sayac)
                    {
                        case 1:
                            h1.Text = "Y";
                            counterScore--;
                            break;
                        case 2:
                            h2.Text = "Y";
                            counterScore--;
                            break;
                        case 3:
                            h3.Text = "Y";
                            counterScore--;
                            break;
                        case 4:
                            h4.Text = "Y";
                            counterScore--;
                            break;
                        case 5:
                            h5.Text = "Y";
                            counterScore--;
                            break;
                        case 6:
                            h6.Text = "Y";
                            counterScore--;
                            break;
                        case 7:
                            h7.Text = "Y";
                            counterScore--;
                            break;
                        case 8:
                            h8.Text = "Y";
                            counterScore--;
                            break;
                        case 9:
                            h9.Text = "Y";
                            counterScore--;
                            break;
                        case 10:
                            h10.Text = "Y";
                            counterScore--;
                            break;
                        case 11:
                            h11.Text = "Y";
                            counterScore--;
                            break;
                        case 12:
                            h12.Text = "Y";
                            counterScore--;
                            break;
                        case 13:
                            h13.Text = "Y";
                            counterScore--;
                            break;
                        case 14:
                            h14.Text = "Y";
                            counterScore--;
                            break;
                    }
                }

            }
            if (!TF)
            {
                life--;
                label2.Text = life.ToString();
                if (life == 5)
                    stage1.Visible = true;
                if (life + 1 == 5)
                {
                    stage2.Visible = true;
                    stage1.Visible = false;
                }
                if (life + 1 == 4)
                {
                    stage3.Visible = true;
                    stage2.Visible = false;
                }
                if (life + 1 == 3)
                {
                    stage4.Visible = true;
                    stage3.Visible = false;
                }
                if (life + 1 == 2)
                {
                    stage5.Visible = true;
                    stage4.Visible = false;
                }
                if (life + 1 == 1)
                {
                    stage6.Visible = true;
                    stage5.Visible = false;
                }
            }
            y.Enabled = false;
            TF = false;
        }

        private void z_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < splitCityName.Length; i++)
            {
                if (splitCityName[i].ToUpper() == "Z")
                {
                    sayac = i + 1;
                    TF = true;
                    switch (sayac)
                    {
                        case 1:
                            h1.Text = "Z";
                            counterScore--;
                            break;
                        case 2:
                            h2.Text = "Z";
                            counterScore--;
                            break;
                        case 3:
                            h3.Text = "Z";
                            counterScore--;
                            break;
                        case 4:
                            h4.Text = "Z";
                            counterScore--;
                            break;
                        case 5:
                            h5.Text = "Z";
                            counterScore--;
                            break;
                        case 6:
                            h6.Text = "Z";
                            counterScore--;
                            break;
                        case 7:
                            h7.Text = "Z";
                            counterScore--;
                            break;
                        case 8:
                            h8.Text = "Z";
                            counterScore--;
                            break;
                        case 9:
                            h9.Text = "Z";
                            counterScore--;
                            break;
                        case 10:
                            h10.Text = "Z";
                            counterScore--;
                            break;
                        case 11:
                            h11.Text = "Z";
                            counterScore--;
                            break;
                        case 12:
                            h12.Text = "Z";
                            counterScore--;
                            break;
                        case 13:
                            h13.Text = "Z";
                            counterScore--;
                            break;
                        case 14:
                            h14.Text = "Z";
                            counterScore--;
                            break;
                    }
                }

            }
            if (!TF)
            {
                life--;
                label2.Text = life.ToString();
                if (life == 5)
                    stage1.Visible = true;
                if (life + 1 == 5)
                {
                    stage2.Visible = true;
                    stage1.Visible = false;
                }
                if (life + 1 == 4)
                {
                    stage3.Visible = true;
                    stage2.Visible = false;
                }
                if (life + 1 == 3)
                {
                    stage4.Visible = true;
                    stage3.Visible = false;
                }
                if (life + 1 == 2)
                {
                    stage5.Visible = true;
                    stage4.Visible = false;
                }
                if (life + 1 == 1)
                {
                    stage6.Visible = true;
                    stage5.Visible = false;
                }
            }
            z.Enabled = false;
            TF = false;
        }

        private void Game_SizeChanged(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (life == 0)
            {
                timer1.Enabled = false;
                timer1.Stop();
                guna2MessageDialog2.Show("\n\n\n😞😞😞😞😞😞😞😞😞😞\n😞😞😞😞😞😞😞😞😞😞\n😞😞 GAMEOWER! 😞😞\n😞😞😞😞😞😞😞😞😞😞\n😞😞😞😞😞😞😞😞😞😞");
                Application.Restart();
            }
            if (counterScore==0)
            {
                timer1.Enabled = false;
                timer1.Stop();
                guna2MessageDialog1.Show("\n\n\n😞😞😞😞😞😞😞😞😞😞\n😞😞😞😞😞😞😞😞😞😞\n😞😞DIDN'T KNOW!😞😞\n😞😞😞😞😞😞😞😞😞😞\n😞😞😞😞😞😞😞😞😞😞");
                StartGame();
            }
        }
    }
}
