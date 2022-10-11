﻿using ServiceLayer.DTOs.CityDto;
using ServiceLayer.DTOs.CountryDto;
using ServiceLayer.DTOs.OrderDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IOrderService
    {
        Task CreateAsync(OrderDto orderDto);

        Task UpdateAsync(int Id, OrderEditDto orderEditDto);
        Task DeleteAsync(int id);
        Task<List<OrderDto>> GetAllAsync();
        Task<OrderDto> GetAsync(int id);
        Task<OrderDto> GetByIdAsync(int id);


        //Task<IEnumerable<OrderDto>> GetAllNameAsync(string name);

    }
}
