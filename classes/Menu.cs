using System.Collections.Generic;
public class Menu{
  private string menuWalls = "////////////////////////////////////////";
  private bool opened = true;
  public List<string> messages = [];
  private List<string> options = [];
  private List<Action> fallbacks = [];


  private int userInput;

  public void DrawMenu(){
    while(opened){

    Console.Clear();

    Console.WriteLine(menuWalls);

    //Draws menu's content;
    foreach(string message in messages){
      Console.WriteLine(message);
    }

    // Draw selectable options
    Console.WriteLine("Select Your option");

    for(int i = 1; i <= options.Count; i++){
      Console.WriteLine($"{i}-) {options[i-1]}");
    }

    Console.WriteLine(menuWalls);

    // -1 means there was ann error, 1 means everything is alright;
    try{
      userInput = int.Parse(Console.ReadLine());

      if(userInput < 1 || userInput > options.Count){
        Console.WriteLine(options.Count);
        Console.WriteLine("Please type a valide option");
        Console.ReadLine();
      }

      fallbacks[userInput - 1]();
      }
      catch(Exception e){
        Console.WriteLine(e.Message);
          Console.ReadLine();
      }
    }
  }

  public void SetOption(string option, Action fallback){
    options.Add(option);
    fallbacks.Add(fallback);
  }
}
