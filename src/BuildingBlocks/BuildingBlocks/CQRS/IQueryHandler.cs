using MediatR;

namespace BuildingBlocks.CQRS;

public interface IQueryHandler<in TQuery, TResponse>
   : IRequestHandler<TQuery, TResponse>
   where TQuery : IQuery<TResponse>
   where TResponse : class // Changed 'notnull' to 'class' to ensure TResponse is a reference type  
{
}
