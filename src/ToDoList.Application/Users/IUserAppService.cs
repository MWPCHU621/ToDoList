using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ToDoList.Roles.Dto;
using ToDoList.Users.Dto;

namespace ToDoList.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
