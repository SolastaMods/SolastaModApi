namespace ReflectionBindingGenerator
{
    public class FieldInfo
    {
        public TypeInfo ContainingType { get; private set; }
        public string FieldType { get; private set; }
        public string FieldName { get; private set; }
        public FieldInfo(TypeInfo containingType, string fieldType, string fieldName)
        {
            ContainingType = containingType;
            FieldType = fieldType;
            FieldName = fieldName;
        }
    }
}
