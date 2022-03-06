using System;
using System.Diagnostics;

namespace RedirectApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var prs = new ProcessStartInfo("chrome");
            prs.Arguments = "https://youtu.be/-WSBK_NePew";
            Process.Start(prs);
        }
    }
}
