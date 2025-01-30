using MediatR;
namespace Payment_APP.Queries;
public interface IQueryHandler<TRequest, TResponse> : IRequestHandler<TRequest, TResponse>
    where TRequest : IQuery<TResponse>
{
}
