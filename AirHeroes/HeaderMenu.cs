using AirHeroes.Properties;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AirHeroes
{
    internal class HeaderMenu
    {
        private static PictureBox coinsCount = new PictureBox();
        private static PictureBox barrelCount = new PictureBox();
        private static PictureBox woodHeader = new PictureBox();
        private static Label coinsAm = new Label();
        private static Label barrelAm = new Label();
        public static PictureBox CoinsCount
        {
            get { return coinsCount; }
            set { coinsCount = value; }
        }
        public static PictureBox BarrelCount
        {
            get { return barrelCount; }
            set { barrelCount = value; }
        }
        public static PictureBox WoodHeader
        {
            get { return woodHeader; }
            set { woodHeader = value; }
        }
        public static Label CoinsAm
        {
            get { return coinsAm; }
            set
            {
                coinsAm = value;
            }
        }
        public static Label BarrelAm
        {
            get { return barrelAm; }
            set { barrelAm = value;}
        }
        public static void LoadWoodHeader(Control.ControlCollection Controls)
        {
            WoodHeader.ImageLocation = @"C:\Users\Ivaylo Kartev\Downloads\WoodHeader.png";
            WoodHeader.Location = new Point(0, 0);
            WoodHeader.Size = new Size(1900, 175);
            Controls.Add(WoodHeader);
        }
        public static void LoadCoins(Control.ControlCollection Controls, int coins) 
        {
            CoinsCount.Image = Resources.coin;
            CoinsCount.Location = new Point(275, 50);
            CoinsCount.Size = new Size(85, 90);
            CoinsCount.BringToFront();
            CoinsCount.Parent = WoodHeader;
            CoinsCount.BackgroundImage = Image.FromFile(@"C:\Users\Ivaylo Kartev\Downloads\WoodBack.png");
            Controls.Add(CoinsCount);
            CoinsAm.Text = coins.ToString();
            CoinsAm.Location = new Point(380, 60);
            CoinsAm.Size = new Size(200, 80);
            CoinsAm.ForeColor= Color.White;
            CoinsAm.TextAlign = ContentAlignment.MiddleRight;
            CoinsAm.Font = new Font("Arial", 45);
            CoinsAm.BringToFront();
            CoinsAm.BackgroundImage = Image.FromFile(@"C:\Users\Ivaylo Kartev\Downloads\WoodBack1.png");
            Controls.Add(CoinsAm);
        }
        public static void LoadBarrels(Control.ControlCollection Controls, int barrels)
        {
            BarrelCount.ImageLocation = @"C:\Users\Ivaylo Kartev\Downloads\Crude-Oil-Barrel-PNG-Pic.png";
            BarrelCount.Location = new Point(650, 50);
            BarrelCount.Size = new Size(85, 85);
            BarrelCount.BringToFront();
            BarrelCount.BackgroundImage = Image.FromFile(@"C:\Users\Ivaylo Kartev\Downloads\BarrelBacl.png");
            Controls.Add(BarrelCount);
            BarrelAm.Text = barrels.ToString();
            BarrelAm.Location = new Point(780, 60);
            BarrelAm.Size = new Size(200, 80);
            BarrelAm.ForeColor = Color.White;
            BarrelAm.TextAlign = ContentAlignment.MiddleRight;
            BarrelAm.Font = new Font("Arial", 45);
            BarrelAm.BringToFront();
            BarrelAm.BackgroundImage = Image.FromFile(@"C:\Users\Ivaylo Kartev\Downloads\WoodBack1.png");
            Controls.Add(BarrelAm);
        }
    }
}
