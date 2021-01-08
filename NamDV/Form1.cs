using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Threading;



namespace tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dlg.SelectedPath;
                button2.Enabled = true;
                button1.Enabled = true;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process0 = new System.Diagnostics.Process();
            process0.StartInfo.FileName = "cmd.exe";

            process0.StartInfo.Arguments = "/C adb devices";
            process0.StartInfo.UseShellExecute = false;
            process0.StartInfo.CreateNoWindow = true;
            process0.StartInfo.RedirectStandardOutput = true;
            process0.Start();
            string output0 = process0.StandardOutput.ReadToEnd();
            var a = output0.Length;
            Console.WriteLine(a);
            if (a < 30)
            {
                textBox2.Clear();
                textBox2.AppendText("Hãy bật chế độ USB debugging trên điện thoại ! ");

            }
            else
            {
                

                 string name = textBox1.Text;
                 /*System.Diagnostics.Process process = new System.Diagnostics.Process();
                 process.StartInfo.FileName = "cmd.exe";

                 process.StartInfo.Arguments = "/C adb shell pm list packages -3 -f";
                 process.StartInfo.UseShellExecute = false;
                 process.StartInfo.CreateNoWindow = true;
                 process.StartInfo.RedirectStandardOutput = true;
                 process.Start();


                 string output = process.StandardOutput.ReadToEnd();

                 string path = name + @"/output.txt";
                 using (StreamWriter sw = File.CreateText(path))
                 {
                     sw.WriteLine(output);
                 }

                 string[] lines = File.ReadAllLines(path);

                 for (int i = 0; i < lines.Length -1 ; i++)
                 {                    
                     string line = lines[i];
                     int first = line.IndexOf(':');
                     int second = line.LastIndexOf('/');

                     string namelink = line.Substring(first + 1, second - first - 1);
                     string nameapk = line.Substring(second + 10);

                     textBox2.Clear();
                     textBox2.AppendText( " Backup " + nameapk);


                     System.Diagnostics.Process process1 = new System.Diagnostics.Process();
                     process1.StartInfo.FileName = "cmd.exe";
                     process1.StartInfo.Arguments = "/C adb pull  " + namelink + "  " + name;
                     process1.StartInfo.UseShellExecute = false;
                     process1.StartInfo.CreateNoWindow = true;
                     process1.Start();
                     process1.WaitForExit();


                 }
                 textBox2.Clear();
                 textBox2.AppendText("Đang tiến hành backup ảnh và video ...");

                 System.Diagnostics.Process process3 = new System.Diagnostics.Process();
                 process3.StartInfo.FileName = "cmd.exe";
                 process3.StartInfo.Arguments = "/C adb pull /sdcard/DCIM" + " " + name;
                 process3.StartInfo.UseShellExecute = false;
                 process3.StartInfo.CreateNoWindow = true;
                 process3.Start();
                 process3.WaitForExit();

                 System.Diagnostics.Process process4 = new System.Diagnostics.Process();
                 process4.StartInfo.FileName = "cmd.exe";
                 process4.StartInfo.Arguments = "/C adb pull /sdcard/Pictures" + " " + name;
                 process4.StartInfo.UseShellExecute = false;
                 process4.StartInfo.CreateNoWindow = true;
                 process4.Start();
                 process4.WaitForExit();*/



                 string path2 = name + @"/data.db";


                 textBox2.Clear();
                 textBox2.AppendText("Đang tiến hành backup data... "); 


                 System.Diagnostics.Process process2 = new System.Diagnostics.Process();
                 process2.StartInfo.FileName = "cmd.exe";
                 process2.StartInfo.Arguments = "/c adb backup -apk -shared -all -f " + " " + path2;
                 process2.StartInfo.UseShellExecute = false;
                 process2.StartInfo.CreateNoWindow = true;               
                 process2.Start();
                 process2.WaitForExit();
                

                
                
               

                
            }
            MessageBox.Show("Done!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc0 = new System.Diagnostics.Process();
            proc0.StartInfo.FileName = "cmd.exe";
            proc0.StartInfo.Arguments = "/C adb devices";
            proc0.StartInfo.UseShellExecute = false;
            proc0.StartInfo.CreateNoWindow = true;
            proc0.StartInfo.RedirectStandardOutput = true;
            proc0.Start();
            string output0 = proc0.StandardOutput.ReadToEnd();
            var b = output0.Length;
            Console.WriteLine(b);
            if (b < 30)
            {
                textBox2.Clear();
                textBox2.AppendText("Hãy bật chế độ USB debugging trên điện thoại ! ");

            }
            else
            {
                string path3 = textBox1.Text;
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = "cmd.exe";

                proc.StartInfo.Arguments = "/C adb shell settings put global verifier_verify_adb_installs 0";
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.CreateNoWindow = true;
                proc.Start();


                proc.StartInfo.Arguments = "/C adb shell settings put global package_verifier_enable 0";
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.CreateNoWindow = true;
                proc.Start();


                string path = path3 + @"/output.txt";
                string[] lines1 = File.ReadAllLines(path);
                System.Diagnostics.Process proc7 = new System.Diagnostics.Process();
                proc7.StartInfo.FileName = "cmd.exe";

                System.Diagnostics.Process proc6 = new System.Diagnostics.Process();
                proc6.StartInfo.FileName = "cmd.exe";

                for (int j = 0; j < lines1.Length - 1; j++)
                {
                    string line1 = lines1[j];
                    int first1 = line1.IndexOf(":");
                    int second1 = line1.LastIndexOf('/');

                    string namelink = line1.Substring(first1 + 11, second1 - first1 - 11);
                    string nameapk = line1.Substring(second1 + 10);
                    string path7 = path3 + @"\" + namelink;
                    Console.WriteLine(path7);
                    string[] filelist1 = Directory.GetFiles(path7, "*.apk", SearchOption.AllDirectories);
                    int sizeOfArray = filelist1.Length;
                    Console.WriteLine(sizeOfArray);
                    if (sizeOfArray == 1)
                    {
                        textBox2.Clear();
                        textBox2.AppendText(" Restore " + nameapk);

                        proc7.StartInfo.Arguments = "/c adb install " + " " + filelist1[0];
                        proc7.StartInfo.UseShellExecute = false;
                        proc7.StartInfo.CreateNoWindow = true;
                        proc7.Start();
                        proc7.WaitForExit();
                    }
                    else if (sizeOfArray > 1)
                    {
                        string arguments = "/c adb install-multiple";
                        for (int i = 0; i < sizeOfArray; i++)
                        {
                            arguments += " " + filelist1[i];
                        }
                        textBox2.Clear();
                        textBox2.AppendText("Restore " + nameapk);

                        proc6.StartInfo.Arguments = arguments;
                        proc6.StartInfo.UseShellExecute = false;
                        proc6.StartInfo.CreateNoWindow = true;
                        proc6.Start();
                        proc6.WaitForExit();

                    }


                }

                textBox2.Clear();
                textBox2.AppendText(" Đang tiến hành restore ảnh và video ...");

                System.Diagnostics.Process proc2 = new System.Diagnostics.Process();
                proc2.StartInfo.FileName = "cmd.exe";
                proc2.StartInfo.Arguments = "/c adb push " + " " + path3 + @"/DCIM" + " " + "/sdcard/";
                proc2.StartInfo.UseShellExecute = false;
                proc2.StartInfo.CreateNoWindow = true;
                proc2.Start();
                proc2.WaitForExit();


                System.Diagnostics.Process proc4 = new System.Diagnostics.Process();
                proc4.StartInfo.FileName = "cmd.exe";
                proc4.StartInfo.Arguments = "/c adb push " + " " + path3 + @"/Pictures" + " " + "/sdcard/";
                proc4.StartInfo.UseShellExecute = false;
                proc4.StartInfo.CreateNoWindow = true;
                proc4.Start();
                proc4.WaitForExit();

                textBox2.Clear();
                textBox2.AppendText(" Đang tiến hành restore data ...");

                string path5 = path3 + @"/data.db";
                System.Diagnostics.Process proc3 = new System.Diagnostics.Process();
                proc3.StartInfo.FileName = "cmd.exe";
                proc3.StartInfo.Arguments = " /c adb restore " + " " + path5;
                proc3.StartInfo.UseShellExecute = false;
                proc3.StartInfo.CreateNoWindow = true;
                proc3.Start();




            }
            MessageBox.Show("Done!");
        }





    
        
    }
}

