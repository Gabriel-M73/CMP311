using System;

namespace EventInterface
{
	interface IScrewdriver
	{
		void fastenerType();
        void handleType();
    }
	interface IHammer
	{
		void fastenerType();
        void handleType();
    }
	interface IWrench
	{
		void fastenerType();
		void handleType();
	}

	public class ToolInfo
	{
		string? name;
		string? fastener; // what fastener the tool is used for
		string? handleMaterial;

		public ToolInfo(string newName, string newFastener, string newHandleMat)
		{
			name = newName;
			fastener = newFastener;
			handleMaterial = newHandleMat;
		}

		public string Name
		{
			get { return name;}
			set { name = value;}
		}
		public string Fastener
		{
            get { return fastener; }
            set { fastener = value; }
        }
		public string HandleMaterial
		{
			get { return handleMaterial; }
			set { handleMaterial = value; }
		}

		public override string ToString()
		{
			return "Tool Name: " + Name.ToString() + ", useable on: " + Fastener.ToString() + 
				", handle material: " + HandleMaterial.ToString();
		}
	} // ToolInfo class

	public class Screwdriver : IScrewdriver
	{
		private ToolInfo tool;

		public Screwdriver (string newName, string newFastener, string newHandleMat)
		{
			tool = new ToolInfo (newName, newFastener, newHandleMat);
		}

		void IScrewdriver.fastenerType()
		{
			Console.WriteLine("Screwdriver fastener type: " + tool.Fastener);
		}
		void IScrewdriver.handleType()
		{
			Console.WriteLine("Screwdriver handle material: " + tool.HandleMaterial);
		}

        public override string ToString()
        {
            return tool.ToString();
        }
    } // Screwdriver class

	public class Hammer : IHammer
	{
		private ToolInfo tool;
		
		public Hammer(string newName, string newFastener, string newHandleMat)
        {
            tool = new ToolInfo(newName, newFastener, newHandleMat);
        }

		void IHammer.fastenerType()
		{
            Console.WriteLine("Hammer fastener type: " + tool.Fastener);
        }
		void IHammer.handleType()
		{
            Console.WriteLine("Hammer handle material: " + tool.HandleMaterial);
        }

        public override string ToString()
        {
            return tool.ToString();
        }
    } // Hammer class

	public class Wrench : IWrench
	{
		private ToolInfo tool;

		public Wrench(string newName, string newFastener, string newHandleMat)
        {
            tool = new ToolInfo(newName, newFastener, newHandleMat);
        }

		void IWrench.fastenerType()
		{
            Console.WriteLine("Wrench fastener type: " + tool.Fastener);
        }
		void IWrench.handleType()
		{
            Console.WriteLine("Wrench handle material: " + tool.HandleMaterial);
        }

        public override string ToString()
        {
            return tool.ToString();
        }
    } // Wrench class

	public class Program
	{
		static void Main(string[] args)
		{
			IScrewdriver screwdriver = new Screwdriver("Screwdriver", "screws", "plastic");
			IHammer hammer1 = new Hammer("WHammer", "nails", "wood");
			IHammer hammer2 = new Hammer("RHammer", "nails", "rubber");
			IWrench wrench = new Wrench("Wrench", "nuts and bolts", "steel");

			screwdriver.fastenerType();
			screwdriver.handleType();
			hammer1.fastenerType();
			hammer1.handleType();
			hammer2.fastenerType();
			hammer2.handleType();
			wrench.fastenerType();
			wrench.handleType();

			Console.WriteLine("Screwdriver(s): " + screwdriver + "\n" + "Hammer(s): " + 
				hammer1 + ", " + hammer2 + "\n" + "Wrench(s): " + wrench);
			Console.ReadLine();
		} // Main
	} // Program class
} // namespace	
// commit and push for video