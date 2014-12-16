namespace fontys_cocktailmachine
{
    public class Ingredient
    {
        private readonly int _id;
        private readonly string _name;

        public Ingredient(string name, int id)
        {
            _name = name;
            _id = id;
        }

        public string Name
        {
            get { return _name; }
        }

        public int Id
        {
            get { return _id; }
        }
    }
}