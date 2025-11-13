namespace Program
{
    public class Program
    {
        public static void Main()
        {
            Student petrov = new Petrov();
            petrov.Age = 16;
            Singer singer = new RockSinger("track");
            IDrawer pen = new Pen();
            IDrawer pencil = new Pencil();
            
            petrov.draw(pen);
            petrov.draw(pencil);
            singer.sing();
            petrov.walk();
        }
    }
}