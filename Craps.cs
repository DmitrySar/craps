class Craps : Game
{
    private CubeSystem cubeSystem;
    //выигрышная сумма
    int[] winValues = { 7, 11 };
    //проигрышная сумма
    int[] loseValues = { 2, 3, 12 };

    public Craps(CubeSystem cubeSystem)
    {
        this.cubeSystem = cubeSystem;
    }

    //проверка суммы
    public bool SumInWinValues()
    {
        return winValues.Contains(cubeSystem.Sum);
    }

    public bool SumInLoseValues()
    {
        return loseValues.Contains(cubeSystem.Sum);
    }

    //значения кубиков
    public List<int> Values
    {
        get { return cubeSystem.Values; }
    }

    //сумма кубиков
    public int Sum
    {
        get { return cubeSystem.Sum; }
    }

    public void NextStep()
    {
        //смена выигрышных и проигрышных сумм
        winValues = new int[] { 0, cubeSystem.Sum };
        loseValues = new int[] { 0, 0, 7 };
        //бросаем кубики
        cubeSystem.Drop();
    }
}