#include<stdio.h>
#include<conio.h>
main()
{
	int num,r;
	printf("Enter any number");
	scanf("%d",&num);
	r=num%4;
	if(r==0)
	{
		printf("Division by 4");
	}
	if(r!=0)
	{
		printf("Not Division by 4");
	}
}