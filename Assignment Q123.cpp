#include<stdio.h>
#include<conio.h>
main()
{
	int i,n,a[10],count=0;
	printf("Enter size of array ");
	scanf("%d",&n);
	printf("Enter array element\n ");
	for(i=0;i<n;i++)
	{
		printf("a[%d]",i);
	    scanf("%d",&a[i]);
    }
    for(i=0;i<n;i++)
    {
      if(a[i]==5)
      	{
      		count=count+1;
		}
	}
		if(count==3)
		{
			printf("True");
		}
	    else
	    printf("False");
    
}