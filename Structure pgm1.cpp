#include<stdio.h>
#include<conio.h>
struct student
{
	int Id;
	char Name[20];
}s1;
 main()
{
	printf("Enter student Id ");
	scanf("%d",&s1.Id);
	printf("Enter student Name ");
	scanf("%s",s1.Name);
	printf("student Id=%d",s1.Id);
	printf("\nstudent Name=%s",s1.Name);
	
}