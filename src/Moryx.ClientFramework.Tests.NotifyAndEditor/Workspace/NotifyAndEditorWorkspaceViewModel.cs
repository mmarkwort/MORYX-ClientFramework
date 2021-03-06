// Copyright (c) 2020, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

using System;
using Moryx.Container;

namespace Moryx.ClientFramework.Tests.NotifyAndEditor
{
    [Plugin(LifeCycle.Singleton, typeof(IModuleWorkspace), Name = ScreenName)]
    public class NotifyAndEditorWorkspaceViewModel : ModuleWorkspace
    {
        internal const string ScreenName = "NotifyAndEditorTestScreen";
        internal Action StopTimer { get; set; }
        internal Action ResetNotifications { get; set; }
        internal Action StartTimer { get; set; }

        private void SetEditMode(bool isEditing)
        {
            CurrentInteraction = isEditing ? WorkspaceInteraction.Editing : WorkspaceInteraction.Idle;
        }

        #region ViewProperties
        private bool _isEditing;
        public bool IsEditing
        {
            get
            {
                return _isEditing;
            }
            set
            {
                _isEditing = value;
                SetEditMode(_isEditing);
                NotifyOfPropertyChange(() => IsEditing);
            }
        }

        public void CmdStopTimer()
        {
            StopTimer();
        }

        public void CmdResetNotifications()
        {
            ResetNotifications();
        }

        public void CmdStartTimer()
        {
            StartTimer();
        }

        #endregion
    }
}
