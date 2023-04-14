using Microsoft.EntityFrameworkCore;
namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        private Set set;
        public Form1()
        {
            InitializeComponent();
            set = new Set();

            //set.GameBoards.Add(new GameBoard() {Name="Star Wars Rebellion", Rate=10.0f });
            //set.GameBoards.Add(new GameBoard() {Name="Nemesis", Rate=9.5f });
            //set.GameBoards.Add(new GameBoard() {Name="Catan", Rate=7.5f });
            //set.GameBoards.Add(new GameBoard() {Name="Lord of Hellas", Rate=8.5f });
            //set.SaveChanges();
            float rate = 8.0f;
            //var games = set.GameBoards.ToList();
            var games = set.GameBoards.Where(x => x.Rate >= rate).ToList();
            //var games = set.GameBoards.FromSql($"select * from GameBoards where rate > {rate}").ToList();
            foreach (var game in games)
                listBox1.Items.Add(game);

        }
    }
}