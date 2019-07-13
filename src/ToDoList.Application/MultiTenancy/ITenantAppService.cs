using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ToDoList.MultiTenancy.Dto;

namespace ToDoList.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

