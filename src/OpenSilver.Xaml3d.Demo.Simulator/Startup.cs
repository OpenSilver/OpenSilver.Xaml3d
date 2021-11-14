using OpenSilver.Simulator;
using System;

namespace OpenSilver.Xaml3d.Demo.Simulator
{
    static class Startup
    {
        [STAThread]
        static int Main(string[] args)
        {
            return SimulatorLauncher.Start(typeof(App));
        }
    }
}
