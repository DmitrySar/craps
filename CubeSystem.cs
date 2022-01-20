internal class CubeSystem
{
    private List<Cube> cubes;

    public CubeSystem(List<Cube> cubes)
    {
        this.cubes = cubes;
    }

    //у системы есть сумма значений
    public int Sum
    {
        get 
        {
            int sum = 0;
            foreach (Cube cube in cubes)
            {
                sum += cube.Value;
            }
            return sum;
        }
    }

    //у кубиков есть значения
    public List<int> Values
    {
        get
        {
            List<int> values = new List<int>();
            foreach (Cube cube in cubes)
            {
                values.Add(cube.Value);
            }
            return values;
        }
    }

    //кубики можно бросить
    public void Drop()
    {
        foreach (Cube cube in cubes)
        {
            cube.Drop();
        }
    }
}