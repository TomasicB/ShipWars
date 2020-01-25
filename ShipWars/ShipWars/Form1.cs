using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using IronPython.Hosting;
using IronPython.Runtime;
using Microsoft.Scripting;
using Microsoft.Scripting.Hosting;

namespace ShipWars
{
    public partial class Form1 : Form
    {
        ScriptEngine pyEngine = null;
        ScriptScope pyScope = null;
        int count_up_p1 = 1, count_down_p1 = 1;
        int count_P1ships = 1, count_P2ships = 1;
        public Graphics gup, gdown;
        public Graphics gup_p2, gdown_p1;
        int shots_p1 = 0, turns_p1 = 0, hits_p1 = 0;
        int shots_PC = 0, hits_PC = 0;
        int[] control_p1 = { 0, 0, 0, 0, 0 };
        List<Squareup> l_up_p1 = new List<Squareup>();
        List<Squaredown> l_down_p1 = new List<Squaredown>();
        List<Squaredown> l_P1ships = new List<Squaredown>();
        List<Squareup> l_P2ships = new List<Squareup>();
        public static string Player1 = "";
        public static int time;
        int len;
        int flag4=1, flag3 =2, flag2=2;
        int checkshots = 0;
        
        public Form1()
        {
            InitializeComponent();

            pyEngine = Python.CreateEngine();
            pyScope = pyEngine.CreateScope();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            gup = pb_up_p1.CreateGraphics();
            gdown = pb_down_p1.CreateGraphics();
            gup_p2 = pbP2ships.CreateGraphics();
            gdown_p1 = pbP1ships.CreateGraphics();

            Initializepbup();
            Initializepbdown();
            InitializeP1ships();
            InitializeP2ships();

        }

        public void Initializepbup() //gornji veliki
        {
            for (int i = 0; i < 396; i += 33)
            {
                for (int j = 0; j < 198; j += 33)
                {
                    Squareup squareup = new Squareup(count_up_p1, i, j);
                    l_up_p1.Add(squareup);
                    count_up_p1++;
                }
            }
        }
        public void Initializepbdown() //doljnji veliki
        {
            for (int i = 0; i < 456; i += 38)
            {
                for (int j = 0; j < 228; j += 38)
                {
                    Squaredown squaredown = new Squaredown(count_down_p1, i, j);
                    l_down_p1.Add(squaredown);
                    count_down_p1++;
                }
            }
        }
        public void InitializeP2ships() //gornji mali
        {
            for (int i = 0; i < 132; i += 33)
            {
                for (int j = 0; j < 165; j += 33)
                {
                    Squareup squareP2ships = new Squareup(count_P2ships, i, j);
                    l_P2ships.Add(squareP2ships);
                    count_P2ships++;
                }
            }
        }
        public void InitializeP1ships() //doljnji mali
        {
            for (int i = 0; i < 152; i += 38)
            {
                for (int j = 0; j < 190; j += 38)
                {
                    Squaredown squareP1ships = new Squaredown(count_P1ships, i, j);
                    l_P1ships.Add(squareP1ships);
                    count_P1ships++;
                }
            }
        }

        private void pbP1ships_MouseDown(object sender, MouseEventArgs e) //odabiranje brodica
        {
            if (e.Y > 152 && e.Y < 190)
                if (flag4 == 0) {
                    len = 0;
                    MessageBox.Show("That ship is already placed");
                }
                else {
                    len = 4;
                    flag4--;
                    control_p1[0] = 1;
                }
            else if (e.Y > 76 && e.Y < 152)
                if (flag3 == 0)
                {
                    len = 0;
                    MessageBox.Show("That ship is already placed");
                }
                else
                {
                    len = 3;
                    flag3--;
                    if(flag3==1)
                        control_p1[1] = 1;
                    else if(flag3==0)
                        control_p1[2] = 1;
                }
            else if (e.Y > 0 && e.Y < 76)
                if (flag2 == 0)
                {
                    len = 0;
                    MessageBox.Show("That ship is already placed");
                }
                else
                {
                    len = 2;
                    flag2--;
                    if (flag2 == 1)
                        control_p1[3] = 1;
                    else if (flag2 == 0)
                        control_p1[4] = 1;
                }
            else
                MessageBox.Show("Click agani");
        }

        public void pb_down_p1_MouseUp(object sender, MouseEventArgs e)
        {
            int k=0, l=0;
            int flen = 0, slen = 0;
            int counti = 0, countj = 0, countid = 0;
            for (int i = 0; i <=e.X; i+=38)
            {
                counti++;
                for (int j = 0; j <=e.Y; j+=38)
                {
                    countj++;
                    k = i;
                    l = j;
                }
            }
            countj = countj / counti;
            countid = counti * 6 - (6 - countj);
            if (e.Button == MouseButtons.Left) //crta brodic horizontalno
                if(CheckEdgeH(k) == true && CheckPlaceH(countid,k,l)==true)
                    for (int i = 0; i < len; i++)
                    {
                        Squaredown squareP1ships = new Squaredown(countid + flen, k + slen, l);
                        squareP1ships.Fill(gdown);
                        l_down_p1.Where(w => w.id == countid + flen).ToList().ForEach(s => s.full = true);
                        flen += 6;
                        slen += 38;                    
                    }
            if (e.Button == MouseButtons.Right) //crta brodic vertikalno
                if (CheckEdgeV(l) == true && CheckPlaceV(countid, k,l)== true)
                    for (int i = 0; i < len; i++)
                    {
                        Squaredown squareP1ships = new Squaredown(countid + flen, k , l+ slen);
                        squareP1ships.Fill(gdown);
                        l_down_p1.Where(w => w.id == countid + flen).ToList().ForEach(s => s.full = true);
                        flen += 1;
                        slen += 38;
                    }
            len = 0;
        }

        private bool CheckEdgeH(int k)
        {
            int slen = 0,count=0;
            for (int i = 0; i < len; i++)
                if (k + slen < 456)
                {
                    count++;
                    slen += 38;
                }
            if(count==len)
                return true;
            else
            {
                MessageBox.Show("Your ship is leaving the field. Bring him back");
                if (len == 2)
                    flag2++;
                else if (len == 3)
                    flag3++;
                else
                    flag4++;
                return false;
            }
        }
        private bool CheckEdgeV(int l)
        {
            int slen = 0, count = 0;
            for (int i = 0; i < len; i++)
                if (l + slen < 227)
                {
                    count++;
                    slen += 38;
                }
            if (count == len)
                return true;
            else
            {
                MessageBox.Show("Your ship is leaving the field. Bring him back");
                if (len == 2)
                    flag2++;
                else if (len == 3)
                    flag3++;
                else
                    flag4++;
                return false;
            }
        }

        private bool CheckPlaceH(int b, int k, int l)
        {
            int count = 0, flen = 0, slen = 0;
            foreach (Squaredown sqd in l_down_p1)
            {
                Squaredown squareP1ships = new Squaredown(b + flen, k+ slen, l );
                if (sqd.id == squareP1ships.id && flen<len*6)
                {
                    if(sqd.full==false)
                        count++;
                    flen += 6;
                    slen += 38;
                }
            }
            if (count == len)
                return true;
            else
            {
                MessageBox.Show("That place is taken. Try another one");
                if (len == 2)
                    flag2++;
                else if (len == 3)
                    flag3++;
                else if (len == 4)
                    flag4++;
                return false;
            }
        }
        private bool CheckPlaceV(int b, int k, int l)
        {
            int count = 0, flen = 0, slen = 0;
            foreach (Squaredown sqd in l_down_p1)
            {
                Squaredown squareP1ships = new Squaredown(b + flen, k, l + slen);
                if (sqd.id == squareP1ships.id && flen<len)
                {
                    if(sqd.full == false)
                        count++;
                    flen += 1;
                    slen += 38;
                }
            }
            if (count==len)
                return true;
            else
            {
                MessageBox.Show("That place is taken. Try another one");
                if (len == 2)
                    flag2++;
                else if (len == 3)
                    flag3++;
                else if (len == 4)
                    flag4++;
                return false;
            }
        }

        
        private void pb_up_p1_MouseDown(object sender, MouseEventArgs e)
        {
            if (turns_p1 >= 1)
            {
                if (checkshots == 0)
                {
                    int k = 0, l = 0;
                    int counti = 0, countj = 0, countid = 0;
                    for (int i = 0; i <= e.X; i += 33)
                    {
                        counti++;
                        for (int j = 0; j <= e.Y; j += 33)
                        {
                            countj++;
                            k = i;
                            l = j;
                        }
                    }
                    countj = countj / counti;
                    countid = counti * 6 - (6 - countj);
                    shots_p1++;
                    Squareup squareP1ship = new Squareup(countid, k, l);
                    if (l_up_p1.ElementAt(countid - 1).shot == false)
                    {
                        foreach (Squareup squ in l_up_p1)
                        {
                            if (squ.id == squareP1ship.id && squ.full == true)
                            {
                                hits_p1++;
                                squareP1ship.FillH(gup);
                                l_up_p1.Where(w => w.id == countid).ToList().ForEach(s => s.shot = true);
                                break;
                            }
                            else
                            {
                                squareP1ship.FillM(gup);
                                l_up_p1.Where(w => w.id == countid).ToList().ForEach(s => s.shot = true);
                            }
                        }
                        checkshots = 1;
                    }
                    else
                    {
                        checkshots = 0;
                        shots_p1--;
                        MessageBox.Show("You already shot at that place. Try another one.");
                    }
                }
                else
                    MessageBox.Show("You already shot, click Continue to move on.");
            }
            else
                MessageBox.Show("Wait for other player to place ships.");
        }

        public void FieldDraw() //crtanje svih polja
        {
            foreach (Squareup squareup in l_up_p1)
            {
                squareup.FillS(gup);
                squareup.Draw(gup);
            }
            foreach (Squaredown squaredown in l_down_p1)
            {
                squaredown.FillS(gdown);
                squaredown.Draw(gdown);
            }
            foreach (Squareup squareP2ships in l_P2ships)
                squareP2ships.Draw(gup_p2);
            foreach (Squaredown squareP1ships in l_P1ships)
                squareP1ships.Draw(gdown_p1);
        }

        private void timRound_Tick(object sender, EventArgs e)
        {
            int sek, min;
            time--;
            sek = time % 600/10;
            min = time / 600;
            lbltimeS.Text = sek.ToString();
            lbltimeM.Text = min.ToString();
            if (min == 0 && sek==0) { 
                timRound.Stop();
                MessageBox.Show("Your time has run out.");
                this.Close();
            }
        }

        public void ShipDraw() //crtanje polja brodica na desnoj strani
        {
            foreach (Squareup squareP2ships in l_P2ships)
            {
                if (squareP2ships.id % 5 == 0)
                    squareP2ships.Fill(gup_p2);
                else if (squareP2ships.id % 5 == 4 && squareP2ships.id > 5)
                    squareP2ships.Fill(gup_p2);
                else if (squareP2ships.id % 5 == 3 && squareP2ships.id > 5)
                    squareP2ships.Fill(gup_p2);
                else if (squareP2ships.id % 5 == 2 && squareP2ships.id > 10)
                    squareP2ships.Fill(gup_p2);
                else if (squareP2ships.id % 5 == 1 && squareP2ships.id > 10)
                    squareP2ships.Fill(gup_p2);
                else
                    squareP2ships.FillS(gup_p2);
            }
            foreach (Squaredown squareP1ships in l_P1ships)
            {
                if (squareP1ships.id % 5 == 0)
                    squareP1ships.Fill(gdown_p1);
                else if (squareP1ships.id % 5 == 4 && squareP1ships.id > 5)
                    squareP1ships.Fill(gdown_p1);
                else if (squareP1ships.id % 5 == 3 && squareP1ships.id > 5)
                    squareP1ships.Fill(gdown_p1);
                else if (squareP1ships.id % 5 == 2 && squareP1ships.id > 10)
                    squareP1ships.Fill(gdown_p1);
                else if (squareP1ships.id % 5 == 1 && squareP1ships.id > 10)
                    squareP1ships.Fill(gdown_p1);
                else
                    squareP1ships.FillS(gdown_p1);
            }
        }

        dynamic tipka;
        private void button2_Click(object sender, EventArgs e)
        {
            ScriptSource ss = pyEngine.CreateScriptSourceFromFile("Settings.py");
            ss.Execute(pyScope);
            tipka = pyScope.GetVariable("buttonclick");
            ShipDraw();
            FieldDraw();
            LoadShips();

            tipka(this);

            TextBox tb = new TextBox();
            tb = pyScope.GetVariable("tbName");
            lblp1.Text = tb.Text;

            MessageBox.Show("Your ships are placed horizontaly in bottom right corner.\nTo select wanted ship click on it " +
            "and then click on the place on the field.\nThe place You clicked is the ship field furthest to the left or the top.\n" +
            "To place ship horizontaly use Left click, to place it verticaly use Right click.");

            button2.Enabled = false;
            timRound.Start();
        }
        
        private void bContinue_Click(object sender, EventArgs e)
        {
            timRound.Start();
            int check = 0;
            checkshots = 0;
            if (control_p1[0] == 1 && control_p1[1] == 1 && control_p1[2] == 1 && control_p1[3] == 1 && control_p1[4] == 1 && shots_p1 == turns_p1)
                check = 1;
            if (check == 1)
            {
                turns_p1++;
                PCShoot();
                lblHits.Text = hits_PC.ToString();
                lblHitsP1.Text = hits_p1.ToString();
                lblShots.Text = shots_PC.ToString();
                lblShotsP1.Text = shots_p1.ToString();
            }
            else
                MessageBox.Show("Place all your ships on field or play your turn.");
            if (hits_p1 == 14 ) 
                MessageBox.Show("Congratulations you have won!");
            if (hits_PC == 14)
                MessageBox.Show("You have lost. Try again!");
            if (hits_p1 == 14 || hits_PC == 14)
            {
                for (int i = 0; i < 100000000; i++) { }
                this.Close();
            }
                

        }

        int id,x=0,temp=1;
        int[] arr = new int[72];
        private void PCShoot()
        {
            int i, j,y=0;
            Random rnd = new Random();
            id= rnd.Next(1, 72);
            while (y < temp)
            {
                if (arr[y] == id)
                {
                    id = rnd.Next(1, 72);
                    arr[x] = id;
                    x++;
                }
                else
                {
                    arr[x] = id;
                    y++;
                }
            }
           
            temp++;
            if (id % 6 == 0)
            {
                i = 5;
                j = id / 6 - 1;
            }
            else
            {
                i = id % 6 - 1;
                j = id / 6;
            }
            i *= 38;
            j *= 38;
            shots_PC++;
            Squaredown sqd = new Squaredown(id, j, i);
            foreach (Squaredown squareP1ship in l_down_p1)
            {
                if (sqd.id == squareP1ship.id && squareP1ship.full == true)
                {
                    hits_PC++;
                    sqd.FillH(gdown);
                    l_down_p1.Where(w => w.id == id).ToList().ForEach(s => s.shot = true);
                    break;
                }
                else
                {
                    sqd.FillM(gdown);
                    l_down_p1.Where(w => w.id == id).ToList().ForEach(s => s.shot = true);
                }
            }
        }

        int[,] Field = new int[,] { { 11, 14, 17, 20, 26, 32, 44, 45, 46, 57, 60, 63, 66, 69 },
                                    { 1,2,3,11,17,20,23,26,29,45,46,47,68,69},
                                    { 14,16,17,20,26,32,35,41,45,47,51,62,63,64 },
                                    {8,9,10,11,27,28,30,32,36,38,44,64,65,66 },
                                    {6,7,12,13,15,18,19,21,25,27,47,53,61,67 },
                                    {11,12,15,21,27,30,36,42,43,48,49,57,58,59 },
                                    {8,9,10,12,18,31,32,35,41,47,56,57,58,59 },
                                    { 16,22,28,36,38,39,42,43,48,49,54,55,64,65} };
        private void LoadShips()
        {
            Random rnd = new Random();
            int row = rnd.Next(0, 7);
            int i = 0;
            foreach(Squareup squ in l_up_p1)
                if(i<14 && squ.id== Field[row,i])
                {
                    squ.full = true;
                    i++;
                }
        }
    }
}
