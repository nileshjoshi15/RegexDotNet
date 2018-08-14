using System;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    public class UnitMod1
    {
        const string matchSucess = "{0} : @{1} {2}";
        public static void CatCatDemo(){
            string pattern = "cat";
            string subject = "catdog";

            var regex = new Regex(pattern);
            var result = regex.Match(subject);

            if(result.Success){
                Console.WriteLine(matchSucess, result.Success, result.Index, result.Length);
            }else{
                Console.WriteLine("Found : {0}",result.Success);
            }
            
        }



        public static void AlternationDemo(){
            string pattern = "dog|cat";
            string subject = "catdog";

            var regex = new Regex(pattern);
            var result = regex.Match(subject);

            if(result.Success){
                Console.WriteLine(matchSucess, result.Success, result.Index, result.Length);
            }else{
                Console.WriteLine("Found : {0}",result.Success);
            }
            
        }




        public static void RepeatDemo(){
            string pattern2 = "(dog){1, 3}"; /** min max match */
            string pattern1 = "(dog)?"; /** 0 or more match */
            string pattern3 = "(dog)?";  /** 0 or 1 match */
            string pattern  = "(dog)+";  /** 1 or more match */
            string subject = "dogdog";

            var regex = new Regex(pattern);
            var result = regex.Match(subject);

            if(result.Success){
                Console.WriteLine(matchSucess, result.Success, result.Index, result.Length);
            }else{
                Console.WriteLine("Found : {0}",result.Success);
            }
            
        }

    }
}