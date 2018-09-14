using System;
using IB.CSharpApiClient.Messages;
using NUnit.Framework;

namespace IB.CSharpApiClient.Tests
{
    public class ApiEventDispatcherTests
    {
        private ApiClientMessageDispatcher _apiClientMessageDispatcher;

        [SetUp]
        public void Init()
        {
            _apiClientMessageDispatcher = new ApiClientMessageDispatcher();
        }

        [Test]
        public void Should_Get_ErrorEventArgs_With_Exception_When_Calling_Error()
        {
            // Arrange
            ErrorMessage errorMessage = null;
            _apiClientMessageDispatcher.Error += (args) => { errorMessage = args; };

            // Act
            _apiClientMessageDispatcher.error(new Exception());

            // Assert
            Assert.IsNotNull(errorMessage.Exception);
        }

        [Test]
        public void Should_Get_ErrorEventArgs_With_ErrorMsg_When_Calling_Error()
        {
            // Arrange
            var errorMsg = "ErrorMsg";
            ErrorMessage errorMessage = null;
            _apiClientMessageDispatcher.Error += (args) => { errorMessage = args; };

            // Act
            _apiClientMessageDispatcher.error(errorMsg);

            // Assert
            Assert.AreEqual(errorMessage.Message, errorMsg);
        }

        [Test]
        public void Should_Get_ErrorEventArgs_With_Values_When_Calling_Error()
        {
            // Arrange
            var requestId = int.MinValue;
            var errorCode = int.MaxValue;
            var errorMsg = "ErrorMsg";
            ErrorMessage errorMessage = null;
            _apiClientMessageDispatcher.Error += (args) => { errorMessage = args; };

            // Act
            _apiClientMessageDispatcher.error(requestId, errorCode, errorMsg);

            // Assert
            Assert.AreEqual(errorMessage.RequestId, requestId);
            Assert.AreEqual(errorMessage.ErrorCode, errorCode);
            Assert.AreEqual(errorMessage.Message, errorMsg);
        }

        [Test]
        public void Should_Get_CurrentTimeEventArgs_When_Calling_CurrentTime()
        {
            // Arrange
            var time = DateTime.Now.Ticks;
            TimeMessage timeMessage = null;
            _apiClientMessageDispatcher.Time += (args) => { timeMessage = args; };

            // Act
            _apiClientMessageDispatcher.currentTime(time);

            // Assert
            Assert.AreEqual(timeMessage.CurrentTime, time);
        }
    }
}