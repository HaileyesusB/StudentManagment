using Microsoft.Extensions.Logging;
using Studmgt.Application.Features;
using Studmgt.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Studmgt.Application.Services
{
    public interface IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly ILogger<StudentService> _logger;
        public OrderService(IOrderRepository orderRepository, ILogger<OrderService> logger)
        {
            _orderRepository = orderRepository;
            _logger = logger;
        }

        public async Task<Guid> AddAsync(OrderEntity orderEntity)
        {
            var model = orderEntity.MapToModel();
            var data = await _orderRepository.AddAsync(model);
            return data.Id;
        }

        public async Task DeleteOrder(Guid guid)
        {
            try
            {
                var order = await _orderRepository.GetByIdAsync(guid);
                if (order == null)
                    throw new NotFoundException(nameof(Order), guid);
                await _orderRepository.DeleteAsync(order);
            }
            catch (Exception e)
            {
                _logger.LogError($"Error Occured : {e.Message}");
                throw;
            }
        }

        public async Task<IEnumerable<OrderEntity>> GetAllOrders()
        {
            var orders = await _orderRepository.GetAllAsync();
            return orders?.Select(o => new OrderEntity(o)).ToList();
        }

        public async Task<OrderEntity> GetByIdAsync(Guid guid)
        {
            var order = await _orderRepository.GetByIdAsync(guid);
            return new OrderEntity(order);
        }

        public async Task<IEnumerable<OrderEntity>> GetOrderByUser(string userName)
        {
            try
            {
                var order = (await _orderRepository.GetQueryAsync(x => x.UserName == userName)).ToList();
                return order?.Select(x => new OrderEntity(x));
            }
            catch (Exception e)
            {

                _logger.LogError($"Error Occured : {e.Message}");
                return Enumerable.Empty<OrderEntity>();
            }
        }

        public async Task UpdateAsync(OrderEntity orderEntity)
        {
            try
            {
                await _orderRepository.UpdateAsync(orderEntity.MapToModel());
            }
            catch (Exception e)
            {
                _logger.LogError($"Error Occured : {e.Message}");
            }
}
