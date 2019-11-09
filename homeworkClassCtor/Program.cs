using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Описать класс Room, описывающий номер в отеле.Должны быть следующие поля:
//количество комнат (по умолчанию одна)
//время, на который снят номер(по умолчанию на сутки)
//ФИО клиента(по умолчанию во всех полях "неведомо")
//Свойства, связанные с каждым полем
//Метод для отображения состояния объекта.
//Для каждого варианта описать перегруженный конструктор.

//В main реализовать инициализацию объекта в зависимости от заполнения полей.


class Room
{
    private int roomCount;
    public int RoomCount
    {
        get
        {
            return roomCount;
        }
        set
        {
            roomCount = value;
        }
    }
    private int timeRent;
    public int TimeRent
    {
        get
        {
            return timeRent;
        }
        set
        {
            timeRent = value;
        }
    }

    Name name;

    class Name
    {
        public string firstName;
        public string lastName;
        public string middleName;
        public Name(string firstName, string lastName, string middleName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.middleName = middleName;
        }
        private Name()
        {
        }
    }
    public Room() : this(1)
    {
    }
    public Room(int roomCount) : this(roomCount, 24)
    {
    }
    public Room(int roomCount, int timeRent) : this(roomCount, timeRent, "неведомо")
    {
    }
    public Room(int roomCount, int timeRent, string firstName) : this(roomCount, timeRent, firstName, "неведомо")
    {
    }
    public Room(int roomCount, int timeRent, string firstName, string lastName) : this(roomCount, timeRent, firstName, lastName, "неведомо")
    {
    }
    public Room(int roomCount, int timeRent, string firstName, string lastName, string middleName)
    {
        RoomCount = roomCount;
        TimeRent = timeRent;
        name = new Name(firstName, lastName, middleName);
    }
    public override string ToString()
    {
        return $"NumberOfRoom: {RoomCount}, TimeOfRent: {TimeRent}, firstName: {name.firstName}, lastName: {name.lastName}, middleName: {name.middleName}";
    }
}
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Room room = new Room();
            Console.WriteLine(room.ToString());
            Room room1 = new Room(5);
            Console.WriteLine(room1.ToString());
            Room room2 = new Room(6, 48);
            Console.WriteLine(room2.ToString());
            Room room3 = new Room(7, 32, "Riven");
            Console.WriteLine(room3.ToString());
            Room room4 = new Room(9, 15, "Oriana", "Piltower");
            Console.WriteLine(room4.ToString());
            Room room5 = new Room(10, 20, "Teemo", "Yordle", "LeagueOfLegends");
            Console.WriteLine(room5.ToString());
        }
    }
}
