#include<stdio.h>
#include<conio.h>
main()
{
	int r,c;
	for(r=1;r<=4;r++)
	{
		for(c=1;c<=4;c++)
		{
			printf("%c",c+64);
		}
		printf("\n");
	}

}