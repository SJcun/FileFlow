using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using FileFlow.Model.Poco;

namespace FileFlow.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// 文件夹
        /// </summary>
        private StateFolder[] _stateFolders;

        public StateFolder[] StateFolders
        {
            get => _stateFolders;
            set
            {
                _stateFolders = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;


        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
