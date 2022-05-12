#include<stdio.h>
#include<conio.h>
main()
{
	int a[4]={1,2,3,4};
	int b[4],i;
	for(i=0;i<4;i++)
	{
		if(i==3)
		{
			b[0]=a[i];
		}
		else
		{
			b[i+1]=a[i];
	    }
		
    }
    for(i=0;i<4;i++)
    {
    	printf("%d\n",b[i]);
	}
    

}
