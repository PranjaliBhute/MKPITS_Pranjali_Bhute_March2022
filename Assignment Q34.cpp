#include<stdio.h>
#include<conio.h>
main()
{
	int num1,num2;
	printf("Enter any two number ");
	scanf("%d%d",&num1,&num2);
	if(num1%num2==0)
	{
		printf("Division is possible ");
	}
	else
	{
		printf("Division is not possible ");
	}
}