using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqHomework.Enums;

namespace LinqHomework
{
    public class VirtualDatabase
    {
        public static List<Car> carsList = new List<Car>()
        {
            new Car()
            {
                City="Baku",
                Brand="Kia",
                Model="Picanto",
                Year= 2006,
                Transmission=Transmissions.Manual,
                Color=Colors.Blue,
                EngineCapacity=3500,
                KmUsed=2400,
                Horsepower=420,
                Price=8500
            },
            new Car()
            {
                City="Sumqayıt",
                Brand="Nissan",
                Model="Jukeml",
                Year= 2018,
                Transmission=Transmissions.Automatic,
                Color=Colors.Red,
                EngineCapacity=4700,
                KmUsed=0,
                Horsepower=350,
                Price=16000
            },
            new Car()
            {
                City="Baki",
                Brand="Toyota",
                Model="RAV4",
                Year= 2022,
                Transmission=Transmissions.Automatic,
                Color=Colors.Green,
                EngineCapacity=3400,
                KmUsed=2600,
                Horsepower=300,
                Price=17000
            },
            new Car()
            {
                City="Bakı",
                Brand="Lexus",
                Model="GX460",
                Year= 2021,
                Transmission=Transmissions.Automatic,
                Color=Colors.Black,
                EngineCapacity= 4500,
                KmUsed=26000,
                Horsepower=296,
                Price=57000
            },
            new Car()
            {
                City="Bakı",
                Brand="Mercedes",
                Model="GLE 63 AMG S 4Matic+ Coupe",
                Year= 2016,
                Transmission=Transmissions.Robot,
                Color=Colors.Black,
                EngineCapacity= 4170,
                KmUsed=26000,
                Horsepower=296,
                Price=10000
            }
        };
    }
}
