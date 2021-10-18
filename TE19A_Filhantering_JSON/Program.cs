using System;
using System.IO;
using System.Text.Json;

// string hugo = File.ReadAllText("hugo.json");

// Fighter f1 = JsonSerializer.Deserialize<Fighter>(hugo);

// Console.WriteLine(f1.Name);





Fighter f1 = new Fighter()
{
  Name = "Hugo",
  Caring = 100,
  Huggability = 3
};

string hugo = JsonSerializer.Serialize<Fighter>(f1);

File.WriteAllText("hugo.json", hugo);

// Console.WriteLine(hugo);


// Console.WriteLine(f1.Name);




// string[] names = File.ReadAllLines("test.txt");

// Console.WriteLine(names[1]);


// // string t = File.ReadAllText("test.txt");

// // System.Console.WriteLine(t);

Console.ReadLine();


// string test = "Hello";

// string path = @"c:\test\";

// if (!Directory.Exists(path))
// {
//   Directory.CreateDirectory(path);
// }

// for (int i = 0; i < 10000; i++)
// {
//   FileStream file = File.Create(path + i);
//   file.Close();
// }
// File.WriteAllText("test.bat", "ECHO Hello");