using System.Collections.Generic;

public class Database{
  public static Database database;

  private Dictionary<int,Student> students;
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

  public int AddSubject(Subject subject) {
    KeyValuePair<int, Subject> lastSubject = subjects.Last();
    subjects.Add(lastSubject.Key + 1, subject);
    return lastSubject.Key;
  }

  public void DeleteSubject(int key){
    subjects.Remove(key);
  }
}
