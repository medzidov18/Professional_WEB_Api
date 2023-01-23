 namespace Menu.Persistence
{
    public class DbInitializer
    {
        public static void Initialize(MenuDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
