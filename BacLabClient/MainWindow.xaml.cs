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
using System.Windows.Navigation;
using System.Windows.Shapes;
using BacLabClient.ServiceReference1;
using System.ServiceModel;

namespace BacLabClient
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, ITestCallback
    {
        TestClient proxy;

        public MainWindow()
        {
            InitializeComponent();

            InstanceContext instanceContext = new InstanceContext(new CallbackHandler());
            proxy = new TestClient(instanceContext);

            //ассинхроный вызов службы
            //IAsyncResult res = proxy.BegintestMetod("HelloAsy", MyCallBack, proxy);


        }


        //ассинхроный вызов службы
        static void MyCallBack(IAsyncResult ar)
        {
            //если есть возвращаемое значение, его присвоить
            ((TestClient)ar.AsyncState).EndtestMetod(ar);
        }

        public IAsyncResult BeginShowMessage(string message, AsyncCallback callback, object asyncState)
        {
            throw new NotImplementedException();
        }

        public void EndShowMessage(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        public void ShowMessage(string message)
        {
            throw new NotImplementedException();
        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            proxy.testMetod("Hello");
        }
    }
}
