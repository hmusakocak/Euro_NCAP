using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_miner
{
    public class DriverPassengerSingle
    {
        public static Color driver_head_1 = Color.FromArgb(15, 172, 51);
        public static Color driver_head_2 = Color.FromArgb(246, 229, 0);
        public static Color driver_head_3 = Color.FromArgb(238, 146, 0);

        public static Color driver_chest_1 = Color.FromArgb(0, 130, 36);
        public static Color driver_chest_2 = Color.FromArgb(230, 204, 0);
        public static Color driver_chest_3 = Color.FromArgb(215, 110, 0);
        public static Color driver_chest_4 = Color.FromArgb(91, 50, 27);

        public static Color driver_leftupper_1 = Color.FromArgb(24, 94, 44);
        public static Color driver_leftupper_1_1 = Color.FromArgb(210, 213, 218);
        public static Color driver_leftupper_2 = Color.FromArgb(192, 153, 0);
        public static Color driver_leftupper_3 = Color.FromArgb(172, 73, 14);
        public static Color driver_leftupper_4 = Color.FromArgb(64, 44, 34);

        public static Color driver_rightupper_1 = Color.FromArgb(13, 163, 50);
        public static Color driver_rightupper_2 = Color.FromArgb(244, 225, 0);
        public static Color driver_rightupper_3 = Color.FromArgb(234, 139, 0);
        public static Color driver_rightupper_4 = Color.FromArgb(124, 67, 35);


        public static Color driver_rightleg_1 = Color.FromArgb(19, 166, 53);
        public static Color driver_rightleg_2 = Color.FromArgb(246, 230, 0);
        public static Color driver_rightleg_3 = Color.FromArgb(238, 149, 0);
        public static Color driver_rightleg_4 = Color.FromArgb(129, 69, 38);

        public static Color driver_leftleg_1 = Color.FromArgb(16, 177, 55);
        public static Color driver_leftleg_2 = Color.FromArgb(249, 235, 0);
        public static Color driver_leftleg_3 = Color.FromArgb(243, 159, 0);
        public static Color driver_leftleg_4 = Color.FromArgb(139, 75, 39);

        public int ifelseDriverHead(Color a)
        {
            if (a == DriverPassengerSingle.driver_head_1)
            {
                return 1;

            }
            if (a == DriverPassengerSingle.driver_head_2)
            {
                return 2;

            }
            if (a == DriverPassengerSingle.driver_head_3)
            {
                return 3;

            }
            return -1;

        }
        public int ifelseDriverChest(Color a)
        {
            if (a == DriverPassengerSingle.driver_chest_1)
            {
                return 1;
            }
            if (a == DriverPassengerSingle.driver_chest_2)
            {
                return 2;
            }
            if (a == DriverPassengerSingle.driver_chest_3)
            {
                return 3;
            }
            if (a == DriverPassengerSingle.driver_chest_4)
            {
                return 4;
            }

            return -1;
        }
        public int ifelseDriverLeftUpper(Color a)
        {
            if (a == DriverPassengerSingle.driver_leftupper_1)
            {
                return 1;
            }
            if (a == DriverPassengerSingle.driver_leftupper_1_1)
            {
                return 1;
            }
            if (a == DriverPassengerSingle.driver_leftupper_2)
            {
                return 2;
            }
            if (a == DriverPassengerSingle.driver_leftupper_3)
            {
                return 3;
            }
            if (a == DriverPassengerSingle.driver_leftupper_4)
            {
                return 4;
            }

            return -1;
        }

        public int ifelseDriverRightUpper(Color a)
        {
            if (a == DriverPassengerSingle.driver_rightupper_1)
            {
                return 1;
            }
            if (a == DriverPassengerSingle.driver_rightupper_2)
            {
                return 2;
            }
            if (a == DriverPassengerSingle.driver_rightupper_3)
            {
                return 3;
            }
            if (a == DriverPassengerSingle.driver_rightupper_4)
            {
                return 4;
            }
            return -1;
        }

        public int ifelseDriverRightLeg(Color a)
        {
            if (a == DriverPassengerSingle.driver_rightleg_1)
            {
                return 1;
            }
            if (a == DriverPassengerSingle.driver_rightleg_2)
            {
                return 2;
            }
            if (a == DriverPassengerSingle.driver_rightleg_3)
            {
                return 3;
            }
            if (a == DriverPassengerSingle.driver_rightleg_4)
            {
                return 4;
            }
            return -1;
        }

        public int ifelseDriverLeftLeg(Color a)
        {
            if (a == DriverPassengerSingle.driver_leftleg_1)
            {
                return 1;
            }
            if (a == DriverPassengerSingle.driver_leftleg_2)
            {
                return 2;
            }
            if (a == DriverPassengerSingle.driver_leftleg_3)
            {
                return 3;
            }
            if (a == DriverPassengerSingle.driver_leftleg_4)
            {
                return 4;
            }
            return -1;
        }
    }

    public class PassengerColorSingle
    {
        public static Color passenger_head_1 = Color.FromArgb(15, 170, 50);
        public static Color passenger_head_2 = Color.FromArgb(245, 228, 0);

        public static Color passenger_chest_1 = Color.FromArgb(0, 155, 41);
        public static Color passenger_chest_2 = Color.FromArgb(242, 222, 0);
        public static Color passenger_chest_3 = Color.FromArgb(232, 134, 0);

        public static Color passenger_leftupper_1 = Color.FromArgb(19, 89, 39);       
        public static Color passenger_leftupper_1_1 = Color.FromArgb(209, 212, 217);       
        public static Color passenger_leftupper_2 = Color.FromArgb(189, 149, 0);
        public static Color passenger_leftupper_3 = Color.FromArgb(169, 69, 9);
        public static Color passenger_leftupper_4 = Color.FromArgb(61, 41, 32);
        public static Color passenger_leftupper_5 = Color.FromArgb(126, 18, 24);

        public static Color passenger_rightupper_1 = Color.FromArgb(13, 163, 50);
        public static Color passenger_rightupper_2 = Color.FromArgb(244, 225, 0);
        public static Color passenger_rightupper_3 = Color.FromArgb(234, 139, 0);

        public static Color passsenger_rightleg_1 = Color.FromArgb(18, 166, 53);
        public static Color passsenger_rightleg_2 = Color.FromArgb(246, 230, 0);
        
        public static Color passenger_leftleg_1 = Color.FromArgb(13, 161, 49);
        public static Color passenger_leftleg_2 = Color.FromArgb(245, 227, 0);        
        public static Color passenger_leftleg_3 = Color.FromArgb(236, 142, 0);

        public int ifelsePassengerHead(Color a)
        {
            if (a == PassengerColorSingle.passenger_head_1)
            {
                return 1;
            }
            if (a == PassengerColorSingle.passenger_head_2)
            {
                return 2;
            }
            return -1;

        }


        public int ifelsePassengerChest(Color a)
        {
            if (a == PassengerColorSingle.passenger_chest_1)
            {
                return 1;
            }
            if (a == PassengerColorSingle.passenger_chest_2)
            {
                return 2;
            }
            if (a == PassengerColorSingle.passenger_chest_3)
            {
                return 3;
            }
            if (a == PassengerColorSingle.passenger_chest_3)
            {
                return 3;
            }
            return -1;
        }

        public int ifelsePassengerLeftUpper(Color a)
        {
            if (a == PassengerColorSingle.passenger_leftupper_1)
            {
                return 1;
            }
            if (a == PassengerColorSingle.passenger_leftupper_1_1)
            {
                return 1;
            }
            if (a == PassengerColorSingle.passenger_leftupper_2)
            {
                return 2;
            }
            if (a == PassengerColorSingle.passenger_leftupper_3)
            {
                return 3;
            }
            if (a == PassengerColorSingle.passenger_leftupper_4)
            {
                return 4;
            }
            if (a == PassengerColorSingle.passenger_leftupper_5)
            {
                return 5;
            }
            return -1;
        }

        public int ifelsePassengerRightUpper(Color a)
        {
            if (a == PassengerColorSingle.passenger_rightupper_1)
            {
                return 1;
            }
            if (a == PassengerColorSingle.passenger_rightupper_2)
            {
                return 2;
            }
            if (a == PassengerColorSingle.passenger_rightupper_3)
            {
                return 3;
            }
            return -1;
        }

        public int ifelsePassengerLeftLeg(Color a)
        {
            if (a == PassengerColorSingle.passenger_leftleg_1)
            {
                return 1;
            }
            if (a == PassengerColorSingle.passenger_leftleg_2)
            {
                return 2;
            }
            if (a == PassengerColorSingle.passenger_leftleg_3)
            {
                return 3;
            }

            return -1;
        }

        public int ifelsePassengerRightLeg(Color a)
        {
            if (a == PassengerColorSingle.passsenger_rightleg_1)
            {
                return 1;
            }
            if (a == PassengerColorSingle.passsenger_rightleg_2)
            {
                return 2;
            }
            return -1;
        }

    }
}
