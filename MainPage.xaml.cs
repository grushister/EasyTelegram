using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Telegram.Bot;


namespace EasyTelegramBeta
{
    public partial class MainPage : ContentPage
    {
        static TelegramBotClient Bot;
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Bot = new TelegramBotClient(EntryOne.Text);
            Bot.SendTextMessageAsync(EntryTwo.Text, EntryThree.Text);
        }

    }
}
