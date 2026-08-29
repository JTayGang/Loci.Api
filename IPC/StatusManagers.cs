using Dalamud.Plugin;
using LociApi.Api;
using LociApi.Enums;
using LociApi.Helpers;

namespace LociApi.Ipc;

/// <inheritdoc cref="ILociApiStatusManager.GetManager" />
public sealed class GetManager(IDalamudPluginInterface pi) : FuncSubscriber<(int, string?)>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Loci.{nameof(GetManager)}";

    /// <summary> The label as a UTF8 string. </summary>
    public static ReadOnlySpan<byte> LabelU8 => "Loci.GetManager"u8;

    /// <inheritdoc cref="ILociApiStatusManager.GetManager" />
    public new (LociApiEc, string?) Invoke()
    {
        var (ec, s) = base.Invoke();
        return ((LociApiEc)ec, s);
    }

    /// <summary> Create a provider. </summary>
    public static FuncProvider<(int, string?)> Provider(IDalamudPluginInterface pi, ILociApiStatusManager api)
    {
        return new FuncProvider<(int, string?)>(pi, Label, () =>
        {
            var (ec, s) = api.GetManager();
            return ((int)ec, s);
        });
    }
}

/// <inheritdoc cref="ILociApiStatusManager.GetManagerByPtr" />
public sealed class GetManagerByPtr(IDalamudPluginInterface pi) : FuncSubscriber<nint, (int, string?)>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Loci.{nameof(GetManagerByPtr)}";

    /// <summary> The label as a UTF8 string. </summary>
    public static ReadOnlySpan<byte> LabelU8 => "Loci.GetManagerByPtr"u8;

    /// <inheritdoc cref="ILociApiStatusManager.GetManagerByPtr" />
    public new (LociApiEc, string?) Invoke(nint address)
    {
        var (ec, s) = base.Invoke(address);
        return ((LociApiEc)ec, s);
    }

    /// <summary> Create a provider. </summary>
    public static FuncProvider<nint, (int, string?)> Provider(IDalamudPluginInterface pi, ILociApiStatusManager api)
    {
        return new FuncProvider<IntPtr, (int, string?)>(pi, Label, a =>
        {
            var (ec, s) = api.GetManagerByPtr(a);
            return ((int)ec, s);
        });
    }
}

/// <inheritdoc cref="ILociApiStatusManager.GetManagerByName" />
public sealed class GetManagerByName(IDalamudPluginInterface pi) : FuncSubscriber<string, string, (int, string?)>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Loci.{nameof(GetManagerByName)}";

    /// <summary> The label as a UTF8 string. </summary>
    public static ReadOnlySpan<byte> LabelU8 => "Loci.GetManagerByName"u8;

    /// <inheritdoc cref="ILociApiStatusManager.GetManagerByName" />
    public (LociApiEc, string?) Invoke(string charaNameWorld)
    {
        var (ec, s) = base.Invoke(charaNameWorld, string.Empty);
        return ((LociApiEc)ec, s);
    }


    /// <inheritdoc cref="ILociApiStatusManager.GetManagerByName" />
    public new (LociApiEc, string?) Invoke(string charaName, string buddyName)
    {
        var (ec, s) = base.Invoke(charaName, buddyName);
        return ((LociApiEc)ec, s);
    }

    /// <summary> Create a provider. </summary>
    public static FuncProvider<string, string, (int, string?)> Provider(IDalamudPluginInterface pi, ILociApiStatusManager api)
    {
        return new FuncProvider<string, string, (int, string?)>(pi, Label, (a, b) =>
        {
            var (ec, s) = api.GetManagerByName(a, b);
            return ((int)ec, s);
        });
    }
}

/// <inheritdoc cref="ILociApiStatusManager.GetManagerInfo" />
public sealed class GetManagerInfo(IDalamudPluginInterface pi) : FuncSubscriber<List<LociStatusInfo>>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Loci.{nameof(GetManagerInfo)}";

    /// <summary> The label as a UTF8 string. </summary>
    public static ReadOnlySpan<byte> LabelU8 => "Loci.GetManagerInfo"u8;

    /// <inheritdoc cref="ILociApiStatusManager.GetManagerInfo" />
    public new List<LociStatusInfo> Invoke()
    {
        return base.Invoke();
    }

    /// <summary> Create a provider. </summary>
    public static FuncProvider<List<LociStatusInfo>> Provider(IDalamudPluginInterface pi, ILociApiStatusManager api)
    {
        return new FuncProvider<List<LociStatusInfo>>(pi, Label, api.GetManagerInfo);
    }
}

/// <inheritdoc cref="ILociApiStatusManager.GetManagerInfoByPtr" />
public sealed class GetManagerInfoByPtr(IDalamudPluginInterface pi) : FuncSubscriber<nint, List<LociStatusInfo>>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Loci.{nameof(GetManagerInfoByPtr)}";

    /// <summary> The label as a UTF8 string. </summary>
    public static ReadOnlySpan<byte> LabelU8 => "Loci.GetManagerInfoByPtr"u8;

    /// <inheritdoc cref="ILociApiStatusManager.GetManagerInfoByPtr" />
    public new List<LociStatusInfo> Invoke(nint ptr)
    {
        return base.Invoke(ptr);
    }

    /// <summary> Create a provider. </summary>
    public static FuncProvider<nint, List<LociStatusInfo>> Provider(IDalamudPluginInterface pi, ILociApiStatusManager api)
    {
        return new FuncProvider<IntPtr, List<LociStatusInfo>>(pi, Label, api.GetManagerInfoByPtr);
    }
}

/// <inheritdoc cref="ILociApiStatusManager.GetManagerInfoByName" />
public sealed class GetManagerInfoByName(IDalamudPluginInterface pi) : FuncSubscriber<string, string, List<LociStatusInfo>>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Loci.{nameof(GetManagerInfoByName)}";

    /// <summary> The label as a UTF8 string. </summary>
    public static ReadOnlySpan<byte> LabelU8 => "Loci.GetManagerInfoByName"u8;

    /// <inheritdoc cref="ILociApiStatusManager.GetManagerInfoByName" />
    public List<LociStatusInfo> Invoke(string charaNameWorld)
    {
        return base.Invoke(charaNameWorld, string.Empty);
    }

    /// <inheritdoc cref="ILociApiStatusManager.GetManagerInfoByName" />
    public new List<LociStatusInfo> Invoke(string charaName, string buddyName)
    {
        return base.Invoke(charaName, buddyName);
    }

    /// <summary> Create a provider. </summary>
    public static FuncProvider<string, string, List<LociStatusInfo>> Provider(IDalamudPluginInterface pi, ILociApiStatusManager api)
    {
        return new FuncProvider<string, string, List<LociStatusInfo>>(pi, Label, api.GetManagerInfoByName);
    }
}

/// <inheritdoc cref="ILociApiStatusManager.GetStatusExpiresAtByPtr" />
public sealed class GetStatusExpiresAtByPtr(IDalamudPluginInterface pi) : FuncSubscriber<nint, List<(Guid GUID, long ExpiresAtMs)>>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Loci.{nameof(GetStatusExpiresAtByPtr)}";

    /// <summary> The label as a UTF8 string. </summary>
    public static ReadOnlySpan<byte> LabelU8 => "Loci.GetStatusExpiresAtByPtr"u8;

    /// <inheritdoc cref="ILociApiStatusManager.GetStatusExpiresAtByPtr" />
    public new List<(Guid GUID, long ExpiresAtMs)> Invoke(nint ptr)
    {
        return base.Invoke(ptr);
    }

    /// <summary> Create a provider. </summary>
    public static FuncProvider<nint, List<(Guid GUID, long ExpiresAtMs)>> Provider(IDalamudPluginInterface pi, ILociApiStatusManager api)
    {
        return new FuncProvider<IntPtr, List<(Guid GUID, long ExpiresAtMs)>>(pi, Label, api.GetStatusExpiresAtByPtr);
    }
}

/// <inheritdoc cref="ILociApiStatusManager.SetManager" />
public sealed class SetManager(IDalamudPluginInterface pi) : FuncSubscriber<string, int>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Loci.{nameof(SetManager)}";

    /// <summary> The label as a UTF8 string. </summary>
    public static ReadOnlySpan<byte> LabelU8 => "Loci.SetManager"u8;

    /// <inheritdoc cref="ILociApiStatusManager.SetManager" />
    public new LociApiEc Invoke(string base64Data)
    {
        return (LociApiEc)base.Invoke(base64Data);
    }

    /// <summary> Create a provider. </summary>
    public static FuncProvider<string, int> Provider(IDalamudPluginInterface pi, ILociApiStatusManager api)
    {
        return new FuncProvider<string, int>(pi, Label, a => (int)api.SetManager(a));
    }
}

/// <inheritdoc cref="ILociApiStatusManager.SetManagerByPtr" />
public sealed class SetManagerByPtr(IDalamudPluginInterface pi) : FuncSubscriber<nint, string, int>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Loci.{nameof(SetManagerByPtr)}";

    /// <summary> The label as a UTF8 string. </summary>
    public static ReadOnlySpan<byte> LabelU8 => "Loci.SetManagerByPtr"u8;

    /// <inheritdoc cref="ILociApiStatusManager.SetManagerByPtr" />
    public new LociApiEc Invoke(nint address, string base64Data)
    {
        return (LociApiEc)base.Invoke(address, base64Data);
    }

    /// <summary> Create a provider. </summary>
    public static FuncProvider<nint, string, int> Provider(IDalamudPluginInterface pi, ILociApiStatusManager api)
    {
        return new FuncProvider<IntPtr, string, int>(pi, Label, (a, b) => (int)api.SetManagerByPtr(a, b));
    }
}

/// <inheritdoc cref="ILociApiStatusManager.SetManagerByName" />
public sealed class SetManagerByName(IDalamudPluginInterface pi) : FuncSubscriber<string, string, string, int>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Loci.{nameof(SetManagerByName)}";

    /// <summary> The label as a UTF8 string. </summary>
    public static ReadOnlySpan<byte> LabelU8 => "Loci.SetManagerByName"u8;

    /// <inheritdoc cref="ILociApiStatusManager.SetManagerByName" />
    public LociApiEc Invoke(string charaNameWorld, string base64Data)
    {
        return (LociApiEc)base.Invoke(charaNameWorld, string.Empty, base64Data);
    }

    /// <inheritdoc cref="ILociApiStatusManager.SetManagerByName" />
    public new LociApiEc Invoke(string charaName, string buddyName, string base64Data)
    {
        return (LociApiEc)base.Invoke(charaName, buddyName, base64Data);
    }

    /// <summary> Create a provider. </summary>
    public static FuncProvider<string, string, string, int> Provider(IDalamudPluginInterface pi, ILociApiStatusManager api)
    {
        return new FuncProvider<string, string, string, int>(pi, Label, (a, b, c) => (int)api.SetManagerByName(a, b, c));
    }
}

/// <inheritdoc cref="ILociApiStatusManager.ClearManager" />
public sealed class ClearManager(IDalamudPluginInterface pi) : FuncSubscriber<int>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Loci.{nameof(ClearManager)}";

    /// <summary> The label as a UTF8 string. </summary>
    public static ReadOnlySpan<byte> LabelU8 => "Loci.ClearManager"u8;

    /// <inheritdoc cref="ILociApiStatusManager.ClearManager" />
    public new LociApiEc Invoke()
    {
        return (LociApiEc)base.Invoke();
    }

    /// <summary> Create a provider. </summary>
    public static FuncProvider<int> Provider(IDalamudPluginInterface pi, ILociApiStatusManager api)
    {
        return new FuncProvider<int>(pi, Label, () => (int)api.ClearManager());
    }
}

/// <inheritdoc cref="ILociApiStatusManager.ClearManagerByPtr" />
public sealed class ClearManagerByPtr(IDalamudPluginInterface pi) : FuncSubscriber<nint, int>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Loci.{nameof(ClearManagerByPtr)}";

    /// <summary> The label as a UTF8 string. </summary>
    public static ReadOnlySpan<byte> LabelU8 => "Loci.ClearManagerByPtr"u8;

    /// <inheritdoc cref="ILociApiStatusManager.ClearManagerByPtr" />
    public new LociApiEc Invoke(nint ptr)
    {
        return (LociApiEc)base.Invoke(ptr);
    }

    /// <summary> Create a provider. </summary>
    public static FuncProvider<nint, int> Provider(IDalamudPluginInterface pi, ILociApiStatusManager api)
    {
        return new FuncProvider<IntPtr, int>(pi, Label, a => (int)api.ClearManagerByPtr(a));
    }
}

/// <inheritdoc cref="ILociApiStatusManager.ClearManagerByName" />
public sealed class ClearManagerByName(IDalamudPluginInterface pi) : FuncSubscriber<string, string, int>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Loci.{nameof(ClearManagerByName)}";

    /// <summary> The label as a UTF8 string. </summary>
    public static ReadOnlySpan<byte> LabelU8 => "Loci.ClearManagerByName"u8;

    /// <inheritdoc cref="ILociApiStatusManager.ClearManagerByName" />
    public LociApiEc Invoke(string charaNameWorld)
    {
        return (LociApiEc)base.Invoke(charaNameWorld, string.Empty);
    }

    /// <inheritdoc cref="ILociApiStatusManager.ClearManagerByName" />
    public new LociApiEc Invoke(string charaName, string buddyName)
    {
        return (LociApiEc)base.Invoke(charaName, buddyName);
    }

    /// <summary> Create a provider. </summary>
    public static FuncProvider<string, string, int> Provider(IDalamudPluginInterface pi, ILociApiStatusManager api)
    {
        return new FuncProvider<string, string, int>(pi, Label, (a, b) => (int)api.ClearManagerByName(a, b));
    }
}

/// <inheritdoc cref="ILociApiStatusManager.ConvertLegacyData" />
public sealed class ConvertLegacyData(IDalamudPluginInterface pi) : FuncSubscriber<string, string>(pi, Label)
{
    /// <summary> The label. </summary>
    public const string Label = $"Loci.{nameof(ConvertLegacyData)}";

    /// <summary> The label as a UTF8 string. </summary>
    public static ReadOnlySpan<byte> LabelU8 => "Loci.ConvertLegacyData"u8;

    /// <inheritdoc cref="ILociApiStatusManager.ConvertLegacyData" />
    public new string Invoke(string legacyData)
        => base.Invoke(legacyData);

    /// <summary> Create a provider. </summary>
    public static FuncProvider<string, string> Provider(IDalamudPluginInterface pi, ILociApiStatusManager api)
        => new(pi, Label, api.ConvertLegacyData);
}

/// <inheritdoc cref="ILociApiStatusManager.ManagerChanged" />
public static class ManagerChanged
{
    /// <summary> The label. </summary>
    public const string Label = $"Loci.{nameof(ManagerChanged)}";

    /// <summary> The label as a UTF8 string. </summary>
    public static ReadOnlySpan<byte> LabelU8 => "Loci.ManagerChanged"u8;

    /// <summary> Create a new event subscriber. </summary>
    public static EventSubscriber<nint, ManagerChangeType> Subscriber(IDalamudPluginInterface pi, params Action<nint, ManagerChangeType>[] actions)
        => new(pi, Label, actions);

    /// <summary> Create a provider. </summary>
    public static EventProvider<nint, ManagerChangeType> Provider(IDalamudPluginInterface pi, ILociApiStatusManager api)
        => new(pi, Label, (t => api.ManagerChanged += t, t => api.ManagerChanged -= t));
}

/// <inheritdoc cref="ILociApiStatusManager.ApplyToTargetSent" />
public static class ApplyToTargetSent
{
    /// <summary> The label. </summary>
    public const string Label = $"Loci.{nameof(ApplyToTargetSent)}";

    /// <summary> The label as a UTF8 string. </summary>
    public static ReadOnlySpan<byte> LabelU8 => "Loci.ApplyToTargetSent"u8;

    /// <summary> Create a new event subscriber. </summary>
    public static EventSubscriber<nint, string, List<LociStatusInfo>> Subscriber(IDalamudPluginInterface pi, params Action<nint, string, List<LociStatusInfo>>[] actions)
        => new(pi, Label, actions);

    /// <summary> Create a provider. </summary>
    public static EventProvider<nint, string, List<LociStatusInfo>> Provider(IDalamudPluginInterface pi, ILociApiStatusManager api)
        => new(pi, Label, t => api.ApplyToTargetSent += t.Invoke, t => api.ApplyToTargetSent -= t.Invoke);
}
