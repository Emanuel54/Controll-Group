using ControlGroup.Model;
using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ControlGroup.ViewModel
{
    class MainPageViewModel : FreshBasePageModel
    {
        private ObservableCollection<MenuModel> menuItems = new ObservableCollection<MenuModel>();

        public ObservableCollection<MenuModel> MenuItems
        {
            get => menuItems;
            set
            {
                menuItems = value;
            }
        }


        public MainPageViewModel()
        {
            LoadData();
        }


        public void LoadData()
        {
            MenuItems.Add(new MenuModel() { Name = "Groups", Description = "This section is to see their Groups" });

            MenuItems.Add(new MenuModel() { Name = "Discussion", Description = "This section is to see their Discussions" });

            MenuItems.Add(new MenuModel() { Name = "Discussion Specials", Description = "This section is to see their Discussions Specials" });


        }





    }
}
