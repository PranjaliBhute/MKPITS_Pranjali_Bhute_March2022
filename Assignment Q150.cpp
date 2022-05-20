#include<stdio.h>
#include<conio.h>
main()
{
	int m,n;
	printf("Enter any integer number ");
	scanf("%d",&m);
	if(m>0)
	{
		n=1;
		printf("The value of n=%d\n",n);
	}
	if(m==0)
	{
		n=0;
		printf("The value of n=%d\n",n);
	}
	if(m<0)
	{
		n=-1;
		printf("the value of n=%d\n",n);
	}
}