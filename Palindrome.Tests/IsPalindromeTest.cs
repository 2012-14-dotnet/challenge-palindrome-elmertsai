using System;
using Xunit;
using Palindrome.Client;
using Palindrome.Domain.Models;

namespace Palindrome.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test_IsPalindromeExists()
        {
            User user = new User();
            var sut = user.IsPalindrome("test");

            var actual = sut;

            Assert.IsType<bool>(actual);
            Assert.NotNull(actual);
        }
    }
}
