using System;
using System.Collections.Generic;

public class sinhvien
{
    public int id { get; set; }
    public string name { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public float mathScore { get; set; }
    public float physicsScore { get; set; }
    public float chemistryScore { get; set; }
    public float averageScore
    {
        get { return (mathScore + physicsScore + chemistryScore) / 3; }
    }
    public string grade
    {
        get
        {
            if (averageScore >= 8)
            {
                return "Giỏi";
            }
            else if (averageScore >= 6.5)
            {
                return "Khá";
            }
            else if (averageScore >= 5)
            {
                return "Trung bình";
            }
            else
            {
                return "Yếu";
            }
        }
    }
}

