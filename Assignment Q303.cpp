#include<stdio.h>
#include<conio.h>
main()
{
	int r,c,sp,count=0;
	for(r=5;r>=1;r--)
	{
		for(sp=r;sp<=5;sp++)
		{
			printf(" ");
		}
    	for(c=1;c<=r;c++)
		{
			printf("%d",r+count);
		}
	    
		printf("\n");
	}
}