using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace data_miner
{
    public class DriverPassengerTogether
    {
        public static Color driver_head = Color.FromArgb(26, 169, 73);

        public static Color driver_chest_1 = Color.FromArgb(23, 159, 66);
        public static Color driver_chest_2 = Color.FromArgb(210, 206, 0);
        public static Color driver_chest_3 = Color.FromArgb(211, 102, 0);
        public static Color driver_chest_4 = Color.FromArgb(130, 72, 31);
        public static Color driver_chest_5 = Color.FromArgb(209, 44, 44);

        public static Color driver_leftupper_1 = Color.FromArgb(38, 195, 97);
        public static Color driver_leftupper_2 = Color.FromArgb(234, 231, 0);
        public static Color driver_leftupper_3 = Color.FromArgb(234, 140, 0);
        public static Color driver_leftupper_4 = Color.FromArgb(168, 105, 51);
        public static Color driver_leftupper_5 = Color.FromArgb(233, 68, 68);

        public static Color driver_rightupper_1 = Color.FromArgb(16, 136, 51);
        public static Color driver_rightupper_2 = Color.FromArgb(191, 186, 0);
        public static Color driver_rightupper_3 = Color.FromArgb(191, 83, 0);
        public static Color driver_rightupper_4 = Color.FromArgb(108, 57, 23);
        public static Color driver_rightupper_5 = Color.FromArgb(190, 33, 33);

        public static Color driver_rightleg_1 = Color.FromArgb(40, 198, 100);
        public static Color driver_rightleg_2 = Color.FromArgb(236, 233, 0);
        public static Color driver_rightleg_3 = Color.FromArgb(236, 143, 0);
        public static Color driver_rightleg_4 = Color.FromArgb(235, 70, 70);

        public static Color driver_leftleg_1 = Color.FromArgb(38, 195, 97);
        public static Color driver_leftleg_2 = Color.FromArgb(234, 231, 0);
        public static Color driver_leftleg_3 = Color.FromArgb(234, 140, 0);


        public int ifelseDriverHead(Color a)
        {
            if (a == DriverPassengerTogether.driver_head)
            {
                return 1;

            }
            return 1;

        }
        public int ifelseDriverChest(Color a)
        {
            if (a == DriverPassengerTogether.driver_chest_1)
            {
                return 1;
            }
            if (a == DriverPassengerTogether.driver_chest_2)
            {
                return 2;
            }
            if (a == DriverPassengerTogether.driver_chest_3)
            {
                return 3;
            }
            if (a == DriverPassengerTogether.driver_chest_4)
            {
                return 4;
            }
            if (a == DriverPassengerTogether.driver_chest_5)
            {
                return 5;
            }
            return -1;
        }
        public int ifelseDriverLeftUpper(Color a)
        {
            if (a == DriverPassengerTogether.driver_leftupper_1)
            {
                return 1;
            }
            if (a == DriverPassengerTogether.driver_leftupper_2)
            {
                return 2;
            }
            if (a == DriverPassengerTogether.driver_leftupper_3)
            {
                return 3;
            }
            if (a == DriverPassengerTogether.driver_leftupper_4)
            {
                return 4;
            }
            if (a == DriverPassengerTogether.driver_leftupper_5)
            {
                return 5;
            }
            return -1;
        }

        public  int ifelseDriverRightUpper(Color a)
        {
            if (a == DriverPassengerTogether.driver_rightupper_1)
            {
                return 1;
            }
            if (a == DriverPassengerTogether.driver_rightupper_2)
            {
                return 2;
            }
            if (a == DriverPassengerTogether.driver_rightupper_3)
            {
                return 3;
            }
            if (a == DriverPassengerTogether.driver_rightupper_4)
            {
                return 4;
            }
            if (a == DriverPassengerTogether.driver_rightupper_5)
            {
                return 5;
            }
            return - 1;
        }

        public int ifelseDriverRightLeg(Color a)
        {
            if (a == DriverPassengerTogether.driver_rightleg_1)
            {
                return 1;
            }
            if (a == DriverPassengerTogether.driver_rightleg_2)
            {
                return 2;
            }
            if (a == DriverPassengerTogether.driver_rightleg_3)
            {
                return 3;
            }
            if (a == DriverPassengerTogether.driver_rightleg_4)
            {
                return 4;
            }
            return -1;
        }

        public int ifelseDriverLeftLeg(Color a)
        {
            if (a == DriverPassengerTogether.driver_leftleg_1)
            {
                return 1;
            }
            if (a == DriverPassengerTogether.driver_leftleg_2)
            {
                return 2;
            }
            if (a == DriverPassengerTogether.driver_leftleg_3)
            {
                return 3;
            }
            return -1;
        }
    }

    public class PassengerColorTogether
    {
        public static Color passenger_head = Color.FromArgb(31,181,83);

        public static Color passenger_chest_1 = Color.FromArgb(22,158,65);
        public static Color passenger_chest_2 = Color.FromArgb(210,205,0);
        public static Color passenger_chest_3 = Color.FromArgb(210,101,0);

        public static Color passenger_leftupper_1 = Color.FromArgb(35,190,91);
        public static Color passenger_leftupper_3 = Color.FromArgb(231,134,0);
        public static Color passenger_leftupper_5 = Color.FromArgb(230,64,64);

        public static Color passenger_rightupper_1 = Color.FromArgb(30,178,81);
        public static Color passenger_rightupper_2 = Color.FromArgb(223,219,0);
        public static Color passenger_rightupper_3 = Color.FromArgb(224,121,0);

        public static Color passsenger_rightleg_1 = Color.FromArgb(37,194,95);
        public static Color passsenger_rightleg_2 = Color.FromArgb(233,230,0);
        public static Color passsenger_rightleg_3 = Color.FromArgb(234,138,0);

        public static Color passenger_leftleg_1 = Color.FromArgb(39,196,98);
        public static Color passenger_leftleg_2 = Color.FromArgb(234,231,0);
        public static Color passenger_leftleg_3 = Color.FromArgb(235,141,0);


        public int ifelsePassengerHead(Color a)
        {
            if (a == PassengerColorTogether.passenger_head)
            {
                return 1;
            }
            return 1;

        }


        public int ifelsePassengerChest(Color a)
        {
            if (a == PassengerColorTogether.passenger_chest_1)
            {
                return 1;
            }
            if (a == PassengerColorTogether.passenger_chest_2)
            {
                return 2;
            }
            if (a == PassengerColorTogether.passenger_chest_3)
            {
                return 3;
            }
            return -1;
        }

        public int ifelsePassengerLeftUpper(Color a)
        {
            if (a == PassengerColorTogether.passenger_leftupper_1)
            {
                return 1;
            }
            if (a == PassengerColorTogether.passenger_leftupper_3)
            {
                return 3;
            }
            if (a == PassengerColorTogether.passenger_leftupper_5)
            {
                return 5;
            }
            return -1;
        }

        public int ifelsePassengerRightUpper(Color a)
        {
            if (a == PassengerColorTogether.passenger_rightupper_1)
            {
                return 1;
            }
            if (a == PassengerColorTogether.passenger_rightupper_2)
            {
                return 2;
            }
            if (a == PassengerColorTogether.passenger_rightupper_3)
            {
                return 3;
            }
            return -1;
        }

        public int ifelsePassengerLeftLeg(Color a)
        {
            if (a == PassengerColorTogether.passenger_leftleg_1)
            {
                return 1;
            }
            if (a == PassengerColorTogether.passenger_leftleg_2)
            {
                return 2;
            }
            if (a == PassengerColorTogether.passenger_leftleg_3)
            {
                return 3;
            }
            return -1;
        }

        public int ifelsePassengerRightLeg(Color a)
        {
            if (a == PassengerColorTogether.passsenger_rightleg_1)
            {
                return 1;
            }
            if (a == PassengerColorTogether.passsenger_rightleg_2)
            {
                return 2;
            }
            if (a == PassengerColorTogether.passsenger_rightleg_3)
            {
                return 3;
            }
            return -1;
        }

    }
}
