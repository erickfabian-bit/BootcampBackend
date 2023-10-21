using Jazani.Application.Generals.Dtos.MineralTypes;

namespace Jazani.Application.Generals.Services
{
    public interface IMineralTypeService
    {
        Task<IReadOnlyList<MineralTypeDto>> FindAllAsync();
        Task<MineralTypeDto?> FindByIdAsync(int id);
        Task<MineralTypeDto> CreateAsync(MineralTypeSaveDto mineralTypeSaveDto);
        Task<MineralTypeDto> EditAsync(int id, MineralTypeSaveDto mineralTypeSaveDto);
        Task<MineralTypeDto> DisabledAsync(int id);
    }
}
