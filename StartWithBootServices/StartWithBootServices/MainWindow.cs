using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartWithBootServices
{
    public partial class MainWindow : Form
    {
        //服务名称
        String serviceName = "BootAutoStart";

        public MainWindow()
        {
            InitializeComponent();
        }


        #region 检查服务存在的存在性

        /// <summary>  
        /// 检查服务存在的存在性  
        /// </summary>  
        /// <param name=" NameService ">服务名</param>  
        /// <returns>存在返回 true,否则返回 false;</returns>  
        public static bool IsServiceIsExisted(string NameService)
        {
            ServiceController[] services = ServiceController.GetServices();
            foreach (ServiceController s in services)
            {
                Console.WriteLine(s.ServiceName);
                if (s.ServiceName.ToLower() == NameService.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region 判断window服务是否启动
        /// <summary>  
        /// 判断某个Windows服务是否启动  
        /// </summary>  
        /// <returns></returns>  
        public static bool IsServiceStart(string serviceName)
        {
            ServiceController psc = new ServiceController(serviceName);
            bool bStartStatus = false;
            try
            {
                if (!psc.Status.Equals(ServiceControllerStatus.Stopped))
                {
                    bStartStatus = true;
                }

                return bStartStatus;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        //根据服务状态显示面板上的按钮
        public void SetControlStatus()
        {
            if (IsServiceIsExisted(serviceName))//如果服务存在 
            {
                RegisterServiceBtn.Enabled = false; //注册服务按钮变灰
                if (IsServiceStart(serviceName))//服务已启动
                {
                    StartServiceBtn.Enabled = false;
                    StopServiceBtn.Enabled = true;
                    UninstallServiceBtn.Enabled = false;
                }
                else //服务未启动
                {
                    StartServiceBtn.Enabled = true;
                    StopServiceBtn.Enabled = false;
                    UninstallServiceBtn.Enabled = true;
                }
            }
            else //其它按钮变灰
            {
                RegisterServiceBtn.Enabled = true;
                UninstallServiceBtn.Enabled = false;
                StartServiceBtn.Enabled = false;
                StopServiceBtn.Enabled = false;
            }
        }


        //注册
        private void RegisterServiceBtn_Click(object sender, EventArgs e)
        {

            //检查服务是否存在
            if (!IsServiceIsExisted(serviceName))
            {
                try
                {
                    //取得需要注册的EXE文件路径  并赋参数S
                    string location = System.Reflection.Assembly.GetExecutingAssembly().Location + " s";
                    //注册服务，并设置启动模式为：自动
                    Process.Start("sc", "create " + serviceName + " binpath= \"" + location + "\" displayName= " + serviceName + " start= auto");
                    //设置服务描述
                    Process.Start("sc", "description " + serviceName + " \"视频服务\"");
                    MessageBox.Show("服务注册成功!  服务名称为：" + serviceName);
                    //刷新窗体
                    SetControlStatus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("注册服务时出现异常，请以管理员身份运行后注册！ 异常信息为：" + ex.ToString());
                }

            }
            else
            {
                MessageBox.Show("服务已经注册，不需再重复注册！");
            }
        }
        //启动
        private void StartServiceBtn_Click(object sender, EventArgs e)
        {

            //检查服务是否存在
            if (!IsServiceIsExisted(serviceName))
            {
                MessageBox.Show("服务还未注册，无法启动！");
            }
            else
            {
                try
                {
                    Process.Start("sc", "start " + serviceName);
                    MessageBox.Show("服务已启动!");
                    //刷新窗体
                    SetControlStatus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("启动服务时出现异常， 异常信息为：" + ex.ToString());
                }
            }

        }
        //停止
        private void StopServiceBtn_Click(object sender, EventArgs e)
        {
            //检查服务是否存在
            if (!IsServiceIsExisted(serviceName))
            {
                MessageBox.Show("服务还未注册，无法停止！");
            }
            else
            {
                try
                {
                    Process.Start("sc", "stop " + serviceName);
                    MessageBox.Show("服务已停止!");
                    //刷新窗体
                    SetControlStatus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("停止服务时出现异常， 异常信息为：" + ex.ToString());
                }
            }
        }
        //卸载
        private void UninstallServiceBtn_Click(object sender, EventArgs e)
        {
            if (!IsServiceIsExisted(serviceName))
            {
                MessageBox.Show("服务还未注册，无法卸载！");
            }
            else
            {
                try
                {
                    //如果服务已启动，需要先停止
                    if (IsServiceStart(serviceName))
                    {
                        Process.Start("sc", "stop " + serviceName);//停止服务
                    }
                    //卸载服务
                    Process.Start("sc", "delete " + serviceName);
                    MessageBox.Show("服务卸载成功!");
                    //刷新窗体
                    SetControlStatus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("卸载服务时出现异常， 异常信息为：" + ex.ToString());
                }
            }
        }
    }
}
