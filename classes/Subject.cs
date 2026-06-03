using System.Collections.Generic;

public class Subject
{
  public static int lastId = 0;
  private int _id;
    private string name;
    private Dictionary<int, Student> students;
    
    public Subject(string n){
      name = n;

      Subject.lastId += 1;
      _id = Subject.lastId;
    }

    public int _ID{
      get{
        return _id;
      }
    }

    public string Name {
      get{
        return name;
      }
    }

    public Dictionary<int, Student> GetStudents(){
      return students.ToDictionary();
    }

    public Student? GetStudent(int studentKey){
      try{
        return students[studentKey];
      }
      catch(Exception e){
        Console.WriteLine(e.Message);
        return null;
      }
    }

    public void AddStudent(Student student){
      
    }
}
