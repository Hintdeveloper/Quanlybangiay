using _2_BUS.IServices;
using _3_GUI.View;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TestProject1
{
    public class Test_FrmThongke
    {
        private FrmThongKe _frmThongKe;

        [SetUp]
        public void Init()
        {
            _frmThongKe = new FrmThongKe();
        }
        [TearDown]
        public void Cleanup()
        {
            _frmThongKe.Dispose();
        }
        [Test]
        public void ShowProductonMatchDate()
        {
            var date_Ngay = new DateTime(2023, 11, 23);
        }
    }
}
