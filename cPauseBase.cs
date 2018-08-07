namespace nPause {
	public class cPauseBase : object {

		protected int Seconds {
			get {
				return
					System.Convert.ToInt32(System.Environment.GetCommandLineArgs()[1])
				;
			}
		}

		protected int MilliSeconds {
			get {
				return
					Seconds * 1000
				;
			}
		}
	}
}