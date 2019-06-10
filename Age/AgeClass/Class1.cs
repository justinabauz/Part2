using System;

namespace VardasPavarde
{
    public class AgeClass
    {
        public AgeClass()
        {

        }

        public AgeClass(string vardas, string pavarde, DateTime gimimoMetai)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            GimimoMetai = gimimoMetai;

        }
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public DateTime GimimoMetai { get;  private set; }
        public int GetAge()
        { 
            var today = DateTime.Today;
            var age = today.Year - GimimoMetai.Year;
            if (GimimoMetai.Date > today.AddYears(-age)) 
            age--;

            return age;


        }

    }
}
