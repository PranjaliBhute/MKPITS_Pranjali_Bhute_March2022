#include<stdio.h>
#include<conio.h>
main()
{
	int choice,num1,num2,res;
	printf("Press 1 for Addition");
	printf("\nPress 2 for Subtraction");
	printf("\nPress 3 for Multiplication");
	printf("\nPress 4 for Division");
	printf("\nEnter your choice ");
	scanf("%d",&choice);
	if(choice==1)
	{
		printf("Enter two numbers ");
		scanf("%d%d",&num1,&num2);
		res=num1+num2;
		printf("Addition of two numbers is %d",res);
	}
	else
	if(choice==2)
	{
		printf("Enter two numbers ");
		scanf("%d%d",&num1,&num2);
		res=num1-num2;
		printf("Subtraction of two numbers is %d",res);
	}
	else
	if(choice==3)
	{ 
	    printf("Enter two numbers ");
	    scanf("%d%d",&num1,&num2);
		res=num1*num2;
		printf("Multiplication of two numbers is %d",res);
	}
	else
	if(choice==4)
	{
		printf("Enter two numbers ");
		scanf("%d%d",&num1,&num2);
		res=num1/num2;
		printf("Division of two numbers is %d",res);
	}
	else
	printf("Invalid choice");
	
}