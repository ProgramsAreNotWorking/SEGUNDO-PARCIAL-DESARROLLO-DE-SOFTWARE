using System.Collections.Generic;

public class Student {
  private string name;
  private string surname;
  private Dictionary<string, Grade> grades = [];

  public Student(string name, string surname){
    this.name = name;
    this.surname = surname;
  }

  public Dictionary<string, Grade> GetGrades(){
     return grades;
  }

  public void AddGrade(int gradeKey){
    bool result = Database.database.GetGrades().Keys.Contains(gradeKey);
    if(result){

    grades.add(grade);
    }

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
}
