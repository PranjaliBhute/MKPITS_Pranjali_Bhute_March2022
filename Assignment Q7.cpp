#include<stdio.h> 
#include<conio.h>
int width, height, area, perimeter;      
int main() 
{
	height = 7;
	width = 5;
    perimeter = 2*(height + width);
	printf("Perimeter of the rectangle = %d inches\n", perimeter);
	area = height * width;
	printf("Area of the rectangle = %d square inches\n", area);

}
