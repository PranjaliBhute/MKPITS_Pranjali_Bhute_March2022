#include<stdio.h>
#include<conio.h>
main()
{
	int r,c,sp;
	for(r=1;r<=7;r=r+2)
	{
		for(sp=1;sp<=41-r;sp++)
		{
			printf(" ");
		}
		for(c=r;c>=1;c--)
		{
			printf(" %d",c);
		}
		printf("\n");
	}
}