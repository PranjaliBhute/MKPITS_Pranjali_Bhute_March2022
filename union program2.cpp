#include<stdio.h>
#include<conio.h>
union student
{
	int Id;
	char Name[20];
};
int main()
{
	union student s1;
	
	printf("Enter Student Id ");
	scanf("%d",&s1.Id);
	printf("Student Id= %d",s1.Id);
	printf("\nEnter Student Name ");
	scanf("%s",s1.Name);
	printf("Student Name= %s",s1.Name);
	
}