namespace WaferLineLib { 
  
  public class Wafer { 
  static int last_wn; 
  readonly int wn; 
  int[] cells = new int[100]; 
  int now; 
  
  public Wafer() { 
  last_wn++; 
  wn = last_wn; 
  }  
  public int Now { 
  get { return now; } 
  } 
  public bool Increment() 
  { 
    if (now < 100) 
    { 
      now++; 
      if (now == 100) 
      { 
        return false; 
      } 
      return true; 
    } 
    return false; 
  } 
   public void Coating(int quality) 
   { 
     if (Now < 100) 
     { 
       cells[Now] = quality; 
     } 
   } 
    public int this[int index] 
    { 
      get 
      { 
        if ((index < 0) || (index >= 100)) 
        { 
          return 0; 
        } 
        return cells[index]; 
      } 
    }
    public double Quality 
    { 
      get 
      { 
        int sum = 0; 
        foreach (int elem in cells) 
        { 
          sum += elem; 
        } 
        return sum / 100.0; } 
    }
    public override string ToString() 
    { 
      return string.Format("No:{0}, Quality:{1}", wn, Quality); 
    } 
  } 
}

