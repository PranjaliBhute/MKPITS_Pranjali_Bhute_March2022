#include<stdio.h>
#include<conio.h>
int main()
{
	int a,b;
	printf("Enter first no. ");
	scanf("%d",&a);
	printf("Enter second no. ");
	scanf("%d",&b);
	if(a==30||b==30||a+b==30)
	{
		printf("True");
	}
	else
	{
		printf("False");
	}
}