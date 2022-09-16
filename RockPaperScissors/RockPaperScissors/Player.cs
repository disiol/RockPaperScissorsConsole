using System;

namespace RockPaper
{
    public class Player
    {
        private EVariants _variant;
        private string _name;
        private string _winer;
        private string _courseOfTheGame;




        public Player()
        {
            this._name = "Bot";

            int varianrNamber = new Random().Next(0,3);

            this._variant = ChoiseVariant(varianrNamber);

        }

        public Player(EVariants choise, string name)
        {
            this._variant = choise;
            this._name = name;
        }

       
         public static EVariants ChoiseVariant(int variantNamber)
        {
            EVariants variant = EVariants.Nan;

            switch (variantNamber)
            {
                case 0:
                 return   variant = EVariants.Paper;
                case 1:
                    return variant = EVariants.Rock;


                case 2:
                    return variant = EVariants.Scissors;

            }
            return variant;



        }


        public string whoWins(Player bot, Player player) {

            RulesforWins(bot, player);


            _courseOfTheGame = $"The player {player._name}  chose: {player._variant} \n The player {bot._name}  chose: {bot._variant}  \n" + _winer;

            return _courseOfTheGame;



        }


        private string RulesforWins(Player bot, Player player)
        {
            if (bot._variant.Equals(player._variant))
            {
                this._winer = "Draw";
            }
            else if (bot._variant.Equals(EVariants.Paper)
            && player._variant.Equals(EVariants.Rock))
            {
                this._winer = $"Wins player: {bot._name}.";

            }
            else if (bot._variant.Equals(EVariants.Rock)
           && player._variant.Equals(EVariants.Paper))
            {
                this._winer = $"Wins player: {player._name}.";

            }
            else if (bot._variant.Equals(EVariants.Scissors)
         && player._variant.Equals(EVariants.Paper))
            {
                this._winer = $"Wins player: {bot._name}.";

            }
            else if (bot._variant.Equals(EVariants.Paper)
         && player._variant.Equals(EVariants.Scissors))
            {
                this._winer = $"Wins player: {player._name}.";

            }
            else if (bot._variant.Equals(EVariants.Rock)
         && player._variant.Equals(EVariants.Scissors))
            {
                this._winer = $"Wins player: {bot._name}.";

            }
            else if (bot._variant.Equals(EVariants.Scissors)
         && player._variant.Equals(EVariants.Rock))
            {
                this._winer = $"Wins player: {player._name}.";

            }


            return this._winer;
        }



    }
}
