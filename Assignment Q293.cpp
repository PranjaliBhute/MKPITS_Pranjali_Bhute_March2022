#include<stdio.h>
#include<conio.h>
main()
{
	int r,c,ch=65;
	for(r=5;r>=1;r--)
	{
	 for(c=1;c<=r;c++)
		{
			printf("%c",ch);
		}
		ch=ch+1;
		printf("\n");
	}
}