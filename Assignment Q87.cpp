#include<stdio.h>
#include<conio.h>
main()
{
	int num1,num2,l1,l2;
	printf("Enter 1st number ");
	scanf("%d",&num1);
	printf("Enter 2nd number ");
	scanf("%d",&num2);
	l1=num1%10;
	l2=num2%10;
	if(l1==l2)
	{
	    printf("Last digit are same ");
    }
	else
	{
		printf("Last digit are not same ");
	}
	
}	
