using System;
using line;

class Program{
    static void Main(string[] args){
        while (true) {
            Console.WriteLine("Enter the coordinates of the beginning of the segment 'x1 y1 x2 y2' or 'stop' to exit:");
            string? input = Console.ReadLine();
            if (input == "stop") {break;}
            if (input == null) {continue;}
            string[] inputArr = input.Split(' ');
            if (inputArr.Length != 4) {continue;}
            double[] coords = new double[4];
            bool isParsed = true;
            for (int i = 0; i < 4; i++) {
                if (!double.TryParse(inputArr[i], out coords[i])) {
                    isParsed = false;
                    break;
                }
            } 
            if (!isParsed) {continue;}
            
            Segment segment = new Segment(coords[0], coords[1], coords[2], coords[3]);
            Console.WriteLine(segment.ToString() + "\n");
        }
    }
    
}