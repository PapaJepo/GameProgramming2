using System;

namespace LabTest1_C17780151
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Quit = false;
            String Play;
            Console.WriteLine("What is your name player?");
            String UserName = Console.ReadLine();
            Console.WriteLine("Hello " +UserName+ ", Welcome to the game.");

            Console.WriteLine("Would you like to play? (yes/no)");
            Play = Console.ReadLine();

            while (Quit == false)
            {
               
                if (Play == "yes" || Play == "Yes" || Play == "YES" || Play == "Y" || Play == "y")
                {

                    Console.WriteLine("Great");

                    MainGame();
                    Quit = true;

                }
                else if (Play == "no" || Play == "No" || Play == "NO" || Play == "N" || Play == "n")
                {
                    Console.WriteLine("Game Over");
                    Quit = true;
                }
                else
                {
                    Console.WriteLine("Please Enter a valid input.");
                    Play = Console.ReadLine();
                }

            }
            Console.WriteLine("");
            Console.WriteLine("Thanks " + UserName + " for playing!");
        }

        public static void MainGame()
        {
            bool ErrorCheck1 = false;
            bool ErrorCheck2 = false;
            bool ErrorCheck3 = false;
            bool ErrorCheck4 = false;
            Console.WriteLine("An Ogre stands in front of you, Can you see the enemy");
            String GameInput = Console.ReadLine();

            while (ErrorCheck1 == false)
            {
                if (GameInput == "yes" || GameInput == "Yes" || GameInput == "YES" || GameInput == "Y" || GameInput == "y")
                {
                    Console.WriteLine("Is the ogre close to you?");
                    GameInput = Console.ReadLine();
                    while (ErrorCheck2 == false)
                    {
                        if (GameInput == "yes" || GameInput == "Yes" || GameInput == "YES" || GameInput == "Y" || GameInput == "y")
                        {
                            bool ShootResult = Shoot(ErrorCheck2);
                            ErrorCheck2 = ShootResult;
                            ErrorCheck1 = true;
                        }
                        else if (GameInput == "no" || GameInput == "No" || GameInput == "NO" || GameInput == "N" || GameInput == "n")
                        {
                            Console.WriteLine("Is the ogre on your flank?");
                            GameInput = Console.ReadLine();
                            while (ErrorCheck3 == false)
                            {
                                if (GameInput == "yes" || GameInput == "Yes" || GameInput == "YES" || GameInput == "Y" || GameInput == "y")
                                {
                                    bool MoveResult = Move(ErrorCheck3);
                                    ErrorCheck3 = MoveResult;
                                    ErrorCheck1 = true;
                                    ErrorCheck2 = true;
                                }
                                else if (GameInput == "no" || GameInput == "No" || GameInput == "NO" || GameInput == "N" || GameInput == "n")
                                {
                                    bool AttackResult = Attack(ErrorCheck3);
                                    ErrorCheck3 = AttackResult;
                                    ErrorCheck1 = true;
                                    ErrorCheck2 = true;
                                }
                                else
                                {
                                    Console.WriteLine("Please Enter a valid input.");
                                    GameInput = Console.ReadLine();
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please Enter a valid input.");
                            GameInput = Console.ReadLine();
                        }
                    }
                }
                else if (GameInput == "no" || GameInput == "No" || GameInput == "NO" || GameInput == "N" || GameInput == "n")
                {
                    Console.WriteLine("Can you hear the ogre?");
                    GameInput = Console.ReadLine();
                    while (ErrorCheck4 == false)
                    {
                        if (GameInput == "yes" || GameInput == "Yes" || GameInput == "YES" || GameInput == "Y" || GameInput == "y")
                        {
                            bool CreepResult = Creep(ErrorCheck4);
                            ErrorCheck4 = CreepResult;
                            ErrorCheck1 = true;
                        }
                        else if (GameInput == "no" || GameInput == "No" || GameInput == "NO" || GameInput == "N" || GameInput == "n")
                        {
                            MainGame();
                        }
                        else
                        {
                            Console.WriteLine("Please Enter a valid input.");
                            GameInput = Console.ReadLine();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Please Enter a valid input.");
                    GameInput = Console.ReadLine();
                }
            }
        }

        public static bool Creep(bool CreepCheck)
        {
            Console.WriteLine("");
            Console.WriteLine("You sneak by the ogre and make your way to the next room.");
            CreepCheck = true;
            return CreepCheck;
        }

        public static bool Shoot(bool ShootCheck)
        {
            Console.WriteLine("");
            Console.WriteLine("You fire a shot at the ogre and land a killing headshot.");
            ShootCheck = true;
            return ShootCheck;
        }

        public static bool Move(bool MoveCheck)
        {
            Console.WriteLine("");
            Console.WriteLine("The ogre attacks from your flank but you quickly roll out of the way and run to the exit.");
            MoveCheck = true;
            return MoveCheck;
        }

        public static bool Attack(bool AttackCheck)
        {
            Console.WriteLine("");
            Console.WriteLine("You lunge your sword forward and land decisive hits on the ogre killing the beast.");
            AttackCheck = true;
            return AttackCheck;
        }
    }
}
