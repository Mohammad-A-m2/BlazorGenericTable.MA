namespace Common.CRUD.UseCase.Client.Models.Data
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
                    HasJob = true
                },
                new()
                {
                    Id = 2,
                    Name = "Jenifer",
                    Description = "Leader",
                    Gender = Gender.Female,
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
                    HasJob = true
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
                    }
                },
                new()
                {
                    Id = 5,
                    Name = "Jena",
                    Description = "Leader",
                    Gender = Gender.Female,
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
                    HasJob = true
                }
            };
        }
    }
}
