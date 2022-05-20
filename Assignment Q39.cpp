#include<stdio.h>
#include<conio.h>
main()
{
	int p,q,i,j,n=1;
	printf("Enter number of lines ");
	scanf("%d",&p);
	printf("Enter the number of elements in a lines ");
	scanf("%d",&q);
	for(i=1;i<=p;i++)
	{
		for(j=1;j<=q;j++)
		{
			printf("%d",n);
			n++;
		}
		printf("\n");
	}
	return 0;
}