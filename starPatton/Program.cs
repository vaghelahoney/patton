using System.Text;

List<int> numbers = new List<int> { 1, 2, 3, 4 };

int total = numbers.Aggregate((acc, n) => acc + n);

List<(string Name, int Age)> people = new List<(string, int)>
{
    ("Sam", 25), ("Anna", 22)
};

var names5 = people.Select(p => p.Name);

var employees = new List<Employee>
{
    new Employee { Name = "Sam", Age = 25 },
    new Employee { Name = "Anna", Age = 22 }
};

var names5employees = employees.Select(p => p.Name);


List<string> names = new List<string> { "Sam", "Anna", "Alex", "Bob", "Ben" };

var groups = names.GroupBy(n => n[0]);

foreach (var group in groups)
{
    Console.WriteLine($"Letter: {group.Key}");
    foreach (var namess in group)
        Console.WriteLine($"  {namess}");

}

string name = "PRAKASHVAGHELARA";
StringBuilder sb = new StringBuilder();
for (int i = name.Length - 1; i >= 0 ; i--)
{
    sb.Append(name[i]);
}
Console.Write(sb.ToString());
Console.WriteLine("");

int nameLenght = 0;
for (int i = 0; nameLenght < name.Length; i++)
{
    for (int j = 1; (j <= i + 1 && nameLenght < name.Length); j++)
    {
        Console.Write(name[nameLenght]);
        nameLenght++;
    }
    Console.WriteLine("");
}

for (int i = 0; i <= 5; i++)
{
    for (int p = 0; p < i; p++)
    {
        Console.Write(" *");
    }
    Console.WriteLine("");
}

for (int i = 0; i <= 5; i++)
{
	for (int p = 0; p < i; p++)
	{
		Console.Write(" *");
	}
    Console.WriteLine("");
}

for (int i = 0; i <= 5; i++)
{
	for(int p = 5 ;p >= i; p--)
	{
		Console.Write(" *");
	}
	Console.WriteLine("");
}

for (int i = 0;i <= 5;i++)
{
	for (int p = 5; p >= i; p--)
	{
        Console.Write(" ");
    }
	for (int t = 0; t<=i;t++)
	{
        Console.Write("*");
    }
    Console.WriteLine("");
}

for (int i = 0; i <= 5; i++)
{
    for (int t = 0; t <= i; t++)
    {
        Console.Write(" ");
    }

    for (int p = 5; p >= i; p--)
    {
        Console.Write("*");
    }
    Console.WriteLine("");
}
Console.WriteLine("");

for (int i = 0;i<=5;i++)
{
    for (int s = 0; s <= i; s++)
    {
        Console.Write(" ");
    }
    for(int t = 0;t<=i;t++)
    {
        Console.Write("*"); 
    }
    Console.WriteLine("");
}

Console.WriteLine("");

for (int i = 0; i <= 5; i++)
{
    for (int s = 5; s >= i; s--)
    {
        Console.Write(" ");
    }
    for (int t = 0; t <= i; t++)
    {
        Console.Write(" *");
    }
    Console.WriteLine("");
}
var data = new List<int> { 1, 2,5, 3,5, 4, 3,5, 6, 7 ,9,2,1};

int secondHinghtValue = 0;
int secondHinght = data[0];

HashSet<int> removeDublicatevalue = new HashSet<int>(data);

for (int i = 0; i < removeDublicatevalue.Count(); i++)
{
    if (secondHinght <= data[i])
    {
        secondHinghtValue = data[i];
    }
}
Console.WriteLine("Second Hinght Value => " + secondHinghtValue);
Console.WriteLine("");
Dictionary<int, int> sameDublicateValue = new Dictionary<int, int>();

for (int i = 0; i < data.Count(); i++)
{
    if (sameDublicateValue.ContainsKey(data[i]))
    {
        sameDublicateValue[data[i]]++;
    }
    else
    {
        sameDublicateValue[data[i]] = 1;
    }
}

Console.WriteLine();
sameDublicateValue.Select(x => $"kay {x.Key} and value is {x.Value}").ToList().ForEach(Console.WriteLine);

Console.WriteLine();
List<List<int>> numberGroups = new List<List<int>>
{
    new List<int> { 1, 2, 3 },
    new List<int> { 4, 5 },
    new List<int> { 6 }
};
numberGroups.SelectMany(g => g).ToList().ForEach(Console.WriteLine);
// Output: 1, 2, 3, 4, 5, 6  (all in one list)
Console.WriteLine();

