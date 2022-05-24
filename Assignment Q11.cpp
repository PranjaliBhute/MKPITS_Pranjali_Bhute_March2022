#include<stdio.h>
#include<conio.h>
main()
{
	double w1,w2,c1,c2,res;
	printf("Weight - items 1:");
	scanf("%lf",&w1);
	printf("no. of items 1:");
	scanf("%lf",&c1);
	printf("Weight - items 2:");
	scanf("%lf",&w2);
	printf("no. of items 2:");
	scanf("%lf",&c2);
	res=((w1*c1)+(w2*c2))/(c1+c2);
	printf("Average value = %lf\n",res);

}