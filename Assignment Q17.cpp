#include<stdio.h>
#include<conio.h>
 main() 
 {
	int seconds, hr, min, sec;
	printf("Input seconds: ");
	scanf("%d", &seconds);
	hr = (seconds/3600); 
	min = (seconds -(3600*hr))/60;
	sec = (seconds -(3600*hr)-(min*60));
	printf("Hr:Min:Sec - %d:%d:%d\n",hr,min,sec);
}
