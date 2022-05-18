#include<stdio.h>
#include<conio.h>
main()
{
	int r,sp,c;
	for(r=4;r>=1;r--)
	{
	 for(sp=1;sp<=41-r;sp++)
		{
			printf("  ");
		}
	 for(c=1;c<=2*r-1;c++)
	 {
	 	printf("%d ",r);
	 }	
	printf("\n");
	}
}