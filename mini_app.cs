using System;

namespace RockPaperScissorCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Камень-Ножницы-Бумага****");
//          выводит название игры
            int playerScore = 0;
            int computerScore = 0;
            string isPlay = "д";
//          начинает счет побед
            do
            {

            Console.WriteLine("Введите 'к' для Камня, 'б' для бумаги и 'н' для ножницы. 'в' чтобы выйти");
            string userInput = Console.ReadLine();

            string[] choiseArr = { "Камень", "Бумага", "Ножницы" };
            Random rand = new Random();
//          с помощью случайного выбора компьютер выберает одну из вариантов
            int index = rand.Next(choiseArr.Length);
            string computerChoise = choiseArr[index];


            switch (userInput)
            {
                case "н":
                    Console.WriteLine("Вы выбрали Ножницы ");
                    Console.WriteLine("Компьютер выбрал " + computerChoise);
                    break;
                case "б":
                    Console.WriteLine("Вы выбрали Бумагу ");
                    Console.WriteLine("CКомпьютер выбрал " + computerChoise);
                    break;
                case "к":
                    Console.WriteLine("Вы выбрали Камень ");
                    Console.WriteLine("Компьютер выбрал " + computerChoise);
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }

            if(userInput == computerChoise.ToLower().Substring(0, 1))
            {
                Console.WriteLine("Ничья");
            }
            else if((userInput == "к" && computerChoise == "Бумага") || (userInput == "б" && computerChoise == "Ножницы") || (userInput == "н" && computerChoise == "Камень"))
            {
                Console.WriteLine("Компьютер победил!");
                    computerScore++;
            }
            else if(( computerChoise == "Камень" && userInput == "б") || (computerChoise == "Бумага" && userInput  == "н") || (computerChoise == "Ножницы" && userInput  == "к"))
            {
                Console.WriteLine("Ты выиграл!");
                    playerScore++;
            }
            else
            {
                Console.WriteLine("Пожалуйста вводи правильно");
            }
                Console.WriteLine("**********СЧЕТ**********");
                Console.WriteLine("**ТЫ: "+playerScore+"\n**Компьютер: "+computerScore);
                Console.WriteLine("Попробуешь снова? в чтобы выйти. Нажми любую кнопку чтобы продолжить.");
                isPlay= Console.ReadLine();
                Console.Clear();
            } while (isPlay != "в");
        }
    }
}