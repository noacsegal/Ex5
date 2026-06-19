using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using GameLogic;

namespace WindownInterface
{
    public partial class FromGameBoard : Form
    {
        private GameManager m_GameManager;
        private string m_Player1Name;
        private string m_Player2Name;
        private int m_BoardSize;
        private int m_ButtonWidth = 50;
        private int m_ButtonHeight = 40;
        private Label? m_LabelPlayer1Score;
        private Label? m_LabelPlayer2Score;
        private bool m_isAIPlayer;

        public FromGameBoard(string i_Player1Name, string i_Player2Name, int i_BoardSize, bool i_isAIPlayer)
        {
            InitializeComponent();
            m_Player1Name = i_Player1Name;
            m_BoardSize = i_BoardSize;
            m_isAIPlayer = i_isAIPlayer;
            if (m_isAIPlayer)
            {
                m_Player2Name = "Computer";
            }
            else
            {
                m_Player2Name = i_Player2Name;
            }

        }

        private void BoardForm_Load(object sender, EventArgs e)
        {
            this.Text = "TicTacToeMisere";
            CreateBoard(m_BoardSize);
            m_GameManager = new GameManager();
            m_GameManager.CellChanged += m_GameManager_CellChanged;
            m_GameManager.GameEnd += m_GameManager_GameEnd;
            m_GameManager.ScoreChanged += m_GameManager_ScoreChanged;
            m_GameManager.StartGame(m_BoardSize, m_isAIPlayer, m_Player1Name, m_Player2Name);
        }
        private void CreateBoard(int i_BoardSize)
        {
            int edge = 20;
            int space = 5;
            int spaceForPlayersScore = 30;
            for (int i= 0; i < i_BoardSize; i++)
            {
                for (int j = 0; j < i_BoardSize; j++)
                {
                    Button currentButton = new Button();
                    currentButton.Width = m_ButtonWidth;
                    currentButton.Height = m_ButtonHeight;
                    currentButton.Enabled = true;
                    currentButton.Left = edge + (j * (m_ButtonWidth + space));
                    currentButton.Top = edge + (i * (m_ButtonHeight + space));
                    currentButton.Tag = new Point(i, j);
                    currentButton.Click += currentButton_Click;
                    currentButton.TabStop = false;
                    this.Controls.Add(currentButton);
                }
            }
            int totalWidth = (i_BoardSize * m_ButtonWidth) + ((i_BoardSize - 1) * space) + (edge * 2);
            int buttonsHeight = (i_BoardSize * m_ButtonHeight) + ((i_BoardSize - 1) * space) + (edge * 2);
            int totalHeight = buttonsHeight + spaceForPlayersScore;
            this.ClientSize = new Size(totalWidth, totalHeight);

            m_LabelPlayer1Score = new Label();
            m_LabelPlayer1Score.Top = buttonsHeight;
            m_LabelPlayer1Score.Left = edge;
            m_LabelPlayer1Score.Width = (totalWidth / 2) - edge;
            m_LabelPlayer1Score.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            m_LabelPlayer1Score.Text = $"{m_Player1Name}: 0";
            this.Controls.Add(m_LabelPlayer1Score);

            m_LabelPlayer2Score = new Label();
            m_LabelPlayer2Score.Top = buttonsHeight;
            m_LabelPlayer2Score.Width = (totalWidth /2 ) - edge;
            m_LabelPlayer2Score.Left = totalWidth / 2;
            m_LabelPlayer2Score.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            m_LabelPlayer2Score.Text = $"{m_Player2Name}: 0";
            this.Controls.Add(m_LabelPlayer2Score);
        }

        private void m_GameManager_CellChanged(CellChangedEventArgs i_EventArgs)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button button)
                {
                    Point buttonPosition = (Point)button.Tag;
                    if (buttonPosition.X == i_EventArgs.Row && buttonPosition.Y == i_EventArgs.Col)
                    {
                        button.Text = i_EventArgs.Symbol.ToString();
                        button.Enabled = false;
                        break;
                    }
                }
            }
        }
        private void m_GameManager_ScoreChanged()
        {
            m_LabelPlayer1Score.Text = $"{m_Player1Name}: {m_GameManager.Player1.Score}";
            m_LabelPlayer2Score.Text = $"{m_Player2Name}: {m_GameManager.Player2.Score}";
        }

        private void currentButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            Point buttonPosition = (Point)clickedButton.Tag;
            m_GameManager.RunTwoPlayers(buttonPosition.X, buttonPosition.Y);
        }
        private void m_GameManager_GameEnd(string i_MessageText, string i_Title)
        {
            DialogResult result = MessageBox.Show(this, i_MessageText + "\nWould you like to play another round?", i_Title, MessageBoxButtons.YesNo);
            
            if (result == DialogResult.Yes)
            {
                m_GameManager.ResetGameRound();
                foreach (Control control in this.Controls)
                {
                    if (control is Button button)
                    {
                        button.Text = "";
                        button.Enabled = true;
                    }
                }
            }
            else
            {
                this.Close();
            }
        }
    }
}
