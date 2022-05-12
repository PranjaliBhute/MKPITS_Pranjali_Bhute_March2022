#include<stdio.h>
#include<conio.h>
main()
{
	int pass;
	printf("Enter a password ");
	scanf("%d",&pass);
	if(pass==1234)
	{
		printf("Correct Password");
	}
	else
	{
		printf("Incorrect Password");
	}
}