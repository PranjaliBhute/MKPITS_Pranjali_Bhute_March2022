#include<stdio.h>
#include<conio.h>
main()
{
	int num1,num2,i;
	printf("Enter 1st number ");
	scanf("%d",&num1);
	printf("Enter 2nd number ");
	scanf("%d",&num2);
	printf("The number which gives remainder as 2 or 3 when divide it by 7 are ");
	i=num1;
	while(i<=num2)
	{
		if(i%7==2 || i%7==3)
		{
			printf("%d\n",i);
		}
		i++;
	}
}