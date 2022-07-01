#include<stdio.h>
#include<conio.h>
int main()
{
	int a,b,c;
	printf("Enter first number ");
	scanf("%d",&a);
	printf("Enter second number ");
	scanf("%d",&b);
	printf("Enter third number ");
	scanf("%d",&c);
	if(a>=20 && a<=50 || b>=20 && b<=50 || c>=20 && c<=50)
	{
		printf("True");
	}
	else
	{
		printf("False");
	}
}