﻿using System.Collections.ObjectModel;
using Prism.Commands;
using Prism.Regions;
using SMS.Common;
using SMS.Modules.Mail.Models;
using SMS.Modules.Mail.Services;

namespace SMS.Modules.Mail.ViewModels
{
  public class MailViewModel : ViewModelBase
  {
    private IMailService _mailService;
    private IRegionManager _regionManager;

    public MailViewModel(IMailService mailService, IRegionManager regionManager)
    {
      _regionManager = regionManager;
      _mailService = mailService;
      MailMessages = new ObservableCollection<MailMessage>(_mailService.Messages);
    }

    public DelegateCommand CommandShowDashboard => new DelegateCommand(OnShowDashboard);

    public string Greeting => "Mail Region";

    public ObservableCollection<MailMessage> MailMessages { get; private set; }

    private void OnShowDashboard()
    {
      _regionManager.RequestNavigate(RegionNames.ContentRegion, "DashboardView");
    }
  }
}
