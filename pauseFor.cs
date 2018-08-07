namespace Main {
	public class PauseFor : object {
		public static void Main() {
			try {
				new nMessage.cMessage(@"Starting ...");

				new nPause.cPause();
			} catch(System.Exception e) {
				new nMessage.cMessage(e);
			} finally {
				new nMessage.cMessage(@"Exiting ...");
			}
		}
	}
}