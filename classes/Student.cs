using System.Collections.Generic;

public class Student {
  public static int lastId;
  private int _id = 0;
  private string name;
  private string surname;
  private Dictionary<int, Grade> grades = new Dictionary<int, Grade>();

  public Student(string name, string surname){
    this.name = name;
    this.surname = surname;

    lastId+=1;
    _id = lastId;
  }

  public Dictionary<int, Grade> GetGrades(){
     return grades.ToDictionary();
  }

  public Grade? GetGrade(int gradeKey){
    try{
      return grades[gradeKey];
    }
    catch(Exception e){
      Console.WriteLine(e.Message);
      return null;
    }
  }

  public void AddGrade(Grade grade){
    bool gradeKeyExists = grades.ContainsKey(grade.Subject);

    if(gradeKeyExists){
      Console.WriteLine("This grade is already set.");
      return;
    }
      grades.Add(grade.Subject, grade);
  }

  public void UpdateGrade(Grade grade){
    bool gradeExists = grades.ContainsKey(grade.Subject);

    if(!gradeExists){
      Console.WriteLine("Please, provide a valide grade key");
      return;
    }

    grades[grade.Subject] = grade;
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

      foreach(KeyValuePair<int,Grade> g in grades){
        total += g.Value.Total;
      }

      int promedio = total/(grades.Count);

      return promedio;
    }
  }
}
