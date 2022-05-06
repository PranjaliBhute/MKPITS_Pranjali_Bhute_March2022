#include<stdio.h>
#include<conio.h>
main()
{
	int r,c;
	for(r=68;r>=65;r--)
	{
		for(c=65;c<=r;c++)
		{
			if(r%2==0)
			{
				printf("%c",c);
			}
			else
			{
				printf("%c",32+c);
			}
		}
		printf("\n");
	}

}