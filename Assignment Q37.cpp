#include<stdio.h>
#include<conio.h>
main()
{
	int num,i,j,n=1;
	printf("Input number of lines ");
	scanf("%d",&num);
	for(i=1;i<=num;i++)
	{
		for(j=0;j<3;j++)
		{
			printf("%d",n);
			n++;
		}
		printf("\n");
	}
	return 0;
}