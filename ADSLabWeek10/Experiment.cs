public class Experiment
{
    public static void runExp()
    {
        for (int n=1000; n<14000; n+=2000)
        {
            //Generate a dataset of size n

            Console.WriteLine("::Experiment for Dataset {0}::", n);
            for (int exp=1; exp<6; exp++)
            {
                Console.WriteLine("Running Experiment Number "+exp);
                //get your experiment run here!
            }
        }
       
    }
}

//©Zairul Mazwan©