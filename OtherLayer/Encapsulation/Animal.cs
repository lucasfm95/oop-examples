namespace OtherLayer.Encapsulation
{
	public class Animal
	{
		//constructor
		public Animal()
		{
		}

		//fields
		private string _type;
		private int _age;

		//Properties
		public string Name { get; set; }
		public string Type
		{
			get { return _type; }
			set { _type = value; }
		}

		//methods
		public int GetAge()
		{
			return _age;
		}

		public void SetAge(int age)
		{
			_age = age;
		}

		public void Sleep()
		{
			StartSleep();

			EndSleep();
		}

		private void StartSleep()
		{

		}

		private void EndSleep()
		{

		}
	}
}