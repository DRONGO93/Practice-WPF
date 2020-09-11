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

namespace Проект_Форма_Статистики_персон
{
    /// <summary>
    /// Логика взаимодействия для Окно_пользователя.xaml
    /// </summary>
    public partial class Окно_пользователя : Window
    {
        public class WebsiteClass
        {
            public string Name { get; set; }
        }

        static public bool flag;

        public void WebsiteLes()
        {
            List<WebsiteClass> Website = new List<WebsiteClass>();
            WebSait.Items.Add(new WebsiteClass() { Name = "РИА Новости" });
            WebSait.Items.Add(new WebsiteClass() { Name = "Комсомольская правда-Digital" });
            WebSait.Items.Add(new WebsiteClass() { Name = "Известия" });
            WebSait.Items.Add(new WebsiteClass() { Name = "Lenta.Ru" });
            WebSait.Items.Add(new WebsiteClass() { Name = "Вести" });
            WebSait.Items.Add(new WebsiteClass() { Name = "RT" });
        }

        public void Person()
        {
            List<WebsiteClass> PersonName = new List<WebsiteClass>();
            Pers.Items.Add(new WebsiteClass() { Name = "Путин В.В." });
            Pers.Items.Add(new WebsiteClass() { Name = "Медведев Д.А." });
            Pers.Items.Add(new WebsiteClass() { Name = "Навальный А.А." });
            Pers.Items.Add(new WebsiteClass() { Name = "Грудинин П.Н." });
            Pers.Items.Add(new WebsiteClass() { Name = "Жириновский В.В." });
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Отмечен.");
            FL(UseParam);
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Не Отмечен.");
            FL(UseParam);
        }

        public void FL(CheckBox UseParam)
        {
            flag = UseParam.IsChecked.Value;
            if (flag == true)
            {
                ApplySetting.IsEnabled = true;
            }
            if (flag == false)
            {
                ApplySetting.IsEnabled = false;
            }
        }

        //private void ApplySetting_Click(object sender, RoutedEventArgs e)
        //{
        //    //MessageBox.Show("Отмечен.");
        //}
    }
}
