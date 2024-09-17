using System.Net.Http.Json;
using AutoFixture;
using FluentAssertions;
using TestcontainersTalk.Api.Controllers;
using TestcontainersTalk.Database;

namespace TestcontainersTalk.IntegrationTests3.Controllers.BookController;

[Collection(nameof(DatabaseTestCollection))]
public class LikeBookTests : DatabaseTest
{
    public LikeBookTests(IntegrationTestFactory factory) : base(factory) {}

    [Fact]
    public async Task When_BookLike_Does_Not_Exist_In_Database_Then_Adds_It()
    {
        var expectedLike = ThisFixture.Create<BookLike>();
        
        await Client.PutAsJsonAsync("book/like", new LikeBookRequest
        {
            BookId = expectedLike.BookId,
            UserId = expectedLike.UserId
        });

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Should().ContainSingle().Which
            .Should().BeEquivalentTo(expectedLike, 
                options => options.Excluding(x => x.Id));
    }

    [Fact]
    public async Task When_BookLike_Exists_In_Database_Already_Then_Does_Nothing()
    {
        var existingBookLike = ThisFixture.Create<BookLike>();
        await Insert(existingBookLike);

        await Client.PutAsJsonAsync("book/like", new LikeBookRequest
        {
            BookId = existingBookLike.BookId,
            UserId = existingBookLike.UserId
        });

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Should().ContainSingle();
    }
}