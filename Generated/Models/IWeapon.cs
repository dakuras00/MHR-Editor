﻿using MHR_Editor.Common;
using MHR_Editor.Models.Enums;

namespace MHR_Editor.Generated.Models;

public interface IWeapon {
    public uint                              Id      { get; set; }
    public int                               Atk     { get; set; }
    public string                            Name    { get; }
    public Snow_data_ParamEnum_WeaponModelId ModelId { get; set; }
    public uint                              SortId  { get; set; }

    public Snow_data_ContentsIdSystem_WeaponId GetWeaponEnum() {
        return (Snow_data_ContentsIdSystem_WeaponId) Id;
    }

    public uint GetWeaponId() {
        return Id & BitMasks.ITEM_ID_BIT_MASK;
    }
}