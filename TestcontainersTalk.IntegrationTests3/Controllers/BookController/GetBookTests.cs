using System.Net.Http.Json;
using AutoFixture;
using FluentAssertions;
using TestcontainersTalk.Database;

namespace TestcontainersTalk.IntegrationTests3.Controllers.BookController;

[Collection(nameof(DatabaseTestCollection))]
public class GetBookTests : DatabaseTest
{
    public GetBookTests(IntegrationTestFactory factory) : base(factory) {}

    [Fact]
    public async Task When_Book_Exists_Then_Returns_It()
    {
        var existingBook = ThisFixture.Create<Book>();
        await Insert(existingBook);
        
        var book = await Client.GetFromJsonAsync<Book>($"book/{existingBook.Name}");

        book.Should().NotBeNull();
    }
}