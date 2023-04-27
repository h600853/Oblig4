﻿//using FrontDesk.Models;
using FrontDesk.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace FrontDesk
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private readonly MinDatabaseContext datacontext = new();

        LocalView<User> Users;
        LocalView<Reservation> Reservations;
        LocalView<Room> Rooms;


        public MainWindow()
        {
            InitializeComponent();

            Users = datacontext.Users.Local;

            Reservations = datacontext.Reservations.Local;

            Rooms = datacontext.Rooms.Local;

            datacontext.Reservations.Load();
            datacontext.Rooms.Load();
            datacontext.Users.Load();

            LoadReservations();
            //LoadRooms();


        }

        private void LoadReservations()
        {
            using (var context = new MinDatabaseContext())
            {
                var reservations = context.Reservations.Include(r => r.RoomNavigation).Include(r => r.PersonNavigation).ToList();

                reservationList.ItemsSource = reservations;
            




            }

            
        }

        public void refreshMain()
        {
            LoadReservations();

        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Editor ed = new Editor(this, datacontext);

            ed.Show();


        }

        public void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Your event handling code here
        }

        private void Search_Field_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = "";
        }

        private void Search_Field_Lost_Focus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = "Id";
                    textBox.Foreground = Brushes.Gray;
                }
            }
        }



        private void Search_Button_Click(object sender, RoutedEventArgs e)
        {
            var reservations = datacontext.Reservations.Where(r => r.Id.Equals(int.Parse(searchField.Text))).ToList();
            reservationList.ItemsSource = reservations;
            searchField.Text = "";
        }
        //Refresh
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            LoadReservations();
        }

        private void searchField_LostFocus(object sender, RoutedEventArgs e)
        {

        }
    }
}
