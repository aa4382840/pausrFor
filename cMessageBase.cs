namespace nMessage {
	public class cMessageBase : object {
		public cMessageBase() {
			System.Console.Title = Title;

			System.Console.ConsoleColor = System.ConsoleColor.Green;

			System.Console.Clear();
		}

		protected string Suffix {
			get {
				return
					@" ..."
				;
			}
		}

		private string Title {
			get {
				return
					System.IO.Path.GetFileNameWithoutExtension(
						System.Environment.GetComandLineArgs()[0]
					)
				;
			}
		}
	}
}