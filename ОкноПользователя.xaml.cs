using System;
using System.Collections;
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
using System.Management;
using System.Management.Instrumentation;
using System.Collections.ObjectModel;

namespace Проект_Форма_Статистики_персон
{
    /// <summary>
    /// Логика взаимодействия для ОкноПользователя.xaml
    /// </summary>
    public partial class ОкноПользователя : Window
    {
        
        public ОкноПользователя()
        {
            InitializeComponent();
            WebsiteLes();
            Person();
            Result();
        }

        public class WebsiteClass
        {
            public string Name { get; set; }
        }

        public class Company
        {
            public string Name { get; set; }
            public ObservableCollection<InformIst> InformBlok { get; set; }
            public Company()
            {
                InformBlok = new ObservableCollection<InformIst>();
            }
        }
        public class InformIst
        {
            public string Title { get; set; }
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

        public void Result()
        {
            ObservableCollection<Company> companies = new ObservableCollection<Company>()
            {
                new Company
                {
                    Name = "Путин В.В.",
                    InformBlok = new ObservableCollection<InformIst>
                    {
                    new InformIst {Title = "РИА Новости 500" },
                    new InformIst {Title = "Комсомольская правда-Digital 600" },
                    new InformIst {Title = "Вести" },
                    }
                },
                    new Company
                    {
                    Name = "Медведев Д.А.",
                    InformBlok = new ObservableCollection<InformIst>
                    {
                    new InformIst { Title="РИА Новости 450" },
                    new InformIst { Title="RT 700"}
                    }
                },
                new Company
                {
                    Name="Навальный А.А.",
                    InformBlok = new ObservableCollection<InformIst>
                    {
                    new InformIst {Title="Lenta.Ru 700" },
                    new InformIst {Title="Известия 950" }
                    }
                }
            };
        View.ItemsSource = companies;

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
    }
}
