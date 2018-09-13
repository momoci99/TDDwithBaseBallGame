using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDwithBaseBallGame
{
    public class BaseBallClass
    {

        private string hiddenNumber = string.Empty;

        public BaseBallClass()
        {
            hiddenNumber = GenerateNumber().ToString();
        }

        public string GetHiddenNumber()
        {
            return hiddenNumber;
        }


        public int GetStrikeCount(string hiddenNumber, string inputNumber)
        {
            char[] hiddenNumberArray;
            char[] inputNumberArray;

            int strikeCount = 0;

            hiddenNumberArray = hiddenNumber.ToCharArray();
            inputNumberArray = inputNumber.ToCharArray();


            for (int outerIndex = 0; outerIndex < hiddenNumberArray.Length; outerIndex++)
            {
                for (int innerIndex = 0; innerIndex < inputNumberArray.Length; innerIndex++)
                {
                    if (hiddenNumberArray[outerIndex].Equals(inputNumberArray[innerIndex]))
                    {
                        strikeCount++;
                    }
                }
            }


            return strikeCount;
        }

        public int GetBallCount(string hiddenNumber, string inputNumber)
        {
            
            char[] inputNumberArray;

            int ballCount = 0;

            
            inputNumberArray = inputNumber.ToCharArray();


            
            for (int innerIndex = 0; innerIndex < inputNumberArray.Length; innerIndex++)
            {
                //숫자의 위치와 일치하는 위치가 달라야 ball Count ++
                //같으면 스트라이크지;;

                int numberIndex = hiddenNumber.IndexOf(inputNumberArray[innerIndex]);

                if (numberIndex >= 0 && numberIndex != innerIndex)
                {
                    ballCount++;
                }
                
            }
            

            return ballCount;

        }


        public bool CheckIsOut(string hiddenNumber, string inputNumber)
        {
            char[] hiddenNumberArray;
            char[] inputNumberArray;


            hiddenNumberArray = hiddenNumber.ToCharArray();
            inputNumberArray = inputNumber.ToCharArray();


            for(int outerIndex = 0; outerIndex < hiddenNumberArray.Length; outerIndex++)
            {
                for(int innerIndex = 0; innerIndex < inputNumberArray.Length; innerIndex++)
                {
                    if (hiddenNumberArray[outerIndex].Equals(inputNumberArray[innerIndex]))
                    {
                        return false;
                    }
                }
            }


            return true;
        }



        /// <summary>
        /// 랜덤한 3자리 양의 숫자를 생성
        /// </summary>
        /// <returns></returns>
        public int GenerateNumber()
        {
            Random rnd = new Random();
            return rnd.Next(1, 999);
        }


        /// <summary>
        /// CheckValidNumber
        /// 숫자인지, 3자리가 맞는지확인하는 함수
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool CheckValidNumber(string number)
        {
            int tempNumber = 0;

            if (number.Length == 3)
            {
                if (int.TryParse(number, out tempNumber))
                {
                    if (tempNumber > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
