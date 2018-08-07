namespace nPause {
	public class cPause : nPause.cPauseBase {
		public cPause() {
			new nMessage.cMessage(
				@"Pausing for " + Seconds + @" Seconds"
			);

			System.Threading.Thread.Sleep(
				MilliSeconds
			);
		}
	}
}