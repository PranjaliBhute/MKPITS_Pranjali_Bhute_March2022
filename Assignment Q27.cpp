#include<stdio.h>
#include<conio.h>
main()
{
	float num[5];
	int i,p=0,n=0;
	printf("Input 1st number ");
	scanf("%f",&num[0]);
	printf("Input 2nd number ");
	scanf("%f",&num[1]);
    printf("Input 3rd number ");
	scanf("%f",&num[2]);
	printf("Input 4th number ");
	scanf("%f",&num[3]);
    printf("Input 5th number ");
	scanf("%f",&num[4]);
	for(i=0;i<5;i++)
	{
		if(num[i] > 0)
		{
			p++;
		}
		else
		if(num[i] < 0)
		{
			n++;
		}
	}
	printf("Counts the number of positive number is %d\n",p);
	printf("Counts the number of negative number is %d\n",n);
	printf("\n");
	return 0;
}