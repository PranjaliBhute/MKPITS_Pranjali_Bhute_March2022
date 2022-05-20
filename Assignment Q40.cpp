#include<stdio.h>
#include<conio.h>
int main()
{
	int m=0,n=0,marks;
	float avg;
	printf("Enter marks of Roll No.1 ");
	scanf("%d",&marks);
	while(marks>0)
	{
		m=m+marks;
		n=n+1;
		printf("enter marks of Roll No.%d ",n+1);
		scanf("%d",&marks);
	}
	avg=(float)(m/n);
	printf("Average marks=%.2f",avg);
}