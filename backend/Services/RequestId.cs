namespace backend.Services;

public static class RequestId
{
    private const string ItemKey = "request_id";

    public static string GetOrCreate(HttpContext context)
    {
        if (context.Items.TryGetValue(ItemKey, out var existing) && existing is string s && s.Length > 0)
            return s;

        var requestId = Guid.NewGuid().ToString();

        context.Items[ItemKey] = requestId;

        return requestId;
    }
}