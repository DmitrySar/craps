class Cube
{
    //максимальное значение - 6
    const int MAX_VALUE = 6;
    //у кубика есть значение
    int value;

    //создадим конструктор для инициализации
    public Cube()
    {
        Drop();
    }
    //кубик можно бросать
    public void Drop()
    {
        //при броске вылетает случайное значение
        value = new Random().Next(1, MAX_VALUE + 1);
    }

    //создадим публичное поле для чтения value
    public int Value
    {
        get { return value; }
    }
        
}