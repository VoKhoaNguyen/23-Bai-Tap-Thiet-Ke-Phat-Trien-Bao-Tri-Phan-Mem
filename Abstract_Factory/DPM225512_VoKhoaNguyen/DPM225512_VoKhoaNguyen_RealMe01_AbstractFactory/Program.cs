
        using System;

namespace MauThietKe.AbstractFactory.VietHoa
    {
        class ChuongTrinhChinh
        {
            static void Main()
            {
                // Tạo và chạy thế giới động vật Châu Phi
                LucDiaFactory chauPhi = new ChauPhiFactory();
                TheGioiDongVat tg1 = new TheGioiDongVat(chauPhi);
                tg1.ChayChuoiThucAn();

                // Tạo và chạy thế giới động vật Châu Mỹ
                LucDiaFactory chauMy = new ChauMyFactory();
                TheGioiDongVat tg2 = new TheGioiDongVat(chauMy);
                tg2.ChayChuoiThucAn();

                Console.ReadKey();
            }
        }


        abstract class LucDiaFactory
        {
            public abstract DongVatAnCo TaoDongVatAnCo();
            public abstract DongVatAnThit TaoDongVatAnThit();
        }

        /// <summary>
        /// ConcreteFactory1 - Châu Phi
        /// </summary>
        class ChauPhiFactory : LucDiaFactory
        {
            public override DongVatAnCo TaoDongVatAnCo()
            {
                return new LinhDuong();
            }

            public override DongVatAnThit TaoDongVatAnThit()
            {
                return new SuTu();
            }
        }

        /// <summary>
        /// ConcreteFactory2 - Châu Mỹ
        /// </summary>
        class ChauMyFactory : LucDiaFactory
        {
            public override DongVatAnCo TaoDongVatAnCo()
            {
                return new BoBison();
            }

            public override DongVatAnThit TaoDongVatAnThit()
            {
                return new ChoSoi();
            }
        }

        /// <summary>
        /// AbstractProductA - Động vật ăn cỏ
        /// </summary>
        abstract class DongVatAnCo
        {
        }

        /// <summary>
        /// AbstractProductB - Động vật ăn thịt
        /// </summary>
        abstract class DongVatAnThit
        {
            public abstract void An(DongVatAnCo dv);
        }

        /// <summary>
        /// ProductA1 - Linh Dương
        /// </summary>
        class LinhDuong : DongVatAnCo
        {
        }

        /// <summary>
        /// ProductB1 - Sư Tử
        /// </summary>
        class SuTu : DongVatAnThit
        {
            public override void An(DongVatAnCo dv)
            {
                Console.WriteLine(this.GetType().Name +
                    " ăn " + dv.GetType().Name);
            }
        }

        /// <summary>
        /// ProductA2 - Bò Bison
        /// </summary>
        class BoBison : DongVatAnCo
        {
        }

        /// <summary>
        /// ProductB2 - Chó Sói
        /// </summary>
        class ChoSoi : DongVatAnThit
        {
            public override void An(DongVatAnCo dv)
            {
                Console.WriteLine(this.GetType().Name +
                    " ăn " + dv.GetType().Name);
            }
        }

        /// <summary>
        /// Client - Thế giới động vật
        /// </summary>
        class TheGioiDongVat
        {
            private DongVatAnCo _anCo;
            private DongVatAnThit _anThit;

            public TheGioiDongVat(LucDiaFactory factory)
            {
                _anThit = factory.TaoDongVatAnThit();
                _anCo = factory.TaoDongVatAnCo();
            }

            public void ChayChuoiThucAn()
            {
                _anThit.An(_anCo);
            }
        }
    }



