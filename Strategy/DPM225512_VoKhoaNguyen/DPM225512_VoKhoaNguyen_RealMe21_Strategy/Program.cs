using System;

namespace Strategy.VietNam
{
    public class Program
    {
        public static void Main(string[] args)
        {
            NgheThuat nt;

            nt = new NgheThuat(new CachA());
            nt.ThucHien();

            nt = new NgheThuat(new CachB());
            nt.ThucHien();

            nt = new NgheThuat(new CachC());
            nt.ThucHien();

            Console.ReadKey();
        }
    }

    public abstract class Cach
    {
        public abstract void Lam();
    }

    public class CachA : Cach
    {
        public override void Lam()
        {
            Console.WriteLine("Thực hiện theo cách A");
        }
    }

    public class CachB : Cach
    {
        public override void Lam()
        {
            Console.WriteLine("Thực hiện theo cách B");
        }
    }

    public class CachC : Cach
    {
        public override void Lam()
        {
            Console.WriteLine("Thực hiện theo cách C");
        }
    }

    public class NgheThuat
    {
        Cach cach;

        public NgheThuat(Cach cach)
        {
            this.cach = cach;
        }

        public void ThucHien()
        {
            cach.Lam();
        }
    }
}
