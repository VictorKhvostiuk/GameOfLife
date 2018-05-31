using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1_gameoflife
{
    public partial class Form1 : Form
    {
        Timer timer;
        bool[,] cells;
        Button[,] btns;
        Button[,] btns2;
        public int IsMember(bool[,] cells, int size, int x, int y, int offsetx, int offsety)
        {
            int result = 0;
            int currentposX = x + offsetx;
            int currentposY = y + offsety;
            bool Isincells = currentposX < 0 || currentposX >= size | currentposY < 0 || currentposY >= size;
            if (!Isincells)
            {
                result = cells[x + offsetx, y + offsety] ? 1 : 0;
            }
            return result;
        }
        public Form1()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 400;
            timer.Tick += timer_Tick;



            //////////////////////////////////
            btns2 = new Button[4, 3];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    btns2[i, j] = new Button();
                    btns2[i, j].Width = 20;
                    btns2[i, j].Height = 20;
                    btns2[i, j].Location = new Point((j + 4) * 20, (i + 10) * 20);
                    btns2[i, j].BackColor = Color.White;

                    panel1.Controls.Add(btns2[i, j]);
                }

            }
            btns2[1, 0].BackColor = Color.Black;
            btns2[1, 2].BackColor = Color.Black;
            btns2[2, 1].BackColor = Color.Black;
            btns2[2, 2].BackColor = Color.Black;
            btns2[3, 1].BackColor = Color.Black;


            /////////////////////////////////


            cells = new bool[45, 45];
            //cells[10, 11] = true;
            //cells[11, 10] = true;
            //cells[11, 11] = true;
            //cells[11, 12] = true;
            //cells[12, 10] = true;
            //cells[12, 12] = true;
            //cells[13, 11] = true;

            ///////////////////////////////////
            //cells[6, 4] = true;
            //cells[7, 4] = true;
            //cells[6, 5] = true;
            //cells[7, 5] = true;
            /////////////
            //cells[7, 12] = true;
            //cells[8, 12] = true;
            //cells[6, 13] = true;
            //cells[8, 13] = true;
            //cells[6, 14] = true;
            //cells[7, 14] = true;
            //////////////
            //cells[5, 26] = true;
            //cells[6, 26] = true;
            //cells[6, 27] = true;
            //cells[4, 27] = true;
            //cells[4, 28] = true;
            //cells[5, 28] = true;
            //////////////
            //cells[4, 38] = true;
            //cells[5, 38] = true;
            //cells[5, 39] = true;
            //cells[4, 39] = true;
            //////////////
            //cells[8, 20] = true;
            //cells[9, 20] = true;
            //cells[10, 20] = true;
            //cells[8, 21] = true;
            //cells[9, 22] = true;
            //////////////
            //cells[16, 28] = true;
            //cells[17, 28] = true;
            //cells[16, 29] = true;
            //cells[18, 29] = true;
            //cells[16, 30] = true;
            //////////////
            //cells[11, 39] = true;
            //cells[12, 39] = true;
            //cells[13, 39] = true;
            //cells[11, 40] = true;
            //cells[12, 41] = true;e
            //////////////////////////////////
            cells[8, 5] = true;
            cells[9, 5] = true;
            cells[10, 5] = true;

            cells[5, 6] = true;
            cells[6, 6] = true;
            cells[10, 6] = true;

            cells[5, 7] = true;
            cells[6, 7] = true;
            cells[7, 7] = true;
            cells[8, 7] = true;
            cells[9, 7] = true;

            cells[5, 9] = true;
            cells[6, 9] = true;
            cells[7, 9] = true;
            cells[8, 9] = true;
            cells[9, 9] = true;

            cells[5, 10] = true;
            cells[6, 10] = true;
            cells[10, 10] = true;

            cells[8, 11] = true;
            cells[9, 11] = true;
            cells[10, 11] = true;



            btns = new Button[45, 45];
            for (int i = 0; i < 45; i++)
            {
                for (int j = 0; j < 45; j++)
                {

                    btns[i, j] = new Button();
                    btns[i, j].Width = 15;
                    btns[i, j].Height = 15;
                    btns[i, j].Location = new Point((j + 1) * 15, (i + 1) * 15);
                    if (cells[i, j])
                        btns[i, j].BackColor = Color.Black;

                    Controls.Add(btns[i, j]);
                }
            }
        }

        void timer_Tick(object sender, EventArgs e)
        {
            //Random r = new Random();
            //int x = r.Next(0, 20);
            //int y = r.Next(0, 20);
            //btns[x, y].BackColor = Color.Black;
            bool[,] cells2 = new bool[45, 45];
            for (int i = 0; i < 45; i++)
            {
                for (int j = 0; j < 45; j++)
                {
                    int numberOfNeighbors = IsMember(cells, 45, i, j, -1, 0)
                            + IsMember(cells, 45, i, j, -1, 1)
                            + IsMember(cells, 45, i, j, 0, 1)
                            + IsMember(cells, 45, i, j, 1, 1)
                            + IsMember(cells, 45, i, j, 1, 0)
                            + IsMember(cells, 45, i, j, 1, -1)
                            + IsMember(cells, 45, i, j, 0, -1)
                            + IsMember(cells, 45, i, j, -1, -1);
                    if (cells[i, j] && (numberOfNeighbors == 2 || numberOfNeighbors == 3))
                        cells2[i, j] = true;
                    else if (!cells[i, j] && numberOfNeighbors == 3)
                        cells2[i, j] = true;
                    else if (cells[i, j] && (numberOfNeighbors < 2 || numberOfNeighbors > 3))
                        cells2[i, j] = false;
                    else cells2[i, j] = cells[i, j];
                    if (cells2[i, j])
                        btns[i, j].BackColor = Color.Black;
                    else
                        btns[i, j].BackColor = Color.White;
                }

            }
            for (int i = 0; i < 45; i++)
            {
                for (int j = 0; j < 45; j++)
                {
                    cells[i, j] = cells2[i, j];
                }
            }



        }

        private void button1_Start_Click(object sender, EventArgs e)
        {
            timer.Start();


        }

        private void button_Pause_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void button1_restart_Click(object sender, EventArgs e)
        {
            timer.Stop();
            for (int i = 0; i < 45; i++)
            {
                for (int j = 0; j < 45; j++)
                    cells[i, j] = false;
            }
            //cells[10, 11] = true;
            //cells[11, 10] = true;
            //cells[11, 11] = true;
            //cells[11, 12] = true;
            //cells[12, 10] = true;
            //cells[12, 12] = true;
            //cells[13, 11] = true;
            ///////////////////////
       
            //cells[6, 4] = true;
            //cells[7, 4] = true;
            //cells[6, 5] = true;
            //cells[7, 5] = true;
            /////////////
            //cells[7, 12] = true;
            //cells[8, 12] = true;
            //cells[6, 13] = true;
            //cells[8, 13] = true;
            //cells[6, 14] = true;
            //cells[7, 14] = true;
            //////////////
            //cells[5, 26] = true;
            //cells[6, 26] = true;
            //cells[6, 27] = true;
            //cells[4, 27] = true;
            //cells[4, 28] = true;
            //cells[5, 28] = true;
            //////////////
            //cells[4, 38] = true;
            //cells[5, 38] = true;
            //cells[5, 39] = true;
            //cells[4, 39] = true;
            //////////////
            //cells[8, 20] = true;
            //cells[9, 20] = true;
            //cells[10, 20] = true;
            //cells[8, 21] = true;
            //cells[9, 22] = true;
            //////////////
            //cells[16, 28] = true;
            //cells[17, 28] = true;
            //cells[16, 29] = true;
            //cells[18, 29] = true;
            //cells[16, 30] = true;
            //////////////
            //cells[11, 39] = true;
            //cells[12, 39] = true;
            //cells[13, 39] = true;
            //cells[11, 40] = true;
            //cells[12, 41] = true;
            cells[8, 5] = true;
            cells[9, 5] = true;
            cells[10, 5] = true;

            cells[5, 6] = true;
            cells[6, 6] = true;
            cells[10, 6] = true;

            cells[5, 7] = true;
            cells[6, 7] = true;
            cells[7, 7] = true;
            cells[8, 7] = true;
            cells[9, 7] = true;

            cells[5, 9] = true;
            cells[6, 9] = true;
            cells[7, 9] = true;
            cells[8, 9] = true;
            cells[9, 9] = true;

            cells[5, 10] = true;
            cells[6, 10] = true;
            cells[10, 10] = true;

            cells[8, 11] = true;
            cells[9, 11] = true;
            cells[10, 11] = true;
            for (int i = 0; i < 45; i++)
            {
                for (int j = 0; j < 45; j++)
                {
                    if (cells[i, j])
                        btns[i, j].BackColor = Color.Black;
                    else
                        btns[i, j].BackColor = Color.White;
                }
            }
        }


    }
}
