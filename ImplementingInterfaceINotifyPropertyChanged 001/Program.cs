namespace ImplementingInterfaceINotifyPropertyChanged_001
{
	internal class Program
    {
        static async Task Main(string[] args)
        {
			// Создаем объект класса Person и устанавливаем его имя "Sarah"
			var myClass = new Person { Name = "Sarah" };
			// Выводим текущее имя в консоль
			Console.WriteLine(myClass.Name);

			// Ждем 200 миллисекунд
			await Task.Delay(200);
			// Изменяем имя объекта на "NewName"
			myClass.Name = "NewName";
			// Выводим новое имя в консоль
			Console.WriteLine(myClass.Name);
			Console.WriteLine();
			Console.ReadKey();
        }
    }
}
