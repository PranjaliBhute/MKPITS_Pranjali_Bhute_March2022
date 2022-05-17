#include<stdio.h>
#include<conio.h>
main()
{
	int r,sp,c;
	for(r=1;r<=3;r++)
	{
		for(sp=r;sp<=3;sp++)
		{
			printf(" ");
		}
		for(c=1;c<=r;c++)
		{
			printf("%c",r+64);
		}
		printf("\n");
	}
}