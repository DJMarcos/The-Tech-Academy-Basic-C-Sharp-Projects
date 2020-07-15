using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace VariablesAndDataTypes
{
	class Report
	{
		static void Main(string[] args)
		{
			Console.WriteLine("The tech Academy");
			string yourName = Console.ReadLine();
			Console.WriteLine("Your name is : " + yourName);
			Console.ReadLine();

			Console.WriteLine("What course are you on?");
			string CourseName = Console.ReadLine();
			Console.ReadLine();

			Console.WriteLine("What page number?");
			string pageNum = Console.ReadLine();
			Console.ReadLine();

			Console.WriteLine("Do you need help with anythng? Please answer 'True' or 'False'");
			bool AnswerTrue = true;
			bool AnswerFalse = false;

			Console.WriteLine("Where there any positive experiences you'd like to share? Please give specifics");
			string Experiences = Console.ReadLine();

			Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
			string feedback = Console.ReadLine();

			Console.WriteLine("how many hours did you study?");
			int HourStudy = Convert.ToInt32(Console.ReadLine());


			Console.WriteLine("Thank You for your answers. An Instructor will respond to this shortly. Have a great day!");
			Console.ReadLine();

			

		}
	}
}