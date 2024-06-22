using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {

        //Match match = Regex.Match(phoneNumber, @"(\d{3})-(\d{3})-(\d{4})");
       // (match.Groups[1].Value == "212", match.Groups[2].Value == "555", match.Groups[3].Value);

        string[] phone = phoneNumber.Split("-");
        bool areaCode = phone[0] == "212" ? true : false;
        bool switchCode = phone[1] == "555" ? true : false;
        
        return (areaCode, switchCode, phone[2]);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }


}
