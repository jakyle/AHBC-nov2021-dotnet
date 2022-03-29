namespace Entity_Web_App.Services.DALModels
{
    public class Animal // this will be the table in my DB
    {
        public int Id { get; set; } // automatically be the primary key, because Id is in the name :)
        public string Type { get; set; }
        public string Name { get; set; }
    }
}
