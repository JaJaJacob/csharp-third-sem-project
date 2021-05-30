using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using CarsLibrary;

namespace program_zaliczeniowy_forms
{
    public partial class Form1 : Form
    {
        PictureBox pictureBox_tmp = new PictureBox();
        List<string> _parts_list = new List<string>();       
        string _temporary_file_name;
        string _temporary_file_name_engine;
        Engine engineM;
        FrontBumper frontbumper1;
        RearBumper rearbumper1;
        SideSkirts sideskirt1;
        Spoiler spoiler1;
        Bonnet bonnet1;
        Alloys alloy1;
        Tire tire1;
        ConsoleColor color1 = ConsoleColor.White;
        Car car1;
        public Form1()
        {
            InitializeComponent();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox8.Hide();
            pictureBox9.Hide();
            label11.Text = "0";
        }

        public void AddFeatures()
        {
            _parts_list.Add("Varis");
            _parts_list.Add("Bensopra");
            _parts_list.Add("INGS");
            _parts_list.Add("Volk TE37");
            _parts_list.Add("Advan 10.0 MV");
            _parts_list.Add("BBS RS-GT");
            _parts_list.Add("HRE C100");
            _parts_list.Add("Michelin Pilot Sport 4S Cup");
            _parts_list.Add("ToyoTires PROXES R888R");
            _parts_list.Add("Hankook RS3");
        }
        public static Engine CreateEngine1()
        {
            Engine engine1 = new Engine1();
            return engine1;
        }
        public static Engine CreateEngine2()
        {
            Engine engine2 = new Engine2();
            return engine2;
        }
        public static Engine CreateEngine3()
        {
            Engine engine3 = new Engine3();
            return engine3;
        }
        public static Car CreateToyotaSupra(Engine engine)
        {
            Car car = new ToyotaSupra(engine);
            return car;
        }
        public static FrontBumper CreateFrontBumper()
        {
            FrontBumper frontbumper = new FrontBumper();
            return frontbumper;
        }
        public static RearBumper CreateRearBumper()
        {
            RearBumper rearbumper = new RearBumper();
            return rearbumper;
        }
        public static SideSkirts CreateSideSkirts()
        {
            SideSkirts sideskirts = new SideSkirts();
            return sideskirts;
        }
        public static Spoiler CreateSpoiler()
        {
            Spoiler spoiler = new Spoiler();
            return spoiler;
        }
        public static Bonnet CreateBonnet()
        {
            Bonnet bonnet = new Bonnet();
            return bonnet;
        }
        public static Alloys CreateAlloys()
        {
            Alloys alloys = new Alloys();
            return alloys;
        }
        public static Tire CreateTire()
        {
            Tire tire = new Tire();
            return tire;
        }
        private void button3_Click(object sender, EventArgs e) //zapisz projekt
        {
            try
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.InitialDirectory = @"C:\";
                saveFile.RestoreDirectory = true;
                saveFile.FileName = car1.Vehicle_Manufacturer_Name + car1.Vehicle_Model_Name + engineM.EngineName + ".txt";
                saveFile.DefaultExt = "txt";
                saveFile.Filter = "txt files (*.txt)|*.txt";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    File.Delete(saveFile.FileName);
                    using (StreamWriter _stream_writer = File.AppendText(saveFile.FileName))
                    {                        
                        string tmp;
                        tmp = car1.Vehicle_Manufacturer_Name + ";" + car1.Vehicle_Model_Name + ";" + engineM.EngineName + ";" + frontbumper1.FrontBumperName + ";" + rearbumper1.RearBumperName + ";" + sideskirt1.SideSkirtName + ";" + spoiler1.SpoilerName + ";" + bonnet1.BonnetName + ";" + alloy1.AlloyName + ";" + tire1.TireName + ";" + engineM.Horsepower + ";" + engineM.Is_Chip_Tuned;                        
                        _stream_writer.Write(tmp);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($" Błąd: {error.Message} \n Nie można zapisać projektu jeśli nie utworzyło się auta!");
            }
        }
        private void button1_Click(object sender, EventArgs e) //stworz projekt //nowy form - nie działa
        {
            panel2.Show();
        }
        private void button2_Click(object sender, EventArgs e) //otworz projekt
        {
            AddFeatures();
            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                
                int _count = 0;
                int _i = 3;
                string filename = openFile.FileName;
                string[] readfile = File.ReadAllText(filename).Split(";");               
                string lol = "";
                _temporary_file_name_engine = readfile[2];
                foreach (string s in readfile)
                {
                    lol = s;
                    _count++;
                    if (_count <= 2)
                    {
                        _temporary_file_name = _temporary_file_name + s;
                    }                 
                }               
                if (_temporary_file_name_engine == "B58B30")
                {
                    engineM = new Engine1();
                    engineM.Horsepower2 = Convert.ToInt32(readfile[10]);
                    engineM.Is_Chip_Tuned = Convert.ToBoolean(readfile[11]);
                }
                else if (_temporary_file_name_engine == "B48B20")
                {
                    engineM = new Engine2();
                    engineM.Horsepower2 = Convert.ToInt32(readfile[10]);
                    engineM.Is_Chip_Tuned = Convert.ToBoolean(readfile[11]);
                }
                else if (_temporary_file_name_engine == "2JZ-GTE")
                {
                    engineM = new Engine3();
                    engineM.Horsepower2 = Convert.ToInt32(readfile[10]);
                    engineM.Is_Chip_Tuned = Convert.ToBoolean(readfile[11]);
                }
                
                foreach (string s in _parts_list)
                {
                    if (readfile[3] == s)
                    { 
                        listBox1.SelectedItem = s;
                    }
                    if (readfile[4] == s)
                    {
                        listBox2.SelectedItem = s;
                    }
                    if (readfile[5] == s)
                    {
                        listBox4.SelectedItem = s;
                    }
                    if (readfile[6] == s)
                    {
                        listBox5.SelectedItem = s;
                    }
                    if (readfile[7] == s)
                    {
                        listBox6.SelectedItem = s;
                    }
                    if (readfile[8] == s)
                    {
                        listBox7.SelectedItem = s;
                    }
                    if (readfile[9] == s)
                    {
                        listBox8.SelectedItem = s;
                    }                 
                }
                if (_temporary_file_name == "ToyotaSupra")
                {
                    car1 = CreateToyotaSupra(engineM);
                    pictureBox1.Image = Bitmap.FromFile(@"Resources\toyotasupraSTOCK.png");
                    pictureBox_tmp = pictureBox1;
                }

                frontbumper1 = new FrontBumper(readfile[3], 1);
                rearbumper1 = new RearBumper(readfile[4], 1);
                sideskirt1 = new SideSkirts(readfile[5], 1);
                spoiler1 = new Spoiler(readfile[6], 1);
                bonnet1 = new Bonnet(readfile[7], 1);
                alloy1 = new Alloys(readfile[8], 1);
                tire1 = new Tire(readfile[9], 1);
                label11.Text = engineM.Horsepower.ToString();
                label12.Text = car1.Vehicle_Manufacturer_Name + " " + car1.Vehicle_Model_Name;
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) //frontbumper
        {
            ListBox listbox1 = new ListBox();
            Controls.Add(listBox1);

            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            string selectedItem = listBox1.Items[listBox1.SelectedIndex].ToString();

            foreach (object item in listBox1.Items)
            {
                sb.Append(item.ToString());
                sb.Append(" ");
            }
            if (selectedItem.ToString() == "Stock")
            {
                pictureBox2.Hide();
            }
            if (selectedItem.ToString() == "Varis")
            {
                pictureBox2.Show();
                FrontBumper frontbumper2 = new FrontBumper("Varis", 0.47m);
                frontbumper1 = frontbumper2;
                pictureBox2.Parent = pictureBox1;
                pictureBox2.Image = Bitmap.FromFile(@"Resources\VarisFB.png");
            }
            else if (selectedItem.ToString() == "INGS")
            {
                pictureBox2.Show();
                FrontBumper frontbumper2 = new FrontBumper("INGS", 0.45m);
                frontbumper1 = frontbumper2;
                pictureBox2.Parent = pictureBox1;
                pictureBox2.Image = Bitmap.FromFile(@"Resources\INGSFB.png");
            }

        }
        
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e) //rearbumper
        {
            ListBox listbox2 = new ListBox();
            Controls.Add(listBox2);

            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            string selectedItem = listBox2.Items[listBox2.SelectedIndex].ToString();

            foreach (object item in listBox2.Items)
            {
                sb.Append(item.ToString());
                sb.Append(" ");
            }
            if (selectedItem.ToString() == "Stock")
            {
                pictureBox4.Hide();
            }
            if (selectedItem.ToString() == "Varis")
            {
                pictureBox4.Show();
                pictureBox4.Parent = pictureBox1;
                RearBumper rearbumper2 = new RearBumper("Varis", 0.49m);
                rearbumper1 = rearbumper2;
                pictureBox4.Image = Bitmap.FromFile(@"Resources\VarisRB.png");
            }
            else if (selectedItem.ToString() == "INGS")
            {
                pictureBox4.Show();
                pictureBox4.Parent = pictureBox1;
                RearBumper rearbumper2 = new RearBumper("INGS", 0.47m);
                rearbumper1 = rearbumper2;
                pictureBox4.Image = Bitmap.FromFile(@"Resources\INGSRB.png");
            }
        }
       
        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Hide();
        } //zamknij okno wyboru projektow
        private void listBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {           
            ListBox listbox3 = new ListBox();
            Controls.Add(listBox3);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            string selectedItem = listBox3.Items[listBox3.SelectedIndex].ToString();
            foreach (object item in listBox3.Items)
            {
                sb.Append(item.ToString());
                sb.Append(" ");
            }
            if (selectedItem.ToString() == "Alfa Romeo 4C")
            {
                panel2.Hide();
            }
            else if (selectedItem.ToString() == "Toyota Supra mkIV")
            {
                panel3.Show();
                //panel3.BringToFront();
                Engine engine = engineM;
                Car car = CreateToyotaSupra(engine);
                frontbumper1 = CreateFrontBumper();
                rearbumper1 = CreateRearBumper();
                sideskirt1 = CreateSideSkirts();
                spoiler1 = CreateSpoiler();
                bonnet1 = CreateBonnet();
                alloy1 = CreateAlloys();
                tire1 = CreateTire();
                color1 = new ConsoleColor();
                car1 = car;
                //panel2.Hide();
                pictureBox1.Image = Bitmap.FromFile(@"Resources\toyotasupraSTOCK.png");
                pictureBox_tmp = pictureBox1;
                label12.Text = car1.Vehicle_Manufacturer_Name + " " + car1.Vehicle_Model_Name;
            }
            listBox3.Visible = false;
            panel2.Hide();
            
        } //gdy wybierze sie projekt
        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listbox4 = new ListBox();
            Controls.Add(listBox4);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            string selectedItem = listBox4.Items[listBox4.SelectedIndex].ToString();
            foreach (object item in listBox4.Items)
            {
                sb.Append(item.ToString());
                sb.Append(" ");
            }
            if (selectedItem.ToString() == "Stock")
            {
                pictureBox3.Hide();
            }
            if (selectedItem.ToString() == "Varis")
            {
                pictureBox3.Show();
                SideSkirts sideskirts = new SideSkirts("Varis", 0.49m);
                sideskirt1 = sideskirts;
                pictureBox3.Parent = pictureBox1;
                pictureBox3.Image = Bitmap.FromFile(@"Resources\VarisSD.png");
            }
            else if (selectedItem.ToString() == "INGS")
            {
                pictureBox3.Show();
                SideSkirts sideskirts = new SideSkirts("INGS", 0.47m);
                sideskirt1 = sideskirts;
                pictureBox3.Parent = pictureBox1;
                pictureBox3.Image = Bitmap.FromFile(@"Resources\INGSSD.png");
            }        
        }
        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listbox5 = new ListBox();
            Controls.Add(listBox5);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            string selectedItem = listBox5.Items[listBox5.SelectedIndex].ToString();
            foreach (object item in listBox5.Items)
            {
                sb.Append(item.ToString());
                sb.Append(" ");
            }
            if (selectedItem.ToString() == "Stock")
            {
                pictureBox5.Hide();
            }
            if (selectedItem.ToString() == "Varis")
            {
                pictureBox5.Show();
                pictureBox5.Parent = pictureBox1;
                Spoiler spoiler = new Spoiler("Varis", 70);
                spoiler1 = spoiler;
                pictureBox5.Image = Bitmap.FromFile(@"Resources\VarisSP.png");
            }
            else if (selectedItem.ToString() == "INGS")
            {
                pictureBox5.Show();
                pictureBox5.Parent = pictureBox1;
                Spoiler spoiler = new Spoiler("INGS", 90);
                spoiler1 = spoiler;
                pictureBox5.Image = Bitmap.FromFile(@"Resources\INGSSP.png");
            }
        }
        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listbox6 = new ListBox();
            Controls.Add(listBox6);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            string selectedItem = listBox6.Items[listBox6.SelectedIndex].ToString();
            foreach (object item in listBox6.Items)
            {
                sb.Append(item.ToString());
                sb.Append(" ");
            }
            if (selectedItem.ToString() == "Stock")
            {
                pictureBox6.Hide();
            }
            if (selectedItem.ToString() == "Varis")
            {
                pictureBox6.Show();
                pictureBox6.Parent = pictureBox1;
                Bonnet bonnet = new Bonnet("Varis", 0.44m);
                bonnet1 = bonnet;
                pictureBox6.Image = Bitmap.FromFile(@"Resources\VarisBN.png");
            }
            else if (selectedItem.ToString() == "INGS")
            {
                pictureBox6.Show();
                pictureBox6.Parent = pictureBox1;
                Bonnet bonnet = new Bonnet("INGS", 0.42m);
                bonnet1 = bonnet;
                pictureBox6.Image = Bitmap.FromFile(@"Resources\INGSBN.png");
            }
        }
        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listbox7 = new ListBox();
            Controls.Add(listBox7);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            string selectedItem = listBox7.Items[listBox7.SelectedIndex].ToString();
            foreach (object item in listBox7.Items)
            {
                sb.Append(item.ToString());
                sb.Append(" ");
            }
            if (selectedItem.ToString() == "Stock")
            {
                pictureBox7.Hide();
                pictureBox8.Hide();
            }
            if (selectedItem.ToString() == "Volk TE37")
            {
                pictureBox7.Show();
                pictureBox7.Parent = pictureBox1;
                pictureBox8.Show();
                pictureBox8.Parent = pictureBox1;
                pictureBox7.BringToFront();
                pictureBox8.BringToFront();
                Alloys alloy = new Alloys("Volk TE37", 12m);
                alloy1 = alloy;
                pictureBox7.Image = Bitmap.FromFile(@"Resources\VolkTE371.png");
                pictureBox8.Image = Bitmap.FromFile(@"Resources\VolkTE372.png");
            }
            else if (selectedItem.ToString() == "Advan 10.0 MV")
            {
                pictureBox7.Show();
                pictureBox7.Parent = pictureBox1;
                pictureBox8.Show();
                pictureBox8.Parent = pictureBox1;
                pictureBox7.BringToFront();
                pictureBox8.BringToFront();
                Alloys alloy = new Alloys("Advan 10.0 MV", 13m);
                alloy1 = alloy;
                pictureBox7.Image = Bitmap.FromFile(@"Resources\ADVAN10M1.png");
                pictureBox8.Image = Bitmap.FromFile(@"Resources\ADVAN10M2.png");
            }
            else if (selectedItem.ToString() == "BBS RS-GT")
            {
                pictureBox7.Show();
                pictureBox7.Parent = pictureBox1;
                pictureBox8.Show();
                pictureBox8.Parent = pictureBox1;
                pictureBox7.BringToFront();
                pictureBox8.BringToFront();
                Alloys alloy = new Alloys("BBS RS-GT", 10m);
                alloy1 = alloy;
                pictureBox7.Image = Bitmap.FromFile(@"Resources\BBRSGT1.png");
                pictureBox8.Image = Bitmap.FromFile(@"Resources\BBRSGT2.png");
            }
            else if (selectedItem.ToString() == "HRE C100")
            {
                pictureBox7.Show();
                pictureBox7.Parent = pictureBox1;
                pictureBox8.Show();
                pictureBox8.Parent = pictureBox1;
                pictureBox7.BringToFront();
                pictureBox8.BringToFront();
                Alloys alloy = new Alloys("HRE C100", 10m);
                alloy1 = alloy;
                pictureBox7.Image = Bitmap.FromFile(@"Resources\C1001.png");
                pictureBox8.Image = Bitmap.FromFile(@"Resources\C1002.png");
            }
        } //felgi
        private void listBox8_SelectedIndexChanged(object sender, EventArgs e) //opony
        {
            ListBox listbox8 = new ListBox();
            Controls.Add(listBox8);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            string selectedItem = listBox8.Items[listBox8.SelectedIndex].ToString();
            foreach (object item in listBox8.Items)
            {
                sb.Append(item.ToString());
                sb.Append(" ");
            }
            if (selectedItem.ToString() == "Stock")
            {
            }
            if (selectedItem.ToString() == "Michelin Pilot Sport 4S Cup")
            {
                Tire tire = new Tire("Michelin Pilot Sport 4S Cup", 10);
                tire1 = tire;
            }
            else if (selectedItem.ToString() == "ToyoTires PROXES R888R")
            {
                Tire tire = new Tire("ToyoTires PROXES R888R", 10);
                tire1 = tire;
            }
            else if (selectedItem.ToString() == "Hankook RS3")
            {
                Tire tire = new Tire("Hankook RS3", 10);
                tire1 = tire;
            }
        }
        private void listBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listbox9 = new ListBox();
            Controls.Add(listBox9);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            string selectedItem = listBox9.Items[listBox9.SelectedIndex].ToString();
            foreach (object item in listBox9.Items)
            {
                sb.Append(item.ToString());
                sb.Append(" ");
            }
            
            if (selectedItem.ToString() == "B58B30 3.0")
            {

                Engine engine = new Engine1();
                engineM = engine;
                panel3.Hide();
            }
            else if (selectedItem.ToString() == "B48B20 2.0")
            {
                Engine engine = new Engine2();
                engineM = engine;
                panel3.Hide();
            }
            else if (selectedItem.ToString() == "2JZ-GTE")
            {
                Engine engine = new Engine3();
                engineM = engine;
                panel3.Hide();
            }
            else
            {
                Engine engine = new Engine1();
                engineM = engine;
                panel3.Hide();
            }

            label11.Text = engineM.Horsepower.ToString();
            panel3.Hide();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            panel4.Show();
        }
        private void listBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChipTuning _chip_tuning = new ChipTuning();
            ListBox listbox10 = new ListBox();
            Controls.Add(listBox10);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            string selectedItem = listBox10.Items[listBox10.SelectedIndex].ToString();
            foreach (object item in listBox10.Items)
            {
                sb.Append(item.ToString());
                sb.Append(" ");
            }
            if (selectedItem.ToString() == "+30 bhp")
            {
                if (engineM.Is_Chip_Tuned && engineM != null)
                {
                    panel4.Hide();
                    MessageBox.Show("Silnik już porobiony");
                }
                else
                {
                    _chip_tuning.ChipTunning_Stage1(engineM);
                }
            }
            else if (selectedItem.ToString() == "+70 bhp")
            {
                if (engineM.Is_Chip_Tuned && engineM != null)
                {
                    panel4.Hide();
                    MessageBox.Show("Silnik już porobiony");
                }
                else
                {
                    _chip_tuning.ChipTunning_Stage2(engineM);
                }
                
            }
            else if (selectedItem.ToString() == "+140 bhp")
            {
                if (engineM.Is_Chip_Tuned && engineM != null)
                {
                    panel4.Hide();
                    MessageBox.Show("Silnik już porobiony");
                }
                else
                {
                    _chip_tuning.ChipTunning_Stage3(engineM); ;
                }               
            }
            else
            {
                MessageBox.Show("Anulowano");
            }

            label11.Text = engineM.Horsepower.ToString();
            listBox10.Visible = false;
            panel4.Hide();
        }
        private void button7_Click(object sender, EventArgs e)
        { }
        private void button7_Click_1(object sender, EventArgs e)
        {
            panel4.Hide();
            listBox10.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = Bitmap.FromFile(@"Resources\toyotasupraSEJP.gif");
            pictureBox9.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pictureBox9.Hide();
        }
    }
}
