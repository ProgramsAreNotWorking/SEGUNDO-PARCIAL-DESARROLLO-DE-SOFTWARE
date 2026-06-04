using System.Collections.Generic;

public class Database{
  public static Database database = new Database();

  private Dictionary<int,Student> students = [];
  private Dictionary<int,Subject> subjects = [];

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

  public void AddStudent(Student student) {
    students.Add(student._ID, student);
  }

  public void DeleteStudent(int key){
    students.Remove(key);
  }

  //Subjects section
  public Dictionary<int, Subject> GetSubjects() {
    return subjects.ToDictionary();
  }

  public Subject? GetSubject(int subjectKey){
    try{
      return subjects[subjectKey];
    }
    catch(Exception e){
      Console.WriteLine(e.Message);
      return null;
    }
  }

  public void AddSubject(Subject subject) {
    subjects.Add(subject._ID, subject);
  }

  public void DeleteSubject(int key){
    subjects.Remove(key);
  }
}
