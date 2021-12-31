#include "ce103-hw4-c-dll.h"

__declspec(dllexport) int ce103_fibonacciNumber(int fiIndex)
{
	fiIndex = fiIndex - 1;
	
	int n1 = 0, n2 = 1, n3 = 0;
	int fibresult;

	if (fiIndex <= 0)
	{
		return 0;
	}
	
	for (int i = 1; i <= fiIndex; ++i)
	{
		n1 = n2;
		n2 = n3;
		n3 = n1 + n2;
		fibresult = n3;
		
		if (fibresult < 0)
		{ 
			return -2;
		}

	}
	return fibresult;
}

__declspec(dllexport) char* ce103_strrev(char* fiStr)
{
	
	int m, s = ce103_strlen(fiStr) - 1, ch;

	for (m = 0; m < s; m++, s--) {

		ch = fiStr[m];
		fiStr[m] = fiStr[s];
		fiStr[s] = ch;
	}

	return fiStr;
}

__declspec(dllexport) int ce103_strlen(const char* fiStr)
{

	int number = 0;

	while (fiStr[number] != '\0')

		number++;

	return number;
}

__declspec(dllexport) char* ce103_strcat(char* fiDest, char* fiSrc)
{
	
	int k = ce103_strlen(fiDest), j = 0;
	
	while (fiSrc[j] != '\0')
	{
		fiDest[k] = fiSrc[j];
		k++;
		j++;
	}
	fiDest[k] = '\0';
	
	return fiDest;
}

__declspec(dllexport) int ce103_strcmp(const char* fiLhs, const char* fiRhs)
{

	int m;

	for (m = 0; fiLhs[m] == fiRhs[m]; m++) {

		if (fiLhs[m] == '\0')
			return 0;
	}
	if ((unsigned char)fiLhs[m] < (unsigned char)fiRhs[m])

		return -1;
	else
		return 1;
}

__declspec(dllexport) char* ce103_strcpy(char* foDestination, const char* fiSource)
{

	char* as = foDestination;
	char* z = fiSource;

	while (*z != '\0')
	{
		*as = *z;
		as++;
		z++;
	}

	*as = '\0';

	return foDestination;
}

__declspec(dllexport) void ce103_hex2bin(char* fiHex, int fiHexLen, unsigned char* foBin)
{
	int k, h;

	for (;;) {
		k = *fiHex++; if (k == 0) break;

		if (k > 96) k -= 87;
		else if (k > 64) k -= 55;
		else k -= 48;
		h = *fiHex++; if (h == 0) { *foBin = k << 4; break; }
		if (h > 96) h -= 87;
		else if (h > 64) h -= 55;
		else h -= 48;
		*foBin++ = (k << 4) | h;
	}
	return fiHex;
}

__declspec(dllexport) void ce103_bin2hex(unsigned char* fiBin, int fiBinLen, char* foHex)
{
	int s, d, * last = fiBin + fiBinLen;

	while (fiBin < last) {
		s = *(fiBin++);
		d = s >> 4;
		*(foHex++) = d + (d > 9 ? 55 : 48);
		d = s & 15;
		*(foHex++) = d + (d > 9 ? 55 : 48);
	}
	*foHex = 0;

	return fiBin;
}
