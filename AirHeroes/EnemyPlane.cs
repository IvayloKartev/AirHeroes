using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AirHeroes
{
    public class EnemyPlane
    {
        private List<EnemyPlane> _enemyPlanes;
        public List<EnemyPlane> EnemyPlanes
        {
            get { return _enemyPlanes; }
            set { _enemyPlanes = value; }
        }
        private int health = 100;
        public int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }
        private Image plane = Image.FromFile(@"C:\Users\Ivaylo Kartev\Downloads\Planes\SmallPlaneEnemy.png");
        public Image Plane
        {
            get { return this.plane; }
            set { this.plane = value; }
        }
        private PictureBox aircraft;
        public PictureBox Aircraft
        {
            get { return this.aircraft; }
            set { this.aircraft = value; }
        }


    }
}
