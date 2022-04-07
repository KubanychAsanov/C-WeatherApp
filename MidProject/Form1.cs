using Newtonsoft.Json;
using System.Net;

namespace MidProject
{
    public partial class WeatherApp : Form
    {
        public WeatherApp()
        {
            InitializeComponent();
        }

        string APIKey = "b447c1a7213b24edcff904cb1a82a55f";

        private void search_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        void getWeather() {
            using (WebClient wc = new WebClient())
            {
                string url = String.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=metric", city.Text, APIKey);

                var json = wc.DownloadString(url);

                WeatherInfo.root? root = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                WeatherInfo.root Info = root;

                picIcon.ImageLocation = $"https://api.openweathermap.org/img/w/{Info.weather[0].icon}.png";
                desc.Text = Info.weather[0].description;
                gradus.Text = Info.main.temp.ToString() + " °C";
            }
        }
    }
}