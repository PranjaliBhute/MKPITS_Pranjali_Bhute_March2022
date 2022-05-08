#include<stdio.h>
#include<conio.h>
main()
{
	int i,num,fact=1;
	printf("Enter Number ");
	scanf("%d",&num);
	i=1;
	while(i<=num)
	{
		fact=fact*i;
		i++;
	}
	printf("Fact=%d",fact);
}