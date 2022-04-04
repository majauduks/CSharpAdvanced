// See https://aka.ms/new-console-template for more information

#region ex1 

string flag = "a";
List<string> names = new List<string>();

while (flag != "x")
{
    Console.WriteLine("Enter a name");
    string name = Console.ReadLine();
    names.Add(name);

    Console.WriteLine("Do you want to add more names? If no - press 'x'");
    flag = Console.ReadLine().ToLower();


}

Console.WriteLine("Enter a sentence");
string sentence = Console.ReadLine();
string[] sentenceWords = sentence.Split(' ');

int[] freq = new int[names.Count];

foreach (string name in names)
{

  int countofname = sentenceWords.Where(x=> x==name.ToLower()).Count();
    Console.WriteLine($"The count of the name {name} is : {countofname}");
    
}

#endregion 





  














































