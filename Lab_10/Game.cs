using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    public class Game
    {
        Random rnd = new Random();
        public int player;
        public int iu;
        double l;


        public Boolean Start(int graney, Boolean cheat)
        {
            double[] nums_iu = new double[graney+2];
            Boolean player_win = true;
            if (cheat == false)
            {
                int j = graney / 2;
                for (int i = 1; i < j; i++)
                {
                    l = 0.4 / j;
                    l = Math.Round(l, 2);
                    nums_iu[i] = l;

                }

                for (int i = j; i <= graney + 1; i++)
                {
                    l = 0.6 / j;
                    l = Math.Round(l, 2);
                    nums_iu[i] = l;

                }
                double value = rnd.NextDouble();
                Math.Round(value, 2);
                double A = value;
                int k = 0;
                while (A > 0)
                {
                    A = A - nums_iu[k];
                    k++;
                }

                k--;
                iu = k;
            }
            else
            {
                iu = YY(graney);
            }
      

           

            

            player = YY(graney);

            return player_win;
        }

        public string Who_win()
        {
            string who_win = "";
            if (player>iu)
            {
                who_win = "Вы выиграли!";
            }
            else
            {
                if (player==iu)
                {
                    who_win = "Ничья!";
                }
                else
                {
                    who_win = "Вы проиграли!";
                }
            }
            return who_win;
        }

        public int YY(int graney)
        {
            double value = rnd.NextDouble();
            Math.Round(value, 2);
            double A = value;
            int k = 0;
            while (A >= 0)
            {
                l = 0.9 / graney;
                l = Math.Round(l, 2);
                A = A - l;
                k++;
            }

            k--;
            return k;
        }
        
     
    }
}

