/**********************************************************************
 * VLC for WinRT
 **********************************************************************
 * Copyright © 2013-2018 VideoLAN and Xboxwin
 *
 * Licensed under GPLv2+ and MPLv2
 * Refer to COPYING file of the official project for license
 **********************************************************************/


namespace VLC.UI.Views
{
    interface IVLCModalFlyout
    {
        /* Return true if this flyout must be displayed in modal mode.
         * In this case, its height fits its content and it is not hidden
         * on background click. */
        bool ModalMode {get;}
    }
}
