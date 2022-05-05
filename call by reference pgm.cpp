#include<stdio.h>
#include<conio.h>
void fun(int *x, int *y);
int main()
{
	int a=2,b=3;
	printf("a=%d b=%d",a,b);
	fun(&a,&b);
	printf("\na=%d b=%d",a,b);
}
 void fun(int *x, int *y)
{
  *x=12;
  *y=13;	
}