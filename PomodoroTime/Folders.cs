using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PomodoroTime
{
  class Folders
  {
    public string Locations =
      Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString();
  }
}
