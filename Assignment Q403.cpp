#include<stdio.h>
#include<conio.h>
main()
{
	int r,sp,c;
	for(r=7;r>=1;r=r-2)
	{
	 for(sp=1;sp<=41-r;sp++)
		{
			printf(" ");
		}
	 for(c=1;c<=r;c++)
	 {
	 	printf(" %d",r);
	 }
	printf("\n");
	}
}