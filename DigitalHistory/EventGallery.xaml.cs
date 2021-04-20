using System.Collections.Generic;
using System.Windows;

using System;
using System.IO;
using System.Collections;

namespace DigitalHistory
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class EventGallery : Window
    {
        public EventGallery()
        {
            InitializeComponent();

            string[] files = Directory.GetFiles(@"C:\");
            string[] foders = Directory.GetDirectories(@"C:\");
            var Events = GetEvents();
            if (Events.Count > 0)
                ListViewEvents.ItemsSource = Events;
        }

        private List<Event> GetEvents()
        {
            return new List<Event>()
            {
                new Event("사진1", "2020-01-01", "/Assets/1.jpg"),
                new Event("사진2", "2020-01-02", "/Assets/2.jpg"),
                new Event("사진3", "2020-01-03", "/Assets/3.jpg"),
                new Event("사진4", "2020-01-04", "/Assets/4.jpg"),
                new Event("사진5", "2020-01-05", "/Assets/5.jpg"),
                new Event("사진6", "2020-01-06", "/Assets/6.jpg"),
                new Event("사진7", "2020-01-07", "/Assets/7.jpg"),
                new Event("사진8", "2020-01-08", "/Assets/8.jpg"),
                new Event("사진9", "2020-01-09", "/Assets/9.jpg"),
                new Event("사진10", "2020-01-10", "/Assets/10.jpg"),
                new Event("사진11", "2020-01-11", "/Assets/11.jpg"),
                new Event("사진12", "2020-01-12", "/Assets/12.jpg")
            };
        }
    }
}