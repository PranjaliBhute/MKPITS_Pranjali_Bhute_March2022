#include<stdio.h>
#include<conio.h>
main()
{
	int r,c,sp;
	for(r=5;r>=1;r--)
	{
    	for(c=1;c<=r;c++)
		{
			printf("%c",c+64);
		}
	    for(sp=r;sp<=5;sp++)
		{
			printf(" ");
		}
		printf("\n");
	}
}