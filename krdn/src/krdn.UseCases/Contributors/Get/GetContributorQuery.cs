using Ardalis.Result;
using Ardalis.SharedKernel;

namespace krdn.UseCases.Contributors.Get;
public record GetContributorQuery(int ContributorId) : IQuery<Result<ContributorDTO>>;
