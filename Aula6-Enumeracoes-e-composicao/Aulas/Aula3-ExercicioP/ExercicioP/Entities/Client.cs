namespace ExercicioP.Entities
{
    public class Client
    {
        public string Name {get; private set;}
        public string Email{get; private set;}
        public DateTime BirthDate {get; private set;}

        public Client(string name, string email, string birthDate){
            Name = name;
            Email = email;
            BirthDate = DateTime.Parse(birthDate);
        }
    }
}
