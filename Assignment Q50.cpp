#include<stdio.h> 
#include<conio.h>
int main() 
{
  double inch, cm;
  printf("Input the distance in centimeter:\n");
  scanf("%lf", &cm);
  inch = cm / 2.54;
  printf("Distance of %0.2lf cms is = %0.2lf inches\n", cm, inch);
  return 0;
}
