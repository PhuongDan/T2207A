using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2207A
{
    public class PhoneBook : Phone
    {

        public List<string> PhoneList;

        public override void InsertPhone(string name, string phone)
        {
            if (!PhoneList)
            {
                // Nếu tên người dùng chưa có sẵn trong PhoneList thì thêm mới
                PhoneList.Add(name, phone);
            }
            else
            {
                // Nếu tên người dùng đã có sẵn thì kiểm tra số điện thoại có khác không
                if (PhoneList[name] != phone)
                {
                    // Nếu khác thì cập nhật số điện thoại mới
                    PhoneList[name] = phone;
                }
                // Nếu số điện thoại đã có rồi thì không cần làm gì thêm
            }
        }

    }
}

  