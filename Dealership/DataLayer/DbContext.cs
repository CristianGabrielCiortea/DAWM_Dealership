using DataLayer.Entities;

namespace DataLayer
{
    public static class DbContext
    {
        public static List<Dealership> Dealerships = new List<Dealership>
        {
            new Dealership
            {
                Id = 1,
                Name = "DealerAuto Best Brasov",
                Address = "Brasov, Strada Vieru, numarul 25",
                Salesmen = new List<Salesman>
                {
                    new Salesman
                    {
                        Id = 1,
                        FirstName = "Adrian",
                        LastName = "Florentin",
                        Address = "Brasov, Strada Zicanului, numarul 12",
                        DateOfBirth = new DateTime(1994, 5, 20),
                        DealershipId = 1
                    },
                    new Salesman
                    {
                        Id = 2,
                        FirstName = "Cristian",
                        LastName = "Mihalcea",
                        Address = "Brasov, Strada Prosperului, numarul 2",
                        DateOfBirth = new DateTime(1985, 4, 13),
                        DealershipId = 1
                    },
                    new Salesman
                    {
                        Id = 1,
                        FirstName = "Adrian",
                        LastName = "Florentin",
                        Address = "Brasov, Strada Mircea cel Batran, numarul 1",
                        DateOfBirth = new DateTime(1978, 1, 19),
                        DealershipId = 1
                    }
                },
                Cars = new List<Car>
                {
                    new Car
                    {
                        Id = 1,
                        Make = "Audi",
                        Model = "A1",
                        Year = 2009,
                        Mileage = 0,
                        EngineSize = 2.5,
                        Color = Enums.Color.Black,
                        FuelType = Enums.FuelType.Diesel,
                        SalesmanId = 1,
                    },
                    new Car
                    {
                        Id = 1,
                        Make = "BMW",
                        Model = "M2",
                        Year = 2015,
                        Mileage = 0,
                        EngineSize = 3.0,
                        Color = Enums.Color.White,
                        FuelType = Enums.FuelType.Gasoline,
                        SalesmanId = 2
                    },
                    new Car
                    {
                        Id = 1,
                        Make = "Audi",
                        Model = "A3",
                        Year = 2010,
                        Mileage = 0,
                        EngineSize = 1.4,
                        Color = Enums.Color.Black,
                        FuelType = Enums.FuelType.Diesel,
                        SalesmanId = 3
                    }
                }
            },
            new Dealership
            {
                Id = 1,
                Name = "DealerAuto Bucuresti Expensive Cars",
                Address = "Bucuresti, Strada Pamantului, numarul 3",
                Salesmen = new List<Salesman>
                {
                    new Salesman
                    {
                        Id = 1,
                        FirstName = "Ionut",
                        LastName = "Constantin",
                        Address = "Bucuresti, Strada Iuliu-Maniu, numarul 12",
                        DateOfBirth = new DateTime(1977, 11, 20),
                        DealershipId = 2
                    },
                    new Salesman
                    {
                        Id = 2,
                        FirstName = "Cristian",
                        LastName = "Vladaut",
                        Address = "Bucuresti, Strada Sanzienelor, numarul 1",
                        DateOfBirth = new DateTime(1985, 4, 22),
                        DealershipId = 2
                    },
                    new Salesman
                    {
                        Id = 1,
                        FirstName = "Andrei",
                        LastName = "Dodolcut",
                        Address = "Bucuresti, Strada Mihai Blaga, numarul 5",
                        DateOfBirth = new DateTime(1978, 2, 8),
                        DealershipId = 2
                    }
                },
                Cars = new List<Car>
                {
                    new Car
                    {
                        Id = 1,
                        Make = "Audi",
                        Model = "A1",
                        Year = 2009,
                        Mileage = 0,
                        EngineSize = 2.5,
                        Color = Enums.Color.Black,
                        FuelType = Enums.FuelType.Diesel,
                        SalesmanId = 1,
                    },
                    new Car
                    {
                        Id = 1,
                        Make = "BMW",
                        Model = "M2",
                        Year = 2015,
                        Mileage = 0,
                        EngineSize = 3.0,
                        Color = Enums.Color.White,
                        FuelType = Enums.FuelType.Gasoline,
                        SalesmanId = 2
                    },
                    new Car
                    {
                        Id = 1,
                        Make = "Audi",
                        Model = "A3",
                        Year = 2010,
                        Mileage = 0,
                        EngineSize = 1.4,
                        Color = Enums.Color.Black,
                        FuelType = Enums.FuelType.Diesel,
                        SalesmanId = 3
                    }
                }
            }
        };

        public static List<Car> Cars = Dealerships.SelectMany(x => x.Cars).ToList();

        public static List<Salesman> Salesmen = Dealerships.SelectMany(x => x.Salesmen).ToList();
    }
}