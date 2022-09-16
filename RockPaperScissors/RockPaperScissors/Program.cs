using System;

namespace RockPaper
{
    internal class Program
    {
        private static Player _bot;
        private static Player _player;
        private static int num1;
        private static string name;

        public static void Main(string[] args)
        {

             

            GetUserInput();


          

        }


        public static void GetUserInput()
        {
            try
            {

                Console.WriteLine("Keep your name");

                name = Console.ReadLine();


                Console.WriteLine("Enter a number between 0 and 3\n" +
                                                            "0 Paper \n " +
                                                            "1 Rock \n " +
                                                            "2 Scissors");



                num1 = (int)Convert.ToInt32(Console.ReadLine());


                if (num1 < 0 || num1 > 3)
                {
                    throw new Exception("The number must be at least 0 and at most 3");

                }




                _player = new Player(Player.ChoiseVariant(num1), name);

                _bot = new Player();


                Console.WriteLine(_bot.whoWins(_bot, _player));






            }
            catch (FormatException)
            {
                System.Console.WriteLine("You have not entered a number!!!");
                GetUserInput();
            }
           
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                GetUserInput();
            }
            finally
            {

            }
        }
    }
}