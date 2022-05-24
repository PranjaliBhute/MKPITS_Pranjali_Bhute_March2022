#include<stdio.h>
#include<conio.h>
main()
{
	int num, n1,n2,n3,rev;
	printf("Enter any number ");
	scanf("%d",&num);
	n1=num%10;
	num=num/10;
	n2=num%10;
	num=num/10;
	n3=num%10;
	rev=n1*100+n2*10+n3*1;
	printf("Reverse number is %d",rev);
}