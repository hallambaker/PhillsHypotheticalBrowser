// See https://aka.ms/new-console-template for more information
using System.Threading;

//Console.WriteLine("Hello, World!");

//var uiThread = new UiThread();


//Thread t = new Thread(uiThread.MainThread);
//t.SetApartmentState(ApartmentState.STA);
//t.Start();


class Program {
    [STAThread]
    static void Main(string[] args) {
        Console.WriteLine("Hello, World!");

        var uiThread = new UiThread();
        uiThread.MainThread();

        // My code here
        }
    }





public class UiThread {

    public void MainThread() {

        //var window = new Window();


        //window.Show();

        Console.WriteLine("finished");
        }

    }



//public class WindowBrowser : Window {


//    }