// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//sort guests into tables by occupation --- need 2 tables
List<Guest> Table1 = new List<Guest>();
List<Guest> Table2 = new List<Guest>();

List<Guest> GuestList = new List<Guest>()

 {new Guest()
    {
      name = "Marilyn Monroe",
      occupation= "entertainer",
      bio= "(1926 - 1962) American actress, singer, model"
    },
     new Guest()
    {
      name= "Abraham Lincoln",
      occupation= "politician",
      bio= "(1809 - 1865) US President during American civil war"
    },
    new Guest()
    {
      name= "Martin Luther King",
      occupation= "activist",
      bio= "(1929 - 1968)  American civil rights campaigner"
    },
    new Guest()
    {
      name= "Rosa Parks",
      occupation= "activist",
      bio= "(1913 - 2005)  American civil rights activist"
    },
    new Guest()
    {
      name= "Peter Sellers",
      occupation= "entertainer",
      bio= "(1925 - 1980) British actor and comedian"
    },
    new Guest()
    {
      name= "Alan Turing",
      occupation= "computer scientist",
      bio= "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"
    },
    new Guest()
    {
      name= "Admiral Grace Hopper",
      occupation= "computer scientist",
      bio= "(1906–1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"
    },
    new Guest()
    {
      name= "Indira Gandhi",
      occupation= "politician",
      bio= "(1917 - 1984) Prime Minister of India 1966 - 1977",
    }
 };
//loop and conditional

GuestList.ForEach(guest => {
if (!Table1.Any(x => x.occupation == guest.occupation)){
    Table1.Add(guest);
} else {
    Table2.Add(guest);
}
});

Table1.ForEach(x => Console.WriteLine($"{x.occupation} {x.name}"));
Console.WriteLine("------------");
Table2.ForEach(x => Console.WriteLine($"{x.occupation} {x.name}"));
