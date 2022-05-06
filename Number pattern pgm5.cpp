#include<stdio.h>
#include<conio.h>
main()
{
	int r,c,s;
		for(r=1;r<=3;r++)
		{
			for(s=3;s>=r;s--)
			 printf(" ");
			 
			for(c=1;c<=r;c++)
			{
		    	printf("%d",c);
		    }
		printf("\n");
	   }
}
