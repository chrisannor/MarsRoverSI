namespace MarsRoverTests
{
    using System;

    using Xunit;

    public static class TestHelper
    {
        public static void DoesNotThrows<T>(Action expressionUnderTest, string exceptionMessage = "Expected exception was thrown by target of invocation.") where T : Exception
        {
            try
            {
                expressionUnderTest();
            }
            catch (T)
            {
                Assert.True(false,"Exception thrown");
            }
            catch (Exception)
            {
                Assert.True(true);
            }

            Assert.True(true);
        }
    }
}