﻿using MediatR;
using Ordering.Application.Mapper;
using Ordering.Application.Queries;
using Ordering.Application.Responses;
using Ordering.Core.Entities;
using Ordering.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ordering.Application.Handlers
{
    public class OrderByUserNameHandler : IRequestHandler<GertOrderByUserNameQuery, IEnumerable<OrderResponse>>
    {
        private readonly IOrderRepository _orderRepository;

        public OrderByUserNameHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<IEnumerable<OrderResponse>> Handle(GertOrderByUserNameQuery request, CancellationToken cancellationToken)
        {
            var orderList = await _orderRepository.GetOrdersByUserName(request.UserName);

            var orderResponseList = OrderMapper.Mapper.Map<IEnumerable<OrderResponse>>(orderList);

            return orderResponseList;
        }
    }
}
