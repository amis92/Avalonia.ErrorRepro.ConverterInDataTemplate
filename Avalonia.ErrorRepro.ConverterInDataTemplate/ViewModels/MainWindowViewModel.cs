using System;
using System.Collections.Generic;
using System.Text;

namespace Avalonia.ErrorRepro.ConverterInDataTemplate.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting => "Hello World!";

        public Custom1ViewModel Custom1 { get; } = new Custom1ViewModel() { Name = "Custom1 Name" };

        public Custom2ViewModel Custom2 { get; } = new Custom2ViewModel();
    }
}
