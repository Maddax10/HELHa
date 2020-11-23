using Démineur.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Démineur___WindowsForm
{
    public partial class Form1 : Form
    {
        Board Board;
        Cell Cell;

        Button Button;
        Button RetryBT;

        Label label;
        Label LooseLB;

        public Form1(Board board)
        {
            this.Board = board;
            InitializeComponent();
            InitializeBoardComponents();
        }

        private void InitializeBoardComponents()
        {
            this.Controls.Clear();
            for (int x = 0; x < Board.NbColones; x++)
            {
                for (int y = 0; y < Board.NbLignes; y++)
                {
                    Cell = Board.GetCellAt(x, y);

                    if (Cell.IsVisible)
                    {
                        this.label = new Label();
                        this.Controls.Add(label);
                        this.label.BackColor = SystemColors.MenuHighlight;
                        this.label.ForeColor = SystemColors.ButtonFace;
                        this.label.Location = new Point(Cell.X * Cell.Size, Cell.Y * Cell.Size);
                        this.label.Name = "label";
                        this.label.Size = new Size(Cell.Size, Cell.Size);
                        this.label.TextAlign = ContentAlignment.MiddleCenter;

                        if (Cell.HasBomb)
                        {
                            this.label.Text = "B";
                            Loose();
                            return;
                        }
                        else if (Cell.NbBombsAround > 0)
                            this.label.Text = Cell.NbBombsAround.ToString();
                    }
                    else
                    {
                        this.Button = new Button();
                        this.Controls.Add(Button);
                        this.Button.Location = new Point(x * Cell.Size, y * Cell.Size);
                        this.Button.Name = "button";
                        this.Button.Size = new Size(Cell.Size, Cell.Size);
                        this.Button.Text = "";
                        this.Button.Tag = Board.GetCellAt(x, y);
                        this.Button.Click += Button_Click;
                    }
                }
            }
        }

        private void Loose()
        {
            Controls.Clear();

            AddLooseLabel();
            AddRetryButton();
        }

        private void RemiseAZeroBoard()
        {
            Board = new Board();
        }

        private void AddRetryButton()
        {
            this.RetryBT = new System.Windows.Forms.Button();
            this.Controls.Add(RetryBT);
            this.RetryBT.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetryBT.Location = new System.Drawing.Point(100, 200);
            this.RetryBT.Name = "LooseBT";
            this.RetryBT.Size = new System.Drawing.Size(131, 51);
            this.RetryBT.Text = "Recommencer";
            this.RetryBT.Click += RetryBT_Click;
        }

        private void RetryBT_Click(object sender, EventArgs e)
        {
            RemiseAZeroBoard();

            InitializeBoardComponents();
        }

        private void AddLooseLabel()
        {
            this.LooseLB = new Label();
            this.Controls.Add(LooseLB);
            this.LooseLB.AutoSize = true;
            this.LooseLB.Font = new Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LooseLB.Location = new System.Drawing.Point(100, 100);
            this.LooseLB.Name = "LooseLB";
            this.LooseLB.TabIndex = 0;
            this.LooseLB.Text = "Perdu !";
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            Cell cell = (Cell)(button.Tag);
            button.Dispose();
            Board.ShowCellAt(cell.X, cell.Y);
            InitializeBoardComponents();
        }
    }
}
