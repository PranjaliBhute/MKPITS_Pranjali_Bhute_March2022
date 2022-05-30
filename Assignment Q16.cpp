#include<stdio.h>
#include<conio.h>
main()
{
	int amt,total;
	printf("Enter any amount: ");
	scanf("%d",&amt);
	printf("There are ");
	
	total = amt/2000;
	printf(" \n%d Note(s) of 2000.00\n",total);
	amt = amt-(total*2000);
	
	total = amt/500;
	printf(" \n%d Note(s) of 500.00\n",total);
	amt = amt-(total*500);
	
	total = amt/100;
	printf(" \n%d Note(s) of 100.00\n",total);
	amt = amt-(total*100);
	
	total = amt/50;
	printf(" \n%d Note(s) of 50.00\n",total);
	amt = amt-(total*50);
	
	total = amt/10;
	printf(" \n%d Note(s) of 10.00\n",total);
	amt = amt-(total*10);
	
	total = amt/5;
	printf(" \n%d Note(s) of 5.00\n",total);
	amt = amt-(total*5);
	
	total = amt/2;
	printf(" \n%d Note(s) of 2.00\n",total);
	amt = amt-(total*2);
	
	total = amt/1;
	printf(" \n%d Note(s) of 1.00\n",total);
	amt = amt-(total*1);
}