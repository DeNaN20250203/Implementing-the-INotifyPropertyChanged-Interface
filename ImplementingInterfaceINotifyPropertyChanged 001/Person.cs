using System.ComponentModel;

namespace ImplementingInterfaceINotifyPropertyChanged_001
{
	/// <summary>
	/// Определяем класс Person, который реализует интерфейс INotifyPropertyChanged
	/// </summary>
	public class Person : INotifyPropertyChanged
	{
		/// <summary>
		/// Закрытое поле для хранения имени
		/// </summary>
		private string? _name;

		/// <summary>
		/// Свойство Name с геттером и сеттером
		/// </summary>
		public string? Name
		{
			get => _name; // Возвращаем текущее значение имени
			set
			{
				_name = value; // Устанавливаем новое значение имени
				// Вызываем событие PropertyChanged, чтобы уведомить об изменении свойства
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
			}
		}

		/// <summary>
		/// Событие, которое срабатывает при изменении свойства
		/// </summary>
		public event PropertyChangedEventHandler? PropertyChanged;
	}
}
