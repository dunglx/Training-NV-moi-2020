#include <stdio.h>
#include <string.h>
#include <stdlib.h>
void decode_value(const char *key, char *value, int size)
{
  	char* pPath;
  	pPath = getenv ("QUERY_STRING");
	int length = 0, i = 0, j = 0;
	char *pos1 = '\0', *pos2 = '\0';
//if the string key is in the query string
if( ( pos1 = strstr(pPath, key)) != NULL )
{
//find start of value for this key
for(i=0; i<strlen(key); i++) pos1++;
//find length of the value
if( (pos2 = strstr(pos1,"&")) != NULL )
	length = pos2 - pos1;
else length = strlen(pos1);
//character by character, copy value from query string
for(i = 0, j = 0; i < length ; i++, j++)
{
if(j < size) value[j] = pos1[i];
}
//add NULL character to end of the value
if(j < size) value[j] = '\0';
else value[size-1] = '\0';
}
}