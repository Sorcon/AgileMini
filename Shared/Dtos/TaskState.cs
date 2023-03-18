namespace Shared.Dtos;

public enum TaskState
{
    New,
    Started,
    ReadyForTesting,
    Testing,
    Reopen,
    ReadyForRelease,
    Released
}