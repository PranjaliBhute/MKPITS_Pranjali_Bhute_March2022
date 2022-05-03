#include<stdio.h>
#include<conio.h>
main()
{
	int r,c,sp;
	for(r=1;r<=3;r++)
	{
		for(sp=3;sp>=r;sp--)
		{
			printf(" ");
		  }
		    for(c=1;c<=r;c++)
		  {
			printf("%d",c);
		}
		 printf("\n");
	}
}
    

