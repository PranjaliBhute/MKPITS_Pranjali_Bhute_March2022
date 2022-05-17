#include<stdio.h>
#include<conio.h>
main()
{
	int i,a[10],n;
	printf("Enter the size of array ");
	scanf("%d",&n);
	printf("Enter array element\n");
	for(i=0;i<n;i++)
	{
	 printf("a[%d]=",i);	
	 scanf("%d",&a[i]);
    }
    for(i=0;i<n;i++)
    {
      if(a[i]==5 || a[i]==7)
      {
    	printf("The %d present at location = %d\n",a[i],i+);
	  }
    }
}
