namespace Main {
	public class pauseFor : object {
		public static void Main() {
			System.Threading.Thread.Sleep(
				System.Convert.ToInt32(System.Environment.GetCommandLineArgs()[1]) * 1000
			);
		}
	}
}