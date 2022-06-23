#include<stdio.h>
#include<conio.h>
int main()
{
	int temp1,temp2;
	printf("Enter temperature 1 is ");
	scanf("%d",&temp1);
	printf("Enter temperature 2 is ");
	scanf("%d",&temp2);
	if(temp1<0 && temp2>100 || temp2<0 && temp1>100)
	{
		printf("True");
	}
	else
	{
		printf("False");
	}
}