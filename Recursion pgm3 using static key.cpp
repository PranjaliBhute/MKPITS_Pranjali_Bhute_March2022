#include<stdio.h>
#include<conio.h>
void fun();
main()
 {
 	fun();
 }
 void fun()
{
	static int i=1;
	if(i==10)
	return;
	printf("%d",i);
	i++;
	fun();
}
