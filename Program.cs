using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProgrammingLanguages
{
  class Program
  {
    static void Main()
    {
      List<Language> languages = File.ReadAllLines("./languages.tsv")
        .Skip(1)
        .Select(line => Language.FromTsv(line))
        .ToList();
      PrettyPrintAll(languages);
      foreach(var item in languages)
      {
  //      Console.WriteLine(item.Prettify());
      }
      var lan = languages.Select(lan => $"Year is {lan.Year} Name is {lan.Name} Chief Developer is {lan.ChiefDeveloper}");
    //  PrintAll(lan);
      

      var cSharp = from l in languages
        where l.Name.Contains("C#")
        select l.Prettify();
  //    PrintAll(cSharp);
     

      var microsoft = from q in languages
        where q.ChiefDeveloper.Contains("Microsoft")
        select q.Prettify();
//      PrintAll(microsoft);
     

      var lisp = from li in languages
        where li.Predecessors.Contains("Lisp")
        select li.Prettify();
     // PrintAll(lisp);
      
      var script = from s in languages
        where s.Name.Contains("Script")
        select s.Prettify();
   //   PrintAll(script);
     
      
    //  Console.WriteLine(languages.Count());
     // Console.WriteLine(languages.Where(c => c.Year>=1995 && c.Year <=2005).Count());
      var nearM = languages.Where(c => c.Year>=1995 && c.Year <=2005).Select(c => $"{c.Name} was invented in {c.Year}");
  //    PrintAll(nearM);


    }
    public static void PrettyPrintAll(IEnumerable<Language> langs)
    {
      foreach(var item in langs)
      {
        Console.WriteLine(item.Prettify());
      }
    }
    public static void PrintAll(IEnumerable<Object> obs)
    {
      foreach(var item in obs)
      {
        Console.WriteLine(item);
      }
    }
  }
}
