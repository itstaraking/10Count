// This program uses a loop to count from 1 - 10
package com.company;

public class Main {

    public static void main(String[] args) {
	// call count method
        Count();
    }

    /**
     * The Count Method uses a loop to count from 1 -10
     */
    public static void Count()
    {
        int maxValue = 10; // this is the end value

        // set the for loop
        for(int num = 1; num <= maxValue; num++)
        {
            System.out.print(num);
        }

    }

}
