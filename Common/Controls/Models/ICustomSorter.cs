﻿using System.Collections;
using System.ComponentModel;

namespace MHR_Editor.Common.Controls.Models;

public interface ICustomSorter : IComparer {
    ListSortDirection SortDirection { get; set; }
}

public interface ICustomSorterWithPropertyName : ICustomSorter {
    string PropertyName { get; set; }
}