using System.Text.Json;

namespace SportsStore.Infrastructure;

public static class SessionExtension {
    public static void SetJson(this ISession session, String key, Object value) {
        session.SetString(key, JsonSerializer.Serialize(value));
    }

    public static T? GetJson<T>(this ISession session, String key) {
        var sessionData = session.GetString(key);
        return sessionData == null ? default(T) : JsonSerializer.Deserialize<T>(sessionData);
    }
}