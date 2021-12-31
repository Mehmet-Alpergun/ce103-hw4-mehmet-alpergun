using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ce103_hw4_cs_dll;
using System.Text;

namespace ce103_hw4_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ce103_fibonacciNumber_cs_test1()
        {
            csharp fibo = new csharp();
            int result = fibo.ce103_fibonacciNumber_cs(4);
            Assert.AreEqual(result, 2);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_cs_imported1()
        {
            csharpimp fibo = new csharpimp();
            int result = fibo.ce103_fibonacciNumber_cs_imported(4);
            Assert.AreEqual(result, 2);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_importedcppcs1()
        {
            csharp fibo = new csharp();
            int result = fibo.ce103_fibonacciNumber_cs(4);
            csharpimp fiboo = new csharpimp();
            int result2 = fiboo.ce103_fibonacciNumber_cs_imported(4);
            Assert.AreEqual(result, result2);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_cs2()
        {
            csharp fibo = new csharp();
            int result = fibo.ce103_fibonacciNumber_cs(12);
            Assert.AreEqual(result, 89);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_cs_imported2()
        {
            csharpimp fibo = new csharpimp();
            int result = fibo.ce103_fibonacciNumber_cs_imported(12);
            Assert.AreEqual(result, 89);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_importedcppcs2()
        {
            csharp fibo = new csharp();
            int result = fibo.ce103_fibonacciNumber_cs(12);
            csharpimp fiboo = new csharpimp();
            int result2 = fiboo.ce103_fibonacciNumber_cs_imported(12);
            Assert.AreEqual(result, result2);
        }
        [TestMethod]
        public void ce103_fibonacciNumber3()
        {
            csharp fibo = new csharp();
            int result = fibo.ce103_fibonacciNumber_cs(14);
            Assert.AreEqual(result, 233);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_cs_imported3()
        {
            csharpimp fibo = new csharpimp();
            int result = fibo.ce103_fibonacciNumber_cs_imported(14);
            Assert.AreEqual(result, 233);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_importedcppcs3()
        {
            csharp fibo = new csharp();
            int result = fibo.ce103_fibonacciNumber_cs(14);
            csharpimp fiboo = new csharpimp();
            int result2 = fiboo.ce103_fibonacciNumber_cs_imported(14);
            Assert.AreEqual(result, result2);
        }
        [TestMethod]
        public void ce103_strrev_1()
        {
            csharp strrev = new csharp();
            Assert.AreEqual(strrev.ce103_strrev_cs("hello"), "olleh");
        }
  
        [TestMethod]
        public void ce103_strrev_2()
        {
            csharp strrev = new csharp();
            Assert.AreEqual(strrev.ce103_strrev_cs("New"), "weN");
        }
    
        [TestMethod]
        public void ce103_strrev_3()
        {
            csharp strrev = new csharp();
            Assert.AreEqual(strrev.ce103_strrev_cs("why"), "yhw");         
        }
     
        [TestMethod]
        public void ce103_strlen_cs_1()
        {
            csharp strlen = new csharp();
            Assert.AreEqual(strlen.ce103_strlen_cs("sorry"), 5);
        }

        [TestMethod]
        public void ce103_strlen_cs_2()
        {
            csharp strlen = new csharp();
            Assert.AreEqual(strlen.ce103_strlen_cs("systems"), 7);
        }
    
        [TestMethod]
        public void ce103_strlen_cs_3()
        {
            csharp strlen = new csharp();
            Assert.AreEqual(strlen.ce103_strlen_cs("really"), 6);
        }

        [TestMethod]
        public void ce103_strcat_cs_1()
        {
            csharp strcat = new csharp();
            Assert.AreEqual(strcat.ce103_strcat_cs("Hello","darling"),"Hellodarling");
        }
  
        [TestMethod]
        public void ce103_strcat_cs_2()
        {
            csharp strcat = new csharp();
            Assert.AreEqual(strcat.ce103_strcat_cs("Computer","money"),"Computermoney");
        }
 
        [TestMethod]
        public void ce103_strcat_cs_3()
        {
            csharp strcat = new csharp();
            Assert.AreEqual(strcat.ce103_strcat_cs("Operating","sale"),"Operatingsale");
        }

        [TestMethod]
        public void ce103_strcmp_cs_1()
        {
            csharp strcmp = new csharp();
            Assert.AreEqual(strcmp.ce103_strcmp_cs("Computer", "Computer"), 0);
        }
 
        [TestMethod]
        public void ce103_strcmp_cs_2()
        {
            csharp strcmp = new csharp();
            Assert.AreNotEqual(strcmp.ce103_strcmp_cs("Computer", "Engineering"), 0);
        }

        [TestMethod]
        public void ce103_strcmp_cs_3()
        {
            csharp strcmp = new csharp();
            Assert.AreNotEqual(strcmp.ce103_strcmp_cs("Hello", "World"), 0);
        }
 
        [TestMethod]
        public void ce103_strcpy_cs_1()
        {
            csharp strcpy = new csharp();
            Assert.AreEqual(strcpy.ce103_strcpy_cs("hello", "no"), "no");
        }
 
        [TestMethod]
        public void ce103_strcpy_cs_2()
        {
            csharp strcpy = new csharp();
            Assert.AreEqual(strcpy.ce103_strcpy_cs("real", "naturel"), "naturel");
        }
 
        [TestMethod]
        public void ce103_strcpy_cs_3()
        {
            csharp strcpy = new csharp();
            Assert.AreEqual(strcpy.ce103_strcpy_cs("systems", "proces"), "proces");
        }
     
        [TestMethod]
        public void ce103_strrev_cs_imported_1()
        {
            csharpimp strrev = new csharpimp();
            Assert.AreEqual(strrev.ce103_strrev_cs_imported("plate"), "etalp");
        }
        [TestMethod]
        public void ce103_strrev_importedcppcs_1()
        {
            csharp strrev = new csharp();
            csharpimp Strrev = new csharpimp();
            Assert.AreEqual(strrev.ce103_strrev_cs("adam"), "mada", Strrev.ce103_strrev_cs_imported("adam"), "mada");
        }
 
        [TestMethod]
        public void ce103_strrev_cs_imported_test_2()
        {
            csharpimp strrev = new csharpimp();
            Assert.AreEqual(strrev.ce103_strrev_cs_imported("no"), "on");
        }
        [TestMethod]
        public void ce103_strrev_importedcppcs_2()
        {
            csharp strrev = new csharp();
            csharpimp Strrev = new csharpimp();
            Assert.AreEqual(strrev.ce103_strrev_cs("no"), "on", Strrev.ce103_strrev_cs_imported("no"), "on");
        }
     
        [TestMethod]
        public void ce103_strrev_cs_imported_3()
        {
            csharpimp strrev = new csharpimp();
            Assert.AreEqual(strrev.ce103_strrev_cs_imported("human"), "namuh");
        }
        [TestMethod]
        public void ce103_strrev_importedcppcs_3()
        {
            csharp strrev = new csharp();
            csharpimp Strrev = new csharpimp();
            Assert.AreEqual(strrev.ce103_strrev_cs("human"), "namuh", Strrev.ce103_strrev_cs_imported("human"), "namuh");
        }
       
        [TestMethod]
        public void ce103_strcat_cs_imported_1()
        {
            csharpimp strcat = new csharpimp();
            Assert.AreEqual(strcat.ce103_strcat_cs_imported("Hello", "nature"), "Hellonature");
        }
        [TestMethod]
        public void ce103_strcat_importedcppcs_1()
        {
            csharp strcat = new csharp();
            csharpimp Strcat = new csharpimp();
            Assert.AreEqual(strcat.ce103_strcat_cs("Hello", "nature"), "Hellonature", Strcat.ce103_strcat_cs_imported("Hello", "nature"), "Hellonature");
        }
      
        [TestMethod]
        public void ce103_strcat_cs_imported_2()
        {
            csharpimp strcat = new csharpimp();
            Assert.AreEqual(strcat.ce103_strcat_cs_imported("Computer", "room"), "Computerroom");
        }
        [TestMethod]
        public void ce103_strcat_importedcppcs_2()
        {
            csharp strcat = new csharp();
            csharpimp Strcat = new csharpimp();
            Assert.AreEqual(strcat.ce103_strcat_cs("Computer", "room"), "Computerroom", Strcat.ce103_strcat_cs_imported("Computer", "room"), "Computerroom");
        }
        
        [TestMethod]
        public void ce103_strcat_cs_imported_3()
        {
            csharpimp strcat = new csharpimp();
            Assert.AreEqual(strcat.ce103_strcat_cs_imported("great", "life"), "greatlife");
        }
        [TestMethod]
        public void ce103_strcat_importedcppcs_3()
        {
            csharp strcat = new csharp();
            csharpimp Strcat = new csharpimp();
            Assert.AreEqual(strcat.ce103_strcat_cs("great", "life"), "greatlife", Strcat.ce103_strcat_cs_imported("great", "life"), "greatlife");
        }
    
        [TestMethod]
        public void ce103_strlen_cs_imported_1()
        {
            csharpimp strlen = new csharpimp();
            Assert.AreEqual(strlen.ce103_strlen_cs_imported("life"), 4);
        }
        [TestMethod]
        public void ce103_strlen_importedcppcs_1()
        {
            csharp strlen = new csharp();
            csharpimp Strlen = new csharpimp();
            Assert.AreEqual(strlen.ce103_strlen_cs("life"), 4, Strlen.ce103_strlen_cs_imported("life"));
        }
    
        [TestMethod]
        public void ce103_strlen_cs_imported_2()
        {
            csharpimp strlen = new csharpimp();
            Assert.AreEqual(strlen.ce103_strlen_cs_imported("binary"), 6);
        }
        [TestMethod]
        public void ce103_strlen_importedcppcs_2()
        {
            csharp strlen = new csharp();
            csharpimp Strlen = new csharpimp();
            Assert.AreEqual(strlen.ce103_strlen_cs("binary"), 6, Strlen.ce103_strlen_cs_imported("binary"));
        }
  
        [TestMethod]
        public void ce103_strlen_cs_imported_3()
        {
            csharpimp strlen = new csharpimp();
            Assert.AreEqual(strlen.ce103_strlen_cs_imported("Artificial Intelligence"), 23);
        }
        [TestMethod]
        public void ce103_strlen_importedcppcs_3()
        {
            csharp strlen = new csharp();
            csharpimp Strlen = new csharpimp();
            Assert.AreEqual(strlen.ce103_strlen_cs("right"), 6, Strlen.ce103_strlen_cs_imported("right"));
        }

        [TestMethod]
        public void ce103_strcmp_cs_imported_1()
        {
            csharpimp strcmp = new csharpimp();
            Assert.AreEqual(strcmp.ce103_strcmp_cs_imported("Computer", "Computer"), 0);
        }
        [TestMethod]
        public void ce103_strcmp_importedcppcs_1()
        {
            csharp strcmp = new csharp();
            csharpimp Strcmp = new csharpimp();
            Assert.AreEqual(strcmp.ce103_strcmp_cs("Computer", "Computer"), 0, Strcmp.ce103_strcmp_cs_imported("Computer", "Computer"));
        }
     
        [TestMethod]
        public void ce103_strcmp_cs_imported_2()
        {
            csharpimp strcmp = new csharpimp();
            Assert.AreNotEqual(strcmp.ce103_strcmp_cs_imported("Computer", "Engineering"), 0);
        }
        [TestMethod]
        public void ce103_strcmp_importedcppcs_2()
        {
            csharp strcmp = new csharp();
            csharpimp Strcmp = new csharpimp();
            Assert.AreNotEqual(strcmp.ce103_strcmp_cs("Computer", "Engineering"), 0, Strcmp.ce103_strcmp_cs_imported("Computer", "Engineering"));
        }
 
        [TestMethod]
        public void ce103_strcmp_cs_imported_3()
        {
            csharpimp strcmp = new csharpimp();
            Assert.AreNotEqual(strcmp.ce103_strcmp_cs_imported("Hello", "World"), 0);
        }
        [TestMethod]
        public void ce103_strcmp_importedcppcs_3()
        {
            csharp strcmp = new csharp();
            csharpimp Strcmp = new csharpimp();
            Assert.AreNotEqual(strcmp.ce103_strcmp_cs("Hello", "World"), 0, Strcmp.ce103_strcmp_cs_imported("Hello", "World"));
        }

        [TestMethod]
        public void ce103_strcpy_cs_imported_1()
        {
            csharpimp strcpy = new csharpimp();
            Assert.AreEqual(strcpy.ce103_strcpy_cs_imported("Computer", "Hi"), "Hi");
        }
        [TestMethod]
        public void ce103_strcpy_importedcppcs_1()
        {
            csharp strcpy = new csharp();
            csharpimp Strcpy = new csharpimp();
            Assert.AreEqual(strcpy.ce103_strcpy_cs("Computer", "Hi"), "Hi", Strcpy.ce103_strcpy_cs_imported("Computer", "Hi"), "Hi");
        }
 
        [TestMethod]
        public void ce103_strcpy_cs_imported_2()
        {
            csharpimp strcpy = new csharpimp();
            Assert.AreEqual(strcpy.ce103_strcpy_cs_imported("Computer", "Engineering"), "Engineering");
        }
        [TestMethod]
        public void ce103_strcpy_importedcppcs_2()
        {
            csharp strcpy = new csharp();
            csharpimp Strcpy = new csharpimp();
            Assert.AreEqual(strcpy.ce103_strcpy_cs("Computer", "Engineering"), "Engineering", Strcpy.ce103_strcpy_cs_imported("Computer", "Engineering"), "Engineering");
        }
     
        [TestMethod]
        public void ce103_strcpy_cs_imported_3()
        {
            csharpimp strcpy = new csharpimp();
            Assert.AreEqual(strcpy.ce103_strcpy_cs_imported("Software", "Hello"), "Hello");
        }
        [TestMethod]
        public void ce103_strcpy_importedcppcs_3()
        {
            csharp strcpy = new csharp();
            csharpimp Strcpy = new csharpimp();
            Assert.AreEqual(strcpy.ce103_strcpy_cs("free", "sale"), "sale", Strcpy.ce103_strcpy_cs_imported("free", "sale"), "sale");
        }
        [TestMethod]
        public void ce103_bin2hex_cs_1()
        {
            csharp bin2hex = new csharp();
            byte[] bin = { 0xAA, 0xFB, 0xCD, 0x23, 0x43, 0x24 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { 'A', 'A', 'F', 'B', 'C', 'D', '2', '3', '4', '3', '2', '4' };

            bin2hex.ce103_bin2hex_cs(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_imported_1()
        {
            csharpimp imported = new csharpimp();
            byte[] bin = { 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A' };

            imported.ce103_bin2hex_cs_imported(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_importedcppcs_1()
        {
            csharp bin2hex = new csharp();
            csharpimp imported = new csharpimp();
            byte[] bin = { 0xAA, 0xFB, 0xCD, 0x23, 0x43, 0x24 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring1 = new char[bin.Length * 2];
            bin2hex.ce103_bin2hex_cs(bin, bin.Length, hexstring1);
            imported.ce103_bin2hex_cs_imported(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring1, hexstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_cs_2()
        {
            csharp bin2hex = new csharp();
            byte[] bin = { 0x11, 0x11, 0x11, 0x11, 0x11 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { '1', '1', '1', '1', '1', '1', '1', '1', '1', '1' };

            bin2hex.ce103_bin2hex_cs(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_imported_2()
        {
            csharpimp imported = new csharpimp();
            byte[] bin = { 0x11, 0x11, 0x11, 0x11, 0x11 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { '1', '1', '1', '1', '1', '1', '1', '1', '1', '1' };

            imported.ce103_bin2hex_cs_imported(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_importedcppcs_2()
        {
            csharp bin2hex = new csharp();
            csharpimp imported = new csharpimp();
            byte[] bin = { 0xBB, 0xFB, 0xCD, 0x23, 0x43, 0x10 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring1 = new char[bin.Length * 2];
            bin2hex.ce103_bin2hex_cs(bin, bin.Length, hexstring1);
            imported.ce103_bin2hex_cs_imported(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring1, hexstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_cs_3()
        {
            csharp bin2hex = new csharp();
            byte[] bin = { 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A' };

            bin2hex.ce103_bin2hex_cs(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_imported_3()
        {
            csharpimp imported = new csharpimp();
            byte[] bin = { 0xAA, 0xFB, 0xCD, 0x23, 0x43, 0x24 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { 'A', 'A', 'F', 'B', 'C', 'D', '2', '3', '4', '3', '2', '4' };

            imported.ce103_bin2hex_cs_imported(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_importedcppcs_3()
        {
            csharp bin2hex = new csharp();
            csharpimp imported = new csharpimp();
            byte[] bin = { 0xDD, 0xDD, 0xDD, 0xDD, 0xDD, 0xDD, 0xDD, 0xDD, 0xDD };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring1 = new char[bin.Length * 2];
            bin2hex.ce103_bin2hex_cs(bin, bin.Length, hexstring1);
            imported.ce103_bin2hex_cs_imported(bin, bin.Length, hexstring2);
            CollectionAssert.AreEqual(hexstring1, hexstring2);
        }
        [TestMethod]
        public void ce103_hex2bin_cs_1()
        {
            csharp hex2bin = new csharp();
            string hexstring = "1313131313131313";
            byte[] expectedArr = { 0x13, 0x13, 0x13, 0x13, 0x13, 0x13, 0x13, 0x13 };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs(hexstring, hexstring.Length, hexArr);

            CollectionAssert.AreEqual(expectedArr, hexArr);
        }
        [TestMethod]
        public void ce103_hex2bin_imported_1()
        {
            csharpimp hex2bin = new csharpimp();
            string hexstring = "AAFBCD234324";
            byte[] expectedArr = { 0xAA, 0xFB, 0xCD, 0x23, 0x43, 0x24 };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs_imported(hexstring, hexstring.Length, hexArr);

            CollectionAssert.AreEqual(expectedArr, hexArr);
        }
        [TestMethod]
        public void ce103_hex2bin_importedcppcs_1()
        {
            csharpimp imported = new csharpimp();
            csharp hex2bin = new csharp();
            string hexstring = "FFFFFFFFFF";

            byte[] hexArr = new byte[hexstring.Length / 2];
            imported.ce103_hex2bin_cs_imported(hexstring, hexstring.Length, hexArr);

            byte[] hexArr2 = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs(hexstring, hexstring.Length, hexArr2);

            CollectionAssert.AreEqual(hexArr, hexArr2);
        }
        [TestMethod]
        public void ce103_hex2bin_cs_2()
        {
            csharp hex2bin = new csharp();
            string hexstring = "1111111111111111";
            byte[] expectedArr = { 0x11, 0x11, 0x11, 0x11, 0x11, 0x11, 0x11, 0x11 };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs(hexstring, hexstring.Length, hexArr);

            CollectionAssert.AreEqual(expectedArr, hexArr);
        }
        [TestMethod]
        public void ce103_hex2bin_imported_2()
        {
            csharpimp hex2bin = new csharpimp();
            string hexstring = "2348975982379872239487";
            byte[] expectedArr = { 0x23, 0x48, 0x97, 0x59, 0x82, 0x37, 0x98, 0x72, 0x23, 0x94, 0x87 };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs_imported(hexstring, hexstring.Length, hexArr);

            CollectionAssert.AreEqual(expectedArr, hexArr);
        }
        [TestMethod]
        public void ce103_hex2bin_importedcppcs_2()
        {
            csharpimp imported = new csharpimp();
            csharp hex2bin = new csharp();
            string hexstring = "ABCDEAEC";
            byte[] expectedArr = { 0xAB, 0xCD, 0xEA, 0xEC };

            byte[] hexArr = new byte[hexstring.Length / 2];
            imported.ce103_hex2bin_cs_imported(hexstring, hexstring.Length, hexArr);

            byte[] hexArr2 = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs(hexstring, hexstring.Length, hexArr2);

            CollectionAssert.AreEqual(hexArr, hexArr2);
        }
        [TestMethod]
        public void ce103_hex2bin_cs_3()
        {
            csharp hex2bin = new csharp();
            string hexstring = "FAFAFAFAFAFAFAFA";
            byte[] expectedArr = { 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs(hexstring, hexstring.Length, hexArr);

            CollectionAssert.AreEqual(expectedArr, hexArr);
        }
        [TestMethod]
        public void ce103_hex2bin_imported_3()
        {
            csharpimp hex2bin = new csharpimp();
            string hexstring = "1313131313131313131313";
            byte[] expectedArr = { 0x13, 0x13, 0x13, 0x13, 0x13, 0x13, 0x13, 0x13, 0x13, 0x13, 0x13 };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs_imported(hexstring, hexstring.Length, hexArr);

            CollectionAssert.AreEqual(expectedArr, hexArr);
        }
        [TestMethod]
        public void ce103_hex2bin_importedcppcs_3()
        {
            csharpimp imported = new csharpimp();
            csharp hex2bin = new csharp();
            string hexstring = "91423FC23A234832FA";
            byte[] expectedArr = { 0x91, 0x42, 0x3F, 0xC2, 0x3A, 0x23, 0x48, 0x32, 0xFA };

            byte[] hexArr = new byte[hexstring.Length / 2];
            imported.ce103_hex2bin_cs_imported(hexstring, hexstring.Length, hexArr);

            byte[] hexArr2 = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs(hexstring, hexstring.Length, hexArr2);

            CollectionAssert.AreEqual(hexArr, hexArr2);
        }
    }
}
