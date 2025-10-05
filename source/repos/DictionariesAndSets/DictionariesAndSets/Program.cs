
var students = new Dictionary<string, string>
{
    {"St10402790", "Reaobaka Ntoagae" },
    {"St10302790", "Olebogeng Malatji" },
    {"St10202790", "Mokgaeetsi Sethole" }
};

var courseCodes = new HashSet<string> { "PROG7314", "PROG7312", "INSY7315", "INSY7314" };

var list = courseCodes.ToList();


Console.WriteLine(students["St10402790"]);


for (int i =0; i < list.Count; i++)
{
    Console.WriteLine(list[i]);
}

var mathStudents = new HashSet<string> { "Reaoleboga Masenya", "Thato Matlala", "Boipelo Seleka", "Kaiso Seleka"};
var scienceStudents = new HashSet<string> { "Lesedi Mafe", "Kaiso Seleka", "Lerato Ntja", "Khoza Msimango" };


var union = new HashSet<string>(mathStudents);
union.UnionWith(scienceStudents);
Console.WriteLine("Union: " + string.Join(", ", union));


var intersection = new HashSet<string>(mathStudents);
intersection.IntersectWith(scienceStudents);
Console.WriteLine("Intersection: " + string.Join(", ", intersection));


var difference = new HashSet<string>(mathStudents);
difference.ExceptWith(scienceStudents);
Console.WriteLine("Difference (Math - Science): " + string.Join(", ", difference));
