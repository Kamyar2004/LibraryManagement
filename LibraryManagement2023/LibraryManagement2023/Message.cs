using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement2023
{
    static class Message
    {
        public static DialogResult delQuestion()
        {
            DialogResult result = MessageBox.Show("آیا میخواهید این مورد را حذف کنید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            return result;
        }

        public static void usedMessage()
        {
            MessageBox.Show("از این مورد در جدول دیگری استفاده شده است!", "گزارش", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        public static void addMessage()
        {
            MessageBox.Show("با موفقیت افزوده شد!", "گزارش", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void editMessage()
        {
            MessageBox.Show("با موفقیت ویرایش شد!", "گزارش", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void delMessage()
        {
            MessageBox.Show("با موفقیت حذف شد!", "گزارش", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void errorMessage(string text)
        {
            MessageBox.Show(text, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
