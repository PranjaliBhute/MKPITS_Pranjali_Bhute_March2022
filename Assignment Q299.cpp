#include<stdio.h>
#include<conio.h>
main()
{
	int r,sp,str;
	for(r=1;r<=3;r++)
	{
		for(sp=r;sp<=3;sp++)
		{
			printf(" ");
		}
		for(str=1;str<=r;str++)
		{
			printf("*");
		}
		printf("\n");
	}
}