#include<stdio.h>
#include<conio.h>
main()
{
	int r,c,sp,ch=65;
	for(r=1;r<=7;r=r+2)
	{
		for(sp=1;sp<=41-r;sp++)
		{
			printf(" ");
		}
		//if(r==1||r==3||r==5||r==7)
		
		for(c=1;c<=r;c++)
		{
			printf(" %c",ch);
			ch++;
		}
    	ch=65;
		printf("\n");
	}
}