using System;

namespace SJB.ZAR.WPF
  {
  public class ApplicationEntry
    {
    [STAThread]
    public static void Main(String[] args)
      {
      ApplicationSingleInstance singleinstanceapp = new ApplicationSingleInstance();
      singleinstanceapp.Run(args);
      }
    }
  }