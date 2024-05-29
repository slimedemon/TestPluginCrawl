using PluginCrawl.Models;
using System.IO;
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

            WriteAllDetailNovel();
        }

        public async void PrintAllNovelsBySearch(string keyword) 
        {
            PluginCrawlTruyenFull plugin = new PluginCrawlTruyenFull();

            var novels = await plugin.CrawlSearch(keyword);
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

        public async void PrintHotNovelsWithPage(int page)
        {
            PluginCrawlTruyenFull plugin = new PluginCrawlTruyenFull();

            var (novels, totalPage) = await plugin.CrawlHot(page);
            string txt = "\n --------------------------------- \n";
            txt = txt + "Total page: " + totalPage + "\n";
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

        public async void PrintLatestNovelsWithPage(int page)
        {
            PluginCrawlTruyenFull plugin = new PluginCrawlTruyenFull();

            var (novels, totalPage) = await plugin.CrawlLatest(page);
            string txt = "\n --------------------------------- \n";
            txt = txt + "Total page: " + totalPage + "\n";
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

        public async void PrintCompletedNovelsWithPage(int page)
        {
            PluginCrawlTruyenFull plugin = new PluginCrawlTruyenFull();

            var (novels, totalPage) = await plugin.CrawlCompleted(page);
            string txt = "\n --------------------------------- \n";
            txt = txt + "Total page: " + totalPage + "\n";
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

        public async void WriteAllDetailNovel()
        {

            PluginCrawlTruyenFull plugin = new PluginCrawlTruyenFull();

            string path = "Novels.txt";
            using (StreamWriter writer = new StreamWriter(path))
            {
                txtDisplay.AppendText("\n Loading data! \n");
                var novels = await plugin.CrawlDetailAllNovels();
                txtDisplay.AppendText("\n Loaded data! \n");

                txtDisplay.AppendText("\n Writing file! \n");
                writer.WriteLine("Total: " + novels.Length + Environment.NewLine);
                foreach (var novel in novels)
                {
                    string txt = "\n ------------------------------------------------------------------------------- \n";
                    txt = txt + "Title: " + novel.Title + "\n";
                    txt = txt + "Author: " + novel.Authors[0].Name + "\n";
                    txt = txt + "Tags: " + novel.Categories[0].Name + "\n";
                    txt = txt + "Cover: " + novel.Cover + "\n";
                    txt = txt + "Stauts: " + novel.Status + "\n";
                    txt = txt + "Rating: " + novel.Rating + "\n";
                    txt = txt + "Des: " + novel.Description + "\n";
                    txt = txt + "\n --------------- Chapter ------------------ \n";
                    foreach (var chapter in novel.Chapters)
                    {
                        txt = txt + chapter.Title + "\n";
                    }

                    writer.WriteLine(txt + Environment.NewLine);
                }
                txtDisplay.AppendText("\n Wrote date! \n");
            }
        }
    }
}