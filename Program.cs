﻿int x1 = 1;
int y1 = 2;
int z1 = 3;

int x2 = 5;
int y2 = 6;
int z2 = 7;

double result = Math.Sqrt( Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
result = Math.Round(result, 3);
Console.WriteLine(result); 