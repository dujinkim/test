package solution;

import java.awt.Point;
import java.util.ArrayDeque;
import java.util.Queue;
import java.util.Random;
import battleship.*;
import java.util.LinkedList;


/**
 * A Sample random shooter - Takes no precaution on double shooting and has no
 * strategy once a ship is hit.
 *
 * @author mark.yendt@mohawkcollege.ca
 * 
 * Dujin Kim 000308351 
 */


public class MySolution 
{
    private int gameSize;
    private BattleShip battleShip;
    private final Random random;
    private CellState map[][];
    
    
    Queue<Point> shotPoint1 = new ArrayDeque<>(); // save the shot point
    LinkedList<Point> triedPoint = new LinkedList<>(); // save the tried shot point
    
    // Point[] shotPoint2 = {}; // save the point hit the ship 
    
    
    public MySolution(BattleShip b) 
    {
        battleShip = b;
        gameSize = b.BOARDSIZE;
        random = new Random();
        map = new CellState[gameSize][gameSize];
        for (int x = 0; x < gameSize; x++) 
        {
            for (int y = 0; y < gameSize; y++) 
            {
                map[x][y] = CellState.Empty;
            }
        }
    }

  
    
    
    
/**
 * 
 * @return boolean hit
 */    
    public boolean fireShot() 
    {       
            int a = random.nextInt(gameSize);
            int b = random.nextInt(gameSize);
            boolean hit = false;
            Point shot = new Point(a, b);
            
            //LinkedList<Point> shotPoint1 = new LinkedList<>();
            
            for (int x = 0; x < gameSize; x++) 
            {
                for (int y = x % 3; y < gameSize; y += 3) // 3 intervals (the stretagy)
                { 
                    shotPoint1.add(new Point(x, y));    // add to the point
                }
            }


            if (!battleShip.allSunk())  // save the point that we want to shot (2 intervals)
            {
                for (int x = 0; x < gameSize; x++) 
                {
                    for (int y = 0; y < gameSize; y+=2) 
                    {
                        if(map[x][y] == CellState.Empty) // when the point is empty
                            shotPoint1.add(new Point(x, y)); // add the point

                        else        // otherwise, save next point 
                            shotPoint1.add(new Point(x, y + 1));   
                        
                        /*if (map[shot.x][shot.y] != CellState.Empty)
                         shot = shotPoint1.poll(); */ // test
                    }
                }
            }

            
            /*
            for (int x = 0; x < gameSize; x++) 
            {
                for (int y = 0; y < gameSize; y+) 
                {
                     if (map[shot.x][shot.y] != CellState.Empty)
                         shot = shotPoint1.poll(); 
                }
            }
              */
            
            
            do  // do while loop is the most and efficient 
            {      
                shot = shotPoint1.poll();   // shot
            } while (map[shot.x][shot.y] != CellState.Empty);  
            
            
            
            
            triedPoint.add(shot);//add the tried point

            hit = battleShip.shoot(shot); // shot
         
            
            
        //Point a = shot.x;
        //Point b = shot.y;
            
            if (hit == true) // if shot is hit
            {
                mission(shot.x, shot.y, hit); // call function ( mission all kill ships )
                map[shot.x][shot.y] = CellState.Hit;//add the hit point
            } 
            else 
            {
                map[shot.x][shot.y] = CellState.Miss; //otherwise, add the missing point
            }
            
        return hit;
    }



    
    
/**
 * @param integer x
 * @param integer y
 * @param boolean hit
 * @return boolean hit
 */
    public boolean mission(int x, int y, boolean hit) 
    {
        if (battleShip.allSunk()) // if battle ships are all sunk, don't call the reculsive method anymore.
        {
            hit = false;
            return hit;
        }
        
        Point shot = new Point(x, y); //the tried point
        int shipNumA = 0; // the ship number counter
        int shipNumZ = 0; // the ship number counter
        
        
        
        if (triedPoint.contains(shot) == false) //if the tried point is false
        {
            triedPoint.add(shot);               //save the new point
            
            shipNumA = battleShip.numberOfShipsSunk();// before shot, ship number 
            hit = battleShip.shoot(shot);             // shot
            shipNumZ = battleShip.numberOfShipsSunk();// after shot, ship number  
        }
        
        if (hit == false && map[x][y] == CellState.Empty)   // when it's not hit and empty, 
   {
            map[x][y] = CellState.Miss;// miss point
            return false;
        }
        
        
        if (map[x][y] == CellState.Empty) // if it's still empty,
   {
           
            map[x][y] = CellState.Hit;  // hit point 
            
            //if the ship is still not sunked     ( use the recursion of the function )
            if (y - 1 >= 0 && shipNumA == shipNumZ) 
            {
                mission( x, y - 1, hit);//shot to the down point    
            }
            
            if (y + 1 < gameSize && shipNumA == shipNumZ) 
            {
                mission( x, y + 1 , hit);//shot to the up point
            }
            
            if (x - 1 >= 0 && shipNumA == shipNumZ) 
            {
                mission( x - 1, y , hit);//shot to the left point
            }
            
            if (x + 1 < gameSize && shipNumA == shipNumZ) 
            {
                mission( x + 1, y , hit);//shot to the right point
            }   
            
        }
        
    return hit;
    }
       
    
    
    
    
    
    
/*
 *  function for printing the result on the map 
 */
    public void showingBoard()    
    {
        for (int x = 0; x < gameSize; x++) 
   {
            for (int y = 0; y < gameSize; y++) 
            {
                System.out.print(" " + map[x][y] + " ");    // print board
            }
            System.out.println();
        }
        System.out.println();
    }
}
