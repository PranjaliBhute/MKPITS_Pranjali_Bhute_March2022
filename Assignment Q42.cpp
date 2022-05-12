#include<stdio.h>
#include<conio.h>
main()
{
	double i,j=1,s=0;
	for(i=1;i<=7;i++)
	{
		s=s+i/j;
		i=i+2;
		j=j*2;
	}
	printf("Value of S=%lf",s);
}