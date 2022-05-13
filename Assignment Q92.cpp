#include<stdio.h>
#include<conio.h>
main()
{
	int n1,n2;
	printf("Enter two integer\n");
	scanf("%d%d",&n1, &n2);
	if(n1+n2==5 || n1-n2==5 || n2-n1==5)
	{
		printf("True");
	}
	else if(n1==5 || n2==5)
	{
		printf("True");
	}
	else
	{
		printf("False");
	}
}