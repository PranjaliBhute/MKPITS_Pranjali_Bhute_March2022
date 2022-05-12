#include<stdio.h>
#include<conio.h>
int test(int x, int y);
int main()
{
	printf("%d\n",test(78,95));
	printf("%d\n",test(20,30));
	printf("%d\n",test(27,25));
	printf("%d",test(29,28));
}
int test(int x, int y)
{
	if(x>=20 && x<=30 && y>=20 && y<=30)
	{
		if(x>=y)
		{
			return x;
		}
		else
		{
			return y;
		}
	}
	/*if(x>=20 && y<=30)
	{
		return x;
	}
	else
	if(x>=20 && y<=30)
	{
		return y;
	}
	else*/
	{
		return 0;
	}
}