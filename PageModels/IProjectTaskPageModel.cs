using AdopcciondeMascotas.Models;
using CommunityToolkit.Mvvm.Input;

namespace AdopcciondeMascotas.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}