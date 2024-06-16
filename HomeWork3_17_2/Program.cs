using HomeWork3_17_2;
using System.Diagnostics;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;

var cars = new List<Car> {
    new Car {
        Id = 1,
        Brand = "Audi",
        Model = "RS Q8",
        ProductionYear = 2022,
        Color = System.Drawing.Color.Black
    },
    new Car {
        Id = 2,
        Brand = "BMW",
        Model = "I7",
        ProductionYear = 2022,
        Color = System.Drawing.Color.Black
    }
    ,new Car {
        Id = 3,
        Brand = "Mersedes",
        Model = "C63",
        ProductionYear = 2022,
        Color = System.Drawing.Color.Black
    },
    new Car {
        Id = 4,
        Brand = "Aston Martin",
        Model = "DB11",
        ProductionYear = 2022,
        Color = System.Drawing.Color.Black
    }
};
var buyers = new List<Buyer> {
    new Buyer {
        CarId = 1,
        Name = "Jeremy Clarkson",
        PhoneNumber = "3213213"
    },
    new Buyer {
        CarId = 3,
        Name = "Richard Hammond",
        PhoneNumber = "3213213"
    },
    new Buyer {
        CarId = 4,
        Name = "James May",
        PhoneNumber = "3213213"
    }
};

var carModelToSearch = "RS Q8";

var searchResult = (
        from buyer in buyers
        join car in cars on buyer.CarId equals car.Id
        where car.Model == carModelToSearch
        select new {
            BuyerName = buyer.Name,
            BuyerPhone = buyer.PhoneNumber,
            Car = car
        }
    ).FirstOrDefault();

if (searchResult == null) {
    Console.WriteLine($"Не знайдено покупця для {carModelToSearch}");
}else {
    Console.WriteLine($"{searchResult.BuyerName}, ph.{searchResult.BuyerPhone}\r\n{searchResult.Car.Brand} {searchResult.Car.Model} {searchResult.Car.Color} ({searchResult.Car.ProductionYear})");
}
