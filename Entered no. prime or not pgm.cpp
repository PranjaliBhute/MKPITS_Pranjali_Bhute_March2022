#include<stdio.h>
#include<conio.h>
main()
{
	int i,num,flag=0;
	printf("Enter any number ");
	scanf("%d",&num);
	for(i=1;i<=num;i++)
	{
		if(num%i==0)
		{
			flag=flag+1;
		}
	}
	if(flag==2)
	printf("%d is Prime No.",num);
	else
	printf("%d is not Prime No.",num);
	
}