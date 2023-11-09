
// double [,] data = ReadWriteFile.genData(4);
// ReadWriteFile.printArray(data);
// ReadWriteFile.writeResult(data);

// Console.WriteLine("Read CSV file to an Array");
// double [,] mstdata = ReadWriteFile.readCSV();
// ReadWriteFile.printArray(mstdata);


double [,] dataset = ReadWriteFile.readCSV();
ReadWriteFile.printArray(dataset);
MST.Prim(dataset);
// int [] mstNodes = MST.Prim(dataset);
// Console.WriteLine("MST Cost : "+MST.getMSTCost(dataset, mstNodes));

//Run Experiments
Experiment.runExp();


//©Zairul Mazwan©
