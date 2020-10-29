#include <stdio.h>
#include <string.h>
#include <stdlib.h>

int main(int argc, char const *argv[])
{
	printf("Content-type:text/htnl\n\n<html><body bgcolor=#23abe2>\n");
	char value[256]="";
	strncpy(value,(char*) getenv("QUERY-STRING"),255);
	printf("QUERY-STRING:%s<BR>\n",value );
	printf("form\n");
	printf("<input type =\"TEXT\"name=\"ITEM1\">\n");
	printf("<input type =\"TEXT\"name=\"ITEM2\">\n");
	printf("<input type=\"SUBMIT\">");
	printf("</form></body></html>\n");
	return 0;
}