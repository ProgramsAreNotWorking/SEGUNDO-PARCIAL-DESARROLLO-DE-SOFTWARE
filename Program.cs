bool running = true;

MainMenu();

void MainMenu(){
  int? userInput;
  Menu menu = new Menu();

  menu.messages.Add("Welcome to Super Class Room!");

  menu.SetOption("Go to Students Menu", StudentMenu);
  menu.SetOption("Go to Subjects Menu", SubjectMenu);

  menu.SetOption("Close the app :(", () => {
      Environment.Exit(0);
  });

  menu.DrawMenu();
  // while(running){
  //   if(menu.DrawMenu() == -1){
  //     continue;
  //   }
  // }
}

void StudentMenu(){
  int? userInput;

  Menu menu = new Menu();

  menu.messages.Add("Welcome to Students Menu");

  menu.SetOption("Add Student", () => {

  });

  menu.SetOption("See students list", () => {
      Console.WriteLine("Students List");
      foreach(Student student in Database.database.GetStudents().Values){
        Console.WriteLine($"{student.Name} {student.Surname}:");

        foreach(Grade grade in student.GetGrades().Values){
          Subject subject = Database.database.GetSubject(grade.Subject);

          Console.Write($"{subject.Name}: ");

          Console.Write($"First Test-{grade.FirstTest} ");
          Console.Write($"Second Test-{grade.SecondTest} ");
          Console.Write($"Third Test-{grade.ThirdTest} ");
          Console.Write($"Professor Judment-{grade.ProfessorJudment} ");
        }
      }
      Console.ReadLine();
  });

  menu.SetOption("See student average", () => {

  });

  menu.SetOption("See students statistics", () => {

  });

  menu.SetOption("Add grades to student", () => {

  });

  menu.SetOption("Return to previews menu", MainMenu);

  menu.DrawMenu();
}

void SubjectMenu(){
  
} 
