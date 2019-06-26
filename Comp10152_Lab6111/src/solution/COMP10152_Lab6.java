package solution;

import battleship.BattleShip;

/**
 * Starting code for Comp10152 - Lab#6
 *
 * @author mark.yendt
 */
public class COMP10152_Lab6 {

    // Instructions :
    // Add your name(s) to the top of the code 
    
    // Change NUMBEROFGAMES to 1 for debugging, but set to 10000 for hand-in
    
    // -----------------------------------------------------------------------------
    // DO NOT ADD ANY CODE here - All of your code should be in the MySolution class
    // -----------------------------------------------------------------------------
    
    static final int NUMBEROFGAMES = 10000; // Needs to be 10000 at HAND-IN time
    
    public static void main(String[] args)
    {
        int totalShots = 0;
        System.out.println(BattleShip.version());
        System.out.println("Solution submitted by [ Dujin Kim 000308351 ]\n");
        long startTime = System.nanoTime();
        
        
        for (int game = 0; game < NUMBEROFGAMES; game++) 
        {
            BattleShip battleShip = new BattleShip();
            MySolution solution = new MySolution(battleShip);

            
            while (!battleShip.allSunk()) 
            {
                solution.fireShot();
            }
            
            int gameShots = battleShip.totalShotsTaken();
            totalShots += gameShots;
            
            
           //solution.showingBoard();// call the method
           //System.out.println();   // print line
            
        }
        
        // Leave these measurements 
        long time = System.nanoTime() - startTime;
        System.out.printf("My Solution - The Average # of Shots required in %d games to sink all Ships = %.2f\n", NUMBEROFGAMES, (double) totalShots / NUMBEROFGAMES);
        System.out.printf("Time to solve %d games = %d ms\n", NUMBEROFGAMES, time / 1000000);
    }   
}