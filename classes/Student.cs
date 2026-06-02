using System.Collections.Generic;
public class Student {
  private string name;
  private string surname;
  private LinkedList<Grade> grades = new LinkedList<Grade>([]);

  public Student(string name, string surname){
    this.name = name;
    this.surname = surname;
  }

  public Student(string name, string surname, int grades){
    this.name = name;
    this.surname = surname;
    this.grades = grades;
  }


  public Grade Grades{
    get { return grades}
    set {
      if(value < 0 || value > 100){
        Console.WriteLine("Invalide grade value. Grades can't be higher than 100, or less than 0.");
        return;

      }

      this.grades = value
    }
  }

  public void AddGrade(Grade grade){
    grades.add(grade);
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
