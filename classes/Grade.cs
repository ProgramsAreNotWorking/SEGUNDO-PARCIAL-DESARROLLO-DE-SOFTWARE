public class Grade{
  private Subject subject;

  private int firstTest = 0;
  private int secondTest = 0;
  private int thirdTest = 0;
  private int professorJudment = 0;

  private Subject setSubject(Subject sub){
    subject = sub;
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

  public int thirdTest { 
    get { return thirdTest;}
    set { 
      if(value < 0 || value > 15){
        Console.WriteLine("You can only set calification between 0 and 15.");
      }

      thirdTest = value;
    }
  }

  public int professorJudment { 
    get { return professorJudment;}
    set { 
      if(value < 0 || value > 40){
        Console.WriteLine("You can only set calification between 0 and 40.");
      }

      professorJudment = value;
    }
  }

  public int total{
    get{  return firstTest + secondTest + thirdTest + professorJudment;}
  }

}

