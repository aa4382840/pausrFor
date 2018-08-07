namespace nMessage {
	public class cMessage : nMessage.cMessageBase {
		public cMessage(object message) {
			System.Console.Write(message);

			System.Console.WriteLine(Suffix);
		}
	}
}