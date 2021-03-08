using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6Task2
{
    class MyString
    {
        char[] myCharArray;
        public int Length { get { return myCharArray.Length; } }
      
        public MyString()
        {
            myCharArray = new char[0];
        }

        public MyString(params char[] chars)
        {
            myCharArray = chars;
        }
        public MyString(string @string) 
        {
            myCharArray = @string.ToCharArray();
        }

        public bool Contains(char charForSearching) 
        {
            for (int i = 0; i < myCharArray.Length; i++)
            {
                if (myCharArray[i] == charForSearching)
                    return true;
            }
            return false;
        }
        public int? IndexOf(char charForSearching) 
        {
            int? index = null;
            for (int i = 0; i < myCharArray.Length; i++)
            {
                if (myCharArray[i] == charForSearching)
                {
                    index = i;
                    return index;
                }
            }
            return index;
        }


        public static MyString operator +(MyString firstCharArray, MyString secondCharArray)
        {
            MyString result = new MyString();
            result.myCharArray = new char[firstCharArray.myCharArray.Length + secondCharArray.myCharArray.Length];
            Array.Copy(firstCharArray.myCharArray, 0, result.myCharArray, 0, firstCharArray.myCharArray.Length);
            Array.Copy(secondCharArray.myCharArray, 0, result.myCharArray,firstCharArray.myCharArray.Length, secondCharArray.myCharArray.Length);
            return result;
        }
        public static MyString operator+ (MyString string1, char char1) 
        {
            MyString result = new MyString();
            result.myCharArray = new char[string1.myCharArray.Length +1];
            Array.Copy(string1.myCharArray, 0, result.myCharArray, 0, string1.myCharArray.Length);
            result.myCharArray[result.myCharArray.GetUpperBound(0)] = char1;
            return result;
        }
        public char[] ShowMyString() 
        {
            return myCharArray;
        }
    }
}
