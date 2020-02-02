namespace PokerPlamApi.Models
{
  public class PokerPlamDatabaseSettings : IPokerPlamDatabaseSettings
  {
    public string UsersCollectionName { get; set; }
    public string ConnectionString { get; set; }
    public string DatabaseName { get; set; }
  }

  public interface IPokerPlamDatabaseSettings
  {
    string UsersCollectionName { get; set; }
    string ConnectionString { get; set; }
    string DatabaseName { get; set; }
  }
}