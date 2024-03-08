using System;

namespace Access_Modifiers
{
    /*
        Since no specific keyword is specified, the SinhVien class will have internal scope
    */
    class SinhVien
    {
        /*
            All properties have private scope. Therefore, they are only used internally within the class
            They cannot be accessed from outside
        */
        private double DiemToan;
        private double diemVan;
        private double diemLy;

        public double DiemVan
        {
            get { return diemVan; }
            set { diemVan = value; }
        }
        public double DiemLy
        {
            get { return diemLy; }
            set
            {
                /*
                    Check if the physics score meets the conditions
                    If so, assign it to the private property
                    Otherwise, do nothing.
                    This ensures the correctness of the data
                 */
                if (value <= 10 || value >= 0)
                {
                    diemLy = value;
                }
            }
        }

        /*
            This is a method to query the value of the DiemToan property
            So the method has 1 parameter passed in, of type double, matching the type of the DiemToan property
        */
        public void setDiemToan(double diemtoan)
        {
            DiemToan = diemtoan;
        }
        /*
            This method has a public scope so it can be used from the outside
            And because this method is inside the class, it can use the private properties above
        */
        public void InThongTinDiemTb()
        {
            double DTB = (DiemToan + DiemVan) / 2;

            Console.WriteLine($"Student has an average score of: {DTB}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SinhVien SV1 = new SinhVien();

            SV1.DiemLy = 8;

            Console.WriteLine($"Physics score: {SV1.DiemLy}");
        }
    }
}
