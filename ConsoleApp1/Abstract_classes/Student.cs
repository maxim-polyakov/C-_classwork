namespace Program
{
    public abstract class Student : IStudent, IHuman
    {
        protected int age;
        
        public int Age
        {
            get { return this.age;}
            set { this.age = value;}
        }
        public abstract void draw(IDrawer drawer);
        public abstract void walk();
    }
}

