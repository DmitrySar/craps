class LogicCraps
{
    //узнаём настал ли конец игры
    public static bool IsEndOfGame(Player player, Craps craps)
    {
        if (craps.SumInLoseValues()) player.IsLose = true;
        if (craps.SumInWinValues()) player.IsWin = true;
        return player.IsWin || player.IsLose;
    }
}