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
  } /// <summary> /// 코팅할 쉘 번호 증가시키기 /// </summary> /// <returns>증가 성공 여부</returns> public bool Increment() { if (now < 100) { now++; if (now == 100) { return false; } return true; } return false; } /// <summary> /// 코팅 메서드 /// </summary> /// <param name="quality">품질 수준</param> public void Coating(int quality) { if (Now < 100) { cells[Now] = quality; } } /// <summary> /// 특정 쉘의 품질 수준 인덱서 - 가져오기 /// </summary> /// <param name="index">쉘 인덱스</param> /// <returns>특정 쉘의 품질</returns> public int this[int index] { get { if ((index < 0) || (index >= 100)) { return 0; } return cells[index]; } } /// <summary> /// 평균 품질 - 가져오기 /// </summary> public double Quality { get { int sum = 0; foreach (int elem in cells) { sum += elem; } return sum / 100.0; } } /// <summary> /// ToString 메서드 재정의 /// </summary> /// <returns>Wafer 번호와 평균 품질</returns> public override string ToString() { return string.Format("No:{0}, Quality:{1}", wn, Quality); } } }

