using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2910_Lab_1
{
    public class VideoGame :IComparable<VideoGame>
    {
        public string Name { get; set; }
        public string Platform { get; set; }
        public string Year { get; set; }
        public string Genre { get; set; }
        public string Publisher { get; set; }
        public string NA_Sales { get; set; }
        public string EU_Sales { get; set; }
        public string JP_Sales { get; set; }
        public string Other_Sales { get; set; }
        public string Global_Sales { get; set; }

        public VideoGame(string name, string platform, string year, string genre, string publisher, string na_sales, string eu_sales, string jp_sales, string other_sales, string global_sales)
        {
            Name = name;
            Platform = platform;
            Year = year;
            Genre = genre;
            Publisher = publisher;
            NA_Sales = na_sales;
            EU_Sales = eu_sales;
            JP_Sales = jp_sales;
            Other_Sales = other_sales;
            Global_Sales = global_sales;
        }

        public VideoGame() { }

        public int CompareTo(VideoGame other)
        {
            return Name.CompareTo(other.Name);
        }

        public override string ToString()
        {
            string msg = $"Title: {Name} \n" +
                $"Platform: {Platform} \n" +
                $"Year: {Year} Genre: {Genre} \n" +
                $"Publisher: {Publisher} \n" +
                $"NASales: {NA_Sales}  EUSales: {EU_Sales} \n" +
                $"JPSales: {JP_Sales}  Other Sales: {Other_Sales}  Global Sales: {Global_Sales}";

            return msg;
        }
    }
}
