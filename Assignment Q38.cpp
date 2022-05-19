#include<stdio.h>
#include<conio.h>
main()
{
	int i,n,a,b,c;
	printf("Enter number of lines ");
	scanf("%d",&n);
	printf("\nNumber, Square, Cube\n");
	for(i=1;i<=n;i++)
	{
		a=i;
		b=a*i;
		c=b*i;
		printf("\n%d %d %d",a,b,c);
	}
	return 0;
}