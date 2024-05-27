﻿using PluginCrawl.Models;
using System.Printing.IndexedProperties;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace PluginCrawl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //PluginCrawlTruyenFull plugin = new PluginCrawlTruyenFull();

            //var novels = plugin.CrawlSearch("me may").Result;
            //string txt = "\n --------------------------------- \n";
            //txtDisplay.AppendText(txt);
            //foreach (var novel in novels)
            //{
            //    txt = "\n --------------------------------- \n";
            //    txt = txt + "Title: " + novel.Title + "\n";
            //    txt = txt + "Author: " + novel.Authors[0].Name + "\n";
            //    txt = txt + "Cover: " + novel.Cover + "\n";
            //    txtDisplay.AppendText(txt);
            //}

            //var novel = plugin.CrawlDetail("thien-tai-tuong-su");
            //string txt = "\n --------------------------------- \n";
            //txt = txt + "Title: " + novel.Title + "\n";
            //txt = txt + "Author: " + novel.Authors[0].Name + "\n";
            //txt = txt + "Tags: " + novel.Categories[0].Name + "\n";
            //txt = txt + "Cover: " + novel.Cover + "\n";
            //txt = txt + "Stauts: " + novel.Status + "\n";
            //txt = txt + "Rating: " + novel.Rating + "\n";
            //txt = txt + "Des: " + novel.Description + "\n";
            //txt = txt + "\n --------------- Chapter ------------------ \n"
            //foreach (var chapter in novel.Chapters)
            //{
            //    txt = txt + chapter.Title + "\n";
            //}
            //txtDisplay.Text = txt;

            //txtDisplay.Text = plugin.CrawChapter(new Novel() { Slug = "thien-tai-tuong-su" }, new Chapter() { Slug = "chuong-8" });

            PrintNovels();

        }

        void PrintNovels() 
        {
            PluginCrawlTruyenFull plugin = new PluginCrawlTruyenFull();

            var task =  plugin.CrawlSearch("Anh Dao");
            var novels = task.Result;
            string txt = "\n --------------------------------- \n";
            txtDisplay.AppendText(txt);
            foreach (var novel in novels)
            {
                txt = "\n --------------------------------- \n";
                txt = txt + "Title: " + novel.Title + "\n";
                txt = txt + "Author: " + novel.Authors[0].Name + "\n";
                txt = txt + "Cover: " + novel.Cover + "\n";
                txtDisplay.AppendText(txt);
            }
        }
    }
}