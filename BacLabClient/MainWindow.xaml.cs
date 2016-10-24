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
   
    [CallbackBehavior(UseSynchronizationContext = false)]
    public partial class MainWindow : Window, IMessageServiceCallback
    {
        MessageServiceClient proxy;
        
        public MainWindow()
        {
            InitializeComponent();

            // Получение имени компьютера.
            String host = System.Net.Dns.GetHostName();
            // Получение ip-адреса.
            System.Net.IPAddress ip = System.Net.Dns.GetHostByName(host).AddressList[0];
            // Показ адреса в label'е.
            adressTextBox.Text = ip.ToString();

            InstanceContext instanceContext = new InstanceContext(this);
            proxy = new MessageServiceClient(instanceContext);

            //ассинхроный вызов службы
            //Подписываемся на общие сообщения
            IAsyncResult res = proxy.BeginSubscribe(ip.ToString()+" "+ host, MyCallBack, proxy);
            
        }


        //ассинхроный вызов службы
        static void MyCallBack(IAsyncResult ar)
        {
            //если есть возвращаемое значение, его присвоить
            bool res =((MessageServiceClient)ar.AsyncState).EndSubscribe(ar);
            MessageBox.Show(res.ToString());
        }

        




        //*******************************************************************************
        //реализация рассылки общих сообщений

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            proxy.AddMessage(1, adressTextBox.Text);
        }
        public IAsyncResult BeginOnMessageAdded(string message, DateTime timestamp, AsyncCallback callback, object asyncState)
        {
            throw new NotImplementedException();
        }

        public void EndOnMessageAdded(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        public void OnMessageAdded(string message, DateTime timestamp)
        {
            MessageBox.Show(message);

            //доступ к контролу из другого потока 
            /*myTextBox.Dispatcher.Invoke(new Action(delegate ()
            {
                myTextBox.Text = message + timestamp.ToString();
            }));*/
            
        }
        
       
    }
}
