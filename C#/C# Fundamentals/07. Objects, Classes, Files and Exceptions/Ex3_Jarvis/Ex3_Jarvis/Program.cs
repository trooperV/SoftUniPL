using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_Jarvis
{
    public class Robot
    {
        public List<Head> Heads { get; set; }
        public List<Arms> Arms { get; set; }
        public List<Legs> Legs { get; set; }
        public List<Torso> Torsos { get; set; }
    }
    public class Head
    {
        public int EnergyConsumption { get; set; }
        public int IQ { get; set; }
        public string Material { get; set; }
    }
    public class Torso
    {
        public int EnergyConsumption { get; set; }
        public decimal ProcessorSize { get; set; }
        public string Material { get; set; }
    }
    public class Arms
    {
        public int EnergyConsumption { get; set; }
        public int ArmsLenght { get; set; }
        public int CountFingers { get; set; }
    }
    public class Legs
    {
        public int EnergyConsumption { get; set; }
        public int Strenght { get; set; }
        public int Speed { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            long totalEnergy = long.Parse(Console.ReadLine());
            Robot robot = new Robot();
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "Assemble!") break;

                string part = input[0];
                int currEnergyCons = int.Parse(input[1]);

                switch (part)
                {
                    case "Head":
                        Head currentHead = new Head();
                        currentHead.EnergyConsumption = currEnergyCons;
                        currentHead.IQ = int.Parse(input[2]);
                        currentHead.Material = input[3];
                        if (robot.Heads == null)
                            robot.Heads = new List<Head>();
                        robot.Heads.Add(currentHead);
                        break;
                    case "Torso":
                        Torso currentTorso = new Torso();
                        currentTorso.EnergyConsumption = currEnergyCons;
                        currentTorso.ProcessorSize = decimal.Parse(input[2]);
                        currentTorso.Material = input[3];
                        if (robot.Torsos == null)
                            robot.Torsos = new List<Torso>();
                        robot.Torsos.Add(currentTorso);
                        break;
                    case "Arm":
                        Arms currArm = new Arms();
                        currArm.EnergyConsumption = currEnergyCons;
                        currArm.ArmsLenght = int.Parse(input[2]);
                        currArm.CountFingers = int.Parse(input[3]);
                        if (robot.Arms == null)
                            robot.Arms = new List<Arms>();
                        robot.Arms.Add(currArm);
                        break;
                    case "Leg":
                        Legs currLeg = new Legs();
                        currLeg.EnergyConsumption = currEnergyCons;
                        currLeg.Strenght = int.Parse(input[2]);
                        currLeg.Speed = int.Parse(input[3]);
                        if (robot.Legs == null)
                            robot.Legs = new List<Legs>();
                        robot.Legs.Add(currLeg);
                        break;
                }
            }
                if (robot.Arms == null)
                    robot.Arms = new List<Arms>();
                if (robot.Legs == null)
                    robot.Legs = new List<Legs>();
                if (robot.Heads == null)
                    robot.Heads = new List<Head>();
                if (robot.Torsos == null)
                    robot.Torsos = new List<Torso>();

                if (robot.Arms.Count >= 2 && robot.Heads.Count >= 1 &&
                    robot.Legs.Count >= 2 && robot.Torsos.Count >= 1)
                {
                    long consumedEnergy =
                          robot.Arms.OrderBy(x => x.EnergyConsumption).First().EnergyConsumption +
                          robot.Arms.OrderBy(x => x.EnergyConsumption).Skip(1).Take(1).First().EnergyConsumption +
                          robot.Legs.OrderBy(x => x.EnergyConsumption).First().EnergyConsumption +
                          robot.Legs.OrderBy(x => x.EnergyConsumption).Skip(1).Take(1).First().EnergyConsumption +
                          robot.Heads.OrderBy(x => x.EnergyConsumption).First().EnergyConsumption +
                          robot.Torsos.OrderBy(x => x.EnergyConsumption).First().EnergyConsumption;

                    if (consumedEnergy > totalEnergy)
                    {
                        Console.WriteLine("We need more power!");
                    }
                    else
                    {
                        Console.WriteLine("Jarvis:");
                        foreach (var item in robot.Heads.OrderBy(x => x.EnergyConsumption).Take(1))
                        {
                            Console.WriteLine($"#Head:");
                            Console.WriteLine($"###Energy consumption: {item.EnergyConsumption}");
                            Console.WriteLine($"###IQ: {item.IQ}");
                            Console.WriteLine($"###Skin material: {item.Material}");
                        }
                        foreach (var item in robot.Torsos.OrderBy(x => x.EnergyConsumption).Take(1))
                        {
                            Console.WriteLine($"#Torso:");
                            Console.WriteLine($"###Energy consumption: {item.EnergyConsumption}");
                            Console.WriteLine($"###Processor size: {item.ProcessorSize:f1}");
                            Console.WriteLine($"###Corpus material: {item.Material}");
                        }
                        foreach (var item in robot.Arms.OrderBy(x => x.EnergyConsumption)
                            .Take(2))
                        {
                            Console.WriteLine($"#Arm:");
                            Console.WriteLine($"###Energy consumption: {item.EnergyConsumption}");
                            Console.WriteLine($"###Reach: {item.ArmsLenght}");
                            Console.WriteLine($"###Fingers: {item.CountFingers}");
                        }
                        foreach (var item in robot.Legs.OrderBy(x => x.EnergyConsumption)
                            .Take(2))
                        {
                            Console.WriteLine($"#Leg:");
                            Console.WriteLine($"###Energy consumption: {item.EnergyConsumption}");
                            Console.WriteLine($"###Strength: {item.Strenght}");
                            Console.WriteLine($"###Speed: {item.Speed}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("We need more parts!");
                }
            
        }
    }
}
