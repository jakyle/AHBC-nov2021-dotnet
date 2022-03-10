namespace intro_to_mvc_for_real_this_time.Models.Dog
{
    public class IndexViewModel
    {
        public IndexViewModel(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; set; }
        public string Description { get; set; }
    }
}
