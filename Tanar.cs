using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace Karesz
{
    public partial class Form1 : Form
    {
        string betöltendő_pálya = "palya009.txt";

        void TANÁR_ROBOTJAI()
        {
            new Robot("Karesz", 10, 10, 10, 10, 15, 3, 1, 2);


            /*Robot janesz = new Robot("Janesz", Robot.képkészlet_lilesz, 0, 0, 0, 0, 1500, 35, 13, 2);


            janesz.Feladat = delegate ()
            {
                while (pálya.MiVanItt(new Vektor(39, 29)) == sárga)
                {
                    janesz.Lőjj();
                    for (int j = 0; j < 3; j++)
                    {
                        janesz.Várj();
                    }

                }
            };

            Robot paresz = new Robot("paresz", Robot.képkészlet_lilesz, 0, 0, 0, 0, 1500, 35, 17, 1);


            paresz.Feladat = delegate ()
            {
                while (pálya.MiVanItt(new Vektor(39, 29)) == sárga)
                {
                    paresz.Lőjj();
                    for (int j = 0; j < 6; j++)
                    {
                        paresz.Várj();
                    }

                }
            };*/

            Robot matyesz = new Robot("matyesz", Robot.képkészlet_lilesz, 0, 0, 0, 0, 1500, 1, 28, 1);

            matyesz.Feladat = delegate ()
            {
                int a = 0;
                int irany = 0;
                while (pálya.MiVanItt(new Vektor(3, 29)) == sárga)
                {
                    

                    for (int i = 0; i < 4; i++)
                    {
                        matyesz.Lépj();
                        if (irany % 2 == 0)
                        {
                            matyesz.Fordulj(balra);
                            matyesz.Lőjj();
                            matyesz.Fordulj(jobbra);
                        }
                        else
                        {
                            matyesz.Fordulj(jobbra);
                            matyesz.Lőjj();
                            matyesz.Fordulj(balra);
                        }
                        
                    }
                    if (matyesz.Előtt_fal_van() == true)
                    {
                        matyesz.Fordulj(balra);
                        matyesz.Fordulj(balra);
                        irany++;
                    }

                }
            };

        }
    }
}