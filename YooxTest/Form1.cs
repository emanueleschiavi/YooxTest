using System.ComponentModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace YooxTest
{
    public partial class Form1 : Form, INotifyPropertyChanged
    {
        private int _player1Score;
        private int _player2Score;

        private ScoreLabels _player1Label;
        private ScoreLabels _player2Label;

        private const int Advantage = 1;
        private const int Win = 2;
        private const int ManageDeuceFrom = 3;
        private const int MinForWin = 4;


        #region FormProperties
        public int Player1Score
        {
            get { return _player1Score; }
            set
            {
                _player1Score = value;
                OnPropertyChanged(nameof(Player1Score));
            }
        }

        public int Player2Score
        {
            get { return _player2Score; }
            set
            {
                _player2Score = value;
                OnPropertyChanged(nameof(Player2Score));
            }
        }

        public ScoreLabels Player1Label
        {
            get { return _player1Label; }
            set
            {
                _player1Label = value;
                OnPropertyChanged(nameof(Player1Label));
            }
        }

        public ScoreLabels Player2Label
        {
            get { return _player2Label; }
            set
            {
                _player2Label = value;
                OnPropertyChanged(nameof(Player2Label));
            }
        }
        #endregion

        public event PropertyChangedEventHandler? PropertyChanged;

        public Form1()
        {
            InitializeComponent();
            lblScore1.DataBindings.Add("Text", this, nameof(Player1Label));
            lblScore2.DataBindings.Add("Text", this, nameof(Player2Label));
            Player1Score = 0;
            Player2Score = 0;

        }

        protected virtual void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            if (property == nameof(Player1Score) || property == nameof(Player2Score))
                CheckScores();

        }
        void CheckScores()
        {
            if (Player1Score >= ManageDeuceFrom && Player2Score >= ManageDeuceFrom)
            {
                ManageDeuce();
            }
            else
            {
                if (Player1Score >= MinForWin)
                {
                    Player1Label = ScoreLabels.Set;
                    Player2Label = ScoreLabels.Empty;
                }
                if (Player2Score >= MinForWin)
                {
                    Player1Label = ScoreLabels.Empty;
                    Player2Label = ScoreLabels.Set;
                }
                if (Player1Score <= ManageDeuceFrom)
                {
                    Player1Label = (ScoreLabels)Player1Score;
                }
                if (Player2Score <= ManageDeuceFrom)
                {
                    Player2Label = (ScoreLabels)Player2Score;
                }

            }

            if(Player1Label == ScoreLabels.Set || Player2Label == ScoreLabels.Set)
            {
                btnPoint1.Enabled = false;
                btnPoint2.Enabled = false;
                btnRandom.Enabled = false;
            }
        }

        private void ManageDeuce()
        {
            if (Player1Score == Player2Score)
            {
                //deuce
                Player1Label = ScoreLabels.Deuce;
                Player2Label = ScoreLabels.Deuce;
                return;
            }
            if (Player1Score - Player2Score == Advantage)
            {
                //adv p1
                Player1Label = ScoreLabels.Advantage;
                Player2Label = ScoreLabels.Empty;

            }
            if (Player1Score - Player2Score == Win)
            {
                //win p1
                Player1Label = ScoreLabels.Set;
                Player2Label = ScoreLabels.Empty;

            }
            if (Player2Score - Player1Score  == Advantage)
            {
                //adv p2
                Player1Label = ScoreLabels.Empty;
                Player2Label = ScoreLabels.Advantage;

            }
            if (Player2Score - Player1Score == Win)
            {
                //win p2
                Player1Label = ScoreLabels.Empty;
                Player2Label = ScoreLabels.Set;

            }

        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            if (new Random().NextDouble() < 0.5)
                Player1Score++;
            else
                Player2Score++;
        }

        private void btnPoint1_Click(object sender, EventArgs e)
        {
            Player1Score++;
        }

        private void btnPoint2_Click(object sender, EventArgs e)
        {
            Player2Score++;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Player1Score = 0;
            Player2Score = 0;

            btnPoint1.Enabled = true;
            btnPoint2.Enabled = true;
            btnRandom.Enabled = true;

        }
    }


    public enum ScoreLabels
    {
        Love,
        Fifteen,
        Thirty,
        Forty,
        Deuce,
        Advantage,
        Empty,
        Set
    }

}