﻿using System.Diagnostics.CodeAnalysis;
using MHR_Editor.Common;
using MHR_Editor.Common.Attributes;
using MHR_Editor.Common.Data;
using MHR_Editor.Models.Enums;

namespace MHR_Editor.Models.Structs;

[SuppressMessage("ReSharper", "InconsistentNaming")]
[SuppressMessage("ReSharper", "UnusedMember.Global")]
[SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
[SuppressMessage("ReSharper", "UnusedType.Global")]
public partial class Snow_data_ArmorBaseUserData_Param {
    [SortOrder(50)]
    public string Name => DataHelper.ARMOR_NAME_LOOKUP[Global.locale].TryGet(Id);

    [SortOrder(int.MaxValue)]
    public string Description => DataHelper.ARMOR_DESC_LOOKUP[Global.locale].TryGet(Id);

    public override string ToString() {
        return Name;
    }

    public uint GetArmorType() {
        return Id & BitMasks.ARMOR_TYPE_BIT_MASK;
    }

    public uint GetArmorId() {
        return Id & BitMasks.ARMOR_ID_BIT_MASK;
    }

    public Snow_data_ContentsIdSystem_SubCategoryType GetArmorTypeEnum() {
        return (Snow_data_ContentsIdSystem_SubCategoryType) GetArmorType();
    }
}