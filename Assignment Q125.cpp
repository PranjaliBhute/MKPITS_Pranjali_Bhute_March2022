#include<stdio.h>
#include<conio.h>
main()
{
	int i,a[10],n,count=0,count1=0;
	printf("Enter size of array ");
	scanf("%d",&n);
	printf("Enter array element\n");
	for(i=0;i<n;i++)
	{
	scanf("%d",&a[i]);
    }
    for(i=0;i<n;i++)
    {
      if(a[i]==3)
      {
    	count=count+1;
	  }
	  if(a[i]==5)
	  {
	  	count1=count1+1;
	  }
    }
	  printf("3 is present %d times",count);
      printf("\n5 is present %d times",count1);
    
}