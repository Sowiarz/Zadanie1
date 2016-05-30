using System;

namespace Application
{
	public class EquipModel
	{
		
		public EquipModel (string serialNumber, float[] inputs,  float[] outputs, string type, string model)
		{
			serialNumber = Hardware.GetSerial();
			inputs = Hardware.ReadInputs ();
			outputs = Hardware.ReadOutputs();
			type = serialNumber.Substring(0, 4);
			model = serialNumber.Substring (4, 4);
		}
		public void ShowDetails(EquipModel em){
			Cosnole.WriteLine ("Serial Number:");
			Console.WriteLine (em.serialNumber);

			Cosnole.WriteLine ("Inputs:");
			Console.WriteLine (em.inputs.ToString());

			Cosnole.WriteLine ("Outputs:");
			Console.WriteLine (em.uotputs.ToString());

			Cosnole.WriteLine ("Type:");
			Console.WriteLine (em.type);

			Cosnole.WriteLine ("Model:");
			Console.WriteLine (em.model);
		}
		public void SetOutputs(EquipModel em){
			float[] newTable = SetOut ();
			em.SetOutputs = Hardware.SetOutputs(newTable);
		}
		public float[] SetOut (){
			float[] table;
			int size;

			Console.WriteLine("Set Leght:");
			size = int.Parse(Console.ReadLine());
			tablica = new int[size];

			for (int i = 0; i < size; i++)
			{
				Console.WriteLine("Set {0} element of table: ", i);
				table[i] = int.Parse(Console.ReadLine());
			}
				
			return table;
		}
	}
}

