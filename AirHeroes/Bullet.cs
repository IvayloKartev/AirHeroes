using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace AirHeroes
{
    public class Bullet
    {
        public string direction; // creating a public string called direction
        public int speed = 1000; // creating a integer called speed and assigning a value of 20
        public PictureBox Bullet1 = new PictureBox(); // create a picture box 
        System.Windows.Forms.Timer tm = new System.Windows.Forms.Timer(); // create a new timer called tm. 
        public int bulletLeft; // create a new public integer
        public int bulletTop;
        public void mkBullet(Form form)
        {
            // this function will add the bullet to the game play
            // it is required to be called from the main class
            Bullet1.BackColor = System.Drawing.Color.Black; // set the colour white for the bullet
            Bullet1.Size = new Size(5, 5); // set the size to the bullet to 5 pixel by 5 pixel
            Bullet1.Tag = "bullet"; // set the tag to bullet
            Bullet1.Left = bulletLeft; // set bullet left 
            Bullet1.Top = bulletTop; // set bullet right
            Bullet1.BringToFront(); // bring the bullet to front of other objects
            form.Controls.Add(Bullet1); // add the bullet to the screen
            tm.Interval = speed; // set the timer interval to speed
            tm.Tick += new EventHandler(tm_Tick); // assignment the timer with an event
            tm.Start(); // start the timer
        }
        public void tm_Tick(object sender, EventArgs e)
        {
            // if direction equals to left
            if (direction == "left")
            {
                Bullet1.Left -= speed; // move bullet towards the left of the screen
            }
            // if direction equals right
            if (direction == "right")
            {
                Bullet1.Left += speed; // move bullet towards the right of the screen
            }
            // if direction is up
            if (direction == "up")
            {
                Bullet1.Top -= 50; // move the bullet towards top of the screen
            }
            // if direction is down
            if (direction == "down")
            {
                Bullet1.Top += speed; // move the bullet bottom of the screen
            }
        }
    }
}
