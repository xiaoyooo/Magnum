namespace Magnum.ProtocolBuffers.Mapping
{
    using System;
    using System.Reflection;
    using Serialization;
    using Specs;

    public interface IFieldDescriptor
    {
        string Name { get; }
        int NumberTag { get; }
        FieldRules Rules { get; }
        Type NetType { get; }
        object DefaultValue { get; }
        bool HasDefaultValue { get; }
        PropertyInfo PropertyInfo { get; }
        bool IsRepeated { get; }
        FieldSerializer GenerateFieldSerializer();
    }
}