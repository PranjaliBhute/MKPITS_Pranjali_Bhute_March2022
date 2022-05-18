#include<stdio.h>
#include<conio.h>
main()
{
	int r,sp,c;
	for(r=7;r>=0;r=r-2)
	{
	 for(sp=1;sp<=41-r;sp++)
		{
			printf(" ");
		}
	 for(c=0;c<r;c++)
	 {
	 	printf(" %c",65+c);
	 }
	printf("\n");
	}
}