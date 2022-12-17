using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppGenetic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Point[,] pos = new Point[64, 10];
        bool done = false;



        int i;
        int[] fit = new int[8];
        Random rnd = new Random();
        //i-j==x[i]-x[j];
        // if(x[i]==x[j]);--
        public int fitness(int[] x)
        {
            int[] n = { 7,7,7,7,7,7,7,7};
            int co = 0;
            int j;
            for (int i = 0; i < 8; i++)
            {


                for (j = 0; j < 8; j++)
                {
                    if (i == 7 && j == 7)
                    {
                        break;
                    }
                    else if (i == j)
                    {
                        j++;

                    }

                    if (x[i] == x[j] || Math.Abs(i - j) == Math.Abs(x[i] - x[j]))
                        co++;
                }
                n[i] -= co;
                co = 0;
            }
            for (int k = 0; k <= 7; k++)
            {
                co += n[k];
            }
            co = co / 2;

            return co;
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            int l = 200;
            int t = 45;
            int k = 0;
            int d = 0;
            for (int i = 0; i < 63; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    pos[i, j].Y = t + k * 38;
                    pos[i, j].X = l + d * 45;
                    k++;
                }

                k = 0;
                d++;
            }
           
              
           
        }
        int index = 0;
        int index1 = 1;
        int ind = 1;
        int ind1 = 9;
        private void timer1_Tick(object sender, EventArgs e)
        {

            pictureBox2.Top = pos[index, index1].Y;
            pictureBox2.Left = pos[index, index1].X;
            index1++;

            if (index1 * ind % ind1 == 0)
            {
                index++;
                ind++;
                ind1 += 9;
            }
            if (index1 == 10)
            {
                pictureBox2.Top = 45;

                index1 = 1;
            }



            if (index == 64)
            {
                index = 0;
            }
        }
       
        
        private void button1_Click(object sender, EventArgs e)
        {
            //int[] cc = { 3,1,6,2,1,8,2,7 };
            //MessageBox.Show(fitness(cc).ToString());

            for (int ff = 0; ff < 10000; ff++)
            {
                int[] x1 = new int[8];
                int[] x2 = new int[8];
                int[] x3 = new int[8];
                int[] x4 = new int[8];
                int[] x5 = new int[8];
                int[] x6 = new int[8];
                int[] x7 = new int[8];
                int[] x8 = new int[8];
                int[] x9 = new int[8];
                int[] x10 = new int[8];
                int[] x11 = new int[8];
                int[] x12 = new int[8];
                int[] x13 = new int[8];
                int[] x14 = new int[8];
                int[] x15 = new int[8];
                int[] x16 = new int[8];
                int[] x17 = new int[8];
                int[] x18 = new int[8];
                int[] x19 = new int[8];
                int[] x20 = new int[8];



                int[] f1 = new int[8];
                int[] f2 = new int[8];
                int[] f3 = new int[8];
                int[] f4 = new int[8];
                int[] f5 = new int[8];
                int[] f6 = new int[8];
                int[] f7 = new int[8];
                int[] f8 = new int[8];
                int[] f9 = new int[8];
                int[] f10 = new int[8];
                int[] f11 = new int[8];
                int[] f12 = new int[8];
                int[] f13 = new int[8];
                int[] f14 = new int[8];
                int[] f15 = new int[8];
                int[] f16 = new int[8];
                int[] f17 = new int[8];
                int[] f18 = new int[8];
                int[] f19 = new int[8];
                int[] f20 = new int[8];

                int[] h = { 3, 6, 2, 7, 1, 4, 8, 5 };
                //MessageBox.Show(fitness(h).ToString()); 

                int sum = 0;
                int y1, y2, y3, y4, y5, y6, y7, y8, y9, y10, y11, y12, y13, y14, y15, y16, y17, y18, y19, y20;

                for (i = 0; i <= 7; i++)
                {
                    x1[i] = rnd.Next(1, 9);
                    x2[i] = rnd.Next(1, 9);
                    x3[i] = rnd.Next(1, 9);
                    x4[i] = rnd.Next(1, 9);
                    x5[i] = rnd.Next(1, 9);
                    x6[i] = rnd.Next(1, 9);
                    x7[i] = rnd.Next(1, 9);
                    x8[i] = rnd.Next(1, 9);
                    x9[i] = rnd.Next(1, 9);
                    x10[i] = rnd.Next(1, 9);
                    x11[i] = rnd.Next(1, 9);
                    x12[i] = rnd.Next(1, 9);
                    x13[i] = rnd.Next(1, 9);
                    x14[i] = rnd.Next(1, 9);
                    x15[i] = rnd.Next(1, 9);
                    x16[i] = rnd.Next(1, 9);
                    x17[i] = rnd.Next(1, 9);
                    x18[i] = rnd.Next(1, 9);
                    x19[i] = rnd.Next(1, 9);
                    x20[i] = rnd.Next(1, 9);
                }



                y1 = fitness(x1);
                y2 = fitness(x2);
                y3 = fitness(x3);
                y4 = fitness(x4);
                y5 = fitness(x5);
                y6 = fitness(x6);
                y7 = fitness(x7);
                y8 = fitness(x8);
                y9 = fitness(x9);
                y10 = fitness(x10);
                y11 = fitness(x11);
                y12 = fitness(x12);
                y13 = fitness(x13);
                y14 = fitness(x14);
                y15 = fitness(x15);
                y16 = fitness(x16);
                y17 = fitness(x17);
                y18 = fitness(x18);
                y19 = fitness(x19);
                y20 = fitness(x20);
                sum = y1 + y2 + y3 + y4 + y5 + y6 + y7 + y8 + y9 + y10
                    + y11 + y12 + y13 + y14 + y15 + y16 + y17 + y18 + y19 + y20;


                int[,] yc = new int[20, 8];
                string outputt = "";
                //int t = 0;
                int j = 0;
                int rn = 0;
                bool c = false;
                Random rnd2 = new Random();
                for (int t = 0; t < 20; t++)
                {
                    rn = rnd2.Next(1, sum);
                    if (rn < y1)
                    {



                        for (j = 0; j <= 7; j++)
                        {

                            yc[t, j] = x1[j];

                        }


                    }
                    //MessageBox.Show(yc[0, 2].ToString());

                    //if (c == false)
                    //{
                    //    t--;
                    //}

                    else if (rn > y1 && rn < y1 + y2)
                    {



                        for (j = 0; j <= 7; j++)
                        {

                            yc[t, j] = x2[j];
                        }

                    }



                    else if (rn > y1 + y2 && rn < y1 + y2 + y3)
                    {


                        for (j = 0; j <= 7; j++)
                        {

                            yc[t, j] = x3[j];


                        }

                    }



                    else if (rn > y1 + y2 + y3 && rn < y1 + y2 + y3 + y4)
                    {


                        for (j = 0; j <= 7; j++)
                        {

                            yc[t, j] = x4[j];


                        }

                    }



                    else if (rn > y1 + y2 + y3 + y4 && rn < y1 + y2 + y3 + y4 + y5)
                    {


                        for (j = 0; j <= 7; j++)
                        {

                            yc[t, j] = x5[j];


                        }


                    }



                    else if (rn > y1 + y2 + y3 + y4 + y5 && rn < y1 + y2 + y3 + y4 + y5 + y6)
                    {


                        for (j = 0; j <= 7; j++)
                        {

                            yc[t, j] = x6[j];


                        }


                    }



                    else if (rn > y1 + y2 + y3 + y4 + y5 + y6 && rn < y1 + y2 + y3 + y4 + y5 + y6 + y7)
                    {


                        for (j = 0; j <= 7; j++)
                        {

                            yc[t, j] = x7[j];


                        }


                    }



                    else if (rn > y1 + y2 + y3 + y4 + y5 + y6 + y7 && rn < y1 + y2 + y3 + y4 + y5 + y6 + y7 + y8)
                    {


                        for (j = 0; j <= 7; j++)
                        {

                            yc[t, j] = x8[j];


                        }

                    }



                    else if (rn > y1 + y2 + y3 + y4 + y5 + y6 + y7 + y8 && rn < y1 + y2 + y3 + y4 + y5 + y6 + y7 + y8 + y9)
                    {


                        for (j = 0; j <= 7; j++)
                        {

                            yc[t, j] = x9[j];


                        }


                    }



                    else if (rn > y1 + y2 + y3 + y4 + y5 + y6 + y7
                         + y8 + y9 && rn < y1 + y2 + y3 + y4 + y5 + y6 + y7 + y8 + y9 + y10)
                    {


                        for (j = 0; j <= 7; j++)
                        {

                            yc[t, j] = x10[j];


                        }


                    }



                    else if (rn > y1 + y2 + y3 + y4 + y5 + y6 + y7
                         + y8 + y9 + y10 && rn < y1 + y2 + y3 + y4 + y5 + y6 + y7 + y8 + y9 + y10 + y11)
                    {


                        for (j = 0; j <= 7; j++)
                        {

                            yc[t, j] = x11[j];


                        }


                    }




                    else if (rn > y1 + y2 + y3 + y4 + y5 + y6 + y7
                         + y8 + y9 + y10 + y11 && rn < y1 + y2 + y3 + y4 + y5 + y6 + y7 + y8 + y9 + y10 + y11 + y12)
                    {


                        for (j = 0; j <= 7; j++)
                        {

                            yc[t, j] = x12[j];


                        }


                    }


                    else if (rn > y1 + y2 + y3 + y4 + y5 + y6 + y7
                         + y8 + y9 + y10 + y11 + y12 && rn < y1 + y2 + y3 + y4 + y5 + y6 + y7 + y8 + y9 + y10 + y11 + y12 + y13)
                    {



                        for (j = 0; j <= 7; j++)
                        {

                            yc[t, j] = x13[j];


                        }


                    }


                    else if (rn > y1 + y2 + y3 + y4 + y5 + y6 + y7
                         + y8 + y9 + y10 + y11 + y12 + y13 && rn < y1 + y2 + y3 + y4 + y5 + y6 + y7 + y8 + y9 + y10 + y11
                         + y12 + y13 + y14)
                    {


                        for (j = 0; j <= 7; j++)
                        {

                            yc[t, j] = x14[j];


                        }


                    }



                    else if (rn > y1 + y2 + y3 + y4 + y5 + y6 + y7
                         + y8 + y9 + y10 + y11 + y12 + y13 + y14 && rn < y1 + y2 + y3 + y4 + y5 + y6 + y7 + y8 + y9 + y10 + y11
                         + y12 + y13 + y14 + y15)
                    {


                        for (j = 0; j <= 7; j++)
                        {

                            yc[t, j] = x15[j];


                        }

                    }



                    else if (rn > y1 + y2 + y3 + y4 + y5 + y6 + y7
                         + y8 + y9 + y10 + y11 + y12 + y13 + y14 + y15 && rn < y1 + y2 + y3 + y4 + y5 + y6 + y7 + y8 + y9 + y10 + y11
                         + y12 + y13 + y14 + y15 + y16)
                    {


                        for (j = 0; j <= 7; j++)
                        {

                            yc[t, j] = x16[j];


                        }


                    }



                    else if (rn > y1 + y2 + y3 + y4 + y5 + y6 + y7
                         + y8 + y9 + y10 + y11 + y12 + y13 + y14 + y15 + y16 && rn < y1 + y2 + y3 + y4 + y5 + y6 + y7 + y8 + y9 + y10 + y11
                         + y12 + y13 + y14 + y15 + y16 + y17)
                    {


                        for (j = 0; j <= 7; j++)
                        {

                            yc[t, j] = x17[j];


                        }


                    }



                    else if (rn > y1 + y2 + y3 + y4 + y5 + y6 + y7
                         + y8 + y9 + y10 + y11 + y12 + y13 + y14 + y15 + y16 + y17 && rn < y1 + y2 + y3 + y4 + y5 + y6 + y7 + y8 + y9 + y10 + y11
                         + y12 + y13 + y14 + y15 + y16 + y17 + y18)
                    {


                        for (j = 0; j <= 7; j++)
                        {

                            yc[t, j] = x18[j];


                        }

                    }



                    else if (rn > y1 + y2 + y3 + y4 + y5 + y6 + y7
                         + y8 + y9 + y10 + y11 + y12 + y13 + y14 + y15 + y16 + y17 + y18 && rn < y1 + y2 + y3 + y4 + y5 + y6 + y7 + y8 + y9 + y10 + y11
                         + y12 + y13 + y14 + y15 + y16 + y17 + y18 + y19)
                    {


                        for (j = 0; j <= 7; j++)
                        {

                            yc[t, j] = x19[j];


                        }
                    }
                    //  (rn > y1 + y2 + y3 + y4 + y5 + y6 + y7
                    //      + y8 + y9 + y10 + y11 + y12 + y13 + y14 + y15 + y16 + y17 + y18 + y19 && rn < y1 + y2 + y3 + y4 + y5 + y6 + y7 + y8 + y9 + y10 + y11
                    //      + y12 + y13 + y14 + y15 + y16 + y17 + y18 + y19 + y20)
                    else
                    {


                        for (j = 0; j <= 7; j++)
                        {

                            yc[t, j] = x20[j];
                        }

                    }
                    //c = false;

                }
                for (int z = 0; z < yc.GetLength(0); z++)
                {
                    for (int v = 0; v < yc.GetLength(1); v++)
                    {
                        outputt += yc[z, v].ToString() + "\t";
                    }
                    outputt += "\n";
                }
                int[,] yc2 = new int[20, 8];
                int r = 0; int d = 0;
                for (r = 0; r < yc2.GetLength(0); r++)
                {
                    rn = rnd2.Next(0, 8);
                    for (d = 0; d < rn; d++)
                    {
                        yc2[r, d] = yc[r, d];
                    }
                    r++;
                    if (r > 19)
                    {
                        r--;
                    }
                    for (d = rn; d < yc2.GetLength(1); d++)
                    {
                        yc2[r - 1, d] = yc[r, d];
                    }
                    for (d = 0; d < rn; d++)
                    {
                        yc2[r, d] = yc[r, d];
                    }
                    r--;
                    for (d = rn; d < yc2.GetLength(1); d++)
                    {
                        yc2[r + 1, d] = yc[r, d];
                    }
                    r++;
                }
                //MessageBox.Show(outputt);
                string yout = "";
                for (int z = 0; z < yc2.GetLength(0); z++)
                {
                    for (int v = 0; v < yc2.GetLength(1); v++)
                    {
                        yout += yc2[z, v].ToString() + "\t";
                    }
                    yout += "\n";
                }
                //MessageBox.Show(yout);
                int rn1;
                string tr = "y";
                for (int z = 0; z < yc2.GetLength(0); z++)
                {
                    rn = rnd2.Next(0, 8);
                    rn1 = rnd2.Next(1, 9);
                    yc2[z, rn] = rn1;
                }
                string you = "";
                for (int z = 0; z < yc2.GetLength(0); z++)
                {
                    for (int v = 0; v < yc2.GetLength(1); v++)
                    {
                        you += yc2[z, v].ToString() + "\t";
                    }
                    you += "\n";
                }
                //MessageBox.Show(you);
                int k1, k2, k3, k4, k5, k6, k7, k8, k9, k10, k11, k12, k13, k14, k15, k16, k17, k18, k19, k20;
                for (int i = 0; i < 20; i++)
                {
                    for (int u = 0; u < 8; u++)
                    {
                        f1[u] = yc2[i, u];
                    }
                    k1 = fitness(f1);
                    i++;
                    for (int u = 0; j < 8; u++)
                    {
                        f2[u] = yc2[i, u];
                    }
                    k2 = fitness(f2);
                    i++;
                    for (int u = 0; u < 8; u++)
                    {
                        f3[u] = yc2[i, u];
                    }
                    k3 = fitness(f3);

                    i++;
                    for (int u = 0; u < 8; u++)
                    {
                        f4[u] = yc2[i, u];
                    }
                    k4 = fitness(f4);

                    i++;
                    for (int u = 0; u < 8; u++)
                    {
                        f5[u] = yc2[i, u];
                    }
                    k5 = fitness(f5);

                    i++;
                    for (int u = 0; u < 8; u++)
                    {
                        f6[u] = yc2[i, u];
                    }
                    k6 = fitness(f6);
                    i++;
                    for (int u = 0; u < 8; u++)
                    {
                        f7[u] = yc2[i, u];
                    }
                    k7 = fitness(f7);
                    i++;
                    for (int u = 0; u < 8; u++)
                    {
                        f8[u] = yc2[i, u];
                    }
                    k8 = fitness(f8);
                    i++;
                    for (int u = 0; u < 8; u++)
                    {
                        f9[u] = yc2[i, u];
                    }
                    k9 = fitness(f9);
                    i++;
                    for (int u = 0; u < 8; u++)
                    {
                        f10[u] = yc2[i, u];
                    }
                    k10 = fitness(f10);

                    i++;
                    for (int u = 0; u < 8; u++)
                    {
                        f11[u] = yc2[i, u];
                    }
                    k11 = fitness(f11);

                    i++;
                    for (int u = 0; u < 8; u++)
                    {
                        f12[u] = yc2[i, u];
                    }
                    k12 = fitness(f12);

                    i++;
                    for (int u = 0; u < 8; u++)
                    {
                        f13[u] = yc2[i, u];
                    }
                    k13 = fitness(f13);

                    i++;
                    for (int u = 0; u < 8; u++)
                    {
                        f14[u] = yc2[i, u];
                    }
                    k14 = fitness(f14);

                    i++;
                    for (int u = 0; u < 8; u++)
                    {
                        f15[u] = yc2[i, u];
                    }
                    k15 = fitness(f15);

                    i++;
                    for (int u = 0; u < 8; u++)
                    {
                        f16[u] = yc2[i, u];
                    }
                    k16 = fitness(f16);

                    i++;
                    for (int u = 0; u < 8; u++)
                    {
                        f17[u] = yc2[i, u];
                    }
                    k17 = fitness(f17);

                    i++;
                    for (int u = 0; u < 8; u++)
                    {
                        f18[u] = yc2[i, u];
                    }
                    k18 = fitness(f18);

                    i++;
                    for (int u = 0; u < 8; u++)
                    {
                        f19[u] = yc2[i, u];
                    }
                    k19 = fitness(f19);

                    i++;
                    for (int u = 0; u < 8; u++)
                    {
                        f20[u] = yc2[i, u];
                    }
                    k20 = fitness(f20);

                    i++;
                    if (k1 == 28)
                    {
                        for (int l = 0; l < 8; l++)
                        {
                            fit[l] = f1[l];
                        }
                        done = true;
                        break;
                    }
                    else if (k2 == 28)
                    {
                        for (int l = 0; l < 8; l++)
                        {
                            fit[l] = f2[l];
                        }
                        done = true;
                        break;
                    }
                    else if (k3 == 28)
                    {
                        for (int l = 0; l < 8; l++)
                        {
                            fit[l] = f3[l];
                        }
                        done = true;
                        break;
                    }
                    else if (k4 == 28)
                    {
                        for (int l = 0; l < 8; l++)
                        {
                            fit[l] = f4[l];
                        }
                        done = true;
                        break;
                    }
                    else if (k5 == 28)
                    {
                        for (int l = 0; l < 8; l++)
                        {
                            fit[l] = f5[l];
                        }
                        done = true;
                        break;
                    }

                    else if (k6 == 28)
                    {
                        for (int l = 0; l < 8; l++)
                        {
                            fit[l] = f6[l];
                        }
                        done = true;
                        break;
                    }
                    else if (k7 == 28)
                    {
                        for (int l = 0; l < 8; l++)
                        {
                            fit[l] = f7[l];
                        }
                        done = true;
                        break;
                    }
                    else if (k8 == 28)
                    {
                        for (int l = 0; l < 8; l++)
                        {
                            fit[l] = f8[l];
                        }
                        done = true;
                        break;
                    }

                    else if (k9 == 28)
                    {
                        for (int l = 0; l < 8; l++)
                        {
                            fit[l] = f9[l];
                        }
                        done = true;
                        break;
                    }
                    else if (k10 == 28)
                    {
                        for (int l = 0; l < 8; l++)
                        {
                            fit[l] = f10[l];
                        }
                        done = true;
                        break;
                    }
                    else if (k11 == 28)
                    {
                        for (int l = 0; l < 8; l++)
                        {
                            fit[l] = f11[l];
                        }
                        done = true;
                        break;
                    }
                    else if (k12 == 28)
                    {
                        for (int l = 0; l < 8; l++)
                        {
                            fit[l] = f12[l];
                        }
                        done = true;
                        break;
                    }

                    else if (k13 == 28)
                    {
                        for (int l = 0; l < 8; l++)
                        {
                            fit[l] = f13[l];
                        }
                        done = true;
                        break;
                    }
                    else if (k14 == 28)
                    {
                        for (int l = 0; l < 8; l++)
                        {
                            fit[l] = f14[l];
                        }
                        done = true;
                        break;
                    }
                    else if (k15 == 28)
                    {
                        for (int l = 0; l < 8; l++)
                        {
                            fit[l] = f15[l];
                        }
                        done = true;
                        break;
                    }
                    else if (k16 == 28)
                    {
                        for (int l = 0; l < 8; l++)
                        {
                            fit[l] = f16[l];
                        }
                        done = true;
                        break;
                    }
                    else if (k17 == 28)
                    {
                        for (int l = 0; l < 8; l++)
                        {
                            fit[l] = f17[l];
                        }
                        done = true;
                        break;
                    }

                    else if (k18 == 28)
                    {
                        for (int l = 0; l < 8; l++)
                        {
                            fit[l] = f18[l];
                        }
                        done = true;
                        break;
                    }
                    else if (k19 == 28)
                    {
                        for (int l = 0; l < 8; l++)
                        {
                            fit[l] = f19[l];
                        }
                        done = true;
                        break;
                    }
                    else if (k20 == 28)
                    {
                        for (int l = 0; l < 8; l++)
                        {
                            fit[l] = f20[l];
                        }
                        done = true;
                        break;
                    }
                }
                //if (fitness(fit) == 28)
                //{
                //    break;
                //}
                //MessageBox.Show(fitness(x1).ToString());
                //for (int y = 0; y < 8; y++)
                //    {
                //        you = fit[y] + "\t";
                //    }
                //k1 = fitness(f1);
            }
                if (done == true)
                {
                    int a = 0;
                    int w = 0;
                    pictureBox2.Top = pos[w, fit[a]].Y;
                    pictureBox2.Left = pos[w, fit[a]].X;
                    a++;
                    w++;
                    pictureBox3.Top = pos[w, fit[a]].Y;
                    pictureBox3.Left = pos[w, fit[a]].X;
                    a++;
                    w++;
                    pictureBox4.Top = pos[w, fit[a]].Y;
                    pictureBox4.Left = pos[w, fit[a]].X;
                    a++;
                    w++;
                    pictureBox5.Top = pos[w, fit[a]].Y;
                    pictureBox5.Left = pos[w, fit[a]].X;
                    a++;
                    w++;
                    pictureBox6.Top = pos[w, fit[a]].Y;
                    pictureBox6.Left = pos[w, fit[a]].X;
                    a++;
                    w++;
                    pictureBox7.Top = pos[w, fit[a]].Y;
                    pictureBox7.Left = pos[w, fit[a]].X;
                    a++;
                    w++;
                    pictureBox8.Top = pos[w, fit[a]].Y;
                    pictureBox8.Left = pos[w, fit[a]].X;
                    a++;
                    w++;
                    pictureBox9.Top = pos[w, fit[a]].Y;
                    pictureBox9.Left = pos[w, fit[a]].X;

                    MessageBox.Show("You Finally Did It Boy", "Announcment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Try Again");
                }
        }

    }
}

