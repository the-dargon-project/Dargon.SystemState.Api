namespace Dargon {
   public interface SystemState {
      string Get(string key, string defaultValue);
      bool TryGet(string key, out string value);
      void Set(string key, string value);

      bool Get(string key, bool defaultValue);
      bool TryGet(string key, out bool value);
      void Set(string key, bool value);

      int Get(string key, int defaultValue);
      bool TryGet(string key, out int value);
      void Set(string key, int value);
   }
}
