using LoanBookApi;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Net;
using System.Net.Http;
using Xunit;

namespace LoanBook.Api.IntegrationTests
{
    public class BookTest
        : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly HttpClient httpClient;
       
        public BookTest(WebApplicationFactory<Startup> factory)
        {
            httpClient = factory.CreateClient();
        }

        [Fact]
        public void Get_Books_Return200()
        {
            // Arrange         
            // Act
            var response = httpClient.GetAsync("api/books").Result;

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);          
        }

        [Fact]
        public void Get_BooksbyId_Return200()
        {
            // Arrange         
            // Act
            var response = httpClient.GetAsync("api/books/{}").Result;

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
