#include<stdio.h>
#include<conio.h>
 main()
 {
	int ndays, yr, mon, day;	
	printf("Input no. of days: ");
	scanf("%d", &ndays);
	yr =  ndays/365;
	ndays = ndays-(365*yr);
	mon = ndays/30;
	day = ndays-(mon*30);
	printf(" %d Year(s) \n %d Month(s) \n %d Day(s)", yr, mon, day);
	
}
