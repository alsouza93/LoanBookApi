using LoanBook.Domains;
using System;
using Xunit;

namespace LoanBook.Api.UnitTests
{
    public class SocialNumberTest
    {       
        [Fact]
        public void SocialNumber_IsValid_ReturnTrueForValidValue()
        {
            //Arrange          
            //Act
            var result = SocialNumber.IsValid("52812349000");

            //Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData("557.287.970-32")]
        [InlineData("016.118.090-61")]
        [InlineData("143.504.220-48")]
        [InlineData("660.352.030-35")]
        [InlineData("93355758019")]
        [InlineData("77228802071")]
        [InlineData("24780314003")]    
        public void SocialNumber_IsValid_ReturnTrueForValidValues(string value)
        {
            //Arrange          
            //Act
            var result = SocialNumber.IsValid(value);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void SocialNumber_Constructor_InstanceValidValue()
        {
            //Arrange          
            //Act
            var socialNumber = SocialNumber.FromString("203.660.060-37");

            //Assert
            Assert.NotNull(socialNumber);
        }

        [Theory]
        [InlineData("00000")]
        [InlineData("000000000000")]
        [InlineData("111111111111")]
        public void SocialNumber_Constructor_ThrowsExceptionForInvalidValues(string value)
        {
            //Arrange          
            //Act   
            //Assert
            var ex = Assert.Throws<ArgumentException>(() => SocialNumber.FromString(value));
            Assert.Equal($"Invalid number [{value}]", ex.Message);           
        }

        [Fact]
        public void SocialNumber_Constructor_ThrowsExceptionForNullValues()
        {
            //Arrange          
            //Act   
            //Assert
            var ex = Assert.Throws<ArgumentNullException>(() => SocialNumber.FromString(null));
            Assert.Equal("Value cannot be null. (Parameter 'value')", ex.Message);
        }
    }
}