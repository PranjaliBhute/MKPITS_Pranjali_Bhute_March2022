#include<stdio.h>
#include<conio.h>
struct student
{
	int Id;
	char Name[20];
};
 main()
{
	struct student s1={1,"Saanvi"};// structure const
	
/*	printf("Enter Student id ");
	scanf("%d",&s1.Id);
	printf("Enter Student Name ");
	scanf("%s",s1.name);*/
	printf("Student Id= %d",s1.Id);
	printf("\nStudent Name= %s",s1.Name);
	
}