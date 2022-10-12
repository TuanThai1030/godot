using System;

namespace Godot.SourceGenerators
{
    // TODO: May need to think about compatibility here. Could Godot change these values between minor versions?

    internal enum VariantType
    {
        Nil = 0,
        Bool = 1,
        Int = 2,
        Float = 3,
        String = 4,
        Vector2 = 5,
        Vector2i = 6,
        Rect2 = 7,
        Rect2i = 8,
        Vector3 = 9,
        Vector3i = 10,
        Transform2d = 11,
        Vector4 = 12,
        Vector4i = 13,
        Plane = 14,
        Quaternion = 15,
        Aabb = 16,
        Basis = 17,
        Transform3d = 18,
        Projection = 19,
        Color = 20,
        StringName = 21,
        NodePath = 22,
        Rid = 23,
        Object = 24,
        Callable = 25,
        Signal = 26,
        Dictionary = 27,
        Array = 28,
        PackedByteArray = 29,
        PackedInt32Array = 30,
        PackedInt64Array = 31,
        PackedFloat32Array = 32,
        PackedFloat64Array = 33,
        PackedStringArray = 34,
        PackedVector2Array = 35,
        PackedVector3Array = 36,
        PackedColorArray = 37,
        Max = 38
    }

    internal enum PropertyHint
    {
        None = 0,
        Range = 1,
        Enum = 2,
        EnumSuggestion = 3,
        ExpEasing = 4,
        Link = 5,
        Flags = 6,
        Layers2dRender = 7,
        Layers2dPhysics = 8,
        Layers2dNavigation = 9,
        Layers3dRender = 10,
        Layers3dPhysics = 11,
        Layers3dNavigation = 12,
        File = 13,
        Dir = 14,
        GlobalFile = 15,
        GlobalDir = 16,
        ResourceType = 17,
        MultilineText = 18,
        Expression = 19,
        PlaceholderText = 20,
        ColorNoAlpha = 21,
        ImageCompressLossy = 22,
        ImageCompressLossless = 23,
        ObjectId = 24,
        TypeString = 25,
        NodePathToEditedNode = 26,
        MethodOfVariantType = 27,
        MethodOfBaseType = 28,
        MethodOfInstance = 29,
        MethodOfScript = 30,
        PropertyOfVariantType = 31,
        PropertyOfBaseType = 32,
        PropertyOfInstance = 33,
        PropertyOfScript = 34,
        ObjectTooBig = 35,
        NodePathValidTypes = 36,
        SaveFile = 37,
        GlobalSaveFile = 38,
        IntIsObjectid = 39,
        IntIsPointer = 41,
        ArrayType = 40,
        LocaleId = 42,
        LocalizableString = 43,
        NodeType = 44,
        Max = 45
    }

    [Flags]
    internal enum PropertyUsageFlags
    {
        None = 0,
        Storage = 2,
        Editor = 4,
        Checkable = 8,
        Checked = 16,
        Internationalized = 32,
        Group = 64,
        Category = 128,
        Subgroup = 256,
        ClassIsBitfield = 512,
        NoInstanceState = 1024,
        RestartIfChanged = 2048,
        ScriptVariable = 4096,
        StoreIfNull = 8192,
        AnimateAsTrigger = 16384,
        UpdateAllIfModified = 32768,
        ScriptDefaultValue = 65536,
        ClassIsEnum = 131072,
        NilIsVariant = 262144,
        Internal = 524288,
        DoNotShareOnDuplicate = 1048576,
        HighEndGfx = 2097152,
        NodePathFromSceneRoot = 4194304,
        ResourceNotPersistent = 8388608,
        KeyingIncrements = 16777216,
        DeferredSetResource = 33554432,
        EditorInstantiateObject = 67108864,
        EditorBasicSetting = 134217728,
        Array = 536870912,
        Default = 6,
        DefaultIntl = 38,
        NoEditor = 2
    }

    public enum MethodFlags
    {
        Normal = 1,
        Editor = 2,
        Const = 4,
        Virtual = 8,
        Vararg = 16,
        Static = 32,
        ObjectCore = 64,
        Default = 1
    }
}
