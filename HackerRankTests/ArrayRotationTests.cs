using System;
using NUnit.Framework;
using HackerRank;
namespace HackerRankTests
{
    [TestFixture]
    public class ArrayRotationTests
    {
        private ArrayRotation _sut;

        [SetUp]
        public void Init()
        {
          _sut=new ArrayRotation("1 2 3 4 5");
        }
        [Test]
        public void Should_return_array_zero_times_rotated()
        {
            var result= _sut.RotateRight(5,0);
           var expected = new int[]{1 ,2, 3, 4 ,5};
             Assert.AreEqual(result,expected);
        }

        //[TestCase(5,1)]
        [TestCase(5,3)]

        public void Should_return_array_r_time_rotated(int length,int r)
        {
          var result=_sut.RotateRight(length,r);
          var expected=new int[]{3,4,5,1,2};
          Assert.AreEqual(expected,result);
        }

        [TestCase(5,1, new int[]{2 ,3 ,4 ,5 ,1})]
        [TestCase(5,2, new int[]{3 ,4 ,5 ,1 ,2})]
        [TestCase(5,3, new int[]{4 ,5 ,1 ,2 ,3})]
        [TestCase(5,4, new int[]{5 ,1 ,2 ,3 ,4})]
        public void Should_return_array_r_times_left_rotated(int length,int r,int[] expected)
        {
           var result=_sut.RotateLeft(length,r);
            Assert.AreEqual(expected,result);
        }

    }
}
