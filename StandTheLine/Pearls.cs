namespace StandTheLine
{
    public class Pearls
    {
        private string _colors = null;

        public string Color
        {
            get { return this._colors; }
            set { this._colors = value; }
        }

        public bool AddPeal()
        {
            return true;
        }

        public bool DeletePearl()
        {
            return true;
        }
    }
}