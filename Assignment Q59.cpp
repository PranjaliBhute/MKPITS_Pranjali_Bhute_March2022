#include<stdio.h>
#include<conio.h>
int main()
{
int x,y=1,i,n;
printf("Input the values of x and n:\n");
scanf("%d%d", &x,&n);
for(i=1;i<=n;i++)
{
	y=y*x;
}
printf("value of y=%d",y);
return 0;
}
