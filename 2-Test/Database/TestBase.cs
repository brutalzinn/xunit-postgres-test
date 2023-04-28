namespace Database
{
    public class TestBase
    {
        private string ConnectionUrl { get; set; }
        public TestBase()
        {
            ConnectionUrl = Environment.GetEnvironmentVariable("PG_URI") ?? "";
        }


    }
}
