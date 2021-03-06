﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SettingsAppearance.xaml.cs" company="Alexander Mohr">
//   This program is free software: you can redistribute it and/or modify
//   it under the terms of the GNU General Public License as published by
//   the Free Software Foundation, either version 3 of the License, 
//   or (at your option) any later version.
//   
//   This program is distributed in the hope that it will be useful,
//   but WITHOUT ANY WARRANTY; without even the implied warranty of
//   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//   GNU General Public License for more details.
//   
//   You should have received a copy of the GNU General Public License
//   along with this program.  If not, see <http://www.gnu.org/licenses/>.
//   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//   GNU General Public License for more details.
// </copyright>
// <summary>
//   Interaction logic for SettingsAppearance.xaml.
// </summary>
// --------------------------------------------------------------------------------------------------------------------



using System.Windows.Controls;

namespace MetroSonic.Content
{
    /// <summary>
    /// Interaction logic for SettingsAppearance.xaml.
    /// </summary>
    public partial class SettingsAppearance : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsAppearance"/> class.
        /// </summary>
        public SettingsAppearance()
        {
            InitializeComponent();

            // create and assign the appearance view model
            DataContext = new SettingsAppearanceViewModel();
        }
    }
}