using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class TicTacToeGame
    {
        //2D array 
        static char[,] ticTacToeField =
        {
            {'1','2','3'}, 
            {'4','5','6'},
            {'7','8','9'}
        };

        private static int turns = 0;


        static void Main(string[] args)
        {
            

            int player = 2;
            int input = 0;
            bool inputIsCorrect = true;
            
            //char tmpSign = ' '; // To store which overriding value (X or O) 

            do
            {
                //Initialize value after start with overriding
                //tmpSign = signOfPlayer;

                //==Turns of between 2 player (Who is turn).
                if (player==1)
                {
                    player = 2;
                    InputXorO(player,input);
                }
                else if (player==2)
                {
                    player = 1;
                    InputXorO(player, input);
                    
                }
                //==Turns of between 2 player (Who is turn it is).


                //To initialize starting value with "X"
                //if (tmpSign.Equals(' '))
                //{
                //    tmpSign = 'O';
                //}
                

                //Check that which player turns and, Insert the game field

                GameField();

                //==Check for the winner
                /*
                 * There is 8 different winning condition for 2D array tictactoe game
                */

                char[] playerChars = { 'X', 'O' };
                
                foreach (char playerChar in playerChars)
                {
                   //Console.WriteLine($"TEST FOREACH LOOP ");
                    if (
                        ((ticTacToeField[0, 0] == playerChar) && (ticTacToeField[0, 1] == playerChar) && (ticTacToeField[0, 2] == playerChar))
                        || ((ticTacToeField[1, 0] == playerChar) && (ticTacToeField[1, 1] == playerChar) && (ticTacToeField[1, 2] == playerChar))
                        || ((ticTacToeField[2, 0] == playerChar) && (ticTacToeField[2, 1] == playerChar) && (ticTacToeField[2, 2] == playerChar))
                        || ((ticTacToeField[0, 0] == playerChar) && (ticTacToeField[1, 0] == playerChar) && (ticTacToeField[2, 0] == playerChar))
                        || ((ticTacToeField[0, 1] == playerChar) && (ticTacToeField[1, 1] == playerChar) && (ticTacToeField[2, 1] == playerChar))
                        || ((ticTacToeField[0, 2] == playerChar) && (ticTacToeField[1, 2] == playerChar) && (ticTacToeField[2, 2] == playerChar))
                        || ((ticTacToeField[0, 0] == playerChar) && (ticTacToeField[1, 1] == playerChar) && (ticTacToeField[2, 2] == playerChar))
                        || ((ticTacToeField[0, 2] == playerChar) && (ticTacToeField[1, 1] == playerChar) && (ticTacToeField[2, 0] == playerChar))
                    )
                    {
                        if (playerChar == 'X')
                        {
                            
                            Console.WriteLine($"\nPlayer 2 is the WINNER!");
                        }
                        else
                        {
                           
                            Console.WriteLine($"\nPlayer 1 is the WINNER!");
                        }

                        System.Console.WriteLine("Press any key to re-start the game");
                        Console.ReadKey();
                        FieldReset();
                        break;
                    }

                    else if (turns ==10)
                    {
                        System.Console.WriteLine("Draw");
                        System.Console.WriteLine("Press any key to re-start the game");
                        Console.ReadKey();
                        FieldReset();
                        break;
                    }

                   
                }
                //==Check for the winner

                //==Check for user input into the tictactoe field
                do
                {
                    Console.WriteLine($"\nPlayer {player}: Choose your field to put {'tmpSign'}");
                    
                    /*
                    * To check if user input is integer,
                    *otherwise it will not crush the program.
                    */

                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        Console.WriteLine("\nPlease Enter Number!!");
                    }

                    /*
                     * Override each field in 2D array ONCE with correct user input  
                    */
                    if ((input == 1) && (ticTacToeField[0, 0] == '1')) { inputIsCorrect = true; }
                    else if ((input == 2) && (ticTacToeField[0, 1] == '2')) { inputIsCorrect = true; }
                    else if ((input == 3) && (ticTacToeField[0, 2] == '3')) { inputIsCorrect = true; }
                    else if ((input == 4) && (ticTacToeField[1, 0] == '4')) { inputIsCorrect = true; }
                    else if ((input == 5) && (ticTacToeField[1, 1] == '5')) { inputIsCorrect = true; }
                    else if ((input == 6) && (ticTacToeField[1, 2] == '6')) { inputIsCorrect = true; }
                    else if ((input == 7) && (ticTacToeField[2, 0] == '7')) { inputIsCorrect = true; }
                    else if ((input == 8) && (ticTacToeField[2, 1] == '8')) { inputIsCorrect = true; }
                    else if ((input == 9) && (ticTacToeField[2, 2] == '9')) { inputIsCorrect = true; }
                    else
                    {
                        Console.WriteLine("\nThe field is NOT filled!!");
                        inputIsCorrect = false;
                    }

                }
                while (!inputIsCorrect);
                //==Check for user input into the tictactoe field

            }
            while (true);


        }//END static void Main(string[] args)

        //Appearance of game method
        public static void GameField()
        {
            //Refresh existing field after each user input
            Console.Clear();
            Console.WriteLine("\n=== WELCOME TO THE TICTACTOE GAME ===\n");
            Console.WriteLine("\n=== Please Read \"README\" before start play ===\n");
            /*
            *Defines related fields between 2D array and console output on command prompt
            */
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            //Numbers will replace with variables
            Console.WriteLine($"  {ticTacToeField[0,0]}  |  {ticTacToeField[0, 1]}  |  {ticTacToeField[0, 2]}    ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            //Numbers will replace with variables
            Console.WriteLine($"  {ticTacToeField[1, 0]}  |  {ticTacToeField[1, 1]}  |  {ticTacToeField[1, 2]}    ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            //Numbers will replace with variables
            Console.WriteLine($"  {ticTacToeField[2, 0]}  |  {ticTacToeField[2, 1]}  |  {ticTacToeField[2, 2]}    ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            turns++;
        }//==END public static void GameField()

        //User Input Switch Cases method
        public static void InputXorO(int player,int playerInput)
        {
            //Char variable to get user input for "X" or "O"
            char signOfPlayer = ' ';

            /*
            *If user (who is turn at the moment) choose "X" or "O"
            *IT IS "NOT" SWITCH BETWEEN PLAYERS
            *IT IS FOR SWITCH BETWEEN PLAYERS ENTRY
            */
            //if player choose 1/2 put the "X"
            if (player == 1)
            {
                signOfPlayer = 'X';
            }
            //if player choose 1/2 put the "O"
            else if (player == 2)
            {
                signOfPlayer = 'O';
            }

            //Put to user input into the related position in ticTacToeField field
            switch (playerInput)
            {
                case 1:
                    ticTacToeField[0, 0] = signOfPlayer;
                    break;
                case 2:
                    ticTacToeField[0, 1] = signOfPlayer;
                    break;
                case 3:
                    ticTacToeField[0, 2] = signOfPlayer;
                    break;
                case 4:
                    ticTacToeField[1, 0] = signOfPlayer;
                    break;
                case 5:
                    ticTacToeField[1, 1] = signOfPlayer;
                    break;
                case 6:
                    ticTacToeField[1, 2] = signOfPlayer;
                    break;
                case 7:
                    ticTacToeField[2, 0] = signOfPlayer;
                    break;
                case 8:
                    ticTacToeField[2, 1] = signOfPlayer;
                    break;
                case 9:
                    ticTacToeField[2, 2] = signOfPlayer;
                    break;
            }

        }//==END public static void InputXorO(int player,int input)

        // Reset Game method
        public static void FieldReset()
        {
            char[,] initialTicTacToeField =
            {
                { '1', '2', '3' },
                { '4', '5', '6' },
                { '7', '8', '9' }
            };

            ticTacToeField=initialTicTacToeField;
            GameField();
            turns = 0;
        }//END public static void FieldReset()


    }//==END class TicTacToeGame



}//==END namespace TicTacToe
