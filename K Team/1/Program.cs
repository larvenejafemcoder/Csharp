using System;

namespace Class
{
    class Animal
    {
        public double Height;
        public double Weight;

        public void Info()
        {
            /*
             Các phương thức bên trong lớp có thể gọi đến các thành phần khác (bao gồm thuộc tính và phương thức) trong
                lớp đó
            */
            Console.WriteLine($"Height: {Height} Weight: {Weight}");
        }
    }
    class Cat
    {
        public double Weight;
        public double Height;

        /*
         Constructor không có tham số
        */

        public Cat()
        {
            Weight = 800;
            Height = 10;
        }

        /*
        Constructor có tham số
        */
        public Cat(int w, int h)
        {
            Weight = w;
            Height = h;
        }

        public void Info()
        {
            Console.WriteLine($"Height: {Height} Weight: {Weight}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region Ví dụ về class

            Animal Dog = new Animal();
            Dog.Weight = 2; // gán trị cho các thuộc tính của đối tượng
            Dog.Height = 50;

            Animal Cat = new Animal();
            Cat.Weight = 1; 
            Cat.Height = 30;

            Dog.Info(); // gọi phương thức của đối tượng
            Cat.Info();

            #endregion

            #region Ví dụ về Constructor

            /*
                  Để ý khi bạn new Cat bạn không truyền tham số vào thì constructor mặc định (constructor không tham số)
             sẽ tự động được gọi để khởi tạo các giá trị mặc định cho các thuộc tính của đối tượng BlackCat.
             */
            Cat BlackCat = new Cat();

            BlackCat.Info(); // In ra thông tin Weight, Height có thực sự được khởi tạo giá trị chưa.

            /*
                  Lần này ta khởi tạo đối tượng và có truyền 2 tham số như vậy constructor có tham số sẽ được gọi.
                  Như vậy các thuộc tính Weight, Height sẽ không mang giá trị mặc định nữa mà sẽ được gán theo giá trị mà người dùng truyền vào
             */
            Cat WhiteCat = new Cat(1200, 30);

            WhiteCat.Info(); // In ra thông tin Weight, Height để xem có theo mong muốn chưa.

            #endregion

            Console.ReadKey();
        }
    }
}