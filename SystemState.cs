namespace Dargon {
   public interface SystemState {
      string Get(string key, string defaultValue);
      void Set(string key, string value);

      bool GetBoolean(string key, bool defaultValue);
      void SetBoolean(string key, bool value);
   }
}
