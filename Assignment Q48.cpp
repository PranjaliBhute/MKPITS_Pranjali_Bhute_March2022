#include<stdio.h>
#include<conio.h>
int main() 
{
	int n,a[10], i, sv, position;

	printf("Input the length of the array: ");
	scanf("%d", &n);
    printf("Input the array elements:\n");
	for(i = 0; i < n; i++)
	{
	   scanf("%d", &a[i]);
	}
	sv = a[0];
	position = 0;
	for(i = 0; i < n; i++)
	 {
		if(sv > a[i]) 
		{
			sv = a[i];
			position = i;
		}
	}
    printf("Smallest Value: %d\n", sv);
	printf("Position of the element: %d\n", position);
}
