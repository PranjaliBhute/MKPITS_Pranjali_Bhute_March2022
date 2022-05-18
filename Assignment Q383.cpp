#include<stdio.h>
#include<conio.h>
main()
{
	int r,c,sp,n=0;
	for(r=1;r<=4;r++)
	{
		for(sp=1;sp<=4-r;sp++)
		{
			printf("  ");
		}
		n=1;
		for(c=1;c<=r;c++)
		{
			printf(" %d",n);
			n++;
        }
        n=n-2;
	    for(c=1;c<r;c++)
		{
			printf(" %d",n);
			n--;
		}
		printf("\n");
	}
}