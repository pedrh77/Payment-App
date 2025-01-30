using MediatR;

namespace Payment_APP.Queries;

public interface IQuery<TResponse> : IRequest<TResponse>
{
}
