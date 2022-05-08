#include<stdio.h>
#include<conio.h>
int main()
{
	int i,x,y,pow=1;
	printf("Enter x & y value ");
	scanf("%d%d",&x,&y);
	i=1;
	while(i<=y)
	{
		pow=pow*x;
		i++;
	}
	printf("Power=%d",pow);
}