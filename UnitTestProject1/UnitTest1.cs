using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDwithBaseBallGame;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        /// <summary>
        /// GetStrikeCount를 테스트하는 메서드
        /// </summary>
        [TestMethod]
        public void TestGetStrikeCountMethod()
        {
            BaseBallClass baseBallObject = new BaseBallClass();

            Assert.AreEqual(0, baseBallObject.GetStrikeCount("123", "456"));
            Assert.AreEqual(3, baseBallObject.GetStrikeCount("123", "123"));

            Assert.AreEqual(2, baseBallObject.GetStrikeCount("563", "163"));

            Assert.AreEqual(1, baseBallObject.GetStrikeCount("123", "156"));
        }




        /// <summary>
        /// GetBallCount를 테스트하는 메서드
        /// </summary>
        [TestMethod]
        public void TestGetBallCountMethod()
        {

            BaseBallClass baseBallObject = new BaseBallClass();


            Assert.AreEqual(0, baseBallObject.GetBallCount("123", "465"));

            Assert.AreEqual(1, baseBallObject.GetBallCount("123", "415"));

            Assert.AreEqual(1, baseBallObject.GetBallCount("421", "127"));

            Assert.AreEqual(0, baseBallObject.GetBallCount("190", "190"));

            Assert.AreEqual(3, baseBallObject.GetBallCount("123", "312"));

        }



        /// <summary>
        /// CheckIsOut을 테스트하는 메서드
        /// 
        /// 조건 : 양의 3자리숫자 문자열이 각각 들어감을 가정
        /// </summary>
        [TestMethod]
        public void TestCheckIsOutMethod()
        {
            BaseBallClass baseBallObject = new BaseBallClass();

            Assert.IsTrue(baseBallObject.CheckIsOut("123", "465"));

            Assert.IsFalse(baseBallObject.CheckIsOut("123", "176"));

            Assert.IsFalse(baseBallObject.CheckIsOut("111", "111"));


        }


        /// <summary>
        /// GenerateNumber를 테스트하는 메서드
        /// </summary>
        [TestMethod]
        public void TestGenerateNumberMethod()
        {
            BaseBallClass baseBallObject = new BaseBallClass();

            Assert.IsTrue(BaseBallClass.CheckValidNumber
                (baseBallObject.GenerateNumber().ToString()));

        }


        /// <summary>
        /// CheckValidNumber메서드를 테스트하는 메서드
        /// </summary>
        [TestMethod]
        public void TestCheckValidNumberMethod()
        {
            //숫자이므로 true 반환 기대
            Assert.IsTrue(BaseBallClass.CheckValidNumber("546"));

            //숫자가 아니므로 false 반환 기대
            Assert.IsFalse(BaseBallClass.CheckValidNumber("asdf"));

            //4자리 숫자이므로 false 반환 기대
            Assert.IsFalse(BaseBallClass.CheckValidNumber("1234"));

            //숫자이지만 3자리가 아니므로 false 반환 기대
            Assert.IsFalse(BaseBallClass.CheckValidNumber("0"));

            //숫자이지만 음수이므로 false 반환 기대
            Assert.IsFalse(BaseBallClass.CheckValidNumber("-12"));

            //숫자가 아니므로 false 반환 기대
            Assert.IsFalse(BaseBallClass.CheckValidNumber("1-1"));
        }


      
    }
}
