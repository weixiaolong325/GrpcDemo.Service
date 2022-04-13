using Grpc.Core;
using System;
using static GrpcDemo.Service.QueryResult.Types;

namespace GrpcDemo.Service.Services
{
    public class OrderService:Order.OrderBase
    {
        private readonly ILogger<GreeterService> _logger;
        public OrderService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// 创建订单
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task<CreateResult> CreateOrder(CreateRequest request, ServerCallContext context)
        {
            //报存数据库 todo

            return Task.FromResult(new CreateResult
            {
                Result=true,
                Message="订单创建成功"
            });
        }
        /// <summary>
        /// 查询订单
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task<QueryResult> QueryOrder(QueryRequest request, ServerCallContext context)
        {
            //查询数据库 //todo

            return Task.FromResult(new QueryResult
            {
                OrderInfo=new OrderInfo
                {
                    Id = request.Id,
                    OrderNo = DateTime.Now.ToString("yyyyMMddHHmmss"),
                    OrderName = "冰箱",
                    Price = 1288
                }
            });
        }
    }
}
