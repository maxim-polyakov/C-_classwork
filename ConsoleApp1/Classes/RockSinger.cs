namespace Program
{
    public class RockSinger : Singer
    {
        private string track;

        public RockSinger(string track)
        {
            this.track = track;
        }
        public override void sing()
        {
            Console.WriteLine("Singing RockSinger " + this.track);
        }
    }
}

