namespace AccommodationManagerApp.Util {
    public class InputCheck {
        public bool IsNumber(string input) {
            return int.TryParse(input, out _);
        }
    }
}