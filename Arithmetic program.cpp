#include<stdio.h>
#include<conio.h>
main()
{
	int choice, num1,num2,res;
	printf("press + for Addition");
	printf("\npress - for Subtraction");
	printf("\npress * fpr Multiplication");
	printf("\npress / for Division");
	printf("\nenter your choice");
	scanf("%c",&choice);
	if(choice== '+')
	{
		printf("enter two numbers");
		scanf("%d%d",&num1,&num2);
		res=num1+num2;
		printf("Addition of two numbers %d",res);
	}
	else
	if(choice== '-')
	{
		printf("enter two numbers");
		scanf("%d%d",&num1,&num2);
		res=num1-num2;
		printf("Subtraction of two numbers %d",res);
	}
	else
	if(choice== '*')
	{
		printf("enter two numbers");
		scanf("%d%d",&num1,&num2);
		res=num1*num2;
		printf("Multiplication of two numbers %d",res);
	}
	else
	if(choice== '/')
	{
		printf("enter two numbers");
		scanf("%d%d",&num1,&num2);
		res=num1/num2;
		printf("Division of two numbers %d",res);
	}
	else
	printf("Invalide choice");
}