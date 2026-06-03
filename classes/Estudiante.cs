public class Estudiante{
  private string nombre;

  private int primerParcial;
  private int segundoParcial;
  private int tercerParcial;

  private int calificacionMaestro;

  private int promedio;

  public int PrimerParcial{
    get {return primerParcial;}
    set{
      if(value < 0 || value > 15){
        Console.WriteLine("Debe de asignar una calificacion valida.")
          return;
      }

      primerParcial = value;
    }
  }

  public int SegundoParcial{
    get {return segundoParcial;}
    set{
      if(value < 0 || value > 15){
        Console.WriteLine("Debe de asignar una calificacion valida.")
          return;
      }

      segundoParcial = value;
    }
  }

  public int tercerParcial{
    get {return tercerParcial;}
    set{
      if(value < 0 || value > 15){
        Console.WriteLine("Debe de asignar una calificacion valida.")
          return;
      }

      tercerParcial = value;
    }
  }

  public int calificacionMaestro{
    get {return calificacionMaestro;}
    set{
      if(value < 0 || value > 40){
        Console.WriteLine("Debe de asignar una calificacion valida.")
          return;
      }

      calificacionMaestro = value;
    }
  }

  public int Promedio{
    get{return promedio;}
  }
}
