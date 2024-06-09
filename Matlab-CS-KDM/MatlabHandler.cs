using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matlab_CS_KDM
{
    public class MatlabHandler
    {
        private const string file = @"\kdm_imie.wav";

        public void callDCTFunction(float treshold, float blockSize)
        {
            // Create the MATLAB instance 
            MLApp.MLApp matlab = new MLApp.MLApp();
            var currentDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            // Change to the directory where the function is located 
            matlab.Execute(@"cd " + currentDirectory + @"\MatlabScripts");
            //Console.WriteLine(currentDirectory);
            // Define the output 
            object result = null;
            
            // Call the MATLAB function myfunc
            //matlab.Feval("myfunc", 2, out result, 3.14, 42.0, "world");
            string audioPath = currentDirectory + file;
            matlab.Feval("myfunc2", 1, out result, audioPath, treshold, currentDirectory, blockSize);

            // Display result 
           
            
        }
    }
}
