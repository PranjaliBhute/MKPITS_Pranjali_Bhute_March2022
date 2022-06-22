#include<stdio.h>
#include<conio.h>
int main()
{
	int a,b,c;
	printf("Enter first no. ");
	scanf("%d",&a);
	printf("Enter second no. ");
	scanf("%d",&b);
	if(a==b)
	{
		c=(a+b)*3;
	}
	else
	{
		c=a+b;
	}
	printf("Sum of two no. is %d",c);
}