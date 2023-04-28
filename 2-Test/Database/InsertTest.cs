using Xunit;

namespace Database
{
    public class InsertTest : TestBase
    {
        [Fact]
        public async void CreateTask_IfInsertSuccess_DontThrowAnyException()
        {
            //await using (var cmd = new NpgsqlCommand("INSERT INTO data (some_field) VALUES (@p)", conn))
            //{
            //    cmd.Parameters.AddWithValue("p", "Hello world");
            //    await cmd.ExecuteNonQueryAsync();
            //}
        }
    }
}