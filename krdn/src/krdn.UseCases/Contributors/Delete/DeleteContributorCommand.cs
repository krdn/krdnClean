using Ardalis.Result;
using Ardalis.SharedKernel;

namespace krdn.UseCases.Contributors.Delete;
public record DeleteContributorCommand(int ContributorId) : ICommand<Result>;
