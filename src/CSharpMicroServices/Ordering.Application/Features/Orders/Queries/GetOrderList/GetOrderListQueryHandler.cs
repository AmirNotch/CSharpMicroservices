using AutoMapper;
using MediatR;
using Ordering.Application.Contracts.Persistence;

namespace Ordering.Application.Features.Orders.Queries.GetOrderList;

public class GetOrdersListQueryHandler : IRequestHandler<GetOrdersListQuery, List<OrdersVm>>
{
    private readonly IOrderRepository _orderRepository;
    private readonly IMapper mapper;

    public GetOrdersListQueryHandler(IOrderRepository orderRepository, IMapper mapper)
    {
        _orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
        this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }
    
    public async Task<List<OrdersVm>> Handle(GetOrdersListQuery request, CancellationToken cancellationToken)
    {
        var orderList = await _orderRepository.GetOrderByUserName(request.UserName);
        return mapper.Map<List<OrdersVm>>(orderList);
    }
}