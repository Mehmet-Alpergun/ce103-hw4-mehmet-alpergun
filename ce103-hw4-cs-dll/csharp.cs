using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ce103_hw4_cs_dll
{
    public class csharp
    {
		/**************************
        * Copyleft (L) 2021 CENG - All Rights Not Reserved
        * You may use, distribute and modify this code.
        **************************/

		 /**
		* @file ce103-hw4-cs-dll
		* @author Mehmet Alpergun
		* @date 03 October 2021
		*
		* @brief <b> HW-4 Functions </b>
		*
		* HW-4 Sample Lib Functions
		*
	    * @see http://bilgisayar.mmf.erdogan.edu.tr/en/
		*
		*/

		/**
	    * @name   fibonacciNumber (ce103_fibonacciNumber_cs)
	    *
	    * @brief Fibonacci Number Calculator
	    *
	    * Calculates the fibonacci number in the given index and return as output
	    *
	    * @param  [in] fiIndex [\b int]  index of fibonacci number in the serie
	    *
	    * @retval [\b int] calculated fibonacci number
	    **/
		public int ce103_fibonacciNumber_cs(int fiIndex)
		{
			fiIndex = fiIndex - 1;
			int d = 0, f = 1, next = 0;
			int retnumb;
			if (fiIndex <= 0)
			{
				return 0;
			}
			
			for (int i = 1; i <= fiIndex; ++i)
			{
				d = f;
				f = next;
				next = d + f;
				retnumb = next;
				if (retnumb < 0)
				{
					return -2;
				}
			}
			retnumb = next;
			return retnumb;
		}

		/**
		@name   strrev (ce103_strrev_cs)

		@brief \b Reverse String

		Reverse given string

		@param [in] fiStr [\b string] The given string which is needed to be reversed.

		@retval [\b string] This function returns the string after reversing the given string
	    **/
		public string ce103_strrev_cs(string fiStr)
		{
			char[] chars = new char[ce103_strlen_cs(fiStr)];
			for (int h = 0, y = ce103_strlen_cs(fiStr) - 1; h <= y; h++, y--)
			{
				chars[h] = fiStr[y];
				chars[y] = fiStr[h];
			}
			//return value that gives us the inverse of the string we entered
			return new string(chars);
		}

		/**
		@name   strlen (ce103_strlen_cs)
		@brief \b Get string length

		Returns the length of the C# string str.

		@param [in] fiStr [\b string] the null-terminated byte string to be examined

		@retval [\b int] The length of the null-terminated byte string str.
	    **/
		public int ce103_strlen_cs(string fiStr)
		{
			int say = 0;
			foreach (char chr in fiStr)
			{
				say++;
			}
			return say;
		}

		/**
		@name   strcat (ce103_strcat_cs)
		@brief \b Concatenate strings

		In this function, we combine 2 randomly entered strings.
        We give one of our strings "fiDest" and the other "fiSrc", that is, a random string.
        The sum of these strings gives us the combined return value of the strings.


		@param  [in] fiDest [\b string] the null-terminated byte string to append to
		@param  [in] fiSrc  [\b string] the null-terminated byte string to copy from

		@retval [\b string] returns a copy of dest
	    **/
		public string ce103_strcat_cs(string fiDest, string fiSrc)
        {
			
			return fiDest +fiSrc;
		}

		/**
		@name   strcmp (ce103_strcmp_cs)
		@brief  \b Compare two strings

		Compares two null-terminated byte strings lexicographically.

		@param  [in] fiLhs [\b string] the null-terminated byte strings to compare
		@param  [in] fiRhs [\b string] the null-terminated byte strings to compare

		@retval [\b int] Negative value if lhs appears before rhs in lexicographical order.
				Zero if lhs and rhs compare equal.
				Positive value if lhs appears after rhs in lexicographical order.
	    **/
		public int ce103_strcmp_cs(string fiLhs, string fiRhs)
        {
			
			if (fiLhs == fiRhs)
			{
				return 0;
			}
			else if (ce103_strlen_cs(fiLhs) < (ce103_strlen_cs(fiRhs)))
			{
				return -1;
			}
			else
			{
				return 1;
			}
		}

		/**
	    *
		@name  strcpy (ce103_strcpy_cs)
		@brief \b Copy string

		Copies the C# string pointed by source into the array pointed by destination,
		including the terminating null character (and stopping at that point).

		@param [out] foDestination	[\b string] the destination array where the content is to be copied.
		@param [in]  fiSource		[\b string]	C string to be copied.

		@retval [\b string] returns a copy of dest
	    **/
		public string ce103_strcpy_cs(string foDestination, string fiSource)
        {
			
			foDestination = fiSource;
			return foDestination;
		}
		/**
        * @name    bin2hex (ce103_bin2hex_cs)
        * 
        * @brief   \b Binary to Hexadecimal Conversion
        *
        * Unpacks alpha numeric value, Example: 0x12 0x34 = "1234".
        *
        * @param [in]  fiBin      [\b byte[]]    Binary data to be converted.
        * 
        * @param [in]  fiBinLen   [\b int]	 Binary data length.
        * 
        * @param [out] foHex      [\b char[]]	 Convertion result as ascii. Doubles the binary length.
        **/
		public void ce103_bin2hex_cs(byte[] fiBin, int fiBinlen, char[] foHex)
        {
			char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
			for (int c = 0; c < fiBinlen; c++)
            {
				foHex[c * 2] = arr[fiBin[c] >> 4];
				foHex[c * 2 + 1] = arr[fiBin[c] & 0x0F];
            }
        }

		/**
        * @name    hex2bin (ce103_hex2bin_cs)
        * 
        * @brief   \b Hexadecimal string to byte array Conversion
        * 
        * Convert hex string to byte array
        *
        * @param   [in]  fiHex    [\b string] Ascii hex string.
        * 
        * @param   [in]  fiHexLen [\b int]     Ascii data length.
        * 
        * @param  [out]  foBin    [\b byte[]]   Convertion result as binary.
        **/
		public void ce103_hex2bin_cs(string fiHex, int fiHexLen, byte[] foBin)
		{
			//char[] foBinArr = new char[fiHexLen / 2];

			int[] count = { 0, 0 };
			for (int t = 0; t < fiHexLen; t += 2)
			{   
				char[] temp = new char[2];
				int hexint = 0;
				for (int a = 0; a < 2; a++)
				{  
					temp[a] = (char)fiHex[t + a];
					if (a == 0)
					{  
						if (temp[a] >= '0' && temp[a] <= '9')
						{ 
							count[a] = temp[a] - '0';
							count[a] *= 16;
						}
						else if (temp[a] >= 'A' && temp[a] <= 'F')
						{
							count[a] = temp[a] - 'A' + 10;
							count[a] *= 16;
						}
					}
					else
					{
						if (temp[a] >= '0' && temp[a] <= '9')
						{
							count[a] = temp[a] - '0';
						}
						else if (temp[a] >= 'A' && temp[a] <= 'F')
						{
							count[a] = temp[a] - 'A' + 10;
						}
					}
					hexint += count[a];
				}
				foBin[t / 2] = (byte)hexint;
			}
		}



	}
}
	    


