#include<stdio.h>
#include<conio.h>
main()
{
	int i=1;
	float sum=0;
	for(i=1;i<=50;i++)
	{
	  sum=sum+1.0/i;
    }
	  printf("The value of S = %f",sum);
}