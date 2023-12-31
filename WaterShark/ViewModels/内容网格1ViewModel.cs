using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;

using WaterShark.Contracts.ViewModels;
using WaterShark.Core.Contracts.Services;
using WaterShark.Core.Models;

namespace WaterShark.ViewModels;

public partial class 内容网格1ViewModel : ObservableRecipient, INavigationAware
{
    private readonly ISampleDataService _sampleDataService;

    public ObservableCollection<SampleOrder> Source { get; } = new ObservableCollection<SampleOrder>();

    public 内容网格1ViewModel(ISampleDataService sampleDataService)
    {
        _sampleDataService = sampleDataService;
    }

    public async void OnNavigatedTo(object parameter)
    {
        Source.Clear();

        // TODO: Replace with real data.
        var data = await _sampleDataService.GetGridDataAsync();

        foreach (var item in data)
        {
            Source.Add(item);
        }
    }

    public void OnNavigatedFrom()
    {
    }
}
