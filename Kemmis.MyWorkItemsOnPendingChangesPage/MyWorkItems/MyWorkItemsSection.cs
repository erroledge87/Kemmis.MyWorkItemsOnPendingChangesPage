﻿using Microsoft.TeamFoundation.Controls;
using Microsoft.TeamFoundation.Controls.WPF.TeamExplorer;

namespace Kemmis.MyWorkItemsOnPendingChangesPage.MyWorkItems
{
    internal abstract class MyWorkItemsSection : TeamExplorerSectionBase
    {
        protected override ITeamExplorerSection CreateViewModel(SectionInitializeEventArgs e)
        {
            return new MyWorkItemsSectionViewModel();
        }

        protected override object CreateView(SectionInitializeEventArgs e)
        {
            var view = new MyWorkItemsSectionView();
            return view;
        }

        protected override void InitializeView(SectionInitializeEventArgs e)
        {
            base.InitializeView(e);
            var view = View as MyWorkItemsSectionView;
            // do intit stuff here if needed
        }

        public override void Initialize(object sender, SectionInitializeEventArgs e)
        {
            base.Initialize(sender, e);
            if (ViewModel != null && ViewModel is MyWorkItemsSectionViewModel && View != null &&
                View is MyWorkItemsSectionView)
            {
                var viewModel = (MyWorkItemsSectionViewModel) ViewModel;
                var view = (MyWorkItemsSectionView) View;

                // add some commands if needed

                //workItemsSectionViewModel.SectionCommands = new ITeamExplorerSectionCommand[2]
                //{
                //    new TeamExplorerSectionCommand(workItemsSectionViewModel.ToggleAddByIdCommand, GitControlsResources.Get("CommandLinkText_AddWorkItemById"), WpfUtil.SharedResources["PlusIconBrush"] as DrawingBrush),
                //    new TeamExplorerSectionCommand(workItemsSectionView.ShowQueriesMenuCommand, GitControlsResources.Get("CommandLinkText_Queries"), WpfUtil.SharedResources["FlatListIconBrush"] as DrawingBrush)
                //};
            }
        }
    }
}