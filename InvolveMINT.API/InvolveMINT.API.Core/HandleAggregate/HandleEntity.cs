using InvolveMINT.API.SharedKernel;
namespace InvolveMINT.API.Core.HandleAggregate
{
  public class HandleEntity : IAggregateRoot
  {
    public HandleEntity()
    {
    }

    public string Id { get; set; } = null!;
  }
}

