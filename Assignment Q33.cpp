#include<stdio.h>
#include<conio.h>
main()
{
	int x,y;
	printf("In cartesian system\nEnter the co-ordinates of x & y\n");
	scanf("%d %d",&x,&y);
	if(x>0 && y>0)
	{
		printf("point(%d,%d) is in 1st quadrant",x,y);
	}
	else if(x>0 && y<0)
	{
		printf("point(%d,%d) is in 2nd quadrant",x,y);
	}
	else if(x<0 && y<0)
	{
		printf("point(%d,%d) is in 3rd quadrant",x,y);
	}
	else if(x<0 && y>0)
	{
		printf("point(%d,%d) is in 4th quadrant",x,y);
	}
	else if(x==0 && y==0)
	{
		printf("point(%d,%d) at origin",x,y);
	}
}