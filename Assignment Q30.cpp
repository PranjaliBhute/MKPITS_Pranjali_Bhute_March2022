#include<stdio.h>
#include<conio.h>
main()
{
	int i,j;
	printf("Input an integer ");
	scanf("%d",&i);
	printf("List of square of each one of the even values from 1 to a %d \n",i);
	for(j=2;j<=i;j++)
	{
		if((j%2) == 0)
		{
			printf("%d^2 = %d\n",j,j*j);
		}
	}
	
	return 0;
}