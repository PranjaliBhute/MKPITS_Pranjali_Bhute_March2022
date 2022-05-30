#include<stdio.h>
#include<conio.h>
 main()
{
    int num,count=0,sum=0,min,max;
	float avg;
	printf("Enter positive integer:\n");
	scanf("%d",&num);
	if(num>0)
	{
		min=num;
		max=num;
		while(num>0)
	{
			count++;
		 	sum = sum+num;
		if(min > num)
		min=num;
		if(max < num)
		max=num;
		printf("Enter positive integer:\n");
		scanf("%d",&num);
	}
		avg= (float)sum/(float)count;
		printf("No. of positive values entered=%d\n",count);
		printf("Minimum value=%d\n",min);
		printf("Maximum value=%d\n",max);
		printf("Average value=%0.2f\n",avg);
	}
    else
   {
    printf("Invalid Input");	
   }
}
