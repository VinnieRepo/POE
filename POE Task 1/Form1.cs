using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace POE_Task_1
{
 
    public partial class Form1 : Form
    {   



        public Form1()
        {
            InitializeComponent();
        }



        


        private void Form1_Load(object sender, EventArgs e)
        {



        }

        GameEngine Start = new GameEngine();

        public void showweapons()
        {
            Weapon1Label.Text = Start.Gameshop.displayWeapon(0);
            Weapon2Label.Text = Start.Gameshop.displayWeapon(1);
            WeaponLabel3.Text = Start.Gameshop.displayWeapon(2);
        }




















        

        private void StartButton_Click(object sender, EventArgs e)
        {
            MapHolderBox.Text = Start.Gamemap.ToString();
            CharacterLabel.Text = Start.Gamemap.Playerguy.ToString();
            EnemyLabel.Text = Start.Gamemap.enemyguy.ToString();
            showweapons();
            if (Start.Gamemap.Playerguy.goldpurse < Start.Gameshop.weaponlist[0].Cost)
            {
                Buy1.Enabled = false;
            }

            if (Start.Gamemap.Playerguy.goldpurse < Start.Gameshop.weaponlist[1].Cost)
            {
                Buy2.Enabled = false;
            }

            if (Start.Gamemap.Playerguy.goldpurse < Start.Gameshop.weaponlist[2].Cost)
            {
                Buy3.Enabled = false;
            }
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            Start.CharacterMove(tile.Movement.Up);
            Start.Enemymove();
            MapLabel.Text = Start.Gamemap.ToString();

        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            Start.CharacterMove(tile.Movement.Right);
            Start.Enemymove();
            MapLabel.Text = Start.Gamemap.ToString();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            Start.CharacterMove(tile.Movement.Down);
            Start.Enemymove();
            MapLabel.Text = Start.Gamemap.ToString();
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            Start.CharacterMove(tile.Movement.Left);
            Start.Enemymove();
            MapLabel.Text = Start.Gamemap.ToString();
        }

        // saveSystem try, it keeps snagging because it cant save a random rumber.
        public static class saveSystem
        {
            public static void SaveEverything(GameEngine Savings)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                string path = @"C:\Users\rampa\OneDrive\Documents" + "/Saves.sav";
                FileStream stream = new FileStream(path,FileMode.Create);

               GameEngine data = new GameEngine();

                formatter.Serialize(stream, data);
                stream.Close();

                
                
            }

            public static GameEngine LoadData()
            {
                string path = @"C:\Users\rampa\OneDrive\Documents" + "/Saves.sav";
                if (File.Exists(path))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    FileStream stream = new FileStream(path, FileMode.Open);

                    GameEngine savings = formatter.Deserialize(stream) as GameEngine;
                    stream.Close();
                    return savings;

                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("No Save file detected in"+path);
                    return null;
                }
            }

        }
        private void SaveButton_Click(object sender, EventArgs e)
        {    
            saveSystem.SaveEverything(Start);
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
           GameEngine data = saveSystem.LoadData();

            Start.Gamemap.Mapcell = data.Gamemap.Mapcell;

            MapHolderBox.Text = Start.Gamemap.ToString();
            CharacterLabel.Text = Start.Gamemap.Playerguy.ToString();
            EnemyLabel.Text = Start.Gamemap.enemyguy.ToString();


        }

        private void Buy1_Click(object sender, EventArgs e)
        {
            Start.Gamemap.Playerguy.weaponequip = Start.Gameshop.weaponlist[1];
            Random r = new Random(0);
            int weaponType = r.Next(0, 2);

            if (weaponType == 0)
            {
                int meleeType = r.Next(0, 2);

                Start.Gameshop.weaponlist[0] = new MeleeWeapon(0, 0, tile.Tiletypes.MeleeWeapon, meleeType);
            }
            else
            {
                int rangeType = r.Next(0, 2);
                Start.Gameshop.weaponlist[0] = new RangedWeapons(0, 0, tile.Tiletypes.RangedWeapon, rangeType);
            }

            if (Start.Gamemap.Playerguy.goldpurse < Start.Gameshop.weaponlist[0].Cost)
            {
                Buy1.Enabled = false;
            }

            showweapons();

        }

        private void Buy2_Click(object sender, EventArgs e)
        {
            Start.Gamemap.Playerguy.weaponequip = Start.Gameshop.weaponlist[1];
            Random r = new Random(0);
            int weaponType = r.Next(0, 2);
            if (weaponType == 0)
            {
                int meleeType = r.Next(0, 2);

                Start.Gameshop.weaponlist[1] = new MeleeWeapon(0, 0, tile.Tiletypes.MeleeWeapon, meleeType);
            }
            else
            {
                int rangeType = r.Next(0, 2);
                Start.Gameshop.weaponlist[1] = new RangedWeapons(0, 0, tile.Tiletypes.RangedWeapon, rangeType);
            }

            if (Start.Gamemap.Playerguy.goldpurse < Start.Gameshop.weaponlist[1].Cost)
            {
                Buy2.Enabled = false;
            }
            
            showweapons();
        }

        private void Buy3_Click(object sender, EventArgs e)
        {
            Start.Gamemap.Playerguy.weaponequip = Start.Gameshop.weaponlist[1];
            Random r = new Random(0);
            int weaponType = r.Next(0, 2);
            if (weaponType == 0)
            {
                int meleeType = r.Next(0, 2);

                Start.Gameshop.weaponlist[2] = new MeleeWeapon(0, 0, tile.Tiletypes.MeleeWeapon, meleeType);
            }
            else
            {
                int rangeType = r.Next(0, 2);
                Start.Gameshop.weaponlist[2] = new RangedWeapons(0, 0, tile.Tiletypes.RangedWeapon, rangeType);
            }

            if (Start.Gamemap.Playerguy.goldpurse < Start.Gameshop.weaponlist[0].Cost)
            {
                Buy3.Enabled = false;
            }

            showweapons();
        }
    }
}
