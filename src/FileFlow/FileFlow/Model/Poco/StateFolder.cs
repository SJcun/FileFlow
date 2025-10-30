using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace FileFlow.Model.Poco
{
    public class StateFolder
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public SolidColorBrush Color { get; set; }

        public StateFolder(string name, string path, SolidColorBrush color)
        {
            Name = name;
            Path = path;
            Color = color;
        }
    }
}
