using AutoFixture;
using FluentAssertions;
using TestcontainersTalk.Api;
using TestcontainersTalk.Database;

namespace TestcontainersTalk.IntegrationTests3;

[Collection(nameof(DatabaseTestCollection2))]
public class LotsOfTests1 : DatabaseTest, IAsyncLifetime
{
    private readonly BookService _bookService;

    public LotsOfTests1(IntegrationTestFactory factory) : base(factory)
    {
        _bookService = new BookService(DbContext);
    }
    
    public new async Task InitializeAsync()
    {
        var books = ThisFixture.CreateMany<Book>(100);
        await InsertMany(books);
        await base.InitializeAsync();
    }

    [Fact]
    public async Task When_BookLike_Does_Not_Exist_In_Database_Then_Adds_It_23()
    {
        var expectedLike = ThisFixture.Create<BookLike>();

        await _bookService.LikeBook(expectedLike.BookId, expectedLike.UserId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
        allBookLikes[0].Should().BeEquivalentTo(expectedLike,
            options => options.Excluding(x => x.Id));
    }

    [Fact]
    public async Task When_BookLike_Exists_In_Database_Already_Then_Does_Nothing_23()
    {
        var gutendexId = ThisFixture.Create<int>();
        var userId = ThisFixture.Create<int>();

        await Insert(new BookLike()
        {
            BookId = gutendexId,
            UserId = userId
        });

        await _bookService.LikeBook(gutendexId, userId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
    }

    [Fact]
    public async Task When_BookLike_Does_Not_Exist_In_Database_Then_Adds_It_54()
    {
        var expectedLike = ThisFixture.Create<BookLike>();

        await _bookService.LikeBook(expectedLike.BookId, expectedLike.UserId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
        allBookLikes[0].Should().BeEquivalentTo(expectedLike,
            options => options.Excluding(x => x.Id));
    }

    [Fact]
    public async Task When_BookLike_Exists_In_Database_Already_Then_Does_Nothing_54()
    {
        var gutendexId = ThisFixture.Create<int>();
        var userId = ThisFixture.Create<int>();

        await Insert(new BookLike()
        {
            BookId = gutendexId,
            UserId = userId
        });

        await _bookService.LikeBook(gutendexId, userId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
    }

    [Fact]
    public async Task When_BookLike_Does_Not_Exist_In_Database_Then_Adds_It_85()
    {
        var expectedLike = ThisFixture.Create<BookLike>();

        await _bookService.LikeBook(expectedLike.BookId, expectedLike.UserId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
        allBookLikes[0].Should().BeEquivalentTo(expectedLike,
            options => options.Excluding(x => x.Id));
    }

    [Fact]
    public async Task When_BookLike_Exists_In_Database_Already_Then_Does_Nothing_85()
    {
        var gutendexId = ThisFixture.Create<int>();
        var userId = ThisFixture.Create<int>();

        await Insert(new BookLike()
        {
            BookId = gutendexId,
            UserId = userId
        });

        await _bookService.LikeBook(gutendexId, userId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
    }

    [Fact]
    public async Task When_BookLike_Does_Not_Exist_In_Database_Then_Adds_It_116()
    {
        var expectedLike = ThisFixture.Create<BookLike>();

        await _bookService.LikeBook(expectedLike.BookId, expectedLike.UserId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
        allBookLikes[0].Should().BeEquivalentTo(expectedLike,
            options => options.Excluding(x => x.Id));
    }

    [Fact]
    public async Task When_BookLike_Exists_In_Database_Already_Then_Does_Nothing_116()
    {
        var gutendexId = ThisFixture.Create<int>();
        var userId = ThisFixture.Create<int>();

        await Insert(new BookLike()
        {
            BookId = gutendexId,
            UserId = userId
        });

        await _bookService.LikeBook(gutendexId, userId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
    }

    [Fact]
    public async Task When_BookLike_Does_Not_Exist_In_Database_Then_Adds_It_147()
    {
        var expectedLike = ThisFixture.Create<BookLike>();

        await _bookService.LikeBook(expectedLike.BookId, expectedLike.UserId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
        allBookLikes[0].Should().BeEquivalentTo(expectedLike,
            options => options.Excluding(x => x.Id));
    }

    [Fact]
    public async Task When_BookLike_Exists_In_Database_Already_Then_Does_Nothing_147()
    {
        var gutendexId = ThisFixture.Create<int>();
        var userId = ThisFixture.Create<int>();

        await Insert(new BookLike()
        {
            BookId = gutendexId,
            UserId = userId
        });

        await _bookService.LikeBook(gutendexId, userId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
    }

    [Fact]
    public async Task When_BookLike_Does_Not_Exist_In_Database_Then_Adds_It_178()
    {
        var expectedLike = ThisFixture.Create<BookLike>();

        await _bookService.LikeBook(expectedLike.BookId, expectedLike.UserId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
        allBookLikes[0].Should().BeEquivalentTo(expectedLike,
            options => options.Excluding(x => x.Id));
    }

    [Fact]
    public async Task When_BookLike_Exists_In_Database_Already_Then_Does_Nothing_178()
    {
        var gutendexId = ThisFixture.Create<int>();
        var userId = ThisFixture.Create<int>();

        await Insert(new BookLike()
        {
            BookId = gutendexId,
            UserId = userId
        });

        await _bookService.LikeBook(gutendexId, userId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
    }

    [Fact]
    public async Task When_BookLike_Does_Not_Exist_In_Database_Then_Adds_It_209()
    {
        var expectedLike = ThisFixture.Create<BookLike>();

        await _bookService.LikeBook(expectedLike.BookId, expectedLike.UserId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
        allBookLikes[0].Should().BeEquivalentTo(expectedLike,
            options => options.Excluding(x => x.Id));
    }

    [Fact]
    public async Task When_BookLike_Exists_In_Database_Already_Then_Does_Nothing_209()
    {
        var gutendexId = ThisFixture.Create<int>();
        var userId = ThisFixture.Create<int>();

        await Insert(new BookLike()
        {
            BookId = gutendexId,
            UserId = userId
        });

        await _bookService.LikeBook(gutendexId, userId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
    }

    [Fact]
    public async Task When_BookLike_Does_Not_Exist_In_Database_Then_Adds_It_240()
    {
        var expectedLike = ThisFixture.Create<BookLike>();

        await _bookService.LikeBook(expectedLike.BookId, expectedLike.UserId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
        allBookLikes[0].Should().BeEquivalentTo(expectedLike,
            options => options.Excluding(x => x.Id));
    }

    [Fact]
    public async Task When_BookLike_Exists_In_Database_Already_Then_Does_Nothing_240()
    {
        var gutendexId = ThisFixture.Create<int>();
        var userId = ThisFixture.Create<int>();

        await Insert(new BookLike()
        {
            BookId = gutendexId,
            UserId = userId
        });

        await _bookService.LikeBook(gutendexId, userId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
    }

    [Fact]
    public async Task When_BookLike_Does_Not_Exist_In_Database_Then_Adds_It_271()
    {
        var expectedLike = ThisFixture.Create<BookLike>();

        await _bookService.LikeBook(expectedLike.BookId, expectedLike.UserId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
        allBookLikes[0].Should().BeEquivalentTo(expectedLike,
            options => options.Excluding(x => x.Id));
    }

    [Fact]
    public async Task When_BookLike_Exists_In_Database_Already_Then_Does_Nothing_271()
    {
        var gutendexId = ThisFixture.Create<int>();
        var userId = ThisFixture.Create<int>();

        await Insert(new BookLike()
        {
            BookId = gutendexId,
            UserId = userId
        });

        await _bookService.LikeBook(gutendexId, userId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
    }

    [Fact]
    public async Task When_BookLike_Does_Not_Exist_In_Database_Then_Adds_It_302()
    {
        var expectedLike = ThisFixture.Create<BookLike>();

        await _bookService.LikeBook(expectedLike.BookId, expectedLike.UserId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
        allBookLikes[0].Should().BeEquivalentTo(expectedLike,
            options => options.Excluding(x => x.Id));
    }

    [Fact]
    public async Task When_BookLike_Exists_In_Database_Already_Then_Does_Nothing_302()
    {
        var gutendexId = ThisFixture.Create<int>();
        var userId = ThisFixture.Create<int>();

        await Insert(new BookLike()
        {
            BookId = gutendexId,
            UserId = userId
        });

        await _bookService.LikeBook(gutendexId, userId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
    }

    [Fact]
    public async Task When_BookLike_Does_Not_Exist_In_Database_Then_Adds_It_333()
    {
        var expectedLike = ThisFixture.Create<BookLike>();

        await _bookService.LikeBook(expectedLike.BookId, expectedLike.UserId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
        allBookLikes[0].Should().BeEquivalentTo(expectedLike,
            options => options.Excluding(x => x.Id));
    }

    [Fact]
    public async Task When_BookLike_Exists_In_Database_Already_Then_Does_Nothing_333()
    {
        var gutendexId = ThisFixture.Create<int>();
        var userId = ThisFixture.Create<int>();

        await Insert(new BookLike()
        {
            BookId = gutendexId,
            UserId = userId
        });

        await _bookService.LikeBook(gutendexId, userId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
    }

    [Fact]
    public async Task When_BookLike_Does_Not_Exist_In_Database_Then_Adds_It_364()
    {
        var expectedLike = ThisFixture.Create<BookLike>();

        await _bookService.LikeBook(expectedLike.BookId, expectedLike.UserId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
        allBookLikes[0].Should().BeEquivalentTo(expectedLike,
            options => options.Excluding(x => x.Id));
    }

    [Fact]
    public async Task When_BookLike_Exists_In_Database_Already_Then_Does_Nothing_364()
    {
        var gutendexId = ThisFixture.Create<int>();
        var userId = ThisFixture.Create<int>();

        await Insert(new BookLike()
        {
            BookId = gutendexId,
            UserId = userId
        });

        await _bookService.LikeBook(gutendexId, userId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
    }

    [Fact]
    public async Task When_BookLike_Does_Not_Exist_In_Database_Then_Adds_It_395()
    {
        var expectedLike = ThisFixture.Create<BookLike>();

        await _bookService.LikeBook(expectedLike.BookId, expectedLike.UserId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
        allBookLikes[0].Should().BeEquivalentTo(expectedLike,
            options => options.Excluding(x => x.Id));
    }

    [Fact]
    public async Task When_BookLike_Exists_In_Database_Already_Then_Does_Nothing_395()
    {
        var gutendexId = ThisFixture.Create<int>();
        var userId = ThisFixture.Create<int>();

        await Insert(new BookLike()
        {
            BookId = gutendexId,
            UserId = userId
        });

        await _bookService.LikeBook(gutendexId, userId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
    }

    [Fact]
    public async Task When_BookLike_Does_Not_Exist_In_Database_Then_Adds_It_426()
    {
        var expectedLike = ThisFixture.Create<BookLike>();

        await _bookService.LikeBook(expectedLike.BookId, expectedLike.UserId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
        allBookLikes[0].Should().BeEquivalentTo(expectedLike,
            options => options.Excluding(x => x.Id));
    }

    [Fact]
    public async Task When_BookLike_Exists_In_Database_Already_Then_Does_Nothing_426()
    {
        var gutendexId = ThisFixture.Create<int>();
        var userId = ThisFixture.Create<int>();

        await Insert(new BookLike()
        {
            BookId = gutendexId,
            UserId = userId
        });

        await _bookService.LikeBook(gutendexId, userId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
    }

    [Fact]
    public async Task When_BookLike_Does_Not_Exist_In_Database_Then_Adds_It_457()
    {
        var expectedLike = ThisFixture.Create<BookLike>();

        await _bookService.LikeBook(expectedLike.BookId, expectedLike.UserId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
        allBookLikes[0].Should().BeEquivalentTo(expectedLike,
            options => options.Excluding(x => x.Id));
    }

    [Fact]
    public async Task When_BookLike_Exists_In_Database_Already_Then_Does_Nothing_457()
    {
        var gutendexId = ThisFixture.Create<int>();
        var userId = ThisFixture.Create<int>();

        await Insert(new BookLike()
        {
            BookId = gutendexId,
            UserId = userId
        });

        await _bookService.LikeBook(gutendexId, userId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
    }

    [Fact]
    public async Task When_BookLike_Does_Not_Exist_In_Database_Then_Adds_It_488()
    {
        var expectedLike = ThisFixture.Create<BookLike>();

        await _bookService.LikeBook(expectedLike.BookId, expectedLike.UserId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
        allBookLikes[0].Should().BeEquivalentTo(expectedLike,
            options => options.Excluding(x => x.Id));
    }

    [Fact]
    public async Task When_BookLike_Exists_In_Database_Already_Then_Does_Nothing_488()
    {
        var gutendexId = ThisFixture.Create<int>();
        var userId = ThisFixture.Create<int>();

        await Insert(new BookLike()
        {
            BookId = gutendexId,
            UserId = userId
        });

        await _bookService.LikeBook(gutendexId, userId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
    }

    [Fact]
    public async Task When_BookLike_Does_Not_Exist_In_Database_Then_Adds_It_519()
    {
        var expectedLike = ThisFixture.Create<BookLike>();

        await _bookService.LikeBook(expectedLike.BookId, expectedLike.UserId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
        allBookLikes[0].Should().BeEquivalentTo(expectedLike,
            options => options.Excluding(x => x.Id));
    }

    [Fact]
    public async Task When_BookLike_Exists_In_Database_Already_Then_Does_Nothing_519()
    {
        var gutendexId = ThisFixture.Create<int>();
        var userId = ThisFixture.Create<int>();

        await Insert(new BookLike()
        {
            BookId = gutendexId,
            UserId = userId
        });

        await _bookService.LikeBook(gutendexId, userId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
    }

    [Fact]
    public async Task When_BookLike_Does_Not_Exist_In_Database_Then_Adds_It_550()
    {
        var expectedLike = ThisFixture.Create<BookLike>();

        await _bookService.LikeBook(expectedLike.BookId, expectedLike.UserId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
        allBookLikes[0].Should().BeEquivalentTo(expectedLike,
            options => options.Excluding(x => x.Id));
    }

    [Fact]
    public async Task When_BookLike_Exists_In_Database_Already_Then_Does_Nothing_550()
    {
        var gutendexId = ThisFixture.Create<int>();
        var userId = ThisFixture.Create<int>();

        await Insert(new BookLike()
        {
            BookId = gutendexId,
            UserId = userId
        });

        await _bookService.LikeBook(gutendexId, userId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
    }

    [Fact]
    public async Task When_BookLike_Does_Not_Exist_In_Database_Then_Adds_It_581()
    {
        var expectedLike = ThisFixture.Create<BookLike>();

        await _bookService.LikeBook(expectedLike.BookId, expectedLike.UserId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
        allBookLikes[0].Should().BeEquivalentTo(expectedLike,
            options => options.Excluding(x => x.Id));
    }

    [Fact]
    public async Task When_BookLike_Exists_In_Database_Already_Then_Does_Nothing_581()
    {
        var gutendexId = ThisFixture.Create<int>();
        var userId = ThisFixture.Create<int>();

        await Insert(new BookLike()
        {
            BookId = gutendexId,
            UserId = userId
        });

        await _bookService.LikeBook(gutendexId, userId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
    }

    [Fact]
    public async Task When_BookLike_Does_Not_Exist_In_Database_Then_Adds_It_612()
    {
        var expectedLike = ThisFixture.Create<BookLike>();

        await _bookService.LikeBook(expectedLike.BookId, expectedLike.UserId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
        allBookLikes[0].Should().BeEquivalentTo(expectedLike,
            options => options.Excluding(x => x.Id));
    }

    [Fact]
    public async Task When_BookLike_Exists_In_Database_Already_Then_Does_Nothing_612()
    {
        var gutendexId = ThisFixture.Create<int>();
        var userId = ThisFixture.Create<int>();

        await Insert(new BookLike()
        {
            BookId = gutendexId,
            UserId = userId
        });

        await _bookService.LikeBook(gutendexId, userId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
    }

    [Fact]
    public async Task When_BookLike_Does_Not_Exist_In_Database_Then_Adds_It_643()
    {
        var expectedLike = ThisFixture.Create<BookLike>();

        await _bookService.LikeBook(expectedLike.BookId, expectedLike.UserId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
        allBookLikes[0].Should().BeEquivalentTo(expectedLike,
            options => options.Excluding(x => x.Id));
    }

    [Fact]
    public async Task When_BookLike_Exists_In_Database_Already_Then_Does_Nothing_643()
    {
        var gutendexId = ThisFixture.Create<int>();
        var userId = ThisFixture.Create<int>();

        await Insert(new BookLike()
        {
            BookId = gutendexId,
            UserId = userId
        });

        await _bookService.LikeBook(gutendexId, userId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
    }

    [Fact]
    public async Task When_BookLike_Does_Not_Exist_In_Database_Then_Adds_It_674()
    {
        var expectedLike = ThisFixture.Create<BookLike>();

        await _bookService.LikeBook(expectedLike.BookId, expectedLike.UserId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
        allBookLikes[0].Should().BeEquivalentTo(expectedLike,
            options => options.Excluding(x => x.Id));
    }

    [Fact]
    public async Task When_BookLike_Exists_In_Database_Already_Then_Does_Nothing_674()
    {
        var gutendexId = ThisFixture.Create<int>();
        var userId = ThisFixture.Create<int>();

        await Insert(new BookLike()
        {
            BookId = gutendexId,
            UserId = userId
        });

        await _bookService.LikeBook(gutendexId, userId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
    }

    [Fact]
    public async Task When_BookLike_Does_Not_Exist_In_Database_Then_Adds_It_705()
    {
        var expectedLike = ThisFixture.Create<BookLike>();

        await _bookService.LikeBook(expectedLike.BookId, expectedLike.UserId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
        allBookLikes[0].Should().BeEquivalentTo(expectedLike,
            options => options.Excluding(x => x.Id));
    }

    [Fact]
    public async Task When_BookLike_Exists_In_Database_Already_Then_Does_Nothing_705()
    {
        var gutendexId = ThisFixture.Create<int>();
        var userId = ThisFixture.Create<int>();

        await Insert(new BookLike()
        {
            BookId = gutendexId,
            UserId = userId
        });

        await _bookService.LikeBook(gutendexId, userId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
    }

    [Fact]
    public async Task When_BookLike_Does_Not_Exist_In_Database_Then_Adds_It_736()
    {
        var expectedLike = ThisFixture.Create<BookLike>();

        await _bookService.LikeBook(expectedLike.BookId, expectedLike.UserId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
        allBookLikes[0].Should().BeEquivalentTo(expectedLike,
            options => options.Excluding(x => x.Id));
    }

    [Fact]
    public async Task When_BookLike_Exists_In_Database_Already_Then_Does_Nothing_736()
    {
        var gutendexId = ThisFixture.Create<int>();
        var userId = ThisFixture.Create<int>();

        await Insert(new BookLike()
        {
            BookId = gutendexId,
            UserId = userId
        });

        await _bookService.LikeBook(gutendexId, userId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
    }

    [Fact]
    public async Task When_BookLike_Does_Not_Exist_In_Database_Then_Adds_It_767()
    {
        var expectedLike = ThisFixture.Create<BookLike>();

        await _bookService.LikeBook(expectedLike.BookId, expectedLike.UserId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
        allBookLikes[0].Should().BeEquivalentTo(expectedLike,
            options => options.Excluding(x => x.Id));
    }

    [Fact]
    public async Task When_BookLike_Exists_In_Database_Already_Then_Does_Nothing_767()
    {
        var gutendexId = ThisFixture.Create<int>();
        var userId = ThisFixture.Create<int>();

        await Insert(new BookLike()
        {
            BookId = gutendexId,
            UserId = userId
        });

        await _bookService.LikeBook(gutendexId, userId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
    }

    [Fact]
    public async Task When_BookLike_Does_Not_Exist_In_Database_Then_Adds_It_798()
    {
        var expectedLike = ThisFixture.Create<BookLike>();

        await _bookService.LikeBook(expectedLike.BookId, expectedLike.UserId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
        allBookLikes[0].Should().BeEquivalentTo(expectedLike,
            options => options.Excluding(x => x.Id));
    }

    [Fact]
    public async Task When_BookLike_Exists_In_Database_Already_Then_Does_Nothing_798()
    {
        var gutendexId = ThisFixture.Create<int>();
        var userId = ThisFixture.Create<int>();

        await Insert(new BookLike()
        {
            BookId = gutendexId,
            UserId = userId
        });

        await _bookService.LikeBook(gutendexId, userId);

        var allBookLikes = DbContext.BookLikes.ToList();
        allBookLikes.Count.Should().Be(1);
    }
}