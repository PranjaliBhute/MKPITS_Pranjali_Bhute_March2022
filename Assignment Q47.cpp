#include<stdio.h>
#include<conio.h>
int main() 
{
	int n[6], i, temp;
	printf("Input the 6 elements of the array:\n");
	for(i = 0; i < 6; i++) 
	{
		scanf("%d", &n[i]);
	}
   for(i = 0; i < 6; i++) {
		if(i < (6/2)) 
		{
			temp = n[i];
			n[i] = n[6-(i+1)];
			n[6-(i+1)] = temp;
		}
	}

	for(i = 0; i < 6; i++) 
	{
		printf("n[%d] = %d\n", i, n[i]);
	}

}
