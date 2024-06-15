using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirHeroes
{
    public class LevelButton
    {
        private Button button1 = new Button();
        public Button Button
        {
            get { return this.button1; }
            set { this.button1 = value; }
        }
        private double score;
        public double Score
        {
            get { return this.score; }
            set { this.score = value; }
        }
        private bool locked = false;
        public bool Locked
        {
            get { return this.locked; }
            set { this.locked = value; }
        }
        private short levelNumber;
        public short LevelNumber
        {
            get { return this.levelNumber; }
            set { this.levelNumber = value; }
        }
    }
}
