#include<stdio.h>
#include<conio.h>
int main()
{
	int a,b;
	printf("Enter any pair of number ");
	printf("\nEnter first number of the pair ");
	scanf("%d",&a);
	printf("Enter second number of the pair ");
	scanf("%d",&b);
	if(a<b)
	{
		printf("The pair is in ascending order ");
	}
	else
	{
		printf("The pair is in decending order ");
	}
	
}