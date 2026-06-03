using System.Collections.Generic;

public class Student {
  public static int lastId;
  private int _id = 0;
  private string name;
  private string surname;
  private Dictionary<string, Grade> grades = [];

  public Student(string name, string surname){
    this.name = name;
    this.surname = surname;

    lastId+=1;
    _id = lastId;
  }

  public Dictionary<string, Grade> GetGrades(){
     return grades.ToDictionary();
  }

  public Grade? GetGrade(string gradeKey){
    try{
      return grades[gradeKey];
    }
    catch(Exception e){
      Console.WriteLine(e.Message);
      return null;
    }
  }

  public void AddGrade(string gradeKey, Grade grade){
    bool gradeKeyExists = grades.Keys.Contains(gradeKey);

    if(gradeKeyExists){
      Console.WriteLine("This key is already use for another grade, try another key.");
      return;
    }

    bool gradeExists = grades.Values;
    
    if()
      grades.Add(gradeKey, grade);
  }

  public void UpdateGrade(string gradeKey, Grade grade){
    bool gradeExists = grades.Keys.Contains(gradeKey);

    if(!gradeExists){
      Console.WriteLine("Please, provide a valide grade key");
      return;
    }

    grades[gradeKey] = grade;
  }

  public string Name {
    get { return name;}
  }

  public string Surname {
    get {return surname;}
  }

  public string FullName {
    get { return $"{name} {surname}";}
  }

  public int _ID {
    get {
      return _id;
    }
  }

  public int Promedio{
    get {
      int total = 0;

      foreach(KeyValuePair<string,Grade> g in grades){
        total += g.Value.Total;
      }

      int promedio = total/(grades.Count);

      return promedio;
    }
  }
}
