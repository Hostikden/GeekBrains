int s = -1;
int res = s switch
{
  >= 10 => 1,
  <= -10 => 2,
  1 or -1 => 3,
  >= 2 and <= 9 => 4,
  not -3 => 5,
  _ => 0
};
Console.WriteLine(res);