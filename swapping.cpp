#include<stdio.h>
#include<conio.h>
main()
{
	int num1,num2,sw;
	printf("Enter two number from swap");
	scanf("%d%d",&num1,&num2);
	sw=num1;
	num1=num2;
	num2=sw;
	printf("After swap");
	printf("num1=%d num2=%d",num1,num2);
	
}