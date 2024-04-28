class _02Method

{
  public static int Roll()
  {
    Random dice = new();
    return dice.Next(1, 7);
  }
}
