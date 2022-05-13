#include<stdio.h>
#include<conio.h>
main()
{
	int r,c;
	for(r=5;r>=1;r--)
	{
	 for(c=1;c<=r;c++)
		{
			printf("%c",r+64);
			
		}
		printf("\n");
	}
}