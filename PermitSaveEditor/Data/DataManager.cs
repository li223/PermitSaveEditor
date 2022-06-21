using System.Collections.Generic;
using System.Linq;

namespace PermitSaveEditor.Data
{
    public class DataManager
    {
        //Plagiarism is fun
        public static string ExecuteCypher(string input)
        {
            string cypherString = "QDXkW<_(V?cqK.lJ>-*y&zv9prf8biYCFeMxBm6ZnG3H4OuS1UaI5TwtoA#Rs!,7d2@L^gNhj)EP$0";
            var charArray = input.ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {
                int index = cypherString.IndexOf(input[i]);
                charArray[i] = ((index < 0) ? input[i] : cypherString[(index + 39) % 78]);
            }

            return new(charArray);
        }

        public static IEnumerable<bool> UnlockAll(List<bool> dataList)
        {
            dataList.ForEach(x =>
            {
                if (!x) x = !x;
            });
            return dataList;
        }

        public static bool AllEnabled(List<bool> dataList) => dataList.All(x => x);
    }
}
