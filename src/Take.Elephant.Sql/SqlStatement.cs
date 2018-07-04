namespace Take.Elephant.Sql
{
    public enum SqlStatement
    {
        AlterTableAddColumn,
        AlterTableAlterColumn,
        And,
        Asc,
        ColumnDefinition,
        CreateSchemaIfNotExists,
        CreateTable,
        Delete,
        Desc,
        Equal,
        Exists,
        GetTableColumns,
        Int16IdentityColumnDefinition,
        Int32IdentityColumnDefinition,
        Int64IdentityColumnDefinition,
        IdentityColumnDefinition,
        In,
        Insert,
        InsertOutput,
        InsertWhereNotExists,
        Is,
        IsNot,
        Null,
        NullableColumnDefinition,
        Or,
        PrimaryKeyConstraintDefinition,
        QueryEquals,
        QueryGreatherThen,
        QueryLessThen,
        Select,
        SelectCount,
        SelectCountDistinct,
        SelectSkipTake,
        SelectTop1,
        SelectDistinct,
        SelectDistinctSkipTake,
        TableExists,
        Update,
        Merge,
        OneEqualsOne,
        OneEqualsZero,
        DummyEqualsZero,
        ValueAsColumn,
        Not,
        NotEqual,
        GreaterThan,
        GreaterThanOrEqual,
        LessThan,
        LessThanOrEqual,
        Like,
        MaxLength,
        MergeIncrement
    }
}