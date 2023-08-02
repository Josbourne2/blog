namespace ConfigFunctionDemo.Configuration
{
    public class ParentOptions
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ChildOptions ChildOptions { get; set; }
    }

    public class ChildOptions
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<string> FavouriteFoods { get; set; }
    }
}