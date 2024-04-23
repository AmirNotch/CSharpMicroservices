using FluentValidation;
using MediatR;
using Ordering.Application.Exceptions;
using ValidationException = FluentValidation.ValidationException;

namespace Ordering.Application.Behaviours;

public class ValidationBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
{
    private readonly IEnumerable<IValidator<TResponse>> _validators;

    public ValidationBehaviour(IEnumerable<IValidator<TResponse>> validators)
    {
        _validators = validators ?? throw new ArgumentNullException(nameof(validators));
    }

    public async Task<TResponse> Handle(
        TRequest request,
        RequestHandlerDelegate<TResponse> next,
        CancellationToken cancellationToken)
    {
        if (_validators.Any())
        {
            var content = new ValidationContext<TRequest>(request);
            
            var validationResult =
                await Task.WhenAll(_validators.Select(v => v.ValidateAsync(content, cancellationToken)));
            var failure = validationResult.SelectMany(r => r.Errors).Where(f => f != null).ToList();

            if (failure.Count != 0)
            {
                throw new ValidationException(failure);
            }

        }
        return await next();
    }
}