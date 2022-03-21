using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal static class GAMECONTROL
    {
        public static int player=0;
        public static int player1wincount = 0;
        public static int player2wincount = 0;
        public static int[,] arr = new int[3, 3] {
        {0, 0, 0} ,
        {0, 0, 0} ,
        {0, 0, 0}};

        public static void switchPlayer()
        {
            GAMECONTROL.player = (GAMECONTROL.player) ^ 1;
        }

        
        

        public static int checkWinState()
        {
           for(int i = 0; i < 3; i++)
            {
                int temp1 = 0;
                int temp2 = 0;
                
                for(int j = 0; j < 3; j++)
                {
                    if (GAMECONTROL.arr[i,j] == 1)
                    {
                        temp1++;
                        
                    }
                    if(GAMECONTROL.arr[i, j] == 2)
                    {
                        temp2++;

                    }


                }
                if (temp1 == 3 || temp2==3 )
                {
                    return 1;
                }
                
            }
            for (int i = 0; i < 3; i++)
            {
                int temp2 = 0;
                int temp1 = 0;

                for (int j = 0; j < 3; j++)
                {
                    
                    if (GAMECONTROL.arr[j, i] == 1)
                    {
                        temp2++;
                        
                    }
                    if (GAMECONTROL.arr[j, i] == 2)
                    {
                        temp1++;

                    }
                }
                if (temp2 == 3 || temp1==3)
                {
                    return 1;
                }

            }


            if (GAMECONTROL.arr[0,0]==1 && GAMECONTROL.arr[1,1]==1 && GAMECONTROL.arr[2,2] == 1)
            {
                
                return 1;
            }
            if (GAMECONTROL.arr[0, 0] == 2 && GAMECONTROL.arr[1, 1] == 2 && GAMECONTROL.arr[2, 2] == 2)
            {

                return 1;
            }
            if (GAMECONTROL.arr[0,2]==1 && GAMECONTROL.arr[1,1]==1 && GAMECONTROL.arr[2,0] == 1)
            {
                return 1;
            }
            if (GAMECONTROL.arr[0, 2] == 2 && GAMECONTROL.arr[1, 1] == 2 && GAMECONTROL.arr[2, 0] == 2)
            {
                return 1;
            }
            int temp3 = 0;
           for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if (GAMECONTROL.arr[i, j] !=0)
                    {
                        temp3++;
                    }
                }
            }
            if (temp3 == 9)
            {
                return 2;
            }
            return 0;


           
           
        }

        public static void clearBoard()
        {
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    GAMECONTROL.arr[i, j] = 0;
                }
            }
        }
    }
}
