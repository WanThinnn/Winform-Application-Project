//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using FireSharp.Config;
//using FireSharp.Interfaces;
//using FireSharp.Response;
//using Newtonsoft.Json;

//public partial class AdminShift : Form
//{
//    private IFirebaseClient firebaseClient;

//    public AdminShift()
//    {
//        InitializeComponent();
//        this.Load += AdminShift_Load;
//    }

    
//        IFirebaseConfig ifc = new FirebaseConfig()
//        {
//            AuthSecret = "f5A5LselW6L4lKJHpNGVH6NZHGKIZilErMoUOoLC",
//            BasePath = "https://neko-coffe-database-default-rtdb.firebaseio.com/"
//        };

//        firebaseClient = new FireSharp.FirebaseClient(ifc);
    

//    private async Task<List<NekoShift>> GetEmployeeShiftsAsync()
//    {
//        FirebaseResponse response = await firebaseClient.GetAsync("EmployeeShifts");
//        var shifts = JsonConvert.DeserializeObject<Dictionary<string, NekoShift>>(response.Body);
//        return shifts.Values.ToList();
//    }

//    private async void LoadCurrentShiftEmployees()
//    {
//        var shifts = await GetEmployeeShiftsAsync();
//        string currentShift = GetCurrentShift();

//        if (currentShift == "Ngoài giờ làm việc")
//        {
//            MessageBox.Show("Hiện tại không có nhân viên nào làm việc", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
//            return;
//        }

//        List<NekoShift> currentShiftEmployees = shifts
//            .Where(s => s.Shift == currentShift && s.Date.Date == DateTime.Now.Date)
//            .ToList();

//        lstCurrentShiftEmployees.Items.Clear();
//        foreach (var shift in currentShiftEmployees)
//        {
//            lstCurrentShiftEmployees.Items.Add($"{shift.ID} - {shift.PhoneNumber}");
//        }
//    }

//    private string GetCurrentShift()
//    {
//        DateTime now = DateTime.Now;
//        TimeSpan time = now.TimeOfDay;

//        if (time >= new TimeSpan(9, 0, 0) && time < new TimeSpan(14, 0, 0))
//        {
//            return "Ca 1 (9h-14h)";
//        }
//        else if (time >= new TimeSpan(14, 0, 0) && time < new TimeSpan(19, 0, 0))
//        {
//            return "Ca 2 (14h-19h)";
//        }
//        else if (time >= new TimeSpan(19, 0, 0) && time < new TimeSpan(24, 0, 0))
//        {
//            return "Ca 3 (19h-24h)";
//        }
//        else
//        {
//            return "Ngoài giờ làm việc";
//        }
//    }

//    private void AdminShift_Load(object sender, EventArgs e)
//    {
//        LoadCurrentShiftEmployees();
//    }
//}
