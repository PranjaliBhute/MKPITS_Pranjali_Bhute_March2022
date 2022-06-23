#include<stdio.h>
#include<conio.h>
#include<math.h>
int main()
{
	int n;
	printf("Enter the number ");
	scanf("%d",&n);
	if(abs(n-100)<=10 || abs(n-200)<=10)
	{
	  printf("True");
	}
    else
    {
	  printf("False");
    }
}