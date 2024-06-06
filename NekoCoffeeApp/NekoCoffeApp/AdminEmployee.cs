using FireSharp.Config;
using FireSharp.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UI
{
    public partial class AdminEmployee : UserControl
    {
        private string _masterUserName;
        public AdminEmployee(string masterUserName)
        {
            InitializeComponent();
            _masterUserName = masterUserName;
        }

        private static AdminEmployee _instance;
        public static AdminEmployee Instance(string masterUserName)
        {
            if (_instance == null || _instance._masterUserName != masterUserName)
            {
                _instance = new AdminEmployee(masterUserName);
            }
            return _instance;

        }

        private void AdminAdjustEmployee_Click(object sender, EventArgs e)
        {

            edit_Employee_2 employee_Edit = new edit_Employee_2(_masterUserName);
            employee_Edit.Show();
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "f5A5LselW6L4lKJHpNGVH6NZHGKIZilErMoUOoLC",
            BasePath = "https://neko-coffe-database-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient empp;

        //private async void EmployeeLoadBtn_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (empp == null)
        //        {
        //            empp = new FireSharp.FirebaseClient(ifc);
        //        }

        //        //var response = await empp.GetAsync(@"Employees/");
        //        //var employees = JsonConvert.DeserializeObject<Dictionary<string, NekoEmployee>>(response.Body);

        //        // Xóa các controls cũ trên Employee_FlowLayoutPanel nếu có

        //        var response = await empp.GetAsync(@"Employees/");
        //        var json = response.Body;

        //        List<NekoEmployee> employees = null;

        //        // Kiểm tra xem JSON có phải là mảng không
        //        if (json.StartsWith("["))
        //        {
        //            employees = JsonConvert.DeserializeObject<List<NekoEmployee>>(json);
        //        }
        //        else
        //        {
        //            var dictEmployees = JsonConvert.DeserializeObject<Dictionary<string, NekoEmployee>>(json);
        //            employees = dictEmployees.Values.ToList();
        //        }

        //        Employee_FlowLayoutPanel.Controls.Clear();


        //        foreach (var employee in employees)
        //        {
        //            DateTime now = DateTime.Now;
        //            int currentHour = now.Hour;
        //            string currentShift = GetCurrentShift(currentHour);
        //            if (employee.Shift == currentShift)
        //            {
        //                Button btn = new Button();
        //                btn.Size = new Size(109, 109);
        //                btn.BackColor = Color.LightBlue;
        //                btn.Text = $"ID: {employee.ID}\nName: {employee.Name}\nShift: {employee.Shift}";
        //                btn.Click += (s, args) => OpenEmployeeDetail(employee);
        //                Employee_FlowLayoutPanel.Controls.Add(btn);
        //            }
        //        }
        //    }

        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error loading employees: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}


        private async void EmployeeLoadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (empp == null)
                {
                    empp = new FireSharp.FirebaseClient(ifc);
                }

                if (empp == null)
                {
                    throw new Exception("Failed to connect to Firebase.");
                }
                var data = await empp.GetAsync($"/Employees_{_masterUserName}/");

                // Check if data or data.Body is null
                if (data == null || data.Body == null)
                {

                    return;
                }

                string jsonData = data.Body;


                if (jsonData.TrimStart().StartsWith("["))
                {
                    // Nếu là mảng JSON, xử lý nó như một danh sách
                    var mListArray = JsonConvert.DeserializeObject<List<NekoEmployee>>(jsonData);

                    // Check if mListArray is null or empty
                    if (mListArray == null || !mListArray.Any())
                    {

                        return;
                    }


                    // Lọc các phần tử null khỏi danh sách nhân viên
                    mListArray = mListArray.Where(employee => employee != null).ToList();

                    // Xóa các controls cũ trên Employee_FlowLayoutPanel nếu có
                    Employee_FlowLayoutPanel.Controls.Clear();

                    DateTime now = DateTime.Now;
                    int currentHour = now.Hour;
                    string currentShift = GetCurrentShift(currentHour);
                    //MessageBox.Show($"Current Hour: {currentHour}, Current Shift: {currentShift}"); // Kiểm tra giá trị của currentShift

                    foreach (var employee in mListArray)
                    {
                        if (employee.Shift == currentShift)
                        {
                            Button btn = new Button();
                            btn.Size = new Size(109, 109);
                            btn.BackColor = Color.LightBlue;
                            btn.Text = $"ID: {employee.ID}\nName: {employee.Name}\nShift: {employee.Shift}";
                            btn.Click += (s, args) => OpenEmployeeDetail(employee);
                            Employee_FlowLayoutPanel.Controls.Add(btn);
                            //MessageBox.Show($"Added button for employee: {employee.Name}"); // Kiểm tra nút được thêm
                        }
                    }

                }
                else
                {
                    // Nếu không phải mảng JSON, xử lý nó như một đối tượng JSON
                    var mList = JsonConvert.DeserializeObject<IDictionary<string, NekoEmployee>>(jsonData);

                    // Check if mList is null or empty
                    if (mList == null || !mList.Any())
                    {

                        return;
                    }

                    var listNumber = mList.Values.ToList();
                    // Lọc các phần tử null khỏi danh sách nhân viên
                    listNumber = listNumber.Where(employee => employee != null).ToList();

                    // Xóa các controls cũ trên Employee_FlowLayoutPanel nếu có
                    Employee_FlowLayoutPanel.Controls.Clear();

                    DateTime now = DateTime.Now;
                    int currentHour = now.Hour;
                    string currentShift = GetCurrentShift(currentHour);
                    //MessageBox.Show($"Current Hour: {currentHour}, Current Shift: {currentShift}"); // Kiểm tra giá trị của currentShift

                    foreach (var employee in listNumber)
                    {
                        if (employee.Shift == currentShift)
                        {
                            Button btn = new Button();
                            btn.Size = new Size(109, 109);
                            btn.BackColor = Color.LightBlue;
                            btn.Text = $"ID: {employee.ID}\nName: {employee.Name}\nShift: {employee.Shift}";
                            btn.Click += (s, args) => OpenEmployeeDetail(employee);
                            Employee_FlowLayoutPanel.Controls.Add(btn);
                            //MessageBox.Show($"Added button for employee: {employee.Name}"); // Kiểm tra nút được thêm
                        }
                    }
                }
                
                
                

               

                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading employees: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }








        private void AdminEmployee_Load(object sender, EventArgs e)
        {
            try
            {
                empp = new FireSharp.FirebaseClient(ifc);
                if (empp == null)
                {
                    throw new Exception("Cannot connect to the Firebase server.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kiểm tra lại mạng: {ex.Message}", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            EmployeeLoadBtn_Click(sender, e);
        }

        private string GetCurrentShift(int currentHour)
        {
            if (currentHour >= 8 && currentHour < 13)
            {
                return "1";
            }
            else if (currentHour >= 13 && currentHour < 18)
            {
                return "2";
            }
            else if (currentHour >= 18 && currentHour < 23)
            {
                return "3";
            }
            else if (currentHour >= 1 && currentHour < 7)
            {
                return "4";
            }
            else
            {
                return "0";
            }
        }

        private void OpenEmployeeDetail(NekoEmployee employee)
        {
            // Khởi tạo form chi tiết nhân viên với thông tin nhân viên được truyền vào
            EmployeeDetail employeeDetail = new EmployeeDetail(employee);
            employeeDetail.Show();
        }
    }



}

