using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using Files.Uwp.Filesystem;
using Microsoft.Toolkit.Uwp;

namespace Files.Uwp.DataModels.NavigationControlItems
{
	internal class PlaceholderItem : ObservableObject, INavigationControlItem
	{
		public int CompareTo(INavigationControlItem other) => throw new NotImplementedException();

		public string Text => "SidebarPlaceholder".GetLocalized();
		public string Path => null;
		public SectionType Section => SectionType.Placeholder;
		public string HoverDisplayText => "SidebarPlaceholder".GetLocalized();
		public NavigationControlItemType ItemType => NavigationControlItemType.Placeholder;
		public ContextMenuOptions MenuOptions => null;
	}
}
