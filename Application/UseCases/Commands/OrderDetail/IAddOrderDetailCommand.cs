﻿using Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static Application.UseCases.IUseCase;

namespace Application.UseCases.Commands.OrderDetail
{
    public interface IAddOrderDetailCommand : ICommand<AddOrderDetailDTO>
    {
    }
}
