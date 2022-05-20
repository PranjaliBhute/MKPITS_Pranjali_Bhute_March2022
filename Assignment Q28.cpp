#include<stdio.h>
#include<conio.h>
main()
{ 
	int i,num[5],sum=0,count=0;
	float average;
	printf("Input 1st number ");
	scanf("%d",&num[0]);
	printf("Input 2nd number ");
	scanf("%d",&num[1]);
    printf("Input 3rd number ");
	scanf("%d",&num[2]);
	printf("Input 4th number ");
	scanf("%d",&num[3]);
    printf("Input 5th number ");
	scanf("%d",&num[4]);
	for(i=0;i<5;i++)
	{
		if(num[i] > 0)
		{
			count++;
			sum+=num[i];
		}
		
	}
	average=sum/count;
	printf("The number of positive number is %d\n",count);
	printf("The average of all positive value is %2f\n",average);
	printf("\n");
	return 0;
}