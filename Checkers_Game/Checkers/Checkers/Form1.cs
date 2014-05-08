using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Checkers
{
    public partial class Form1 : Form
    {

        private const int mRows = 8;
        private const int mColumns = 8;
        private const int mButtonWidth = 50;
        private const int mButtonHeight = 50;

        private Game game;

        //This needs to be moved to Player class (can use isMakingMove flag on player)!        
        private BoardSpace previousBoardSpace = null;

        public Form1()
        {
            InitializeComponent();
            initGame();
        }

        public void initGame()
        {
            try
            {
                //Create a new game object
                game = new Game();
                
                //Create me as the player
                Player player = new Player("Jessica", ChipColor.Red, Seat.Top);

                //Create the computer player.
                Player computer = new Player("Easy Computer", ChipColor.Black, Seat.Bottom);

                //Make sure to create the players list if it's null
                game.Players = game.Players == null ? new List<Player>() : game.Players;

                //Add the player to the master list
                game.Players.Add(player);

                //Add the computer to the master list
                game.Players.Add(computer);

                loadBoard();
                loadChipsForPlayers();
                assignAllChipsToBoard();

                drawChips();
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("{0}", ex.Message));
            }

        }
        
        public void loadBoard()
        {
            initEmptySpaces();
        }

        private void loadChipsForPlayers()
        {
            foreach(Player player in game.Players)
                game.giveStartingChips(player);
        }

        private void assignAllChipsToBoard()
        {
            //iterating through all the players in the game
            foreach (Player p in game.Players)
            {
                assignPlayerChipsToBoard(p);
            }
        }

        private void assignPlayerChipsToBoard(Player p)
        {

            int c = 0;
            bool noMorechipsLeft = false;

            //iterate through the positions on the board
            for (int i = 0; i < mRows; i++)
            {

                for (int j = 0; j < mColumns; j++)
                {
                    //If no more chips left, exit this loop
                    if (noMorechipsLeft)
                        return;
                    if (p.Seat == Seat.Top)
                    {                        
                        switch (i)
                        {
                            //Case 0 is going to be our first row 0.  
                            case 0:
                                if (j % 2 == 0)
                                {
                                    BoardSpace spaceInQuestion = game.getSpaceByCoordinates(j, i);
                                    if (spaceInQuestion != null)
                                    {
                                        spaceInQuestion.ChipInContainer = p.Chips[c];
                                        c++;

                                        //If the current counter is greater than what we have total, no more chips!  (since it's 0 based, I subtract 1)
                                        if (c - (p.Chips.Count - 1) >= 0)
                                            noMorechipsLeft = true;
                                    }
                                }
                                break;

                            //Case 1 is going to be our second row 1.  
                            case 1:
                                if (j % 2 == 1)
                                {
                                    BoardSpace spaceInQuestion = game.getSpaceByCoordinates(j, i);
                                    if (spaceInQuestion != null)
                                    {
                                        spaceInQuestion.ChipInContainer = p.Chips[c];
                                        c++;

                                        //If the current counter is greater than what we have total, no more chips!
                                        if (c - (p.Chips.Count) >= 0)
                                            noMorechipsLeft = true;
                                    }
                                }
                                break;
                        }
                    }
                    else if (p.Seat == Seat.Bottom)
                    {
                        switch (i)
                        {
                            case 6:
                                if (j % 2 == 0)
                                {
                                    BoardSpace spaceInQuestion = game.getSpaceByCoordinates(j, i);
                                    if (spaceInQuestion != null)
                                    {
                                        spaceInQuestion.ChipInContainer = p.Chips[c];
                                        c++;

                                        //If the current counter is greater than what we have total, no more chips!  (since it's 0 based, I subtract 1)
                                        if (c - (p.Chips.Count - 1) >= 0)
                                            noMorechipsLeft = true;
                                    }
                                }
                                break;

                            case 7:
                                if (j % 2 == 1)
                                {
                                    BoardSpace spaceInQuestion = game.getSpaceByCoordinates(j, i);
                                    if (spaceInQuestion != null)
                                    {
                                        spaceInQuestion.ChipInContainer = p.Chips[c];
                                        c++;

                                        //If the current counter is greater than what we have total, no more chips!
                                        if (c - (p.Chips.Count) >= 0)
                                            noMorechipsLeft = true;
                                    }
                                }
                                break;
                        }
                    }
                            
                            

                }
            }
                
            
        }

        public void drawChips()
        {
            foreach (Control ctrl in pnlBoard.Controls)
            {

                if (ctrl.Tag == null)
                {
                    //Empty space
                }
                else
                {
                    if (ctrl.Tag is BoardSpace)
                    {
                        BoardSpace space = (BoardSpace)ctrl.Tag;


                        if (ctrl is Button)
                        {
                            Button btn = (Button)ctrl;

                            if (space.ChipInContainer != null)
                            {
                                //Old hard-coded way:  using colors  -  btn.BackColor = space.ChipInContainer.Color == ChipColor.Red ? System.Drawing.Color.Red : System.Drawing.Color.Black;

                                //Set image based on folder relative to executing path
                                btn.Image = space.ChipInContainer.Color == ChipColor.Red ? Image.FromFile(Application.StartupPath + "\\images\\Red_Piece.png")
                                    : Image.FromFile(Application.StartupPath + "\\images\\Black_Piece.png");
                            }
                            else
                                btn.Image = null;
                        }


                    }

                }


            }

        }

        public void initEmptySpaces()
        {
            for (int i = 0; i < mRows; i++)
            {
                for (int j = 0; j < mColumns; j++)
                {
                    Button btn = new Button();
                    btn.Click += new EventHandler(chip_Click);
                    //btn.Text = i + "," + j;
                    btn.ForeColor = System.Drawing.Color.DarkBlue;
                    btn.Size = new System.Drawing.Size(mButtonWidth, mButtonHeight);
                    btn.Location = new Point(i * mButtonWidth, j * mButtonHeight);
                    
                    BoardSpace thisBoardSpace = new BoardSpace(i, j);                                     

                    btn.Tag = thisBoardSpace;

                    //If this is the first boardspace, we are instanciating our list for the first time when it's null
                    game.BoardSpaces = game.BoardSpaces == null ? new List<BoardSpace>() : game.BoardSpaces;

                    //Add this BoardSpace to our collection in the game itself
                    game.BoardSpaces.Add(thisBoardSpace);

                    //Add button to the actual panel
                    pnlBoard.Controls.Add(btn);

                }
            }
        }

        void chip_Click(object sender, EventArgs e)
        {
            Button btn;

            try
            {

                if (sender is Button)
                {
                    btn = (Button)sender;
                    if (btn.Tag != null)
                    {
                        if (btn.Tag is BoardSpace)
                        {
                            //Get the current space clicked on
                            BoardSpace thisSpace = (BoardSpace)btn.Tag;

                            //If the previous space is null, we have nothing selected
                            if (previousBoardSpace == null)
                            {
                                //Does out new selection have a chip in it?
                                if (thisSpace.ChipInContainer == null)
                                    throw new Exception("This board space does not contain a chip to move!");
                                else
                                {
                                    //Our new selection has a chip in it.  We set previousBoardSpace to this space (note: this will be a player's previousBoardSpace at the least)
                                    previousBoardSpace = thisSpace;

                                    //Change the cursor to something else so that the user knows they have a move pending.
                                    this.Cursor = Cursors.NoMove2D;
                                }
                            }
                            else
                            {
                                //The previous space is not null, so we must be clicking a destination space now.  Does the previous space have a chip in it?  It always should now that I added the check, but just to be sure this can't hurt!
                                if (previousBoardSpace.ChipInContainer != null)
                                {
                                    //Get the chip in my hand by looking at the previous board space's chip
                                    Chip chipInMyHand = previousBoardSpace.ChipInContainer;

                                    //Call move function passing the old space and the new space
                                    if (chipInMyHand.Move(previousBoardSpace, thisSpace))
                                    {
                                        //Set back the cursor, the move was successful!
                                        this.Cursor = Cursors.Default;

                                        //Call draw chips again.  This will draw the entire board based on our lists.
                                        drawChips();

                                        //Set previous BoardSpace to null because we are done with it and it has moved.
                                        previousBoardSpace = null;

                                    }
                                }
                                else
                                    throw new Exception("Previously clicked board space does not have a chip in it!  Not sure how this happened!");

                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("{0}", ex.Message));
            }
        }

    }
}
