using System.Collections.Generic;

public class Database{
  public static Database database;

  private Dictionary<int,Student> students;
  private Dictionary<int,Grade> grades;
  private Dictionary<int,Subject> subjects;

  private Database(){
  }

  public static Database GetDatabase(){
    if(database == null)
      database = new Database();

    return database;
  }

  //Students section
  public Dictionary<int,Student> GetStudents() {
    return students.ToDictionary();
  }

  public int AddStudent(Student student) {
    KeyValuePair<int, Student> lastStudent = students.Last();
    students.Add(lastStudent.Key + 1, student);
    return lastStudent.Key;
  }

  public void DeleteStudent(int key){
    students.Remove(key);
  }


  //Grades section
  public Dictionary<int,Grade> GetGrades() {
    return grades.ToDictionary();
  }

  public int AddGrade(Grade grade) {
    KeyValuePair<int, Grade> lastGrade = grades.Last();
    grades.Add(lastGrade.Key + 1, grade);
    return lastGrade.Key;
  }

  public void DeleteGrade(int key){
    try{

    grades.Remove(key);
    }
    catch( Exception e){
      Console.WriteLine(e.Message);
    }
  }

  public void UpdateGrade(int key, Grade value){
    try{
      grades[key] = value;
    }
    catch(Exception e){
      Console.WriteLine(e.Message);
    }
  }


  //Subjects section
  public Dictionary<int, Subject> GetSubject() {
    return subjects.ToDictionary();
  }

  public int AddSubject(Subject subject) {
    KeyValuePair<int, Subject> lastSubject = subjects.Last();
    subjects.Add(lastSubject.Key + 1, subject);
    return lastSubject.Key;
  }

  public void DeleteSubject(int key){
    subjects.Remove(key);
  }
}
