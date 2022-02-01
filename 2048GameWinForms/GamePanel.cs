namespace _2048GameWinForms
{
    public partial class GamePanel : Form
    {

        public int[,] map = new int[4, 4];
        public PictureBox[,] pics = new PictureBox[4, 4];
        public int[,] newMap = new int[4, 4];
        public GamePanel()
        {
            InitializeComponent();

            this.KeyDown += new KeyEventHandler(KeyBoardEvent);
            map[0, 0] = 1;
            map[1, 0] = 1;
            map[0, 1] = 1;
            createMap();
            createPics();
        }

        private void createMap()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    PictureBox pic = new PictureBox();
                    pic.Location = new Point(12 + 56 * j, 87 + 56 * i);
                    pic.Size = new Size(50, 50);
                    pic.BackColor = Color.Gray;
                    this.Controls.Add(pic);
                }
            }
        }

        private void createPics() 
        {
            pics[0, 0] = new PictureBox();
            Label label = new Label();
            label.Text = "2";
            label.Size = new Size(50, 50);  
            label.Font = new Font(new FontFamily("Microsoft Sans Serif"), 28);
            pics[0, 0].Controls.Add(label);
            pics[0, 0].Location = new Point(12, 87);
            pics[0, 0].Size = new Size(50, 50);
            pics[0, 0].BackColor = Color.Red;
            this.Controls.Add(pics[0, 0]);
            pics[0, 0].BringToFront();

            Label label1 = new Label();
            label1.Text = "2";
            label1.Size = new Size(50, 50);
            label1.Font = new Font(new FontFamily("Microsoft Sans Serif"), 28);
            pics[0, 1] = new PictureBox();
            pics[0, 1].Controls.Add(label1);
            pics[0, 1].Location = new Point(68, 87);
            pics[0, 1].Size = new Size(50, 50);
            pics[0, 1].BackColor = Color.Red;
            this.Controls.Add(pics[0, 1]);
            pics[0, 1].BringToFront();

            Label label2 = new Label();
            label2.Text = "4";
            label2.Size = new Size(50, 50);
            label2.Font = new Font(new FontFamily("Microsoft Sans Serif"), 28);
            pics[1, 0] = new PictureBox();
            pics[1, 0].Controls.Add(label2);
            pics[1, 0].Location = new Point(12, 143);
            pics[1, 0].Size = new Size(50, 50);
            pics[1, 0].BackColor = Color.Yellow;
            this.Controls.Add(pics[1, 0]);
            pics[1, 0].BringToFront();
        }

        private void KeyBoardEvent(object? sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "Right":
                    for (int k = 0; k < 4; k++)
                    {
                        for (int l = 2; l >= 0; l--)
                        {
                            if (map[k, l] == 1)
                            {
                                for (int j = l + 1; j < 4; j++)
                                {
                                    if (map[k, j] == 0)
                                    {
                                        map[k, j - 1] = 0;
                                        map[k, j] = 1;
                                        pics[k, j] = pics[k, j - 1];
                                        pics[k, j - 1] = null;
                                        pics[k, j].Location = new Point(pics[k, j].Location.X + 56, pics[k, j].Location.Y);
                                    }
                                }
                            }
                        }
                    }
                    
                    break;
                  
                case "Left":
                    for (int k = 0; k < 4; k++)
                    {
                        for (int l = 1; l < 4; l++)
                        {
                            if (map[k, l] == 1)
                            {
                                for (int j = l - 1; j >= 0; j--)
                                {
                                    if (map[k, j] == 0)
                                    {
                                        map[k, j + 1] = 0;
                                        map[k, j] = 1;
                                        pics[k, j] = pics[k, j + 1];
                                        pics[k, j + 1] = null;
                                        pics[k, j].Location = new Point(pics[k, j].Location.X - 56, pics[k, j].Location.Y);
                                    }
                                }
                            }
                        }
                    }
                    break;

                case "Down":
                    for (int k = 2; k >= 0; k--)
                    {
                        for (int l = 1; l < 4; l++)
                        {
                            if (map[k, l] == 1)
                            {
                                for (int j = k + 1; j < 4; j++)
                                {
                                    if (map[j, l] == 0)
                                    {
                                        map[j - 1, l] = 0;
                                        map[j, l] = 1;
                                        pics[j, l] = pics[j - 1, l];
                                        pics[j - 1, l] = null;
                                        pics[j, l].Location = new Point(pics[j, l].Location.X, pics[j, l].Location.Y + 56);
                                    }
                                }
                            }
                        }
                    }
                    break;

                case "Up":
                    for (int k = 1; k < 4; k++)
                    {
                        for (int l = 0; l < 4; l++)
                        {
                            if (map[k, l] == 1)
                            {
                                for (int j = k - 1; j >= 0; j--)
                                {
                                    if (map[j, l] == 0)
                                    {
                                        map[j + 1, l] = 0;
                                        map[j, l] = 1;
                                        pics[j, l] = pics[j + 1, l];
                                        pics[j + 1, l] = null;
                                        pics[j, l].Location = new Point(pics[j, l].Location.X, pics[j, l].Location.Y - 56);
                                    }                            
                                }
                            }
                        }
                    }
                    break;
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void GamePanel_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GamePanel_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }
    }
}
