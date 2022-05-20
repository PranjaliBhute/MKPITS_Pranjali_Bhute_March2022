#include<stdio.h>
#include<conio.h>
main()
{
	int num1,num2,i,temp,sum=0;
	printf("Enter 1st integer ");
	scanf("%d",&num1);
	printf("Enter 2nd integer ");
	scanf("%d",&num2);
	if(num1>num2)
	{
		temp=num2;
		num2=num1;
		num1=temp;
	}
	for(i=num1;i<=num2;i++)
	{
		if(i%17 !=0)
		{
			sum=sum+i;
		}
	}
	printf("Sum of all number not divisible by 17 is %d",sum);
	return 0;
}