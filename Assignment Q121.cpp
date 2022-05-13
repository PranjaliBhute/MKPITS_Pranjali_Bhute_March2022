#include<stdio.h>
#include<conio.h>
main()
{
	int i,a[10],count=0;
	printf("Enter array element ");
	for(i=0;i<=5;i++)
	{
	scanf("%d",&a[i]);
    }
    for(i=0;i<=5;i++)
    {
      if(a[i]==5 && a[i+1]==5)
      {
    	count=count+1;
	  }
   }
	printf("count=%d",count);
}