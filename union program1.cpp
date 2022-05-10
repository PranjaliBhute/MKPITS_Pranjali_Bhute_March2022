#include<stdio.h>
#include<conio.h>
union student
{
	int Id;
	char Name[20];
}s1;
 main()
{
	printf("Enter student Id ");
	scanf("%d",&s1.Id);
	printf("student Id=%d",s1.Id);
	printf("\nEnter student Name ");
	scanf("%s",&s1.Name);
	printf("student Name=%s",s1.Name);
	
}