#include<stdio.h>
#include<conio.h>
int main()
{
	int n;
	printf("Enter the number ");
	scanf("%d",&n);
	if(n%3==0 || n%7==0)
	{
		printf("True");
	}
	else
	{
		printf("False");
	}
}