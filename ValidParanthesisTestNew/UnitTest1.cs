using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Runtime.CompilerServices;
using Xunit;

namespace ValidParanthesisTestNew
{
    
    public class UnitTest1
    {
        [Theory]
        [InlineData("{}()[]}{",false)]
        public void TheoryTest_ValidParanthesis(string s, bool expectedResult)
        {
            var result = ValidParentheses20.ValidParenthesis.IsValid(s);

            Assert.True(result);
            
        }
    }
}
