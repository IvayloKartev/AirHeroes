using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Drawing;
namespace AirHeroes
{
    public class Player
    {
        private string image = @"C:\Users\Ivaylo Kartev\Downloads\Planes\PLayerPlane1.png";
        public string Image
        {
            get { return this.image; }
            set { this.image = value; }
        }
        private int xPos;
        public int XPos
        {
            get { return this.xPos; }
            set { this.xPos = value; }
        }
        private int yPos;
        public int YPos
        {
            get { return this.yPos; }
            set { this.yPos = value; }
        }
        private PictureBox character;
        public PictureBox Character
        {
            get { return this.character; }
            set { this.character = value; }
        }
        private PictureBox character1;
        public PictureBox Character1
        {
            get { return this.character1; }
            set { this.character1 = value; }
        }
        public void InitializePlayer(System.Windows.Forms.Control.ControlCollection Controls)
        {
            Bitmap bitmap0 = new Bitmap(System.Drawing.Image.FromFile(image));
            var bt = MakeTransparent(bitmap0, Color.Blue, 5);
            Character = new PictureBox();
            Character.Location = new Point(XPos, YPos);
            Character.Size = new Size(122, 104);
            Character.TabIndex = 0;
            Character.ImageLocation = image;
            Image portrait = System.Drawing.Image.FromFile(Image);
            Character.Image = portrait;
            Character.BackColor = Color.Transparent;
            Character.BackgroundImageLayout = ImageLayout.Stretch;
            Character.Load();
            Controls.Add(Character);
            Character.BringToFront();
        }
        private Bitmap MakeTransparent(Bitmap bitmap, Color color, int tolerance)
        {
            Bitmap transparentImage = new Bitmap(bitmap, 30, 48);
            for (int i = transparentImage.Size.Width - 1; i >= 0; i--)
            {
                for (int j = transparentImage.Size.Height - 1; j >= 0; j--)
                {
                    var currentColor = transparentImage.GetPixel(i, j);
                    if (Math.Abs(color.R - currentColor.R) < tolerance &&
                      Math.Abs(color.G - currentColor.G) < tolerance &&
                      Math.Abs(color.B - currentColor.B) < tolerance)
                        transparentImage.SetPixel(i, j, color);
                }
            }

            transparentImage.MakeTransparent(color);
            return transparentImage;
        }
    }
}
