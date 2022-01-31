/*
 *   Игра в кости.
 *   
 *   Игрок бросает две кости и подсчитывает сумму выпавших очков.
 *   Он сразу же выигрывает, если эта сумма равна 7 или 11, 
 *   и проигрывает, если она равна 2, 3 или 12.
 *   Всякая другая сумма – это его “пойнт”.
 *   
 *   Если в первый раз выпадает “пойнт”, то игрок бросает кости еще до тех пор,
 *   пока он или не выиграет, выбросив свой “пойнт”, или не проиграет,получив сумму очков, равную 7.
*/

/*
 * декомпозируем задачу
 * 
 * у нас есть кубик (Cube)
 * кубики образуют систему (CubeSystem)
 * система кубиков используется в игре (Game)
 * также есть игрок (Player)
 * и некая логика игры (GameLogic)
 */

// refactoring

class Program
{
    public static void Main()
    {
        //создаём новую игру
        Craps craps = new Craps(new CubeSystem(new List<Cube> { new Cube(), new Cube() }));
        //создаём игрока
        Console.Write("Введите имя: ");
        Player player = new Player(Console.ReadLine(), craps);

        //продолжать ли игру
        bool isContinue = true;
        //цикл пока не закончится игра
        while (isContinue)
        {
            //Выведем значения и сумму кубиков на консоль
            craps.ToConsole();

            //проверяем логику
            isContinue = !LogicCraps.IsEndOfGame(player, craps);

            //выводим сообщения при проигрыше
            if (player.IsLose) Console.WriteLine($"{player.Name} is Lose.");
            //выводим сообщение при выигрыше
            else if (player.IsWin) Console.WriteLine($"{player.Name} is Win!!!");
            //следующий ход
            if (isContinue) player.NextStep();
        }
        
    }
}