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

class Program
{
    public static void Main()
    {
        Craps craps = new Craps(new CubeSystem(new List<Cube> { new Cube(), new Cube() }));
        Console.Write("Введите имя: ");
        Player player = new Player(Console.ReadLine(), craps);

        bool isContinue = true;
        while (isContinue)
        {
            craps.ToConsole();
            isContinue = !LogicCraps.IsEndOfGame(player, craps);
            if (player.IsLose) Console.WriteLine($"{player.Name} is Lose.");
            else if (player.IsWin) Console.WriteLine($"{player.Name} is Win!!!");
            if (isContinue) player.NextStep();
        }      
    }
}