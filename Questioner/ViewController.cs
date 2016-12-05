using System;

using AppKit;
using Foundation;

namespace Questioner
{
	public partial class ViewController : NSViewController
	{
		public ViewController(IntPtr handle) : base(handle)
		{
		}

		bool kontrola;
		int pocetBodu = 1;
		int cisloLevlu = 1;

		public override void ViewDidLoad()
		{
			game(true);
			base.ViewDidLoad();
			// Do any additional setup after loading the view.
		}

		partial void textsend1(Foundation.NSObject sender)
		{
			game(true);
		}

		partial void textsend2(Foundation.NSObject sender)
		{
			game(false);
		}


		public void game(bool inp)
		{
			if (pocetBodu >= 0)
			{
				if (pocetBodu <= 9)
				{
					if (kontrola == inp)
					{
						pocetBodu = pocetBodu + 1;
					}
					else
					{
						pocetBodu = pocetBodu - 1;
					}
				}
				else
				{
					cisloLevlu = cisloLevlu + 1;
					pocetBodu = 0;
				}
			}
			else
			{
				pocetBodu = 0;
			}

			bod.IntValue = pocetBodu;
			levl.IntValue = cisloLevlu;

			Random rnd = new Random();
			Int32 number1 = rnd.Next(25);
			hodnotaA.IntValue = number1;

			Random rnd2 = new Random();
			Int32 number2 = rnd2.Next(25);
			hodnotaB.IntValue = number2;

			Random operator1 = new Random();
			Int32 randomOperator = operator1.Next(4);



			if (randomOperator % 2 == 1)
			{
				kontrola = true;
				switch (randomOperator)
				{
					case 0:
						operace.StringValue = "+";
						number1 = number1 + number2;
						textvis1.IntValue = number1;
						Random falseAnswer = new Random();
						number2 = falseAnswer.Next(number1 - 10, number1 + 10);
						if (number2 == number1)
						{
							textvis2.IntValue = number2 + 1;
						}
						else
						{
							textvis2.IntValue = number2;
						}
						break;
					case 1:
						operace.StringValue = "-";
						number1 = number1 - number2;
						textvis1.IntValue = number1;
						Random falseAnswer1 = new Random();
						number2 = falseAnswer1.Next(number1 - 10, number1 + 10);
						if (number2 == number1)
						{
							textvis2.IntValue = number2 + 1;
						}
						else
						{
							textvis2.IntValue = number2;
						}
						break;
					case 2:
						operace.StringValue = "*";
						number1 = number1 * number2;
						textvis1.IntValue = number1;
						Random falseAnswer2 = new Random();
						number2 = falseAnswer2.Next(number1 - 10, number1 + 10);
						if (number2 == number1)
						{
							textvis2.IntValue = number2 + 1;
						}
						else
						{
							textvis2.IntValue = number2;
						}
						break;
					case 3:
						operace.StringValue = "/";
						number1 = number1 / number2;
						textvis1.IntValue = number1;
						Random falseAnswer3 = new Random();
						number2 = falseAnswer3.Next(number1 - 10, number1 + 10);
						if (number2 == number1)
						{
							textvis2.IntValue = number2 + 1;
						}
						else
						{
							textvis2.IntValue = number2;
						}
						break;
					default:
						operace.StringValue = "Chyba!";
						break;
				}
			}
			else
			{
				kontrola = false;
				switch (randomOperator)
				{
					case 0:
						operace.StringValue = "+";
						number1 = number1 + number2;
						textvis2.IntValue = number1;
						Random falseAnswer = new Random();
						number2 = falseAnswer.Next(number1 - 10, number1 + 10);
						if (number2 == number1)
						{
							textvis1.IntValue = number2 + 1;
						}
						else
						{
							textvis1.IntValue = number2;
						}
						break;
					case 1:
						operace.StringValue = "-";
						number1 = number1 - number2;
						textvis2.IntValue = number1;
						Random falseAnswer1 = new Random();
						number2 = falseAnswer1.Next(number1 - 10, number1 + 10);
						if (number2 == number1)
						{
							textvis1.IntValue = number2 + 1;
						}
						else
						{
							textvis1.IntValue = number2;
						}
						break;
					case 2:
						operace.StringValue = "*";
						number1 = number1 * number2;
						textvis2.IntValue = number1;
						Random falseAnswer2 = new Random();
						number2 = falseAnswer2.Next(number1 - 10, number1 + 10);
						if (number2 == number1)
						{
							textvis1.IntValue = number2 + 1;
						}
						else
						{
							textvis1.IntValue = number2;
						}
						break;
					case 3:
						operace.StringValue = "/";
						number1 = number1 / number2;
						textvis2.IntValue = number1;
						Random falseAnswer3 = new Random();
						number2 = falseAnswer3.Next(number1 - 10, number1 + 10);
						if (number2 == number1)
						{
							textvis1.IntValue = number2 + 1;
						}
						else
						{
							textvis1.IntValue = number2;
						}
						break;
					default:
						operace.StringValue = "Chyba!";
						break;
				}
			}
		}

		public override NSObject RepresentedObject
		{
			get
			{
				return base.RepresentedObject;
			}
			set
			{
				base.RepresentedObject = value;
				// Update the view, if already loaded.
			}
		}
	}
}
