public class Experiment
{
    public static void runExp()
    {
        for (int n=1000; n<10000; n+=2000)
        {
            //Generate a dataset of size n
            //You may need to declare a 2D array of size [25,3] to capture Datasets, Experiment Number, Seconds

            Console.WriteLine("::Experiment for Dataset {0}::", n);
            for (int exp=1; exp<6; exp++)
            {
                Console.WriteLine("Running Experiment Number "+exp);
                //get your experiment run here!
                //Use timestamp here to capture start and end time.
            }
        }
       
    }
}

//©Zairul Mazwan©