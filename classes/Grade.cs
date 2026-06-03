public class Grade{
  private int subjectId;

  private int firstTest = 0;
  private int secondTest = 0;
  private int thirdTest = 0;
  private int professorJudment = 0;

  public Grade(int subjectId){
    this.subjectId = subjectId;
  }

  public int Subject{
    get{
      return subjectId;
    }
  }
  public int FirstTest { 
    get { return firstTest;}
    set { 
      if(value < 0 || value > 15){
        Console.WriteLine("You can only set calification between 0 and 15.");
      }

      firstTest = value;
    }
  }


  public int SecondTest { 
    get { return SecondTest;}
    set { 
      if(value < 0 || value > 15){
        Console.WriteLine("You can only set calification between 0 and 15.");
      }

      SecondTest = value;
    }
  }

  public int ThirdTest { 
    get { return thirdTest;}
    set { 
      if(value < 0 || value > 15){
        Console.WriteLine("You can only set calification between 0 and 15.");
      }

      thirdTest = value;
    }
  }

  public int ProfessorJudment { 
    get { return professorJudment;}
    set { 
      if(value < 0 || value > 40){
        Console.WriteLine("You can only set calification between 0 and 40.");
      }

      professorJudment = value;
    }
  }

  public int Total{
    get{  return firstTest + secondTest + thirdTest + professorJudment;}
  }

}

