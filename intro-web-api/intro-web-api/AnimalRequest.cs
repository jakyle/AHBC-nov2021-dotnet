namespace intro_web_api
{

    // The consumer of the api will be sending JSON as part of the HTTP Request Body, and the dotnet 
    // application will convert it to a C# object FOR you based on this request model.
    public class AnimalRequest
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Sign { get; set; }
    }
}
