using System.Collections.Generic;
using System.Linq;

namespace PermitSaveEditor.Data;

public class DataManager
{
    //Plagiarism is fun
    public static string ExecuteCypher(string input)
    {
        var cypherString = "QDXkW<_(V?cqK.lJ>-*y&zv9prf8biYCFeMxBm6ZnG3H4OuS1UaI5TwtoA#Rs!,7d2@L^gNhj)EP$0";
        var charArray = input.ToCharArray();

        for (var i = 0; i < input.Length; i++)
        {
            var index = cypherString.IndexOf(input[i]);
            charArray[i] = index < 0 ? input[i] : cypherString[(index + 39) % 78];
        }

        return new string(charArray);
    }

    public static bool AllEnabled(IEnumerable<bool> dataList) => dataList.All(x => x);
}