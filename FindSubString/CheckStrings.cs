using System;

namespace FindSubString
{
    //GOAL:
    //Return -1 if the substring does not exist in the firstString
    //If the substring does exist then we return the first position where
    //it does exist.

    class CheckStrings
    {
        //TODO: Write unit test

        static void Main(string[] args)
        {
            Console.WriteLine(positionThatContains("dsfddfnjdks", "Jane")); // -1 or Does not exist in string
            Console.WriteLine(positionThatContains("GemMMADFSFES", "FSF")); // 8th letter
            Console.ReadLine();
        }

        public static int positionThatContains(string firstString , string substringCheck )
        {
            //Begin looping through indexes of the first string
            for (int i = 0; i < firstString.Length; i++)
            {

                //If we have a case where the first letter of "substringCheck" appears in one
                //of the indexes of the firstString then this is a possible 
                if(firstString[i] == substringCheck[0])
                {

                    //Loop through second string checking if all of the following indexes match
                    for (int j = 0; j < substringCheck.Length; j++)
                    {

                        //our case that continues to check if the following letters match
                        if (firstString[i + j] == substringCheck[j])
                        {
                            //If we've reached the end then this matches 
                            if (j == substringCheck.Length-1)
                            {
                                //Return we're we started
                                return i;
                            }

                            //If they do match we're continuing
                            continue;
                        }

                        //If subsequent letters don't match then we're breaking out of this case
                        else break;
                    }
                }

            }

            //If there were no cases that met the conditions above 
            return -1;
        }
    }
}
