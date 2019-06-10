using System;

namespace BindKraftAutomation.Globals
{
    public static class Helpers
    {
        public static Func<string, string, int, string[]> assertByStartHtml =
        (content, expected, sliceLength) =>
        {
            string[] result = new string[2];
            result[0] = "true";
            result[1] = "Pass";

            var textStart = content.Trim().Substring(0, sliceLength);

            if (textStart != expected)
            {
                result[0] = "false";
                result[1] = textStart + " was different than the expected: " + expected;
            }

            return result;
        };

        //Sample - used in KraftBoardMenu() [//Assert.That(testBoardPopUp(), "Kraft board pop up error.");]
       // public bool testBoardPopUp()
       // {
        //    var len = BoardsPopContent.Text.Length;
         //   var textStart = BoardsPopContent.Text.Trim().Substring(0, 6);
         //   var textEnd = BoardsPopContent.Text.Substring(len - 6);
         //
         //   if (BoardsPopTitle.Text != "Boards" ||
         //       textStart != "Easily" ||
         //       textEnd != "teams.")
         //   {
         //       return false;
        //    }

        //    return true;
       // }


    }
}
