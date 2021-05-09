using BlazorWasmDemo.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasmDemo.DataServices
{
    public interface ISpaceXDataService
    {
        Task<List<LaunchesDto>> GetAllLaunches();
    }   
}
