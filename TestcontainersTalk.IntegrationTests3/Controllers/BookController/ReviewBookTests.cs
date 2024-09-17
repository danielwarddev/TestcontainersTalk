using System.Net.Http.Json;
using AutoFixture;
using FluentAssertions;
using TestcontainersTalk.Api.Controllers;
using TestcontainersTalk.Database;

namespace TestcontainersTalk.IntegrationTests3.Controllers.BookController;

[Collection(nameof(DatabaseTestCollection))]
public class BookReviewTests : DatabaseTest
{
    public BookReviewTests(IntegrationTestFactory factory) : base(factory) {}

    [Fact]
    public async Task When_BookReview_Does_Not_Exist_In_Database_Then_Adds_It()
    {
        var expectedReview = ThisFixture.Create<BookReview>();

        await Client.PutAsJsonAsync("book/review", new ReviewBookRequest(
            expectedReview.BookId,
            expectedReview.UserId,
            expectedReview.ReviewContent
        ));

        var allBookReviews = DbContext.BookReviews.ToList();
        allBookReviews.Should().ContainSingle().Which
            .Should().BeEquivalentTo(expectedReview, 
                options => options.Excluding(x => x.Id));
    }

    [Fact]
    public async Task When_BookReview_Exists_In_Database_Already_Then_Updates_Review_Content()
    {
        var existingReview = ThisFixture.Create<BookReview>();
        await Insert(existingReview);

        var updatedReview = existingReview;
        updatedReview.ReviewContent = "This book is totally cool";

        await Client.PutAsJsonAsync("book/review", new ReviewBookRequest(
            updatedReview.BookId,
            updatedReview.UserId,
            updatedReview.ReviewContent
        ));

        var allBookReviews = DbContext.BookReviews.ToList();
        allBookReviews.Count.Should().Be(1);
        allBookReviews.Should().ContainSingle().Which
            .Should().BeEquivalentTo(updatedReview,
                options => options.Excluding(x => x.Id));
    }
}