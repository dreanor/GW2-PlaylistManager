﻿using System.Collections.Generic;
using System.Windows;

namespace PlaylistManager.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var ambientViewModel = new PlaylistViewModel("Ambient", "Music that plays when no other criteria are met");
            var battleViewModel = new PlaylistViewModel("Battle", "Music that plays in \"large\" fights involving many foes (~5 or more enemies); some personal story steps; PvP");
            var bossBattleViewModel = new PlaylistViewModel("BossBattle", "Music that plays when fighting world bosses and some Dungeon bosses; some personal story steps; some Activities");
            var cityViewModel = new PlaylistViewModel("City", "Music that plays when inside one of the main cities, such as The Black Citadel, but not always");
            var defeatedViewModel = new PlaylistViewModel("Defeated", "Music that plays upon being Defeated");
            var mainMenuViewModel = new PlaylistViewModel("MainMenu", "Music that plays at the character select screen");
            var nightTimeViewModel = new PlaylistViewModel("NightTime", "Music that plays when in some explorable areas and it is nighttime (the moon is out)");
            var underwaterViewModel = new PlaylistViewModel("Underwater", "Music that plays any time the breathing apparatus is equipped. Overrides most other playlists");
            var victoryViewModel = new PlaylistViewModel("Victory", "Music that plays after World bosses or Meta events");

            List<TabContainer> containers = new List<TabContainer>
            {
                new TabContainer(ambientViewModel.Header, new PlaylistView(ambientViewModel), ambientViewModel),
                new TabContainer(battleViewModel.Header, new PlaylistView(battleViewModel), battleViewModel),
                new TabContainer(bossBattleViewModel.Header, new PlaylistView(bossBattleViewModel), bossBattleViewModel),
                new TabContainer(cityViewModel.Header, new PlaylistView(cityViewModel), cityViewModel),
                new TabContainer(defeatedViewModel.Header, new PlaylistView(defeatedViewModel), defeatedViewModel),
                new TabContainer(mainMenuViewModel.Header, new PlaylistView(mainMenuViewModel), mainMenuViewModel),
                new TabContainer(nightTimeViewModel.Header, new PlaylistView(nightTimeViewModel), nightTimeViewModel),
                new TabContainer(underwaterViewModel.Header, new PlaylistView(underwaterViewModel), underwaterViewModel),
                new TabContainer(victoryViewModel.Header, new PlaylistView(victoryViewModel), victoryViewModel)
            };

            ViewModel viewModel = new ViewModel(containers);
            View view = new View(viewModel);
            view.Show();
        }
    }
}
