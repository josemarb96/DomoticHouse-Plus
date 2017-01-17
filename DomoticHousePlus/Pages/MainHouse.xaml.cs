using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=234238

namespace DomoticHousePlus.Pages
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainHouse : Page
    {
        public MainHouse()
        {
            this.InitializeComponent();

            //Primer frame que sale
            myFrame.Navigate(typeof(Pages.pageLuces));
            TitleSection.Text = "Luces";
        }

        #region Hamburguer menu
        /// <summary>
        /// Permite ver o cerrar el menú hamburguesa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HamburguerButton_Click(object sender, RoutedEventArgs e)
        {
            mySplitView.IsPaneOpen = !mySplitView.IsPaneOpen;
        }
        #endregion

        #region Cambiar frames
        /// <summary>
        /// Método que permite cambiar los frames según ´la categoría que elijamos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbLuces.IsSelected)
            {
                myFrame.Navigate(typeof(Pages.pageLuces));
                TitleSection.Text = "Luces";
            }
            else if (lbPersianas.IsSelected)
            {
                myFrame.Navigate(typeof(Pages.pagePersianas));
                TitleSection.Text = "Persianas";
            }
            else if (lbCamaras.IsSelected)
            {
                myFrame.Navigate(typeof(Pages.pageCamaras));
                TitleSection.Text = "Cámaras";
            }
            else if (lbAlarma.IsSelected)
            {
                myFrame.Navigate(typeof(Pages.pageAlarma));
                TitleSection.Text = "Alarma";
            }
        }
        #endregion
    }
}