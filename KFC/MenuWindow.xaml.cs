using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace KFC
{
    /// <summary>
    /// Логика взаимодействия для MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        int sum;
        public MenuWindow()
        {
            InitializeComponent();
            logo.Visibility = Visibility.Collapsed;
            tbfin.Visibility = Visibility.Collapsed;
        }
        public void BurgersBtn_Click(object sender, RoutedEventArgs e)
        {
            FirstRowBurgers.Visibility = Visibility.Visible;
            FirstRowBurgersTBox.Visibility = Visibility.Visible;
            SecondRowBurgers.Visibility = Visibility.Visible;
            SecondRowBurgersTBox.Visibility = Visibility.Visible;
            ThirdRowBurger.Visibility = Visibility.Visible;
            ThirdRowBurgerTBox.Visibility = Visibility.Visible;
            FirstRowDesert.Visibility = Visibility.Collapsed;
            FirstRowDesertTBox.Visibility = Visibility.Collapsed;
            FirstRowSnacks.Visibility = Visibility.Collapsed;
            FirstRowSnacksTBOx.Visibility = Visibility.Collapsed;
            FirstRowTvister.Visibility = Visibility.Collapsed;
            FirstRowTvisterTBOx.Visibility = Visibility.Collapsed;
        }

        public void DesertsBtn_Click(object sender, RoutedEventArgs e)
        {
            FirstRowBurgers.Visibility = Visibility.Collapsed;
            FirstRowBurgersTBox.Visibility = Visibility.Collapsed;
            SecondRowBurgers.Visibility = Visibility.Collapsed;
            SecondRowBurgersTBox.Visibility = Visibility.Collapsed;
            ThirdRowBurger.Visibility = Visibility.Collapsed;
            ThirdRowBurgerTBox.Visibility = Visibility.Collapsed;
            FirstRowDesert.Visibility = Visibility.Visible;
            FirstRowDesertTBox.Visibility = Visibility.Visible;
            FirstRowSnacks.Visibility = Visibility.Collapsed;
            FirstRowSnacksTBOx.Visibility = Visibility.Collapsed;
            FirstRowTvister.Visibility = Visibility.Collapsed;
            FirstRowTvisterTBOx.Visibility = Visibility.Collapsed;
        }

        public void TvistersBtn_Click(object sender, RoutedEventArgs e)
        {
            FirstRowBurgers.Visibility = Visibility.Collapsed;
            FirstRowBurgersTBox.Visibility = Visibility.Collapsed;
            SecondRowBurgers.Visibility = Visibility.Collapsed;
            SecondRowBurgersTBox.Visibility = Visibility.Collapsed;
            ThirdRowBurger.Visibility = Visibility.Collapsed;
            ThirdRowBurgerTBox.Visibility = Visibility.Collapsed;
            FirstRowDesert.Visibility = Visibility.Collapsed;
            FirstRowDesertTBox.Visibility = Visibility.Collapsed;
            FirstRowSnacks.Visibility = Visibility.Collapsed;
            FirstRowSnacksTBOx.Visibility = Visibility.Collapsed;
            FirstRowTvister.Visibility = Visibility.Visible;
            FirstRowTvisterTBOx.Visibility = Visibility.Visible;
        }

        public void SnacksBtn_Click(object sender, RoutedEventArgs e)
        {
            FirstRowBurgers.Visibility = Visibility.Collapsed;
            FirstRowBurgersTBox.Visibility = Visibility.Collapsed;
            SecondRowBurgers.Visibility = Visibility.Collapsed;
            SecondRowBurgersTBox.Visibility = Visibility.Collapsed;
            ThirdRowBurger.Visibility = Visibility.Collapsed;
            ThirdRowBurgerTBox.Visibility = Visibility.Collapsed;
            FirstRowDesert.Visibility = Visibility.Collapsed;
            FirstRowDesertTBox.Visibility = Visibility.Collapsed;
            FirstRowSnacks.Visibility = Visibility.Visible;
            FirstRowSnacksTBOx.Visibility = Visibility.Visible;
            FirstRowTvister.Visibility = Visibility.Collapsed;
            FirstRowTvisterTBOx.Visibility = Visibility.Collapsed;
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            Itogg();
            MessageBox.Show("Оплата прошла успешно: " + sum + " рублей");
        }

        public string Itogg()
        {
            FirstRowBurgers.Visibility = Visibility.Collapsed;
            FirstRowBurgersTBox.Visibility = Visibility.Collapsed;
            SecondRowBurgers.Visibility = Visibility.Collapsed;
            SecondRowBurgersTBox.Visibility = Visibility.Collapsed;
            ThirdRowBurger.Visibility = Visibility.Collapsed;
            ThirdRowBurgerTBox.Visibility = Visibility.Collapsed;
            FirstRowDesert.Visibility = Visibility.Collapsed;
            FirstRowDesertTBox.Visibility = Visibility.Collapsed;
            FirstRowSnacks.Visibility = Visibility.Collapsed;
            FirstRowSnacksTBOx.Visibility = Visibility.Collapsed;
            FirstRowTvister.Visibility = Visibility.Collapsed;
            FirstRowTvisterTBOx.Visibility = Visibility.Collapsed;
            BurgersBtn.Visibility = Visibility.Collapsed;
            TvistersBtn.Visibility = Visibility.Collapsed;
            SnacksBtn.Visibility = Visibility.Collapsed;
            DesertsBtn.Visibility = Visibility.Collapsed;
            logo.Visibility = Visibility.Visible;
            tbfin.Visibility = Visibility.Visible;
            Itog.Text = "Итог" + " " + sum;
            Itog.Visibility = Visibility.Visible;
            string itogg = Itog.Text;
            return itogg;
        }

        public void BigBBtn_Click(object sender, RoutedEventArgs e)
        {
            BigBurger();
        }

        public void ZingerBBtn_Click(object sender, RoutedEventArgs e)
        {
            ZingerBurger();
        }

        public void HotSandersBBtn_Click(object sender, RoutedEventArgs e)
        {
            HotSandersBurger();
        }

        public void SandersBBtn_Click(object sender, RoutedEventArgs e)
        {
            SandersBurger();
        }

        public void BlackBBtn_Click(object sender, RoutedEventArgs e)
        {
            BlackBurger();
        }

        public void ChiefBBtn_Click(object sender, RoutedEventArgs e)
        {
            ChiefBurger();
        }

        public void TropicDesertBtn_Click(object sender, RoutedEventArgs e)
        {
            sum += 109;
            tbfin.AppendText(Environment.NewLine + "Тропический десерт\t\t\t\t109 р.");
        }

        public void TiramisuBtn_Click(object sender, RoutedEventArgs e)
        {
            sum += 99;
            tbfin.AppendText(Environment.NewLine + "Тирамису\t\t\t\t99 р.");
        }

        public void TvisterBtn_Click(object sender, RoutedEventArgs e)
        {
            sum += 159;
            tbfin.AppendText(Environment.NewLine + "Оригинальный твистер\t\t\t\t159 р.");
        }

        public void TvisterJuniorBtn_Click(object sender, RoutedEventArgs e)
        {
            sum += 99;
            tbfin.AppendText(Environment.NewLine + "Твистер джуниор\t\t\t\t99 р.");
        }

        public void FriBtn_Click(object sender, RoutedEventArgs e)
        {
            sum += 69;
            tbfin.AppendText(Environment.NewLine + "Картофель фри\t\t\t\t69 р.");
        }

        public void PoDerevenskiBtn_Click(object sender, RoutedEventArgs e)
        {
            PoDerevenski();
        }

        public double PoDerevenski()
        {
            sum += 79;
            tbfin.AppendText(Environment.NewLine + "Картофель по-деревенски\t\t\t\t79 р.");
            return sum;
        }
        public double BigBurger()
        {
            sum += 215;
            tbfin.AppendText(Environment.NewLine + "Биг бургер\t\t\t\t215 р.");
            return sum;
        }
        public double ZingerBurger()
        {
            sum += 110;
            tbfin.AppendText(Environment.NewLine + "Зингер\t\t\t\t110 р.");
            return sum;
        }
        public double HotSandersBurger()
        {
            sum += 135;
            tbfin.AppendText(Environment.NewLine + "Острый сандерс\t\t\t\t135 р.");
            return sum;
        }
        public double SandersBurger()
        {
            sum += 135;
            tbfin.AppendText(Environment.NewLine + "Сандерс\t\t\t\t135 р.");
            return sum;
        }
        public double BlackBurger()
        {
            sum += 150;
            tbfin.AppendText(Environment.NewLine + "Чёрный бургер\t\t\t\t150 р.");
            return sum;
        }
        public double ChiefBurger()
        {
            sum += 170;
            tbfin.AppendText(Environment.NewLine + "Шефбургер\t\t\t\t170 р.");
            return sum;
        }
    }
}
