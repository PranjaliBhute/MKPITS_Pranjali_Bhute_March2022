#include<stdio.h>
#include<conio.h>
int main()
{
	int n,x=51,diff;
	printf("Enter the number ");
	scanf("%d",&n);
	if(n>x)
	{
		diff= (n-x)*3;
	}
	else
	{
		diff= (x-n);
	}
	printf("Absolute difference is %d ",diff);
}