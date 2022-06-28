using System;
public class Kata
{
    public static int[] Flip(char dir, int[] arr)
    {
      Array.Sort(arr);
      if(dir == 'R'){
        return arr;
      }else{
        Array.Reverse(arr);
        return arr;
    }
  }
}