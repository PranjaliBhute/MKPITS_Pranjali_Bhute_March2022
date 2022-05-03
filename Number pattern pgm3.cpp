#include<stdio.h>
#include<conio.h>
main()
{
	int r,c,n=1;
	for(r=1;r<=4;r++)
	{
		for(c=1;c<=r;c++)
		{
			printf("%d",n++);
		}
		printf("\n");
	}
}