﻿using MHR_Editor.Common.Models;

namespace MHR_Editor.Generator.Models {
    public class StructType {
        public readonly string     name;
        public readonly string     hash;
        public readonly StructJson structInfo;
        public          int        useCount;

        public StructType(string name, string hash, StructJson structInfo) {
            this.name       = name;
            this.hash       = hash;
            this.structInfo = structInfo;
        }

        public void UpdateUsingCounts() {
            // ReSharper disable once ForeachCanBePartlyConvertedToQueryUsingAnotherGetEnumerator
            foreach (var field in structInfo.fields!) {
                if (field.name == null) continue;
                var enumType = field.GetEnumType(); // No discernible difference between struct and enum here.
                if (enumType == null) continue;
                if (Program.STRUCT_TYPES.ContainsKey(enumType)) {
                    Program.STRUCT_TYPES[enumType].useCount++;
                    Program.STRUCT_TYPES[enumType].UpdateUsingCounts();
                }
                if (Program.ENUM_TYPES.ContainsKey(enumType)) {
                    Program.ENUM_TYPES[enumType].useCount++;
                }
            }
        }
    }
}