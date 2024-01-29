using MeuhedetDentist.Entities;

namespace MeuhedetDentist
{
    public class DataContext
    {
        public List<clients> clients = new List<clients>();
        public List<doctors> doctors = new List<doctors>();
        public List<turns> turns = new List<turns>();

        public DataContext()
        {
            clients = new List<clients>
            {
                 new clients { IdClient = 123, NameClient = "Hadas", AgeClient = 20 ,AdressClient="Bnei Brak Makover 15"},
                 new clients { IdClient = 121, NameClient = "Avishag", AgeClient = 18,AdressClient="Bnei Brak Pinkas 8" },
                 new clients { IdClient = 323, NameClient = "Ruthi", AgeClient = 5,AdressClient="Beit Shemesh Beri 10" }
            };

            doctors = new List<doctors>
            {
                new doctors {IdDoctors=222,NameDoctors="Dan",SalaryDoctors=700,HoursDoctors=8 },
                new doctors {IdDoctors=333,NameDoctors="Levi",SalaryDoctors=900,HoursDoctors=6 },
                new doctors {IdDoctors=444,NameDoctors="Binyamin",SalaryDoctors=1200,HoursDoctors=7 }
            };

            turns = new List<turns>
            {
                 new turns {NumTurn = 1,IsAvailableTurn = true,DateTimeTurn = new DateTime(2022,12,22), NumRoom=03},
                 new turns {NumTurn = 2,IsAvailableTurn = false,DateTimeTurn = new DateTime(2022,12,22), NumRoom=03},
                 new turns {NumTurn = 3,IsAvailableTurn = true,DateTimeTurn = new DateTime(2021,11,05), NumRoom=04},
            };
        }
    }
}
