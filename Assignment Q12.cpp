#include<stdio.h>
#include<conio.h>
main()
{
	char id[10];
	int hour;
	double value,salary;
	printf("Input the employee ID :");
	scanf("%s",&id);
	printf("Input the working hours :");
	scanf("%d",&hour);
	printf("Salary amount per hour :");
	scanf("%lf",&value);
	salary=value*hour;
	printf("Employee ID : %s",id);
	printf("\nSalary : %0.2lf Rupee",salary);
}