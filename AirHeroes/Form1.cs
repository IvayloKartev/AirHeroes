using Microsoft.VisualBasic.Devices;
using System.Drawing;
using System.Drawing.Text;
using System.Numerics; 
namespace AirHeroes
{
    public partial class Form1 : Form
    {
        private Player playerPlane = new Player();
        public Player PlayerPLane
        {
            get { return playerPlane; }
            set { this.playerPlane = value; }
        }
        public bool goLeft;
        public bool goRight;
        private List<LevelButton> buttons = new List<LevelButton>();
        public Button archiveMagazine;
        public List<LevelButton> Buttons
        {
            get { return this.buttons; }
            set { this.buttons = value; }
        }
        private LevelButton level1 = new LevelButton();
        public LevelButton Level1
        {
            get { return this.level1; }
            set { this.level1 = value; }
        }
        private LevelButton level2 = new LevelButton();
        public LevelButton Level2
        {
            get { return this.level2; }
            set { this.level2 = value; }
        }
        private LevelButton level3 = new LevelButton();
        public LevelButton Level3
        {
            get { return this.level3; }
            set { this.level3 = value; }
        }
        private LevelButton level4 = new LevelButton();
        public LevelButton Level4
        {
            get { return this.level4; }
            set { this.level4 = value; }
        }
        private LevelButton level5 = new LevelButton();
        public LevelButton Level5
        {
            get { return this.level5; }
            set { this.level5 = value; }
        }
        private LevelButton level6 = new LevelButton();
        public LevelButton Level6
        {
            get { return this.level6; }
            set { this.level6 = value; }
        }
        private LevelButton level7 = new LevelButton();
        public LevelButton Level7
        {
            get { return this.level7; }
            set { this.level7 = value; }
        }
        private LevelButton level8 = new LevelButton();
        public LevelButton Level8
        {
            get { return this.level8; }
            set { this.level8 = value; }
        }
        private LevelButton level9 = new LevelButton();
        public LevelButton Level9
        {
            get { return this.level9; }
            set { this.level9 = value; }
        }
        private LevelButton level10 = new LevelButton();
        public LevelButton Level10
        {
            get { return this.level10; }
            set { this.level10 = value; }
        }

        private LevelButton currLevel = new LevelButton();
        public LevelButton CurrLevel
        {
            get { return this.currLevel; }
            set { this.currLevel = value; }
        }
        private int coins=0;
        public int Coins
        {
            get { return this.coins; }
            set { this.coins = value; }
        }
        private Label coinsT = new Label();
        public Label CoinsT
        {
            get { return this.coinsT; }
            set { this.coinsT = value; }
        }
        public int curr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);
            this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.KeyPreview = true;
            PlayerPLane.XPos = 800;
            PlayerPLane.YPos = 800;
            DoubleBuffered= true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameTitle.Visible = false;
            StartButton.Visible = false;
            InitializeHome("sky");
            HeaderMenu.LoadBarrels(Controls, oilBarrels);
            HeaderMenu.LoadCoins(Controls, Coins);
            HeaderMenu.LoadWoodHeader(Controls);
        }
        private void InitializeHome(string world)
        {
            archiveMagazine = new Button();
            archiveMagazine.Location = new Point(30, 40);
            archiveMagazine.Size = new Size(133, 100);
            archiveMagazine.BackColor = Color.Transparent;
            archiveMagazine.Image = Image.FromFile(@"C:\Users\Ivaylo Kartev\Downloads\Planes\magazine.png");
            Controls.Add(archiveMagazine);
            int temp6 = 100;
            for (int i = 1; i <= 5; i++)
            {
                LevelButton level = new LevelButton();
                level.Button.Location = new Point(300 * (i - 1) + 50, 275);
                level.Button.Size = new Size(280, 280);
                level.Button.Text = i.ToString();
                level.Button.Font = new Font("MS Gothic", 100);
                Level1.Locked = true;

                Buttons.Add(level);
                if (i == 1)
                {
                    Level1.Button = level.Button;
                    Level1.Button.Click += new EventHandler(Level1_Click);
                    
                }
                if(i==2)
                {
                    Level2.Button = level.Button;
                    Level2.Button.Click += new EventHandler(Level2_Click);
                    if (!Level2.Locked) Level2.Button.Image = Image.FromFile(@"C:\Users\Ivaylo Kartev\Downloads\Planes\R2.png");
                    else { Level2.Button.Image = null; Level2.Button.Update(); }
                }
                if (i == 3)
                {
                    Level3.Button = level.Button;
                    Level3.Button.Click += new EventHandler(Level3_Click);
                    if (!Level3.Locked) Level3.Button.Image = Image.FromFile(@"C:\Users\Ivaylo Kartev\Downloads\Planes\R2.png");
                    else Level3.Button.Image = null;
                }
                if (i == 4)
                {
                    Level4.Button = level.Button;
                    Level4.Button.Click += new EventHandler(Level4_Click);
                    if (!Level4.Locked) Level4.Button.Image = Image.FromFile(@"C:\Users\Ivaylo Kartev\Downloads\Planes\R2.png");
                    else Level4.Button.Image = null;
                }
                if (i == 5)
                {
                    Level5.Button = level.Button;
                    Level5.Button.Click += new EventHandler(Level5_Click);
                    if (!Level5.Locked) Level5.Button.Image = Image.FromFile(@"C:\Users\Ivaylo Kartev\Downloads\Planes\R2.png");
                    else Level5.Button.Image = null;
                }
                Controls.Add(level.Button);
            }
            for (int i = 6; i <= 10; i++)
            {
                LevelButton level = new LevelButton();
                level.Button.Location = new Point(300 * (i - 6) + 50, 575);
                level.Button.Size = new Size(280, 280);
                level.Button.Text = i.ToString();
                level.Button.Font = new Font("MS Gothic", 100);
                if (i != 1) level.Locked = true;
                Buttons.Add(level);
                if (i == 6)
                {
                    Level6.Button = level.Button;
                    Level6.Button.Click += new EventHandler(Level6_Click);
                    if (!Level6.Locked) Level6.Button.Image = Image.FromFile(@"C:\Users\Ivaylo Kartev\Downloads\Planes\R2.png");
                    else Level6.Button.Image = null;
                }
                if (i == 7)
                {
                    Level7.Button = level.Button;
                    Level7.Button.Click += new EventHandler(Level7_Click);
                    if (!Level7.Locked) Level7.Button.Image = Image.FromFile(@"C:\Users\Ivaylo Kartev\Downloads\Planes\R2.png");
                    else Level7.Button.Image = null;
                }
                if (i == 8)
                {
                    Level8.Button = level.Button;
                    Level8.Button.Click += new EventHandler(Level8_Click);
                    if (!Level8.Locked) Level8.Button.Image = Image.FromFile(@"C:\Users\Ivaylo Kartev\Downloads\Planes\R2.png");
                    else Level8.Button.Image = null;
                }
                if (i == 9)
                {
                    Level9.Button = level.Button;
                    Level9.Button.Click += new EventHandler(Level9_Click);
                    if (!Level9.Locked) Level9.Button.Image = Image.FromFile(@"C:\Users\Ivaylo Kartev\Downloads\Planes\R2.png");
                    else Level9.Button.Image = null;
                }
                if (i == 10)
                {
                    Level10.Button = level.Button;
                    Level10.Button.Click += new EventHandler(Level4_Click);
                    if (!Level10.Locked) Level10.Button.Image = Image.FromFile(@"C:\Users\Ivaylo Kartev\Downloads\Planes\R2.png");
                    else Level10.Button.Image = null;
                }
                Controls.Add(level.Button);
            }
            CoinsT.Location = new Point(600, 30);
            CoinsT.Size = new Size(350, 50);
            CoinsT.Text = "Coins: " + Coins.ToString();
            CoinsT.Font = new Font("MS Gothic", 30);
            CoinsT.BackColor = Color.Transparent;
            //Controls.Add(CoinsT);
        }
        public bool allowOil = false;
        public int oilBarrels = 0;

        bool deployedPlayer = false;
        private void Level1_Click(object sender, EventArgs e)
        {
            StartLevel();
            curr = 1;
            CurrLevel.LevelNumber = Level1.LevelNumber;
            CurrLevel.Button = Level1.Button;
            PlayerPLane.XPos = 800;
            PlayerPLane.YPos = 800;
            PlayerPLane.InitializePlayer(Controls);
            DropPlayer();
        }
        private void Level2_Click(object sender, EventArgs e)
        {
            if (Level2.Locked)
            {
                StartLevel();
                curr = 2;
                CurrLevel = Level2;
                CurrLevel.LevelNumber = Level2.LevelNumber;
                CurrLevel.Button = Level2.Button;
                PlayerPLane.XPos = 800;
                PlayerPLane.YPos = 800;
                PlayerPLane.InitializePlayer(Controls);
                DropPlayer();
            }
        }
        private void Level3_Click(object sender, EventArgs e)
        {
            if (Level3.Locked)
            {
                StartLevel();
                curr = 3;
                CurrLevel = Level3;
                CurrLevel.LevelNumber = Level3.LevelNumber;
                CurrLevel.Button = Level3.Button;
                PlayerPLane.XPos = 800;
                PlayerPLane.YPos = 800;
                PlayerPLane.InitializePlayer(Controls);
                DropPlayer();
            }
        }
        private void Level4_Click(object sender, EventArgs e)
        {
            if (Level4.Locked)
            {
                StartLevel();
                curr = 4;
                CurrLevel = Level3;
                CurrLevel.LevelNumber = Level3.LevelNumber;
                CurrLevel.Button = Level3.Button;
                PlayerPLane.XPos = 800;
                PlayerPLane.YPos = 800;
                PlayerPLane.InitializePlayer(Controls);
                DropPlayer();
            }
        }
        private void Level5_Click(object sender, EventArgs e)
        {
            if (Level5.Locked)
            {
                StartLevel();
                curr = 5;
                CurrLevel = Level5;
                CurrLevel.LevelNumber = Level5.LevelNumber;
                CurrLevel.Button = Level5.Button;
                PlayerPLane.XPos = 800;
                PlayerPLane.YPos = 800;
                PlayerPLane.InitializePlayer(Controls);
                DropPlayer();
            }
        }
        private void Level6_Click(object sender, EventArgs e)
        {
            if (Level6.Locked)
            {
                StartLevel();
                curr = 6;
                CurrLevel = Level6;
                CurrLevel.LevelNumber = Level6.LevelNumber;
                CurrLevel.Button = Level6.Button;
                PlayerPLane.XPos = 800;
                PlayerPLane.YPos = 800;
                PlayerPLane.InitializePlayer(Controls);
                DropPlayer();
            }
        }
        private void Level7_Click(object sender, EventArgs e)
        {
            if (Level7.Locked)
            {
                StartLevel();
                curr = 7;
                CurrLevel = Level7;
                CurrLevel.LevelNumber = Level7.LevelNumber;
                CurrLevel.Button = Level7.Button;
                PlayerPLane.XPos = 800;
                PlayerPLane.YPos = 800;
                PlayerPLane.InitializePlayer(Controls);
                DropPlayer();
            }
        }
        private void Level8_Click(object sender, EventArgs e)
        {
            if (Level8.Locked)
            {
                StartLevel();
                curr = 8;
                CurrLevel = Level8;
                CurrLevel.LevelNumber = Level8.LevelNumber;
                CurrLevel.Button = Level8.Button;
                PlayerPLane.XPos = 800;
                PlayerPLane.YPos = 800;
                PlayerPLane.InitializePlayer(Controls);
                DropPlayer();
            }
        }
        private void Level9_Click(object sender, EventArgs e)
        {
            if (Level9.Locked)
            {
                StartLevel();
                curr = 9;
                CurrLevel = Level9;
                CurrLevel.LevelNumber = Level9.LevelNumber;
                CurrLevel.Button = Level9.Button;
                PlayerPLane.XPos = 800;
                PlayerPLane.YPos = 800;
                PlayerPLane.InitializePlayer(Controls);
                DropPlayer();
            }
        }
        private void Level10_Click(object sender, EventArgs e)
        {
            if (Level10.Locked)
            {
                StartLevel();
                curr = 10;
                CurrLevel = Level10;
                CurrLevel.LevelNumber = Level10.LevelNumber;
                CurrLevel.Button = Level10.Button;
                PlayerPLane.XPos = 800;
                PlayerPLane.YPos = 800;
                PlayerPLane.InitializePlayer(Controls);
                DropPlayer();
            }
        }
        private void DropPlayer()
        {
            deployedPlayer = true;
            PlayerPLane.XPos = 800;
            PlayerPLane.YPos = 800;
            PlayerPLane.Character.Visible = true;
            PlayerPLane.Character.BringToFront();
            //Player.Character.Parent = this.Tile;
            //Player.Character.BackgroundImage = Image.FromFile(@"C:\Users\Ivaylo Kartev\Downloads\grassTile.png");
        }
        public int gameTime=0;
        public bool startGame = false;
        private void StartLevel()
        {
            foreach (var control in Buttons)
            {
                control.Button.Visible = false;
            }
            startGame = true;
        }
        public Button Ok = new Button();
        public Panel screen = new Panel();
        private void ShowEndScreen()
        {
            if(win)
            {
                screen.Location = new Point(600, 300);
                screen.Size = new Size(600, 600);
                screen.BackColor = Color.YellowGreen;
                Controls.Add(screen);
                PictureBox youWin= new PictureBox();
                youWin.Parent = screen;
                youWin.Size = new Size(300, 194);
                youWin.Location = new Point(100, 100);
                youWin.ImageLocation = @"C:\Users\Ivaylo Kartev\Downloads\Planes\winscreen.png";
                youWin.Load();
                screen.Controls.Add(youWin);
                Ok.Parent = screen;
                Ok.Location = new Point(300, 400);
                Ok.Size = new Size(100, 50);
                Ok.Text = "OK";
                Ok.Font = new Font("MS Gothic", 30);
                Ok.Click += new EventHandler(Ok_Clic);
            }
            else
            {
                continue1 = true;
            }
        }
        bool continue1 = false;
        private void Ok_Clic(object sender, EventArgs e)
        {
            continue1 = true;
        }
        private async void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.A)
            {
                PlayerPLane.Character.Left -= 200;
                PlayerPLane.XPos -= 200;
            }
            if (e.KeyCode == Keys.D)
            {
                PlayerPLane.Character.Left += 200;
                PlayerPLane.XPos += 200;
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                goRight = false;
            }
        }
        public bool endGame = false;
        public List<EnemyPlane> spawner = new List<EnemyPlane>();
        private async void FinishGame()
        {
            this.Controls.Remove(PlayerPLane.Character);
            foreach(var bullet in bullets)
            {
                Controls.Remove(bullet.Bullet1);
            }
            foreach(var plane in spawner)
            {
                Controls.Remove(plane.Aircraft);
            }
            if (win)
            {
                if (curr == 1) Level2.Locked = true;
                else if (curr == 2) Level3.Locked = true;
                else if (curr == 3) Level4.Locked = true;
                else if (curr == 4) Level5.Locked = true;
                else if (curr == 5) Level6.Locked = true;
                else if (curr == 6) Level7.Locked = true;
                else if (curr == 7) Level8.Locked = true;
                else if (curr == 8) Level9.Locked = true;
                else if (curr == 9) Level10.Locked = true;
            }
            bullets.Clear();
            spawner.Clear();
            deployedPlayer = false;
            endGame = false;
            if(curr==2)
            {
                oilBarrels += 5;
            }
            ShowEndScreen();
            while (!continue1) await Task.Delay(100);
            screen.Visible = false;
            Controls.Remove(screen);
            InitializeHome("sky");
        }
        public bool win = true;
        private async void timer1_Tick(object sender, EventArgs e)
        {
            HeaderMenu.CoinsAm.Text=Coins.ToString();
            HeaderMenu.BarrelAm.Text=oilBarrels.ToString();
            Random shootChance = new Random();
            if(deployedPlayer && gameTime%2==0) Shoot("up");
            if (startGame) gameTime = gameTime + 1;
            Random spawnChance = new Random();
            if(endGame && startGame)
            {
                gameTime = 0;
                startGame = false;
                FinishGame();
            }
            if(gameTime < 60 && gameTime > 0)
            {
               var a = 10;
               if(curr==1) a=spawnChance.Next(0,6);
               else if(curr==2) a=spawnChance.Next(0,5);
               else if (curr==3) a =spawnChance.Next(0,4);
               else if (curr==4) a=spawnChance.Next(0,2);
               else if (curr==5) a=spawnChance.Next(0,1);
               if(a==0) DeployTroops(spawner);
            }
            if (gameTime < 120 && gameTime > 60)
            {
                int a = 10;
                if(curr==1) a= spawnChance.Next(0,6);
                else if(curr==2) a=spawnChance.Next(0,4);
                else if(curr==3) a=spawnChance.Next(0,3);
                else if (curr==4) a = spawnChance.Next(0,1);
                else if (curr==5) a= 0;
                if (a == 0) DeployTroops(spawner);
            }
            if (gameTime >= 120)
            {
                endGame = true;
                win = true;
            }
            foreach (var plane in spawner)
            {
                plane.Aircraft.Top += 50;
                if(plane.Aircraft.Top == 800) win = false;
            }
            if(!win)
            {
                gameTime = 0;
                startGame = false;
                FinishGame();
                win = true;
            }
            Random coinDrop = new Random();
            foreach (var enemyPlane in spawner.ToList())
            {
                foreach(var bullet in bullets.ToList())
                {
                    if(bullet.Bullet1.Bounds.IntersectsWith(enemyPlane.Aircraft.Bounds))
                    {
                        int coinD = coinDrop.Next(1,11);
                        this.Controls.Remove(bullet.Bullet1);
                        if (coinD > 2)
                        {
                            enemyPlane.Aircraft.ImageLocation = @"C:\Users\Ivaylo Kartev\Downloads\Planes\explosion.png";
                            enemyPlane.Aircraft.Load();
                            await Task.Delay(100);
                        }
                        if(coinD<=1)
                        {
                            enemyPlane.Aircraft.ImageLocation = @"C:\Users\Ivaylo Kartev\Downloads\Planes\coin.png";
                            enemyPlane.Aircraft.Load();
                            Coins += 50;
                            await Task.Delay(100);
                        }
                        if(coinD==2)
                        {
                            enemyPlane.Aircraft.ImageLocation = @"C:\Users\Ivaylo Kartev\Downloads\Planes\oilBarrel.png";
                            enemyPlane.Aircraft.Load();
                            oilBarrels += 1;
                            await Task.Delay(100);
                        }
                        this.Controls.Remove(enemyPlane.Aircraft);
                        this.bullets.Remove(bullet);
                        this.spawner.Remove(enemyPlane); 
                    }
                }
            }
        }
        public void DeployTroops(List<EnemyPlane> EnemyPlanes)
        {
            EnemyPlane mPlane = new EnemyPlane();
            PictureBox enemy = new PictureBox();
            enemy.Tag = "enemyPlane";
            enemy.Image = mPlane.Plane;
            enemy.Size = new Size(134, 104);
            Random pos = new Random();
            enemy.Left = pos.Next(1, 7) * 200;
            enemy.Top = 150;
            enemy.BackColor = Color.Transparent;
            enemy.SizeMode = PictureBoxSizeMode.AutoSize;
            Controls.Add(enemy);
            mPlane.Aircraft = enemy;
            EnemyPlanes.Add(mPlane);
        }
        public List<Bullet> bullets = new List<Bullet>();
        private void Shoot(string direct)
        {
            // this is the function thats makes the new bullets in this game
            Bullet shoot = new Bullet(); // create a new instance of the bullet class
            shoot.direction = direct; // assignment the direction to the bullet
            shoot.bulletLeft = PlayerPLane.XPos + (122 /2); // place the bullet to left half of the player
            shoot.bulletTop = PlayerPLane.YPos - 104; // place the bullet on top half of the player
            shoot.mkBullet(this); // run the function mkBullet from the bullet class. 
            bullets.Add(shoot);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.D)
            {
                PlayerPLane.Character.Left -= 20;
                e.Handled= true;
            }
            if (e.KeyChar == (char)Keys.A)
            {
                PlayerPLane.Character.Left += 20;
                e.Handled = true;
            }
        }
    }
}