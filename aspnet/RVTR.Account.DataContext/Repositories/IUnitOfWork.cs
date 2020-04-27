using System.Threading.Tasks;

namespace RVTR.Account.DataContext.Repositories
{
  /// <summary>
  /// Represents the _UnitOfWork_ interface
  /// </summary>
  public interface IUnitOfWork
  {
    /// <summary>
    /// Represents the _UnitOfWork_ `Commit` method
    /// </summary>
    Task<int> CommitAsync();
  }
}
