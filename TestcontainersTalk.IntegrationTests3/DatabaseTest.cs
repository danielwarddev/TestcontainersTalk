using AutoFixture;
using TestcontainersTalk.Database;

namespace TestcontainersTalk.IntegrationTests3;

public abstract class DatabaseTest : IAsyncLifetime
{
    protected readonly Fixture ThisFixture = new();
    protected readonly HttpClient Client;
    protected readonly BookstoreContext DbContext;
    private readonly Func<Task> _resetDatabase;

    public DatabaseTest(IntegrationTestFactory factory)
    {
        _resetDatabase = factory.ResetDatabase;
        DbContext = factory.Db;
        Client = factory.CreateClient();
    }

    public async Task Insert<T>(T entity) where T : class
    {
        await DbContext.AddAsync(entity);
        await DbContext.SaveChangesAsync();
    }
    
    public async Task InsertMany<T>(IEnumerable<T> entities) where T : class
    {
        await DbContext.AddRangeAsync(entities);
        await DbContext.SaveChangesAsync();
    }

    public Task InitializeAsync() => Task.CompletedTask;

    public Task DisposeAsync()
    {
        DbContext.ChangeTracker.Clear();
        return _resetDatabase();
    }
}