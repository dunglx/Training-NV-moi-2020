// C programming in linux (c) David Haskin 2008
// bai3.2
#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>

void doit(int number1, int number2, double*result)
{
	*result = sqrt((double)(number1 + number2));
}
int main(int argc, char const *argv[])
{
	int n1=0, n2=0, i=0;
	double result = 0;
	n1 = atoi(argv[1]);
	n2 = atoi(argv[2]);
	printf("Content-type:text/html\n\n<html><body>\n");
	for(i=1;i<=100;i++)
	{
		doit(n1+i,n2*i,&result);
		printf("%f",result );
	}
	printf("</body></htm>\n");
	return 0;
}