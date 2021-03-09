using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6Task2
{
    class MyString
    {
        List<char> myStringList;
        public int Length { get { return myStringList.Count; } }
        public char this[int index]
        {
            get { return myStringList[index]; }
            set { myStringList[index] = value; }
        }
        public MyString()
        {
            myStringList = new List<char>();
        }
        public MyString(params char[] chars)
        {
            myStringList = new List<char>();
            myStringList.AddRange(chars);
        }
        public MyString(string @string)
        {
            myStringList = new List<char>();
            myStringList.AddRange(@string.ToCharArray());
        }
        public bool Contains(char charForSearching)
        {
            if (myStringList.Contains(charForSearching))
                return true;
            else return false;
        }
        public bool Contains(char[] charArrayForSearching)
        {
            int counter = 0;
            for (int i = 0; i < myStringList.Count; i++)
            {
                if (counter == charArrayForSearching.Length)
                    return true;
                for (int j = counter; j < charArrayForSearching.Length;)
                {
                    if (myStringList[i] == charArrayForSearching[j])
                    {
                        counter++;
                        break;
                    }
                    else
                    {
                        counter = 0;
                        break;
                    }
                }
            }
            return false;

        }
        public int IndexOf(char charForSearching)
        {
            int index;
            index = myStringList.IndexOf(charForSearching);
            return index;
        }
        public static MyString operator +(MyString firstStringList, MyString secondStringList)
        {
            firstStringList.myStringList.AddRange(secondStringList.myStringList);
            return firstStringList;
        }
        public static MyString operator +(MyString firstStringList, char char1)
        {
            firstStringList.myStringList.Add(char1);
            return firstStringList;
        }
        public static MyString operator +(MyString firstStringList, char[] charArr)
        {
            firstStringList.myStringList.AddRange(charArr);
            return firstStringList;
        }
        public static MyString operator +(MyString firstStringList, string firststring)
        {
            firstStringList.myStringList.AddRange(firststring);
            return firstStringList;
        }

        public char[] ShowMyString()
        {
            char[] result = myStringList.ToArray();
            return result;
        }
    }
}
