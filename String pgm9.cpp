#include<stdio.h>
#include<conio.h>
#include<string.h>
main()
{
	char name1[20]={"Pranjali"};
	char name2[20]={"Vaibhav"};
	int cmp;
	cmp=strcmp(name2,name1);
	printf("%d",cmp);
}