#include<stdio.h>
#include<conio.h>
main()
{
	int n1,n2;
	printf("Enter two integer number ");
	scanf("%d%d",&n1,&n2);
	if(n1>n2)
	{
		if(n1%n2==0)
		{
			printf("%d is multiple of %d ",n1,n2);
		}
		else
		{
			printf("%d is not multiple of %d ",n1,n2);
		}
	}
	else
	if(n2%n1==0)
	{
		printf("%d is multiple of %d ",n2,n1);
	}
	else
	{
		printf("%d is not multiple of %d ",n2,n1);
	}
	
}