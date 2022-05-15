#include<stdio.h>
#include<conio.h>
main()
{
	int a[20],i,n,flag=0,count;
	printf("Enter size ");
	scanf("%d",&n);
	for(i=0;i<n;i++)
	{
		scanf("%d",&a[i]);
	}
	for(i=0;i<n;i++)
	{
		if(a[i]==5 && !flag)
		{
			count++;
			flag=1;
		}
		else
		flag=0;
	}
	printf("count=%d",count);
}