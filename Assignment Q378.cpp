#include<stdio.h>
#include<conio.h>
main()
{
	int r,c,sp,ch=65;
	for(r=1;r<=4;r++)
	{
		for(sp=1;sp<=41-r;sp++)
		{
			printf("  ");
		}
		for(c=r;c>=1;c--)
		{
			printf(" %c",ch);
			ch--;
		}
		ch=ch+2;
		for(c=1;c<r;c++)
		{
			printf(" %c",ch);
			ch++;
		}
		ch=65+r;
		printf("\n");
	}
}