   /*    A
        B B
       C C C
      D D D D  */ 
#include<stdio.h>
#include<conio.h>
main()
{
	int r,c,sp,count=1;
	for(r=1;r<=4;r++)
	{
		for(sp=1;sp<=41-r;sp++)
		{
			printf(" ");
		}
		for(c=1;c<=r;c++)
		{
			printf(" %c",64+r);
		}
		printf("\n");
	}
}