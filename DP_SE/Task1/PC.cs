namespace Task1.PC
{
    public class CPU
    {
        public string? processedData;
        public void ProcessData()
        {
            string? fetchedData = RAM.tempData;
            
            Console.WriteLine("Processing Data by the CPU");
            
            processedData = fetchedData;
            
            Console.WriteLine(processedData);
            
            HDD.storedData = processedData;
        }
    }
    public class RAM
    {
        internal static string? tempData;
        public void StoreData()
        {
            string? fetchedData = HDD.storedData;

            Console.WriteLine("Storing data in the RAM for quick access");
            
            tempData = fetchedData;
            
            Console.WriteLine(tempData);
            
            HDD.storedData = tempData;
        }        
    }
    public class HDD
    {
        public HDD (string? data)
        {
            storedData = data;
        }
        internal static string? storedData;
        public void ReadData()
        {
            Console.WriteLine("Getting data from the HDD");

            if(storedData == null)
                storedData = "DATA";

            Console.WriteLine(storedData);
        }
    }

    public class PC
    {
        public CPU? myCPU;
        public RAM? myRAM;
        public HDD? myHDD;
        public string? Data { get; set; } // Optional
        public void Run()
        {
            myHDD = new HDD(Data);
            myRAM = new RAM();
            myCPU = new CPU();
            myHDD.ReadData();
            myRAM.StoreData();
            myCPU.ProcessData();
        }
    }
}