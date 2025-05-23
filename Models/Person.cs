using System.ComponentModel;

namespace BlazorGenericTable.MA.UseCase.Client.Models
{
    public class Person
    {
        [DisplayName("Column Number")]
        public int Id { get; set; }
        [DisplayName("Fullname")]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Gender Gender { get; set; }
        public List<string> Jobs { get; set; } = new();
        public bool HasJob { get; set; }
        public DateOnly Birthdate { get; set; }
        public DateTime StartWorkAt { get; set; }

        public override bool Equals(object obj)
        {

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Person newValue = (Person)obj;
            if (Id == newValue.Id && Name == newValue.Name && Description == newValue.Description &&
                Gender == newValue.Gender && Jobs.SequenceEqual(newValue.Jobs) &&
                HasJob == newValue.HasJob)
            {
                return true;
            }

            return false;
        }
    }
}
