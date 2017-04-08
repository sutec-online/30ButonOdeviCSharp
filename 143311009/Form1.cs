using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _143311009
{
    public partial class Form1 : Form
    {
        Button [] gezilenler = new Button[30];
        int buton_sayici = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sinir1 = (int)numericUpDown1.Value;
            int sinir2 = (int)numericUpDown2.Value;
            Random rnd = new Random();
            for (int i = 1; i < 31; i++)
            {
                Button btn = (Button)this.Controls["button" + i];
                btn.Text = rnd.Next(sinir1, sinir2).ToString();
            }
        }

        void ziyaret(Button kgn)
        {
            Button ust, alt, sag, sol;
            kgn.BackColor = Color.White;

            //Buton 1, 6, 25 ve 30'un 2 komşusu vardır.
            if(kgn.Name == "button1")
            {
                alt = (Button)this.Controls["button7"];
                sag = (Button)this.Controls["button2"];

                if(alt.BackColor == Color.White)
                {
                    if(sag.BackColor == Color.White)
                    {
                        kgn.BackColor = Color.Black;
                    }
                    else
                    {
                        ziyaret(sag);
                    }
                }
                else
                {
                    if(sag.BackColor == Color.White)
                    {
                        ziyaret(alt);
                    }
                    else
                    {
                        if(int.Parse(alt.Text) > int.Parse(sag.Text))
                        {
                            ziyaret(alt);
                        }
                        else
                        {
                            ziyaret(sag);
                        }
                    }
                }

            }else if(kgn.Name == "button6")
            {
                alt = (Button)this.Controls["button12"];
                sol = (Button)this.Controls["button5"];

                if (alt.BackColor == Color.White)
                {
                    if (sol.BackColor == Color.White)
                    {
                        kgn.BackColor = Color.Black;
                    }
                    else
                    {
                        ziyaret(sol);
                    }
                }
                else
                {
                    if (sol.BackColor == Color.White)
                    {
                        ziyaret(alt);
                    }
                    else
                    {
                        if (int.Parse(alt.Text) > int.Parse(sol.Text))
                        {
                            ziyaret(alt);
                        }
                        else
                        {
                            ziyaret(sol);
                        }
                    }
                }

            }
            else if(kgn.Name == "button25")
            {
                ust = (Button)this.Controls["button19"];
                sag = (Button)this.Controls["button26"];

                if (ust.BackColor == Color.White)
                {
                    if (sag.BackColor == Color.White)
                    {
                        kgn.BackColor = Color.Black;
                    }
                    else
                    {
                        ziyaret(sag);
                    }
                }
                else
                {
                    if (sag.BackColor == Color.White)
                    {
                        ziyaret(ust);
                    }
                    else
                    {
                        if (int.Parse(ust.Text) > int.Parse(sag.Text))
                        {
                            ziyaret(ust);
                        }
                        else
                        {
                            ziyaret(sag);
                        }
                    }
                }

            }
            else if(kgn.Name == "button30")
            {
                ust = (Button)this.Controls["button24"];
                sol = (Button)this.Controls["button29"];

                if (ust.BackColor == Color.White)
                {
                    if (sol.BackColor == Color.White)
                    {
                        kgn.BackColor = Color.Black;
                    }
                    else
                    {
                        ziyaret(sol);
                    }
                }
                else
                {
                    if (sol.BackColor == Color.White)
                    {
                        ziyaret(ust);
                    }
                    else
                    {
                        if (int.Parse(ust.Text) > int.Parse(sol.Text))
                        {
                            ziyaret(ust);
                        }
                        else
                        {
                            ziyaret(sol);
                        }
                    }
                }


            }else if(kgn.Name == "button7" || kgn.Name == "button13" || kgn.Name == "button19")
            {
                int buton_no = int.Parse(kgn.Name.Replace("button", ""));
                int btn_ust = buton_no - 6;
                int btn_alt = buton_no + 6;
                int btn_sag = buton_no + 1;

                alt = (Button)this.Controls["button" + btn_alt];
                sag = (Button)this.Controls["button" + btn_sag];
                ust = (Button)this.Controls["button" + btn_ust];

                if (alt.BackColor == Color.White)
                {
                    if (sag.BackColor == Color.White)
                    {
                        if (ust.BackColor == Color.White)
                        {
                            kgn.BackColor = Color.Black;
                        }
                        else
                        {
                            ziyaret(ust);
                        }
                    }
                    else
                    {
                        if (ust.BackColor == Color.White)
                        {
                            ziyaret(sag);
                        }
                        else
                        {
                            if (int.Parse(sag.Text) > int.Parse(ust.Text))
                            {
                                ziyaret(sag);
                            }
                            else
                            {
                                ziyaret(ust);
                            }
                        }
                    }
                }
                else
                {
                    if (sag.BackColor == Color.White)
                    {
                        if (ust.BackColor == Color.White)
                        {
                            ziyaret(alt);
                        }
                        else
                        {
                            if (int.Parse(alt.Text) > int.Parse(ust.Text))
                            {
                                ziyaret(alt);
                            }
                            else
                            {
                                ziyaret(ust);
                            }
                        }
                    }
                    else
                    {
                        if (ust.BackColor == Color.White)
                        {
                            if (int.Parse(alt.Text) > int.Parse(sag.Text))
                            {
                                ziyaret(alt);
                            }
                            else
                            {
                                ziyaret(sag);
                            }
                        }
                        else
                        {
                            if (int.Parse(alt.Text) > int.Parse(sag.Text))
                            {
                                if (int.Parse(alt.Text) > int.Parse(ust.Text))
                                {
                                    ziyaret(alt);
                                }
                                else
                                {
                                    ziyaret(ust);
                                }
                            }
                            else
                            {
                                if (int.Parse(sag.Text) > int.Parse(ust.Text))
                                {
                                    ziyaret(sag);
                                }
                                else
                                {
                                    ziyaret(ust);
                                }
                            }
                        }
                    }
                }
            }else if (kgn.Name == "button12" || kgn.Name == "button18" || kgn.Name == "button24")
            {
                int buton_no = int.Parse(kgn.Name.Replace("button", ""));
                int btn_ust = buton_no - 6;
                int btn_alt = buton_no + 6;
                int btn_sol = buton_no - 1;

                alt = (Button)this.Controls["button" + btn_alt];
                sol = (Button)this.Controls["button" + btn_sol];
                ust = (Button)this.Controls["button" + btn_ust];

                if (alt.BackColor == Color.White)
                {
                    if (sol.BackColor == Color.White)
                    {
                        if (ust.BackColor == Color.White)
                        {
                            kgn.BackColor = Color.Black;
                        }
                        else
                        {
                            ziyaret(ust);
                        }
                    }
                    else
                    {
                        if (ust.BackColor == Color.White)
                        {
                            ziyaret(sol);
                        }
                        else
                        {
                            if (int.Parse(sol.Text) > int.Parse(ust.Text))
                            {
                                ziyaret(sol);
                            }
                            else
                            {
                                ziyaret(ust);
                            }
                        }
                    }
                }
                else
                {
                    if (sol.BackColor == Color.White)
                    {
                        if (ust.BackColor == Color.White)
                        {
                            ziyaret(alt);
                        }
                        else
                        {
                            if (int.Parse(alt.Text) > int.Parse(ust.Text))
                            {
                                ziyaret(alt);
                            }
                            else
                            {
                                ziyaret(ust);
                            }
                        }
                    }
                    else
                    {
                        if (ust.BackColor == Color.White)
                        {
                            if (int.Parse(alt.Text) > int.Parse(sol.Text))
                            {
                                ziyaret(alt);
                            }
                            else
                            {
                                ziyaret(sol);
                            }
                        }
                        else
                        {
                            if (int.Parse(alt.Text) > int.Parse(sol.Text))
                            {
                                if (int.Parse(alt.Text) > int.Parse(ust.Text))
                                {
                                    ziyaret(alt);
                                }
                                else
                                {
                                    ziyaret(ust);
                                }
                            }
                            else
                            {
                                if (int.Parse(sol.Text) > int.Parse(ust.Text))
                                {
                                    ziyaret(sol);
                                }
                                else
                                {
                                    ziyaret(ust);
                                }
                            }
                        }
                    }
                }
            }else if (kgn.Name == "button2" || kgn.Name == "button3" || kgn.Name == "button4" || kgn.Name == "button5")
            {
                // Butonun 3 komşusu varsa.

                int buton_no = int.Parse(kgn.Name.Replace("button", ""));
                int btn_alt = buton_no + 6;
                int btn_sag = buton_no + 1;
                int btn_sol = buton_no - 1;

                alt = (Button)this.Controls["button"+btn_alt];
                sag = (Button)this.Controls["button"+btn_sag];
                sol = (Button)this.Controls["button"+btn_sol];

                if (alt.BackColor == Color.White)
                {
                    if (sag.BackColor == Color.White)
                    {
                        if (sol.BackColor == Color.White)
                        {
                            kgn.BackColor = Color.Black;
                        }
                        else
                        {
                            ziyaret(sol);
                        }
                    }
                    else
                    {
                        if (sol.BackColor == Color.White)
                        {
                            ziyaret(sag);
                        }
                        else
                        {
                            if (int.Parse(sag.Text) > int.Parse(sol.Text))
                            {
                                ziyaret(sag);
                            }
                            else
                            {
                                ziyaret(sol);
                            }
                        }
                    }
                }
                else
                {
                    if (sag.BackColor == Color.White)
                    {
                        if (sol.BackColor == Color.White)
                        {
                            ziyaret(alt);
                        }
                        else
                        {
                            if(int.Parse(alt.Text) > int.Parse(sol.Text))
                            {
                                ziyaret(alt);
                            }
                            else
                            {
                                ziyaret(sol);
                            }
                        }
                    }
                    else
                    {
                        if (sol.BackColor == Color.White)
                        {
                            if (int.Parse(alt.Text) > int.Parse(sag.Text))
                            {
                                ziyaret(alt);
                            }
                            else
                            {
                                ziyaret(sag);
                            }
                        }
                        else
                        {
                            if (int.Parse(alt.Text) > int.Parse(sag.Text))
                            {
                                if (int.Parse(alt.Text) > int.Parse(sol.Text))
                                {
                                    ziyaret(alt);
                                }
                                else
                                {
                                    ziyaret(sol);
                                }
                            }
                            else
                            {
                                if (int.Parse(sag.Text) > int.Parse(sol.Text))
                                {
                                    ziyaret(sag);
                                }
                                else
                                {
                                    ziyaret(sol);
                                }
                            }
                        }
                    }
                }

            }else if (kgn.Name == "button26" || kgn.Name == "button27" || kgn.Name == "button28" || kgn.Name == "button29")
            {
                // Butonun 3 komşusu varsa.

                int buton_no = int.Parse(kgn.Name.Replace("button", ""));
                int btn_ust = buton_no - 6;
                int btn_sag = buton_no + 1;
                int btn_sol = buton_no - 1;

                ust = (Button)this.Controls["button" + btn_ust];
                sag = (Button)this.Controls["button" + btn_sag];
                sol = (Button)this.Controls["button" + btn_sol];

                if (ust.BackColor == Color.White)
                {
                    if (sag.BackColor == Color.White)
                    {
                        if(sol.BackColor == Color.White)
                        {
                            kgn.BackColor = Color.Black;
                        }
                        else
                        {
                            ziyaret(sol);
                        }
                    }
                    else
                    {
                        if(sol.BackColor == Color.White)
                        {
                            ziyaret(sag);
                        }
                        else
                        {
                            if(int.Parse(sag.Text) > int.Parse(sol.Text))
                            {
                                ziyaret(sag);
                            }
                            else
                            {
                                ziyaret(sol);
                            }
                        }
                    }
                }
                else
                {
                    if(sag.BackColor == Color.White)
                    {
                        if(sol.BackColor == Color.White)
                        {
                            ziyaret(ust);
                        }
                        else
                        {
                            if(int.Parse(ust.Text) > int.Parse(sol.Text))
                            {
                                ziyaret(ust);
                            }
                            else
                            {
                                ziyaret(sol);
                            }
                        }
                    }
                    else
                    {
                        if(sol.BackColor == Color.White)
                        {
                            if(int.Parse(ust.Text) > int.Parse(sag.Text))
                            {
                                ziyaret(ust);
                            }
                            else
                            {
                                ziyaret(sag);
                            }
                        }
                        else
                        {
                            if(int.Parse(ust.Text) > int.Parse(sag.Text))
                            {
                                if(int.Parse(ust.Text) > int.Parse(sol.Text))
                                {
                                    ziyaret(ust);
                                }
                                else
                                {
                                    ziyaret(sol);
                                }
                            }
                            else
                            {
                                if(int.Parse(sag.Text) > int.Parse(sol.Text))
                                {
                                    ziyaret(sag);
                                }
                                else
                                {
                                    ziyaret(sol);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                // 4 komşusu varsa.

                int buton_no = int.Parse(kgn.Name.Replace("button",""));
                int btn_ust = buton_no - 6;
                int btn_alt = buton_no + 6;
                int btn_sag = buton_no + 1;
                int btn_sol = buton_no - 1;

                ust = (Button)this.Controls["button" + btn_ust];
                alt = (Button)this.Controls["button" + btn_alt];
                sag = (Button)this.Controls["button" + btn_sag];
                sol = (Button)this.Controls["button" + btn_sol];

                if(ust.BackColor == Color.White)
                {
                    if(alt.BackColor == Color.White)
                    {
                        if(sag.BackColor == Color.White)
                        {
                            if(sol.BackColor == Color.White)
                            {
                                kgn.BackColor = Color.Black;
                            }
                            else
                            {
                                ziyaret(sol);
                            }
                        }
                        else
                        {
                            if(sol.BackColor == Color.White)
                            {
                                ziyaret(sag);
                            }
                            else
                            {
                                if(int.Parse(sag.Text) > int.Parse(sol.Text))
                                {
                                    ziyaret(sag);
                                }
                                else
                                {
                                    ziyaret(sol);
                                }
                            }
                        }
                    }
                    else
                    {
                        if(sag.BackColor == Color.White)
                        {
                            if(sol.BackColor == Color.White)
                            {
                                ziyaret(alt);
                            }
                            else
                            {
                                if(int.Parse(alt.Text) > int.Parse(sol.Text))
                                {
                                    ziyaret(alt);
                                }
                                else
                                {
                                    ziyaret(sol);
                                }
                            }
                        }
                        else
                        {
                            if(sol.BackColor == Color.White)
                            {
                                if(int.Parse(alt.Text) > int.Parse(sag.Text))
                                {
                                    ziyaret(alt);
                                }
                                else
                                {
                                    ziyaret(sag);
                                }
                            }
                            else
                            {
                                if(int.Parse(alt.Text) > int.Parse(sag.Text))
                                {
                                    if(int.Parse(alt.Text) > int.Parse(sol.Text))
                                    {
                                        ziyaret(alt);
                                    }
                                    else
                                    {
                                        ziyaret(sol);
                                    }
                                }
                                else
                                {
                                    if(int.Parse(sag.Text) > int.Parse(sol.Text))
                                    {
                                        ziyaret(sag);
                                    }
                                    else
                                    {
                                        ziyaret(sol);
                                    }
                                }
                            }
                        }
                    }

                }
                else
                {
                    if(alt.BackColor == Color.White)
                    {
                        if(sag.BackColor == Color.White)
                        {
                            if(sol.BackColor == Color.White)
                            {
                                ziyaret(ust);
                            }
                            else
                            {
                                if(int.Parse(ust.Text) > int.Parse(sol.Text))
                                {
                                    ziyaret(ust);
                                }
                                else
                                {
                                    ziyaret(sol);
                                }
                            }
                        }
                        else
                        {
                            if(sol.BackColor == Color.White)
                            {
                                if(int.Parse(ust.Text) > int.Parse(sag.Text))
                                {
                                    ziyaret(ust);
                                }
                                else
                                {
                                    ziyaret(sag);
                                }
                            }
                            else
                            {
                                if(int.Parse(ust.Text) > int.Parse(sag.Text))
                                {
                                    if(int.Parse(ust.Text) > int.Parse(sol.Text))
                                    {
                                        ziyaret(ust);
                                    }
                                    else
                                    {
                                        ziyaret(sol);
                                    }
                                }
                                else
                                {
                                    if(int.Parse(sag.Text) > int.Parse(sol.Text))
                                    {
                                        ziyaret(sag);
                                    }
                                    else
                                    {
                                        ziyaret(sol);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if(sag.BackColor == Color.White)
                        {
                            if(sol.BackColor == Color.White)
                            {
                                if(int.Parse(ust.Text) > int.Parse(alt.Text))
                                {
                                    ziyaret(ust);
                                }
                                else
                                {
                                    ziyaret(alt);
                                }
                            }
                            else
                            {
                                if(int.Parse(ust.Text) > int.Parse(alt.Text))
                                {
                                    if(int.Parse(ust.Text) > int.Parse(sol.Text))
                                    {
                                        ziyaret(ust);
                                    }
                                    else
                                    {
                                        ziyaret(sol);
                                    }
                                }
                                else
                                {
                                    if(int.Parse(alt.Text) > int.Parse(sol.Text))
                                    {
                                        ziyaret(alt);
                                    }
                                    else
                                    {
                                        ziyaret(sol);
                                    }
                                }
                            }
                        }
                        else
                        {
                            if(sol.BackColor == Color.White)
                            {
                                if(int.Parse(ust.Text) > int.Parse(alt.Text))
                                {
                                    if(int.Parse(ust.Text) > int.Parse(sag.Text))
                                    {
                                        ziyaret(ust);
                                    }
                                    else
                                    {
                                        ziyaret(sag);
                                    }
                                }
                                else
                                {
                                    if(int.Parse(alt.Text) > int.Parse(sag.Text))
                                    {
                                        ziyaret(alt);
                                    }
                                    else
                                    {
                                        ziyaret(sag);
                                    }
                                }
                            }
                            else
                            {
                                if(int.Parse(ust.Text) > int.Parse(alt.Text))
                                {
                                    if(int.Parse(ust.Text) > int.Parse(sag.Text))
                                    {
                                        if(int.Parse(ust.Text) > int.Parse(sol.Text))
                                        {
                                            ziyaret(ust);
                                        }
                                        else
                                        {
                                            ziyaret(sol);
                                        }
                                    }
                                    else
                                    {
                                        if(int.Parse(sag.Text) > int.Parse(sol.Text))
                                        {
                                            ziyaret(sag);
                                        }
                                        else
                                        {
                                            ziyaret(sol);
                                        }
                                    }
                                }
                                else
                                {
                                    if(int.Parse(alt.Text) > int.Parse(sag.Text))
                                    {
                                        if(int.Parse(alt.Text) > int.Parse(sol.Text))
                                        {
                                            ziyaret(alt);
                                        }
                                        else
                                        {
                                            ziyaret(sol);
                                        }
                                    }
                                    else
                                    {
                                        if(int.Parse(sag.Text) > int.Parse(sol.Text))
                                        {
                                            ziyaret(sag);
                                        }
                                        else
                                        {
                                            ziyaret(sol);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnkgn(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ziyaret(btn);
        }
    }
}
