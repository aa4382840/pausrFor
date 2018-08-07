namespace nPause {
	public class cPause : object {
		public cPause() {
			new nMessage.cMessage(@"Pausing for " + System.Environment.GetCommandLineArgs()[1] + @" Seconds ...");

			System.Threading.Thread.Sleep(
				MilliSeconds
			);
		}

		private int MilliSeconds {
			get {
				return
					System.Convert.ToInt32(System.Environment.GetCommandLineArgs()[1]) * 1000
				;
			}
		}
	}
}