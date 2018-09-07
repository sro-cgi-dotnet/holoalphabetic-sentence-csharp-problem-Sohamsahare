using System;
using System.Linq;

namespace HoloalphabeticSentence
{
    public class HoloalphabeticSentence
    {
        // Write the logic to determine whether the input string is a HoloalphabeticSentence or not
        public static bool IsHoloalphabeticSentence(string sentence, string alphabets = "abcdefghijklmnopqrstuvwxyz")
        {
            // change to lowercase
            sentence = sentence.ToLower();
            // array to count occurence of each alphabet
            int[] characterSet = new int[26];
            int asciiValue = -1;
            // if sum is 26 then it's an holoalphabetic sentence
            int sum = 0;
            const int characterOffset = 97;
            // checking for each alphabet
            for(int i = 0; i < sentence.Length; i++){
                asciiValue = sentence[i] - characterOffset;
                if(asciiValue >= 0){
                    characterSet[asciiValue] = 1;
                }
            }
            // summing all output
            for(int i = 0; i < 26; i++){
                sum += characterSet[i];
            }
            // final check
            if(sum == 26){
                return true;
            }
            return false;
        }
    }
}