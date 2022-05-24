#include<stdio.h>
int main() 
{
	int j, i;
	printf("Input an integer: ");
	scanf("%d", &j);
	printf("All the divisor of %d are: ", j);
	for(i = 1; i <= j; i++) 
	{
		if((j%i) == 0)
		{
			printf("\n%d",i);
		}
	}
	
}
