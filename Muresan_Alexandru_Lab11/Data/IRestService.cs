﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using Muresan_Alexandru_Lab11.Models;

namespace Muresan_Alexandru_Lab11.Data
{
    public interface IRestService
    {
        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);

    }
}
