namespace BlazorGenericTable.MA.UseCase.Client.Models.Data
{
    public static class PersonMockData
    {
        public static List<Person> GetPersons()
        {
            return new List<Person>()
            {
                new()
                {
                    Id = 1,
                    Name = "Mohammad Aghamohammadi",
                    Description = "Creator of the generic table component From Rasht",
                    Gender = Gender.Male,
                    Jobs =new()
                    {
                        "Programmer","Developer","Product owner"
                    }, 
                    HasJob = true,
                    Birthdate = DateOnly.Parse("1992-02-02"),
                    StartWorkAt = DateTime.Now.AddYears(-1)
                },
                new()
                {
                    Id = 2,
                    Name = "Jenifer",
                    Description = "Leader",
                    Gender = Gender.Female,
                    Birthdate = DateOnly.Parse("1982-04-22"),
                    StartWorkAt = DateTime.Now.AddYears(-3)
                },
                new()
                {
                    Id = 3,
                    Name = "John",
                    Description = "Product owner",
                    Gender = Gender.Other,
                    Jobs = new()
                    {
                        "Product owner", "Leader", "Other"
                    },
                    HasJob = true,
                    Birthdate = DateOnly.Parse("1990-12-12"),
                    StartWorkAt = DateTime.Now.AddYears(-6)
                },
                new()
                {
                    Id = 4,
                    Name = "Joel",
                    Description = "A developer from California",
                    Gender = Gender.Male,
                    Jobs =new()
                    {
                        "Programmer","Product owner"
                    },
                    Birthdate = DateOnly.Parse("1998-05-04"),
                    StartWorkAt = DateTime.Now.AddYears(-2)
                },
                new()
                {
                    Id = 5,
                    Name = "Jena",
                    Description = "Leader",
                    Gender = Gender.Female,
                    Birthdate = DateOnly.Parse("1982-5-11"),
                    StartWorkAt = DateTime.Now.AddYears(-9)
                },
                new()
                {
                    Id = 6,
                    Name = "James",
                    Description = "Product owner",
                    Gender = Gender.Other,
                    Jobs = new()
                    {
                        "Product owner", "Leader", "Other"
                    },
                    HasJob = true,
                    Birthdate = DateOnly.Parse("2002-8-12"),
                    StartWorkAt = DateTime.Now.AddYears(-1)
                }
            };
        }
    }
}
