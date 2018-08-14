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
    }
}