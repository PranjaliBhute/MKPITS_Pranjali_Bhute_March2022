#include<stdio.h>
#include<conio.h>
main()
{
	int r,sp,str;
	for(r=4;r>=1;r--)
	{
	 for(sp=1;sp<=41-r;sp++)
		{
			printf(" ");
		}
	 for(str=1;str<=2*r-1;str++)
	 {
	 	printf("*");
	 }	
	printf("\n");
	}
}