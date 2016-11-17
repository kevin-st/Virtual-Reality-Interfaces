using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VR_Interfaces_Project
{
    public class Game
    {
        private decimal _gameWidth, _gameHeight;
        private bool _hasWon, _hasInitialzed;

        private Button[,] _grid;
        private readonly IFrmGame form;

        // default constructor
        public Game() { }

        public Game(decimal width, decimal height, IFrmGame form)
        {
            this.form = form;

            _gameWidth = width;
            _gameHeight = height;
            _hasWon = false;

            _grid = new Button[(int)_gameWidth, (int)_gameHeight];
        }

        public decimal Width
        {
            get { return _gameWidth; }
            set { _gameWidth = value; }
        }

        public decimal Height
        {
            get { return _gameHeight; }
            set { _gameHeight = value; }
        }

        public bool HasWon
        {
            get { return _hasWon; }
            set { _hasWon = value; }
        }

        public bool HasInitialized
        {
            get { return _hasInitialzed; }
        }

        /// <summary>
        /// Initializes a new game and adds the button controls to the game view.
        /// </summary>
        public void InitializeGame()
        {
            byte counter = 1;

            for(byte i = 0; i < _gameHeight; i++)
            {
                for(byte j = 0; j <_gameWidth; j++)
                {
                    _grid[i, j] = new Button();

                    _grid[i, j].Enabled = false;
                    _grid[i, j].Name = "Cell " + counter;
                    //_grid[i, j].Text = "Cell " + counter;
                    _grid[i, j].BackColor = System.Drawing.Color.Transparent;
                    _grid[i, j].FlatStyle = FlatStyle.Flat;
                    _grid[i, j].Width = form.GameView.Width / (int)_gameWidth;
                    _grid[i, j].Height = form.GameView.Height / (int)_gameHeight;
                    _grid[i, j].Parent = form.GameView;
                    _grid[i, j].Location = new System.Drawing.Point(j * _grid[i,j].Width, i * _grid[i,j].Height);

                    counter++;
                }
            }

            _hasInitialzed = true;
        }

        /// <summary>
        /// Resets the game view
        /// </summary>
        public void ResetGameView()
        {
            for(byte i = 0; i < _gameHeight; i++)
            {
                for (byte j = 0; j <_gameWidth; j++)
                {
                    form.GameView.Controls.Remove(_grid[i, j]);
                    _grid[i, j] = null;
                }
            }

            _grid = null;
            _hasInitialzed = false;
        }

        public void AddToGameField(Triangle2DF[,] arr, string text)
        {
            for(byte i = 0; i < _gameHeight; i++)
            {
                for(byte j = 0; j < _gameWidth; j++)
                {
                    if(arr[i, j].Area != 0 && _grid[i,j].Text == "")
                    {
                        _grid[i, j].Text = text;
                    }
                }
            }
        }

        public void AddToGameField(CircleF[,] arr, string text)
        {
            for (byte i = 0; i < _gameHeight; i++)
            {
                for (byte j = 0; j < _gameWidth; j++)
                {
                    if (arr[i, j].Area != 0 && _grid[i, j].Text == "")
                    {
                        _grid[i, j].Text = text;
                    }
                }
            }
        }
    }
}
