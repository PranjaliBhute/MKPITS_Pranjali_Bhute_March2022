#include<stdio.h>
#include<conio.h>
main()
{
	int p1,p2,p3;
	printf("Enter the age of 3 person");
	scanf("%d%d%d",&p1,&p2,&p3);
	if(p1>p2&&p1>p3)
	{
		printf("P1 is greater");
	}
	else
	if(p2>p1&&p2>p3)
	{
		printf("P2 is greater");
	}
	else
	if(p3>p1&&p3>p2)
	{
		printf("P3 is greater");
	}
}