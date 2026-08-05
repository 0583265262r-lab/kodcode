using VehicleFleetRegistryAPI.Enums;
using VehicleFleetRegistryAPI.Models;

namespace VehicleFleetRegistryAPI.Data
{
    public class VehicleData
    {
       public List<Vehicle> vehicles = new()
{
    new Vehicle { Id = 1, RegistrationNumber = "IL50001", VehicleType = "Toyota Corolla", Status = Status.Available, AssignedDriver = "David Cohen", CurrentLocation = "Jerusalem", Mileage = 12000 },
    new Vehicle { Id = 2, RegistrationNumber = "IL50002", VehicleType = "Ford Transit", Status = Status.InUse, AssignedDriver = "Moshe Levi", CurrentLocation = "Tel Aviv", Mileage = 45000 },
    new Vehicle { Id = 3, RegistrationNumber = "IL50003", VehicleType = "Hyundai i30", Status = Status.Maintenance, AssignedDriver = "Yossi Bar", CurrentLocation = "Haifa", Mileage = 87000 },
    new Vehicle { Id = 4, RegistrationNumber = "IL50004", VehicleType = "Kia Sportage", Status = Status.Decommissioned, AssignedDriver = "Avi Shalom", CurrentLocation = "Ashdod", Mileage = 190000 },
    new Vehicle { Id = 5, RegistrationNumber = "IL50005", VehicleType = "Mitsubishi L200", Status = Status.Available, AssignedDriver = "Noam David", CurrentLocation = "Beer Sheva", Mileage = 33000 },

    new Vehicle { Id = 6, RegistrationNumber = "IL50006", VehicleType = "Mazda 3", Status = Status.InUse, AssignedDriver = "Eitan Green", CurrentLocation = "Netanya", Mileage = 62000 },
    new Vehicle { Id = 7, RegistrationNumber = "IL50007", VehicleType = "Volkswagen Golf", Status = Status.Available, AssignedDriver = "Daniel Ron", CurrentLocation = "Rishon LeZion", Mileage = 21000 },
    new Vehicle { Id = 8, RegistrationNumber = "IL50008", VehicleType = "Mercedes Sprinter", Status = Status.Maintenance, AssignedDriver = "Omer Tal", CurrentLocation = "Petah Tikva", Mileage = 98000 },
    new Vehicle { Id = 9, RegistrationNumber = "IL50009", VehicleType = "Nissan XTrail", Status = Status.Decommissioned, AssignedDriver = "Amit Levi", CurrentLocation = "Eilat", Mileage = 230000 },
    new Vehicle { Id = 10, RegistrationNumber = "IL50010", VehicleType = "Ford Ranger", Status = Status.InUse, AssignedDriver = "Ron Azulay", CurrentLocation = "Holon", Mileage = 57000 },

    new Vehicle { Id = 11, RegistrationNumber = "IL50011", VehicleType = "Toyota Hilux", Status = Status.Available, AssignedDriver = "Yair Cohen", CurrentLocation = "Rehovot", Mileage = 28000 },
    new Vehicle { Id = 12, RegistrationNumber = "IL50012", VehicleType = "Iveco Daily", Status = Status.Maintenance, AssignedDriver = "Lior Shani", CurrentLocation = "Modiin", Mileage = 115000 },
    new Vehicle { Id = 13, RegistrationNumber = "IL50013", VehicleType = "Skoda Octavia", Status = Status.InUse, AssignedDriver = "Bar Peretz", CurrentLocation = "Ashkelon", Mileage = 76000 },
    new Vehicle { Id = 14, RegistrationNumber = "IL50014", VehicleType = "Honda Civic", Status = Status.Available, AssignedDriver = "Yuval Mor", CurrentLocation = "Kfar Saba", Mileage = 17000 },
    new Vehicle { Id = 15, RegistrationNumber = "IL50015", VehicleType = "Jeep Wrangler", Status = Status.Decommissioned, AssignedDriver = "Itay Cohen", CurrentLocation = "Raanana", Mileage = 290000 },

    new Vehicle { Id = 16, RegistrationNumber = "IL50016", VehicleType = "Renault Kangoo", Status = Status.InUse, AssignedDriver = "Gil Bar", CurrentLocation = "Bat Yam", Mileage = 65000 },
    new Vehicle { Id = 17, RegistrationNumber = "IL50017", VehicleType = "Peugeot Partner", Status = Status.Available, AssignedDriver = "Nir Dayan", CurrentLocation = "Lod", Mileage = 34000 },
    new Vehicle { Id = 18, RegistrationNumber = "IL50018", VehicleType = "Volvo Truck", Status = Status.Maintenance, AssignedDriver = "Shai Levi", CurrentLocation = "Ramla", Mileage = 125000 },
    new Vehicle { Id = 19, RegistrationNumber = "IL50019", VehicleType = "Subaru Forester", Status = Status.InUse, AssignedDriver = "Erez Tal", CurrentLocation = "Nazareth", Mileage = 82000 },
    new Vehicle { Id = 20, RegistrationNumber = "IL50020", VehicleType = "Hyundai Tucson", Status = Status.Available, AssignedDriver = "Matan Gal", CurrentLocation = "Tiberias", Mileage = 25000 },

    new Vehicle { Id = 21, RegistrationNumber = "IL50021", VehicleType = "Toyota Yaris", Status = Status.Decommissioned, AssignedDriver = "Ariel Ron", CurrentLocation = "Afula", Mileage = 310000 },
    new Vehicle { Id = 22, RegistrationNumber = "IL50022", VehicleType = "Citroen Berlingo", Status = Status.Available, AssignedDriver = "Tal Cohen", CurrentLocation = "Karmiel", Mileage = 22000 },
    new Vehicle { Id = 23, RegistrationNumber = "IL50023", VehicleType = "MAN Truck", Status = Status.InUse, AssignedDriver = "Ori Ben", CurrentLocation = "Akko", Mileage = 92000 },
    new Vehicle { Id = 24, RegistrationNumber = "IL50024", VehicleType = "Chevrolet Captiva", Status = Status.Maintenance, AssignedDriver = "Guy Levi", CurrentLocation = "Hadera", Mileage = 118000 },
    new Vehicle { Id = 25, RegistrationNumber = "IL50025", VehicleType = "Kia Sorento", Status = Status.Available, AssignedDriver = "Eli Bar", CurrentLocation = "Herzliya", Mileage = 36000 },

    new Vehicle { Id = 26, RegistrationNumber = "IL50026", VehicleType = "Jeep Compass", Status = Status.InUse, AssignedDriver = "Oded Cohen", CurrentLocation = "Givatayim", Mileage = 77000 },
    new Vehicle { Id = 27, RegistrationNumber = "IL50027", VehicleType = "Seat Leon", Status = Status.Available, AssignedDriver = "Avi Ron", CurrentLocation = "Ramat Gan", Mileage = 19000 },
    new Vehicle { Id = 28, RegistrationNumber = "IL50028", VehicleType = "Scania Truck", Status = Status.Decommissioned, AssignedDriver = "Moshe Tal", CurrentLocation = "Kiryat Gat", Mileage = 340000 },
    new Vehicle { Id = 29, RegistrationNumber = "IL50029", VehicleType = "Fiat Ducato", Status = Status.Maintenance, AssignedDriver = "David Bar", CurrentLocation = "Sderot", Mileage = 105000 },
    new Vehicle { Id = 30, RegistrationNumber = "IL50030", VehicleType = "Ford Focus", Status = Status.InUse, AssignedDriver = "Yoni Levi", CurrentLocation = "Yavne", Mileage = 69000 },

    new Vehicle { Id = 31, RegistrationNumber = "IL50031", VehicleType = "Toyota Rav4", Status = Status.Available, AssignedDriver = "Rami Cohen", CurrentLocation = "Beit Shemesh", Mileage = 23000 },
    new Vehicle { Id = 32, RegistrationNumber = "IL50032", VehicleType = "Nissan Patrol", Status = Status.Maintenance, AssignedDriver = "Shlomi Bar", CurrentLocation = "Safed", Mileage = 97000 },
    new Vehicle { Id = 33, RegistrationNumber = "IL50033", VehicleType = "DAF Truck", Status = Status.InUse, AssignedDriver = "Amir Tal", CurrentLocation = "Nahariya", Mileage = 86000 },
    new Vehicle { Id = 34, RegistrationNumber = "IL50034", VehicleType = "Mazda CX5", Status = Status.Available, AssignedDriver = "Eyal Cohen", CurrentLocation = "Dimona", Mileage = 20000 },
    new Vehicle { Id = 35, RegistrationNumber = "IL50035", VehicleType = "Mercedes Vito", Status = Status.Decommissioned, AssignedDriver = "Nadav Levi", CurrentLocation = "Arad", Mileage = 295000 },

    new Vehicle { Id = 36, RegistrationNumber = "IL50036", VehicleType = "Toyota Land Cruiser", Status = Status.InUse, AssignedDriver = "Bar Cohen", CurrentLocation = "Or Yehuda", Mileage = 73000 },
    new Vehicle { Id = 37, RegistrationNumber = "IL50037", VehicleType = "Kia Picanto", Status = Status.Available, AssignedDriver = "Ron Tal", CurrentLocation = "Kiryat Ono", Mileage = 26000 },
    new Vehicle { Id = 38, RegistrationNumber = "IL50038", VehicleType = "Volvo FH", Status = Status.Maintenance, AssignedDriver = "Amit Bar", CurrentLocation = "Maalot", Mileage = 134000 },
    new Vehicle { Id = 39, RegistrationNumber = "IL50039", VehicleType = "Suzuki Jimny", Status = Status.InUse, AssignedDriver = "Erez Cohen", CurrentLocation = "Yokneam", Mileage = 79000 },
    new Vehicle { Id = 40, RegistrationNumber = "IL50040", VehicleType = "Audi A4", Status = Status.Available, AssignedDriver = "Lior Ben", CurrentLocation = "Nes Ziona", Mileage = 18000 },

    new Vehicle { Id = 41, RegistrationNumber = "IL50041", VehicleType = "Renault Master", Status = Status.Decommissioned, AssignedDriver = "Daniel Bar", CurrentLocation = "Kiryat Shmona", Mileage = 360000 },
    new Vehicle { Id = 42, RegistrationNumber = "IL50042", VehicleType = "Ford Transit", Status = Status.Available, AssignedDriver = "Yossi Levi", CurrentLocation = "Beit Shean", Mileage = 31000 },
    new Vehicle { Id = 43, RegistrationNumber = "IL50043", VehicleType = "Isuzu Truck", Status = Status.InUse, AssignedDriver = "Moti Cohen", CurrentLocation = "Rosh HaAyin", Mileage = 95000 },
    new Vehicle { Id = 44, RegistrationNumber = "IL50044", VehicleType = "Hyundai Santa Fe", Status = Status.Maintenance, AssignedDriver = "Avi Bar", CurrentLocation = "Tirat Carmel", Mileage = 121000 },
    new Vehicle { Id = 45, RegistrationNumber = "IL50045", VehicleType = "Jeep Cherokee", Status = Status.Available, AssignedDriver = "Noam Levi", CurrentLocation = "Zichron Yaakov", Mileage = 28000 },

    new Vehicle { Id = 46, RegistrationNumber = "IL50046", VehicleType = "BMW 320", Status = Status.InUse, AssignedDriver = "Gil Cohen", CurrentLocation = "Jerusalem", Mileage = 56000 },
    new Vehicle { Id = 47, RegistrationNumber = "IL50047", VehicleType = "Volkswagen Caddy", Status = Status.Available, AssignedDriver = "Eitan Bar", CurrentLocation = "Tel Aviv", Mileage = 23000 },
    new Vehicle { Id = 48, RegistrationNumber = "IL50048", VehicleType = "Hino Truck", Status = Status.Maintenance, AssignedDriver = "Yuval Levi", CurrentLocation = "Haifa", Mileage = 145000 },
    new Vehicle { Id = 49, RegistrationNumber = "IL50049", VehicleType = "Land Rover", Status = Status.Decommissioned, AssignedDriver = "Moshe Cohen", CurrentLocation = "Eilat", Mileage = 390000 },
    new Vehicle { Id = 50, RegistrationNumber = "IL50050", VehicleType = "Mitsubishi Pajero", Status = Status.InUse, AssignedDriver = "David Levi", CurrentLocation = "Beer Sheva", Mileage = 65000 }
};
    }
}
