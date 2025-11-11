namespace Program
{
    public class Petrov : Student
    {
        public override void draw(IDrawer drawer)
        {
            Console.WriteLine(drawer.draw());
        }

        public override void walk()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Walking...");
            }
            
        }
    } 
}