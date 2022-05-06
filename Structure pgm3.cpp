#include<stdio.h>
#include<conio.h>
struct student
{
	int Id;
	char Name[20];
};
int main()
{
	int i;
	struct student s[4];
	for(i=0;i<4;i++)
	{
	  printf("Enter student Id ");
	  scanf("%d",&s[i].Id);
	  printf("Enter student Name ");
	  scanf("%s",s[i].Name);
	}
	for(i=0;i<4;i++)
	{
		printf("\nStudent Id=%d",s[i].Id);
		printf("\nStudent Name=%s",s[i].Name);
	}
}
